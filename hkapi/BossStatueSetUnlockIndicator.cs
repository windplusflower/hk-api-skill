using System;
using UnityEngine;

// Token: 0x02000268 RID: 616
public class BossStatueSetUnlockIndicator : MonoBehaviour
{
	// Token: 0x06000CF4 RID: 3316 RVA: 0x000416D4 File Offset: 0x0003F8D4
	private void Start()
	{
		foreach (BossStatue bossStatue in UnityEngine.Object.FindObjectsOfType<BossStatue>())
		{
			if (this.CheckIfNewBossStatue(bossStatue.StatueState) || this.CheckIfNewBossStatue(bossStatue.DreamStatueState))
			{
				this.newStatueCount++;
				bossStatue.OnSeenNewStatue += delegate()
				{
					this.newStatueCount--;
					if (this.newStatueCount == 0)
					{
						GameManager.instance.playerData.SetBoolSwappedArgs(false, "unlockedNewBossStatue");
						return;
					}
					if (this.newStatueCount < 0)
					{
						Debug.LogError("New statue count fell below zero. This means something has gone wrong!");
					}
				};
			}
		}
	}

	// Token: 0x06000CF5 RID: 3317 RVA: 0x00041735 File Offset: 0x0003F935
	private bool CheckIfNewBossStatue(BossStatue.Completion completion)
	{
		return completion.isUnlocked && !completion.hasBeenSeen;
	}

	// Token: 0x04000DE2 RID: 3554
	private int newStatueCount;
}
