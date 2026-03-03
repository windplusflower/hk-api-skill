using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A71 RID: 2673
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets the Parent of a Game Object. It uses the Transform.SetParent method")]
	public class SetTransformParent : FsmStateAction
	{
		// Token: 0x060039A0 RID: 14752 RVA: 0x00150091 File Offset: 0x0014E291
		public override void Reset()
		{
			this.gameObject = null;
			this.parent = null;
			this.worldPositionStays = true;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x001500B0 File Offset: 0x0014E2B0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			GameObject value = this.parent.Value;
			Transform transform = null;
			if (value != null)
			{
				transform = value.transform;
			}
			if (ownerDefaultTarget != null)
			{
				ownerDefaultTarget.transform.SetParent(transform, this.worldPositionStays.Value);
			}
			base.Finish();
		}

		// Token: 0x04003C9F RID: 15519
		[RequiredField]
		[Tooltip("The Game Object to parent.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003CA0 RID: 15520
		[Tooltip("The new parent for the Game Object.")]
		public FsmGameObject parent;

		// Token: 0x04003CA1 RID: 15521
		[Tooltip("If true, the parent-relative position, scale and rotation is modified such that the object keeps the same world space position, rotation and scale as before.")]
		public FsmBool worldPositionStays;
	}
}
