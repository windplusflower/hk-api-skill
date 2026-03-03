using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000640 RID: 1600
	public struct WordWrapState
	{
		// Token: 0x04002A8B RID: 10891
		public int previous_WordBreak;

		// Token: 0x04002A8C RID: 10892
		public int total_CharacterCount;

		// Token: 0x04002A8D RID: 10893
		public int visible_CharacterCount;

		// Token: 0x04002A8E RID: 10894
		public int visible_SpriteCount;

		// Token: 0x04002A8F RID: 10895
		public int visible_LinkCount;

		// Token: 0x04002A90 RID: 10896
		public int firstCharacterIndex;

		// Token: 0x04002A91 RID: 10897
		public int firstVisibleCharacterIndex;

		// Token: 0x04002A92 RID: 10898
		public int lastCharacterIndex;

		// Token: 0x04002A93 RID: 10899
		public int lastVisibleCharIndex;

		// Token: 0x04002A94 RID: 10900
		public int lineNumber;

		// Token: 0x04002A95 RID: 10901
		public float maxCapHeight;

		// Token: 0x04002A96 RID: 10902
		public float maxAscender;

		// Token: 0x04002A97 RID: 10903
		public float maxDescender;

		// Token: 0x04002A98 RID: 10904
		public float maxLineAscender;

		// Token: 0x04002A99 RID: 10905
		public float maxLineDescender;

		// Token: 0x04002A9A RID: 10906
		public float previousLineAscender;

		// Token: 0x04002A9B RID: 10907
		public float xAdvance;

		// Token: 0x04002A9C RID: 10908
		public float preferredWidth;

		// Token: 0x04002A9D RID: 10909
		public float preferredHeight;

		// Token: 0x04002A9E RID: 10910
		public float previousLineScale;

		// Token: 0x04002A9F RID: 10911
		public int wordCount;

		// Token: 0x04002AA0 RID: 10912
		public FontStyles fontStyle;

		// Token: 0x04002AA1 RID: 10913
		public float fontScale;

		// Token: 0x04002AA2 RID: 10914
		public float fontScaleMultiplier;

		// Token: 0x04002AA3 RID: 10915
		public float currentFontSize;

		// Token: 0x04002AA4 RID: 10916
		public float baselineOffset;

		// Token: 0x04002AA5 RID: 10917
		public float lineOffset;

		// Token: 0x04002AA6 RID: 10918
		public TMP_TextInfo textInfo;

		// Token: 0x04002AA7 RID: 10919
		public TMP_LineInfo lineInfo;

		// Token: 0x04002AA8 RID: 10920
		public Color32 vertexColor;

		// Token: 0x04002AA9 RID: 10921
		public TMP_XmlTagStack<Color32> colorStack;

		// Token: 0x04002AAA RID: 10922
		public TMP_XmlTagStack<float> sizeStack;

		// Token: 0x04002AAB RID: 10923
		public TMP_XmlTagStack<int> fontWeightStack;

		// Token: 0x04002AAC RID: 10924
		public TMP_XmlTagStack<int> styleStack;

		// Token: 0x04002AAD RID: 10925
		public TMP_XmlTagStack<int> actionStack;

		// Token: 0x04002AAE RID: 10926
		public TMP_XmlTagStack<MaterialReference> materialReferenceStack;

		// Token: 0x04002AAF RID: 10927
		public TMP_FontAsset currentFontAsset;

		// Token: 0x04002AB0 RID: 10928
		public TMP_SpriteAsset currentSpriteAsset;

		// Token: 0x04002AB1 RID: 10929
		public Material currentMaterial;

		// Token: 0x04002AB2 RID: 10930
		public int currentMaterialIndex;

		// Token: 0x04002AB3 RID: 10931
		public Extents meshExtents;

		// Token: 0x04002AB4 RID: 10932
		public bool tagNoParsing;
	}
}
