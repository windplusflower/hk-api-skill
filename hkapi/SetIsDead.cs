using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001AA RID: 426
[ActionCategory("Hollow Knight")]
public class SetIsDead : FsmStateAction
{
	// Token: 0x0600097A RID: 2426 RVA: 0x0003455F File Offset: 0x0003275F
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.setValue = new FsmBool();
	}

	// Token: 0x0600097B RID: 2427 RVA: 0x00034578 File Offset: 0x00032778
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null)
			{
				component.SetIsDead(this.setValue.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A94 RID: 2708
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A95 RID: 2709
	public FsmBool setValue;
}
