using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200017F RID: 383
[ActionCategory("Hollow Knight")]
public class PreSpawnCorpse : FsmStateAction
{
	// Token: 0x060008BD RID: 2237 RVA: 0x00030333 File Offset: 0x0002E533
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x00030340 File Offset: 0x0002E540
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			EnemyDeathEffects component = gameObject.GetComponent<EnemyDeathEffects>();
			if (component != null)
			{
				component.PreInstantiate();
			}
		}
		base.Finish();
	}

	// Token: 0x040009BA RID: 2490
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
