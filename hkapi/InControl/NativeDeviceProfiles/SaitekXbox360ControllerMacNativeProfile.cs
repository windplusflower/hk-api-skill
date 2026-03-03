using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200086B RID: 2155
	[Preserve]
	[NativeInputDeviceProfile]
	public class SaitekXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003104 RID: 12548 RVA: 0x0011E1E0 File Offset: 0x0011C3E0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Saitek Xbox 360 Controller";
			base.DeviceNotes = "Saitek Xbox 360 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 51970
				}
			};
		}
	}
}
