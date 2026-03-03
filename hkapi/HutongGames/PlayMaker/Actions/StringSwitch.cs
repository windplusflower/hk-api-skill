using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CFA RID: 3322
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of a String Variable.")]
	public class StringSwitch : FsmStateAction
	{
		// Token: 0x06004500 RID: 17664 RVA: 0x00177CC8 File Offset: 0x00175EC8
		public override void Reset()
		{
			this.stringVariable = null;
			this.compareTo = new FsmString[1];
			this.sendEvent = new FsmEvent[1];
			this.everyFrame = false;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x00177CF0 File Offset: 0x00175EF0
		public override void OnEnter()
		{
			this.DoStringSwitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x00177D06 File Offset: 0x00175F06
		public override void OnUpdate()
		{
			this.DoStringSwitch();
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x00177D10 File Offset: 0x00175F10
		private void DoStringSwitch()
		{
			if (this.stringVariable.IsNone)
			{
				return;
			}
			for (int i = 0; i < this.compareTo.Length; i++)
			{
				if (this.stringVariable.Value == this.compareTo[i].Value)
				{
					base.Fsm.Event(this.sendEvent[i]);
					return;
				}
			}
		}

		// Token: 0x04004952 RID: 18770
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x04004953 RID: 18771
		[CompoundArray("String Switches", "Compare String", "Send Event")]
		public FsmString[] compareTo;

		// Token: 0x04004954 RID: 18772
		public FsmEvent[] sendEvent;

		// Token: 0x04004955 RID: 18773
		public bool everyFrame;
	}
}
