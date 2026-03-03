using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Modding;
using UnityEngine;

namespace Language
{
	// Token: 0x020006AB RID: 1707
	public static class Language
	{
		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000E3E58 File Offset: 0x000E2058
		public static LocalizationSettings settings
		{
			get
			{
				if (Language._settings == null)
				{
					Language._settings = (LocalizationSettings)Resources.Load("Languages/" + Path.GetFileNameWithoutExtension(Language.settingsAssetPath), typeof(LocalizationSettings));
				}
				return Language._settings;
			}
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000E3EA4 File Offset: 0x000E20A4
		static Language()
		{
			Language.settingsAssetPath = "Assets/Localization/Resources/Languages/LocalizationSettings.asset";
			Language._settings = null;
			Language.currentLanguage = LanguageCode.N;
			Language.LoadAvailableLanguages();
			Language.LoadLanguage();
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000E3EC8 File Offset: 0x000E20C8
		public static void LoadLanguage()
		{
			string text = Language.RestoreLanguageSelection();
			Debug.LogFormat("Restored language code '{0}'", new object[]
			{
				text
			});
			Language.SwitchLanguage(text);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000E3EF8 File Offset: 0x000E20F8
		private static string RestoreLanguageSelection()
		{
			if (Platform.Current && Platform.Current.SharedData.HasKey("M2H_lastLanguage"))
			{
				string @string = Platform.Current.SharedData.GetString("M2H_lastLanguage", "");
				Debug.LogFormat("Loaded saved language code '{0}'", new object[]
				{
					@string
				});
				if (Language.availableLanguages.Contains(@string))
				{
					return @string;
				}
				Debug.LogErrorFormat("Loaded saved language code '{0}' is not an available language", new object[]
				{
					@string
				});
			}
			if (Language.settings.useSystemLanguagePerDefault)
			{
				SystemLanguage systemLanguage = Platform.Current.GetSystemLanguage();
				Debug.LogFormat("Loaded system language '{0}'", new object[]
				{
					systemLanguage
				});
				string text = Language.LanguageNameToCode(systemLanguage).ToString();
				Debug.LogFormat("Loaded system language code '{0}'", new object[]
				{
					text
				});
				if (Language.availableLanguages.Contains(text))
				{
					return text;
				}
				Debug.LogErrorFormat("System language code '{0}' is not an available language", new object[]
				{
					text
				});
			}
			Debug.LogFormat("Falling back to default language code '{0}'", new object[]
			{
				Language.settings.defaultLangCode
			});
			return LocalizationSettings.GetLanguageEnum(Language.settings.defaultLangCode).ToString();
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x000E4030 File Offset: 0x000E2230
		public static void LoadAvailableLanguages()
		{
			Language.availableLanguages = new List<string>();
			if (Language.settings.sheetTitles == null || Language.settings.sheetTitles.Length == 0)
			{
				Debug.Log("None available");
				return;
			}
			foreach (object obj in Enum.GetValues(typeof(LanguageCode)))
			{
				LanguageCode languageCode = (LanguageCode)obj;
				if (Language.HasLanguageFile(languageCode.ToString() ?? "", Language.settings.sheetTitles[0]))
				{
					Language.availableLanguages.Add(languageCode.ToString() ?? "");
				}
			}
			StringBuilder stringBuilder = new StringBuilder("Discovered supported languages: ");
			for (int i = 0; i < Language.availableLanguages.Count; i++)
			{
				stringBuilder.Append(Language.availableLanguages[i]);
				if (i < Language.availableLanguages.Count - 1)
				{
					stringBuilder.Append(", ");
				}
			}
			Debug.Log(stringBuilder.ToString());
			Resources.UnloadUnusedAssets();
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x000E4168 File Offset: 0x000E2368
		public static string[] GetLanguages()
		{
			return Language.availableLanguages.ToArray();
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x000E4174 File Offset: 0x000E2374
		public static bool SwitchLanguage(string langCode)
		{
			return Language.SwitchLanguage(LocalizationSettings.GetLanguageEnum(langCode));
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x000E4184 File Offset: 0x000E2384
		public static bool SwitchLanguage(LanguageCode code)
		{
			if (Language.availableLanguages.Contains(code.ToString() ?? ""))
			{
				Language.DoSwitch(code);
				return true;
			}
			Debug.LogError("Could not switch from language " + Language.currentLanguage.ToString() + " to " + code.ToString());
			if (Language.currentLanguage == LanguageCode.N)
			{
				if (Language.availableLanguages.Count > 0)
				{
					Language.DoSwitch(LocalizationSettings.GetLanguageEnum(Language.availableLanguages[0]));
					Debug.LogError("Switched to " + Language.currentLanguage.ToString() + " instead");
				}
				else
				{
					Debug.LogError("Please verify that you have the file: Resources/Languages/" + code.ToString());
					Debug.Break();
				}
			}
			return false;
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x000E4260 File Offset: 0x000E2460
		private static void DoSwitch(LanguageCode newLang)
		{
			if (Platform.Current)
			{
				Platform.Current.SharedData.SetString("M2H_lastLanguage", newLang.ToString() ?? "");
				Platform.Current.SharedData.Save();
			}
			Language.currentLanguage = newLang;
			Language.currentEntrySheets = new Dictionary<string, Dictionary<string, string>>();
			foreach (string text in Language.settings.sheetTitles)
			{
				Language.currentEntrySheets[text] = new Dictionary<string, string>();
				string languageFileContents = Language.GetLanguageFileContents(text);
				if (languageFileContents != "")
				{
					using (XmlReader xmlReader = XmlReader.Create(new StringReader(languageFileContents)))
					{
						while (xmlReader.ReadToFollowing("entry"))
						{
							xmlReader.MoveToFirstAttribute();
							string value = xmlReader.Value;
							xmlReader.MoveToElement();
							string text2 = xmlReader.ReadElementContentAsString().Trim();
							text2 = text2.UnescapeXML();
							Language.currentEntrySheets[text][value] = text2;
						}
					}
				}
			}
			LocalizedAsset[] array = (LocalizedAsset[])UnityEngine.Object.FindObjectsOfType(typeof(LocalizedAsset));
			for (int i = 0; i < array.Length; i++)
			{
				array[i].LocalizeAsset();
			}
			Language.SendMonoMessage("ChangedLanguage", new object[]
			{
				Language.currentLanguage
			});
			if (!ConfigManager.IsSavingConfig)
			{
				ConfigManager.SaveConfig();
			}
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x000E43E0 File Offset: 0x000E25E0
		public static UnityEngine.Object GetAsset(string name)
		{
			return Resources.Load("Languages/Assets/" + Language.CurrentLanguage().ToString() + "/" + name);
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000E4415 File Offset: 0x000E2615
		private static bool HasLanguageFile(string lang, string sheetTitle)
		{
			return (TextAsset)Resources.Load("Languages/" + lang + "_" + sheetTitle, typeof(TextAsset)) != null;
		}

		// Token: 0x0600288B RID: 10379 RVA: 0x000E4444 File Offset: 0x000E2644
		private static string GetLanguageFileContents(string sheetTitle)
		{
			TextAsset textAsset = (TextAsset)Resources.Load("Languages/" + Language.currentLanguage.ToString() + "_" + sheetTitle, typeof(TextAsset));
			if (!(textAsset != null))
			{
				return "";
			}
			return textAsset.text;
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x000E449B File Offset: 0x000E269B
		public static LanguageCode CurrentLanguage()
		{
			return Language.currentLanguage;
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x000E44A2 File Offset: 0x000E26A2
		public static string Get(string key)
		{
			return Language.Get(key, Language.settings.sheetTitles[0]);
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x000E44B6 File Offset: 0x000E26B6
		public static string Get(string key, string sheetTitle)
		{
			return ModHooks.LanguageGet(key, sheetTitle);
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x000E44BF File Offset: 0x000E26BF
		public static bool Has(string key)
		{
			return Language.Has(key, Language.settings.sheetTitles[0]);
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x000E44D3 File Offset: 0x000E26D3
		public static bool Has(string key, string sheetTitle)
		{
			return Language.currentEntrySheets != null && Language.currentEntrySheets.ContainsKey(sheetTitle) && Language.currentEntrySheets[sheetTitle].ContainsKey(key);
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x000E44FC File Offset: 0x000E26FC
		private static void SendMonoMessage(string methodString, params object[] parameters)
		{
			if (parameters != null && parameters.Length > 1)
			{
				Debug.LogError("We cannot pass more than one argument currently!");
			}
			foreach (GameObject gameObject in (GameObject[])UnityEngine.Object.FindObjectsOfType(typeof(GameObject)))
			{
				if (gameObject && gameObject.transform.parent == null)
				{
					if (parameters != null && parameters.Length == 1)
					{
						gameObject.gameObject.BroadcastMessage(methodString, parameters[0], SendMessageOptions.DontRequireReceiver);
					}
					else
					{
						gameObject.gameObject.BroadcastMessage(methodString, SendMessageOptions.DontRequireReceiver);
					}
				}
			}
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x000E4588 File Offset: 0x000E2788
		public static LanguageCode LanguageNameToCode(SystemLanguage name)
		{
			if (name == SystemLanguage.Afrikaans)
			{
				return LanguageCode.AF;
			}
			if (name == SystemLanguage.Arabic)
			{
				return LanguageCode.AR;
			}
			if (name == SystemLanguage.Basque)
			{
				return LanguageCode.BA;
			}
			if (name == SystemLanguage.Belarusian)
			{
				return LanguageCode.BE;
			}
			if (name == SystemLanguage.Bulgarian)
			{
				return LanguageCode.BG;
			}
			if (name == SystemLanguage.Catalan)
			{
				return LanguageCode.CA;
			}
			if (name == SystemLanguage.Chinese)
			{
				return LanguageCode.ZH;
			}
			if (name == SystemLanguage.Czech)
			{
				return LanguageCode.CS;
			}
			if (name == SystemLanguage.Danish)
			{
				return LanguageCode.DA;
			}
			if (name == SystemLanguage.Dutch)
			{
				return LanguageCode.NL;
			}
			if (name == SystemLanguage.English)
			{
				return LanguageCode.EN;
			}
			if (name == SystemLanguage.Estonian)
			{
				return LanguageCode.ET;
			}
			if (name == SystemLanguage.Faroese)
			{
				return LanguageCode.FA;
			}
			if (name == SystemLanguage.Finnish)
			{
				return LanguageCode.FI;
			}
			if (name == SystemLanguage.French)
			{
				return LanguageCode.FR;
			}
			if (name == SystemLanguage.German)
			{
				return LanguageCode.DE;
			}
			if (name == SystemLanguage.Greek)
			{
				return LanguageCode.EL;
			}
			if (name == SystemLanguage.Hebrew)
			{
				return LanguageCode.HE;
			}
			if (name == SystemLanguage.Hungarian)
			{
				return LanguageCode.HU;
			}
			if (name == SystemLanguage.Icelandic)
			{
				return LanguageCode.IS;
			}
			if (name == SystemLanguage.Indonesian)
			{
				return LanguageCode.ID;
			}
			if (name == SystemLanguage.Italian)
			{
				return LanguageCode.IT;
			}
			if (name == SystemLanguage.Japanese)
			{
				return LanguageCode.JA;
			}
			if (name == SystemLanguage.Korean)
			{
				return LanguageCode.KO;
			}
			if (name == SystemLanguage.Latvian)
			{
				return LanguageCode.LA;
			}
			if (name == SystemLanguage.Lithuanian)
			{
				return LanguageCode.LT;
			}
			if (name == SystemLanguage.Norwegian)
			{
				return LanguageCode.NO;
			}
			if (name == SystemLanguage.Polish)
			{
				return LanguageCode.PL;
			}
			if (name == SystemLanguage.Portuguese)
			{
				return LanguageCode.PT;
			}
			if (name == SystemLanguage.Romanian)
			{
				return LanguageCode.RO;
			}
			if (name == SystemLanguage.Russian)
			{
				return LanguageCode.RU;
			}
			if (name == SystemLanguage.SerboCroatian)
			{
				return LanguageCode.SH;
			}
			if (name == SystemLanguage.Slovak)
			{
				return LanguageCode.SK;
			}
			if (name == SystemLanguage.Slovenian)
			{
				return LanguageCode.SL;
			}
			if (name == SystemLanguage.Spanish)
			{
				return LanguageCode.ES;
			}
			if (name == SystemLanguage.Swedish)
			{
				return LanguageCode.SW;
			}
			if (name == SystemLanguage.Thai)
			{
				return LanguageCode.TH;
			}
			if (name == SystemLanguage.Turkish)
			{
				return LanguageCode.TR;
			}
			if (name == SystemLanguage.Ukrainian)
			{
				return LanguageCode.UK;
			}
			if (name == SystemLanguage.Vietnamese)
			{
				return LanguageCode.VI;
			}
			if (name == SystemLanguage.Hungarian)
			{
				return LanguageCode.HU;
			}
			if (name == SystemLanguage.ChineseSimplified)
			{
				return LanguageCode.ZH;
			}
			if (name == SystemLanguage.ChineseTraditional)
			{
				return LanguageCode.ZH;
			}
			return LanguageCode.N;
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x000E471C File Offset: 0x000E291C
		public static string GetInternal(string key, string sheetTitle)
		{
			if (Language.currentEntrySheets == null || !Language.currentEntrySheets.ContainsKey(sheetTitle))
			{
				Debug.LogError("The sheet with title \"" + sheetTitle + "\" does not exist!");
				return string.Empty;
			}
			if (Language.currentEntrySheets[sheetTitle].ContainsKey(key))
			{
				return Language.currentEntrySheets[sheetTitle][key];
			}
			return "#!#" + key + "#!#";
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x000E4790 File Offset: 0x000E2990
		public static string orig_Get(string key, string sheetTitle)
		{
			if (Language.currentEntrySheets == null || !Language.currentEntrySheets.ContainsKey(sheetTitle))
			{
				Debug.LogError("The sheet with title \"" + sheetTitle + "\" does not exist!");
				return "";
			}
			if (Language.currentEntrySheets[sheetTitle].ContainsKey(key))
			{
				return Language.currentEntrySheets[sheetTitle][key];
			}
			return "#!#" + key + "#!#";
		}

		// Token: 0x04002DA8 RID: 11688
		public static string settingsAssetPath;

		// Token: 0x04002DA9 RID: 11689
		private static LocalizationSettings _settings;

		// Token: 0x04002DAA RID: 11690
		private static List<string> availableLanguages;

		// Token: 0x04002DAB RID: 11691
		private static LanguageCode currentLanguage;

		// Token: 0x04002DAC RID: 11692
		private static Dictionary<string, Dictionary<string, string>> currentEntrySheets;

		// Token: 0x04002DAD RID: 11693
		private const string LastLanguageKey = "M2H_lastLanguage";
	}
}
