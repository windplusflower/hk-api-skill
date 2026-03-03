using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000854 RID: 2132
	[Preserve]
	[NativeInputDeviceProfile]
	public class PowerAAirflowControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030D6 RID: 12502 RVA: 0x0011D630 File Offset: 0x0011B830
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PowerA Airflow Controller";
			base.DeviceNotes = "PowerA Airflow Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5604,
					ProductID = 16138
				}
			};
		}
	}
}
