using System;
using Language;
using TMPro;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class ChangeFontByLanguage : MonoBehaviour
{
	// Token: 0x06000025 RID: 37 RVA: 0x00002C5C File Offset: 0x00000E5C
	private void Awake()
	{
		this.tmpro = base.GetComponent<TextMeshPro>();
		if (this.tmpro)
		{
			if (this.defaultFont == null)
			{
				this.defaultFont = this.tmpro.font;
			}
			this.startFontSize = this.tmpro.fontSize;
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002CB2 File Offset: 0x00000EB2
	private void Start()
	{
		this.SetFont();
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002CBA File Offset: 0x00000EBA
	private void OnEnable()
	{
		if (!this.onlyOnStart)
		{
			this.SetFont();
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002CCC File Offset: 0x00000ECC
	public void SetFont()
	{
		if (this.tmpro == null)
		{
			return;
		}
		string a = Language.CurrentLanguage().ToString();
		if (a == "JA")
		{
			this.tmpro.fontSize = this.GetFontScale("JA");
			this.tmpro.font = ((this.fontJA != null) ? this.fontJA : this.defaultFont);
			return;
		}
		if (a == "RU")
		{
			this.tmpro.fontSize = this.GetFontScale("RU");
			this.tmpro.font = ((this.fontRU != null) ? this.fontRU : this.defaultFont);
			return;
		}
		if (a == "ZH")
		{
			this.tmpro.fontSize = this.GetFontScale("ZH");
			this.tmpro.font = ((this.fontZH != null) ? this.fontZH : this.defaultFont);
			return;
		}
		if (a == "KO")
		{
			this.tmpro.fontSize = this.GetFontScale("KO");
			this.tmpro.font = ((this.fontKO != null) ? this.fontKO : this.defaultFont);
			return;
		}
		this.tmpro.fontSize = this.startFontSize;
		if (this.defaultFont != null)
		{
			this.tmpro.font = this.defaultFont;
		}
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002E58 File Offset: 0x00001058
	private float GetFontScale(string lang)
	{
		switch (this.fontScaleLangType)
		{
		case ChangeFontByLanguage.FontScaleLangTypes.AreaName:
			return this.fontScaleAreaName.GetFontScale(lang, this.startFontSize);
		case ChangeFontByLanguage.FontScaleLangTypes.SubAreaName:
			return this.fontScaleSubAreaName.GetFontScale(lang, this.startFontSize);
		case ChangeFontByLanguage.FontScaleLangTypes.WideMap:
			return this.fontScaleWideMap.GetFontScale(lang, this.startFontSize);
		case ChangeFontByLanguage.FontScaleLangTypes.CreditsTitle:
			return this.fontScaleCreditsTitle.GetFontScale(lang, this.startFontSize);
		case ChangeFontByLanguage.FontScaleLangTypes.ExcerptAuthor:
			return this.fontScaleExcerptAuthor.GetFontScale(lang, this.startFontSize);
		default:
			return this.startFontSize;
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002EF0 File Offset: 0x000010F0
	public ChangeFontByLanguage()
	{
		this.fontScaleAreaName = new ChangeFontByLanguage.FontScaleLang
		{
			fontSizeJA = new float?(4.5f),
			fontSizeRU = new float?(2.8f),
			fontSizeZH = new float?(4.5f),
			fontSizeKO = new float?(4.5f)
		};
		this.fontScaleSubAreaName = new ChangeFontByLanguage.FontScaleLang
		{
			fontSizeJA = null,
			fontSizeRU = new float?(3.9f),
			fontSizeZH = null,
			fontSizeKO = null
		};
		this.fontScaleWideMap = new ChangeFontByLanguage.FontScaleLang
		{
			fontSizeJA = new float?(2.5f),
			fontSizeRU = null,
			fontSizeZH = new float?(3.14f),
			fontSizeKO = new float?(2.89f)
		};
		this.fontScaleCreditsTitle = new ChangeFontByLanguage.FontScaleLang
		{
			fontSizeJA = null,
			fontSizeRU = new float?(5.5f),
			fontSizeZH = null,
			fontSizeKO = null
		};
		this.fontScaleExcerptAuthor = new ChangeFontByLanguage.FontScaleLang
		{
			fontSizeJA = new float?(4.5f),
			fontSizeRU = new float?(4.5f),
			fontSizeZH = new float?(4.5f),
			fontSizeKO = new float?(4.5f)
		};
		base..ctor();
	}

	// Token: 0x04000009 RID: 9
	public TMP_FontAsset defaultFont;

	// Token: 0x0400000A RID: 10
	public TMP_FontAsset fontJA;

	// Token: 0x0400000B RID: 11
	public TMP_FontAsset fontRU;

	// Token: 0x0400000C RID: 12
	public TMP_FontAsset fontZH;

	// Token: 0x0400000D RID: 13
	public TMP_FontAsset fontKO;

	// Token: 0x0400000E RID: 14
	public bool onlyOnStart;

	// Token: 0x0400000F RID: 15
	private TextMeshPro tmpro;

	// Token: 0x04000010 RID: 16
	private float startFontSize;

	// Token: 0x04000011 RID: 17
	public ChangeFontByLanguage.FontScaleLangTypes fontScaleLangType;

	// Token: 0x04000012 RID: 18
	private ChangeFontByLanguage.FontScaleLang fontScaleAreaName;

	// Token: 0x04000013 RID: 19
	private ChangeFontByLanguage.FontScaleLang fontScaleSubAreaName;

	// Token: 0x04000014 RID: 20
	private ChangeFontByLanguage.FontScaleLang fontScaleWideMap;

	// Token: 0x04000015 RID: 21
	private ChangeFontByLanguage.FontScaleLang fontScaleCreditsTitle;

	// Token: 0x04000016 RID: 22
	private ChangeFontByLanguage.FontScaleLang fontScaleExcerptAuthor;

	// Token: 0x02000006 RID: 6
	public enum FontScaleLangTypes
	{
		// Token: 0x04000018 RID: 24
		None,
		// Token: 0x04000019 RID: 25
		AreaName,
		// Token: 0x0400001A RID: 26
		SubAreaName,
		// Token: 0x0400001B RID: 27
		WideMap,
		// Token: 0x0400001C RID: 28
		CreditsTitle,
		// Token: 0x0400001D RID: 29
		ExcerptAuthor
	}

	// Token: 0x02000007 RID: 7
	private class FontScaleLang
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00003060 File Offset: 0x00001260
		public float GetFontScale(string lang, float defaultScale)
		{
			if (lang == "JA")
			{
				if (this.fontSizeJA == null)
				{
					return defaultScale;
				}
				return this.fontSizeJA.Value;
			}
			else if (lang == "RU")
			{
				if (this.fontSizeRU == null)
				{
					return defaultScale;
				}
				return this.fontSizeRU.Value;
			}
			else if (lang == "ZH")
			{
				if (this.fontSizeZH == null)
				{
					return defaultScale;
				}
				return this.fontSizeZH.Value;
			}
			else
			{
				if (!(lang == "KO"))
				{
					return defaultScale;
				}
				if (this.fontSizeKO == null)
				{
					return defaultScale;
				}
				return this.fontSizeKO.Value;
			}
		}

		// Token: 0x0400001E RID: 30
		public float? fontSizeJA;

		// Token: 0x0400001F RID: 31
		public float? fontSizeRU;

		// Token: 0x04000020 RID: 32
		public float? fontSizeZH;

		// Token: 0x04000021 RID: 33
		public float? fontSizeKO;
	}
}
