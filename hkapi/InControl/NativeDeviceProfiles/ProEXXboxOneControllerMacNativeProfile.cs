using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200085A RID: 2138
	[Preserve]
	[NativeInputDeviceProfile]
	public class ProEXXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x060030E2 RID: 12514 RVA: 0x0011D904 File Offset: 0x0011BB04
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Pro EX Xbox One Controller";
			base.DeviceNotes = "Pro EX Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21562
				}
			};
		}
	}
}
