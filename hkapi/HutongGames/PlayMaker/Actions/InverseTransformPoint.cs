using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C33 RID: 3123
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Transforms position from world space to a Game Object's local space. The opposite of TransformPoint.")]
	public class InverseTransformPoint : FsmStateAction
	{
		// Token: 0x0600416A RID: 16746 RVA: 0x0016C702 File Offset: 0x0016A902
		public override void Reset()
		{
			this.gameObject = null;
			this.worldPosition = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x0600416B RID: 16747 RVA: 0x0016C720 File Offset: 0x0016A920
		public override void OnEnter()
		{
			this.DoInverseTransformPoint();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600416C RID: 16748 RVA: 0x0016C736 File Offset: 0x0016A936
		public override void OnUpdate()
		{
			this.DoInverseTransformPoint();
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x0016C740 File Offset: 0x0016A940
		private void DoInverseTransformPoint()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.storeResult.Value = ownerDefaultTarget.transform.InverseTransformPoint(this.worldPosition.Value);
		}

		// Token: 0x040045AE RID: 17838
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045AF RID: 17839
		[RequiredField]
		public FsmVector3 worldPosition;

		// Token: 0x040045B0 RID: 17840
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeResult;

		// Token: 0x040045B1 RID: 17841
		public bool everyFrame;
	}
}
