using System;
using Language;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Serializable]
public class LocalizationSettings : ScriptableObject
{
	// Token: 0x06000046 RID: 70 RVA: 0x00003620 File Offset: 0x00001820
	public static LanguageCode GetLanguageEnum(string langCode)
	{
		langCode = langCode.ToUpper();
		foreach (object obj in Enum.GetValues(typeof(LanguageCode)))
		{
			LanguageCode result = (LanguageCode)obj;
			if (result.ToString().Equals(langCode, StringComparison.InvariantCultureIgnoreCase))
			{
				return result;
			}
		}
		Debug.LogError("ERORR: There is no language: [" + langCode + "]");
		return LanguageCode.EN;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x000036B8 File Offset: 0x000018B8
	public LocalizationSettings()
	{
		this.useSystemLanguagePerDefault = true;
		this.defaultLangCode = "EN";
		base..ctor();
	}

	// Token: 0x0400002F RID: 47
	public string[] sheetTitles;

	// Token: 0x04000030 RID: 48
	public bool useSystemLanguagePerDefault;

	// Token: 0x04000031 RID: 49
	public string defaultLangCode;

	// Token: 0x04000032 RID: 50
	public string gDocsURL;
}
