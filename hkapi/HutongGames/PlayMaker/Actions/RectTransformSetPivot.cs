using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A27 RID: 2599
	[ActionCategory("RectTransform")]
	[Tooltip("The normalized position in this RectTransform that it rotates around.")]
	public class RectTransformSetPivot : FsmStateActionAdvanced
	{
		// Token: 0x06003879 RID: 14457 RVA: 0x0014ADB4 File Offset: 0x00148FB4
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.pivot = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x0014ADF0 File Offset: 0x00148FF0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetPivotPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x0014AE38 File Offset: 0x00149038
		public override void OnActionUpdate()
		{
			this.DoSetPivotPosition();
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x0014AE40 File Offset: 0x00149040
		private void DoSetPivotPosition()
		{
			Vector2 value = this._rt.pivot;
			if (!this.pivot.IsNone)
			{
				value = this.pivot.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this._rt.pivot = value;
		}

		// Token: 0x04003B20 RID: 15136
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B21 RID: 15137
		[Tooltip("The Vector2 pivot. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 pivot;

		// Token: 0x04003B22 RID: 15138
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overides pivot x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B23 RID: 15139
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overides pivot y value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B24 RID: 15140
		private RectTransform _rt;
	}
}
