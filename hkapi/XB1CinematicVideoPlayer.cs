using System;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x0200009C RID: 156
public class XB1CinematicVideoPlayer : CinematicVideoPlayer
{
	// Token: 0x0600035C RID: 860 RVA: 0x00012140 File Offset: 0x00010340
	public XB1CinematicVideoPlayer(CinematicVideoPlayerConfig config) : base(config)
	{
		this.originalMainTexture = config.MeshRenderer.material.GetTexture("_MainTex");
		this.renderTexture = new RenderTexture(Screen.width, Screen.height, 0);
		Graphics.Blit((config.FaderStyle == CinematicVideoFaderStyles.White) ? Texture2D.whiteTexture : Texture2D.blackTexture, this.renderTexture);
		this.videoPlayer = config.MeshRenderer.gameObject.AddComponent<VideoPlayer>();
		this.videoPlayer.playOnAwake = false;
		this.videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
		this.videoPlayer.SetTargetAudioSource(0, config.AudioSource);
		this.videoPlayer.renderMode = VideoRenderMode.RenderTexture;
		this.videoPlayer.targetTexture = this.renderTexture;
		config.MeshRenderer.material.SetTexture("_MainTex", this.renderTexture);
		VideoClip embeddedVideoClip = config.VideoReference.EmbeddedVideoClip;
		this.videoPlayer.clip = embeddedVideoClip;
		this.videoPlayer.prepareCompleted += this.OnPrepareCompleted;
		this.videoPlayer.Prepare();
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00012258 File Offset: 0x00010458
	public override void Dispose()
	{
		base.Dispose();
		if (this.videoPlayer != null)
		{
			this.videoPlayer.Stop();
			UnityEngine.Object.Destroy(this.videoPlayer);
			this.videoPlayer = null;
			MeshRenderer meshRenderer = base.Config.MeshRenderer;
			if (meshRenderer != null)
			{
				meshRenderer.material.SetTexture("_MainTex", this.originalMainTexture);
			}
		}
		if (this.renderTexture != null)
		{
			UnityEngine.Object.Destroy(this.renderTexture);
			this.renderTexture = null;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600035E RID: 862 RVA: 0x0000D6F1 File Offset: 0x0000B8F1
	// (set) Token: 0x0600035F RID: 863 RVA: 0x0000D71C File Offset: 0x0000B91C
	public override float Volume
	{
		get
		{
			if (base.Config.AudioSource != null)
			{
				return base.Config.AudioSource.volume;
			}
			return 1f;
		}
		set
		{
			if (base.Config.AudioSource != null)
			{
				base.Config.AudioSource.volume = value;
			}
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000360 RID: 864 RVA: 0x0000D742 File Offset: 0x0000B942
	public override bool IsLoading
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000361 RID: 865 RVA: 0x000122E1 File Offset: 0x000104E1
	// (set) Token: 0x06000362 RID: 866 RVA: 0x000122FE File Offset: 0x000104FE
	public override bool IsLooping
	{
		get
		{
			return this.videoPlayer != null && this.videoPlayer.isLooping;
		}
		set
		{
			if (this.videoPlayer != null)
			{
				this.videoPlayer.isLooping = value;
			}
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000363 RID: 867 RVA: 0x0001231A File Offset: 0x0001051A
	public override bool IsPlaying
	{
		get
		{
			if (this.videoPlayer != null && this.videoPlayer.isPrepared)
			{
				return this.videoPlayer.isPlaying;
			}
			return this.isPlayEnqueued;
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00012349 File Offset: 0x00010549
	public override void Play()
	{
		if (this.videoPlayer != null && this.videoPlayer.isPrepared)
		{
			this.videoPlayer.Play();
		}
		this.isPlayEnqueued = true;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x00012378 File Offset: 0x00010578
	public override void Stop()
	{
		if (this.videoPlayer != null)
		{
			this.videoPlayer.Stop();
		}
		this.isPlayEnqueued = false;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0001239A File Offset: 0x0001059A
	private void OnPrepareCompleted(VideoPlayer source)
	{
		if (source == this.videoPlayer && this.videoPlayer != null && this.isPlayEnqueued)
		{
			this.videoPlayer.Play();
			this.isPlayEnqueued = false;
		}
	}

	// Token: 0x040002C3 RID: 707
	private VideoPlayer videoPlayer;

	// Token: 0x040002C4 RID: 708
	private Texture originalMainTexture;

	// Token: 0x040002C5 RID: 709
	private RenderTexture renderTexture;

	// Token: 0x040002C6 RID: 710
	private const string TexturePropertyName = "_MainTex";

	// Token: 0x040002C7 RID: 711
	private bool isPlayEnqueued;
}
