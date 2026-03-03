using System;
using UnityEngine;

// Token: 0x020004CD RID: 1229
[RequireComponent(typeof(CanvasGroup))]
public class ZeroAlphaOnStart : MonoBehaviour
{
	// Token: 0x06001B49 RID: 6985 RVA: 0x0008314D File Offset: 0x0008134D
	private void Start()
	{
		base.GetComponent<CanvasGroup>().alpha = 0f;
	}
}
