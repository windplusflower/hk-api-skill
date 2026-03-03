using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000137 RID: 311
public class GrassWind : MonoBehaviour
{
	// Token: 0x06000745 RID: 1861 RVA: 0x000299B5 File Offset: 0x00027BB5
	private void Awake()
	{
		this.col = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x000299C4 File Offset: 0x00027BC4
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Nail Attack")
		{
			GrassBehaviour componentInParent = base.GetComponentInParent<GrassBehaviour>();
			if (componentInParent)
			{
				base.StartCoroutine(this.DelayReact(componentInParent, collision));
			}
		}
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00029A01 File Offset: 0x00027C01
	private IEnumerator DelayReact(GrassBehaviour behaviour, Collider2D collision)
	{
		yield return null;
		behaviour.WindReact(collision);
		yield break;
	}

	// Token: 0x04000811 RID: 2065
	private Collider2D col;
}
