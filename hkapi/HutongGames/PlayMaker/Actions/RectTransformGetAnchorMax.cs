using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A10 RID: 2576
	[ActionCategory("RectTransform")]
	[Tooltip("Get the normalized position in the parent RectTransform that the upper right corner is anchored to.")]
	public class RectTransformGetAnchorMax : FsmStateActionAdvanced
	{
		// Token: 0x06003810 RID: 14352 RVA: 0x00149369 File Offset: 0x00147569
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.anchorMax = null;
			this.x = null;
			this.y = null;
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00149390 File Offset: 0x00147590
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

		// Token: 0x06003812 RID: 14354 RVA: 0x001493D8 File Offset: 0x001475D8
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x001493E0 File Offset: 0x001475E0
		private void DoGetValues()
		{
			if (!this.anchorMax.IsNone)
			{
				this.anchorMax.Value = this._rt.anchorMax;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.anchorMax.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.anchorMax.y;
			}
		}

		// Token: 0x04003A9E RID: 15006
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A9F RID: 15007
		[Tooltip("The anchorMax")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 anchorMax;

		// Token: 0x04003AA0 RID: 15008
		[Tooltip("The x component of the anchorMax")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AA1 RID: 15009
		[Tooltip("The y component of the anchorMax")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AA2 RID: 15010
		private RectTransform _rt;
	}
}
