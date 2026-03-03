using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000354 RID: 852
[CreateAssetMenu(fileName = "AchievementIDMap", menuName = "Hollow Knight/Achievement ID Map", order = 1900)]
public class AchievementIDMap : ScriptableObject
{
	// Token: 0x0600135C RID: 4956 RVA: 0x0005807C File Offset: 0x0005627C
	public int? GetServiceIdForInternalId(string internalId)
	{
		if (this.serviceIdsByInternalId == null)
		{
			this.serviceIdsByInternalId = new Dictionary<string, int>();
			for (int i = 0; i < this.pairs.Length; i++)
			{
				AchievementIDMap.AchievementIDPair achievementIDPair = this.pairs[i];
				this.serviceIdsByInternalId.Add(achievementIDPair.InternalId, achievementIDPair.ServiceId);
			}
		}
		int value;
		if (!this.serviceIdsByInternalId.TryGetValue(internalId, out value))
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x04001296 RID: 4758
	[SerializeField]
	private AchievementIDMap.AchievementIDPair[] pairs;

	// Token: 0x04001297 RID: 4759
	private Dictionary<string, int> serviceIdsByInternalId;

	// Token: 0x02000355 RID: 853
	[Serializable]
	public class AchievementIDPair
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x000580EF File Offset: 0x000562EF
		public string InternalId
		{
			get
			{
				return this.internalId;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x000580F7 File Offset: 0x000562F7
		public int ServiceId
		{
			get
			{
				return this.serviceId;
			}
		}

		// Token: 0x04001298 RID: 4760
		[SerializeField]
		[FormerlySerializedAs("achievementId")]
		private string internalId;

		// Token: 0x04001299 RID: 4761
		[SerializeField]
		[FormerlySerializedAs("trophyId")]
		private int serviceId;
	}
}
