using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B5 RID: 2485
	[ActionCategory("Math")]
	[Tooltip("Calculate the distance between two points and store it as a float.")]
	public class DistanceBetweenPoints : FsmStateAction
	{
		// Token: 0x06003663 RID: 13923 RVA: 0x00140A6C File Offset: 0x0013EC6C
		public override void Reset()
		{
			this.distanceResult = null;
			this.point1 = null;
			this.point2 = null;
			this.everyFrame = false;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x00140A8A File Offset: 0x0013EC8A
		public override void OnEnter()
		{
			this.DoCalcDistance();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x00140AA0 File Offset: 0x0013ECA0
		public override void OnUpdate()
		{
			this.DoCalcDistance();
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x00140AA8 File Offset: 0x0013ECA8
		private void DoCalcDistance()
		{
			if (this.distanceResult == null)
			{
				return;
			}
			if (this.ignoreZ)
			{
				Vector2 a = new Vector2(this.point1.Value.x, this.point1.Value.y);
				Vector2 b = new Vector2(this.point2.Value.x, this.point2.Value.y);
				this.distanceResult.Value = Vector2.Distance(a, b);
				return;
			}
			Vector3 a2 = new Vector3(this.point1.Value.x, this.point1.Value.y, this.point1.Value.z);
			Vector2 v = new Vector3(this.point2.Value.x, this.point2.Value.y, this.point2.Value.z);
			this.distanceResult.Value = Vector3.Distance(a2, v);
		}

		// Token: 0x0400382D RID: 14381
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat distanceResult;

		// Token: 0x0400382E RID: 14382
		[RequiredField]
		public FsmVector3 point1;

		// Token: 0x0400382F RID: 14383
		[RequiredField]
		public FsmVector3 point2;

		// Token: 0x04003830 RID: 14384
		public bool ignoreZ;

		// Token: 0x04003831 RID: 14385
		public bool everyFrame;
	}
}
