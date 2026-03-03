using System;
using UnityEngine;

// Token: 0x020005BD RID: 1469
public static class tk2dUITime
{
	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x0600216F RID: 8559 RVA: 0x000A888B File Offset: 0x000A6A8B
	public static float deltaTime
	{
		get
		{
			return tk2dUITime._deltaTime;
		}
	}

	// Token: 0x06002170 RID: 8560 RVA: 0x000A8892 File Offset: 0x000A6A92
	public static void Init()
	{
		tk2dUITime.lastRealTime = (double)Time.realtimeSinceStartup;
		tk2dUITime._deltaTime = Time.maximumDeltaTime;
	}

	// Token: 0x06002171 RID: 8561 RVA: 0x000A88AC File Offset: 0x000A6AAC
	public static void Update()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		if (Time.timeScale < 0.001f)
		{
			tk2dUITime._deltaTime = Mathf.Min(0.06666667f, (float)((double)realtimeSinceStartup - tk2dUITime.lastRealTime));
		}
		else
		{
			tk2dUITime._deltaTime = Time.deltaTime / Time.timeScale;
		}
		tk2dUITime.lastRealTime = (double)realtimeSinceStartup;
	}

	// Token: 0x06002172 RID: 8562 RVA: 0x000A88FC File Offset: 0x000A6AFC
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dUITime()
	{
		tk2dUITime.lastRealTime = 0.0;
		tk2dUITime._deltaTime = 0.016666668f;
	}

	// Token: 0x040026DC RID: 9948
	private static double lastRealTime;

	// Token: 0x040026DD RID: 9949
	private static float _deltaTime;
}
