using System;

namespace TMPro
{
	// Token: 0x020005DA RID: 1498
	internal interface ITweenValue
	{
		// Token: 0x060022F0 RID: 8944
		void TweenValue(float floatPercentage);

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060022F1 RID: 8945
		bool ignoreTimeScale { get; }

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060022F2 RID: 8946
		float duration { get; }

		// Token: 0x060022F3 RID: 8947
		bool ValidTarget();
	}
}
