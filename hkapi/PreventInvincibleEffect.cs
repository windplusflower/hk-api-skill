using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001AC RID: 428
[ActionCategory("Hollow Knight")]
public class PreventInvincibleEffect : FsmStateAction
{
	// Token: 0x06000980 RID: 2432 RVA: 0x00034683 File Offset: 0x00032883
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.preventEffect = new FsmBool();
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x0003469C File Offset: 0x0003289C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			HealthManager component = gameObject.GetComponent<HealthManager>();
			if (component != null)
			{
				component.SetPreventInvincibleEffect(this.preventEffect.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x04000A9A RID: 2714
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x04000A9B RID: 2715
	public FsmBool preventEffect;
}
