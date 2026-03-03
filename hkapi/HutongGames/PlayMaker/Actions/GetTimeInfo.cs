using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C1B RID: 3099
	[ActionCategory(ActionCategory.Time)]
	[Tooltip("Gets various useful Time measurements.")]
	public class GetTimeInfo : FsmStateAction
	{
		// Token: 0x06004100 RID: 16640 RVA: 0x0016B648 File Offset: 0x00169848
		public override void Reset()
		{
			this.getInfo = GetTimeInfo.TimeInfo.TimeSinceLevelLoad;
			this.storeValue = null;
			this.everyFrame = false;
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x0016B65F File Offset: 0x0016985F
		public override void OnEnter()
		{
			this.DoGetTimeInfo();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x0016B675 File Offset: 0x00169875
		public override void OnUpdate()
		{
			this.DoGetTimeInfo();
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0016B680 File Offset: 0x00169880
		private void DoGetTimeInfo()
		{
			switch (this.getInfo)
			{
			case GetTimeInfo.TimeInfo.DeltaTime:
				this.storeValue.Value = Time.deltaTime;
				return;
			case GetTimeInfo.TimeInfo.TimeScale:
				this.storeValue.Value = Time.timeScale;
				return;
			case GetTimeInfo.TimeInfo.SmoothDeltaTime:
				this.storeValue.Value = Time.smoothDeltaTime;
				return;
			case GetTimeInfo.TimeInfo.TimeInCurrentState:
				this.storeValue.Value = base.State.StateTime;
				return;
			case GetTimeInfo.TimeInfo.TimeSinceStartup:
				this.storeValue.Value = Time.time;
				return;
			case GetTimeInfo.TimeInfo.TimeSinceLevelLoad:
				this.storeValue.Value = Time.timeSinceLevelLoad;
				return;
			case GetTimeInfo.TimeInfo.RealTimeSinceStartup:
				this.storeValue.Value = FsmTime.RealtimeSinceStartup;
				return;
			case GetTimeInfo.TimeInfo.RealTimeInCurrentState:
				this.storeValue.Value = FsmTime.RealtimeSinceStartup - base.State.RealStartTime;
				return;
			default:
				this.storeValue.Value = 0f;
				return;
			}
		}

		// Token: 0x0400453F RID: 17727
		public GetTimeInfo.TimeInfo getInfo;

		// Token: 0x04004540 RID: 17728
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeValue;

		// Token: 0x04004541 RID: 17729
		public bool everyFrame;

		// Token: 0x02000C1C RID: 3100
		public enum TimeInfo
		{
			// Token: 0x04004543 RID: 17731
			DeltaTime,
			// Token: 0x04004544 RID: 17732
			TimeScale,
			// Token: 0x04004545 RID: 17733
			SmoothDeltaTime,
			// Token: 0x04004546 RID: 17734
			TimeInCurrentState,
			// Token: 0x04004547 RID: 17735
			TimeSinceStartup,
			// Token: 0x04004548 RID: 17736
			TimeSinceLevelLoad,
			// Token: 0x04004549 RID: 17737
			RealTimeSinceStartup,
			// Token: 0x0400454A RID: 17738
			RealTimeInCurrentState
		}
	}
}
