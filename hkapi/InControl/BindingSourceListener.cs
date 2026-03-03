using System;

namespace InControl
{
	// Token: 0x020006BE RID: 1726
	public interface BindingSourceListener
	{
		// Token: 0x060028DC RID: 10460
		void Reset();

		// Token: 0x060028DD RID: 10461
		BindingSource Listen(BindingListenOptions listenOptions, InputDevice device);
	}
}
