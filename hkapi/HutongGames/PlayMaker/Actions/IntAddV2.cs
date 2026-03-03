using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009E6 RID: 2534
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Adds a value to an Integer Variable. Uses FixedUpdate")]
	public class IntAddV2 : FsmStateAction
	{
		// Token: 0x06003751 RID: 14161 RVA: 0x0014656B File Offset: 0x0014476B
		public override void Reset()
		{
			this.intVariable = null;
			this.add = null;
			this.everyFrame = false;
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x00146582 File Offset: 0x00144782
		public override void OnEnter()
		{
			this.intVariable.Value += this.add.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001465AF File Offset: 0x001447AF
		public override void OnFixedUpdate()
		{
			this.intVariable.Value += this.add.Value;
		}

		// Token: 0x04003991 RID: 14737
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;

		// Token: 0x04003992 RID: 14738
		[RequiredField]
		public FsmInt add;

		// Token: 0x04003993 RID: 14739
		public bool everyFrame;
	}
}
