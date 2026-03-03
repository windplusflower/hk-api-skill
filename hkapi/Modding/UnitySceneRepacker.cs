using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Modding
{
	// Token: 0x02000DA1 RID: 3489
	internal static class UnitySceneRepacker
	{
		// Token: 0x06004878 RID: 18552 RVA: 0x00188F30 File Offset: 0x00187130
		public static ValueTuple<byte[], RepackStats> Repack(string bundleName, string gamePath, string preloadsJson, UnitySceneRepacker.Mode mode)
		{
			byte[] embeddedTypetreeDump = UnitySceneRepacker.GetEmbeddedTypetreeDump();
			IntPtr intPtr;
			int size;
			IntPtr ptr;
			RepackStats item;
			UnitySceneRepacker.export(bundleName, gamePath, preloadsJson, out intPtr, out size, out ptr, out item, embeddedTypetreeDump, embeddedTypetreeDump.Length, (byte)mode);
			if (intPtr != IntPtr.Zero)
			{
				throw new UnitySceneRepackerException(UnitySceneRepacker.PtrToStringAndFree(intPtr));
			}
			return new ValueTuple<byte[], RepackStats>(UnitySceneRepacker.PtrToByteArrayAndFree(size, ptr), item);
		}

		// Token: 0x06004879 RID: 18553
		[DllImport("unityscenerepacker", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		private static extern void export([MarshalAs(UnmanagedType.LPUTF8Str)] string bundleName, [MarshalAs(UnmanagedType.LPUTF8Str)] string gameDir, [MarshalAs(UnmanagedType.LPUTF8Str)] string preloadJson, out IntPtr error, out int bundleSize, out IntPtr bundleData, out RepackStats repackStats, byte[] monobehaviourTypetreeExport, int monobehaviourTypetreeExportLen, byte mode);

		// Token: 0x0600487A RID: 18554
		[DllImport("unityscenerepacker", CallingConvention = CallingConvention.Cdecl)]
		private static extern void free_str(IntPtr str);

		// Token: 0x0600487B RID: 18555
		[DllImport("unityscenerepacker", CallingConvention = CallingConvention.Cdecl)]
		private static extern void free_array(int len, IntPtr data);

		// Token: 0x0600487C RID: 18556 RVA: 0x00188F80 File Offset: 0x00187180
		private static string PtrToStringAndFree(IntPtr ptr)
		{
			if (ptr == IntPtr.Zero)
			{
				return null;
			}
			string result = Marshal.PtrToStringAnsi(ptr);
			UnitySceneRepacker.free_str(ptr);
			return result;
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00188FA0 File Offset: 0x001871A0
		private static byte[] PtrToByteArrayAndFree(int size, IntPtr ptr)
		{
			if (ptr == IntPtr.Zero || size == 0)
			{
				return new byte[0];
			}
			byte[] array = new byte[size];
			Marshal.Copy(ptr, array, 0, size);
			UnitySceneRepacker.free_array(size, ptr);
			return array;
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00188FDC File Offset: 0x001871DC
		private static byte[] GetEmbeddedTypetreeDump()
		{
			byte[] result;
			using (Stream manifestResourceStream = typeof(UnitySceneRepacker).Assembly.GetManifestResourceStream("Modding.monobehaviour-typetree-dump.lz4"))
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					manifestResourceStream.CopyTo(memoryStream);
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x02000DA2 RID: 3490
		public enum Mode
		{
			// Token: 0x04004C93 RID: 19603
			SceneBundle,
			// Token: 0x04004C94 RID: 19604
			AssetBundle
		}
	}
}
