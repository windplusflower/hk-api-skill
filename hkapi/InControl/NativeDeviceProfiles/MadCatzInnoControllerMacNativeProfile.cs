using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200082F RID: 2095
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzInnoControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600308C RID: 12428 RVA: 0x0011BEB8 File Offset: 0x0011A0B8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Inno Controller";
			base.DeviceNotes = "Mad Catz Inno Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 62465
				}
			};
		}
	}
}
