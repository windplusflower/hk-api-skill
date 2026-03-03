using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D03 RID: 3331
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Transforms a Position from a Game Object's local space to world space.")]
	public class TransformPoint : FsmStateAction
	{
		// Token: 0x0600451B RID: 17691 RVA: 0x0017858C File Offset: 0x0017678C
		public override void Reset()
		{
			this.gameObject = null;
			this.localPosition = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x0600451C RID: 17692 RVA: 0x001785AA File Offset: 0x001767AA
		public override void OnEnter()
		{
			this.DoTransformPoint();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x001785C0 File Offset: 0x001767C0
		public override void OnUpdate()
		{
			this.DoTransformPoint();
		}

		// Token: 0x0600451E RID: 17694 RVA: 0x001785C8 File Offset: 0x001767C8
		private void DoTransformPoint()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.storeResult.Value = ownerDefaultTarget.transform.TransformPoint(this.localPosition.Value);
		}

		// Token: 0x04004988 RID: 18824
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004989 RID: 18825
		[RequiredField]
		public FsmVector3 localPosition;

		// Token: 0x0400498A RID: 18826
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeResult;

		// Token: 0x0400498B RID: 18827
		public bool everyFrame;
	}
}
