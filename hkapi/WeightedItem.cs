using System;
using UnityEngine;

// Token: 0x020004EC RID: 1260
public class WeightedItem
{
	// Token: 0x1700035B RID: 859
	// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x000847BD File Offset: 0x000829BD
	public float Weight
	{
		get
		{
			return this.weight;
		}
	}

	// Token: 0x040021C3 RID: 8643
	[SerializeField]
	[Range(0.001f, 10f)]
	private float weight;
}
