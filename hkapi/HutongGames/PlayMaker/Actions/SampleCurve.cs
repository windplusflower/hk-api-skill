using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C7D RID: 3197
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Gets the value of a curve at a given time and stores it in a Float Variable. NOTE: This can be used for more than just animation! It's a general way to transform an input number into an output number using a curve (e.g., linear input -> bell curve).")]
	public class SampleCurve : FsmStateAction
	{
		// Token: 0x060042DA RID: 17114 RVA: 0x0017128D File Offset: 0x0016F48D
		public override void Reset()
		{
			this.curve = null;
			this.sampleAt = null;
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x060042DB RID: 17115 RVA: 0x001712AB File Offset: 0x0016F4AB
		public override void OnEnter()
		{
			this.DoSampleCurve();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060042DC RID: 17116 RVA: 0x001712C1 File Offset: 0x0016F4C1
		public override void OnUpdate()
		{
			this.DoSampleCurve();
		}

		// Token: 0x060042DD RID: 17117 RVA: 0x001712CC File Offset: 0x0016F4CC
		private void DoSampleCurve()
		{
			if (this.curve == null || this.curve.curve == null || this.storeValue == null)
			{
				return;
			}
			this.storeValue.Value = this.curve.curve.Evaluate(this.sampleAt.Value);
		}

		// Token: 0x0400471C RID: 18204
		[RequiredField]
		public FsmAnimationCurve curve;

		// Token: 0x0400471D RID: 18205
		[RequiredField]
		public FsmFloat sampleAt;

		// Token: 0x0400471E RID: 18206
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeValue;

		// Token: 0x0400471F RID: 18207
		public bool everyFrame;
	}
}
