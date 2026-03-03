using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000874 RID: 2164
	[Preserve]
	[NativeInputDeviceProfile]
	public class Xbox360MortalKombatFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003116 RID: 12566 RVA: 0x0011E5EC File Offset: 0x0011C7EC
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Xbox 360 Mortal Kombat Fight Stick";
			base.DeviceNotes = "Xbox 360 Mortal Kombat Fight Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63750
				}
			};
		}
	}
}
