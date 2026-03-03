using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A15 RID: 2581
	[ActionCategory("RectTransform")]
	[Tooltip("Gets the local rotation of this RectTransform.")]
	public class RectTransformGetLocalRotation : FsmStateActionAdvanced
	{
		// Token: 0x06003824 RID: 14372 RVA: 0x001497F0 File Offset: 0x001479F0
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.rotation = new FsmVector3
			{
				UseVariable = true
			};
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.z = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00149854 File Offset: 0x00147A54
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

		// Token: 0x06003826 RID: 14374 RVA: 0x0014989C File Offset: 0x00147A9C
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x001498A4 File Offset: 0x00147AA4
		private void DoGetValues()
		{
			if (this._rt == null)
			{
				return;
			}
			if (!this.rotation.IsNone)
			{
				this.rotation.Value = this._rt.eulerAngles;
			}
			if (!this.x.IsNone)
			{
				this.x.Value = this._rt.eulerAngles.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = this._rt.eulerAngles.y;
			}
			if (!this.z.IsNone)
			{
				this.z.Value = this._rt.eulerAngles.z;
			}
		}

		// Token: 0x04003AB8 RID: 15032
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AB9 RID: 15033
		[Tooltip("The rotation")]
		public FsmVector3 rotation;

		// Token: 0x04003ABA RID: 15034
		[Tooltip("The x component of the rotation")]
		public FsmFloat x;

		// Token: 0x04003ABB RID: 15035
		[Tooltip("The y component of the rotation")]
		public FsmFloat y;

		// Token: 0x04003ABC RID: 15036
		[Tooltip("The z component of the rotation")]
		public FsmFloat z;

		// Token: 0x04003ABD RID: 15037
		private RectTransform _rt;
	}
}
