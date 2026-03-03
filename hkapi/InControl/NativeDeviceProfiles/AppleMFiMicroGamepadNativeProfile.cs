using System;

namespace InControl.NativeDeviceProfiles
{
	// Token: 0x02000877 RID: 2167
	[Preserve]
	[NativeInputDeviceProfile]
	public class AppleMFiMicroGamepadNativeProfile : InputDeviceProfile
	{
		// Token: 0x0600311C RID: 12572 RVA: 0x0011EA98 File Offset: 0x0011CC98
		public override void Define()
		{
			base.Define();
			base.DeviceName = "{NAME} MFi Controller";
			base.DeviceNotes = "MFi Controller on iOS / tvOS / macOS";
			base.DeviceClass = InputDeviceClass.Controller;
			base.DeviceStyle = InputDeviceStyle.AppleMFi;
			base.IncludePlatforms = new string[]
			{
				"iOS",
				"tvOS",
				"iPhone",
				"iPad",
				"AppleTV",
				"OS X"
			};
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					VendorID = ushort.MaxValue,
					ProductID = 0,
					VersionNumber = 1U
				}
			};
			base.ButtonMappings = new InputControlMapping[]
			{
				new InputControlMapping
				{
					Name = "A",
					Target = InputControlType.Action1,
					Source = InputDeviceProfile.Button(0)
				},
				new InputControlMapping
				{
					Name = "X",
					Target = InputControlType.Action2,
					Source = InputDeviceProfile.Button(1)
				},
				new InputControlMapping
				{
					Name = "DPad Up",
					Target = InputControlType.DPadUp,
					Source = InputDeviceProfile.Button(2)
				},
				new InputControlMapping
				{
					Name = "DPad Down",
					Target = InputControlType.DPadDown,
					Source = InputDeviceProfile.Button(3)
				},
				new InputControlMapping
				{
					Name = "DPad Left",
					Target = InputControlType.DPadLeft,
					Source = InputDeviceProfile.Button(4)
				},
				new InputControlMapping
				{
					Name = "DPad Right",
					Target = InputControlType.DPadRight,
					Source = InputDeviceProfile.Button(5)
				},
				new InputControlMapping
				{
					Name = "Menu",
					Target = InputControlType.Menu,
					Source = InputDeviceProfile.Button(6)
				}
			};
		}
	}
}
