using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AFE RID: 2814
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Float Variable FROM-TO with assistance of Deformation Curve.")]
	public class CurveFloat : CurveFsmAction
	{
		// Token: 0x06003C62 RID: 15458 RVA: 0x0015BE6F File Offset: 0x0015A06F
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = new FsmFloat
			{
				UseVariable = true
			};
			this.toValue = new FsmFloat
			{
				UseVariable = true
			};
			this.fromValue = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C63 RID: 15459 RVA: 0x0015BEB0 File Offset: 0x0015A0B0
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[1];
			this.fromFloats = new float[1];
			this.fromFloats[0] = (this.fromValue.IsNone ? 0f : this.fromValue.Value);
			this.toFloats = new float[1];
			this.toFloats[0] = (this.toValue.IsNone ? 0f : this.toValue.Value);
			this.calculations = new CurveFsmAction.Calculation[1];
			this.calculations[0] = this.calculation;
			this.curves = new AnimationCurve[1];
			this.curves[0] = this.animCurve.curve;
			base.Init();
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x0015BF7C File Offset: 0x0015A17C
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.floatVariable.IsNone && this.isRunning)
			{
				this.floatVariable.Value = this.resultFloats[0];
			}
			if (this.finishInNextStep && !this.looping)
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
					this.floatVariable.Value = this.resultFloats[0];
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x0400403E RID: 16446
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x0400403F RID: 16447
		[RequiredField]
		public FsmFloat fromValue;

		// Token: 0x04004040 RID: 16448
		[RequiredField]
		public FsmFloat toValue;

		// Token: 0x04004041 RID: 16449
		[RequiredField]
		public FsmAnimationCurve animCurve;

		// Token: 0x04004042 RID: 16450
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue and toValue.")]
		public CurveFsmAction.Calculation calculation;

		// Token: 0x04004043 RID: 16451
		private bool finishInNextStep;
	}
}
