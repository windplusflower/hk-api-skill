using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000834 RID: 2100
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMicroControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003096 RID: 12438 RVA: 0x0011C0C0 File Offset: 0x0011A2C0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Micro Controller";
			base.DeviceNotes = "Mad Catz Micro Controller on Mac";
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
