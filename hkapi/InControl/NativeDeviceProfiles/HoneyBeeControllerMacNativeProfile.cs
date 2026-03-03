using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007FB RID: 2043
	[Preserve]
	[NativeInputDeviceProfile]
	public class HoneyBeeControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x0011A634 File Offset: 0x00118834
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Honey Bee Controller";
			base.DeviceNotes = "Honey Bee Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 4779,
					ProductID = 21760
				}
			};
		}
	}
}
