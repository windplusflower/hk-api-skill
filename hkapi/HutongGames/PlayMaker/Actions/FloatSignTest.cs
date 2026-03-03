using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B92 RID: 2962
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the sign of a Float.")]
	public class FloatSignTest : FsmStateAction
	{
		// Token: 0x06003EDF RID: 16095 RVA: 0x001656F8 File Offset: 0x001638F8
		public override void Reset()
		{
			this.floatValue = 0f;
			this.isPositive = null;
			this.isNegative = null;
			this.everyFrame = false;
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x0016571F File Offset: 0x0016391F
		public override void OnEnter()
		{
			this.DoSignTest();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x00165735 File Offset: 0x00163935
		public override void OnUpdate()
		{
			this.DoSignTest();
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0016573D File Offset: 0x0016393D
		private void DoSignTest()
		{
			if (this.floatValue == null)
			{
				return;
			}
			base.Fsm.Event((this.floatValue.Value < 0f) ? this.isNegative : this.isPositive);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x00165773 File Offset: 0x00163973
		public override string ErrorCheck()
		{
			if (FsmEvent.IsNullOrEmpty(this.isPositive) && FsmEvent.IsNullOrEmpty(this.isNegative))
			{
				return "Action sends no events!";
			}
			return "";
		}

		// Token: 0x040042F3 RID: 17139
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to test.")]
		public FsmFloat floatValue;

		// Token: 0x040042F4 RID: 17140
		[Tooltip("Event to send if the float variable is positive.")]
		public FsmEvent isPositive;

		// Token: 0x040042F5 RID: 17141
		[Tooltip("Event to send if the float variable is negative.")]
		public FsmEvent isNegative;

		// Token: 0x040042F6 RID: 17142
		[Tooltip("Repeat every frame. Useful if the variable is changing and you're waiting for a particular result.")]
		public bool everyFrame;
	}
}
