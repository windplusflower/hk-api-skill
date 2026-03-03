using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001AF RID: 431
[ActionCategory("Hollow Knight")]
public class CheckInvincibility : FsmStateAction
{
	// Token: 0x06000989 RID: 2441 RVA: 0x000347F7 File Offset: 0x000329F7
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.storeValue = new FsmBool();
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00034810 File Offset: 0x00032A10
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component != null)
			{
				this.storeValue.Value = component.CheckInvincible();
			}
		}
		base.Finish();
	}

	// Token: 0x04000AA0 RID: 2720
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000AA1 RID: 2721
	public FsmBool storeValue;
}
