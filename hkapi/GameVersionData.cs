using System;
using UnityEngine;

// Token: 0x02000111 RID: 273
[Serializable]
public class GameVersionData : ScriptableObject
{
	// Token: 0x06000693 RID: 1683 RVA: 0x00026ADC File Offset: 0x00024CDC
	public string GetGameVersionString()
	{
		return string.Concat(new string[]
		{
			this.gameVersion.major.ToString(),
			".",
			this.gameVersion.minor.ToString(),
			".",
			this.gameVersion.revision.ToString(),
			".",
			this.gameVersion.package.ToString()
		});
	}

	// Token: 0x0400071B RID: 1819
	[SerializeField]
	public GameVersion gameVersion;

	// Token: 0x0400071C RID: 1820
	public string version;
}
