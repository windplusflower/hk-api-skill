using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A24 RID: 2596
	[ActionCategory("RectTransform")]
	[Tooltip("Set the local rotation of this RectTransform.")]
	public class RectTransformSetLocalRotation : FsmStateActionAdvanced
	{
		// Token: 0x0600386A RID: 14442 RVA: 0x0014AA48 File Offset: 0x00148C48
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

		// Token: 0x0600386B RID: 14443 RVA: 0x0014AAAC File Offset: 0x00148CAC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetValues();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x0014AAF4 File Offset: 0x00148CF4
		public override void OnActionUpdate()
		{
			this.DoSetValues();
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x0014AAFC File Offset: 0x00148CFC
		private void DoSetValues()
		{
			if (this._rt == null)
			{
				return;
			}
			Vector3 eulerAngles = this._rt.eulerAngles;
			if (!this.rotation.IsNone)
			{
				eulerAngles = this.rotation.Value;
			}
			if (!this.x.IsNone)
			{
				eulerAngles.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				eulerAngles.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				eulerAngles.z = this.z.Value;
			}
			this._rt.eulerAngles = eulerAngles;
		}

		// Token: 0x04003B10 RID: 15120
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B11 RID: 15121
		[Tooltip("The rotation. Set to none for no effect")]
		public FsmVector3 rotation;

		// Token: 0x04003B12 RID: 15122
		[Tooltip("The x component of the rotation. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B13 RID: 15123
		[Tooltip("The y component of the rotation. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B14 RID: 15124
		[Tooltip("The z component of the rotation. Set to none for no effect")]
		public FsmFloat z;

		// Token: 0x04003B15 RID: 15125
		private RectTransform _rt;
	}
}
