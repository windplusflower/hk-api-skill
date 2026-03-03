using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ADE RID: 2782
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Perform a raycast into the 2d scene using screen coordinates and stores the results. Use Ray Distance to set how close the camera must be to pick the 2d object. NOTE: Uses the MainCamera!")]
	public class ScreenPick2d : FsmStateAction
	{
		// Token: 0x06003BC5 RID: 15301 RVA: 0x00158C74 File Offset: 0x00156E74
		public override void Reset()
		{
			this.screenVector = new FsmVector3
			{
				UseVariable = true
			};
			this.screenX = new FsmFloat
			{
				UseVariable = true
			};
			this.screenY = new FsmFloat
			{
				UseVariable = true
			};
			this.normalized = false;
			this.storeDidPickObject = null;
			this.storeGameObject = null;
			this.storePoint = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.everyFrame = false;
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00158CF7 File Offset: 0x00156EF7
		public override void OnEnter()
		{
			this.DoScreenPick();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00158D0D File Offset: 0x00156F0D
		public override void OnUpdate()
		{
			this.DoScreenPick();
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00158D18 File Offset: 0x00156F18
		private void DoScreenPick()
		{
			if (Camera.main == null)
			{
				base.LogError("No MainCamera defined!");
				base.Finish();
				return;
			}
			Vector3 pos = Vector3.zero;
			if (!this.screenVector.IsNone)
			{
				pos = this.screenVector.Value;
			}
			if (!this.screenX.IsNone)
			{
				pos.x = this.screenX.Value;
			}
			if (!this.screenY.IsNone)
			{
				pos.y = this.screenY.Value;
			}
			if (this.normalized.Value)
			{
				pos.x *= (float)Screen.width;
				pos.y *= (float)Screen.height;
			}
			RaycastHit2D rayIntersection = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(pos), float.PositiveInfinity, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			bool flag = rayIntersection.collider != null;
			this.storeDidPickObject.Value = flag;
			if (flag)
			{
				this.storeGameObject.Value = rayIntersection.collider.gameObject;
				this.storePoint.Value = rayIntersection.point;
				return;
			}
			this.storeGameObject.Value = null;
			this.storePoint.Value = Vector3.zero;
		}

		// Token: 0x04003F73 RID: 16243
		[Tooltip("A Vector3 screen position. Commonly stored by other actions.")]
		public FsmVector3 screenVector;

		// Token: 0x04003F74 RID: 16244
		[Tooltip("X position on screen.")]
		public FsmFloat screenX;

		// Token: 0x04003F75 RID: 16245
		[Tooltip("Y position on screen.")]
		public FsmFloat screenY;

		// Token: 0x04003F76 RID: 16246
		[Tooltip("Are the supplied screen coordinates normalized (0-1), or in pixels.")]
		public FsmBool normalized;

		// Token: 0x04003F77 RID: 16247
		[UIHint(UIHint.Variable)]
		[Tooltip("Store whether the Screen pick did pick a GameObject")]
		public FsmBool storeDidPickObject;

		// Token: 0x04003F78 RID: 16248
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked GameObject")]
		public FsmGameObject storeGameObject;

		// Token: 0x04003F79 RID: 16249
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked position in world Space")]
		public FsmVector3 storePoint;

		// Token: 0x04003F7A RID: 16250
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003F7B RID: 16251
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003F7C RID: 16252
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
