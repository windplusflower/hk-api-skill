using System;
using UnityEngine;

// Token: 0x0200029E RID: 670
public class GodfinderInvIcon : MonoBehaviour
{
	// Token: 0x06000E0A RID: 3594 RVA: 0x000450DE File Offset: 0x000432DE
	private void Awake()
	{
		this.spriteRenderer = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x000450EC File Offset: 0x000432EC
	private void OnEnable()
	{
		if (this.spriteRenderer)
		{
			if (!GameManager.instance.playerData.GetBool("bossRushMode"))
			{
				this.spriteRenderer.sprite = (GameManager.instance.playerData.GetBool("unlockedNewBossStatue") ? this.newBossSprite : this.normalSprite);
				BossScene[] array = this.bosses;
				for (int i = 0; i < array.Length; i++)
				{
					if (!array[i].IsUnlocked(BossSceneCheckSource.Godfinder))
					{
						return;
					}
				}
				GodfinderInvIcon.BossSceneExtra[] array2 = this.extraBosses;
				for (int i = 0; i < array2.Length; i++)
				{
					if (!array2[i].IsUnlocked())
					{
						return;
					}
				}
			}
			this.spriteRenderer.sprite = this.allBossesSprite;
		}
	}

	// Token: 0x04000EDE RID: 3806
	public Sprite normalSprite;

	// Token: 0x04000EDF RID: 3807
	public Sprite newBossSprite;

	// Token: 0x04000EE0 RID: 3808
	public Sprite allBossesSprite;

	// Token: 0x04000EE1 RID: 3809
	[Tooltip("Once all listed bosses are unlocked, godfinder is in complete state.")]
	public BossScene[] bosses;

	// Token: 0x04000EE2 RID: 3810
	[Tooltip("Boss scenes with conditions as to whether they are counted or not.")]
	public GodfinderInvIcon.BossSceneExtra[] extraBosses;

	// Token: 0x04000EE3 RID: 3811
	private SpriteRenderer spriteRenderer;

	// Token: 0x0200029F RID: 671
	[Serializable]
	public class BossSceneExtra
	{
		// Token: 0x06000E0D RID: 3597 RVA: 0x000451A4 File Offset: 0x000433A4
		public bool IsUnlocked()
		{
			if (this.extraTests != null)
			{
				BossScene.BossTest[] array = this.extraTests;
				for (int i = 0; i < array.Length; i++)
				{
					if (!array[i].IsUnlocked())
					{
						return true;
					}
				}
			}
			return this.bossScene && this.bossScene.IsUnlocked(BossSceneCheckSource.Godfinder);
		}

		// Token: 0x04000EE4 RID: 3812
		public BossScene bossScene;

		// Token: 0x04000EE5 RID: 3813
		[Tooltip("If any of these tests fail the boss scene will be skipped.")]
		public BossScene.BossTest[] extraTests;
	}
}
