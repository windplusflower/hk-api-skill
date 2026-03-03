using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000195 RID: 405
[ActionCategory("Hollow Knight")]
public class SendExtraDamage : FsmStateAction
{
	// Token: 0x06000905 RID: 2309 RVA: 0x00032478 File Offset: 0x00030678
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.extraDamageType = new FsmEnum("Extra Damage Type", typeof(ExtraDamageTypes), 0);
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x000324A0 File Offset: 0x000306A0
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			ExtraDamageable component = gameObject.GetComponent<ExtraDamageable>();
			if (component != null)
			{
				component.RecieveExtraDamage((ExtraDamageTypes)this.extraDamageType.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A1E RID: 2590
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A1F RID: 2591
	public FsmEnum extraDamageType;
}
