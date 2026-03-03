using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A17 RID: 2583
	[ActionCategory("RectTransform")]
	[Tooltip("Get the offset of the lower left corner of the rectangle relative to the lower left anchor")]
	public class RectTransformGetOffsetMin : FsmStateActionAdvanced
	{
		// Token: 0x0600382E RID: 14382 RVA: 0x00149A50 File Offset: 0x00147C50
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.offsetMin = null;
			this.x = null;
			this.y = null;
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00149A74 File Offset: 0x00147C74
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoGetValues();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x00149ABC File Offset: 0x00147CBC
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00149AC4 File Offset: 0x00147CC4
		private void DoGetValues()
		{
			if (!this.offsetMin.IsNone)
			{
				this.offsetMin.Value = this._rt.offsetMin;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.offsetMin.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.offsetMin.y;
			}
		}

		// Token: 0x04003AC3 RID: 15043
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AC4 RID: 15044
		[Tooltip("The offsetMin")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 offsetMin;

		// Token: 0x04003AC5 RID: 15045
		[Tooltip("The x component of the offsetMin")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AC6 RID: 15046
		[Tooltip("The y component of the offsetMin")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AC7 RID: 15047
		private RectTransform _rt;
	}
}
