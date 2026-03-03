using System;
using UnityEngine;

// Token: 0x020001FC RID: 508
public class MakeSkippable : MonoBehaviour
{
	// Token: 0x06000B17 RID: 2839 RVA: 0x0003ADDC File Offset: 0x00038FDC
	private void Awake()
	{
		this.cinematicPlayer = base.GetComponent<CinematicPlayer>();
		this.cutsceneHelper = base.GetComponent<CutsceneHelper>();
		if (this.cinematicPlayer != null)
		{
			this.skipType = MakeSkippable.SkipType.Cinematic;
			return;
		}
		if (this.cutsceneHelper != null)
		{
			this.skipType = MakeSkippable.SkipType.Cutscene;
			return;
		}
		this.skipType = MakeSkippable.SkipType.Inactive;
		Debug.LogError("MakeSkippable requires a Cinematic Player or Cutscene Helper component.");
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x0003AE3E File Offset: 0x0003903E
	private void Start()
	{
		if (this.skipType != MakeSkippable.SkipType.Inactive)
		{
			if (this.unlockAfterSec <= 0f)
			{
				this.UnlockSkip();
				return;
			}
			base.Invoke("UnlockSkip", this.unlockAfterSec);
		}
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x0003AE70 File Offset: 0x00039070
	private void UnlockSkip()
	{
		if (this.skipType != MakeSkippable.SkipType.Cinematic)
		{
			if (this.skipType == MakeSkippable.SkipType.Cutscene)
			{
				if (this.cutsceneHelper != null)
				{
					this.cutsceneHelper.UnlockSkip();
					return;
				}
				Debug.LogError("MakeSkippable - Cutscene Helper is null");
			}
			return;
		}
		if (this.cinematicPlayer != null)
		{
			this.cinematicPlayer.UnlockSkip();
			return;
		}
		Debug.LogError("MakeSkippable - Cinematic Player is null");
	}

	// Token: 0x04000C20 RID: 3104
	public float unlockAfterSec;

	// Token: 0x04000C21 RID: 3105
	private CinematicPlayer cinematicPlayer;

	// Token: 0x04000C22 RID: 3106
	private CutsceneHelper cutsceneHelper;

	// Token: 0x04000C23 RID: 3107
	private MakeSkippable.SkipType skipType;

	// Token: 0x020001FD RID: 509
	private enum SkipType
	{
		// Token: 0x04000C25 RID: 3109
		Inactive,
		// Token: 0x04000C26 RID: 3110
		Cinematic,
		// Token: 0x04000C27 RID: 3111
		Cutscene
	}
}
