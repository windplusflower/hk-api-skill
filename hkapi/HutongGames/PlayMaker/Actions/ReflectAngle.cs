using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A2B RID: 2603
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Reflect the selected angle horizontally or vertically.")]
	public class ReflectAngle : FsmStateAction
	{
		// Token: 0x0600388A RID: 14474 RVA: 0x0014B126 File Offset: 0x00149326
		public override void Reset()
		{
			this.angle = null;
			this.reflectHorizontally = false;
			this.reflectVertically = false;
			this.storeResult = null;
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x0014B144 File Offset: 0x00149344
		public override void OnEnter()
		{
			this.DoReflectAngle();
			base.Finish();
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x0014B154 File Offset: 0x00149354
		private void DoReflectAngle()
		{
			float num = this.angle.Value;
			if (this.reflectHorizontally)
			{
				num = 180f - num;
			}
			if (this.reflectVertically)
			{
				num = -num;
			}
			while (num > 360f)
			{
				num -= 360f;
			}
			while (num < -360f)
			{
				num += 360f;
			}
			this.storeResult.Value = num;
		}

		// Token: 0x04003B32 RID: 15154
		[RequiredField]
		[Tooltip("The angle to reflect. Must be expressed in degrees, ")]
		public FsmFloat angle;

		// Token: 0x04003B33 RID: 15155
		public bool reflectHorizontally;

		// Token: 0x04003B34 RID: 15156
		public bool reflectVertically;

		// Token: 0x04003B35 RID: 15157
		[Tooltip("Float to store the reflected angle in.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;
	}
}
