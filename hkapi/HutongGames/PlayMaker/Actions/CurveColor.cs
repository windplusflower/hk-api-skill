using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AFD RID: 2813
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Color Variable FROM-TO with assistance of Deformation Curves.")]
	public class CurveColor : CurveFsmAction
	{
		// Token: 0x06003C5D RID: 15453 RVA: 0x0015BAF5 File Offset: 0x00159CF5
		public override void Reset()
		{
			base.Reset();
			this.colorVariable = new FsmColor
			{
				UseVariable = true
			};
			this.toValue = new FsmColor
			{
				UseVariable = true
			};
			this.fromValue = new FsmColor
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C5E RID: 15454 RVA: 0x0015BB34 File Offset: 0x00159D34
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[4];
			this.fromFloats = new float[4];
			this.fromFloats[0] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.r);
			this.fromFloats[1] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.g);
			this.fromFloats[2] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.b);
			this.fromFloats[3] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.a);
			this.toFloats = new float[4];
			this.toFloats[0] = (this.toValue.IsNone ? 0f : this.toValue.Value.r);
			this.toFloats[1] = (this.toValue.IsNone ? 0f : this.toValue.Value.g);
			this.toFloats[2] = (this.toValue.IsNone ? 0f : this.toValue.Value.b);
			this.toFloats[3] = (this.toValue.IsNone ? 0f : this.toValue.Value.a);
			this.curves = new AnimationCurve[4];
			this.curves[0] = this.curveR.curve;
			this.curves[1] = this.curveG.curve;
			this.curves[2] = this.curveB.curve;
			this.curves[3] = this.curveA.curve;
			this.calculations = new CurveFsmAction.Calculation[4];
			this.calculations[0] = this.calculationR;
			this.calculations[1] = this.calculationG;
			this.calculations[2] = this.calculationB;
			this.calculations[3] = this.calculationA;
			base.Init();
		}

		// Token: 0x06003C5F RID: 15455 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06003C60 RID: 15456 RVA: 0x0015BD74 File Offset: 0x00159F74
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.colorVariable.IsNone && this.isRunning)
			{
				this.clr = new Color(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
				this.colorVariable.Value = this.clr;
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
				if (!this.colorVariable.IsNone)
				{
					this.clr = new Color(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
					this.colorVariable.Value = this.clr;
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x04004031 RID: 16433
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmColor colorVariable;

		// Token: 0x04004032 RID: 16434
		[RequiredField]
		public FsmColor fromValue;

		// Token: 0x04004033 RID: 16435
		[RequiredField]
		public FsmColor toValue;

		// Token: 0x04004034 RID: 16436
		[RequiredField]
		public FsmAnimationCurve curveR;

		// Token: 0x04004035 RID: 16437
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Red and toValue.Rec.")]
		public CurveFsmAction.Calculation calculationR;

		// Token: 0x04004036 RID: 16438
		[RequiredField]
		public FsmAnimationCurve curveG;

		// Token: 0x04004037 RID: 16439
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Green and toValue.Green.")]
		public CurveFsmAction.Calculation calculationG;

		// Token: 0x04004038 RID: 16440
		[RequiredField]
		public FsmAnimationCurve curveB;

		// Token: 0x04004039 RID: 16441
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Blue and toValue.Blue.")]
		public CurveFsmAction.Calculation calculationB;

		// Token: 0x0400403A RID: 16442
		[RequiredField]
		public FsmAnimationCurve curveA;

		// Token: 0x0400403B RID: 16443
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.Alpha and toValue.Alpha.")]
		public CurveFsmAction.Calculation calculationA;

		// Token: 0x0400403C RID: 16444
		private Color clr;

		// Token: 0x0400403D RID: 16445
		private bool finishInNextStep;
	}
}
