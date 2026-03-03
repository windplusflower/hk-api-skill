using System;

namespace TMPro
{
	// Token: 0x0200062B RID: 1579
	public static class TMP_Math
	{
		// Token: 0x06002619 RID: 9753 RVA: 0x000C8412 File Offset: 0x000C6612
		public static bool Approximately(float a, float b)
		{
			return b - 0.0001f < a && a < b + 0.0001f;
		}

		// Token: 0x04002A0A RID: 10762
		public const float FLOAT_MAX = 32768f;

		// Token: 0x04002A0B RID: 10763
		public const float FLOAT_MIN = -32768f;

		// Token: 0x04002A0C RID: 10764
		public const int INT_MAX = 2147483647;

		// Token: 0x04002A0D RID: 10765
		public const int INT_MIN = -2147483647;
	}
}
