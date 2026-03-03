using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B7E RID: 2942
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of an Enum Variable.")]
	public class EnumSwitch : FsmStateAction
	{
		// Token: 0x06003E84 RID: 16004 RVA: 0x00164737 File Offset: 0x00162937
		public override void Reset()
		{
			this.enumVariable = null;
			this.compareTo = new FsmEnum[0];
			this.sendEvent = new FsmEvent[0];
			this.everyFrame = false;
		}

		// Token: 0x06003E85 RID: 16005 RVA: 0x0016475F File Offset: 0x0016295F
		public override void OnEnter()
		{
			this.DoEnumSwitch();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003E86 RID: 16006 RVA: 0x00164775 File Offset: 0x00162975
		public override void OnUpdate()
		{
			this.DoEnumSwitch();
		}

		// Token: 0x06003E87 RID: 16007 RVA: 0x00164780 File Offset: 0x00162980
		private void DoEnumSwitch()
		{
			if (this.enumVariable.IsNone)
			{
				return;
			}
			for (int i = 0; i < this.compareTo.Length; i++)
			{
				if (object.Equals(this.enumVariable.Value, this.compareTo[i].Value))
				{
					base.Fsm.Event(this.sendEvent[i]);
					return;
				}
			}
		}

		// Token: 0x04004293 RID: 17043
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmEnum enumVariable;

		// Token: 0x04004294 RID: 17044
		[CompoundArray("Enum Switches", "Compare Enum Values", "Send")]
		[MatchFieldType("enumVariable")]
		public FsmEnum[] compareTo;

		// Token: 0x04004295 RID: 17045
		public FsmEvent[] sendEvent;

		// Token: 0x04004296 RID: 17046
		public bool everyFrame;
	}
}
