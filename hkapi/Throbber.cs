using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004C1 RID: 1217
public class Throbber : MonoBehaviour
{
	// Token: 0x06001AFE RID: 6910 RVA: 0x00080C90 File Offset: 0x0007EE90
	protected void Update()
	{
		float num = Mathf.Min(0.016666668f, Time.unscaledDeltaTime);
		if (this.sprites.Length != 0)
		{
			this.frameTimer += num * this.frameRate;
			int num2 = (int)this.frameTimer;
			if (num2 > 0)
			{
				this.frameTimer -= (float)num2;
				this.frameIndex = (this.frameIndex + num2) % this.sprites.Length;
				this.image.sprite = this.sprites[this.frameIndex];
			}
		}
	}

	// Token: 0x04002057 RID: 8279
	[SerializeField]
	private Image image;

	// Token: 0x04002058 RID: 8280
	[SerializeField]
	private Sprite[] sprites;

	// Token: 0x04002059 RID: 8281
	[SerializeField]
	private float frameRate;

	// Token: 0x0400205A RID: 8282
	private float frameTimer;

	// Token: 0x0400205B RID: 8283
	private int frameIndex;
}
