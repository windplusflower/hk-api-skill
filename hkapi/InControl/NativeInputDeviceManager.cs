using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using InControl.NativeDeviceProfiles;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006FD RID: 1789
	public class NativeInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06002C3C RID: 11324 RVA: 0x000EE844 File Offset: 0x000ECA44
		public NativeInputDeviceManager()
		{
			this.attachedDevices = new List<NativeInputDevice>();
			this.detachedDevices = new List<NativeInputDevice>();
			this.systemDeviceProfiles = new List<InputDeviceProfile>(NativeInputDeviceProfileList.Profiles.Length);
			this.customDeviceProfiles = new List<InputDeviceProfile>();
			this.deviceEvents = new uint[32];
			this.AddSystemDeviceProfiles();
			NativeInputOptions options = default(NativeInputOptions);
			options.enableXInput = (InputManager.NativeInputEnableXInput ? 1 : 0);
			options.enableMFi = (InputManager.NativeInputEnableMFi ? 1 : 0);
			options.preventSleep = (InputManager.NativeInputPreventSleep ? 1 : 0);
			if (InputManager.NativeInputUpdateRate > 0U)
			{
				options.updateRate = (ushort)InputManager.NativeInputUpdateRate;
			}
			else
			{
				options.updateRate = (ushort)Mathf.FloorToInt(1f / Time.fixedDeltaTime);
			}
			Native.Init(options);
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000EE910 File Offset: 0x000ECB10
		public override void Destroy()
		{
			Native.Stop();
		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x000EE918 File Offset: 0x000ECB18
		public override void Update(ulong updateTick, float deltaTime)
		{
			IntPtr source;
			int num = Native.GetDeviceEvents(out source);
			if (num > 0)
			{
				Utility.ArrayExpand<uint>(ref this.deviceEvents, num);
				MarshalUtility.Copy(source, this.deviceEvents, num);
				int num2 = 0;
				uint num3 = this.deviceEvents[num2++];
				int num4 = 0;
				while ((long)num4 < (long)((ulong)num3))
				{
					uint num5 = this.deviceEvents[num2++];
					StringBuilder stringBuilder = new StringBuilder(256);
					stringBuilder.Append("Attached native device with handle " + num5.ToString() + ":\n");
					InputDeviceInfo inputDeviceInfo;
					if (Native.GetDeviceInfo(num5, out inputDeviceInfo))
					{
						stringBuilder.AppendFormat("Name: {0}\n", inputDeviceInfo.name);
						stringBuilder.AppendFormat("Driver Type: {0}\n", inputDeviceInfo.driverType);
						stringBuilder.AppendFormat("Location ID: {0}\n", inputDeviceInfo.location);
						stringBuilder.AppendFormat("Serial Number: {0}\n", inputDeviceInfo.serialNumber);
						stringBuilder.AppendFormat("Vendor ID: 0x{0:x}\n", inputDeviceInfo.vendorID);
						stringBuilder.AppendFormat("Product ID: 0x{0:x}\n", inputDeviceInfo.productID);
						stringBuilder.AppendFormat("Version Number: 0x{0:x}\n", inputDeviceInfo.versionNumber);
						stringBuilder.AppendFormat("Buttons: {0}\n", inputDeviceInfo.numButtons);
						stringBuilder.AppendFormat("Analogs: {0}\n", inputDeviceInfo.numAnalogs);
						this.DetectDevice(num5, inputDeviceInfo);
					}
					Logger.LogInfo(stringBuilder.ToString());
					num4++;
				}
				uint num6 = this.deviceEvents[num2++];
				int num7 = 0;
				while ((long)num7 < (long)((ulong)num6))
				{
					uint deviceHandle = this.deviceEvents[num2++];
					Logger.LogInfo("Detached native device with handle " + deviceHandle.ToString() + ":");
					NativeInputDevice nativeInputDevice = this.FindAttachedDevice(deviceHandle);
					if (nativeInputDevice != null)
					{
						this.DetachDevice(nativeInputDevice);
					}
					else
					{
						Logger.LogWarning("Couldn't find device to detach with handle: " + deviceHandle.ToString());
					}
					num7++;
				}
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x000EEB1C File Offset: 0x000ECD1C
		private void DetectDevice(uint deviceHandle, InputDeviceInfo deviceInfo)
		{
			InputDeviceProfile inputDeviceProfile = null;
			inputDeviceProfile = (inputDeviceProfile ?? this.customDeviceProfiles.Find((InputDeviceProfile profile) => profile.Matches(deviceInfo)));
			inputDeviceProfile = (inputDeviceProfile ?? this.systemDeviceProfiles.Find((InputDeviceProfile profile) => profile.Matches(deviceInfo)));
			inputDeviceProfile = (inputDeviceProfile ?? this.customDeviceProfiles.Find((InputDeviceProfile profile) => profile.LastResortMatches(deviceInfo)));
			inputDeviceProfile = (inputDeviceProfile ?? this.systemDeviceProfiles.Find((InputDeviceProfile profile) => profile.LastResortMatches(deviceInfo)));
			if (inputDeviceProfile == null || inputDeviceProfile.IsNotHidden)
			{
				NativeInputDevice nativeInputDevice = this.FindDetachedDevice(deviceInfo) ?? new NativeInputDevice();
				nativeInputDevice.Initialize(deviceHandle, deviceInfo, inputDeviceProfile);
				this.AttachDevice(nativeInputDevice);
			}
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x000EEBE2 File Offset: 0x000ECDE2
		private void AttachDevice(NativeInputDevice device)
		{
			this.detachedDevices.Remove(device);
			this.attachedDevices.Add(device);
			InputManager.AttachDevice(device);
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x000EEC03 File Offset: 0x000ECE03
		private void DetachDevice(NativeInputDevice device)
		{
			this.attachedDevices.Remove(device);
			this.detachedDevices.Add(device);
			InputManager.DetachDevice(device);
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000EEC24 File Offset: 0x000ECE24
		private NativeInputDevice FindAttachedDevice(uint deviceHandle)
		{
			int count = this.attachedDevices.Count;
			for (int i = 0; i < count; i++)
			{
				NativeInputDevice nativeInputDevice = this.attachedDevices[i];
				if (nativeInputDevice.Handle == deviceHandle)
				{
					return nativeInputDevice;
				}
			}
			return null;
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000EEC64 File Offset: 0x000ECE64
		private NativeInputDevice FindDetachedDevice(InputDeviceInfo deviceInfo)
		{
			ReadOnlyCollection<NativeInputDevice> arg = new ReadOnlyCollection<NativeInputDevice>(this.detachedDevices);
			if (NativeInputDeviceManager.CustomFindDetachedDevice != null)
			{
				return NativeInputDeviceManager.CustomFindDetachedDevice(deviceInfo, arg);
			}
			return NativeInputDeviceManager.SystemFindDetachedDevice(deviceInfo, arg);
		}

		// Token: 0x06002C44 RID: 11332 RVA: 0x000EEC98 File Offset: 0x000ECE98
		private static NativeInputDevice SystemFindDetachedDevice(InputDeviceInfo deviceInfo, ReadOnlyCollection<NativeInputDevice> detachedDevices)
		{
			int count = detachedDevices.Count;
			for (int i = 0; i < count; i++)
			{
				NativeInputDevice nativeInputDevice = detachedDevices[i];
				if (nativeInputDevice.Info.HasSameVendorID(deviceInfo) && nativeInputDevice.Info.HasSameProductID(deviceInfo) && nativeInputDevice.Info.HasSameSerialNumber(deviceInfo))
				{
					return nativeInputDevice;
				}
			}
			for (int j = 0; j < count; j++)
			{
				NativeInputDevice nativeInputDevice2 = detachedDevices[j];
				if (nativeInputDevice2.Info.HasSameVendorID(deviceInfo) && nativeInputDevice2.Info.HasSameProductID(deviceInfo) && nativeInputDevice2.Info.HasSameLocation(deviceInfo))
				{
					return nativeInputDevice2;
				}
			}
			for (int k = 0; k < count; k++)
			{
				NativeInputDevice nativeInputDevice3 = detachedDevices[k];
				if (nativeInputDevice3.Info.HasSameVendorID(deviceInfo) && nativeInputDevice3.Info.HasSameProductID(deviceInfo) && nativeInputDevice3.Info.HasSameVersionNumber(deviceInfo))
				{
					return nativeInputDevice3;
				}
			}
			for (int l = 0; l < count; l++)
			{
				NativeInputDevice nativeInputDevice4 = detachedDevices[l];
				if (nativeInputDevice4.Info.HasSameLocation(deviceInfo))
				{
					return nativeInputDevice4;
				}
			}
			return null;
		}

		// Token: 0x06002C45 RID: 11333 RVA: 0x000EEDCB File Offset: 0x000ECFCB
		private void AddSystemDeviceProfile(InputDeviceProfile deviceProfile)
		{
			if (deviceProfile != null && deviceProfile.IsSupportedOnThisPlatform)
			{
				this.systemDeviceProfiles.Add(deviceProfile);
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x000EEDE4 File Offset: 0x000ECFE4
		private void AddSystemDeviceProfiles()
		{
			for (int i = 0; i < NativeInputDeviceProfileList.Profiles.Length; i++)
			{
				InputDeviceProfile deviceProfile = InputDeviceProfile.CreateInstanceOfType(NativeInputDeviceProfileList.Profiles[i]);
				this.AddSystemDeviceProfile(deviceProfile);
			}
		}

		// Token: 0x06002C47 RID: 11335 RVA: 0x000EEE18 File Offset: 0x000ED018
		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			if (Application.platform != RuntimePlatform.OSXPlayer && Application.platform != RuntimePlatform.OSXEditor && Application.platform != RuntimePlatform.WindowsPlayer && Application.platform != RuntimePlatform.WindowsEditor && Application.platform != RuntimePlatform.IPhonePlayer && Application.platform != RuntimePlatform.tvOS)
			{
				return false;
			}
			try
			{
				NativeVersionInfo nativeVersionInfo;
				Native.GetVersionInfo(out nativeVersionInfo);
				Logger.LogInfo(string.Concat(new string[]
				{
					"InControl Native (version ",
					nativeVersionInfo.major.ToString(),
					".",
					nativeVersionInfo.minor.ToString(),
					".",
					nativeVersionInfo.patch.ToString(),
					")"
				}));
			}
			catch (DllNotFoundException ex)
			{
				if (errors != null)
				{
					errors.Add(ex.Message + Utility.PluginFileExtension() + " could not be found or is missing a dependency.");
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002C48 RID: 11336 RVA: 0x000EEEF4 File Offset: 0x000ED0F4
		internal static bool Enable()
		{
			List<string> list = new List<string>();
			if (NativeInputDeviceManager.CheckPlatformSupport(list))
			{
				if (InputManager.NativeInputEnableMFi)
				{
					InputManager.HideDevicesWithProfile(typeof(XboxOneSBluetoothMacNativeProfile));
					InputManager.HideDevicesWithProfile(typeof(PlayStation4MacNativeProfile));
					InputManager.HideDevicesWithProfile(typeof(SteelseriesNimbusMacNativeProfile));
					InputManager.HideDevicesWithProfile(typeof(HoriPadUltimateMacNativeProfile));
					InputManager.HideDevicesWithProfile(typeof(NintendoSwitchProMacNativeProfile));
				}
				InputManager.AddDeviceManager<NativeInputDeviceManager>();
				return true;
			}
			foreach (string str in list)
			{
				Logger.LogError("Error enabling NativeInputDeviceManager: " + str);
			}
			return false;
		}

		// Token: 0x040031AD RID: 12717
		public static Func<InputDeviceInfo, ReadOnlyCollection<NativeInputDevice>, NativeInputDevice> CustomFindDetachedDevice;

		// Token: 0x040031AE RID: 12718
		private readonly List<NativeInputDevice> attachedDevices;

		// Token: 0x040031AF RID: 12719
		private readonly List<NativeInputDevice> detachedDevices;

		// Token: 0x040031B0 RID: 12720
		private readonly List<InputDeviceProfile> systemDeviceProfiles;

		// Token: 0x040031B1 RID: 12721
		private readonly List<InputDeviceProfile> customDeviceProfiles;

		// Token: 0x040031B2 RID: 12722
		private uint[] deviceEvents;
	}
}
