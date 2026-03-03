using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000835 RID: 2101
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzNeoFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003098 RID: 12440 RVA: 0x0011C128 File Offset: 0x0011A328
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mad Catz Neo Fight Stick";
			base.DeviceNotes = "Mad Catz Neo Fight Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 61498
				}
			};
		}
	}
}
