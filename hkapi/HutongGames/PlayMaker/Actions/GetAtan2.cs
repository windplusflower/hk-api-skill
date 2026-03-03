using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D09 RID: 3337
	[ActionCategory(ActionCategory.Trigonometry)]
	[Tooltip("Get the Arc Tangent 2 as in atan2(y,x). You can get the result in degrees, simply check on the RadToDeg conversion")]
	public class GetAtan2 : FsmStateAction
	{
		// Token: 0x0600453F RID: 17727 RVA: 0x00178AF3 File Offset: 0x00176CF3
		public override void Reset()
		{
			this.xValue = null;
			this.yValue = null;
			this.RadToDeg = true;
			this.everyFrame = false;
			this.angle = null;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00178B1D File Offset: 0x00176D1D
		public override void OnEnter()
		{
			this.DoATan();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00178B33 File Offset: 0x00176D33
		public override void OnUpdate()
		{
			this.DoATan();
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00178B3C File Offset: 0x00176D3C
		private void DoATan()
		{
			float num = Mathf.Atan2(this.yValue.Value, this.xValue.Value);
			if (this.RadToDeg.Value)
			{
				num *= 57.29578f;
			}
			this.angle.Value = num;
		}

		// Token: 0x040049A6 RID: 18854
		[RequiredField]
		[Tooltip("The x value of the tan")]
		public FsmFloat xValue;

		// Token: 0x040049A7 RID: 18855
		[RequiredField]
		[Tooltip("The y value of the tan")]
		public FsmFloat yValue;

		// Token: 0x040049A8 RID: 18856
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The resulting angle. Note:If you want degrees, simply check RadToDeg")]
		public FsmFloat angle;

		// Token: 0x040049A9 RID: 18857
		[Tooltip("Check on if you want the angle expressed in degrees.")]
		public FsmBool RadToDeg;

		// Token: 0x040049AA RID: 18858
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
