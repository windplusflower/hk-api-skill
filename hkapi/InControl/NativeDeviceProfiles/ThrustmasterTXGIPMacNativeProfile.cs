using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000872 RID: 2162
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustmasterTXGIPMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003112 RID: 12562 RVA: 0x0011E520 File Offset: 0x0011C720
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Thrustmaster TX GIP";
			base.DeviceNotes = "Thrustmaster TX GIP on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1103,
					ProductID = 46692
				}
			};
		}
	}
}
