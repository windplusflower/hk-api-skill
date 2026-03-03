using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	// Token: 0x020006F4 RID: 1780
	public static class InputManager
	{
		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06002B93 RID: 11155 RVA: 0x000EC45C File Offset: 0x000EA65C
		// (remove) Token: 0x06002B94 RID: 11156 RVA: 0x000EC490 File Offset: 0x000EA690
		public static event Action OnSetup;

		// Token: 0x1400006A RID: 106
		// (add) Token: 0x06002B95 RID: 11157 RVA: 0x000EC4C4 File Offset: 0x000EA6C4
		// (remove) Token: 0x06002B96 RID: 11158 RVA: 0x000EC4F8 File Offset: 0x000EA6F8
		public static event Action<ulong, float> OnUpdate;

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06002B97 RID: 11159 RVA: 0x000EC52C File Offset: 0x000EA72C
		// (remove) Token: 0x06002B98 RID: 11160 RVA: 0x000EC560 File Offset: 0x000EA760
		public static event Action OnReset;

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06002B99 RID: 11161 RVA: 0x000EC594 File Offset: 0x000EA794
		// (remove) Token: 0x06002B9A RID: 11162 RVA: 0x000EC5C8 File Offset: 0x000EA7C8
		public static event Action<InputDevice> OnDeviceAttached;

		// Token: 0x1400006D RID: 109
		// (add) Token: 0x06002B9B RID: 11163 RVA: 0x000EC5FC File Offset: 0x000EA7FC
		// (remove) Token: 0x06002B9C RID: 11164 RVA: 0x000EC630 File Offset: 0x000EA830
		public static event Action<InputDevice> OnDeviceDetached;

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x06002B9D RID: 11165 RVA: 0x000EC664 File Offset: 0x000EA864
		// (remove) Token: 0x06002B9E RID: 11166 RVA: 0x000EC698 File Offset: 0x000EA898
		public static event Action<InputDevice> OnActiveDeviceChanged;

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x06002B9F RID: 11167 RVA: 0x000EC6CC File Offset: 0x000EA8CC
		// (remove) Token: 0x06002BA0 RID: 11168 RVA: 0x000EC700 File Offset: 0x000EA900
		internal static event Action<ulong, float> OnUpdateDevices;

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x06002BA1 RID: 11169 RVA: 0x000EC734 File Offset: 0x000EA934
		// (remove) Token: 0x06002BA2 RID: 11170 RVA: 0x000EC768 File Offset: 0x000EA968
		internal static event Action<ulong, float> OnCommitDevices;

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000EC79B File Offset: 0x000EA99B
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x000EC7A2 File Offset: 0x000EA9A2
		public static bool CommandWasPressed { get; private set; }

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000EC7AA File Offset: 0x000EA9AA
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x000EC7B1 File Offset: 0x000EA9B1
		public static bool InvertYAxis { get; set; }

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000EC7B9 File Offset: 0x000EA9B9
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x000EC7C0 File Offset: 0x000EA9C0
		public static bool IsSetup { get; private set; }

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000EC7C8 File Offset: 0x000EA9C8
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x000EC7CF File Offset: 0x000EA9CF
		public static IMouseProvider MouseProvider { get; private set; }

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000EC7D7 File Offset: 0x000EA9D7
		// (set) Token: 0x06002BAC RID: 11180 RVA: 0x000EC7DE File Offset: 0x000EA9DE
		public static IKeyboardProvider KeyboardProvider { get; private set; }

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000EC7E6 File Offset: 0x000EA9E6
		// (set) Token: 0x06002BAE RID: 11182 RVA: 0x000EC7ED File Offset: 0x000EA9ED
		internal static string Platform { get; private set; }

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000EC7F5 File Offset: 0x000EA9F5
		[Obsolete("Use InputManager.CommandWasPressed instead.")]
		public static bool MenuWasPressed
		{
			get
			{
				return InputManager.CommandWasPressed;
			}
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000EC7FC File Offset: 0x000EA9FC
		internal static bool SetupInternal()
		{
			if (InputManager.IsSetup)
			{
				return false;
			}
			InputManager.Platform = Utility.GetPlatformName(true);
			InputManager.enabled = true;
			InputManager.initialTime = 0f;
			InputManager.currentTime = 0f;
			InputManager.lastUpdateTime = 0f;
			InputManager.currentTick = 0UL;
			InputManager.applicationIsFocused = true;
			InputManager.deviceManagers.Clear();
			InputManager.deviceManagerTable.Clear();
			InputManager.devices.Clear();
			InputManager.Devices = InputManager.devices.AsReadOnly();
			InputManager.activeDevice = InputDevice.Null;
			InputManager.activeDevices.Clear();
			InputManager.ActiveDevices = InputManager.activeDevices.AsReadOnly();
			InputManager.playerActionSets.Clear();
			InputManager.MouseProvider = new UnityMouseProvider();
			InputManager.MouseProvider.Setup();
			InputManager.KeyboardProvider = new UnityKeyboardProvider();
			InputManager.KeyboardProvider.Setup();
			InputManager.IsSetup = true;
			bool flag = true;
			if (InputManager.EnableNativeInput && NativeInputDeviceManager.Enable())
			{
				flag = false;
			}
			if (InputManager.EnableXInput && flag)
			{
				XInputDeviceManager.Enable();
			}
			if (InputManager.OnSetup != null)
			{
				InputManager.OnSetup();
				InputManager.OnSetup = null;
			}
			if (flag)
			{
				InputManager.AddDeviceManager<UnityInputDeviceManager>();
			}
			return true;
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000EC91C File Offset: 0x000EAB1C
		internal static void ResetInternal()
		{
			if (InputManager.OnReset != null)
			{
				InputManager.OnReset();
			}
			InputManager.OnSetup = null;
			InputManager.OnUpdate = null;
			InputManager.OnReset = null;
			InputManager.OnActiveDeviceChanged = null;
			InputManager.OnDeviceAttached = null;
			InputManager.OnDeviceDetached = null;
			InputManager.OnUpdateDevices = null;
			InputManager.OnCommitDevices = null;
			InputManager.DestroyDeviceManagers();
			InputManager.DestroyDevices();
			InputManager.playerActionSets.Clear();
			InputManager.MouseProvider.Reset();
			InputManager.KeyboardProvider.Reset();
			InputManager.IsSetup = false;
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000EC998 File Offset: 0x000EAB98
		public static void Update()
		{
			InputManager.UpdateInternal();
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000EC9A0 File Offset: 0x000EABA0
		internal static void UpdateInternal()
		{
			InputManager.AssertIsSetup();
			if (InputManager.OnSetup != null)
			{
				InputManager.OnSetup();
				InputManager.OnSetup = null;
			}
			if (!InputManager.enabled)
			{
				return;
			}
			if (InputManager.SuspendInBackground && !InputManager.applicationIsFocused)
			{
				return;
			}
			InputManager.currentTick += 1UL;
			InputManager.UpdateCurrentTime();
			float num = InputManager.currentTime - InputManager.lastUpdateTime;
			InputManager.MouseProvider.Update();
			InputManager.KeyboardProvider.Update();
			InputManager.UpdateDeviceManagers(num);
			InputManager.CommandWasPressed = false;
			InputManager.UpdateDevices(num);
			InputManager.CommitDevices(num);
			InputDevice inputDevice = InputManager.ActiveDevice;
			InputManager.UpdateActiveDevice();
			InputManager.UpdatePlayerActionSets(num);
			if (inputDevice != InputManager.ActiveDevice && InputManager.OnActiveDeviceChanged != null)
			{
				InputManager.OnActiveDeviceChanged(InputManager.ActiveDevice);
			}
			if (InputManager.OnUpdate != null)
			{
				InputManager.OnUpdate(InputManager.currentTick, num);
			}
			InputManager.lastUpdateTime = InputManager.currentTime;
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000ECA78 File Offset: 0x000EAC78
		public static void Reload()
		{
			InputManager.ResetInternal();
			InputManager.SetupInternal();
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000ECA85 File Offset: 0x000EAC85
		private static void AssertIsSetup()
		{
			if (!InputManager.IsSetup)
			{
				throw new Exception("InputManager is not initialized. Call InputManager.Setup() first.");
			}
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000ECA9C File Offset: 0x000EAC9C
		private static void SetZeroTickOnAllControls()
		{
			int count = InputManager.devices.Count;
			for (int i = 0; i < count; i++)
			{
				ReadOnlyCollection<InputControl> controls = InputManager.devices[i].Controls;
				int count2 = controls.Count;
				for (int j = 0; j < count2; j++)
				{
					InputControl inputControl = controls[j];
					if (inputControl != null)
					{
						inputControl.SetZeroTick();
					}
				}
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000ECB00 File Offset: 0x000EAD00
		public static void ClearInputState()
		{
			int count = InputManager.devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.devices[i].ClearInputState();
			}
			int count2 = InputManager.playerActionSets.Count;
			for (int j = 0; j < count2; j++)
			{
				InputManager.playerActionSets[j].ClearInputState();
			}
			InputManager.activeDevice = InputDevice.Null;
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x000ECB65 File Offset: 0x000EAD65
		internal static void OnApplicationFocus(bool focusState)
		{
			if (!focusState)
			{
				if (InputManager.SuspendInBackground)
				{
					InputManager.ClearInputState();
				}
				InputManager.SetZeroTickOnAllControls();
			}
			InputManager.applicationIsFocused = focusState;
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00003603 File Offset: 0x00001803
		internal static void OnApplicationPause(bool pauseState)
		{
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000ECB81 File Offset: 0x000EAD81
		internal static void OnApplicationQuit()
		{
			InputManager.ResetInternal();
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000ECB88 File Offset: 0x000EAD88
		internal static void OnLevelWasLoaded()
		{
			InputManager.SetZeroTickOnAllControls();
			InputManager.UpdateInternal();
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000ECB94 File Offset: 0x000EAD94
		public static void AddDeviceManager(InputDeviceManager deviceManager)
		{
			InputManager.AssertIsSetup();
			Type type = deviceManager.GetType();
			if (InputManager.deviceManagerTable.ContainsKey(type))
			{
				Logger.LogError("A device manager of type '" + type.Name + "' already exists; cannot add another.");
				return;
			}
			InputManager.deviceManagers.Add(deviceManager);
			InputManager.deviceManagerTable.Add(type, deviceManager);
			deviceManager.Update(InputManager.currentTick, InputManager.currentTime - InputManager.lastUpdateTime);
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000ECC02 File Offset: 0x000EAE02
		public static void AddDeviceManager<T>() where T : InputDeviceManager, new()
		{
			InputManager.AddDeviceManager(Activator.CreateInstance<T>());
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000ECC14 File Offset: 0x000EAE14
		public static T GetDeviceManager<T>() where T : InputDeviceManager
		{
			InputDeviceManager inputDeviceManager;
			if (InputManager.deviceManagerTable.TryGetValue(typeof(T), out inputDeviceManager))
			{
				return inputDeviceManager as T;
			}
			return default(T);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000ECC4E File Offset: 0x000EAE4E
		public static bool HasDeviceManager<T>() where T : InputDeviceManager
		{
			return InputManager.deviceManagerTable.ContainsKey(typeof(T));
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000ECC64 File Offset: 0x000EAE64
		private static void UpdateCurrentTime()
		{
			if (InputManager.initialTime < 1E-45f)
			{
				InputManager.initialTime = Time.realtimeSinceStartup;
			}
			InputManager.currentTime = Mathf.Max(0f, Time.realtimeSinceStartup - InputManager.initialTime);
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000ECC98 File Offset: 0x000EAE98
		private static void UpdateDeviceManagers(float deltaTime)
		{
			int count = InputManager.deviceManagers.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.deviceManagers[i].Update(InputManager.currentTick, deltaTime);
			}
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000ECCD4 File Offset: 0x000EAED4
		private static void DestroyDeviceManagers()
		{
			int count = InputManager.deviceManagers.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.deviceManagers[i].Destroy();
			}
			InputManager.deviceManagers.Clear();
			InputManager.deviceManagerTable.Clear();
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000ECD1C File Offset: 0x000EAF1C
		private static void DestroyDevices()
		{
			int count = InputManager.devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.devices[i].OnDetached();
			}
			InputManager.devices.Clear();
			InputManager.activeDevice = InputDevice.Null;
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000ECD64 File Offset: 0x000EAF64
		private static void UpdateDevices(float deltaTime)
		{
			int count = InputManager.devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.devices[i].Update(InputManager.currentTick, deltaTime);
			}
			if (InputManager.OnUpdateDevices != null)
			{
				InputManager.OnUpdateDevices(InputManager.currentTick, deltaTime);
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000ECDB8 File Offset: 0x000EAFB8
		private static void CommitDevices(float deltaTime)
		{
			int count = InputManager.devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputDevice inputDevice = InputManager.devices[i];
				inputDevice.Commit(InputManager.currentTick, deltaTime);
				if (inputDevice.CommandWasPressed)
				{
					InputManager.CommandWasPressed = true;
				}
			}
			if (InputManager.OnCommitDevices != null)
			{
				InputManager.OnCommitDevices(InputManager.currentTick, deltaTime);
			}
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000ECE18 File Offset: 0x000EB018
		private static void UpdateActiveDevice()
		{
			InputManager.activeDevices.Clear();
			int count = InputManager.devices.Count;
			for (int i = 0; i < count; i++)
			{
				InputDevice inputDevice = InputManager.devices[i];
				if (inputDevice.LastInputAfter(InputManager.ActiveDevice) && !inputDevice.Passive)
				{
					InputManager.ActiveDevice = inputDevice;
				}
				if (inputDevice.IsActive)
				{
					InputManager.activeDevices.Add(inputDevice);
				}
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000ECE80 File Offset: 0x000EB080
		public static void AttachDevice(InputDevice inputDevice)
		{
			InputManager.AssertIsSetup();
			if (!inputDevice.IsSupportedOnThisPlatform)
			{
				return;
			}
			if (inputDevice.IsAttached)
			{
				return;
			}
			if (!InputManager.devices.Contains(inputDevice))
			{
				InputManager.devices.Add(inputDevice);
				InputManager.devices.Sort((InputDevice d1, InputDevice d2) => d1.SortOrder.CompareTo(d2.SortOrder));
			}
			inputDevice.OnAttached();
			if (InputManager.OnDeviceAttached != null)
			{
				InputManager.OnDeviceAttached(inputDevice);
			}
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000ECF00 File Offset: 0x000EB100
		public static void DetachDevice(InputDevice inputDevice)
		{
			if (!InputManager.IsSetup)
			{
				return;
			}
			if (!inputDevice.IsAttached)
			{
				return;
			}
			InputManager.devices.Remove(inputDevice);
			if (InputManager.ActiveDevice == inputDevice)
			{
				InputManager.ActiveDevice = InputDevice.Null;
			}
			inputDevice.OnDetached();
			if (InputManager.OnDeviceDetached != null)
			{
				InputManager.OnDeviceDetached(inputDevice);
			}
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000ECF54 File Offset: 0x000EB154
		public static void HideDevicesWithProfile(Type type)
		{
			if (type.IsSubclassOf(typeof(InputDeviceProfile)))
			{
				InputDeviceProfile.Hide(type);
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000ECF6E File Offset: 0x000EB16E
		internal static void AttachPlayerActionSet(PlayerActionSet playerActionSet)
		{
			if (!InputManager.playerActionSets.Contains(playerActionSet))
			{
				InputManager.playerActionSets.Add(playerActionSet);
			}
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000ECF88 File Offset: 0x000EB188
		internal static void DetachPlayerActionSet(PlayerActionSet playerActionSet)
		{
			InputManager.playerActionSets.Remove(playerActionSet);
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000ECF98 File Offset: 0x000EB198
		internal static void UpdatePlayerActionSets(float deltaTime)
		{
			int count = InputManager.playerActionSets.Count;
			for (int i = 0; i < count; i++)
			{
				InputManager.playerActionSets[i].Update(InputManager.currentTick, deltaTime);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002BCD RID: 11213 RVA: 0x000ECFD4 File Offset: 0x000EB1D4
		public static bool AnyKeyIsPressed
		{
			get
			{
				return KeyCombo.Detect(true).IncludeCount > 0;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000ECFF2 File Offset: 0x000EB1F2
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x000ED002 File Offset: 0x000EB202
		public static InputDevice ActiveDevice
		{
			get
			{
				return InputManager.activeDevice ?? InputDevice.Null;
			}
			private set
			{
				InputManager.activeDevice = (value ?? InputDevice.Null);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000ED013 File Offset: 0x000EB213
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x000ED01A File Offset: 0x000EB21A
		public static bool Enabled
		{
			get
			{
				return InputManager.enabled;
			}
			set
			{
				if (InputManager.enabled != value)
				{
					if (value)
					{
						InputManager.SetZeroTickOnAllControls();
						InputManager.UpdateInternal();
					}
					else
					{
						InputManager.ClearInputState();
						InputManager.SetZeroTickOnAllControls();
					}
					InputManager.enabled = value;
				}
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000ED043 File Offset: 0x000EB243
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x000ED04A File Offset: 0x000EB24A
		public static bool SuspendInBackground { get; set; }

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000ED052 File Offset: 0x000EB252
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x000ED059 File Offset: 0x000EB259
		public static bool EnableNativeInput { get; internal set; }

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000ED061 File Offset: 0x000EB261
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x000ED068 File Offset: 0x000EB268
		public static bool EnableXInput { get; internal set; }

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000ED070 File Offset: 0x000EB270
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x000ED077 File Offset: 0x000EB277
		public static uint XInputUpdateRate { get; internal set; }

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000ED07F File Offset: 0x000EB27F
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x000ED086 File Offset: 0x000EB286
		public static uint XInputBufferSize { get; internal set; }

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000ED08E File Offset: 0x000EB28E
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x000ED095 File Offset: 0x000EB295
		public static bool NativeInputEnableXInput { get; internal set; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000ED09D File Offset: 0x000EB29D
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x000ED0A4 File Offset: 0x000EB2A4
		public static bool NativeInputEnableMFi { get; internal set; }

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000ED0AC File Offset: 0x000EB2AC
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x000ED0B3 File Offset: 0x000EB2B3
		public static bool NativeInputPreventSleep { get; internal set; }

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000ED0BB File Offset: 0x000EB2BB
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x000ED0C2 File Offset: 0x000EB2C2
		public static uint NativeInputUpdateRate { get; internal set; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002BE4 RID: 11236 RVA: 0x000ED0CA File Offset: 0x000EB2CA
		// (set) Token: 0x06002BE5 RID: 11237 RVA: 0x000ED0D1 File Offset: 0x000EB2D1
		public static bool EnableICade { get; internal set; }

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002BE6 RID: 11238 RVA: 0x000ED0D9 File Offset: 0x000EB2D9
		internal static VersionInfo UnityVersion
		{
			get
			{
				if (InputManager.unityVersion == null)
				{
					InputManager.unityVersion = new VersionInfo?(VersionInfo.UnityVersion());
				}
				return InputManager.unityVersion.Value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06002BE7 RID: 11239 RVA: 0x000ED100 File Offset: 0x000EB300
		public static ulong CurrentTick
		{
			get
			{
				return InputManager.currentTick;
			}
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000ED108 File Offset: 0x000EB308
		// Note: this type is marked as 'beforefieldinit'.
		static InputManager()
		{
			InputManager.Version = VersionInfo.InControlVersion();
			InputManager.deviceManagers = new List<InputDeviceManager>();
			InputManager.deviceManagerTable = new Dictionary<Type, InputDeviceManager>();
			InputManager.devices = new List<InputDevice>();
			InputManager.activeDevice = InputDevice.Null;
			InputManager.activeDevices = new List<InputDevice>();
			InputManager.playerActionSets = new List<PlayerActionSet>();
		}

		// Token: 0x04003166 RID: 12646
		public static readonly VersionInfo Version;

		// Token: 0x0400316F RID: 12655
		private static readonly List<InputDeviceManager> deviceManagers;

		// Token: 0x04003170 RID: 12656
		private static readonly Dictionary<Type, InputDeviceManager> deviceManagerTable;

		// Token: 0x04003171 RID: 12657
		private static readonly List<InputDevice> devices;

		// Token: 0x04003172 RID: 12658
		private static InputDevice activeDevice;

		// Token: 0x04003173 RID: 12659
		private static readonly List<InputDevice> activeDevices;

		// Token: 0x04003174 RID: 12660
		private static readonly List<PlayerActionSet> playerActionSets;

		// Token: 0x04003175 RID: 12661
		public static ReadOnlyCollection<InputDevice> Devices;

		// Token: 0x04003176 RID: 12662
		public static ReadOnlyCollection<InputDevice> ActiveDevices;

		// Token: 0x0400317D RID: 12669
		private static bool applicationIsFocused;

		// Token: 0x0400317E RID: 12670
		private static float initialTime;

		// Token: 0x0400317F RID: 12671
		private static float currentTime;

		// Token: 0x04003180 RID: 12672
		private static float lastUpdateTime;

		// Token: 0x04003181 RID: 12673
		private static ulong currentTick;

		// Token: 0x04003182 RID: 12674
		private static VersionInfo? unityVersion;

		// Token: 0x04003183 RID: 12675
		private static bool enabled;
	}
}
