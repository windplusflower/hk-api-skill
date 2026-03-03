using System;
using UnityEngine;

// Token: 0x02000205 RID: 517
public class PersonalObjectPool : MonoBehaviour
{
	// Token: 0x06000B40 RID: 2880 RVA: 0x0003BB9C File Offset: 0x00039D9C
	private void Start()
	{
		this.CreateStartupPools();
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x0003BBA4 File Offset: 0x00039DA4
	private void OnEnable()
	{
		this.gm = GameManager.instance;
		this.gm.DestroyPersonalPools += this.DestroyMyPooledObjects;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0003BBC8 File Offset: 0x00039DC8
	public void CreateStartupPools()
	{
		if (this.createdStartupPools)
		{
			return;
		}
		this.createdStartupPools = true;
		if (this.startupPool != null && this.startupPool.Length != 0)
		{
			for (int i = 0; i < this.startupPool.Length; i++)
			{
				this.CreatePool(this.startupPool[i].prefab, this.startupPool[i].size);
			}
		}
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0003BC31 File Offset: 0x00039E31
	public void CreatePool(GameObject prefab, int initialPoolSize)
	{
		ObjectPool.CreatePool(prefab, initialPoolSize);
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0003BC3C File Offset: 0x00039E3C
	public void DestroyMyPooledObjects()
	{
		if (this.startupPool != null && this.startupPool.Length != 0)
		{
			for (int i = 0; i < this.startupPool.Length; i++)
			{
				ObjectPool.DestroyPooled(this.startupPool[i].prefab, this.startupPool[i].size);
			}
		}
		this.gm.DestroyPersonalPools -= this.DestroyMyPooledObjects;
	}

	// Token: 0x04000C44 RID: 3140
	public StartupPool[] startupPool;

	// Token: 0x04000C45 RID: 3141
	private GameManager gm;

	// Token: 0x04000C46 RID: 3142
	private bool createdStartupPools;
}
