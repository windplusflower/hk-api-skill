using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x0200010B RID: 267
[Serializable]
public class Achievement
{
	// Token: 0x04000701 RID: 1793
	public string key;

	// Token: 0x04000702 RID: 1794
	public AchievementType type;

	// Token: 0x04000703 RID: 1795
	public Sprite earnedIcon;

	// Token: 0x04000704 RID: 1796
	public Sprite unearnedIcon;

	// Token: 0x04000705 RID: 1797
	public string localizedText;

	// Token: 0x04000706 RID: 1798
	public string localizedTitle;
}
