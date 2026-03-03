using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007FD RID: 2045
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003028 RID: 12328 RVA: 0x0011A704 File Offset: 0x00118904
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Controller";
			base.DeviceNotes = "Hori Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 220
				},
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 103
				},
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 256
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 21760
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 654
				}
			};
		}
	}
}
