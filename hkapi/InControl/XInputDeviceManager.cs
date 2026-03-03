using System;
using System.Collections.Generic;
using System.Threading;
using InControl.Internal;
using InControl.UnityDeviceProfiles;
using UnityEngine;
using XInputDotNetPure;

namespace InControl
{
	// Token: 0x02000737 RID: 1847
	public class XInputDeviceManager : InputDeviceManager
	{
		// Token: 0x06002E62 RID: 11874 RVA: 0x000F64F0 File Offset: 0x000F46F0
		public XInputDeviceManager()
		{
			this.deviceConnected = new bool[4];
			this.gamePadState = new RingBuffer<GamePadState>[4];
			base..ctor();
			if (InputManager.XInputUpdateRate == 0U)
			{
				this.timeStep = Mathf.FloorToInt(Time.fixedDeltaTime * 1000f);
			}
			else
			{
				this.timeStep = Mathf.FloorToInt(1f / InputManager.XInputUpdateRate * 1000f);
			}
			this.bufferSize = (int)Math.Max(InputManager.XInputBufferSize, 1U);
			for (int i = 0; i < 4; i++)
			{
				this.gamePadState[i] = new RingBuffer<GamePadState>(this.bufferSize);
			}
			this.StartWorker();
			for (int j = 0; j < 4; j++)
			{
				this.devices.Add(new XInputDevice(j, this));
			}
			this.Update(0UL, 0f);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000F65B9 File Offset: 0x000F47B9
		private void StartWorker()
		{
			if (this.thread == null)
			{
				this.thread = new Thread(new ThreadStart(this.Worker));
				this.thread.IsBackground = true;
				this.thread.Start();
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000F65F1 File Offset: 0x000F47F1
		private void StopWorker()
		{
			if (this.thread != null)
			{
				this.thread.Abort();
				this.thread.Join();
				this.thread = null;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x000F6618 File Offset: 0x000F4818
		private void Worker()
		{
			for (;;)
			{
				for (int i = 0; i < 4; i++)
				{
					this.gamePadState[i].Enqueue(GamePad.GetState((PlayerIndex)i));
				}
				Thread.Sleep(this.timeStep);
			}
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x000F6650 File Offset: 0x000F4850
		internal GamePadState GetState(int deviceIndex)
		{
			return this.gamePadState[deviceIndex].Dequeue();
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x000F6660 File Offset: 0x000F4860
		public override void Update(ulong updateTick, float deltaTime)
		{
			for (int i = 0; i < 4; i++)
			{
				XInputDevice xinputDevice = this.devices[i] as XInputDevice;
				if (!xinputDevice.IsConnected)
				{
					xinputDevice.GetState();
				}
				if (xinputDevice.IsConnected != this.deviceConnected[i])
				{
					if (xinputDevice.IsConnected)
					{
						InputManager.AttachDevice(xinputDevice);
					}
					else
					{
						InputManager.DetachDevice(xinputDevice);
					}
					this.deviceConnected[i] = xinputDevice.IsConnected;
				}
			}
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x000F66CD File Offset: 0x000F48CD
		public override void Destroy()
		{
			this.StopWorker();
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x000F66D8 File Offset: 0x000F48D8
		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			if (Application.platform != RuntimePlatform.WindowsPlayer && Application.platform != RuntimePlatform.WindowsEditor)
			{
				return false;
			}
			try
			{
				GamePad.GetState(PlayerIndex.One);
			}
			catch (DllNotFoundException ex)
			{
				if (errors != null)
				{
					errors.Add(ex.Message + ".dll could not be found or is missing a dependency.");
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x000F6734 File Offset: 0x000F4934
		internal static void Enable()
		{
			List<string> list = new List<string>();
			if (XInputDeviceManager.CheckPlatformSupport(list))
			{
				InputManager.HideDevicesWithProfile(typeof(Xbox360WindowsUnityProfile));
				InputManager.HideDevicesWithProfile(typeof(XboxOneWindowsUnityProfile));
				InputManager.HideDevicesWithProfile(typeof(XboxOneWindows10UnityProfile));
				InputManager.HideDevicesWithProfile(typeof(XboxOneWindows10AEUnityProfile));
				InputManager.HideDevicesWithProfile(typeof(LogitechF310ModeXWindowsUnityProfile));
				InputManager.HideDevicesWithProfile(typeof(LogitechF510ModeXWindowsUnityProfile));
				InputManager.HideDevicesWithProfile(typeof(LogitechF710ModeXWindowsUnityProfile));
				InputManager.AddDeviceManager<XInputDeviceManager>();
				return;
			}
			foreach (string text in list)
			{
				Logger.LogError(text);
			}
		}

		// Token: 0x040032E9 RID: 13033
		private readonly bool[] deviceConnected;

		// Token: 0x040032EA RID: 13034
		private const int maxDevices = 4;

		// Token: 0x040032EB RID: 13035
		private readonly RingBuffer<GamePadState>[] gamePadState;

		// Token: 0x040032EC RID: 13036
		private Thread thread;

		// Token: 0x040032ED RID: 13037
		private readonly int timeStep;

		// Token: 0x040032EE RID: 13038
		private int bufferSize;
	}
}
