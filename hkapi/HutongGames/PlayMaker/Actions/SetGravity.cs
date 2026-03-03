using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC0 RID: 3264
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sets the gravity vector, or individual axis.")]
	public class SetGravity : FsmStateAction
	{
		// Token: 0x060043FB RID: 17403 RVA: 0x00174AEC File Offset: 0x00172CEC
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
			this.z = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x00174B3D File Offset: 0x00172D3D
		public override void OnEnter()
		{
			this.DoSetGravity();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00174B53 File Offset: 0x00172D53
		public override void OnUpdate()
		{
			this.DoSetGravity();
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00174B5C File Offset: 0x00172D5C
		private void DoSetGravity()
		{
			Vector3 value = this.vector.Value;
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				value.z = this.z.Value;
			}
			Physics.gravity = value;
		}

		// Token: 0x0400485F RID: 18527
		public FsmVector3 vector;

		// Token: 0x04004860 RID: 18528
		public FsmFloat x;

		// Token: 0x04004861 RID: 18529
		public FsmFloat y;

		// Token: 0x04004862 RID: 18530
		public FsmFloat z;

		// Token: 0x04004863 RID: 18531
		public bool everyFrame;
	}
}
