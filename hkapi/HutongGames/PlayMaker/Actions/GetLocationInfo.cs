using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF7 RID: 3063
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Gets Location Info from a mobile device. NOTE: Use StartLocationService before trying to get location info.")]
	public class GetLocationInfo : FsmStateAction
	{
		// Token: 0x06004065 RID: 16485 RVA: 0x0016A1BB File Offset: 0x001683BB
		public override void Reset()
		{
			this.longitude = null;
			this.latitude = null;
			this.altitude = null;
			this.horizontalAccuracy = null;
			this.verticalAccuracy = null;
			this.errorEvent = null;
		}

		// Token: 0x06004066 RID: 16486 RVA: 0x0016A1E7 File Offset: 0x001683E7
		public override void OnEnter()
		{
			this.DoGetLocationInfo();
			base.Finish();
		}

		// Token: 0x06004067 RID: 16487 RVA: 0x00003603 File Offset: 0x00001803
		private void DoGetLocationInfo()
		{
		}

		// Token: 0x040044C4 RID: 17604
		[UIHint(UIHint.Variable)]
		public FsmVector3 vectorPosition;

		// Token: 0x040044C5 RID: 17605
		[UIHint(UIHint.Variable)]
		public FsmFloat longitude;

		// Token: 0x040044C6 RID: 17606
		[UIHint(UIHint.Variable)]
		public FsmFloat latitude;

		// Token: 0x040044C7 RID: 17607
		[UIHint(UIHint.Variable)]
		public FsmFloat altitude;

		// Token: 0x040044C8 RID: 17608
		[UIHint(UIHint.Variable)]
		public FsmFloat horizontalAccuracy;

		// Token: 0x040044C9 RID: 17609
		[UIHint(UIHint.Variable)]
		public FsmFloat verticalAccuracy;

		// Token: 0x040044CA RID: 17610
		[Tooltip("Event to send if the location cannot be queried.")]
		public FsmEvent errorEvent;
	}
}
