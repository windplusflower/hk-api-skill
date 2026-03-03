using System;
using UnityEngine;

// Token: 0x0200038C RID: 908
public class PreInstantiateGameObject : MonoBehaviour
{
	// Token: 0x170002CE RID: 718
	// (get) Token: 0x06001515 RID: 5397 RVA: 0x000643C2 File Offset: 0x000625C2
	public GameObject InstantiatedGameObject
	{
		get
		{
			return this.instantiatedGameObject;
		}
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x000643CA File Offset: 0x000625CA
	private void Awake()
	{
		if (this.prefab)
		{
			this.instantiatedGameObject = UnityEngine.Object.Instantiate<GameObject>(this.prefab);
			this.instantiatedGameObject.SetActive(false);
		}
	}

	// Token: 0x0400192E RID: 6446
	public GameObject prefab;

	// Token: 0x0400192F RID: 6447
	private GameObject instantiatedGameObject;
}
