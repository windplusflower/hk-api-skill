using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000830 RID: 2096
	[Preserve]
	[NativeInputDeviceProfile]
	public class MadCatzMC2ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600308E RID: 12430 RVA: 0x0011BF20 File Offset: 0x0011A120
		public override void Define()
		{
			base.Define();
			base.DeviceName = "MadCatz MC2 Controller";
			base.DeviceNotes = "MadCatz MC2 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1848,
					ProductID = 18208
				}
			};
		}
	}
}
