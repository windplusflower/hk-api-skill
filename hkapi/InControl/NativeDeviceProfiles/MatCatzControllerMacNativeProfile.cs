using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200083F RID: 2111
	[Preserve]
	[NativeInputDeviceProfile]
	public class MatCatzControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030AC RID: 12460 RVA: 0x0011C538 File Offset: 0x0011A738
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mat Catz Controller";
			base.DeviceNotes = "Mat Catz Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61462
				}
			};
		}
	}
}
