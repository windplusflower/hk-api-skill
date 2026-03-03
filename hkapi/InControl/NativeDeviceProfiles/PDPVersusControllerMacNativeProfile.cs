using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x0200084F RID: 2127
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPVersusControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030CC RID: 12492 RVA: 0x0011D100 File Offset: 0x0011B300
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Versus Controller";
			base.DeviceNotes = "PDP Versus Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63748
				}
			};
		}
	}
}
