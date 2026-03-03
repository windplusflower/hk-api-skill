using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007EA RID: 2026
	[Preserve]
	[NativeInputDeviceProfile]
	public class ArdwiinoControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003002 RID: 12290 RVA: 0x00119E18 File Offset: 0x00118018
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Ardwiino Controller";
			base.DeviceNotes = "Ardwiino Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 4617,
					ProductID = 10370
				}
			};
		}
	}
}
