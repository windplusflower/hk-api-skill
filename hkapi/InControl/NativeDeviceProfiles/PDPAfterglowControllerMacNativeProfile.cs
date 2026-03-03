using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000848 RID: 2120
	[Preserve]
	[NativeInputDeviceProfile]
	public class PDPAfterglowControllerMacNativeProfile : Xbox360DriverMacNativeProfile
	{
		// Token: 0x060030BE RID: 12478 RVA: 0x0011CB68 File Offset: 0x0011AD68
		public override void Define()
		{
			base.Define();
			base.DeviceName = "PDP Afterglow Controller";
			base.DeviceNotes = "PDP Afterglow Controller on Mac";
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 64252
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63751
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 64253
				},
				new InputDeviceMatcher
				{
					VendorID = 1118,
					ProductID = 742
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 768
				},
				new InputDeviceMatcher
				{
					VendorID = 9414,
					ProductID = 22554
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 1043
				},
				new InputDeviceMatcher
				{
					VendorID = 7085,
					ProductID = 63744
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 63744
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 275
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 531
				},
				new InputDeviceMatcher
				{
					VendorID = 4779,
					ProductID = 769
				},
				new InputDeviceMatcher
				{
					VendorID = 3695,
					ProductID = 4371
				}
			};
		}
	}
}
