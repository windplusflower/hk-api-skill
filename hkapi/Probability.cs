using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200038E RID: 910
public class Probability
{
	// Token: 0x0600151B RID: 5403 RVA: 0x00064460 File Offset: 0x00062660
	public static GameObject GetRandomGameObjectByProbability(Probability.ProbabilityGameObject[] array)
	{
		if (array.Length > 1)
		{
			List<Probability.ProbabilityGameObject> list = new List<Probability.ProbabilityGameObject>(array);
			Probability.ProbabilityGameObject probabilityGameObject = null;
			list.Sort((Probability.ProbabilityGameObject x, Probability.ProbabilityGameObject y) => x.probability.CompareTo(y.probability));
			float num = 0f;
			foreach (Probability.ProbabilityGameObject probabilityGameObject2 in list)
			{
				num += ((probabilityGameObject2.probability != 0f) ? probabilityGameObject2.probability : 1f);
			}
			float num2 = UnityEngine.Random.Range(0f, num);
			float num3 = 0f;
			foreach (Probability.ProbabilityGameObject probabilityGameObject3 in list)
			{
				if (num2 >= num3)
				{
					probabilityGameObject = probabilityGameObject3;
				}
				num3 += probabilityGameObject3.probability;
			}
			return probabilityGameObject.prefab;
		}
		if (array.Length == 1)
		{
			return array[0].prefab;
		}
		return null;
	}

	// Token: 0x0200038F RID: 911
	[Serializable]
	public class ProbabilityGameObject
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x0006457C File Offset: 0x0006277C
		public ProbabilityGameObject()
		{
			this.probability = 1f;
		}

		// Token: 0x04001932 RID: 6450
		public GameObject prefab;

		// Token: 0x04001933 RID: 6451
		[Tooltip("If probability = 0, it will be considered 1.")]
		public float probability;
	}
}
