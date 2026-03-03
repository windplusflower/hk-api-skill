using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001AE RID: 430
[ActionCategory("Hollow Knight")]
public class SetDamageOverride : FsmStateAction
{
	// Token: 0x06000986 RID: 2438 RVA: 0x0003477B File Offset: 0x0003297B
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.damageOverride = new FsmBool();
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00034794 File Offset: 0x00032994
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component != null)
			{
				component.SetDamageOverride(this.damageOverride.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A9E RID: 2718
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A9F RID: 2719
	public FsmBool damageOverride;
}
