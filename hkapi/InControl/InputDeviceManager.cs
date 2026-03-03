using System;
using System.Collections.Generic;

namespace InControl
{
	// Token: 0x020006EA RID: 1770
	public abstract class InputDeviceManager
	{
		// Token: 0x06002B11 RID: 11025
		public abstract void Update(ulong updateTick, float deltaTime);

		// Token: 0x06002B12 RID: 11026 RVA: 0x00003603 File Offset: 0x00001803
		public virtual void Destroy()
		{
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000EAD4D File Offset: 0x000E8F4D
		protected InputDeviceManager()
		{
			this.devices = new List<InputDevice>();
			base..ctor();
		}

		// Token: 0x04003109 RID: 12553
		protected readonly List<InputDevice> devices;
	}
}
