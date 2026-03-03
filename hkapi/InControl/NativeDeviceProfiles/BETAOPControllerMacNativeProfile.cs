using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007EC RID: 2028
	[Preserve]
	[NativeInputDeviceProfile]
	public class BETAOPControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003006 RID: 12294 RVA: 0x00119F4C File Offset: 0x0011814C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "BETAOP Controller";
			base.DeviceNotes = "BETAOP Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 4544,
					ProductID = 21766
				}
			};
		}
	}
}
