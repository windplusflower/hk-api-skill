using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000855 RID: 2133
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerAMiniControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030D8 RID: 12504 RVA: 0x0011D698 File Offset: 0x0011B898
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PowerA Mini Controller";
			base.DeviceNotes = "PowerA Mini Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21530
				}
			};
		}
	}
}
