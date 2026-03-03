using System;
using UnityEngine;

// Token: 0x02000110 RID: 272
[Serializable]
public class GameConfig : ScriptableObject
{
	// Token: 0x04000708 RID: 1800
	public bool showTargetSceneNamesOnGates;

	// Token: 0x04000709 RID: 1801
	public bool enableDebugButtons;

	// Token: 0x0400070A RID: 1802
	public bool enableCheats;

	// Token: 0x0400070B RID: 1803
	public bool disableSaveGame;

	// Token: 0x0400070C RID: 1804
	public bool useSaveEncryption;

	// Token: 0x0400070D RID: 1805
	public bool steamEnabled;

	// Token: 0x0400070E RID: 1806
	public bool galaxyEnabled;

	// Token: 0x0400070F RID: 1807
	public bool clearRecordsOnStart;

	// Token: 0x04000710 RID: 1808
	public bool unlockPermadeathMode;

	// Token: 0x04000711 RID: 1809
	public bool unlockBossRushMode;

	// Token: 0x04000712 RID: 1810
	public bool clearPreferredLanguageSetting;

	// Token: 0x04000713 RID: 1811
	public bool unlockAllMenuStyles;

	// Token: 0x04000714 RID: 1812
	public bool hideExtrasMenu;

	// Token: 0x04000715 RID: 1813
	public bool hideKeyboardMenu;

	// Token: 0x04000716 RID: 1814
	public bool hideLanguageOption;

	// Token: 0x04000717 RID: 1815
	public bool nativeAchievementsSettingAlwaysOn;

	// Token: 0x04000718 RID: 1816
	public bool hideVsyncSetting;

	// Token: 0x04000719 RID: 1817
	public bool enableTFRSetting;

	// Token: 0x0400071A RID: 1818
	public bool hideMonitorSetting;
}
