using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000857 RID: 2135
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerAMiniXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030DC RID: 12508 RVA: 0x0011D7CC File Offset: 0x0011B9CC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Power A Mini Xbox One Controller";
			base.DeviceNotes = "Power A Mini Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21562
				}
			};
		}
	}
}
