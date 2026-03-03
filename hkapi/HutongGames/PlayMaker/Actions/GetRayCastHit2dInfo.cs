using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ACE RID: 2766
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Gets info on the last 2d Raycast or LineCast and store in variables.")]
	public class GetRayCastHit2dInfo : FsmStateAction
	{
		// Token: 0x06003B79 RID: 15225 RVA: 0x00157851 File Offset: 0x00155A51
		public override void Reset()
		{
			this.gameObjectHit = null;
			this.point = null;
			this.normal = null;
			this.distance = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B7A RID: 15226 RVA: 0x00157876 File Offset: 0x00155A76
		public override void OnEnter()
		{
			this.StoreRaycastInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B7B RID: 15227 RVA: 0x0015788C File Offset: 0x00155A8C
		public override void OnUpdate()
		{
			this.StoreRaycastInfo();
		}

		// Token: 0x06003B7C RID: 15228 RVA: 0x00157894 File Offset: 0x00155A94
		private void StoreRaycastInfo()
		{
			RaycastHit2D lastRaycastHit2DInfo = Fsm.GetLastRaycastHit2DInfo(base.Fsm);
			if (lastRaycastHit2DInfo.collider != null)
			{
				this.gameObjectHit.Value = lastRaycastHit2DInfo.collider.gameObject;
				this.point.Value = lastRaycastHit2DInfo.point;
				this.normal.Value = lastRaycastHit2DInfo.normal;
				this.distance.Value = lastRaycastHit2DInfo.fraction;
			}
		}

		// Token: 0x04003F06 RID: 16134
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the GameObject hit by the last Raycast and store it in a variable.")]
		public FsmGameObject gameObjectHit;

		// Token: 0x04003F07 RID: 16135
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the world position of the ray hit point and store it in a variable.")]
		[Title("Hit Point")]
		public FsmVector2 point;

		// Token: 0x04003F08 RID: 16136
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the normal at the hit point and store it in a variable.")]
		public FsmVector3 normal;

		// Token: 0x04003F09 RID: 16137
		[UIHint(UIHint.Variable)]
		[Tooltip("Get the distance along the ray to the hit point and store it in a variable.")]
		public FsmFloat distance;

		// Token: 0x04003F0A RID: 16138
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
