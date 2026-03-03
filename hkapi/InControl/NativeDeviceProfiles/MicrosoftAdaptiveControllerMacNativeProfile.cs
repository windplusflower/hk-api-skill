using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000842 RID: 2114
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftAdaptiveControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030B2 RID: 12466 RVA: 0x0011C66C File Offset: 0x0011A86C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Microsoft Adaptive Controller";
			base.DeviceNotes = "Microsoft Adaptive Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 2826
				}
			};
		}
	}
}
