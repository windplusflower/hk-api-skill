using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A8 RID: 2472
	[ActionCategory("Math")]
	[Tooltip("Calculate the distance between two points and compare it against a known distance value.")]
	public class CompareDistance2D : FsmStateAction
	{
		// Token: 0x06003626 RID: 13862 RVA: 0x0013FA4E File Offset: 0x0013DC4E
		public override void Reset()
		{
			this.point1 = null;
			this.point2 = null;
			this.knownDistance = null;
			this.everyFrame = false;
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0013FA6C File Offset: 0x0013DC6C
		public override void OnEnter()
		{
			this.sqrDistanceTest = this.knownDistance.Value * this.knownDistance.Value;
			this.DoCompareDistance();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0013FA9F File Offset: 0x0013DC9F
		public override void OnUpdate()
		{
			this.DoCompareDistance();
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00003603 File Offset: 0x00001803
		private void DoCalcDistance()
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x0013FAA8 File Offset: 0x0013DCA8
		private void DoCompareDistance()
		{
			Vector2 a = new Vector2(this.point1.Value.x, this.point1.Value.y);
			Vector2 b = new Vector2(this.point2.Value.x, this.point2.Value.y);
			float magnitude = (a - b).magnitude;
			float value = this.knownDistance.Value;
		}

		// Token: 0x04003802 RID: 14338
		[RequiredField]
		public FsmVector2 point1;

		// Token: 0x04003803 RID: 14339
		[RequiredField]
		public FsmVector2 point2;

		// Token: 0x04003804 RID: 14340
		[RequiredField]
		public FsmFloat knownDistance;

		// Token: 0x04003805 RID: 14341
		public bool everyFrame;

		// Token: 0x04003806 RID: 14342
		private float sqrDistanceTest;
	}
}
