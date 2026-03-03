using System;
using UnityEngine;

// Token: 0x02000387 RID: 903
public static class TimeController
{
	// Token: 0x170002C8 RID: 712
	// (get) Token: 0x060014BD RID: 5309 RVA: 0x0005A98C File Offset: 0x00058B8C
	// (set) Token: 0x060014BE RID: 5310 RVA: 0x0005A993 File Offset: 0x00058B93
	public static float SlowMotionTimeScale
	{
		get
		{
			return TimeController.slowMotionTimeScale;
		}
		set
		{
			TimeController.SetTimeScaleFactor(ref TimeController.slowMotionTimeScale, value);
		}
	}

	// Token: 0x170002C9 RID: 713
	// (get) Token: 0x060014BF RID: 5311 RVA: 0x0005A9A0 File Offset: 0x00058BA0
	// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0005A9A7 File Offset: 0x00058BA7
	public static float PauseTimeScale
	{
		get
		{
			return TimeController.pauseTimeScale;
		}
		set
		{
			TimeController.SetTimeScaleFactor(ref TimeController.pauseTimeScale, value);
		}
	}

	// Token: 0x170002CA RID: 714
	// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0005A9B4 File Offset: 0x00058BB4
	// (set) Token: 0x060014C2 RID: 5314 RVA: 0x0005A9BB File Offset: 0x00058BBB
	public static float PlatformBackgroundTimeScale
	{
		get
		{
			return TimeController.platformBackgroundTimeScale;
		}
		set
		{
			TimeController.SetTimeScaleFactor(ref TimeController.platformBackgroundTimeScale, value);
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0005A9C8 File Offset: 0x00058BC8
	// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0005A9CF File Offset: 0x00058BCF
	public static float GenericTimeScale
	{
		get
		{
			return TimeController.genericTimeScale;
		}
		set
		{
			TimeController.SetTimeScaleFactor(ref TimeController.genericTimeScale, value);
		}
	}

	// Token: 0x060014C5 RID: 5317 RVA: 0x0005A9DC File Offset: 0x00058BDC
	static TimeController()
	{
		TimeController.slowMotionTimeScale = 1f;
		TimeController.pauseTimeScale = 1f;
		TimeController.platformBackgroundTimeScale = 1f;
		TimeController.genericTimeScale = 1f;
	}

	// Token: 0x060014C6 RID: 5318 RVA: 0x0005AA08 File Offset: 0x00058C08
	private static void SetTimeScaleFactor(ref float field, float val)
	{
		if (field != val)
		{
			field = val;
			float num = TimeController.slowMotionTimeScale * TimeController.pauseTimeScale * TimeController.platformBackgroundTimeScale * TimeController.genericTimeScale;
			if (num < 0.01f)
			{
				num = 0f;
			}
			Time.timeScale = num;
		}
	}

	// Token: 0x0400131F RID: 4895
	private static float slowMotionTimeScale;

	// Token: 0x04001320 RID: 4896
	private static float pauseTimeScale;

	// Token: 0x04001321 RID: 4897
	private static float platformBackgroundTimeScale;

	// Token: 0x04001322 RID: 4898
	private static float genericTimeScale;
}
