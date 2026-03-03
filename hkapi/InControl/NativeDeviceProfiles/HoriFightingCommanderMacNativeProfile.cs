using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000802 RID: 2050
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingCommanderMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003032 RID: 12338 RVA: 0x0011AA24 File Offset: 0x00118C24
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Fighting Commander";
			base.DeviceNotes = "Hori Fighting Commander on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 197
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21776
				}
			};
		}
	}
}
