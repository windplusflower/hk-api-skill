using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C31 RID: 3121
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of an Integer Variable.")]
	public class IntSwitch : FsmStateAction
	{
		// Token: 0x06004160 RID: 16736 RVA: 0x0016C5D8 File Offset: 0x0016A7D8
		public override void Reset()
		{
			this.intVariable = null;
			this.compareTo = new FsmInt[1];
			this.sendEvent = new FsmEvent[1];
			this.everyFrame = false;
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x0016C600 File Offset: 0x0016A800
		public override void OnEnter()
		{
			this.DoIntSwitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004162 RID: 16738 RVA: 0x0016C616 File Offset: 0x0016A816
		public override void OnUpdate()
		{
			this.DoIntSwitch();
		}

		// Token: 0x06004163 RID: 16739 RVA: 0x0016C620 File Offset: 0x0016A820
		private void DoIntSwitch()
		{
			if (this.intVariable.IsNone)
			{
				return;
			}
			for (int i = 0; i < this.compareTo.Length; i++)
			{
				if (this.intVariable.Value == this.compareTo[i].Value)
				{
					base.Fsm.Event(this.sendEvent[i]);
					return;
				}
			}
		}

		// Token: 0x040045A6 RID: 17830
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x040045A7 RID: 17831
		[CompoundArray("Int Switches", "Compare Int", "Send Event")]
		public FsmInt[] compareTo;

		// Token: 0x040045A8 RID: 17832
		public FsmEvent[] sendEvent;

		// Token: 0x040045A9 RID: 17833
		public bool everyFrame;
	}
}
