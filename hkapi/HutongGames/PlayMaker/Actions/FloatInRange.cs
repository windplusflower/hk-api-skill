using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009C8 RID: 2504
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Checks whether a float value is within a certain range (inclusive)")]
	public class FloatInRange : FsmStateAction
	{
		// Token: 0x060036CA RID: 14026 RVA: 0x001438DD File Offset: 0x00141ADD
		public override void Reset()
		{
			this.floatVariable = null;
			this.lowerValue = null;
			this.upperValue = null;
			this.boolVariable = null;
			this.everyFrame = false;
			this.trueEvent = null;
			this.falseEvent = null;
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00143910 File Offset: 0x00141B10
		public override void OnEnter()
		{
			this.DoFloatRange();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00143926 File Offset: 0x00141B26
		public override void OnUpdate()
		{
			this.DoFloatRange();
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00143930 File Offset: 0x00141B30
		private void DoFloatRange()
		{
			if (this.floatVariable.IsNone)
			{
				return;
			}
			if (this.floatVariable.Value <= this.upperValue.Value && this.floatVariable.Value >= this.lowerValue.Value)
			{
				this.boolVariable.Value = true;
				base.Fsm.Event(this.trueEvent);
				return;
			}
			this.boolVariable.Value = false;
			base.Fsm.Event(this.falseEvent);
		}

		// Token: 0x040038E4 RID: 14564
		[RequiredField]
		[Tooltip("The float variable to test.")]
		public FsmFloat floatVariable;

		// Token: 0x040038E5 RID: 14565
		[RequiredField]
		public FsmFloat lowerValue;

		// Token: 0x040038E6 RID: 14566
		[RequiredField]
		public FsmFloat upperValue;

		// Token: 0x040038E7 RID: 14567
		[UIHint(UIHint.Variable)]
		public FsmBool boolVariable;

		// Token: 0x040038E8 RID: 14568
		public FsmEvent trueEvent;

		// Token: 0x040038E9 RID: 14569
		public FsmEvent falseEvent;

		// Token: 0x040038EA RID: 14570
		[Tooltip("Repeat every frame. Useful if the variable is changing.")]
		public bool everyFrame;
	}
}
