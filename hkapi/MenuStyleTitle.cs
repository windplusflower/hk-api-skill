using System;
using Language;
using UnityEngine;

// Token: 0x02000499 RID: 1177
public class MenuStyleTitle : MonoBehaviour
{
	// Token: 0x06001A4E RID: 6734 RVA: 0x0007E338 File Offset: 0x0007C538
	public void SetTitle(int index)
	{
		MenuStyleTitle.TitleSpriteCollection titleSpriteCollection = (index >= 0 && index < this.TitleSprites.Length) ? this.TitleSprites[index] : this.DefaultTitleSprite;
		bool flag = false;
		foreach (RuntimePlatform runtimePlatform in titleSpriteCollection.PlatformWhitelist)
		{
			if (Application.platform == runtimePlatform)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			titleSpriteCollection = this.DefaultTitleSprite;
		}
		if (this.Title)
		{
			LanguageCode languageCode = Language.CurrentLanguage();
			if (languageCode <= LanguageCode.JA)
			{
				if (languageCode <= LanguageCode.FR)
				{
					if (languageCode == LanguageCode.ES)
					{
						this.Title.sprite = (titleSpriteCollection.Spanish ? titleSpriteCollection.Spanish : titleSpriteCollection.Default);
						return;
					}
					if (languageCode == LanguageCode.FR)
					{
						this.Title.sprite = (titleSpriteCollection.French ? titleSpriteCollection.French : titleSpriteCollection.Default);
						return;
					}
				}
				else
				{
					if (languageCode == LanguageCode.IT)
					{
						this.Title.sprite = (titleSpriteCollection.Italian ? titleSpriteCollection.Italian : titleSpriteCollection.Default);
						return;
					}
					if (languageCode == LanguageCode.JA)
					{
						this.Title.sprite = (titleSpriteCollection.Japanese ? titleSpriteCollection.Japanese : titleSpriteCollection.Default);
						return;
					}
				}
			}
			else if (languageCode <= LanguageCode.PT_BR)
			{
				if (languageCode == LanguageCode.KO)
				{
					this.Title.sprite = (titleSpriteCollection.Korean ? titleSpriteCollection.Korean : titleSpriteCollection.Default);
					return;
				}
				if (languageCode - LanguageCode.PT <= 1)
				{
					this.Title.sprite = (titleSpriteCollection.BrazilianPT ? titleSpriteCollection.BrazilianPT : titleSpriteCollection.Default);
					return;
				}
			}
			else
			{
				if (languageCode == LanguageCode.RU)
				{
					this.Title.sprite = (titleSpriteCollection.Russian ? titleSpriteCollection.Russian : titleSpriteCollection.Default);
					return;
				}
				if (languageCode == LanguageCode.ZH)
				{
					this.Title.sprite = (titleSpriteCollection.Chinese ? titleSpriteCollection.Chinese : titleSpriteCollection.Default);
					return;
				}
			}
			this.Title.sprite = titleSpriteCollection.Default;
		}
	}

	// Token: 0x04001F9D RID: 8093
	public SpriteRenderer Title;

	// Token: 0x04001F9E RID: 8094
	public MenuStyleTitle.TitleSpriteCollection DefaultTitleSprite;

	// Token: 0x04001F9F RID: 8095
	public MenuStyleTitle.TitleSpriteCollection[] TitleSprites;

	// Token: 0x0200049A RID: 1178
	[Serializable]
	public struct TitleSpriteCollection
	{
		// Token: 0x04001FA0 RID: 8096
		public RuntimePlatform[] PlatformWhitelist;

		// Token: 0x04001FA1 RID: 8097
		public Sprite Default;

		// Token: 0x04001FA2 RID: 8098
		public Sprite Chinese;

		// Token: 0x04001FA3 RID: 8099
		public Sprite Russian;

		// Token: 0x04001FA4 RID: 8100
		public Sprite Italian;

		// Token: 0x04001FA5 RID: 8101
		public Sprite Japanese;

		// Token: 0x04001FA6 RID: 8102
		public Sprite Spanish;

		// Token: 0x04001FA7 RID: 8103
		public Sprite Korean;

		// Token: 0x04001FA8 RID: 8104
		public Sprite French;

		// Token: 0x04001FA9 RID: 8105
		public Sprite BrazilianPT;
	}
}
