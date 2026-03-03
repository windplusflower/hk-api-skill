using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007EF RID: 2031
	[Preserve]
	[NativeInputDeviceProfile]
	public class BrookNeoGeoConverterMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600300C RID: 12300 RVA: 0x0011A084 File Offset: 0x00118284
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Brook NeoGeo Converter";
			base.DeviceNotes = "Brook NeoGeo Converter on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 3090,
					ProductID = 2036
				}
			};
		}
	}
}
