using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000858 RID: 2136
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerASpectraIlluminatedControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x0011D834 File Offset: 0x0011BA34
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PowerA Spectra Illuminated Controller";
			base.DeviceNotes = "PowerA Spectra Illuminated Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21546
				}
			};
		}
	}
}
