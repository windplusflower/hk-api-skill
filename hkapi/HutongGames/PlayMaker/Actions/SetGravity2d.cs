using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000ADF RID: 2783
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Sets the gravity vector, or individual axis.")]
	public class SetGravity2d : FsmStateAction
	{
		// Token: 0x06003BCA RID: 15306 RVA: 0x00158E64 File Offset: 0x00157064
		public override void Reset()
		{
			this.vector = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00158E98 File Offset: 0x00157098
		public override void OnEnter()
		{
			this.DoSetGravity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x00158EAE File Offset: 0x001570AE
		public override void OnUpdate()
		{
			this.DoSetGravity();
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00158EB8 File Offset: 0x001570B8
		private void DoSetGravity()
		{
			Vector2 value = this.vector.Value;
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			Physics2D.gravity = value;
		}

		// Token: 0x04003F7D RID: 16253
		[Tooltip("Gravity as Vector2.")]
		public FsmVector2 vector;

		// Token: 0x04003F7E RID: 16254
		[Tooltip("Override the x value of the gravity")]
		public FsmFloat x;

		// Token: 0x04003F7F RID: 16255
		[Tooltip("Override the y value of the gravity")]
		public FsmFloat y;

		// Token: 0x04003F80 RID: 16256
		[Tooltip("Repeat every frame")]
		public bool everyFrame;
	}
}
