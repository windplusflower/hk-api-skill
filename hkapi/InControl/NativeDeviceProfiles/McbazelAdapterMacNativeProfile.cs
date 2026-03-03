using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000841 RID: 2113
	[Preserve]
	[NativeInputDeviceProfile]
	public class McbazelAdapterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030B0 RID: 12464 RVA: 0x0011C604 File Offset: 0x0011A804
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Mcbazel Adapter";
			base.DeviceNotes = "Mcbazel Adapter on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 654
				}
			};
		}
	}
}
