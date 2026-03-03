using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A1 RID: 417
[ActionCategory("Hollow Knight")]
public class SetSpecialDeath : FsmStateAction
{
	// Token: 0x0600095E RID: 2398 RVA: 0x0003413D File Offset: 0x0003233D
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.hasSpecialDeath = new FsmBool();
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00034158 File Offset: 0x00032358
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.hasSpecialDeath.IsNone)
			{
				component.hasSpecialDeath = this.hasSpecialDeath.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x04000A81 RID: 2689
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A82 RID: 2690
	public FsmBool hasSpecialDeath;
}
