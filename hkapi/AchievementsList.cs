using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200010F RID: 271
[Serializable]
public class AchievementsList : MonoBehaviour
{
	// Token: 0x0600068F RID: 1679 RVA: 0x00026A3C File Offset: 0x00024C3C
	public Achievement FindAchievement(string key)
	{
		for (int i = 0; i < this.achievements.Count; i++)
		{
			if (string.Equals(this.achievements[i].key, key))
			{
				return this.achievements[i];
			}
		}
		return null;
	}

	// Token: 0x06000690 RID: 1680 RVA: 0x00026A88 File Offset: 0x00024C88
	public bool AchievementExists(string key)
	{
		for (int i = 0; i < this.achievements.Count; i++)
		{
			if (string.Equals(this.achievements[i].key, key))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000691 RID: 1681 RVA: 0x00026AC7 File Offset: 0x00024CC7
	public AchievementsList()
	{
		this.achievements = new List<Achievement>();
		base..ctor();
	}

	// Token: 0x04000707 RID: 1799
	public List<Achievement> achievements;
}
