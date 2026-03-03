using System;
using UnityEngine;

// Token: 0x020004E8 RID: 1256
public static class ObjectPoolAuditor
{
	// Token: 0x06001BD0 RID: 7120 RVA: 0x00003603 File Offset: 0x00001803
	public static void RecordPoolCreated(GameObject prefab, int initialPoolSize)
	{
	}

	// Token: 0x06001BD1 RID: 7121 RVA: 0x00003603 File Offset: 0x00001803
	public static void RecordSpawned(GameObject prefab, bool didInstantiate)
	{
	}

	// Token: 0x06001BD2 RID: 7122 RVA: 0x00003603 File Offset: 0x00001803
	public static void RecordDespawned(GameObject instanceOrPrefab, bool willReuse)
	{
	}
}
