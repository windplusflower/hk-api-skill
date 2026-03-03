using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F4 RID: 2036
	[Preserve]
	[NativeInputDeviceProfile]
	public class FusionXboxOneControllerMacNativeProfile : XboxOneDriverMacNativeProfile
	{
		// Token: 0x06003016 RID: 12310 RVA: 0x0011A288 File Offset: 0x00118488
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Fusion Xbox One Controller";
			base.DeviceNotes = "Fusion Xbox One Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 21786
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 22042
				}
			};
		}
	}
}
