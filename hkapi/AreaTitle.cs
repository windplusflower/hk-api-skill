using System;
using UnityEngine;

// Token: 0x02000430 RID: 1072
public class AreaTitle : MonoBehaviour
{
	// Token: 0x06001828 RID: 6184 RVA: 0x000718EB File Offset: 0x0006FAEB
	private void Awake()
	{
		AreaTitle.instance = this;
		base.gameObject.SetActive(false);
	}

	// Token: 0x04001CF8 RID: 7416
	public static AreaTitle instance;
}
