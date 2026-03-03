using System;
using UnityEngine;

// Token: 0x020003D9 RID: 985
public class MaskByYPos : MonoBehaviour
{
	// Token: 0x0600168B RID: 5771 RVA: 0x0006AE16 File Offset: 0x00069016
	private void OnEnable()
	{
		if (this.spriteRenderer == null)
		{
			this.spriteRenderer = base.GetComponent<SpriteRenderer>();
		}
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x0006AE34 File Offset: 0x00069034
	private void Update()
	{
		float y = base.transform.position.y;
		if (this.maskIfAboveY)
		{
			if (y < this.yPos)
			{
				if (!this.spriteRenderer.enabled)
				{
					this.spriteRenderer.enabled = true;
				}
			}
			else if (this.spriteRenderer.enabled)
			{
				this.spriteRenderer.enabled = false;
			}
		}
		if (this.maskIfBelowY)
		{
			if (y > this.yPos)
			{
				if (!this.spriteRenderer.enabled)
				{
					this.spriteRenderer.enabled = true;
					return;
				}
			}
			else if (this.spriteRenderer.enabled)
			{
				this.spriteRenderer.enabled = false;
			}
		}
	}

	// Token: 0x04001B2B RID: 6955
	public SpriteRenderer spriteRenderer;

	// Token: 0x04001B2C RID: 6956
	public float yPos;

	// Token: 0x04001B2D RID: 6957
	public bool maskIfAboveY;

	// Token: 0x04001B2E RID: 6958
	public bool maskIfBelowY;
}
