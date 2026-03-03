using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BDC RID: 3036
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Measures the Distance betweens 2 Game Objects and stores the result in a Float Variable.")]
	public class GetDistance : FsmStateAction
	{
		// Token: 0x06003FEA RID: 16362 RVA: 0x00168C20 File Offset: 0x00166E20
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.storeResult = null;
			this.everyFrame = true;
		}

		// Token: 0x06003FEB RID: 16363 RVA: 0x00168C3E File Offset: 0x00166E3E
		public override void OnEnter()
		{
			this.DoGetDistance();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FEC RID: 16364 RVA: 0x00168C54 File Offset: 0x00166E54
		public override void OnUpdate()
		{
			this.DoGetDistance();
		}

		// Token: 0x06003FED RID: 16365 RVA: 0x00168C5C File Offset: 0x00166E5C
		private void DoGetDistance()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null || this.target.Value == null || this.storeResult == null)
			{
				return;
			}
			this.storeResult.Value = Vector3.Distance(ownerDefaultTarget.transform.position, this.target.Value.transform.position);
		}

		// Token: 0x04004423 RID: 17443
		[RequiredField]
		[Tooltip("Measure distance from this GameObject.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004424 RID: 17444
		[RequiredField]
		[Tooltip("Target GameObject.")]
		public FsmGameObject target;

		// Token: 0x04004425 RID: 17445
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance in a float variable.")]
		public FsmFloat storeResult;

		// Token: 0x04004426 RID: 17446
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
