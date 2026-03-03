using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A6 RID: 422
[ActionCategory("Hollow Knight")]
public class SubtractHP : FsmStateAction
{
	// Token: 0x0600096D RID: 2413 RVA: 0x00034372 File Offset: 0x00032572
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.amount = new FsmInt();
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x0003438C File Offset: 0x0003258C
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.amount.IsNone)
			{
				component.hp -= this.amount.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x04000A8B RID: 2699
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A8C RID: 2700
	public FsmInt amount;
}
