using System;
using UnityEngine;

// Token: 0x020004CF RID: 1231
public class AssetNamePickerAttribute : PropertyAttribute
{
	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06001B4D RID: 6989 RVA: 0x0008315F File Offset: 0x0008135F
	public string SearchFilter
	{
		get
		{
			return this.searchFilter;
		}
	}

	// Token: 0x06001B4E RID: 6990 RVA: 0x00083167 File Offset: 0x00081367
	public AssetNamePickerAttribute(string searchFilter)
	{
		this.searchFilter = searchFilter;
	}

	// Token: 0x040020C6 RID: 8390
	private readonly string searchFilter;
}
