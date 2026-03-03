using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CF1 RID: 3313
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Starts location service updates. Last location coordinates can be retrieved with GetLocationInfo.")]
	public class StartLocationServiceUpdates : FsmStateAction
	{
		// Token: 0x060044DD RID: 17629 RVA: 0x001777C6 File Offset: 0x001759C6
		public override void Reset()
		{
			this.maxWait = 20f;
			this.desiredAccuracy = 10f;
			this.updateDistance = 10f;
			this.successEvent = null;
			this.failedEvent = null;
		}

		// Token: 0x060044DE RID: 17630 RVA: 0x0013ACE9 File Offset: 0x00138EE9
		public override void OnEnter()
		{
			base.Finish();
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnUpdate()
		{
		}

		// Token: 0x0400492E RID: 18734
		[Tooltip("Maximum time to wait in seconds before failing.")]
		public FsmFloat maxWait;

		// Token: 0x0400492F RID: 18735
		public FsmFloat desiredAccuracy;

		// Token: 0x04004930 RID: 18736
		public FsmFloat updateDistance;

		// Token: 0x04004931 RID: 18737
		[Tooltip("Event to send when the location services have started.")]
		public FsmEvent successEvent;

		// Token: 0x04004932 RID: 18738
		[Tooltip("Event to send if the location services fail to start.")]
		public FsmEvent failedEvent;
	}
}
