using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001A2 RID: 418
[ActionCategory("Hollow Knight")]
public class SetSendKilledToObject : FsmStateAction
{
	// Token: 0x06000961 RID: 2401 RVA: 0x000341AF File Offset: 0x000323AF
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.killedObject = new FsmGameObject();
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x000341C8 File Offset: 0x000323C8
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			HealthManager component = safe.GetComponent<HealthManager>();
			if (component != null && !this.killedObject.IsNone)
			{
				component.SetSendKilledToObject(this.killedObject.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A83 RID: 2691
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A84 RID: 2692
	public FsmGameObject killedObject;
}
