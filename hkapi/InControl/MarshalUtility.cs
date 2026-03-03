using System;
using System.Runtime.InteropServices;

namespace InControl
{
	// Token: 0x02000726 RID: 1830
	public static class MarshalUtility
	{
		// Token: 0x06002D69 RID: 11625 RVA: 0x000F42DF File Offset: 0x000F24DF
		public static void Copy(IntPtr source, uint[] destination, int length)
		{
			Utility.ArrayExpand<int>(ref MarshalUtility.buffer, length);
			Marshal.Copy(source, MarshalUtility.buffer, 0, length);
			Buffer.BlockCopy(MarshalUtility.buffer, 0, destination, 0, 4 * length);
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000F4309 File Offset: 0x000F2509
		// Note: this type is marked as 'beforefieldinit'.
		static MarshalUtility()
		{
			MarshalUtility.buffer = new int[32];
		}

		// Token: 0x040032C3 RID: 12995
		private static int[] buffer;
	}
}
