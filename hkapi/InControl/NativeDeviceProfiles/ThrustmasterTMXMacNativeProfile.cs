using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000871 RID: 2161
	[Preserve]
	[NativeInputDeviceProfile]
	public class ThrustmasterTMXMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003110 RID: 12560 RVA: 0x0011E4B8 File Offset: 0x0011C6B8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Thrustmaster TMX";
			base.DeviceNotes = "Thrustmaster TMX on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1103,
					ProductID = 46718
				}
			};
		}
	}
}
