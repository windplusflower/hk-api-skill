using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC8 RID: 2760
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets the Mass of a Game Object's Rigid Body 2D.")]
	public class GetMass2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B5C RID: 15196 RVA: 0x00156843 File Offset: 0x00154A43
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00156853 File Offset: 0x00154A53
		public override void OnEnter()
		{
			this.DoGetMass();
			base.Finish();
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00156864 File Offset: 0x00154A64
		private void DoGetMass()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			this.storeResult.Value = base.rigidbody2d.mass;
		}

		// Token: 0x04003EB4 RID: 16052
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with a Rigidbody2D attached.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003EB5 RID: 16053
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the mass of gameObject.")]
		public FsmFloat storeResult;
	}
}
