using System;
using UnityEngine;
using UnityEngine.Video;

// Token: 0x0200006E RID: 110
[CreateAssetMenu(menuName = "Hollow Knight/Cinematic Video Reference", fileName = "CinematicVideoReference", order = 1000)]
public class CinematicVideoReference : ScriptableObject
{
	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600024E RID: 590 RVA: 0x0000D8A1 File Offset: 0x0000BAA1
	public string VideoFileName
	{
		get
		{
			return base.name;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x0600024F RID: 591 RVA: 0x0000D8A9 File Offset: 0x0000BAA9
	public string VideoAssetPath
	{
		get
		{
			return this.videoAssetPath;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000250 RID: 592 RVA: 0x0000D8B1 File Offset: 0x0000BAB1
	public string AudioAssetPath
	{
		get
		{
			return this.audioAssetPath;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000251 RID: 593 RVA: 0x0000D8B9 File Offset: 0x0000BAB9
	public VideoClip EmbeddedVideoClip
	{
		get
		{
			return this.embeddedVideoClip;
		}
	}

	// Token: 0x040001E5 RID: 485
	[SerializeField]
	private string videoAssetPath;

	// Token: 0x040001E6 RID: 486
	[SerializeField]
	private string audioAssetPath;

	// Token: 0x040001E7 RID: 487
	[SerializeField]
	private VideoClip embeddedVideoClip;
}
