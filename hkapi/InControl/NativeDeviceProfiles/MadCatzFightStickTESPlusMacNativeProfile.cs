using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200082D RID: 2093
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFightStickTESPlusMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003088 RID: 12424 RVA: 0x0011BDE8 File Offset: 0x00119FE8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Fight Stick TES Plus";
			base.DeviceNotes = "Mad Catz Fight Stick TES Plus on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61506
				}
			};
		}
	}
}
