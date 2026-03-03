using System;
using UnityEngine;

// Token: 0x020004A6 RID: 1190
public class MeshSortingOrder : MonoBehaviour
{
	// Token: 0x06001A79 RID: 6777 RVA: 0x0007F17B File Offset: 0x0007D37B
	private void Awake()
	{
		this.rend = base.GetComponent<MeshRenderer>();
		this.rend.sortingLayerName = this.layerName;
		this.rend.sortingOrder = this.order;
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x0007F1AC File Offset: 0x0007D3AC
	public void Update()
	{
		if (this.rend.sortingLayerName != this.layerName)
		{
			this.rend.sortingLayerName = this.layerName;
		}
		if (this.rend.sortingOrder != this.order)
		{
			this.rend.sortingOrder = this.order;
		}
	}

	// Token: 0x06001A7B RID: 6779 RVA: 0x0007F17B File Offset: 0x0007D37B
	public void OnValidate()
	{
		this.rend = base.GetComponent<MeshRenderer>();
		this.rend.sortingLayerName = this.layerName;
		this.rend.sortingOrder = this.order;
	}

	// Token: 0x04001FE0 RID: 8160
	public string layerName;

	// Token: 0x04001FE1 RID: 8161
	public int order;

	// Token: 0x04001FE2 RID: 8162
	private MeshRenderer rend;
}
