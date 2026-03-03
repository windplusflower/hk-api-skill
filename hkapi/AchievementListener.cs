using System;
using Language;
using TMPro;
using UnityEngine;

// Token: 0x020001EE RID: 494
public class AchievementListener : MonoBehaviour
{
	// Token: 0x06000AB0 RID: 2736 RVA: 0x000398D0 File Offset: 0x00037AD0
	private void OnEnable()
	{
		if (!this.gm)
		{
			this.gm = GameManager.instance;
		}
		Debug.Log(base.name + " enabled, subscribing to AwardAchievement.");
		this.gm.achievementHandler.AwardAchievementEvent += this.CaptureAchievementEvent;
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x00039926 File Offset: 0x00037B26
	private void OnDisable()
	{
		this.gm.achievementHandler.AwardAchievementEvent -= this.CaptureAchievementEvent;
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x00039944 File Offset: 0x00037B44
	private void CaptureAchievementEvent(string achievementKey)
	{
		Debug.Log("*** Achievement Awarded! *** " + achievementKey);
		Achievement achievement = this.gm.achievementHandler.achievementsList.FindAchievement(achievementKey);
		this.icon.sprite = achievement.earnedIcon;
		this.title.text = Language.Get(achievement.localizedTitle, "Achievements");
		this.text.text = Language.Get(achievement.localizedText, "Achievements");
		if (this.fsmToSendEvent && !string.IsNullOrEmpty(this.eventName))
		{
			this.fsmToSendEvent.SendEvent(this.eventName);
		}
	}

	// Token: 0x04000BD0 RID: 3024
	private GameManager gm;

	// Token: 0x04000BD1 RID: 3025
	public SpriteRenderer icon;

	// Token: 0x04000BD2 RID: 3026
	public TextMeshPro title;

	// Token: 0x04000BD3 RID: 3027
	public TextMeshPro text;

	// Token: 0x04000BD4 RID: 3028
	public PlayMakerFSM fsmToSendEvent;

	// Token: 0x04000BD5 RID: 3029
	public string eventName;
}
