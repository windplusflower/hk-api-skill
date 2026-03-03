using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000806 RID: 2054
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingStickVXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600303A RID: 12346 RVA: 0x0011AC58 File Offset: 0x00118E58
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Fighting Stick VX";
			base.DeviceNotes = "Hori Fighting Stick VX on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 62723
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21762
				}
			};
		}
	}
}
