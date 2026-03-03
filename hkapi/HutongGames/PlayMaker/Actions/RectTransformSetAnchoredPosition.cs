using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A22 RID: 2594
	[ActionCategory("RectTransform")]
	[Tooltip("The position of the pivot of this RectTransform relative to the anchor reference point.The anchor reference point is where the anchors are. If the anchor are not together, the four anchor positions are interpolated according to the pivot normalized values.")]
	public class RectTransformSetAnchoredPosition : FsmStateActionAdvanced
	{
		// Token: 0x06003860 RID: 14432 RVA: 0x0014A795 File Offset: 0x00148995
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.position = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0014A7D0 File Offset: 0x001489D0
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetAnchoredPosition();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x0014A818 File Offset: 0x00148A18
		public override void OnActionUpdate()
		{
			this.DoSetAnchoredPosition();
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x0014A820 File Offset: 0x00148A20
		private void DoSetAnchoredPosition()
		{
			Vector2 anchoredPosition = this._rt.anchoredPosition;
			if (!this.position.IsNone)
			{
				anchoredPosition = this.position.Value;
			}
			if (!this.x.IsNone)
			{
				anchoredPosition.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				anchoredPosition.y = this.y.Value;
			}
			this._rt.anchoredPosition = anchoredPosition;
		}

		// Token: 0x04003B04 RID: 15108
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B05 RID: 15109
		[Tooltip("The Vector2 position. Set to none for no effect, and/or set individual axis below. ")]
		public FsmVector2 position;

		// Token: 0x04003B06 RID: 15110
		[Tooltip("Setting only the x value. Overides position x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B07 RID: 15111
		[Tooltip("Setting only the y value. Overides position x value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B08 RID: 15112
		private RectTransform _rt;
	}
}
