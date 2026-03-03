using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x020007EE RID: 2030
	[Preserve]
	[NativeInputDeviceProfile]
	public class BigBenControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x0600300A RID: 12298 RVA: 0x0011A01C File Offset: 0x0011821C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Big Ben Controller";
			base.DeviceNotes = "Big Ben Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 5227,
					ProductID = 1537
				}
			};
		}
	}
}
