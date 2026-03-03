using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000801 RID: 2049
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003030 RID: 12336 RVA: 0x0011A9C0 File Offset: 0x00118BC0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Fight Stick";
			base.DeviceNotes = "Hori Fight Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 13
				}
			};
		}
	}
}
