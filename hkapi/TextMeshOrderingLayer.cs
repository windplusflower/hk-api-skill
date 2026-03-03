using System;
using UnityEngine;

// Token: 0x02000410 RID: 1040
public class TextMeshOrderingLayer : MonoBehaviour
{
	// Token: 0x0600178B RID: 6027 RVA: 0x0006F3A0 File Offset: 0x0006D5A0
	private void Start()
	{
		base.GetComponent<MeshRenderer>().sortingLayerID = base.transform.parent.GetComponent<SpriteRenderer>().sortingLayerID;
		base.GetComponent<MeshRenderer>().sortingOrder = base.transform.parent.GetComponent<SpriteRenderer>().sortingOrder;
	}
}
