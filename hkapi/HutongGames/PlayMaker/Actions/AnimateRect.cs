using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AFB RID: 2811
	[ActionCategory("AnimateVariables")]
	[Tooltip("Animates the value of a Rect Variable using an Animation Curve.")]
	public class AnimateRect : AnimateFsmAction
	{
		// Token: 0x06003C53 RID: 15443 RVA: 0x0015B67D File Offset: 0x0015987D
		public override void Reset()
		{
			base.Reset();
			this.rectVariable = new FsmRect
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C54 RID: 15444 RVA: 0x0015B698 File Offset: 0x00159898
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[4];
			this.fromFloats = new float[4];
			this.fromFloats[0] = (this.rectVariable.IsNone ? 0f : this.rectVariable.Value.x);
			this.fromFloats[1] = (this.rectVariable.IsNone ? 0f : this.rectVariable.Value.y);
			this.fromFloats[2] = (this.rectVariable.IsNone ? 0f : this.rectVariable.Value.width);
			this.fromFloats[3] = (this.rectVariable.IsNone ? 0f : this.rectVariable.Value.height);
			this.curves = new AnimationCurve[4];
			this.curves[0] = this.curveX.curve;
			this.curves[1] = this.curveY.curve;
			this.curves[2] = this.curveW.curve;
			this.curves[3] = this.curveH.curve;
			this.calculations = new AnimateFsmAction.Calculation[4];
			this.calculations[0] = this.calculationX;
			this.calculations[1] = this.calculationY;
			this.calculations[2] = this.calculationW;
			this.calculations[3] = this.calculationH;
			base.Init();
			if (Math.Abs(this.delay.Value) < 0.01f)
			{
				this.UpdateVariableValue();
			}
		}

		// Token: 0x06003C55 RID: 15445 RVA: 0x0015B845 File Offset: 0x00159A45
		private void UpdateVariableValue()
		{
			if (!this.rectVariable.IsNone)
			{
				this.rectVariable.Value = new Rect(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
			}
		}

		// Token: 0x06003C56 RID: 15446 RVA: 0x0015B884 File Offset: 0x00159A84
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

		// Token: 0x0400401F RID: 16415
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		// Token: 0x04004020 RID: 16416
		[RequiredField]
		public FsmAnimationCurve curveX;

		// Token: 0x04004021 RID: 16417
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.x.")]
		public AnimateFsmAction.Calculation calculationX;

		// Token: 0x04004022 RID: 16418
		[RequiredField]
		public FsmAnimationCurve curveY;

		// Token: 0x04004023 RID: 16419
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.y.")]
		public AnimateFsmAction.Calculation calculationY;

		// Token: 0x04004024 RID: 16420
		[RequiredField]
		public FsmAnimationCurve curveW;

		// Token: 0x04004025 RID: 16421
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.width.")]
		public AnimateFsmAction.Calculation calculationW;

		// Token: 0x04004026 RID: 16422
		[RequiredField]
		public FsmAnimationCurve curveH;

		// Token: 0x04004027 RID: 16423
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to rectVariable.height.")]
		public AnimateFsmAction.Calculation calculationH;

		// Token: 0x04004028 RID: 16424
		private bool finishInNextStep;
	}
}
