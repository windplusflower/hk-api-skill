using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F3 RID: 2035
	[Preserve]
	[NativeInputDeviceProfile]
	public class ElecomControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003014 RID: 12308 RVA: 0x0011A220 File Offset: 0x00118420
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Elecom Controller";
			base.DeviceNotes = "Elecom Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1390,
					ProductID = 8196
				}
			};
		}
	}
}
