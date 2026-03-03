using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A12 RID: 2578
	[ActionCategory("RectTransform")]
	[Tooltip("Get the position of the pivot of this RectTransform relative to the anchor reference point.")]
	public class RectTransformGetAnchoredPosition : FsmStateActionAdvanced
	{
		// Token: 0x0600381A RID: 14362 RVA: 0x0014955C File Offset: 0x0014775C
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.position = null;
			this.x = null;
			this.y = null;
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00149580 File Offset: 0x00147780
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

		// Token: 0x0600381C RID: 14364 RVA: 0x001495C8 File Offset: 0x001477C8
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x001495D0 File Offset: 0x001477D0
		private void DoGetValues()
		{
			if (!this.position.IsNone)
			{
				this.position.Value = this._rt.anchoredPosition;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.anchoredPosition.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.anchoredPosition.y;
			}
		}

		// Token: 0x04003AA8 RID: 15016
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AA9 RID: 15017
		[Tooltip("The anchored Position")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 position;

		// Token: 0x04003AAA RID: 15018
		[Tooltip("The x component of the anchored Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AAB RID: 15019
		[Tooltip("The y component of the anchored Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AAC RID: 15020
		private RectTransform _rt;
	}
}
