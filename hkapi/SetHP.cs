using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A4 RID: 420
[ActionCategory("Hollow Knight")]
public class SetHP : FsmStateAction
{
	// Token: 0x06000967 RID: 2407 RVA: 0x0003428A File Offset: 0x0003248A
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.hp = new FsmInt();
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x000342A4 File Offset: 0x000324A4
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.hp.IsNone)
			{
				component.hp = this.hp.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x04000A87 RID: 2695
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A88 RID: 2696
	public FsmInt hp;
}
