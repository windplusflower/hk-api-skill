using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD3 RID: 2771
	public abstract class RigidBody2dActionBase : FsmStateAction
	{
		// Token: 0x06003B91 RID: 15249 RVA: 0x00157BD9 File Offset: 0x00155DD9
		protected void CacheRigidBody2d(GameObject go)
		{
			if (go == null)
			{
				return;
			}
			this.rb2d = go.GetComponent<Rigidbody2D>();
			if (this.rb2d == null)
			{
				base.LogWarning("Missing rigid body 2D: " + go.name);
				return;
			}
		}

		// Token: 0x04003F1A RID: 16154
		protected Rigidbody2D rb2d;
	}
}
