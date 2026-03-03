using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D17 RID: 3351
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Interpolates between 2 Vector3 values over a specified Time.")]
	public class Vector3Interpolate : FsmStateAction
	{
		// Token: 0x0600457B RID: 17787 RVA: 0x00179348 File Offset: 0x00177548
		public override void Reset()
		{
			this.mode = InterpolationType.Linear;
			this.fromVector = new FsmVector3
			{
				UseVariable = true
			};
			this.toVector = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.storeResult = null;
			this.finishEvent = null;
			this.realTime = false;
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x001793A5 File Offset: 0x001775A5
		public override void OnEnter()
		{
			this.startTime = FsmTime.RealtimeSinceStartup;
			this.currentTime = 0f;
			if (this.storeResult == null)
			{
				base.Finish();
				return;
			}
			this.storeResult.Value = this.fromVector.Value;
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x001793E4 File Offset: 0x001775E4
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
			float num = this.currentTime / this.time.Value;
			InterpolationType interpolationType = this.mode;
			if (interpolationType != InterpolationType.Linear && interpolationType == InterpolationType.EaseInOut)
			{
				num = Mathf.SmoothStep(0f, 1f, num);
			}
			this.storeResult.Value = Vector3.Lerp(this.fromVector.Value, this.toVector.Value, num);
			if (num >= 1f)
			{
				if (this.finishEvent != null)
				{
					base.Fsm.Event(this.finishEvent);
				}
				base.Finish();
			}
		}

		// Token: 0x040049DB RID: 18907
		public InterpolationType mode;

		// Token: 0x040049DC RID: 18908
		[RequiredField]
		public FsmVector3 fromVector;

		// Token: 0x040049DD RID: 18909
		[RequiredField]
		public FsmVector3 toVector;

		// Token: 0x040049DE RID: 18910
		[RequiredField]
		public FsmFloat time;

		// Token: 0x040049DF RID: 18911
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeResult;

		// Token: 0x040049E0 RID: 18912
		public FsmEvent finishEvent;

		// Token: 0x040049E1 RID: 18913
		[Tooltip("Ignore TimeScale")]
		public bool realTime;

		// Token: 0x040049E2 RID: 18914
		private float startTime;

		// Token: 0x040049E3 RID: 18915
		private float currentTime;
	}
}
