using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007FF RID: 2047
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriEX2ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600302C RID: 12332 RVA: 0x0011A894 File Offset: 0x00118A94
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori EX2 Controller";
			base.DeviceNotes = "Hori EX2 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 13
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 62721
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21760
				}
			};
		}
	}
}
