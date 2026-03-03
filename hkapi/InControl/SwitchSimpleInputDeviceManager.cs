using System;
using System.Collections.Generic;

namespace InControl
{
	// Token: 0x02000709 RID: 1801
	public class SwitchSimpleInputDeviceManager : InputDeviceManager
	{
		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x000EFEE7 File Offset: 0x000EE0E7
		public SwitchSimpleInputDevice Device
		{
			get
			{
				return this.device;
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000EFEEF File Offset: 0x000EE0EF
		public SwitchSimpleInputDeviceManager()
		{
			this.device = new SwitchSimpleInputDevice();
			this.devices.Add(this.device);
			this.Update(0UL, 0f);
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000EFF20 File Offset: 0x000EE120
		public override void Update(ulong updateTick, float deltaTime)
		{
			if (this.device.IsConnected != this.isDeviceAttached)
			{
				if (this.device.IsConnected)
				{
					InputManager.AttachDevice(this.device);
				}
				else
				{
					InputManager.DetachDevice(this.device);
				}
				this.isDeviceAttached = this.device.IsConnected;
			}
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0000D742 File Offset: 0x0000B942
		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			return false;
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x000EFF78 File Offset: 0x000EE178
		internal static bool Enable()
		{
			List<string> list = new List<string>();
			try
			{
				if (!SwitchSimpleInputDeviceManager.CheckPlatformSupport(list))
				{
					return false;
				}
				InputManager.AddDeviceManager<SwitchSimpleInputDeviceManager>();
			}
			finally
			{
				foreach (string text in list)
				{
					Logger.LogError(text);
				}
			}
			return true;
		}

		// Token: 0x040031CD RID: 12749
		private SwitchSimpleInputDevice device;

		// Token: 0x040031CE RID: 12750
		private bool isDeviceAttached;
	}
}
