using System;
using UnityEngine;
using UnityEngine.Profiling;

// Token: 0x020004E3 RID: 1251
public class GCManager : MonoBehaviour
{
	// Token: 0x17000359 RID: 857
	// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0000D742 File Offset: 0x0000B942
	public static bool IsSupported
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0004E56C File Offset: 0x0004C76C
	// (set) Token: 0x06001BB6 RID: 7094 RVA: 0x00003603 File Offset: 0x00001803
	public static bool IsAutomaticCollectionEnabled
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	// Token: 0x06001BB7 RID: 7095 RVA: 0x00084227 File Offset: 0x00082427
	public static void Collect()
	{
		GCManager.framesSinceCollect = 0;
		GC.Collect();
	}

	// Token: 0x06001BB8 RID: 7096 RVA: 0x00084234 File Offset: 0x00082434
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		if (GCManager.IsSupported)
		{
			GameObject gameObject = new GameObject("GCManager", new Type[]
			{
				typeof(GCManager)
			});
			gameObject.hideFlags |= HideFlags.HideAndDontSave;
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	// Token: 0x06001BB9 RID: 7097 RVA: 0x0008426E File Offset: 0x0008246E
	public static long GetMemoryUsage()
	{
		return Profiler.GetTotalReservedMemoryLong() - Profiler.GetTotalUnusedReservedMemoryLong();
	}

	// Token: 0x06001BBA RID: 7098 RVA: 0x0008427B File Offset: 0x0008247B
	protected void Update()
	{
		GCManager.framesSinceCollect++;
		if (GCManager.framesSinceCollect >= 108000)
		{
			GCManager.Collect();
		}
		if (GCManager.IsSupported)
		{
			GCManager.IsAutomaticCollectionEnabled = (GCManager.GetMemoryUsage() > (long)((ulong)-1358954496));
		}
	}

	// Token: 0x040021B5 RID: 8629
	private const long GCPanicLimit = 2936012800L;

	// Token: 0x040021B6 RID: 8630
	private const int GCPanicFrameLimit = 108000;

	// Token: 0x040021B7 RID: 8631
	private static int framesSinceCollect;
}
