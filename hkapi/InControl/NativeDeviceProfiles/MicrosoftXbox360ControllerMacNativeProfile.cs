using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000843 RID: 2115
	[Preserve]
	[NativeInputDeviceProfile]
	public class MicrosoftXbox360ControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030B4 RID: 12468 RVA: 0x0011C6D4 File Offset: 0x0011A8D4
		public override void Define()
		{
			base.Define();
			base.DeviceName = "Microsoft Xbox 360 Controller";
			base.DeviceNotes = "Microsoft Xbox 360 Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 654
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 655
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 307
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 63233
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 672
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 62721
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 672
				}
			};
		}
	}
}
