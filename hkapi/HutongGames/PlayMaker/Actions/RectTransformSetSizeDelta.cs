using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A28 RID: 2600
	[ActionCategory("RectTransform")]
	[Tooltip("Set the size of this RectTransform relative to the distances between the anchors. this is the 'Width' and 'Height' values in the RectTransform inspector.")]
	public class RectTransformSetSizeDelta : FsmStateActionAdvanced
	{
		// Token: 0x0600387E RID: 14462 RVA: 0x0014AEBC File Offset: 0x001490BC
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.sizeDelta = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x0014AEF8 File Offset: 0x001490F8
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetSizeDelta();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x0014AF40 File Offset: 0x00149140
		public override void OnActionUpdate()
		{
			this.DoSetSizeDelta();
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0014AF48 File Offset: 0x00149148
		private void DoSetSizeDelta()
		{
			Vector2 value = this._rt.sizeDelta;
			if (!this.sizeDelta.IsNone)
			{
				value = this.sizeDelta.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this._rt.sizeDelta = value;
		}

		// Token: 0x04003B25 RID: 15141
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B26 RID: 15142
		[Tooltip("TheVector2 sizeDelta. Set to none for no effect, and/or set individual axis below.")]
		public FsmVector2 sizeDelta;

		// Token: 0x04003B27 RID: 15143
		[Tooltip("Setting only the x value. Overides sizeDelta x value if set. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B28 RID: 15144
		[Tooltip("Setting only the x value. Overides sizeDelta y value if set. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B29 RID: 15145
		private RectTransform _rt;
	}
}
