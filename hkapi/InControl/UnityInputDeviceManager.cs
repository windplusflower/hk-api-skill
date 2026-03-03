using System;
using System.Collections.Generic;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000721 RID: 1825
	public class UnityInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06002D53 RID: 11603 RVA: 0x000F3767 File Offset: 0x000F1967
		public UnityInputDeviceManager()
		{
			this.systemDeviceProfiles = new List<InputDeviceProfile>(UnityInputDeviceProfileList.Profiles.Length);
			this.customDeviceProfiles = new List<InputDeviceProfile>();
			this.AddSystemDeviceProfiles();
			this.QueryJoystickInfo();
			this.AttachDevices();
		}

		// Token: 0x06002D54 RID: 11604 RVA: 0x000F37A0 File Offset: 0x000F19A0
		public override void Update(ulong updateTick, float deltaTime)
		{
			this.deviceRefreshTimer += deltaTime;
			if (this.deviceRefreshTimer >= 1f)
			{
				this.deviceRefreshTimer = 0f;
				this.QueryJoystickInfo();
				if (this.JoystickInfoHasChanged)
				{
					Logger.LogInfo("Change in attached Unity joysticks detected; refreshing device list.");
					this.DetachDevices();
					this.AttachDevices();
				}
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x000F37F8 File Offset: 0x000F19F8
		private void QueryJoystickInfo()
		{
			this.joystickNames = Input.GetJoystickNames();
			this.joystickCount = this.joystickNames.Length;
			this.joystickHash = 527 + this.joystickCount;
			for (int i = 0; i < this.joystickCount; i++)
			{
				this.joystickHash = this.joystickHash * 31 + this.joystickNames[i].GetHashCode();
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000F385E File Offset: 0x000F1A5E
		private bool JoystickInfoHasChanged
		{
			get
			{
				return this.joystickHash != this.lastJoystickHash || this.joystickCount != this.lastJoystickCount;
			}
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x000F3884 File Offset: 0x000F1A84
		private void AttachDevices()
		{
			try
			{
				for (int i = 0; i < this.joystickCount; i++)
				{
					this.DetectJoystickDevice(i + 1, this.joystickNames[i]);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError(ex.Message);
				Logger.LogError(ex.StackTrace);
			}
			this.lastJoystickCount = this.joystickCount;
			this.lastJoystickHash = this.joystickHash;
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x000F38F4 File Offset: 0x000F1AF4
		private void DetachDevices()
		{
			int count = this.devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.DetachDevice(this.devices[i]);
			}
			this.devices.Clear();
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x000F3935 File Offset: 0x000F1B35
		public void ReloadDevices()
		{
			this.QueryJoystickInfo();
			this.DetachDevices();
			this.AttachDevices();
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x000F3949 File Offset: 0x000F1B49
		private void AttachDevice(UnityInputDevice device)
		{
			this.devices.Add(device);
			InputManager.AttachDevice(device);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000F3960 File Offset: 0x000F1B60
		private bool HasAttachedDeviceWithJoystickId(int unityJoystickId)
		{
			int count = this.devices.Count;
			for (int i = 0; i < count; i++)
			{
				UnityInputDevice unityInputDevice = this.devices[i] as UnityInputDevice;
				if (unityInputDevice != null && unityInputDevice.JoystickId == unityJoystickId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x000F39A8 File Offset: 0x000F1BA8
		private void DetectJoystickDevice(int unityJoystickId, string unityJoystickName)
		{
			if (this.HasAttachedDeviceWithJoystickId(unityJoystickId))
			{
				return;
			}
			if (unityJoystickName.IndexOf("webcam", StringComparison.OrdinalIgnoreCase) != -1)
			{
				return;
			}
			if (InputManager.UnityVersion < new VersionInfo(4, 5, 0, 0) && (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer) && unityJoystickName == "Unknown Wireless Controller")
			{
				return;
			}
			if (InputManager.UnityVersion >= new VersionInfo(4, 6, 3, 0) && (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer) && string.IsNullOrEmpty(unityJoystickName))
			{
				return;
			}
			InputDeviceProfile inputDeviceProfile = this.DetectDevice(unityJoystickName);
			if (inputDeviceProfile == null)
			{
				UnityInputDevice device = new UnityInputDevice(unityJoystickId, unityJoystickName);
				this.AttachDevice(device);
				Logger.LogWarning(string.Concat(new string[]
				{
					"Device ",
					unityJoystickId.ToString(),
					" with name \"",
					unityJoystickName,
					"\" does not match any supported profiles and will be considered an unknown controller."
				}));
				return;
			}
			if (!inputDeviceProfile.IsHidden)
			{
				UnityInputDevice device2 = new UnityInputDevice(inputDeviceProfile, unityJoystickId, unityJoystickName);
				this.AttachDevice(device2);
				Logger.LogInfo(string.Concat(new string[]
				{
					"Device ",
					unityJoystickId.ToString(),
					" matched profile ",
					inputDeviceProfile.GetType().Name,
					" (",
					inputDeviceProfile.DeviceName,
					")"
				}));
				return;
			}
			Logger.LogInfo(string.Concat(new string[]
			{
				"Device ",
				unityJoystickId.ToString(),
				" matching profile ",
				inputDeviceProfile.GetType().Name,
				" (",
				inputDeviceProfile.DeviceName,
				") is hidden and will not be attached."
			}));
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000F3B3C File Offset: 0x000F1D3C
		private InputDeviceProfile DetectDevice(string unityJoystickName)
		{
			InputDeviceProfile inputDeviceProfile = null;
			InputDeviceInfo deviceInfo = new InputDeviceInfo
			{
				name = unityJoystickName
			};
			return (((inputDeviceProfile ?? this.customDeviceProfiles.Find((InputDeviceProfile profile) => profile.Matches(deviceInfo))) ?? this.systemDeviceProfiles.Find((InputDeviceProfile profile) => profile.Matches(deviceInfo))) ?? this.customDeviceProfiles.Find((InputDeviceProfile profile) => profile.LastResortMatches(deviceInfo))) ?? this.systemDeviceProfiles.Find((InputDeviceProfile profile) => profile.LastResortMatches(deviceInfo));
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000F3BD3 File Offset: 0x000F1DD3
		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			if (deviceProfile != null && deviceProfile.IsSupportedOnThisPlatform)
			{
				this.systemDeviceProfiles.Add(deviceProfile);
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000F3BEC File Offset: 0x000F1DEC
		private void AddSystemDeviceProfiles()
		{
			for (int i = 0; i < UnityInputDeviceProfileList.Profiles.Length; i++)
			{
				InputDeviceProfile deviceProfile = InputDeviceProfile.CreateInstanceOfType(UnityInputDeviceProfileList.Profiles[i]);
				this.AddSystemDeviceProfile(deviceProfile);
			}
		}

		// Token: 0x040032B8 RID: 12984
		private const float deviceRefreshInterval = 1f;

		// Token: 0x040032B9 RID: 12985
		private float deviceRefreshTimer;

		// Token: 0x040032BA RID: 12986
		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		// Token: 0x040032BB RID: 12987
		private readonly List<InputDeviceProfile> customDeviceProfiles;

		// Token: 0x040032BC RID: 12988
		private string[] joystickNames;

		// Token: 0x040032BD RID: 12989
		private int lastJoystickCount;

		// Token: 0x040032BE RID: 12990
		private int lastJoystickHash;

		// Token: 0x040032BF RID: 12991
		private int joystickCount;

		// Token: 0x040032C0 RID: 12992
		private int joystickHash;
	}
}
