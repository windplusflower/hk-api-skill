using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B02 RID: 2818
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Vector3 Variable FROM-TO with assistance of Deformation Curves.")]
	public class CurveVector3 : CurveFsmAction
	{
		// Token: 0x06003C71 RID: 15473 RVA: 0x0015D03B File Offset: 0x0015B23B
		public override void Reset()
		{
			base.Reset();
			this.vectorVariable = new FsmVector3
			{
				UseVariable = true
			};
			this.toValue = new FsmVector3
			{
				UseVariable = true
			};
			this.fromValue = new FsmVector3
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0015D07C File Offset: 0x0015B27C
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[3];
			this.fromFloats = new float[3];
			this.fromFloats[0] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.x);
			this.fromFloats[1] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.y);
			this.fromFloats[2] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.z);
			this.toFloats = new float[3];
			this.toFloats[0] = (this.toValue.IsNone ? 0f : this.toValue.Value.x);
			this.toFloats[1] = (this.toValue.IsNone ? 0f : this.toValue.Value.y);
			this.toFloats[2] = (this.toValue.IsNone ? 0f : this.toValue.Value.z);
			this.curves = new AnimationCurve[3];
			this.curves[0] = this.curveX.curve;
			this.curves[1] = this.curveY.curve;
			this.curves[2] = this.curveZ.curve;
			this.calculations = new CurveFsmAction.Calculation[3];
			this.calculations[0] = this.calculationX;
			this.calculations[1] = this.calculationY;
			this.calculations[2] = this.calculationZ;
			base.Init();
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x0015D244 File Offset: 0x0015B444
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.vectorVariable.IsNone && this.isRunning)
			{
				this.vct = new Vector3(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2]);
				this.vectorVariable.Value = this.vct;
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
				if (!this.vectorVariable.IsNone)
				{
					this.vct = new Vector3(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2]);
					this.vectorVariable.Value = this.vct;
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x04004071 RID: 16497
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vectorVariable;

		// Token: 0x04004072 RID: 16498
		[RequiredField]
		public FsmVector3 fromValue;

		// Token: 0x04004073 RID: 16499
		[RequiredField]
		public FsmVector3 toValue;

		// Token: 0x04004074 RID: 16500
		[RequiredField]
		public FsmAnimationCurve curveX;

		// Token: 0x04004075 RID: 16501
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.x and toValue.x.")]
		public CurveFsmAction.Calculation calculationX;

		// Token: 0x04004076 RID: 16502
		[RequiredField]
		public FsmAnimationCurve curveY;

		// Token: 0x04004077 RID: 16503
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.y and toValue.y.")]
		public CurveFsmAction.Calculation calculationY;

		// Token: 0x04004078 RID: 16504
		[RequiredField]
		public FsmAnimationCurve curveZ;

		// Token: 0x04004079 RID: 16505
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.z and toValue.z.")]
		public CurveFsmAction.Calculation calculationZ;

		// Token: 0x0400407A RID: 16506
		private Vector3 vct;

		// Token: 0x0400407B RID: 16507
		private bool finishInNextStep;
	}
}
