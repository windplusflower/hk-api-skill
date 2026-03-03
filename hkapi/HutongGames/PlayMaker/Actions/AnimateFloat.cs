using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF6 RID: 2806
	[ActionCategory(ActionCategory.AnimateVariables)]
	[Tooltip("Animates the value of a Float Variable using an Animation Curve.")]
	public class AnimateFloat : FsmStateAction
	{
		// Token: 0x06003C3C RID: 15420 RVA: 0x0015A668 File Offset: 0x00158868
		public override void Reset()
		{
			this.animCurve = null;
			this.floatVariable = null;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0015A688 File Offset: 0x00158888
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			if (this.animCurve != null && this.animCurve.curve != null && this.animCurve.curve.keys.Length != 0)
			{
				this.endTime = this.animCurve.curve.keys[this.animCurve.curve.length - 1].time;
				this.looping = ActionHelpers.IsLoopingWrapMode(this.animCurve.curve.postWrapMode);
				this.floatVariable.Value = this.animCurve.curve.Evaluate(0f);
				return;
			}
			base.Finish();
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0015A74C File Offset: 0x0015894C
		public override void OnUpdate()
		{
			if (this.realTime)
			{
				this.currentTime = FsmTime.RealtimeSinceStartup - this.startTime;
			}
			else
			{
				this.currentTime += Time.deltaTime;
			}
			if (this.animCurve != null && this.animCurve.curve != null && this.floatVariable != null)
			{
				this.floatVariable.Value = this.animCurve.curve.Evaluate(this.currentTime);
			}
			if (this.currentTime >= this.endTime)
			{
				if (!this.looping)
				{
					base.Finish();
				}
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
			}
		}

		// Token: 0x04003FE9 RID: 16361
		[RequiredField]
		[Tooltip("The animation curve to use.")]
		public FsmAnimationCurve animCurve;

		// Token: 0x04003FEA RID: 16362
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The float variable to set.")]
		public FsmFloat floatVariable;

		// Token: 0x04003FEB RID: 16363
		[Tooltip("Optionally send an Event when the animation finishes.")]
		public FsmEvent finishEvent;

		// Token: 0x04003FEC RID: 16364
		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		// Token: 0x04003FED RID: 16365
		private float startTime;

		// Token: 0x04003FEE RID: 16366
		private float currentTime;

		// Token: 0x04003FEF RID: 16367
		private float endTime;

		// Token: 0x04003FF0 RID: 16368
		private bool looping;
	}
}
