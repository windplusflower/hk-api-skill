using System;
using UnityEngine;

// Token: 0x02000411 RID: 1041
public class AutoZSorter : MonoBehaviour
{
	// Token: 0x0600178D RID: 6029 RVA: 0x0006F3ED File Offset: 0x0006D5ED
	public AutoZSorter()
	{
		this.amountToSpace = 0.5f;
		base..ctor();
	}

	// Token: 0x04001C4E RID: 7246
	public GameObject prefabToSort;

	// Token: 0x04001C4F RID: 7247
	public float amountToSpace;
}
