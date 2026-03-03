using System;
using UnityEngine;

// Token: 0x02000418 RID: 1048
public class ParallaxSorter : MonoBehaviour
{
	// Token: 0x060017B4 RID: 6068 RVA: 0x0006FEEB File Offset: 0x0006E0EB
	private void Awake()
	{
		this.stripSortingLayers = true;
	}

	// Token: 0x04001C74 RID: 7284
	public string[] sortingLayers;

	// Token: 0x04001C75 RID: 7285
	public int[] sortingLayerIDs;

	// Token: 0x04001C76 RID: 7286
	public float[] layerDepths;

	// Token: 0x04001C77 RID: 7287
	public bool stripSortingLayers;
}
