using System;

namespace InControl
{
	// Token: 0x020006D6 RID: 1750
	public interface IInputControl
	{
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x060029E8 RID: 10728
		bool HasChanged { get; }

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x060029E9 RID: 10729
		bool IsPressed { get; }

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060029EA RID: 10730
		bool WasPressed { get; }

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060029EB RID: 10731
		bool WasReleased { get; }

		// Token: 0x060029EC RID: 10732
		void ClearInputState();
	}
}
