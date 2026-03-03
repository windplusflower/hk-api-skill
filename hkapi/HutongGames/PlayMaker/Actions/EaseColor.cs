using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B03 RID: 2819
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Easing Animation - Color")]
	public class EaseColor : EaseFsmAction
	{
		// Token: 0x06003C76 RID: 15478 RVA: 0x0015D327 File Offset: 0x0015B527
		public override void Reset()
		{
			base.Reset();
			this.colorVariable = null;
			this.fromValue = null;
			this.toValue = null;
			this.finishInNextStep = false;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0015D34C File Offset: 0x0015B54C
		public override void OnEnter()
		{
			base.OnEnter();
			this.fromFloats = new float[4];
			this.fromFloats[0] = this.fromValue.Value.r;
			this.fromFloats[1] = this.fromValue.Value.g;
			this.fromFloats[2] = this.fromValue.Value.b;
			this.fromFloats[3] = this.fromValue.Value.a;
			this.toFloats = new float[4];
			this.toFloats[0] = this.toValue.Value.r;
			this.toFloats[1] = this.toValue.Value.g;
			this.toFloats[2] = this.toValue.Value.b;
			this.toFloats[3] = this.toValue.Value.a;
			this.resultFloats = new float[4];
			this.finishInNextStep = false;
			this.colorVariable.Value = this.fromValue.Value;
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0015D460 File Offset: 0x0015B660
		public override void OnExit()
		{
			base.OnExit();
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x0015D468 File Offset: 0x0015B668
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.colorVariable.IsNone && this.isRunning)
			{
				this.colorVariable.Value = new Color(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
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
				if (!this.colorVariable.IsNone)
				{
					this.colorVariable.Value = new Color(this.reverse.IsNone ? this.toValue.Value.r : (this.reverse.Value ? this.fromValue.Value.r : this.toValue.Value.r), this.reverse.IsNone ? this.toValue.Value.g : (this.reverse.Value ? this.fromValue.Value.g : this.toValue.Value.g), this.reverse.IsNone ? this.toValue.Value.b : (this.reverse.Value ? this.fromValue.Value.b : this.toValue.Value.b), this.reverse.IsNone ? this.toValue.Value.a : (this.reverse.Value ? this.fromValue.Value.a : this.toValue.Value.a));
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x0400407C RID: 16508
		[RequiredField]
		public FsmColor fromValue;

		// Token: 0x0400407D RID: 16509
		[RequiredField]
		public FsmColor toValue;

		// Token: 0x0400407E RID: 16510
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		// Token: 0x0400407F RID: 16511
		private bool finishInNextStep;
	}
}
