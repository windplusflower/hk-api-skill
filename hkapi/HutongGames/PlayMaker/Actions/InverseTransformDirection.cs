using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C32 RID: 3122
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Transforms a Direction from world space to a Game Object's local space. The opposite of TransformDirection.")]
	public class InverseTransformDirection : FsmStateAction
	{
		// Token: 0x06004165 RID: 16741 RVA: 0x0016C67C File Offset: 0x0016A87C
		public override void Reset()
		{
			this.gameObject = null;
			this.worldDirection = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x0016C69A File Offset: 0x0016A89A
		public override void OnEnter()
		{
			this.DoInverseTransformDirection();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x0016C6B0 File Offset: 0x0016A8B0
		public override void OnUpdate()
		{
			this.DoInverseTransformDirection();
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x0016C6B8 File Offset: 0x0016A8B8
		private void DoInverseTransformDirection()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.storeResult.Value = ownerDefaultTarget.transform.InverseTransformDirection(this.worldDirection.Value);
		}

		// Token: 0x040045AA RID: 17834
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045AB RID: 17835
		[RequiredField]
		public FsmVector3 worldDirection;

		// Token: 0x040045AC RID: 17836
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeResult;

		// Token: 0x040045AD RID: 17837
		public bool everyFrame;
	}
}
