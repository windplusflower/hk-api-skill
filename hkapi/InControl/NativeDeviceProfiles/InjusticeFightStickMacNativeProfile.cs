using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000815 RID: 2069
	[Preserve]
	[NativeInputDeviceProfile]
	public class InjusticeFightStickMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003058 RID: 12376 RVA: 0x0011B2F8 File Offset: 0x001194F8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Injustice Fight Stick";
			base.DeviceNotes = "Injustice Fight Stick on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 293
				}
			};
		}
	}
}
