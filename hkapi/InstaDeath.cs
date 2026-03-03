using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A3 RID: 419
[ActionCategory("Hollow Knight")]
public class InstaDeath : FsmStateAction
{
	// Token: 0x06000964 RID: 2404 RVA: 0x0003421F File Offset: 0x0003241F
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x0003422C File Offset: 0x0003242C
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !component.isDead)
			{
				component.Die(new float?(Mathf.Sign(this.direction.Value)), AttackTypes.Generic, false);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A85 RID: 2693
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A86 RID: 2694
	public FsmFloat direction;
}
