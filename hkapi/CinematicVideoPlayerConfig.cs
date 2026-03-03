using System;
using UnityEngine;

// Token: 0x0200006A RID: 106
public class CinematicVideoPlayerConfig
{
	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600022C RID: 556 RVA: 0x0000D50A File Offset: 0x0000B70A
	public CinematicVideoReference VideoReference
	{
		get
		{
			return this.videoReference;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x0600022D RID: 557 RVA: 0x0000D512 File Offset: 0x0000B712
	public MeshRenderer MeshRenderer
	{
		get
		{
			return this.meshRenderer;
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600022E RID: 558 RVA: 0x0000D51A File Offset: 0x0000B71A
	public AudioSource AudioSource
	{
		get
		{
			return this.audioSource;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600022F RID: 559 RVA: 0x0000D522 File Offset: 0x0000B722
	public CinematicVideoFaderStyles FaderStyle
	{
		get
		{
			return this.faderStyle;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000230 RID: 560 RVA: 0x0000D52A File Offset: 0x0000B72A
	public float ImplicitVolume
	{
		get
		{
			return this.implicitVolume;
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x0000D532 File Offset: 0x0000B732
	public CinematicVideoPlayerConfig(CinematicVideoReference videoReference, MeshRenderer meshRenderer, AudioSource audioSource, CinematicVideoFaderStyles faderStyle, float implicitVolume)
	{
		this.videoReference = videoReference;
		this.meshRenderer = meshRenderer;
		this.audioSource = audioSource;
		this.faderStyle = faderStyle;
		this.implicitVolume = implicitVolume;
	}

	// Token: 0x040001DB RID: 475
	private CinematicVideoReference videoReference;

	// Token: 0x040001DC RID: 476
	private MeshRenderer meshRenderer;

	// Token: 0x040001DD RID: 477
	private AudioSource audioSource;

	// Token: 0x040001DE RID: 478
	private CinematicVideoFaderStyles faderStyle;

	// Token: 0x040001DF RID: 479
	private float implicitVolume;
}
