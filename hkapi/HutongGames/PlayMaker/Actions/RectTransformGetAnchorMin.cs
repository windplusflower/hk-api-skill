using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A11 RID: 2577
	[ActionCategory("RectTransform")]
	[Tooltip("Get the normalized position in the parent RectTransform that the lower left corner is anchored to.")]
	public class RectTransformGetAnchorMin : FsmStateActionAdvanced
	{
		// Token: 0x06003815 RID: 14357 RVA: 0x00149468 File Offset: 0x00147668
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.anchorMin = null;
			this.x = null;
			this.y = null;
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x0014948C File Offset: 0x0014768C
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

		// Token: 0x06003817 RID: 14359 RVA: 0x001494D4 File Offset: 0x001476D4
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x001494DC File Offset: 0x001476DC
		private void DoGetValues()
		{
			if (!this.anchorMin.IsNone)
			{
				this.anchorMin.Value = this._rt.anchorMin;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.anchorMin.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.anchorMin.y;
			}
		}

		// Token: 0x04003AA3 RID: 15011
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AA4 RID: 15012
		[Tooltip("The anchorMin")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 anchorMin;

		// Token: 0x04003AA5 RID: 15013
		[Tooltip("The x component of the anchorMin")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AA6 RID: 15014
		[Tooltip("The y component of the anchorMin")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AA7 RID: 15015
		private RectTransform _rt;
	}
}
