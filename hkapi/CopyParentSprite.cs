using System;
using UnityEngine;

// Token: 0x0200044C RID: 1100
public class CopyParentSprite : MonoBehaviour
{
	// Token: 0x060018B0 RID: 6320 RVA: 0x00073B15 File Offset: 0x00071D15
	private void Start()
	{
		base.GetComponent<SpriteRenderer>().sprite = base.transform.parent.gameObject.GetComponent<SpriteRenderer>().sprite;
	}
}
