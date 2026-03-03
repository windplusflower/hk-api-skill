using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B04 RID: 2820
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Easing Animation - Float")]
	public class EaseFloat : EaseFsmAction
	{
		// Token: 0x06003C7B RID: 15483 RVA: 0x0015D664 File Offset: 0x0015B864
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = null;
			this.fromValue = null;
			this.toValue = null;
			this.finishInNextStep = false;
		}

		// Token: 0x06003C7C RID: 15484 RVA: 0x0015D688 File Offset: 0x0015B888
		public override void OnEnter()
		{
			base.OnEnter();
			this.fromFloats = new float[1];
			this.fromFloats[0] = this.fromValue.Value;
			this.toFloats = new float[1];
			this.toFloats[0] = this.toValue.Value;
			this.resultFloats = new float[1];
			this.finishInNextStep = false;
			this.floatVariable.Value = this.fromValue.Value;
		}

		// Token: 0x06003C7D RID: 15485 RVA: 0x0015D460 File Offset: 0x0015B660
		public override void OnExit()
		{
			base.OnExit();
		}

		// Token: 0x06003C7E RID: 15486 RVA: 0x0015D704 File Offset: 0x0015B904
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.floatVariable.IsNone && this.isRunning)
			{
				this.floatVariable.Value = this.resultFloats[0];
			}
			if (this.finishInNextStep)
			{
				base.Finish();
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
			}
			if (this.finishAction && !this.finishInNextStep)
			{
				if (!this.floatVariable.IsNone)
				{
					this.floatVariable.Value = (this.reverse.IsNone ? this.toValue.Value : (this.reverse.Value ? this.fromValue.Value : this.toValue.Value));
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x04004080 RID: 16512
		[RequiredField]
		public FsmFloat fromValue;

		// Token: 0x04004081 RID: 16513
		[RequiredField]
		public FsmFloat toValue;

		// Token: 0x04004082 RID: 16514
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x04004083 RID: 16515
		private bool finishInNextStep;
	}
}
