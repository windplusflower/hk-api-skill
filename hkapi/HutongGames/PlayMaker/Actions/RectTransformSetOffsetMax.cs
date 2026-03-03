using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A25 RID: 2597
	[ActionCategory("RectTransform")]
	[Tooltip("\tThe offset of the upper right corner of the rectangle relative to the upper right anchor.")]
	public class RectTransformSetOffsetMax : FsmStateActionAdvanced
	{
		// Token: 0x0600386F RID: 14447 RVA: 0x0014ABA6 File Offset: 0x00148DA6
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.offsetMax = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x0014ABE0 File Offset: 0x00148DE0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetOffsetMax();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x0014AC28 File Offset: 0x00148E28
		public override void OnActionUpdate()
		{
			this.DoSetOffsetMax();
		}

		// Token: 0x06003872 RID: 14450 RVA: 0x0014AC30 File Offset: 0x00148E30
		private void DoSetOffsetMax()
		{
			Vector2 value = this._rt.offsetMax;
			if (!this.offsetMax.IsNone)
			{
				value = this.offsetMax.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this._rt.offsetMax = value;
		}

		// Token: 0x04003B16 RID: 15126
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B17 RID: 15127
		[Tooltip("The Vector2 offsetMax. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 offsetMax;

		// Token: 0x04003B18 RID: 15128
		[Tooltip("Setting only the x value. Overides offsetMax x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B19 RID: 15129
		[Tooltip("Setting only the y value. Overides offsetMax y value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B1A RID: 15130
		private RectTransform _rt;
	}
}
