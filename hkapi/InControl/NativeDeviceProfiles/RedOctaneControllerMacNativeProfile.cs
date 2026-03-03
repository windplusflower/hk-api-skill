using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000863 RID: 2147
	[Preserve]
	[NativeInputDeviceProfile]
	public class RedOctaneControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030F4 RID: 12532 RVA: 0x0011DD78 File Offset: 0x0011BF78
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Red Octane Controller";
			base.DeviceNotes = "Red Octane Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5168,
					ProductID = 63489
				},
				new InputDeviceMatcher
				{
					VendorID = 5168,
					ProductID = 672
				}
			};
		}
	}
}
