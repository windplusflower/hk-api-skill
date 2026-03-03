using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000836 RID: 2102
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzPortableDrumMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600309A RID: 12442 RVA: 0x0011C190 File Offset: 0x0011A390
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Portable Drum";
			base.DeviceNotes = "Mad Catz Portable Drum on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 39025
				}
			};
		}
	}
}
