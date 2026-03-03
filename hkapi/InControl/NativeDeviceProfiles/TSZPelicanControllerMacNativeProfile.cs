using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200086C RID: 2156
	[Preserve]
	[NativeInputDeviceProfile]
	public class TSZPelicanControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003106 RID: 12550 RVA: 0x0011E248 File Offset: 0x0011C448
		public override void Define()
		{
			base.Define();
			base.DeviceName = "TSZ Pelican Controller";
			base.DeviceNotes = "TSZ Pelican Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 513
				}
			};
		}
	}
}
