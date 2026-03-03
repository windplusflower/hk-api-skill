using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000187 RID: 391
[ActionCategory("Hollow Knight")]
public class MakeEnemyDreamnailReactionReady : FsmStateAction
{
	// Token: 0x060008D2 RID: 2258 RVA: 0x0003091C File Offset: 0x0002EB1C
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060008D3 RID: 2259 RVA: 0x0003092C File Offset: 0x0002EB2C
	public override void OnEnter()
	{
		GameObject gameObject = (this.target.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.target.GameObject.Value;
		if (gameObject != null)
		{
			EnemyDreamnailReaction component = gameObject.GetComponent<EnemyDreamnailReaction>();
			if (component != null)
			{
				component.MakeReady();
			}
		}
		base.Finish();
	}

	// Token: 0x040009D1 RID: 2513
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
