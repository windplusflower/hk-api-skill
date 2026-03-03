using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001B0 RID: 432
[ActionCategory("Hollow Knight")]
public class SendHealthManagerDeathEvent : FsmStateAction
{
	// Token: 0x0600098C RID: 2444 RVA: 0x00034873 File Offset: 0x00032A73
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00034880 File Offset: 0x00032A80
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component != null)
			{
				component.SendDeathEvent();
			}
		}
		base.Finish();
	}

	// Token: 0x04000AA2 RID: 2722
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
