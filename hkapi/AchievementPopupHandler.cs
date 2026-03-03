using System;
using System.Collections.Generic;
using Language;
using UnityEngine;

// Token: 0x0200042C RID: 1068
public class AchievementPopupHandler : MonoBehaviour
{
	// Token: 0x0600180C RID: 6156 RVA: 0x00071205 File Offset: 0x0006F405
	private void Awake()
	{
		AchievementPopupHandler.Instance = this;
		if (this.template)
		{
			this.popups.Add(this.template);
			this.template.gameObject.SetActive(false);
		}
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x0007123C File Offset: 0x0006F43C
	private void Start()
	{
		this.achievements = GameManager.instance.achievementHandler;
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x0007124E File Offset: 0x0006F44E
	public void Setup(AchievementHandler handler)
	{
		this.achievements = handler;
		if (!Platform.Current.HasNativeAchievementsDialog)
		{
			this.achievements.AwardAchievementEvent += this.HandleAchievementEvent;
		}
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x0007127C File Offset: 0x0006F47C
	private void HandleAchievementEvent(string key)
	{
		Achievement achievement = this.achievements.achievementsList.FindAchievement(key);
		Sprite earnedIcon = achievement.earnedIcon;
		string name = Language.Get(achievement.localizedTitle, "Achievements");
		string description = Language.Get(achievement.localizedText, "Achievements");
		AchievementPopup pooledPopup = this.GetPooledPopup();
		if (pooledPopup)
		{
			pooledPopup.Setup(earnedIcon, name, description);
			this.lastPopup = pooledPopup;
			pooledPopup.OnFinish += this.DisableAll;
			return;
		}
		Debug.LogError("Could not get achievement popup!");
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x00071300 File Offset: 0x0006F500
	private AchievementPopup GetPooledPopup()
	{
		AchievementPopup achievementPopup = null;
		foreach (AchievementPopup achievementPopup2 in this.popups)
		{
			if (!achievementPopup2.gameObject.activeSelf)
			{
				achievementPopup = achievementPopup2;
				break;
			}
		}
		if (achievementPopup == null && this.template)
		{
			achievementPopup = UnityEngine.Object.Instantiate<GameObject>(this.template.gameObject, this.template.transform.parent).GetComponent<AchievementPopup>();
			this.popups.Add(achievementPopup);
		}
		if (this.reverseOrder)
		{
			achievementPopup.transform.SetAsFirstSibling();
		}
		else
		{
			achievementPopup.transform.SetAsLastSibling();
		}
		achievementPopup.gameObject.SetActive(true);
		return achievementPopup;
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x000713D4 File Offset: 0x0006F5D4
	private void DisableAll(AchievementPopup sender)
	{
		sender.OnFinish -= this.DisableAll;
		if (sender == this.lastPopup)
		{
			foreach (AchievementPopup achievementPopup in this.popups)
			{
				achievementPopup.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x0007144C File Offset: 0x0006F64C
	public AchievementPopupHandler()
	{
		this.popups = new List<AchievementPopup>();
		base..ctor();
	}

	// Token: 0x04001CDC RID: 7388
	public static AchievementPopupHandler Instance;

	// Token: 0x04001CDD RID: 7389
	public AchievementPopup template;

	// Token: 0x04001CDE RID: 7390
	private List<AchievementPopup> popups;

	// Token: 0x04001CDF RID: 7391
	public bool reverseOrder;

	// Token: 0x04001CE0 RID: 7392
	private AchievementHandler achievements;

	// Token: 0x04001CE1 RID: 7393
	private AchievementPopup lastPopup;
}
