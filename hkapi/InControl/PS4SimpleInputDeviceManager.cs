using System;
using System.Collections.Generic;

namespace InControl
{
	// Token: 0x02000707 RID: 1799
	public class PS4SimpleInputDeviceManager : InputDeviceManager
	{
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000EFC25 File Offset: 0x000EDE25
		public PS4SimpleInputDevice Device
		{
			get
			{
				return this.device;
			}
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000EFC2D File Offset: 0x000EDE2D
		public PS4SimpleInputDeviceManager()
		{
			this.device = new PS4SimpleInputDevice();
			this.devices.Add(this.device);
			this.Update(0UL, 0f);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x000EFC5E File Offset: 0x000EDE5E
		public override void Update(ulong updateTick, float deltaTime)
		{
			if (!this.isDeviceAttached)
			{
				InputManager.AttachDevice(this.device);
				this.isDeviceAttached = true;
			}
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0000D742 File Offset: 0x0000B942
		public static bool CheckPlatformSupport(ICollection<string> errors)
		{
			return false;
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x000EFC7C File Offset: 0x000EDE7C
		internal static bool Enable()
		{
			List<string> list = new List<string>();
			try
			{
				if (!PS4SimpleInputDeviceManager.CheckPlatformSupport(list))
				{
					return false;
				}
				InputManager.AddDeviceManager<PS4SimpleInputDeviceManager>();
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

		// Token: 0x040031C8 RID: 12744
		private PS4SimpleInputDevice device;

		// Token: 0x040031C9 RID: 12745
		private bool isDeviceAttached;
	}
}
