using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CD7 RID: 3287
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets the Parent of a Game Object.")]
	public class SetParent : FsmStateAction
	{
		// Token: 0x0600445D RID: 17501 RVA: 0x00175833 File Offset: 0x00173A33
		public override void Reset()
		{
			this.gameObject = null;
			this.parent = null;
			this.resetLocalPosition = null;
			this.resetLocalRotation = null;
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x00175854 File Offset: 0x00173A54
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				ownerDefaultTarget.transform.parent = ((this.parent.Value == null) ? null : this.parent.Value.transform);
				if (this.resetLocalPosition.Value)
				{
					ownerDefaultTarget.transform.localPosition = Vector3.zero;
				}
				if (this.resetLocalRotation.Value)
				{
					ownerDefaultTarget.transform.localRotation = Quaternion.identity;
				}
			}
			base.Finish();
		}

		// Token: 0x040048A4 RID: 18596
		[RequiredField]
		[Tooltip("The Game Object to parent.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048A5 RID: 18597
		[Tooltip("The new parent for the Game Object.")]
		public FsmGameObject parent;

		// Token: 0x040048A6 RID: 18598
		[Tooltip("Set the local position to 0,0,0 after parenting.")]
		public FsmBool resetLocalPosition;

		// Token: 0x040048A7 RID: 18599
		[Tooltip("Set the local rotation to 0,0,0 after parenting.")]
		public FsmBool resetLocalRotation;
	}
}
