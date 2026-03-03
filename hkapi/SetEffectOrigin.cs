using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200017D RID: 381
[ActionCategory("Hollow Knight")]
public class SetEffectOrigin : FsmStateAction
{
	// Token: 0x060008B7 RID: 2231 RVA: 0x0003023B File Offset: 0x0002E43B
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.effectOrigin = new FsmVector3();
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00030254 File Offset: 0x0002E454
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			EnemyDeathEffects component = gameObject.GetComponent<EnemyDeathEffects>();
			if (component != null)
			{
				component.effectOrigin = this.effectOrigin.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x040009B6 RID: 2486
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x040009B7 RID: 2487
	public FsmVector3 effectOrigin;
}
