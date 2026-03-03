using System;

// Token: 0x02000116 RID: 278
[Serializable]
public class SaveGameData
{
	// Token: 0x06000697 RID: 1687 RVA: 0x00026B58 File Offset: 0x00024D58
	public SaveGameData(PlayerData playerData, SceneData sceneData)
	{
		this.playerData = playerData;
		this.sceneData = sceneData;
	}

	// Token: 0x04000729 RID: 1833
	public PlayerData playerData;

	// Token: 0x0400072A RID: 1834
	public SceneData sceneData;
}
