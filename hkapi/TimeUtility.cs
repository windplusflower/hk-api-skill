using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000501 RID: 1281
public static class TimeUtility
{
	// Token: 0x06001C3D RID: 7229 RVA: 0x00085661 File Offset: 0x00083861
	public static IEnumerator Wait(float duration)
	{
		for (float timer = 0f; timer < duration; timer += Time.deltaTime)
		{
			yield return null;
		}
		yield break;
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x00085670 File Offset: 0x00083870
	public static IEnumerator WaitForRealSeconds(float time)
	{
		float start = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup < start + time)
		{
			yield return null;
		}
		yield break;
	}
}
