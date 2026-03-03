using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ADA RID: 2778
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Perform a Mouse Pick on a 2d scene and stores the results. Use Ray Distance to set how close the camera must be to pick the 2d object.")]
	public class MousePick2d : FsmStateAction
	{
		// Token: 0x06003BB1 RID: 15281 RVA: 0x00158441 File Offset: 0x00156641
		public override void Reset()
		{
			this.storeDidPickObject = null;
			this.storeGameObject = null;
			this.storePoint = null;
			this.layerMask = new FsmInt[0];
			this.invertMask = false;
			this.everyFrame = false;
		}

		// Token: 0x06003BB2 RID: 15282 RVA: 0x00158477 File Offset: 0x00156677
		public override void OnEnter()
		{
			this.DoMousePick2d();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BB3 RID: 15283 RVA: 0x0015848D File Offset: 0x0015668D
		public override void OnUpdate()
		{
			this.DoMousePick2d();
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x00158498 File Offset: 0x00156698
		private void DoMousePick2d()
		{
			RaycastHit2D rayIntersection = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition), float.PositiveInfinity, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
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

		// Token: 0x04003F4D RID: 16205
		[UIHint(UIHint.Variable)]
		[Tooltip("Store if a GameObject was picked in a Bool variable. True if a GameObject was picked, otherwise false.")]
		public FsmBool storeDidPickObject;

		// Token: 0x04003F4E RID: 16206
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked GameObject in a variable.")]
		public FsmGameObject storeGameObject;

		// Token: 0x04003F4F RID: 16207
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked point in a variable.")]
		public FsmVector2 storePoint;

		// Token: 0x04003F50 RID: 16208
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04003F51 RID: 16209
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04003F52 RID: 16210
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
