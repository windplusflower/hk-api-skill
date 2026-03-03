using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007F6 RID: 2038
	[Preserve]
	[NativeInputDeviceProfile]
	public class GuitarHeroControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600301A RID: 12314 RVA: 0x0011A42C File Offset: 0x0011862C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Guitar Hero Controller";
			base.DeviceNotes = "Guitar Hero Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5168,
					ProductID = 18248
				}
			};
		}
	}
}
