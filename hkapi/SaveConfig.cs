using System;
using UnityEngine;

// Token: 0x02000114 RID: 276
[Serializable]
public class SaveConfig : ScriptableObject
{
	// Token: 0x04000721 RID: 1825
	[SerializeField]
	public SaveConfig.SaveSet saveToUse;

	// Token: 0x04000722 RID: 1826
	[SerializeField]
	public PlayerData defaultPlayerData;

	// Token: 0x04000723 RID: 1827
	[SerializeField]
	public PlayerData testPlayerData;

	// Token: 0x04000724 RID: 1828
	[SerializeField]
	public PlayerData fullPlayerData;

	// Token: 0x02000115 RID: 277
	public enum SaveSet
	{
		// Token: 0x04000726 RID: 1830
		Default,
		// Token: 0x04000727 RID: 1831
		Test,
		// Token: 0x04000728 RID: 1832
		Full
	}
}
