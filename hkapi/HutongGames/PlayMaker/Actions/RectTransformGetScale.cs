using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A1A RID: 2586
	[ActionCategory("RectTransform")]
	[Tooltip("Get the scale of RectTransform")]
	public class RectTransformGetScale : FsmStateActionAdvanced
	{
		// Token: 0x0600383D RID: 14397 RVA: 0x00149DD0 File Offset: 0x00147FD0
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.xScale = null;
			this.yScale = null;
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00149DF0 File Offset: 0x00147FF0
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

		// Token: 0x0600383F RID: 14399 RVA: 0x00149E38 File Offset: 0x00148038
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00149E40 File Offset: 0x00148040
		private void DoGetValues()
		{
			if (!this.xScale.IsNone)
			{
				this.xScale.Value = this._rt.localScale.x;
			}
			if (!this.yScale.IsNone)
			{
				this.yScale.Value = this._rt.localScale.y;
			}
		}

		// Token: 0x04003AD4 RID: 15060
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AD5 RID: 15061
		[UIHint(UIHint.Variable)]
		public FsmFloat xScale;

		// Token: 0x04003AD6 RID: 15062
		[UIHint(UIHint.Variable)]
		public FsmFloat yScale;

		// Token: 0x04003AD7 RID: 15063
		private RectTransform _rt;
	}
}
