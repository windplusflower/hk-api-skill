using System;
using UnityEngine;

// Token: 0x02000259 RID: 601
public class BossStatueCompletionStates : MonoBehaviour
{
	// Token: 0x06000CAF RID: 3247 RVA: 0x00040755 File Offset: 0x0003E955
	private void OnValidate()
	{
		ArrayForEnumAttribute.EnsureArraySize<BossStatueCompletionStates.State>(ref this.tierStates, typeof(BossStatueCompletionStates.Tiers));
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x0004076C File Offset: 0x0003E96C
	private void Start()
	{
		BossStatueCompletionStates.Tiers? highestCompletedTier = this.GetHighestCompletedTier();
		if (highestCompletedTier == null)
		{
			this.defaultState.SetActive(true);
			return;
		}
		for (int i = 0; i < this.tierStates.Length; i++)
		{
			this.tierStates[i].SetActive(false);
		}
		for (int j = 0; j < this.tierStates.Length; j++)
		{
			if (j == (int)highestCompletedTier.Value)
			{
				this.tierStates[j].SetActive(true);
			}
		}
	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x000407EC File Offset: 0x0003E9EC
	public BossStatueCompletionStates.Tiers? GetHighestCompletedTier()
	{
		for (int i = Enum.GetNames(typeof(BossStatueCompletionStates.Tiers)).Length - 1; i >= 0; i--)
		{
			if (this.GetIsTierCompleted((BossStatueCompletionStates.Tiers)i))
			{
				return new BossStatueCompletionStates.Tiers?((BossStatueCompletionStates.Tiers)i);
			}
		}
		return null;
	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00040830 File Offset: 0x0003EA30
	public bool GetIsTierCompleted(BossStatueCompletionStates.Tiers tier)
	{
		int num = 0;
		int num2 = 0;
		this.CountCompletion(tier, out num, out num2);
		Debug.Log(string.Format("Counted completion for {0}, Total: {1}, Completed: {2}, Tier: {3}", new object[]
		{
			base.gameObject.name,
			num2,
			num,
			tier.ToString()
		}));
		return num >= num2;
	}

	// Token: 0x06000CB3 RID: 3251 RVA: 0x00040898 File Offset: 0x0003EA98
	public void CountCompletion(BossStatueCompletionStates.Tiers tier, out int completed, out int total)
	{
		completed = 0;
		total = 0;
		foreach (BossStatue bossStatue in this.bossListSource ? this.bossListSource.bossStatues.ToArray() : new BossStatue[0])
		{
			if (bossStatue.gameObject.activeInHierarchy && !bossStatue.hasNoTiers && !bossStatue.dontCountCompletion)
			{
				if (bossStatue.HasRegularVersion)
				{
					total++;
					if (this.HasCompletedTier(bossStatue.StatueState, tier))
					{
						completed++;
					}
				}
				if (bossStatue.HasDreamVersion)
				{
					total++;
					if (this.HasCompletedTier(bossStatue.DreamStatueState, tier))
					{
						completed++;
					}
				}
			}
		}
	}

	// Token: 0x06000CB4 RID: 3252 RVA: 0x0004094C File Offset: 0x0003EB4C
	private bool HasCompletedTier(BossStatue.Completion completion, BossStatueCompletionStates.Tiers tier)
	{
		switch (tier)
		{
		case BossStatueCompletionStates.Tiers.Tier1:
			if (completion.completedTier1)
			{
				return true;
			}
			break;
		case BossStatueCompletionStates.Tiers.Tier2:
			if (completion.completedTier2)
			{
				return true;
			}
			break;
		case BossStatueCompletionStates.Tiers.Tier3:
			if (completion.completedTier3)
			{
				return true;
			}
			break;
		}
		return this.checkTiersAdditive && tier < (BossStatueCompletionStates.Tiers)Enum.GetNames(typeof(BossStatueCompletionStates.Tiers)).Length - 1 && this.HasCompletedTier(completion, tier + 1);
	}

	// Token: 0x06000CB5 RID: 3253 RVA: 0x000409B5 File Offset: 0x0003EBB5
	public BossStatueCompletionStates()
	{
		this.checkTiersAdditive = true;
		base..ctor();
	}

	// Token: 0x04000DA0 RID: 3488
	public BossSummaryBoard bossListSource;

	// Token: 0x04000DA1 RID: 3489
	public BossStatueCompletionStates.State defaultState;

	// Token: 0x04000DA2 RID: 3490
	[ArrayForEnum(typeof(BossStatueCompletionStates.Tiers))]
	public BossStatueCompletionStates.State[] tierStates;

	// Token: 0x04000DA3 RID: 3491
	public bool checkTiersAdditive;

	// Token: 0x0200025A RID: 602
	public enum Tiers
	{
		// Token: 0x04000DA5 RID: 3493
		Tier1,
		// Token: 0x04000DA6 RID: 3494
		Tier2,
		// Token: 0x04000DA7 RID: 3495
		Tier3
	}

	// Token: 0x0200025B RID: 603
	[Serializable]
	public struct State
	{
		// Token: 0x06000CB6 RID: 3254 RVA: 0x000409C4 File Offset: 0x0003EBC4
		public void SetActive(bool value)
		{
			if (this.gameObject)
			{
				this.gameObject.SetActive(value);
				if (value && !string.IsNullOrEmpty(this.playmakerEvent))
				{
					FSMUtility.SendEventToGameObject(this.gameObject, this.playmakerEvent, false);
				}
			}
		}

		// Token: 0x04000DA8 RID: 3496
		[SerializeField]
		private GameObject gameObject;

		// Token: 0x04000DA9 RID: 3497
		[SerializeField]
		private string playmakerEvent;
	}
}
