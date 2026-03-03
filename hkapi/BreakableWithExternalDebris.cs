using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200039F RID: 927
public class BreakableWithExternalDebris : Breakable
{
	// Token: 0x0600155E RID: 5470 RVA: 0x0006603C File Offset: 0x0006423C
	protected override void CreateAdditionalDebrisParts(List<GameObject> debrisParts)
	{
		base.CreateAdditionalDebrisParts(debrisParts);
		for (int i = 0; i < this.externalDebris.Length; i++)
		{
			this.Spawn(this.externalDebris[i], debrisParts);
		}
		BreakableWithExternalDebris.WeightedExternalDebrisItem weightedExternalDebrisItem = this.externalDebrisVariants.SelectValue<BreakableWithExternalDebris.WeightedExternalDebrisItem>();
		if (weightedExternalDebrisItem != null)
		{
			this.Spawn(weightedExternalDebrisItem.Value, debrisParts);
		}
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x00066094 File Offset: 0x00064294
	private void Spawn(BreakableWithExternalDebris.ExternalDebris externalDebris, List<GameObject> debrisParts)
	{
		for (int i = 0; i < externalDebris.Count; i++)
		{
			if (!(externalDebris.Prefab == null))
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(externalDebris.Prefab);
				gameObject.GetComponents<IExternalDebris>(BreakableWithExternalDebris.externalDebrisResponders);
				for (int j = 0; j < BreakableWithExternalDebris.externalDebrisResponders.Count; j++)
				{
					BreakableWithExternalDebris.externalDebrisResponders[j].InitExternalDebris();
				}
				BreakableWithExternalDebris.externalDebrisResponders.Clear();
				gameObject.transform.position = base.transform.position + new Vector3(UnityEngine.Random.Range(-this.debrisPrefabPositionVariance, this.debrisPrefabPositionVariance), UnityEngine.Random.Range(-this.debrisPrefabPositionVariance, this.debrisPrefabPositionVariance), 0f);
				gameObject.SetActive(false);
				debrisParts.Add(gameObject);
			}
		}
	}

	// Token: 0x06001561 RID: 5473 RVA: 0x0006616E File Offset: 0x0006436E
	// Note: this type is marked as 'beforefieldinit'.
	static BreakableWithExternalDebris()
	{
		BreakableWithExternalDebris.externalDebrisResponders = new List<IExternalDebris>();
	}

	// Token: 0x040019A7 RID: 6567
	[SerializeField]
	private float debrisPrefabPositionVariance;

	// Token: 0x040019A8 RID: 6568
	[SerializeField]
	private BreakableWithExternalDebris.ExternalDebris[] externalDebris;

	// Token: 0x040019A9 RID: 6569
	[SerializeField]
	private BreakableWithExternalDebris.WeightedExternalDebrisItem[] externalDebrisVariants;

	// Token: 0x040019AA RID: 6570
	private static List<IExternalDebris> externalDebrisResponders;

	// Token: 0x020003A0 RID: 928
	[Serializable]
	public struct ExternalDebris
	{
		// Token: 0x040019AB RID: 6571
		public GameObject Prefab;

		// Token: 0x040019AC RID: 6572
		public int Count;
	}

	// Token: 0x020003A1 RID: 929
	[Serializable]
	public class WeightedExternalDebrisItem : WeightedItem
	{
		// Token: 0x040019AD RID: 6573
		public BreakableWithExternalDebris.ExternalDebris Value;
	}
}
