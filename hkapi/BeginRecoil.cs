using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[ActionCategory("Hollow Knight")]
public class BeginRecoil : FsmStateAction
{
	// Token: 0x06000A1B RID: 2587 RVA: 0x000377FC File Offset: 0x000359FC
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.attackDirection = new FsmFloat();
		this.attackType = new FsmInt();
		this.attackMagnitude = new FsmFloat();
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0003782C File Offset: 0x00035A2C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			Recoil component = gameObject.GetComponent<Recoil>();
			if (component != null)
			{
				component.RecoilByDirection(DirectionUtils.GetCardinalDirection(this.attackDirection.Value), this.attackMagnitude.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000B33 RID: 2867
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000B34 RID: 2868
	[UIHint(UIHint.Variable)]
	public FsmFloat attackDirection;

	// Token: 0x04000B35 RID: 2869
	[UIHint(UIHint.Variable)]
	public FsmInt attackType;

	// Token: 0x04000B36 RID: 2870
	[UIHint(UIHint.Variable)]
	public FsmFloat attackMagnitude;
}
