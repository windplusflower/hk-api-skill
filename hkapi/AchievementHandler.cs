using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020002D1 RID: 721
public class AchievementHandler : MonoBehaviour
{
	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0004A1EB File Offset: 0x000483EB
	// (set) Token: 0x06000F11 RID: 3857 RVA: 0x0004A1F3 File Offset: 0x000483F3
	public AchievementsList achievementsList { get; private set; }

	// Token: 0x14000021 RID: 33
	// (add) Token: 0x06000F12 RID: 3858 RVA: 0x0004A1FC File Offset: 0x000483FC
	// (remove) Token: 0x06000F13 RID: 3859 RVA: 0x0004A234 File Offset: 0x00048434
	public event AchievementHandler.AchievementAwarded AwardAchievementEvent;

	// Token: 0x06000F14 RID: 3860 RVA: 0x0004A269 File Offset: 0x00048469
	private void Awake()
	{
		this.achievementsList = UnityEngine.Object.Instantiate<AchievementsList>(this.achievementsListPrefab, base.transform);
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x0004A282 File Offset: 0x00048482
	private void Start()
	{
		this.gm = GameManager.instance;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x0004A290 File Offset: 0x00048490
	public void AwardAchievementToPlayer(string key)
	{
		if (this.achievementsList.FindAchievement(key) != null)
		{
			if (this.CanAwardAchievement(key) && !Platform.Current.IsAchievementUnlocked(key).GetValueOrDefault())
			{
				Platform.Current.PushAchievementUnlock(key);
				if (this.gm.gameSettings.showNativeAchievementPopups == 1)
				{
					if (this.AwardAchievementEvent != null)
					{
						this.AwardAchievementEvent(key);
						return;
					}
					Debug.LogError("AwardAchievement has no subscribers.");
					return;
				}
			}
		}
		else
		{
			Debug.LogError("No such achievement exists in the AchievementsList: " + key);
		}
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0004A318 File Offset: 0x00048518
	public bool AchievementWasAwarded(string key)
	{
		if (this.achievementsList.FindAchievement(key) != null)
		{
			return Platform.Current.IsAchievementUnlocked(key).GetValueOrDefault();
		}
		Debug.LogError("No such achievement exists in AchievementsList: " + key);
		return false;
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0004A358 File Offset: 0x00048558
	public void ResetAllAchievements()
	{
		Platform.Current.ResetAchievements();
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x0004A364 File Offset: 0x00048564
	public void FlushRecordsToDisk()
	{
		Platform.Current.SharedData.Save();
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0004A375 File Offset: 0x00048575
	public void QueueAchievement(string key)
	{
		if (!this.queuedAchievements.Contains(key))
		{
			this.queuedAchievements.Add(key);
		}
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0004A394 File Offset: 0x00048594
	public void AwardQueuedAchievements()
	{
		foreach (string key in this.queuedAchievements)
		{
			this.AwardAchievementToPlayer(key);
		}
		this.queuedAchievements.Clear();
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x0004A3F4 File Offset: 0x000485F4
	public void AwardAllAchievements()
	{
		foreach (Achievement achievement in this.achievementsList.achievements)
		{
			this.AwardAchievementToPlayer(achievement.key);
		}
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0004A454 File Offset: 0x00048654
	private bool CanAwardAchievement(string key)
	{
		if (GameManager.instance)
		{
			string currentMapZone = GameManager.instance.GetCurrentMapZone();
			if (this.achievementWhiteLists.ContainsKey(currentMapZone))
			{
				if (this.achievementWhiteLists[currentMapZone].Contains(key))
				{
					return true;
				}
				Debug.LogWarning(string.Format("Achievement <b>{0}</b> can not be awarded in map zone <b>{1}</b>", key, currentMapZone));
				return false;
			}
		}
		return true;
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0004A4B0 File Offset: 0x000486B0
	public AchievementHandler()
	{
		this.queuedAchievements = new List<string>();
		this.achievementWhiteLists = new Dictionary<string, List<string>>
		{
			{
				"GODS_GLORY",
				new List<string>
				{
					"PANTHEON1",
					"PANTHEON2",
					"PANTHEON3",
					"PANTHEON4",
					"ENDINGD",
					"COMPLETIONGG"
				}
			}
		};
		base..ctor();
	}

	// Token: 0x04000FD7 RID: 4055
	private GameManager gm;

	// Token: 0x04000FD9 RID: 4057
	public AchievementsList achievementsListPrefab;

	// Token: 0x04000FDA RID: 4058
	public Sprite hiddenAchievementIcon;

	// Token: 0x04000FDC RID: 4060
	private List<string> queuedAchievements;

	// Token: 0x04000FDD RID: 4061
	private Dictionary<string, List<string>> achievementWhiteLists;

	// Token: 0x020002D2 RID: 722
	// (Invoke) Token: 0x06000F20 RID: 3872
	public delegate void AchievementAwarded(string key);
}
