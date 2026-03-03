using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009C1 RID: 2497
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Fling")]
	public class FlingObject : RigidBody2dActionBase
	{
		// Token: 0x060036AC RID: 13996 RVA: 0x00142BFC File Offset: 0x00140DFC
		public override void Reset()
		{
			this.flungObject = null;
			this.speedMin = null;
			this.speedMax = null;
			this.angleMin = null;
			this.angleMax = null;
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00142C24 File Offset: 0x00140E24
		public override void OnEnter()
		{
			if (this.flungObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.flungObject);
				if (ownerDefaultTarget != null)
				{
					float num = UnityEngine.Random.Range(this.speedMin.Value, this.speedMax.Value);
					float num2 = UnityEngine.Random.Range(this.angleMin.Value, this.angleMax.Value);
					this.vectorX = num * Mathf.Cos(num2 * 0.017453292f);
					this.vectorY = num * Mathf.Sin(num2 * 0.017453292f);
					Vector2 velocity;
					velocity.x = this.vectorX;
					velocity.y = this.vectorY;
					base.CacheRigidBody2d(ownerDefaultTarget);
					this.rb2d.velocity = velocity;
				}
			}
			base.Finish();
		}

		// Token: 0x04003899 RID: 14489
		[RequiredField]
		public FsmOwnerDefault flungObject;

		// Token: 0x0400389A RID: 14490
		public FsmFloat speedMin;

		// Token: 0x0400389B RID: 14491
		public FsmFloat speedMax;

		// Token: 0x0400389C RID: 14492
		public FsmFloat angleMin;

		// Token: 0x0400389D RID: 14493
		public FsmFloat angleMax;

		// Token: 0x0400389E RID: 14494
		private float vectorX;

		// Token: 0x0400389F RID: 14495
		private float vectorY;

		// Token: 0x040038A0 RID: 14496
		private bool originAdjusted;
	}
}
