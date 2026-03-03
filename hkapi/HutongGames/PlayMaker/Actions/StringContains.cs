using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF8 RID: 3320
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if a String contains another String.")]
	public class StringContains : FsmStateAction
	{
		// Token: 0x060044F6 RID: 17654 RVA: 0x00177B3B File Offset: 0x00175D3B
		public override void Reset()
		{
			this.stringVariable = null;
			this.containsString = "";
			this.trueEvent = null;
			this.falseEvent = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00177B70 File Offset: 0x00175D70
		public override void OnEnter()
		{
			this.DoStringContains();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x00177B86 File Offset: 0x00175D86
		public override void OnUpdate()
		{
			this.DoStringContains();
		}

		// Token: 0x060044F9 RID: 17657 RVA: 0x00177B90 File Offset: 0x00175D90
		private void DoStringContains()
		{
			if (this.stringVariable.IsNone || this.containsString.IsNone)
			{
				return;
			}
			bool flag = this.stringVariable.Value.Contains(this.containsString.Value);
			if (this.storeResult != null)
			{
				this.storeResult.Value = flag;
			}
			if (flag && this.trueEvent != null)
			{
				base.Fsm.Event(this.trueEvent);
				return;
			}
			if (!flag && this.falseEvent != null)
			{
				base.Fsm.Event(this.falseEvent);
			}
		}

		// Token: 0x04004947 RID: 18759
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The String variable to test.")]
		public FsmString stringVariable;

		// Token: 0x04004948 RID: 18760
		[RequiredField]
		[Tooltip("Test if the String variable contains this string.")]
		public FsmString containsString;

		// Token: 0x04004949 RID: 18761
		[Tooltip("Event to send if true.")]
		public FsmEvent trueEvent;

		// Token: 0x0400494A RID: 18762
		[Tooltip("Event to send if false.")]
		public FsmEvent falseEvent;

		// Token: 0x0400494B RID: 18763
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the true/false result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x0400494C RID: 18764
		[Tooltip("Repeat every frame. Useful if any of the strings are changing over time.")]
		public bool everyFrame;
	}
}
