using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000847 RID: 2119
	[Preserve]
	[NativeInputDeviceProfile]
	public class NaconGC100XFControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030BC RID: 12476 RVA: 0x0011CB00 File Offset: 0x0011AD00
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Nacon GC-100XF Controller";
			base.DeviceNotes = "Nacon GC-100XF Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 4553,
					ProductID = 22000
				}
			};
		}
	}
}
