using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000862 RID: 2146
	[Preserve]
	[NativeInputDeviceProfile]
	public class RazerWolverineUltimateControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030F2 RID: 12530 RVA: 0x0011DD10 File Offset: 0x0011BF10
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Razer Wolverine Ultimate Controller";
			base.DeviceNotes = "Razer Wolverine Ultimate Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5426,
					ProductID = 2580
				}
			};
		}
	}
}
