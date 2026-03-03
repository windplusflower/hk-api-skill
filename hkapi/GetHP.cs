using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[ActionCategory("Hollow Knight")]
public class GetHP : FsmStateAction
{
	// Token: 0x06000970 RID: 2416 RVA: 0x000343EA File Offset: 0x000325EA
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.storeValue = new FsmInt
		{
			UseVariable = true
		};
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x0003440C File Offset: 0x0003260C
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.storeValue.IsNone)
			{
				this.storeValue.Value = component.hp;
			}
		}
		base.Finish();
	}

	// Token: 0x04000A8D RID: 2701
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A8E RID: 2702
	[UIHint(UIHint.Variable)]
	public FsmInt storeValue;
}
