using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009B6 RID: 2486
	[ActionCategory("Math")]
	[Tooltip("Calculate the distance between two points and store it as a float.")]
	public class DistanceBetweenPoints2D : FsmStateAction
	{
		// Token: 0x06003668 RID: 13928 RVA: 0x00140BB0 File Offset: 0x0013EDB0
		public override void Reset()
		{
			this.distanceResult = null;
			this.point1 = null;
			this.point2 = null;
			this.everyFrame = false;
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00140BCE File Offset: 0x0013EDCE
		public override void OnEnter()
		{
			this.DoCalcDistance();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x00140BE4 File Offset: 0x0013EDE4
		public override void OnUpdate()
		{
			this.DoCalcDistance();
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x00140BEC File Offset: 0x0013EDEC
		private void DoCalcDistance()
		{
			if (this.distanceResult == null)
			{
				return;
			}
			Vector2 a = new Vector2(this.point1.Value.x, this.point1.Value.y);
			Vector2 b = new Vector2(this.point2.Value.x, this.point2.Value.y);
			float value = Vector2.Distance(a, b);
			this.distanceResult.Value = value;
		}

		// Token: 0x04003832 RID: 14386
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat distanceResult;

		// Token: 0x04003833 RID: 14387
		[RequiredField]
		public FsmVector2 point1;

		// Token: 0x04003834 RID: 14388
		[RequiredField]
		public FsmVector2 point2;

		// Token: 0x04003835 RID: 14389
		public bool everyFrame;
	}
}
