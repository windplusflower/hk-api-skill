using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A26 RID: 2598
	[ActionCategory("RectTransform")]
	[Tooltip("The offset of the lower left corner of the rectangle relative to the lower left anchor.")]
	public class RectTransformSetOffsetMin : FsmStateActionAdvanced
	{
		// Token: 0x06003874 RID: 14452 RVA: 0x0014ACAC File Offset: 0x00148EAC
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.offsetMin = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x0014ACE8 File Offset: 0x00148EE8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetOffsetMin();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x0014AD30 File Offset: 0x00148F30
		public override void OnActionUpdate()
		{
			this.DoSetOffsetMin();
		}

		// Token: 0x06003877 RID: 14455 RVA: 0x0014AD38 File Offset: 0x00148F38
		private void DoSetOffsetMin()
		{
			Vector2 value = this._rt.offsetMin;
			if (!this.offsetMin.IsNone)
			{
				value = this.offsetMin.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this._rt.offsetMin = value;
		}

		// Token: 0x04003B1B RID: 15131
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B1C RID: 15132
		[Tooltip("The Vector2 offsetMin. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 offsetMin;

		// Token: 0x04003B1D RID: 15133
		[Tooltip("Setting only the x value. Overides offsetMin x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B1E RID: 15134
		[Tooltip("Setting only the x value. Overides offsetMin y value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B1F RID: 15135
		private RectTransform _rt;
	}
}
