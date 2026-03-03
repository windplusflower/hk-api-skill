using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000608 RID: 1544
	[ExecuteInEditMode]
	[Serializable]
	public class TMP_Settings : ScriptableObject
	{
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000BBCC9 File Offset: 0x000B9EC9
		public static bool enableWordWrapping
		{
			get
			{
				return TMP_Settings.instance.m_enableWordWrapping;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06002462 RID: 9314 RVA: 0x000BBCD5 File Offset: 0x000B9ED5
		public static bool enableKerning
		{
			get
			{
				return TMP_Settings.instance.m_enableKerning;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000BBCE1 File Offset: 0x000B9EE1
		public static bool enableExtraPadding
		{
			get
			{
				return TMP_Settings.instance.m_enableExtraPadding;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06002464 RID: 9316 RVA: 0x000BBCED File Offset: 0x000B9EED
		public static bool enableTintAllSprites
		{
			get
			{
				return TMP_Settings.instance.m_enableTintAllSprites;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000BBCF9 File Offset: 0x000B9EF9
		public static bool enableParseEscapeCharacters
		{
			get
			{
				return TMP_Settings.instance.m_enableParseEscapeCharacters;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06002466 RID: 9318 RVA: 0x000BBD05 File Offset: 0x000B9F05
		public static int missingGlyphCharacter
		{
			get
			{
				return TMP_Settings.instance.m_missingGlyphCharacter;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x000BBD11 File Offset: 0x000B9F11
		public static bool warningsDisabled
		{
			get
			{
				return TMP_Settings.instance.m_warningsDisabled;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002468 RID: 9320 RVA: 0x000BBD1D File Offset: 0x000B9F1D
		public static TMP_FontAsset defaultFontAsset
		{
			get
			{
				return TMP_Settings.instance.m_defaultFontAsset;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x000BBD29 File Offset: 0x000B9F29
		public static string defaultFontAssetPath
		{
			get
			{
				return TMP_Settings.instance.m_defaultFontAssetPath;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x0600246A RID: 9322 RVA: 0x000BBD35 File Offset: 0x000B9F35
		public static float defaultFontSize
		{
			get
			{
				return TMP_Settings.instance.m_defaultFontSize;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000BBD41 File Offset: 0x000B9F41
		public static float defaultTextContainerWidth
		{
			get
			{
				return TMP_Settings.instance.m_defaultTextContainerWidth;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600246C RID: 9324 RVA: 0x000BBD4D File Offset: 0x000B9F4D
		public static float defaultTextContainerHeight
		{
			get
			{
				return TMP_Settings.instance.m_defaultTextContainerHeight;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x000BBD59 File Offset: 0x000B9F59
		public static List<TMP_FontAsset> fallbackFontAssets
		{
			get
			{
				return TMP_Settings.instance.m_fallbackFontAssets;
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x000BBD65 File Offset: 0x000B9F65
		public static bool matchMaterialPreset
		{
			get
			{
				return TMP_Settings.instance.m_matchMaterialPreset;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000BBD71 File Offset: 0x000B9F71
		public static TMP_SpriteAsset defaultSpriteAsset
		{
			get
			{
				return TMP_Settings.instance.m_defaultSpriteAsset;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x000BBD7D File Offset: 0x000B9F7D
		public static string defaultSpriteAssetPath
		{
			get
			{
				return TMP_Settings.instance.m_defaultSpriteAssetPath;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x000BBD89 File Offset: 0x000B9F89
		public static TMP_StyleSheet defaultStyleSheet
		{
			get
			{
				return TMP_Settings.instance.m_defaultStyleSheet;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000BBD95 File Offset: 0x000B9F95
		public static TextAsset leadingCharacters
		{
			get
			{
				return TMP_Settings.instance.m_leadingCharacters;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000BBDA1 File Offset: 0x000B9FA1
		public static TextAsset followingCharacters
		{
			get
			{
				return TMP_Settings.instance.m_followingCharacters;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000BBDAD File Offset: 0x000B9FAD
		public static TMP_Settings.LineBreakingTable linebreakingRules
		{
			get
			{
				if (TMP_Settings.instance.m_linebreakingRules == null)
				{
					TMP_Settings.LoadLinebreakingRules();
				}
				return TMP_Settings.instance.m_linebreakingRules;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000BBDCA File Offset: 0x000B9FCA
		public static TMP_Settings instance
		{
			get
			{
				if (TMP_Settings.s_Instance == null)
				{
					TMP_Settings.s_Instance = (Resources.Load("TMP Settings") as TMP_Settings);
				}
				return TMP_Settings.s_Instance;
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x000BBDF4 File Offset: 0x000B9FF4
		public static TMP_Settings LoadDefaultSettings()
		{
			if (TMP_Settings.s_Instance == null)
			{
				TMP_Settings x = Resources.Load("TMP Settings") as TMP_Settings;
				if (x != null)
				{
					TMP_Settings.s_Instance = x;
				}
			}
			return TMP_Settings.s_Instance;
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x000BBE32 File Offset: 0x000BA032
		public static TMP_Settings GetSettings()
		{
			if (TMP_Settings.instance == null)
			{
				return null;
			}
			return TMP_Settings.instance;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x000BBE48 File Offset: 0x000BA048
		public static TMP_FontAsset GetFontAsset()
		{
			if (TMP_Settings.instance == null)
			{
				return null;
			}
			return TMP_Settings.instance.m_defaultFontAsset;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x000BBE63 File Offset: 0x000BA063
		public static TMP_SpriteAsset GetSpriteAsset()
		{
			if (TMP_Settings.instance == null)
			{
				return null;
			}
			return TMP_Settings.instance.m_defaultSpriteAsset;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x000BBE7E File Offset: 0x000BA07E
		public static TMP_StyleSheet GetStyleSheet()
		{
			if (TMP_Settings.instance == null)
			{
				return null;
			}
			return TMP_Settings.instance.m_defaultStyleSheet;
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x000BBE9C File Offset: 0x000BA09C
		public static void LoadLinebreakingRules()
		{
			if (TMP_Settings.instance == null)
			{
				return;
			}
			if (TMP_Settings.s_Instance.m_linebreakingRules == null)
			{
				TMP_Settings.s_Instance.m_linebreakingRules = new TMP_Settings.LineBreakingTable();
			}
			TMP_Settings.s_Instance.m_linebreakingRules.leadingCharacters = TMP_Settings.GetCharacters(TMP_Settings.s_Instance.m_leadingCharacters);
			TMP_Settings.s_Instance.m_linebreakingRules.followingCharacters = TMP_Settings.GetCharacters(TMP_Settings.s_Instance.m_followingCharacters);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000BBF10 File Offset: 0x000BA110
		private static Dictionary<int, char> GetCharacters(TextAsset file)
		{
			Dictionary<int, char> dictionary = new Dictionary<int, char>();
			foreach (char c in file.text)
			{
				if (!dictionary.ContainsKey((int)c))
				{
					dictionary.Add((int)c, c);
				}
			}
			return dictionary;
		}

		// Token: 0x0400287D RID: 10365
		private static TMP_Settings s_Instance;

		// Token: 0x0400287E RID: 10366
		[SerializeField]
		private bool m_enableWordWrapping;

		// Token: 0x0400287F RID: 10367
		[SerializeField]
		private bool m_enableKerning;

		// Token: 0x04002880 RID: 10368
		[SerializeField]
		private bool m_enableExtraPadding;

		// Token: 0x04002881 RID: 10369
		[SerializeField]
		private bool m_enableTintAllSprites;

		// Token: 0x04002882 RID: 10370
		[SerializeField]
		private bool m_enableParseEscapeCharacters;

		// Token: 0x04002883 RID: 10371
		[SerializeField]
		private int m_missingGlyphCharacter;

		// Token: 0x04002884 RID: 10372
		[SerializeField]
		private bool m_warningsDisabled;

		// Token: 0x04002885 RID: 10373
		[SerializeField]
		private TMP_FontAsset m_defaultFontAsset;

		// Token: 0x04002886 RID: 10374
		[SerializeField]
		private string m_defaultFontAssetPath;

		// Token: 0x04002887 RID: 10375
		[SerializeField]
		private float m_defaultFontSize;

		// Token: 0x04002888 RID: 10376
		[SerializeField]
		private float m_defaultTextContainerWidth;

		// Token: 0x04002889 RID: 10377
		[SerializeField]
		private float m_defaultTextContainerHeight;

		// Token: 0x0400288A RID: 10378
		[SerializeField]
		private List<TMP_FontAsset> m_fallbackFontAssets;

		// Token: 0x0400288B RID: 10379
		[SerializeField]
		private bool m_matchMaterialPreset;

		// Token: 0x0400288C RID: 10380
		[SerializeField]
		private TMP_SpriteAsset m_defaultSpriteAsset;

		// Token: 0x0400288D RID: 10381
		[SerializeField]
		private string m_defaultSpriteAssetPath;

		// Token: 0x0400288E RID: 10382
		[SerializeField]
		private TMP_StyleSheet m_defaultStyleSheet;

		// Token: 0x0400288F RID: 10383
		[SerializeField]
		private TextAsset m_leadingCharacters;

		// Token: 0x04002890 RID: 10384
		[SerializeField]
		private TextAsset m_followingCharacters;

		// Token: 0x04002891 RID: 10385
		[SerializeField]
		private TMP_Settings.LineBreakingTable m_linebreakingRules;

		// Token: 0x02000609 RID: 1545
		public class LineBreakingTable
		{
			// Token: 0x04002892 RID: 10386
			public Dictionary<int, char> leadingCharacters;

			// Token: 0x04002893 RID: 10387
			public Dictionary<int, char> followingCharacters;
		}
	}
}
