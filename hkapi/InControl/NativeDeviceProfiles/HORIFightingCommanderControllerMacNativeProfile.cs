using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F7 RID: 2039
	[Preserve]
	[NativeInputDeviceProfile]
	public class HORIFightingCommanderControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600301C RID: 12316 RVA: 0x0011A494 File Offset: 0x00118694
		public override void Define()
		{
			base.Define();
			base.DeviceName = "HORI Fighting Commander Controller";
			base.DeviceNotes = "HORI Fighting Commander Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3853,
					ProductID = 134
				}
			};
		}
	}
}
