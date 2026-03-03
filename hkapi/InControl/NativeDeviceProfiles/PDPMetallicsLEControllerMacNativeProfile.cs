using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200084C RID: 2124
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPMetallicsLEControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x0011CFC8 File Offset: 0x0011B1C8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Metallics LE Controller";
			base.DeviceNotes = "PDP Metallics LE Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 345
				}
			};
		}
	}
}
