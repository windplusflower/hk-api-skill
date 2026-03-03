using System;
using UnityEngine;

// Token: 0x02000122 RID: 290
public class ActivateChildrenOnContact : MonoBehaviour
{
	// Token: 0x060006BB RID: 1723 RVA: 0x00027300 File Offset: 0x00025500
	private void OnTriggerEnter2D(Collider2D collision)
	{
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(true);
		}
		if (this.circleCollider != null)
		{
			this.circleCollider.enabled = false;
		}
		if (this.boxCollider != null)
		{
			this.boxCollider.enabled = false;
		}
	}

	// Token: 0x04000757 RID: 1879
	public CircleCollider2D circleCollider;

	// Token: 0x04000758 RID: 1880
	public BoxCollider2D boxCollider;
}
