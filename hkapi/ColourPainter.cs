using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200012B RID: 299
public class ColourPainter : MonoBehaviour
{
	// Token: 0x060006F0 RID: 1776 RVA: 0x00027EF1 File Offset: 0x000260F1
	private void Awake()
	{
		this.boxCollider = base.GetComponent<BoxCollider2D>();
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00027F00 File Offset: 0x00026100
	private void Update()
	{
		if (this.active)
		{
			if (this.timer < this.delay)
			{
				this.timer += Time.deltaTime;
				return;
			}
			foreach (SpriteRenderer spriteRenderer in this.splatList)
			{
				spriteRenderer.color = this.colour;
			}
			this.boxCollider.enabled = false;
			this.active = false;
		}
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00027F94 File Offset: 0x00026194
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Extra Tag")
		{
			this.splatList.Add(collision.gameObject.GetComponent<SpriteRenderer>());
		}
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00027FBE File Offset: 0x000261BE
	public void DoPaint()
	{
		this.splatList.Clear();
		this.timer = 0f;
		this.active = true;
		this.boxCollider.enabled = true;
	}

	// Token: 0x0400078A RID: 1930
	public Color colour;

	// Token: 0x0400078B RID: 1931
	public int chance;

	// Token: 0x0400078C RID: 1932
	public float delay;

	// Token: 0x0400078D RID: 1933
	public List<SpriteRenderer> splatList;

	// Token: 0x0400078E RID: 1934
	private BoxCollider2D boxCollider;

	// Token: 0x0400078F RID: 1935
	private float timer;

	// Token: 0x04000790 RID: 1936
	private bool active;

	// Token: 0x04000791 RID: 1937
	private bool painted;
}
