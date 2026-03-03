using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B94 RID: 2964
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of a Float Variable. The float could represent distance, angle to a target, health left... The array sets up float ranges that correspond to Events.")]
	public class FloatSwitch : FsmStateAction
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x0016582E File Offset: 0x00163A2E
		public override void Reset()
		{
			this.floatVariable = null;
			this.lessThan = new FsmFloat[1];
			this.sendEvent = new FsmEvent[1];
			this.everyFrame = false;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00165856 File Offset: 0x00163A56
		public override void OnEnter()
		{
			this.DoFloatSwitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x0016586C File Offset: 0x00163A6C
		public override void OnUpdate()
		{
			this.DoFloatSwitch();
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00165874 File Offset: 0x00163A74
		private void DoFloatSwitch()
		{
			if (this.floatVariable.IsNone)
			{
				return;
			}
			for (int i = 0; i < this.lessThan.Length; i++)
			{
				if (this.floatVariable.Value < this.lessThan[i].Value)
				{
					base.Fsm.Event(this.sendEvent[i]);
					return;
				}
			}
		}

		// Token: 0x040042FB RID: 17147
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to test.")]
		public FsmFloat floatVariable;

		// Token: 0x040042FC RID: 17148
		[CompoundArray("Float Switches", "Less Than", "Send Event")]
		public FsmFloat[] lessThan;

		// Token: 0x040042FD RID: 17149
		public FsmEvent[] sendEvent;

		// Token: 0x040042FE RID: 17150
		[Tooltip("Repeat every frame. Useful if the variable is changing.")]
		public bool everyFrame;
	}
}
