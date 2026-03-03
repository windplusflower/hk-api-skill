using System;
using UnityEngine;

// Token: 0x02000206 RID: 518
[Serializable]
public struct StartupPool
{
	// Token: 0x06000B46 RID: 2886 RVA: 0x0003BCAB File Offset: 0x00039EAB
	public StartupPool(int size, GameObject prefab)
	{
		this.size = size;
		this.prefab = prefab;
	}

	// Token: 0x04000C47 RID: 3143
	public int size;

	// Token: 0x04000C48 RID: 3144
	public GameObject prefab;
}
