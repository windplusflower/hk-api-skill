using System;
using System.Collections.Generic;

namespace TMPro
{
	// Token: 0x020005FC RID: 1532
	internal static class TMP_ListPool<T>
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x000BA01D File Offset: 0x000B821D
		public static List<T> Get()
		{
			return TMP_ListPool<T>.s_ListPool.Get();
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000BA029 File Offset: 0x000B8229
		public static void Release(List<T> toRelease)
		{
			TMP_ListPool<T>.s_ListPool.Release(toRelease);
		}

		// Token: 0x04002857 RID: 10327
		private static readonly TMP_ObjectPool<List<T>> s_ListPool = new TMP_ObjectPool<List<T>>(null, delegate(List<T> l)
		{
			l.Clear();
		});
	}
}
