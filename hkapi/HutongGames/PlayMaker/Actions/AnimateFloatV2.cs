using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF8 RID: 2808
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Float Variable using an Animation Curve.")]
	public class AnimateFloatV2 : AnimateFsmAction
	{
		// Token: 0x06003C45 RID: 15429 RVA: 0x0015AA61 File Offset: 0x00158C61
		public override void Reset()
		{
			base.Reset();
			this.floatVariable = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x0015AA7C File Offset: 0x00158C7C
		public override void OnEnter()
		{
			base.OnEnter();
			this.finishInNextStep = false;
			this.resultFloats = new float[1];
			this.fromFloats = new float[1];
			this.fromFloats[0] = (this.floatVariable.IsNone ? 0f : this.floatVariable.Value);
			this.calculations = new AnimateFsmAction.Calculation[1];
			this.calculations[0] = this.calculation;
			this.curves = new AnimationCurve[1];
			this.curves[0] = this.animCurve.curve;
			base.Init();
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnExit()
		{
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x0015AB14 File Offset: 0x00158D14
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

		// Token: 0x04003FFB RID: 16379
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat floatVariable;

		// Token: 0x04003FFC RID: 16380
		[RequiredField]
		public FsmAnimationCurve animCurve;

		// Token: 0x04003FFD RID: 16381
		[Tooltip("Calculation lets you set a type of curve deformation that will be applied to floatVariable")]
		public AnimateFsmAction.Calculation calculation;

		// Token: 0x04003FFE RID: 16382
		private bool finishInNextStep;
	}
}
