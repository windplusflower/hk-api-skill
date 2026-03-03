using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B01 RID: 2817
	[ActionCategory("AnimateVariables")]
	[Tooltip("Animates the value of a Rect Variable FROM-TO with assistance of Deformation Curves.")]
	public class CurveRect : CurveFsmAction
	{
		// Token: 0x06003C6C RID: 15468 RVA: 0x0015CCB2 File Offset: 0x0015AEB2
		public override void Reset()
		{
			base.Reset();
			this.rectVariable = new FsmRect
			{
				UseVariable = true
			};
			this.toValue = new FsmRect
			{
				UseVariable = true
			};
			this.fromValue = new FsmRect
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x0015CCF0 File Offset: 0x0015AEF0
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[4];
			this.fromFloats = new float[4];
			this.fromFloats[0] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.x);
			this.fromFloats[1] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.y);
			this.fromFloats[2] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.width);
			this.fromFloats[3] = (this.fromValue.IsNone ? 0f : this.fromValue.Value.height);
			this.toFloats = new float[4];
			this.toFloats[0] = (this.toValue.IsNone ? 0f : this.toValue.Value.x);
			this.toFloats[1] = (this.toValue.IsNone ? 0f : this.toValue.Value.y);
			this.toFloats[2] = (this.toValue.IsNone ? 0f : this.toValue.Value.width);
			this.toFloats[3] = (this.toValue.IsNone ? 0f : this.toValue.Value.height);
			this.curves = new AnimationCurve[4];
			this.curves[0] = this.curveX.curve;
			this.curves[1] = this.curveY.curve;
			this.curves[2] = this.curveW.curve;
			this.curves[3] = this.curveH.curve;
			this.calculations = new CurveFsmAction.Calculation[4];
			this.calculations[0] = this.calculationX;
			this.calculations[1] = this.calculationY;
			this.calculations[2] = this.calculationW;
			this.calculations[2] = this.calculationH;
			base.Init();
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x0015CF48 File Offset: 0x0015B148
		public override void OnUpdate()
		{
			base.OnUpdate();
			if (!this.rectVariable.IsNone && this.isRunning)
			{
				this.rct = new Rect(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
				this.rectVariable.Value = this.rct;
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
				if (!this.rectVariable.IsNone)
				{
					this.rct = new Rect(this.resultFloats[0], this.resultFloats[1], this.resultFloats[2], this.resultFloats[3]);
					this.rectVariable.Value = this.rct;
				}
				this.finishInNextStep = true;
			}
		}

		// Token: 0x04004064 RID: 16484
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmRect rectVariable;

		// Token: 0x04004065 RID: 16485
		[RequiredField]
		public FsmRect fromValue;

		// Token: 0x04004066 RID: 16486
		[RequiredField]
		public FsmRect toValue;

		// Token: 0x04004067 RID: 16487
		[RequiredField]
		public FsmAnimationCurve curveX;

		// Token: 0x04004068 RID: 16488
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.x and toValue.x.")]
		public CurveFsmAction.Calculation calculationX;

		// Token: 0x04004069 RID: 16489
		[RequiredField]
		public FsmAnimationCurve curveY;

		// Token: 0x0400406A RID: 16490
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.y and toValue.y.")]
		public CurveFsmAction.Calculation calculationY;

		// Token: 0x0400406B RID: 16491
		[RequiredField]
		public FsmAnimationCurve curveW;

		// Token: 0x0400406C RID: 16492
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.width and toValue.width.")]
		public CurveFsmAction.Calculation calculationW;

		// Token: 0x0400406D RID: 16493
		[RequiredField]
		public FsmAnimationCurve curveH;

		// Token: 0x0400406E RID: 16494
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to otherwise linear move between fromValue.height and toValue.height.")]
		public CurveFsmAction.Calculation calculationH;

		// Token: 0x0400406F RID: 16495
		private Rect rct;

		// Token: 0x04004070 RID: 16496
		private bool finishInNextStep;
	}
}
