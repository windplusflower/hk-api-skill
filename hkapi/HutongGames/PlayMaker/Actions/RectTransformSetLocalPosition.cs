using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A23 RID: 2595
	[ActionCategory("RectTransform")]
	[Tooltip("Set the local position of this RectTransform.")]
	public class RectTransformSetLocalPosition : FsmStateActionAdvanced
	{
		// Token: 0x06003865 RID: 14437 RVA: 0x0014A89C File Offset: 0x00148A9C
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.position2d = new FsmVector2
			{
				UseVariable = true
			};
			this.position = new FsmVector3
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

		// Token: 0x06003866 RID: 14438 RVA: 0x0014A910 File Offset: 0x00148B10
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

		// Token: 0x06003867 RID: 14439 RVA: 0x0014A958 File Offset: 0x00148B58
		public override void OnActionUpdate()
		{
			this.DoSetValues();
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x0014A960 File Offset: 0x00148B60
		private void DoSetValues()
		{
			if (this._rt == null)
			{
				return;
			}
			Vector3 localPosition = this._rt.localPosition;
			if (!this.position.IsNone)
			{
				localPosition = this.position.Value;
			}
			if (!this.position2d.IsNone)
			{
				localPosition.x = this.position2d.Value.x;
				localPosition.y = this.position2d.Value.y;
			}
			if (!this.x.IsNone)
			{
				localPosition.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				localPosition.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				localPosition.z = this.z.Value;
			}
			this._rt.localPosition = localPosition;
		}

		// Token: 0x04003B09 RID: 15113
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B0A RID: 15114
		[Tooltip("The position. Set to none for no effect")]
		public FsmVector2 position2d;

		// Token: 0x04003B0B RID: 15115
		[Tooltip("Or the 3d position. Set to none for no effect")]
		public FsmVector3 position;

		// Token: 0x04003B0C RID: 15116
		[Tooltip("The x component of the rotation. Set to none for no effect")]
		public FsmFloat x;

		// Token: 0x04003B0D RID: 15117
		[Tooltip("The y component of the rotation. Set to none for no effect")]
		public FsmFloat y;

		// Token: 0x04003B0E RID: 15118
		[Tooltip("The z component of the rotation. Set to none for no effect")]
		public FsmFloat z;

		// Token: 0x04003B0F RID: 15119
		private RectTransform _rt;
	}
}
