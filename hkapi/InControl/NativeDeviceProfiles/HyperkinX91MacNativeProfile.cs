using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000814 RID: 2068
	[Preserve]
	[NativeInputDeviceProfile]
	public class HyperkinX91MacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003056 RID: 12374 RVA: 0x0011B290 File Offset: 0x00119490
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Hyperkin X91";
			base.DeviceNotes = "Hyperkin X91 on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 11812,
					ProductID = 5768
				}
			};
		}
	}
}
