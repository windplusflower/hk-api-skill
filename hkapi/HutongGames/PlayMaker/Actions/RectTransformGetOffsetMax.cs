using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A16 RID: 2582
	[ActionCategory("RectTransform")]
	[Tooltip("Get the offset of the upper right corner of the rectangle relative to the upper right anchor")]
	public class RectTransformGetOffsetMax : FsmStateActionAdvanced
	{
		// Token: 0x06003829 RID: 14377 RVA: 0x0014995B File Offset: 0x00147B5B
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.offsetMax = null;
			this.x = null;
			this.y = null;
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00149980 File Offset: 0x00147B80
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

		// Token: 0x0600382B RID: 14379 RVA: 0x001499C8 File Offset: 0x00147BC8
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x001499D0 File Offset: 0x00147BD0
		private void DoGetValues()
		{
			if (!this.offsetMax.IsNone)
			{
				this.offsetMax.Value = this._rt.offsetMax;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.offsetMax.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.offsetMax.y;
			}
		}

		// Token: 0x04003ABE RID: 15038
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003ABF RID: 15039
		[Tooltip("The offsetMax")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 offsetMax;

		// Token: 0x04003AC0 RID: 15040
		[Tooltip("The x component of the offsetMax")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AC1 RID: 15041
		[Tooltip("The y component of the offsetMax")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AC2 RID: 15042
		private RectTransform _rt;
	}
}
