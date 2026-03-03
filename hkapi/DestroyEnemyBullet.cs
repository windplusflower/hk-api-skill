using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001E2 RID: 482
[ActionCategory("Hollow Knight")]
public class DestroyEnemyBullet : FsmStateAction
{
	// Token: 0x06000A87 RID: 2695 RVA: 0x000392AF File Offset: 0x000374AF
	public override void Reset()
	{
		this.target = null;
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x000392B8 File Offset: 0x000374B8
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe)
		{
			EnemyBullet component = safe.GetComponent<EnemyBullet>();
			if (component)
			{
				component.OrbitShieldHit(base.Owner.transform);
			}
		}
		base.Finish();
	}

	// Token: 0x04000BB1 RID: 2993
	public FsmOwnerDefault target;
}
