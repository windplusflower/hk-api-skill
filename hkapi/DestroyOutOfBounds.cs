using System;
using UnityEngine;

// Token: 0x02000179 RID: 377
public class DestroyOutOfBounds : MonoBehaviour
{
	// Token: 0x060008A2 RID: 2210 RVA: 0x0002F4BF File Offset: 0x0002D6BF
	private void Update()
	{
		if (base.transform.position.y < -1f)
		{
			base.gameObject.SetActive(false);
		}
	}
}
