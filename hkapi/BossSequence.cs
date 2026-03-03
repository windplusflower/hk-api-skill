using System;
using UnityEngine;

// Token: 0x02000231 RID: 561
[CreateAssetMenu(fileName = "New Boss Sequence", menuName = "Hollow Knight/Boss Sequence List")]
public class BossSequence : ScriptableObject
{
	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0003DC9A File Offset: 0x0003BE9A
	public int Count
	{
		get
		{
			return this.bossScenes.Length;
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0003DCA4 File Offset: 0x0003BEA4
	public string GetSceneAt(int index)
	{
		return this.GetBossScene(index).sceneName;
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0003DCB2 File Offset: 0x0003BEB2
	public string GetSceneObjectName(int index)
	{
		return this.GetBossScene(index).name;
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0003DCC0 File Offset: 0x0003BEC0
	public bool CanLoad(int index)
	{
		return !this.GetBossScene(index).isHidden || this.GetBossScene(index).IsUnlocked(BossSceneCheckSource.Sequence);
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x0003DCE0 File Offset: 0x0003BEE0
	public BossScene GetBossScene(int index)
	{
		BossScene bossScene = this.bossScenes[index];
		if (!bossScene.IsUnlockedSelf(BossSceneCheckSource.Sequence) && bossScene.baseBoss && bossScene.substituteBoss)
		{
			bossScene = bossScene.baseBoss;
		}
		return bossScene;
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x0003DD1C File Offset: 0x0003BF1C
	public bool IsUnlocked()
	{
		if (this.useSceneUnlocks)
		{
			foreach (BossScene bossScene in this.bossScenes)
			{
				if (!bossScene.isHidden && !bossScene.IsUnlocked(BossSceneCheckSource.Sequence))
				{
					return false;
				}
			}
		}
		if (this.tests != null && this.tests.Length != 0)
		{
			BossScene.BossTest[] array2 = this.tests;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].IsUnlocked())
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0003DD92 File Offset: 0x0003BF92
	public bool IsSceneHidden(int index)
	{
		return this.GetBossScene(index).isHidden;
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0003DDA0 File Offset: 0x0003BFA0
	public BossSequence()
	{
		this.useSceneUnlocks = true;
		this.nailDamage = 5;
		this.lowerNailDamagePercentage = 0.8f;
		this.maxHealth = 5;
		base..ctor();
	}

	// Token: 0x04000CD8 RID: 3288
	[SerializeField]
	private BossScene[] bossScenes;

	// Token: 0x04000CD9 RID: 3289
	public bool useSceneUnlocks;

	// Token: 0x04000CDA RID: 3290
	public BossScene.BossTest[] tests;

	// Token: 0x04000CDB RID: 3291
	[Space]
	public string achievementKey;

	// Token: 0x04000CDC RID: 3292
	[Space]
	public string customEndScene;

	// Token: 0x04000CDD RID: 3293
	public string customEndScenePlayerData;

	// Token: 0x04000CDE RID: 3294
	[Header("Bindings")]
	public int nailDamage;

	// Token: 0x04000CDF RID: 3295
	[Tooltip("If nail damage is already at or below the above nailDamage value, use a percentage instead.")]
	[Range(0f, 1f)]
	public float lowerNailDamagePercentage;

	// Token: 0x04000CE0 RID: 3296
	public int maxHealth;
}
