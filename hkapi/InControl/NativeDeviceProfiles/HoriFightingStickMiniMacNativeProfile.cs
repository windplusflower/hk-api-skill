using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000805 RID: 2053
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoriFightingStickMiniMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003038 RID: 12344 RVA: 0x0011ABF0 File Offset: 0x00118DF0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hori Fighting Stick Mini";
			base.DeviceNotes = "Hori Fighting Stick Mini on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 237
				}
			};
		}
	}
}
