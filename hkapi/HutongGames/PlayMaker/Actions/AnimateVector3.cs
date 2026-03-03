using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AFC RID: 2812
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Vector3 Variable using an Animation Curve.")]
	public class AnimateVector3 : AnimateFsmAction
	{
		// Token: 0x06003C58 RID: 15448 RVA: 0x0015B8E9 File Offset: 0x00159AE9
		public override void Reset()
		{
			base.Reset();
			this.vectorVariable = new FsmVector3
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x0015B904 File Offset: 0x00159B04
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[3];
			this.fromFloats = new float[3];
			this.fromFloats[0] = (this.vectorVariable.IsNone ? 0f : this.vectorVariable.Value.x);
			this.fromFloats[1] = (this.vectorVariable.IsNone ? 0f : this.vectorVariable.Value.y);
			this.fromFloats[2] = (this.vectorVariable.IsNone ? 0f : this.vectorVariable.Value.z);
			this.curves = new AnimationCurve[3];
			this.curves[0] = this.curveX.curve;
			this.curves[1] = this.curveY.curve;
			this.curves[2] = this.curveZ.curve;
			this.calculations = new AnimateFsmAction.Calculation[3];
			this.calculations[0] = this.calculationX;
			this.calculations[1] = this.calculationY;
			this.calculations[2] = this.calculationZ;
			base.Init();
			if (Math.Abs(this.delay.Value) < 0.01f)
			{
				this.UpdateVariableValue();
			}
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x0015BA58 File Offset: 0x00159C58
		private void UpdateVariableValue()
		{
			if (!this.vectorVariable.IsNone)
			{
				this.vectorVariable.Value = new Vector3(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2]);
			}
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x0015BA90 File Offset: 0x00159C90
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

		// Token: 0x04004029 RID: 16425
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vectorVariable;

		// Token: 0x0400402A RID: 16426
		[RequiredField]
		public FsmAnimationCurve curveX;

		// Token: 0x0400402B RID: 16427
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to vectorVariable.x.")]
		public AnimateFsmAction.Calculation calculationX;

		// Token: 0x0400402C RID: 16428
		[RequiredField]
		public FsmAnimationCurve curveY;

		// Token: 0x0400402D RID: 16429
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to vectorVariable.y.")]
		public AnimateFsmAction.Calculation calculationY;

		// Token: 0x0400402E RID: 16430
		[RequiredField]
		public FsmAnimationCurve curveZ;

		// Token: 0x0400402F RID: 16431
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to vectorVariable.z.")]
		public AnimateFsmAction.Calculation calculationZ;

		// Token: 0x04004030 RID: 16432
		private bool finishInNextStep;
	}
}
