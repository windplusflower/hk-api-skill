using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x0200017E RID: 382
[ActionCategory("Hollow Knight")]
public class SetCorpseSpawnPoint : FsmStateAction
{
	// Token: 0x060008BA RID: 2234 RVA: 0x000302B7 File Offset: 0x0002E4B7
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
		this.spawnPoint = new FsmVector3();
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x000302D0 File Offset: 0x0002E4D0
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			EnemyDeathEffects component = gameObject.GetComponent<EnemyDeathEffects>();
			if (component != null)
			{
				component.corpseSpawnPoint = this.spawnPoint.Value;
			}
		}
		base.Finish();
	}

	// Token: 0x040009B8 RID: 2488
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;

	// Token: 0x040009B9 RID: 2489
	public FsmVector3 spawnPoint;
}
