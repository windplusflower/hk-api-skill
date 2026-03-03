using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000804 RID: 2052
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingStickEX2MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x0011AB28 File Offset: 0x00118D28
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Fighting Stick EX2";
			base.DeviceNotes = "Hori Fighting Stick EX2 on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 10
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 62725
				},
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 13
				}
			};
		}
	}
}
