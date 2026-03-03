using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000823 RID: 2083
	[Preserve]
	[NativeInputDeviceProfile]
	public class MVCTEStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003074 RID: 12404 RVA: 0x0011B8D8 File Offset: 0x00119AD8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "MVC TE Stick";
			base.DeviceNotes = "MVC TE Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61497
				},
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 46904
				}
			};
		}
	}
}
