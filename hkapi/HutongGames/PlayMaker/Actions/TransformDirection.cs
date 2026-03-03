using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D00 RID: 3328
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Transforms a Direction from a Game Object's local space to world space.")]
	public class TransformDirection : FsmStateAction
	{
		// Token: 0x06004513 RID: 17683 RVA: 0x00178332 File Offset: 0x00176532
		public override void Reset()
		{
			this.gameObject = null;
			this.localDirection = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00178350 File Offset: 0x00176550
		public override void OnEnter()
		{
			this.DoTransformDirection();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x00178366 File Offset: 0x00176566
		public override void OnUpdate()
		{
			this.DoTransformDirection();
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x00178370 File Offset: 0x00176570
		private void DoTransformDirection()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.storeResult.Value = ownerDefaultTarget.transform.TransformDirection(this.localDirection.Value);
		}

		// Token: 0x04004979 RID: 18809
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400497A RID: 18810
		[RequiredField]
		public FsmVector3 localDirection;

		// Token: 0x0400497B RID: 18811
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeResult;

		// Token: 0x0400497C RID: 18812
		public bool everyFrame;
	}
}
