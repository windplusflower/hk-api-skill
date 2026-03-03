using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009CD RID: 2509
	[ActionCategory("Math")]
	[Tooltip("Get the angle between two vector3 positions. 0 is right, 90 is up etc.")]
	public class GetAngleBetweenPoints : FsmStateAction
	{
		// Token: 0x060036E3 RID: 14051 RVA: 0x00003603 File Offset: 0x00001803
		public override void Reset()
		{
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x00143CF9 File Offset: 0x00141EF9
		public override void OnEnter()
		{
			this.DoGetAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x00143CF9 File Offset: 0x00141EF9
		public override void OnUpdate()
		{
			this.DoGetAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00143D10 File Offset: 0x00141F10
		private void DoGetAngle()
		{
			float num = this.point1.Value.y - this.point2.Value.y;
			float num2 = this.point1.Value.x - this.point2.Value.x;
			float num3;
			for (num3 = Mathf.Atan2(num, num2) * 57.295776f; num3 < 0f; num3 += 360f)
			{
			}
			this.storeAngle.Value = num3;
		}

		// Token: 0x040038FC RID: 14588
		[RequiredField]
		public FsmVector3 point1;

		// Token: 0x040038FD RID: 14589
		[RequiredField]
		public FsmVector3 point2;

		// Token: 0x040038FE RID: 14590
		[RequiredField]
		public FsmFloat storeAngle;

		// Token: 0x040038FF RID: 14591
		private FsmFloat x;

		// Token: 0x04003900 RID: 14592
		private FsmFloat y;

		// Token: 0x04003901 RID: 14593
		public bool everyFrame;
	}
}
