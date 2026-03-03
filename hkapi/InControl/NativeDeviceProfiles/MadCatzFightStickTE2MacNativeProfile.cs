using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200082C RID: 2092
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzFightStickTE2MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003086 RID: 12422 RVA: 0x0011BD80 File Offset: 0x00119F80
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Fight Stick TE2";
			base.DeviceNotes = "Mad Catz Fight Stick TE2 on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61568
				}
			};
		}
	}
}
