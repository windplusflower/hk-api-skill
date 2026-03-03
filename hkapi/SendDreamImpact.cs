using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000189 RID: 393
[ActionCategory("Hollow Knight")]
public class SendDreamImpact : FsmStateAction
{
	// Token: 0x060008D8 RID: 2264 RVA: 0x00030A14 File Offset: 0x0002EC14
	public override void Reset()
	{
		this.target = new FsmOwnerDefault();
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00030A24 File Offset: 0x0002EC24
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe != null)
		{
			EnemyDreamnailReaction enemyDreamnailReaction = safe.GetComponent<EnemyDreamnailReaction>();
			if (enemyDreamnailReaction == null)
			{
				enemyDreamnailReaction = safe.GetComponentInParent<EnemyDreamnailReaction>();
				if (enemyDreamnailReaction && !enemyDreamnailReaction.allowUseChildColliders)
				{
					enemyDreamnailReaction = null;
				}
			}
			if (enemyDreamnailReaction != null)
			{
				enemyDreamnailReaction.RecieveDreamImpact();
			}
		}
		base.Finish();
	}

	// Token: 0x040009D4 RID: 2516
	[UIHint(UIHint.Variable)]
	public FsmOwnerDefault target;
}
