using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000820 RID: 2080
	[Preserve]
	[NativeInputDeviceProfile]
	public class LogitechThunderpadMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600306E RID: 12398 RVA: 0x0011B7A0 File Offset: 0x001199A0
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Logitech Thunderpad";
			base.DeviceNotes = "Logitech Thunderpad on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1133,
					ProductID = 51848
				}
			};
		}
	}
}
