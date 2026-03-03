using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200017C RID: 380
[ActionCategory("Hollow Knight")]
public class SendDeathEvent : FsmStateAction
{
	// Token: 0x060008B4 RID: 2228 RVA: 0x000301B8 File Offset: 0x0002E3B8
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.attackDirection = new FsmFloat();
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x000301D0 File Offset: 0x0002E3D0
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			EnemyDeathEffects component = gameObject.GetComponent<EnemyDeathEffects>();
			if (component != null)
			{
				component.RecieveDeathEvent(new float?(this.attackDirection.Value), false, false, false);
			}
		}
		base.Finish();
	}

	// Token: 0x040009B4 RID: 2484
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x040009B5 RID: 2485
	[UIHint(UIHint.Variable)]
	public FsmFloat attackDirection;
}
