using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[ActionCategory("Hollow Knight")]
public class AddHP : FsmStateAction
{
	// Token: 0x0600096A RID: 2410 RVA: 0x000342FB File Offset: 0x000324FB
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.amount = new FsmInt();
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x00034314 File Offset: 0x00032514
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.amount.IsNone)
			{
				component.hp += this.amount.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x04000A89 RID: 2697
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A8A RID: 2698
	public FsmInt amount;
}
