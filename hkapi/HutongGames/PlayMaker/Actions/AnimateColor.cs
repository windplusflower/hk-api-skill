using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF7 RID: 2807
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Color Variable using an Animation Curve.")]
	public class AnimateColor : AnimateFsmAction
	{
		// Token: 0x06003C40 RID: 15424 RVA: 0x0015A7FA File Offset: 0x001589FA
		public override void Reset()
		{
			base.Reset();
			this.colorVariable = new FsmColor
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0015A814 File Offset: 0x00158A14
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[4];
			this.fromFloats = new float[4];
			this.fromFloats[0] = (this.colorVariable.IsNone ? 0f : this.colorVariable.Value.r);
			this.fromFloats[1] = (this.colorVariable.IsNone ? 0f : this.colorVariable.Value.g);
			this.fromFloats[2] = (this.colorVariable.IsNone ? 0f : this.colorVariable.Value.b);
			this.fromFloats[3] = (this.colorVariable.IsNone ? 0f : this.colorVariable.Value.a);
			this.curves = new AnimationCurve[4];
			this.curves[0] = this.curveR.curve;
			this.curves[1] = this.curveG.curve;
			this.curves[2] = this.curveB.curve;
			this.curves[3] = this.curveA.curve;
			this.calculations = new AnimateFsmAction.Calculation[4];
			this.calculations[0] = this.calculationR;
			this.calculations[1] = this.calculationG;
			this.calculations[2] = this.calculationB;
			this.calculations[3] = this.calculationA;
			base.Init();
			if (Math.Abs(this.delay.Value) < 0.01f)
			{
				this.UpdateVariableValue();
			}
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x0015A9B5 File Offset: 0x00158BB5
		private void UpdateVariableValue()
		{
			if (!this.colorVariable.IsNone)
			{
				this.colorVariable.Value = new Color(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
			}
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0015A9F4 File Offset: 0x00158BF4
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (this.isRunning)
			{
				this.UpdateVariableValue();
			}
			if (this.finishInNextStep && !this.looping)
			{
				base.Finish();
				base.Fsm.Event(this.finishEvent);
			}
			if (this.finishAction && !this.finishInNextStep)
			{
				this.UpdateVariableValue();
				this.finishInNextStep = true;
			}
		}

		// Token: 0x04003FF1 RID: 16369
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		// Token: 0x04003FF2 RID: 16370
		[RequiredField]
		public FsmAnimationCurve curveR;

		// Token: 0x04003FF3 RID: 16371
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to colorVariable.r.")]
		public AnimateFsmAction.Calculation calculationR;

		// Token: 0x04003FF4 RID: 16372
		[RequiredField]
		public FsmAnimationCurve curveG;

		// Token: 0x04003FF5 RID: 16373
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to colorVariable.g.")]
		public AnimateFsmAction.Calculation calculationG;

		// Token: 0x04003FF6 RID: 16374
		[RequiredField]
		public FsmAnimationCurve curveB;

		// Token: 0x04003FF7 RID: 16375
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to colorVariable.b.")]
		public AnimateFsmAction.Calculation calculationB;

		// Token: 0x04003FF8 RID: 16376
		[RequiredField]
		public FsmAnimationCurve curveA;

		// Token: 0x04003FF9 RID: 16377
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to colorVariable.a.")]
		public AnimateFsmAction.Calculation calculationA;

		// Token: 0x04003FFA RID: 16378
		private bool finishInNextStep;
	}
}
