using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[ActionCategory("Hollow Knight")]
public class GetIsDead : FsmStateAction
{
	// Token: 0x06000977 RID: 2423 RVA: 0x000344E6 File Offset: 0x000326E6
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.storeValue = new FsmBool
		{
			UseVariable = true
		};
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x00034508 File Offset: 0x00032708
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.storeValue.IsNone)
			{
				this.storeValue.Value = component.GetIsDead();
			}
		}
		base.Finish();
	}

	// Token: 0x04000A92 RID: 2706
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A93 RID: 2707
	[UIHint(UIHint.Variable)]
	public FsmBool storeValue;
}
