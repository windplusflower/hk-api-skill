using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020000F3 RID: 243
[ActionCategory("Hollow Knight")]
public class FadeColorFader : FsmStateAction
{
	// Token: 0x0600051F RID: 1311 RVA: 0x0001B155 File Offset: 0x00019355
	public override void Reset()
	{
		this.target = null;
		this.fadeType = null;
		this.useChildren = new FsmBool(true);
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001B178 File Offset: 0x00019378
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			ColorFader[] array;
			if (this.useChildren.Value)
			{
				array = safe.GetComponentsInChildren<ColorFader>();
			}
			else
			{
				array = new ColorFader[]
				{
					safe.GetComponent<ColorFader>()
				};
			}
			ColorFader[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i].Fade((FadeColorFader.FadeType)this.fadeType.Value == FadeColorFader.FadeType.UP);
			}
		}
		base.Finish();
	}

	// Token: 0x040004F0 RID: 1264
	public FsmOwnerDefault target;

	// Token: 0x040004F1 RID: 1265
	[ObjectType(typeof(FadeColorFader.FadeType))]
	public FsmEnum fadeType;

	// Token: 0x040004F2 RID: 1266
	public FsmBool useChildren;

	// Token: 0x020000F4 RID: 244
	public enum FadeType
	{
		// Token: 0x040004F4 RID: 1268
		UP,
		// Token: 0x040004F5 RID: 1269
		DOWN
	}
}
