using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BD9 RID: 3033
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets the last measured linear acceleration of a device and stores it in a Vector3 Variable.")]
	public class GetDeviceAcceleration : FsmStateAction
	{
		// Token: 0x06003FE0 RID: 16352 RVA: 0x00168A0D File Offset: 0x00166C0D
		public override void Reset()
		{
			this.storeVector = null;
			this.storeX = null;
			this.storeY = null;
			this.storeZ = null;
			this.multiplier = 1f;
			this.everyFrame = false;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x00168A42 File Offset: 0x00166C42
		public override void OnEnter()
		{
			this.DoGetDeviceAcceleration();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x00168A58 File Offset: 0x00166C58
		public override void OnUpdate()
		{
			this.DoGetDeviceAcceleration();
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x00168A60 File Offset: 0x00166C60
		private void DoGetDeviceAcceleration()
		{
			Vector3 vector = new Vector3(Input.acceleration.x, Input.acceleration.y, Input.acceleration.z);
			if (!this.multiplier.IsNone)
			{
				vector *= this.multiplier.Value;
			}
			this.storeVector.Value = vector;
			this.storeX.Value = vector.x;
			this.storeY.Value = vector.y;
			this.storeZ.Value = vector.z;
		}

		// Token: 0x04004413 RID: 17427
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeVector;

		// Token: 0x04004414 RID: 17428
		[UIHint(UIHint.Variable)]
		public FsmFloat storeX;

		// Token: 0x04004415 RID: 17429
		[UIHint(UIHint.Variable)]
		public FsmFloat storeY;

		// Token: 0x04004416 RID: 17430
		[UIHint(UIHint.Variable)]
		public FsmFloat storeZ;

		// Token: 0x04004417 RID: 17431
		public FsmFloat multiplier;

		// Token: 0x04004418 RID: 17432
		public bool everyFrame;
	}
}
