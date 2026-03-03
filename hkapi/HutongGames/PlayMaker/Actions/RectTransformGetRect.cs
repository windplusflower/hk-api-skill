using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A19 RID: 2585
	[ActionCategory("RectTransform")]
	[Tooltip("The calculated rectangle in the local space of the Transform.")]
	public class RectTransformGetRect : FsmStateActionAdvanced
	{
		// Token: 0x06003838 RID: 14392 RVA: 0x00149C38 File Offset: 0x00147E38
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.rect = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.width = new FsmFloat
			{
				UseVariable = true
			};
			this.height = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00149CA4 File Offset: 0x00147EA4
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

		// Token: 0x0600383A RID: 14394 RVA: 0x00149CEC File Offset: 0x00147EEC
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x00149CF4 File Offset: 0x00147EF4
		private void DoGetValues()
		{
			if (!this.rect.IsNone)
			{
				this.rect.Value = this._rt.rect;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.rect.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.rect.y;
			}
			if (!this.width.IsNone)
			{
				this.width.Value = this._rt.rect.width;
			}
			if (!this.height.IsNone)
			{
				this.height.Value = this._rt.rect.height;
			}
		}

		// Token: 0x04003ACD RID: 15053
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003ACE RID: 15054
		[UIHint(UIHint.Variable)]
		[Tooltip("The rect")]
		public FsmRect rect;

		// Token: 0x04003ACF RID: 15055
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AD0 RID: 15056
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AD1 RID: 15057
		[UIHint(UIHint.Variable)]
		public FsmFloat width;

		// Token: 0x04003AD2 RID: 15058
		[UIHint(UIHint.Variable)]
		public FsmFloat height;

		// Token: 0x04003AD3 RID: 15059
		private RectTransform _rt;
	}
}
