using System;

namespace InControl
{
	// Token: 0x02000704 RID: 1796
	public class OuyaEverywhereDeviceManager : InputDeviceManager
	{
		// Token: 0x06002C57 RID: 11351 RVA: 0x000EF958 File Offset: 0x000EDB58
		public OuyaEverywhereDeviceManager()
		{
			this.deviceConnected = new bool[4];
			base..ctor();
			for (int i = 0; i < 4; i++)
			{
				this.devices.Add(new OuyaEverywhereDevice(i));
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000EF994 File Offset: 0x000EDB94
		public override void Update(ulong updateTick, float deltaTime)
		{
			for (int i = 0; i < 4; i++)
			{
				OuyaEverywhereDevice ouyaEverywhereDevice = this.devices[i] as OuyaEverywhereDevice;
				if (ouyaEverywhereDevice.IsConnected != this.deviceConnected[i])
				{
					if (ouyaEverywhereDevice.IsConnected)
					{
						ouyaEverywhereDevice.BeforeAttach();
						InputManager.AttachDevice(ouyaEverywhereDevice);
					}
					else
					{
						InputManager.DetachDevice(ouyaEverywhereDevice);
					}
					this.deviceConnected[i] = ouyaEverywhereDevice.IsConnected;
				}
			}
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00003603 File Offset: 0x00001803
		public static void Enable()
		{
		}

		// Token: 0x040031C0 RID: 12736
		private bool[] deviceConnected;
	}
}
