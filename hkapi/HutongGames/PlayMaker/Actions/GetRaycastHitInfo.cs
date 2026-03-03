using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C0C RID: 3084
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets info on the last Raycast and store in variables.")]
	public class GetRaycastHitInfo : FsmStateAction
	{
		// Token: 0x060040BD RID: 16573 RVA: 0x0016AD7F File Offset: 0x00168F7F
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.point = null;
			this.normal = null;
			this.distance = null;
			this.everyFrame = false;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x0016ADA4 File Offset: 0x00168FA4
		private void StoreRaycastInfo()
		{
			if (base.Fsm.RaycastHitInfo.collider != null)
			{
				this.gameObjectHit.Value = base.Fsm.RaycastHitInfo.collider.gameObject;
				this.point.Value = base.Fsm.RaycastHitInfo.point;
				this.normal.Value = base.Fsm.RaycastHitInfo.normal;
				this.distance.Value = base.Fsm.RaycastHitInfo.distance;
			}
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0016AE49 File Offset: 0x00169049
		public override void OnEnter()
		{
			this.StoreRaycastInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0016AE5F File Offset: 0x0016905F
		public override void OnUpdate()
		{
			this.StoreRaycastInfo();
		}

		// Token: 0x04004506 RID: 17670
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit by the last Raycast and store it in a variable.")]
		public FsmGameObject gameObjectHit;

		// Token: 0x04004507 RID: 17671
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the ray hit point and store it in a variable.")]
		[Title("Hit Point")]
		public FsmVector3 point;

		// Token: 0x04004508 RID: 17672
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the normal at the hit point and store it in a variable.")]
		public FsmVector3 normal;

		// Token: 0x04004509 RID: 17673
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat distance;

		// Token: 0x0400450A RID: 17674
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
