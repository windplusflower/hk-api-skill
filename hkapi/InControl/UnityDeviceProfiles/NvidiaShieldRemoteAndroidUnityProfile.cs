using System;

namespace InControl.UnityDeviceProfiles
{
	// Token: 0x02000772 RID: 1906
	[Preserve]
	[UnityInputDeviceProfile]
	public class NvidiaShieldRemoteAndroidUnityProfile : InputDeviceProfile
	{
		// Token: 0x06002F12 RID: 12050 RVA: 0x00100B6C File Offset: 0x000FED6C
		public override void Define()
		{
			base.Define();
			base.DeviceName = "NVIDIA Shield Remote";
			base.DeviceNotes = "NVIDIA Shield Remote on Android";
			base.DeviceClass = InputDeviceClass.Remote;
			base.DeviceStyle = InputDeviceStyle.NVIDIAShield;
			base.IncludePlatforms = new string[]
			{
				"Android"
			};
			base.Matchers = new InputDeviceMatcher[]
			{
				new InputDeviceMatcher
				{
					NameLiteral = "SHIELD Remote"
				},
				new InputDeviceMatcher
				{
					NamePattern = "SHIELD Remote"
				}
			};
			base.ButtonMappings = new InputControlMapping[]
			{
				new InputControlMapping
				{
					Name = "A",
					Target = InputControlType.Action1,
					Source = InputDeviceProfile.Button(0)
				}
			};
			base.AnalogMappings = new InputControlMapping[]
			{
				InputDeviceProfile.DPadLeftMapping(4),
				InputDeviceProfile.DPadRightMapping(4),
				InputDeviceProfile.DPadUpMapping(5),
				InputDeviceProfile.DPadDownMapping(5)
			};
		}
	}
}
