using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000833 RID: 2099
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMicroConControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003094 RID: 12436 RVA: 0x0011C058 File Offset: 0x0011A258
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz MicroCon Controller";
			base.DeviceNotes = "Mad Catz MicroCon Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18230
				}
			};
		}
	}
}
