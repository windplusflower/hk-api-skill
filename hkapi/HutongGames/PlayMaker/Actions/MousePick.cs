using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C3F RID: 3135
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Perform a Mouse Pick on the scene from the Main Camera and stores the results. Use Ray Distance to set how close the camera must be to pick the object.")]
	public class MousePick : FsmStateAction
	{
		// Token: 0x060041A0 RID: 16800 RVA: 0x0016D400 File Offset: 0x0016B600
		public override void Reset()
		{
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

		// Token: 0x060041A1 RID: 16801 RVA: 0x0016D45F File Offset: 0x0016B65F
		public override void OnEnter()
		{
			this.DoMousePick();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x0016D475 File Offset: 0x0016B675
		public override void OnUpdate()
		{
			this.DoMousePick();
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x0016D480 File Offset: 0x0016B680
		private void DoMousePick()
		{
			RaycastHit raycastHit = ActionHelpers.MousePick(this.rayDistance.Value, ActionHelpers.LayerArrayToLayerMask(this.layerMask, this.invertMask.Value));
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
			this.storeDistance.Value = float.PositiveInfinity;
			this.storePoint.Value = Vector3.zero;
			this.storeNormal.Value = Vector3.zero;
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x0016D55B File Offset: 0x0016B75B
		public MousePick()
		{
			this.rayDistance = 100f;
			base..ctor();
		}

		// Token: 0x040045FA RID: 17914
		[RequiredField]
		[Tooltip("Set the length of the ray to cast from the Main Camera.")]
		public FsmFloat rayDistance;

		// Token: 0x040045FB RID: 17915
		[UIHint(UIHint.Variable)]
		[Tooltip("Set Bool variable true if an object was picked, false if not.")]
		public FsmBool storeDidPickObject;

		// Token: 0x040045FC RID: 17916
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the picked GameObject.")]
		public FsmGameObject storeGameObject;

		// Token: 0x040045FD RID: 17917
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the point of contact.")]
		public FsmVector3 storePoint;

		// Token: 0x040045FE RID: 17918
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the normal at the point of contact.")]
		public FsmVector3 storeNormal;

		// Token: 0x040045FF RID: 17919
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance to the point of contact.")]
		public FsmFloat storeDistance;

		// Token: 0x04004600 RID: 17920
		[UIHint(UIHint.Layer)]
		[Tooltip("Pick only from these layers.")]
		public FsmInt[] layerMask;

		// Token: 0x04004601 RID: 17921
		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		// Token: 0x04004602 RID: 17922
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
