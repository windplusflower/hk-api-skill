using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A18 RID: 2584
	[ActionCategory("RectTransform")]
	[Tooltip("Get the normalized position in this RectTransform that it rotates around.")]
	public class RectTransformGetPivot : FsmStateActionAdvanced
	{
		// Token: 0x06003833 RID: 14387 RVA: 0x00149B44 File Offset: 0x00147D44
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.pivot = null;
			this.x = null;
			this.y = null;
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00149B68 File Offset: 0x00147D68
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

		// Token: 0x06003835 RID: 14389 RVA: 0x00149BB0 File Offset: 0x00147DB0
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00149BB8 File Offset: 0x00147DB8
		private void DoGetValues()
		{
			if (!this.pivot.IsNone)
			{
				this.pivot.Value = this._rt.pivot;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.pivot.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.pivot.y;
			}
		}

		// Token: 0x04003AC8 RID: 15048
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AC9 RID: 15049
		[Tooltip("The pivot")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 pivot;

		// Token: 0x04003ACA RID: 15050
		[Tooltip("The x component of the pivot")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003ACB RID: 15051
		[Tooltip("The y component of the pivot")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003ACC RID: 15052
		private RectTransform _rt;
	}
}
