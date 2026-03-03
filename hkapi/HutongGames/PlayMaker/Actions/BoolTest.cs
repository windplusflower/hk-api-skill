using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B3C RID: 2876
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the value of a Boolean Variable.")]
	public class BoolTest : FsmStateAction
	{
		// Token: 0x06003D6F RID: 15727 RVA: 0x00160E7D File Offset: 0x0015F07D
		public override void Reset()
		{
			this.boolVariable = null;
			this.isTrue = null;
			this.isFalse = null;
			this.everyFrame = false;
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00160E9B File Offset: 0x0015F09B
		public override void OnEnter()
		{
			base.Fsm.Event(this.boolVariable.Value ? this.isTrue : this.isFalse);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00160ED1 File Offset: 0x0015F0D1
		public override void OnUpdate()
		{
			base.Fsm.Event(this.boolVariable.Value ? this.isTrue : this.isFalse);
		}

		// Token: 0x04004182 RID: 16770
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bool variable to test.")]
		public FsmBool boolVariable;

		// Token: 0x04004183 RID: 16771
		[Tooltip("Event to send if the Bool variable is True.")]
		public FsmEvent isTrue;

		// Token: 0x04004184 RID: 16772
		[Tooltip("Event to send if the Bool variable is False.")]
		public FsmEvent isFalse;

		// Token: 0x04004185 RID: 16773
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
