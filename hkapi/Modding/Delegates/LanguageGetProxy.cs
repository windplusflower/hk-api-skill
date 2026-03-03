using System;

namespace Modding.Delegates
{
	/// <summary>
	///     Called whenever localization specific strings are requested
	/// </summary>
	/// <param name="key">The key within the sheet</param>
	/// <param name="sheetTitle">The title of the sheet</param>
	/// <param name="orig">The original localized value</param>
	/// <returns>The modified localization, return *current* to keep as-is.</returns>
	// Token: 0x02000DE3 RID: 3555
	// (Invoke) Token: 0x06004977 RID: 18807
	public delegate string LanguageGetProxy(string key, string sheetTitle, string orig);
}
