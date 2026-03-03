using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace TMPro
{
	// Token: 0x020005EC RID: 1516
	[Serializable]
	public class TMP_FontAsset : TMP_Asset
	{
		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x000B6325 File Offset: 0x000B4525
		public static TMP_FontAsset defaultFontAsset
		{
			get
			{
				if (TMP_FontAsset.s_defaultFontAsset == null)
				{
					TMP_FontAsset.s_defaultFontAsset = Resources.Load<TMP_FontAsset>("Fonts & Materials/ARIAL SDF");
				}
				return TMP_FontAsset.s_defaultFontAsset;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x000B6348 File Offset: 0x000B4548
		public FaceInfo fontInfo
		{
			get
			{
				return this.m_fontInfo;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x000B6350 File Offset: 0x000B4550
		public Dictionary<int, TMP_Glyph> characterDictionary
		{
			get
			{
				if (this.m_characterDictionary == null)
				{
					this.ReadFontDefinition();
				}
				return this.m_characterDictionary;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06002374 RID: 9076 RVA: 0x000B6366 File Offset: 0x000B4566
		public Dictionary<int, KerningPair> kerningDictionary
		{
			get
			{
				return this.m_kerningDictionary;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x000B636E File Offset: 0x000B456E
		public KerningTable kerningInfo
		{
			get
			{
				return this.m_kerningInfo;
			}
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00003603 File Offset: 0x00001803
		private void OnEnable()
		{
		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00003603 File Offset: 0x00001803
		private void OnDisable()
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x000B6376 File Offset: 0x000B4576
		public void AddFaceInfo(FaceInfo faceInfo)
		{
			this.m_fontInfo = faceInfo;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x000B6380 File Offset: 0x000B4580
		public void AddGlyphInfo(TMP_Glyph[] glyphInfo)
		{
			this.m_glyphInfoList = new List<TMP_Glyph>();
			int num = glyphInfo.Length;
			this.m_fontInfo.CharacterCount = num;
			this.m_characterSet = new int[num];
			for (int i = 0; i < num; i++)
			{
				TMP_Glyph tmp_Glyph = new TMP_Glyph();
				tmp_Glyph.id = glyphInfo[i].id;
				tmp_Glyph.x = glyphInfo[i].x;
				tmp_Glyph.y = glyphInfo[i].y;
				tmp_Glyph.width = glyphInfo[i].width;
				tmp_Glyph.height = glyphInfo[i].height;
				tmp_Glyph.xOffset = glyphInfo[i].xOffset;
				tmp_Glyph.yOffset = glyphInfo[i].yOffset;
				tmp_Glyph.xAdvance = glyphInfo[i].xAdvance;
				tmp_Glyph.scale = 1f;
				this.m_glyphInfoList.Add(tmp_Glyph);
				this.m_characterSet[i] = tmp_Glyph.id;
			}
			this.m_glyphInfoList = (from s in this.m_glyphInfoList
			orderby s.id
			select s).ToList<TMP_Glyph>();
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x000B6496 File Offset: 0x000B4696
		public void AddKerningInfo(KerningTable kerningTable)
		{
			this.m_kerningInfo = kerningTable;
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x000B64A0 File Offset: 0x000B46A0
		public void ReadFontDefinition()
		{
			if (this.m_fontInfo == null)
			{
				return;
			}
			this.m_characterDictionary = new Dictionary<int, TMP_Glyph>();
			for (int i = 0; i < this.m_glyphInfoList.Count; i++)
			{
				TMP_Glyph tmp_Glyph = this.m_glyphInfoList[i];
				if (!this.m_characterDictionary.ContainsKey(tmp_Glyph.id))
				{
					this.m_characterDictionary.Add(tmp_Glyph.id, tmp_Glyph);
				}
				if (tmp_Glyph.scale == 0f)
				{
					tmp_Glyph.scale = 1f;
				}
			}
			TMP_Glyph tmp_Glyph2 = new TMP_Glyph();
			if (this.m_characterDictionary.ContainsKey(32))
			{
				this.m_characterDictionary[32].width = this.m_characterDictionary[32].xAdvance;
				this.m_characterDictionary[32].height = this.m_fontInfo.Ascender - this.m_fontInfo.Descender;
				this.m_characterDictionary[32].yOffset = this.m_fontInfo.Ascender;
				this.m_characterDictionary[32].scale = 1f;
			}
			else
			{
				tmp_Glyph2 = new TMP_Glyph();
				tmp_Glyph2.id = 32;
				tmp_Glyph2.x = 0f;
				tmp_Glyph2.y = 0f;
				tmp_Glyph2.width = this.m_fontInfo.Ascender / 5f;
				tmp_Glyph2.height = this.m_fontInfo.Ascender - this.m_fontInfo.Descender;
				tmp_Glyph2.xOffset = 0f;
				tmp_Glyph2.yOffset = this.m_fontInfo.Ascender;
				tmp_Glyph2.xAdvance = this.m_fontInfo.PointSize / 4f;
				tmp_Glyph2.scale = 1f;
				this.m_characterDictionary.Add(32, tmp_Glyph2);
			}
			if (!this.m_characterDictionary.ContainsKey(160))
			{
				tmp_Glyph2 = TMP_Glyph.Clone(this.m_characterDictionary[32]);
				this.m_characterDictionary.Add(160, tmp_Glyph2);
			}
			if (!this.m_characterDictionary.ContainsKey(8203))
			{
				tmp_Glyph2 = TMP_Glyph.Clone(this.m_characterDictionary[32]);
				tmp_Glyph2.width = 0f;
				tmp_Glyph2.xAdvance = 0f;
				this.m_characterDictionary.Add(8203, tmp_Glyph2);
			}
			if (!this.m_characterDictionary.ContainsKey(8288))
			{
				tmp_Glyph2 = TMP_Glyph.Clone(this.m_characterDictionary[32]);
				tmp_Glyph2.width = 0f;
				tmp_Glyph2.xAdvance = 0f;
				this.m_characterDictionary.Add(8288, tmp_Glyph2);
			}
			if (!this.m_characterDictionary.ContainsKey(10))
			{
				tmp_Glyph2 = new TMP_Glyph();
				tmp_Glyph2.id = 10;
				tmp_Glyph2.x = 0f;
				tmp_Glyph2.y = 0f;
				tmp_Glyph2.width = 10f;
				tmp_Glyph2.height = this.m_characterDictionary[32].height;
				tmp_Glyph2.xOffset = 0f;
				tmp_Glyph2.yOffset = this.m_characterDictionary[32].yOffset;
				tmp_Glyph2.xAdvance = 0f;
				tmp_Glyph2.scale = 1f;
				this.m_characterDictionary.Add(10, tmp_Glyph2);
				if (!this.m_characterDictionary.ContainsKey(13))
				{
					this.m_characterDictionary.Add(13, tmp_Glyph2);
				}
			}
			if (!this.m_characterDictionary.ContainsKey(9))
			{
				tmp_Glyph2 = new TMP_Glyph();
				tmp_Glyph2.id = 9;
				tmp_Glyph2.x = this.m_characterDictionary[32].x;
				tmp_Glyph2.y = this.m_characterDictionary[32].y;
				tmp_Glyph2.width = this.m_characterDictionary[32].width * (float)this.tabSize + (this.m_characterDictionary[32].xAdvance - this.m_characterDictionary[32].width) * (float)(this.tabSize - 1);
				tmp_Glyph2.height = this.m_characterDictionary[32].height;
				tmp_Glyph2.xOffset = this.m_characterDictionary[32].xOffset;
				tmp_Glyph2.yOffset = this.m_characterDictionary[32].yOffset;
				tmp_Glyph2.xAdvance = this.m_characterDictionary[32].xAdvance * (float)this.tabSize;
				tmp_Glyph2.scale = 1f;
				this.m_characterDictionary.Add(9, tmp_Glyph2);
			}
			this.m_fontInfo.TabWidth = this.m_characterDictionary[9].xAdvance;
			if (this.m_fontInfo.CapHeight == 0f && this.m_characterDictionary.ContainsKey(65))
			{
				this.m_fontInfo.CapHeight = this.m_characterDictionary[65].yOffset;
			}
			if (this.m_fontInfo.Scale == 0f)
			{
				this.m_fontInfo.Scale = 1f;
			}
			this.m_kerningDictionary = new Dictionary<int, KerningPair>();
			List<KerningPair> kerningPairs = this.m_kerningInfo.kerningPairs;
			for (int j = 0; j < kerningPairs.Count; j++)
			{
				KerningPair kerningPair = kerningPairs[j];
				KerningPairKey kerningPairKey = new KerningPairKey(kerningPair.AscII_Left, kerningPair.AscII_Right);
				if (!this.m_kerningDictionary.ContainsKey(kerningPairKey.key))
				{
					this.m_kerningDictionary.Add(kerningPairKey.key, kerningPair);
				}
				else if (!TMP_Settings.warningsDisabled)
				{
					Debug.LogWarning(string.Concat(new string[]
					{
						"Kerning Key for [",
						kerningPairKey.ascii_Left.ToString(),
						"] and [",
						kerningPairKey.ascii_Right.ToString(),
						"] already exists."
					}));
				}
			}
			this.hashCode = TMP_TextUtilities.GetSimpleHashCode(base.name);
			this.materialHashCode = TMP_TextUtilities.GetSimpleHashCode(this.material.name);
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x000B6A7B File Offset: 0x000B4C7B
		public bool HasCharacter(int character)
		{
			return this.m_characterDictionary != null && this.m_characterDictionary.ContainsKey(character);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x000B6A7B File Offset: 0x000B4C7B
		public bool HasCharacter(char character)
		{
			return this.m_characterDictionary != null && this.m_characterDictionary.ContainsKey((int)character);
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x000B6A98 File Offset: 0x000B4C98
		public bool HasCharacter(char character, bool searchFallbacks)
		{
			if (this.m_characterDictionary == null)
			{
				return false;
			}
			if (this.m_characterDictionary.ContainsKey((int)character))
			{
				return true;
			}
			if (searchFallbacks)
			{
				if (this.fallbackFontAssets != null && this.fallbackFontAssets.Count > 0)
				{
					for (int i = 0; i < this.fallbackFontAssets.Count; i++)
					{
						if (this.fallbackFontAssets[i].characterDictionary != null && this.fallbackFontAssets[i].characterDictionary.ContainsKey((int)character))
						{
							return true;
						}
					}
				}
				if (TMP_Settings.fallbackFontAssets != null && TMP_Settings.fallbackFontAssets.Count > 0)
				{
					for (int j = 0; j < TMP_Settings.fallbackFontAssets.Count; j++)
					{
						if (TMP_Settings.fallbackFontAssets[j].characterDictionary != null && TMP_Settings.fallbackFontAssets[j].characterDictionary.ContainsKey((int)character))
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x000B6B78 File Offset: 0x000B4D78
		public bool HasCharacters(string text, out List<char> missingCharacters)
		{
			if (this.m_characterDictionary == null)
			{
				missingCharacters = null;
				return false;
			}
			missingCharacters = new List<char>();
			for (int i = 0; i < text.Length; i++)
			{
				if (!this.m_characterDictionary.ContainsKey((int)text[i]))
				{
					missingCharacters.Add(text[i]);
				}
			}
			return missingCharacters.Count == 0;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x000B6BD8 File Offset: 0x000B4DD8
		public static string GetCharacters(TMP_FontAsset fontAsset)
		{
			string text = string.Empty;
			for (int i = 0; i < fontAsset.m_glyphInfoList.Count; i++)
			{
				text += ((char)fontAsset.m_glyphInfoList[i].id).ToString();
			}
			return text;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x000B6C24 File Offset: 0x000B4E24
		public static int[] GetCharactersArray(TMP_FontAsset fontAsset)
		{
			int[] array = new int[fontAsset.m_glyphInfoList.Count];
			for (int i = 0; i < fontAsset.m_glyphInfoList.Count; i++)
			{
				array[i] = fontAsset.m_glyphInfoList[i].id;
			}
			return array;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x000B6C6D File Offset: 0x000B4E6D
		public TMP_FontAsset()
		{
			this.fontWeights = new TMP_FontWeights[10];
			this.boldStyle = 0.75f;
			this.boldSpacing = 7f;
			this.italicStyle = 35;
			this.tabSize = 10;
			base..ctor();
		}

		// Token: 0x040027CF RID: 10191
		private static TMP_FontAsset s_defaultFontAsset;

		// Token: 0x040027D0 RID: 10192
		public TMP_FontAsset.FontAssetTypes fontAssetType;

		// Token: 0x040027D1 RID: 10193
		[SerializeField]
		private FaceInfo m_fontInfo;

		// Token: 0x040027D2 RID: 10194
		[SerializeField]
		public Texture2D atlas;

		// Token: 0x040027D3 RID: 10195
		[SerializeField]
		private List<TMP_Glyph> m_glyphInfoList;

		// Token: 0x040027D4 RID: 10196
		private Dictionary<int, TMP_Glyph> m_characterDictionary;

		// Token: 0x040027D5 RID: 10197
		private Dictionary<int, KerningPair> m_kerningDictionary;

		// Token: 0x040027D6 RID: 10198
		[SerializeField]
		private KerningTable m_kerningInfo;

		// Token: 0x040027D7 RID: 10199
		[SerializeField]
		private KerningPair m_kerningPair;

		// Token: 0x040027D8 RID: 10200
		[SerializeField]
		public List<TMP_FontAsset> fallbackFontAssets;

		// Token: 0x040027D9 RID: 10201
		[SerializeField]
		public FontCreationSetting fontCreationSettings;

		// Token: 0x040027DA RID: 10202
		[SerializeField]
		public TMP_FontWeights[] fontWeights;

		// Token: 0x040027DB RID: 10203
		private int[] m_characterSet;

		// Token: 0x040027DC RID: 10204
		public float normalStyle;

		// Token: 0x040027DD RID: 10205
		public float normalSpacingOffset;

		// Token: 0x040027DE RID: 10206
		public float boldStyle;

		// Token: 0x040027DF RID: 10207
		public float boldSpacing;

		// Token: 0x040027E0 RID: 10208
		public byte italicStyle;

		// Token: 0x040027E1 RID: 10209
		public byte tabSize;

		// Token: 0x040027E2 RID: 10210
		private byte m_oldTabSize;

		// Token: 0x020005ED RID: 1517
		public enum FontAssetTypes
		{
			// Token: 0x040027E4 RID: 10212
			None,
			// Token: 0x040027E5 RID: 10213
			SDF,
			// Token: 0x040027E6 RID: 10214
			Bitmap
		}
	}
}
