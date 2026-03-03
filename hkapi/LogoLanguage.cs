using System;
using Language;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000010 RID: 16
public class LogoLanguage : MonoBehaviour
{
	// Token: 0x0600004B RID: 75 RVA: 0x00003716 File Offset: 0x00001916
	private void OnEnable()
	{
		this.SetSprite();
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00003720 File Offset: 0x00001920
	public void SetSprite()
	{
		if (Language.CurrentLanguage().ToString() == "ZH")
		{
			if (this.spriteRenderer)
			{
				this.spriteRenderer.sprite = this.chineseSprite;
			}
			if (this.uiImage)
			{
				this.uiImage.sprite = this.chineseSprite;
			}
		}
		else
		{
			if (this.spriteRenderer)
			{
				this.spriteRenderer.sprite = this.englishSprite;
			}
			if (this.uiImage)
			{
				this.uiImage.sprite = this.englishSprite;
			}
		}
		if (this.uiImage && this.setNativeSize)
		{
			this.uiImage.SetNativeSize();
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000037E6 File Offset: 0x000019E6
	public LogoLanguage()
	{
		this.setNativeSize = true;
		base..ctor();
	}

	// Token: 0x04000034 RID: 52
	public SpriteRenderer spriteRenderer;

	// Token: 0x04000035 RID: 53
	[Space]
	public Image uiImage;

	// Token: 0x04000036 RID: 54
	public bool setNativeSize;

	// Token: 0x04000037 RID: 55
	[Space]
	public Sprite englishSprite;

	// Token: 0x04000038 RID: 56
	public Sprite chineseSprite;
}
