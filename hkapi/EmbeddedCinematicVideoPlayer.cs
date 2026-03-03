using System;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x0200006C RID: 108
public abstract class EmbeddedCinematicVideoPlayer : CinematicVideoPlayer
{
	// Token: 0x06000240 RID: 576 RVA: 0x0000D588 File Offset: 0x0000B788
	public EmbeddedCinematicVideoPlayer(CinematicVideoPlayerConfig config) : base(config)
	{
		this.originalMainTexture = config.MeshRenderer.material.GetTexture("_MainTex");
		this.videoPlayer = config.MeshRenderer.gameObject.AddComponent<VideoPlayer>();
		this.videoPlayer.playOnAwake = false;
		this.videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
		this.videoPlayer.SetTargetAudioSource(0, config.AudioSource);
		this.videoPlayer.renderMode = VideoRenderMode.MaterialOverride;
		this.videoPlayer.targetMaterialRenderer = config.MeshRenderer;
		this.videoPlayer.targetMaterialProperty = "_MainTex";
		if (File.Exists(this.GetAbsolutePath()))
		{
			this.videoPlayer.url = new Uri(this.GetAbsolutePath()).AbsoluteUri;
		}
		else
		{
			VideoClip embeddedVideoClip = config.VideoReference.EmbeddedVideoClip;
			this.videoPlayer.clip = embeddedVideoClip;
		}
		this.videoPlayer.prepareCompleted += this.OnPrepareCompleted;
		this.videoPlayer.Prepare();
	}

	// Token: 0x06000241 RID: 577
	protected abstract string GetAbsolutePath();

	// Token: 0x06000242 RID: 578 RVA: 0x0000D688 File Offset: 0x0000B888
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
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06000243 RID: 579 RVA: 0x0000D6F1 File Offset: 0x0000B8F1
	// (set) Token: 0x06000244 RID: 580 RVA: 0x0000D71C File Offset: 0x0000B91C
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

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000245 RID: 581 RVA: 0x0000D742 File Offset: 0x0000B942
	public override bool IsLoading
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000246 RID: 582 RVA: 0x0000D745 File Offset: 0x0000B945
	// (set) Token: 0x06000247 RID: 583 RVA: 0x0000D762 File Offset: 0x0000B962
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

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x06000248 RID: 584 RVA: 0x0000D77E File Offset: 0x0000B97E
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

	// Token: 0x06000249 RID: 585 RVA: 0x0000D7AD File Offset: 0x0000B9AD
	public override void Play()
	{
		if (this.videoPlayer != null && this.videoPlayer.isPrepared)
		{
			this.videoPlayer.Play();
		}
		this.isPlayEnqueued = true;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x0000D7DC File Offset: 0x0000B9DC
	public override void Stop()
	{
		if (this.videoPlayer != null)
		{
			this.videoPlayer.Stop();
		}
		this.isPlayEnqueued = false;
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0000D7FE File Offset: 0x0000B9FE
	private void OnPrepareCompleted(VideoPlayer source)
	{
		if (source == this.videoPlayer && this.videoPlayer != null && this.isPlayEnqueued)
		{
			this.videoPlayer.Play();
			this.isPlayEnqueued = false;
		}
	}

	// Token: 0x040001E1 RID: 481
	private VideoPlayer videoPlayer;

	// Token: 0x040001E2 RID: 482
	private Texture originalMainTexture;

	// Token: 0x040001E3 RID: 483
	private const string TexturePropertyName = "_MainTex";

	// Token: 0x040001E4 RID: 484
	private bool isPlayEnqueued;
}
