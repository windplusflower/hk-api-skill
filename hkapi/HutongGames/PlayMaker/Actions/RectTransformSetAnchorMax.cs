using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A1E RID: 2590
	[ActionCategory("RectTransform")]
	[Tooltip("The normalized position in the parent RectTransform that the upper right corner is anchored to. This is relative screen space, values ranges from 0 to 1")]
	public class RectTransformSetAnchorMax : FsmStateActionAdvanced
	{
		// Token: 0x06003851 RID: 14417 RVA: 0x0014A17E File Offset: 0x0014837E
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.anchorMax = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x0014A1B8 File Offset: 0x001483B8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetAnchorMax();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0014A200 File Offset: 0x00148400
		public override void OnActionUpdate()
		{
			this.DoSetAnchorMax();
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x0014A208 File Offset: 0x00148408
		private void DoSetAnchorMax()
		{
			Vector2 value = this._rt.anchorMax;
			if (!this.anchorMax.IsNone)
			{
				value = this.anchorMax.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this._rt.anchorMax = value;
		}

		// Token: 0x04003AE8 RID: 15080
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AE9 RID: 15081
		[Tooltip("The Vector2 anchor. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 anchorMax;

		// Token: 0x04003AEA RID: 15082
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overides anchorMax x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003AEB RID: 15083
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overides anchorMax x value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003AEC RID: 15084
		private RectTransform _rt;
	}
}
