using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200083D RID: 2109
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzSaitekAV8R02MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030A8 RID: 12456 RVA: 0x0011C468 File Offset: 0x0011A668
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Saitek AV8R02";
			base.DeviceNotes = "Mad Catz Saitek AV8R02 on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 52009
				}
			};
		}
	}
}
