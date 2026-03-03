using System;
using UnityEngine;

// Token: 0x02000419 RID: 1049
[Serializable]
public class PrefabSwapper : MonoBehaviour
{
	// Token: 0x060017B6 RID: 6070 RVA: 0x0006FEF4 File Offset: 0x0006E0F4
	public bool contains(string testGo)
	{
		string[] array = this.ignoreList;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == testGo)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x0006FF24 File Offset: 0x0006E124
	public PrefabSwapper()
	{
		this.preserveZDepth = true;
		this.ignorePrefabs = true;
		base..ctor();
	}

	// Token: 0x04001C78 RID: 7288
	public GameObject objToSwapout;

	// Token: 0x04001C79 RID: 7289
	public string[] ignoreList;

	// Token: 0x04001C7A RID: 7290
	public bool preserveZDepth;

	// Token: 0x04001C7B RID: 7291
	public bool ignorePrefabs;
}
