using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000853 RID: 2131
	[Preserve]
	[NativeInputDeviceProfile]
	public class POWERAFUS1ONTournamentControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030D4 RID: 12500 RVA: 0x0011D5C8 File Offset: 0x0011B7C8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "POWER A FUS1ON Tournament Controller";
			base.DeviceNotes = "POWER A FUS1ON Tournament Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21399
				}
			};
		}
	}
}
