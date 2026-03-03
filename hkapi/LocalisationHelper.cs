using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020002CA RID: 714
public static class LocalisationHelper
{
	// Token: 0x06000F06 RID: 3846 RVA: 0x00049F84 File Offset: 0x00048184
	public static string GetProcessed(this string text, LocalisationHelper.FontSource fontSource)
	{
		if (LocalisationHelper.substitutions.ContainsKey(fontSource))
		{
			string text2 = text;
			foreach (KeyValuePair<string, string> keyValuePair in LocalisationHelper.substitutions[fontSource])
			{
				text2 = text2.Replace(keyValuePair.Key, keyValuePair.Value);
			}
			if (text2 != text)
			{
				Debug.Log(string.Format("LocalisationHelper processed string \"<b>{0}</b>\", result: \"<b>{1}</b>\".", text, text2));
				text = text2;
			}
		}
		return text;
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x0004A01C File Offset: 0x0004821C
	// Note: this type is marked as 'beforefieldinit'.
	static LocalisationHelper()
	{
		LocalisationHelper.substitutions = new Dictionary<LocalisationHelper.FontSource, Dictionary<string, string>>
		{
			{
				LocalisationHelper.FontSource.Trajan,
				new Dictionary<string, string>
				{
					{
						"ß",
						"ss"
					}
				}
			}
		};
	}

	// Token: 0x04000FC7 RID: 4039
	private static Dictionary<LocalisationHelper.FontSource, Dictionary<string, string>> substitutions;

	// Token: 0x020002CB RID: 715
	public enum FontSource
	{
		// Token: 0x04000FC9 RID: 4041
		Trajan,
		// Token: 0x04000FCA RID: 4042
		Perpetua
	}
}
