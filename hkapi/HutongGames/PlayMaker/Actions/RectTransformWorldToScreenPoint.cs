using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A29 RID: 2601
	[ActionCategory("RectTransform")]
	[Tooltip("RectTransforms position from world space into screen space. Leave the camera to none for default behavior")]
	public class RectTransformWorldToScreenPoint : FsmStateActionAdvanced
	{
		// Token: 0x06003883 RID: 14467 RVA: 0x0014AFC4 File Offset: 0x001491C4
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.camera = new FsmOwnerDefault();
			this.camera.OwnerOption = OwnerDefaultOption.SpecifyGameObject;
			this.camera.GameObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.screenPoint = null;
			this.screenX = null;
			this.screenY = null;
			this.everyFrame = false;
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x0014B028 File Offset: 0x00149228
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			if (base.Fsm.GetOwnerDefaultTarget(this.camera) != null)
			{
				this._cam = ownerDefaultTarget.GetComponent<Camera>();
			}
			this.DoWorldToScreenPoint();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x0014B095 File Offset: 0x00149295
		public override void OnActionUpdate()
		{
			this.DoWorldToScreenPoint();
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x0014B0A0 File Offset: 0x001492A0
		private void DoWorldToScreenPoint()
		{
			Vector2 vector = RectTransformUtility.WorldToScreenPoint(this._cam, this._rt.position);
			if (this.normalize.Value)
			{
				vector.x /= (float)Screen.width;
				vector.y /= (float)Screen.height;
			}
			this.screenPoint.Value = vector;
			this.screenX.Value = vector.x;
			this.screenY.Value = vector.y;
		}

		// Token: 0x04003B2A RID: 15146
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003B2B RID: 15147
		[CheckForComponent(typeof(Camera))]
		[Tooltip("The camera to perform the calculation. Leave to none for default behavior")]
		public FsmOwnerDefault camera;

		// Token: 0x04003B2C RID: 15148
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen position in a Vector3 Variable. Z will equal zero.")]
		public FsmVector3 screenPoint;

		// Token: 0x04003B2D RID: 15149
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen X position in a Float Variable.")]
		public FsmFloat screenX;

		// Token: 0x04003B2E RID: 15150
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the screen Y position in a Float Variable.")]
		public FsmFloat screenY;

		// Token: 0x04003B2F RID: 15151
		[Tooltip("Normalize screen coordinates (0-1). Otherwise coordinates are in pixels.")]
		public FsmBool normalize;

		// Token: 0x04003B30 RID: 15152
		private RectTransform _rt;

		// Token: 0x04003B31 RID: 15153
		private Camera _cam;
	}
}
