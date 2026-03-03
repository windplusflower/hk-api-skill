using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000864 RID: 2148
	[Preserve]
	[NativeInputDeviceProfile]
	public class RedOctaneGuitarMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030F6 RID: 12534 RVA: 0x0011DE14 File Offset: 0x0011C014
		public override void Define()
		{
			base.Define();
			base.DeviceName = "RedOctane Guitar";
			base.DeviceNotes = "RedOctane Guitar on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5168,
					ProductID = 1803
				}
			};
		}
	}
}
