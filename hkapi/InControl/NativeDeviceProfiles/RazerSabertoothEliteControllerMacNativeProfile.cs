using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200085F RID: 2143
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerSabertoothEliteControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030EC RID: 12524 RVA: 0x0011DBA8 File Offset: 0x0011BDA8
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Sabertooth Elite Controller";
			base.DeviceNotes = "Razer Sabertooth Elite Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5769,
					ProductID = 65024
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 23812
				}
			};
		}
	}
}
