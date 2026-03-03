using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B6D RID: 2925
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Destroys the Owner of the Fsm! Useful for spawned Prefabs that need to kill themselves, e.g., a projectile that explodes on impact.")]
	public class DestroySelf : FsmStateAction
	{
		// Token: 0x06003E44 RID: 15940 RVA: 0x00163D12 File Offset: 0x00161F12
		public override void Reset()
		{
			this.detachChildren = false;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x00163D20 File Offset: 0x00161F20
		public override void OnEnter()
		{
			if (base.Owner != null)
			{
				if (this.detachChildren.Value)
				{
					base.Owner.transform.DetachChildren();
				}
				UnityEngine.Object.Destroy(base.Owner);
			}
			base.Finish();
		}

		// Token: 0x0400425C RID: 16988
		[Tooltip("Detach children before destroying the Owner.")]
		public FsmBool detachChildren;
	}
}
