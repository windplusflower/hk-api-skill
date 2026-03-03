using System;
using Language;
using UnityEngine;

// Token: 0x020002CD RID: 717
[RequireComponent(typeof(SpriteRenderer))]
public class LocaliseSprite : MonoBehaviour
{
	// Token: 0x06000F0B RID: 3851 RVA: 0x0004A0ED File Offset: 0x000482ED
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x0004A0FC File Offset: 0x000482FC
	private void Start()
	{
		LanguageCode languageCode = Language.CurrentLanguage();
		foreach (LocaliseSprite.LangSpritePair langSpritePair in this.sprites)
		{
			if (langSpritePair.language == languageCode)
			{
				this.spriteRenderer.sprite = langSpritePair.sprite;
				return;
			}
		}
	}

	// Token: 0x04000FCF RID: 4047
	public LocaliseSprite.LangSpritePair[] sprites;

	// Token: 0x04000FD0 RID: 4048
	private SpriteRenderer spriteRenderer;

	// Token: 0x020002CE RID: 718
	[Serializable]
	public struct LangSpritePair
	{
		// Token: 0x04000FD1 RID: 4049
		public LanguageCode language;

		// Token: 0x04000FD2 RID: 4050
		public Sprite sprite;
	}
}
