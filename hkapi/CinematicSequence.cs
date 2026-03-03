using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000066 RID: 102
[RequireComponent(typeof(AudioSource))]
public class CinematicSequence : SkippableSequence
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600021D RID: 541 RVA: 0x0000D152 File Offset: 0x0000B352
	public CinematicVideoPlayer VideoPlayer
	{
		get
		{
			return this.videoPlayer;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600021E RID: 542 RVA: 0x0000D15A File Offset: 0x0000B35A
	public override bool IsSkipped
	{
		get
		{
			return this.isSkipped;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600021F RID: 543 RVA: 0x0000D162 File Offset: 0x0000B362
	// (set) Token: 0x06000220 RID: 544 RVA: 0x0000D17E File Offset: 0x0000B37E
	public bool IsLooping
	{
		get
		{
			if (this.videoPlayer != null)
			{
				return this.videoPlayer.IsLooping;
			}
			return this.isLooping;
		}
		set
		{
			if (this.videoPlayer != null)
			{
				this.videoPlayer.IsLooping = value;
			}
			this.isLooping = value;
		}
	}

	// Token: 0x06000221 RID: 545 RVA: 0x0000D19B File Offset: 0x0000B39B
	protected void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
		this.fadeByController = 1f;
	}

	// Token: 0x06000222 RID: 546 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
	protected void OnDestroy()
	{
		if (this.videoPlayer != null)
		{
			this.videoPlayer.Dispose();
			this.videoPlayer = null;
		}
	}

	// Token: 0x06000223 RID: 547 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
	protected void Update()
	{
		if (this.videoPlayer != null)
		{
			this.framesSinceBegan++;
			this.videoPlayer.Update();
			if (!this.videoPlayer.IsLoading && !this.didPlay)
			{
				this.didPlay = true;
				if (this.atmosSnapshot != null)
				{
					this.atmosSnapshot.TransitionTo(this.atmosSnapshotTransitionDuration);
				}
				Debug.LogFormat(this, "Started cinematic '{0}'", new object[]
				{
					this.videoReference.name
				});
				this.videoPlayer.Play();
			}
			if (!this.videoPlayer.IsPlaying && !this.videoPlayer.IsLoading && this.framesSinceBegan >= 10)
			{
				Debug.LogFormat(this, "Stopped cinematic '{0}'", new object[]
				{
					this.videoReference.name
				});
				this.videoPlayer.Dispose();
				this.videoPlayer = null;
				this.targetRenderer.enabled = false;
				return;
			}
			if (this.isSkipped)
			{
				Debug.LogFormat(this, "Skipped cinematic '{0}'", new object[]
				{
					this.videoReference.name
				});
				this.videoPlayer.Stop();
			}
		}
	}

	// Token: 0x06000224 RID: 548 RVA: 0x0000D2FC File Offset: 0x0000B4FC
	public override void Begin()
	{
		if (this.videoPlayer != null && this.videoPlayer.IsPlaying)
		{
			Debug.LogErrorFormat(this, "Can't play a cinematic sequence that is already playing", Array.Empty<object>());
			return;
		}
		if (this.videoPlayer != null)
		{
			this.videoPlayer.Dispose();
			this.videoPlayer = null;
			this.targetRenderer.enabled = false;
		}
		this.targetRenderer.enabled = true;
		this.videoPlayer = CinematicVideoPlayer.Create(new CinematicVideoPlayerConfig(this.videoReference, this.targetRenderer, this.audioSource, CinematicVideoFaderStyles.Black, GameManager.instance.GetImplicitCinematicVolume()));
		this.videoPlayer.IsLooping = this.isLooping;
		this.videoPlayer.Volume = this.fadeByController;
		this.isSkipped = false;
		this.framesSinceBegan = 0;
		this.UpdateBlanker(1f - this.fadeByController);
		Debug.LogFormat(this, "Started cinematic '{0}'", new object[]
		{
			this.videoReference.name
		});
	}

	// Token: 0x06000225 RID: 549 RVA: 0x0000D3F0 File Offset: 0x0000B5F0
	private void UpdateBlanker(float alpha)
	{
		if (alpha > Mathf.Epsilon)
		{
			if (!this.blankerRenderer.enabled)
			{
				this.blankerRenderer.enabled = true;
			}
			this.blankerRenderer.material.color = new Color(0f, 0f, 0f, alpha);
			return;
		}
		if (this.blankerRenderer.enabled)
		{
			this.blankerRenderer.enabled = false;
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000226 RID: 550 RVA: 0x0000D460 File Offset: 0x0000B660
	public override bool IsPlaying
	{
		get
		{
			bool flag = this.framesSinceBegan < 10 || !this.didPlay;
			return !this.isSkipped && (flag || (this.videoPlayer != null && this.videoPlayer.IsPlaying));
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000D4A8 File Offset: 0x0000B6A8
	public override void Skip()
	{
		this.isSkipped = true;
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000228 RID: 552 RVA: 0x0000D4B1 File Offset: 0x0000B6B1
	// (set) Token: 0x06000229 RID: 553 RVA: 0x0000D4B9 File Offset: 0x0000B6B9
	public override float FadeByController
	{
		get
		{
			return this.fadeByController;
		}
		set
		{
			this.fadeByController = value;
			if (this.videoPlayer != null)
			{
				this.videoPlayer.Volume = this.fadeByController;
			}
			this.UpdateBlanker(1f - this.fadeByController);
		}
	}

	// Token: 0x040001C8 RID: 456
	private AudioSource audioSource;

	// Token: 0x040001C9 RID: 457
	[SerializeField]
	private AudioMixerSnapshot atmosSnapshot;

	// Token: 0x040001CA RID: 458
	[SerializeField]
	private float atmosSnapshotTransitionDuration;

	// Token: 0x040001CB RID: 459
	[SerializeField]
	private CinematicVideoReference videoReference;

	// Token: 0x040001CC RID: 460
	[SerializeField]
	private bool isLooping;

	// Token: 0x040001CD RID: 461
	[SerializeField]
	private MeshRenderer targetRenderer;

	// Token: 0x040001CE RID: 462
	[SerializeField]
	private MeshRenderer blankerRenderer;

	// Token: 0x040001CF RID: 463
	private CinematicVideoPlayer videoPlayer;

	// Token: 0x040001D0 RID: 464
	private bool didPlay;

	// Token: 0x040001D1 RID: 465
	private bool isSkipped;

	// Token: 0x040001D2 RID: 466
	private int framesSinceBegan;

	// Token: 0x040001D3 RID: 467
	private float fadeByController;
}
