using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A1B RID: 2587
	[ActionCategory("RectTransform")]
	[Tooltip("Get the size of this RectTransform relative to the distances between the anchors. this is the 'Width' and 'Height' values in the RectTransform inspector.")]
	public class RectTransformGetSizeDelta : FsmStateActionAdvanced
	{
		// Token: 0x06003842 RID: 14402 RVA: 0x00149E9D File Offset: 0x0014809D
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.sizeDelta = null;
			this.width = null;
			this.height = null;
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00149EC4 File Offset: 0x001480C4
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

		// Token: 0x06003844 RID: 14404 RVA: 0x00149F0C File Offset: 0x0014810C
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003845 RID: 14405 RVA: 0x00149F14 File Offset: 0x00148114
		private void DoGetValues()
		{
			if (!this.sizeDelta.IsNone)
			{
				this.sizeDelta.Value = this._rt.sizeDelta;
			}
			if (!this.width.IsNone)
			{
				this.width.Value = this._rt.sizeDelta.x;
			}
			if (!this.height.IsNone)
			{
				this.height.Value = this._rt.sizeDelta.y;
			}
		}

		// Token: 0x04003AD8 RID: 15064
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AD9 RID: 15065
		[Tooltip("The sizeDelta")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 sizeDelta;

		// Token: 0x04003ADA RID: 15066
		[Tooltip("The x component of the sizeDelta, the width.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat width;

		// Token: 0x04003ADB RID: 15067
		[Tooltip("The y component of the sizeDelta, the height")]
		[UIHint(UIHint.Variable)]
		public FsmFloat height;

		// Token: 0x04003ADC RID: 15068
		private RectTransform _rt;
	}
}
