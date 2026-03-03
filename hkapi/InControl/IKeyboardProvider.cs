using System;

namespace InControl
{
	// Token: 0x020006F6 RID: 1782
	public interface IKeyboardProvider
	{
		// Token: 0x06002BEC RID: 11244
		void Setup();

		// Token: 0x06002BED RID: 11245
		void Reset();

		// Token: 0x06002BEE RID: 11246
		void Update();

		// Token: 0x06002BEF RID: 11247
		bool AnyKeyIsPressed();

		// Token: 0x06002BF0 RID: 11248
		bool GetKeyIsPressed(Key control);

		// Token: 0x06002BF1 RID: 11249
		string GetNameForKey(Key control);
	}
}
