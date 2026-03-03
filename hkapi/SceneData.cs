using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200052B RID: 1323
[Serializable]
public class SceneData
{
	// Token: 0x1700038C RID: 908
	// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0008706F File Offset: 0x0008526F
	// (set) Token: 0x06001D00 RID: 7424 RVA: 0x00087087 File Offset: 0x00085287
	public static SceneData instance
	{
		get
		{
			if (SceneData._instance == null)
			{
				SceneData._instance = new SceneData();
			}
			return SceneData._instance;
		}
		set
		{
			SceneData._instance = value;
		}
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x0008708F File Offset: 0x0008528F
	protected SceneData()
	{
		this.SetupNewSceneData();
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x0008709D File Offset: 0x0008529D
	public void Reset()
	{
		this.SetupNewSceneData();
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x000870A8 File Offset: 0x000852A8
	public void SaveMyState(GeoRockData geoRockData)
	{
		int num = this.FindGeoRockInList(geoRockData);
		if (num == -1)
		{
			this.geoRocks.Add(geoRockData);
			return;
		}
		this.geoRocks[num] = geoRockData;
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x000870DC File Offset: 0x000852DC
	public void SaveMyState(PersistentBoolData persistentBoolData)
	{
		int num = this.FindPersistentBoolItemInList(persistentBoolData);
		if (num == -1)
		{
			this.persistentBoolItems.Add(persistentBoolData);
			return;
		}
		this.persistentBoolItems[num] = persistentBoolData;
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x00087110 File Offset: 0x00085310
	public void SaveMyState(PersistentIntData persistentIntData)
	{
		int num = this.FindPersistentIntItemInList(persistentIntData);
		if (num == -1)
		{
			this.persistentIntItems.Add(persistentIntData);
			return;
		}
		this.persistentIntItems[num] = persistentIntData;
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x00087144 File Offset: 0x00085344
	public void ResetSemiPersistentItems()
	{
		for (int i = 0; i < this.persistentBoolItems.Count; i++)
		{
			if (this.persistentBoolItems[i].semiPersistent)
			{
				this.persistentBoolItems[i].activated = false;
			}
		}
		for (int j = 0; j < this.persistentIntItems.Count; j++)
		{
			if (this.persistentIntItems[j].semiPersistent)
			{
				this.persistentIntItems[j].value = -1;
			}
		}
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x000871C8 File Offset: 0x000853C8
	public GeoRockData FindMyState(GeoRockData grd)
	{
		int num = this.FindGeoRockInList(grd);
		if (num == -1)
		{
			return null;
		}
		return this.geoRocks[num];
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x000871F0 File Offset: 0x000853F0
	public PersistentBoolData FindMyState(PersistentBoolData persistentBoolData)
	{
		int num = this.FindPersistentBoolItemInList(persistentBoolData);
		if (num == -1)
		{
			return null;
		}
		return this.persistentBoolItems[num];
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x00087218 File Offset: 0x00085418
	public PersistentIntData FindMyState(PersistentIntData persistentIntData)
	{
		int num = this.FindPersistentIntItemInList(persistentIntData);
		if (num == -1)
		{
			return null;
		}
		return this.persistentIntItems[num];
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x0008723F File Offset: 0x0008543F
	private void SetupNewSceneData()
	{
		this.geoRocks = new List<GeoRockData>();
		this.persistentBoolItems = new List<PersistentBoolData>();
		this.persistentIntItems = new List<PersistentIntData>();
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00087264 File Offset: 0x00085464
	private int FindGeoRockInList(GeoRockData grd)
	{
		for (int i = 0; i < this.geoRocks.Count; i++)
		{
			if (string.Compare(this.geoRocks[i].sceneName, grd.sceneName, true) == 0 && this.geoRocks[i].id == grd.id)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x000872C8 File Offset: 0x000854C8
	private int FindPersistentBoolItemInList(PersistentBoolData pbd)
	{
		for (int i = 0; i < this.persistentBoolItems.Count; i++)
		{
			if (string.Compare(this.persistentBoolItems[i].sceneName, pbd.sceneName, true) == 0 && this.persistentBoolItems[i].id == pbd.id)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x0008732C File Offset: 0x0008552C
	private int FindPersistentIntItemInList(PersistentIntData pid)
	{
		for (int i = 0; i < this.persistentIntItems.Count; i++)
		{
			if (string.Compare(this.persistentIntItems[i].sceneName, pid.sceneName, true) == 0 && this.persistentIntItems[i].id == pid.id)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x04002275 RID: 8821
	[SerializeField]
	public List<GeoRockData> geoRocks;

	// Token: 0x04002276 RID: 8822
	[SerializeField]
	public List<PersistentBoolData> persistentBoolItems;

	// Token: 0x04002277 RID: 8823
	[SerializeField]
	public List<PersistentIntData> persistentIntItems;

	// Token: 0x04002278 RID: 8824
	private static SceneData _instance;
}
