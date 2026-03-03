using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001E4 RID: 484
[ActionCategory("Hollow Knight")]
public class EnemyPusherIgnore : FsmStateAction
{
	// Token: 0x06000A8C RID: 2700 RVA: 0x00039354 File Offset: 0x00037554
	public override void Reset()
	{
		this.target = null;
		this.other = new FsmGameObject
		{
			UseVariable = true
		};
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00039370 File Offset: 0x00037570
	public override void OnEnter()
	{
		GameObject safe = this.target.GetSafe(this);
		if (safe && this.other.Value)
		{
			EnemyPusher componentInChildren = this.other.Value.GetComponentInChildren<EnemyPusher>();
			if (componentInChildren)
			{
				Collider2D component = safe.GetComponent<Collider2D>();
				Collider2D component2 = componentInChildren.GetComponent<Collider2D>();
				if (component && component2)
				{
					Physics2D.IgnoreCollision(component, component2);
				}
			}
		}
		base.Finish();
	}

	// Token: 0x04000BB2 RID: 2994
	public FsmOwnerDefault target;

	// Token: 0x04000BB3 RID: 2995
	public FsmGameObject other;
}
