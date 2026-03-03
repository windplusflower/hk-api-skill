using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A1F RID: 2591
	[ActionCategory("RectTransform")]
	[Tooltip("The normalized position in the parent RectTransform that the lower left corner is anchored to. This is relative screen space, values ranges from 0 to 1")]
	public class RectTransformSetAnchorMin : FsmStateActionAdvanced
	{
		// Token: 0x06003856 RID: 14422 RVA: 0x0014A284 File Offset: 0x00148484
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.anchorMin = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0014A2C0 File Offset: 0x001484C0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetAnchorMin();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x0014A308 File Offset: 0x00148508
		public override void OnActionUpdate()
		{
			this.DoSetAnchorMin();
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x0014A310 File Offset: 0x00148510
		private void DoSetAnchorMin()
		{
			Vector2 value = this._rt.anchorMin;
			if (!this.anchorMin.IsNone)
			{
				value = this.anchorMin.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this._rt.anchorMin = value;
		}

		// Token: 0x04003AED RID: 15085
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AEE RID: 15086
		[Tooltip("The Vector2 anchor. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 anchorMin;

		// Token: 0x04003AEF RID: 15087
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overides anchorMin x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003AF0 RID: 15088
		[HasFloatSlider(0f, 1f)]
		[Tooltip("Setting only the x value. Overides anchorMin x value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003AF1 RID: 15089
		private RectTransform _rt;
	}
}
