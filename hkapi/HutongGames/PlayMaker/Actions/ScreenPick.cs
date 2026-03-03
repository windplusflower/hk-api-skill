using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C80 RID: 3200
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Perform a raycast into the scene using screen coordinates and stores the results. Use Ray Distance to set how close the camera must be to pick the object. NOTE: Uses the MainCamera!")]
	public class ScreenPick : FsmStateAction
	{
		// Token: 0x060042E8 RID: 17128 RVA: 0x001714BC File Offset: 0x0016F6BC
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
			this.rayDistance = 100f;
			this.storeDidPickObject = null;
			this.storeGameObject = null;
			this.storePoint = null;
			this.storeNormal = null;
			this.storeDistance = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.everyFrame = false;
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x0017155D File Offset: 0x0016F75D
		public override void OnEnter()
		{
			this.DoScreenPick();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x00171573 File Offset: 0x0016F773
		public override void OnUpdate()
		{
			this.DoScreenPick();
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x0017157C File Offset: 0x0016F77C
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
			RaycastHit raycastHit;
			Physics.Raycast(Camera.main.ScreenPointToRay(pos), out raycastHit, this.rayDistance.Value, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
			bool flag = raycastHit.collider != null;
			this.storeDidPickObject.Value = flag;
			if (flag)
			{
				this.storeGameObject.Value = raycastHit.collider.gameObject;
				this.storeDistance.Value = raycastHit.distance;
				this.storePoint.Value = raycastHit.point;
				this.storeNormal.Value = raycastHit.normal;
				return;
			}
			this.storeGameObject.Value = null;
			this.storeDistance = float.PositiveInfinity;
			this.storePoint.Value = Vector3.zero;
			this.storeNormal.Value = Vector3.zero;
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x0017170F File Offset: 0x0016F90F
		public ScreenPick()
		{
			this.rayDistance = 100f;
			base..ctor();
		}

		// Token: 0x0400472A RID: 18218
		[Tooltip("A Vector3 screen position. Commonly stored by other actions.")]
		public FsmVector3 screenVector;

		// Token: 0x0400472B RID: 18219
		[Tooltip("X position on screen.")]
		public FsmFloat screenX;

		// Token: 0x0400472C RID: 18220
		[Tooltip("Y position on screen.")]
		public FsmFloat screenY;

		// Token: 0x0400472D RID: 18221
		[Tooltip("Are the supplied screen coordinates normalized (0-1), or in pixels.")]
		public FsmBool normalized;

		// Token: 0x0400472E RID: 18222
		[RequiredField]
		public FsmFloat rayDistance;

		// Token: 0x0400472F RID: 18223
		[UIHint(UIHint.Variable)]
		public FsmBool storeDidPickObject;

		// Token: 0x04004730 RID: 18224
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;

		// Token: 0x04004731 RID: 18225
		[UIHint(UIHint.Variable)]
		public FsmVector3 storePoint;

		// Token: 0x04004732 RID: 18226
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeNormal;

		// Token: 0x04004733 RID: 18227
		[UIHint(UIHint.Variable)]
		public FsmFloat storeDistance;

		// Token: 0x04004734 RID: 18228
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04004735 RID: 18229
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04004736 RID: 18230
		public bool everyFrame;
	}
}
