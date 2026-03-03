using System;
using GlobalEnums;
using TMPro;
using UnityEngine;

// Token: 0x020001FA RID: 506
public class GameCompletionScreen : MonoBehaviour
{
	// Token: 0x06000AEE RID: 2798 RVA: 0x0003A0A8 File Offset: 0x000382A8
	private void Start()
	{
		this.gm = GameManager.instance;
		PlayerData playerData = this.gm.playerData;
		playerData.CountGameCompletion();
		SaveStats saveStats = new SaveStats(playerData.GetInt("maxHealthBase"), playerData.GetInt("geo"), playerData.GetVariable<MapZone>("mapZone"), playerData.GetFloat("playTime"), playerData.GetInt("MPReserveMax"), playerData.GetInt("permadeathMode"), playerData.GetBool("bossRushMode"), playerData.GetFloat("completionPercentage"), playerData.GetBool("unlockedCompletionRate"));
		this.percentageNumber.text = saveStats.GetCompletionPercentage();
		this.playTimeNumber.text = saveStats.GetPlaytimeHHMMSS();
	}

	// Token: 0x04000BF9 RID: 3065
	public TextMeshPro percentageNumber;

	// Token: 0x04000BFA RID: 3066
	public TextMeshPro playTimeNumber;

	// Token: 0x04000BFB RID: 3067
	private GameManager gm;
}
