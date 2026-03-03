using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000480 RID: 1152
public class MenuAchievementsList : MonoBehaviour
{
	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0007D44F File Offset: 0x0007B64F
	// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0007D457 File Offset: 0x0007B657
	[SerializeField]
	public bool init { get; private set; }

	// Token: 0x060019F8 RID: 6648 RVA: 0x0007D460 File Offset: 0x0007B660
	public void AddMenuAchievement(MenuAchievement achievement)
	{
		this.menuAchievementsList.Add(achievement);
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x0007D470 File Offset: 0x0007B670
	public MenuAchievement FindAchievement(string key)
	{
		for (int i = 0; i < this.menuAchievementsList.Count; i++)
		{
			if (this.menuAchievementsList[i].name == key)
			{
				return this.menuAchievementsList[i];
			}
		}
		return null;
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x0007D4BA File Offset: 0x0007B6BA
	public void MarkInit()
	{
		this.init = true;
	}

	// Token: 0x04001F5E RID: 8030
	public MenuAchievement menuAchievementPrefab;

	// Token: 0x04001F60 RID: 8032
	[SerializeField]
	private List<MenuAchievement> menuAchievementsList;
}
