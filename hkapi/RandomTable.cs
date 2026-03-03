using System;
using UnityEngine;

// Token: 0x020004ED RID: 1261
public static class RandomTable
{
	// Token: 0x06001BD9 RID: 7129 RVA: 0x000847C8 File Offset: 0x000829C8
	public static bool TrySelectValue<Ty>(this Ty[] items, out Ty value) where Ty : WeightedItem
	{
		if (items.Length == 0)
		{
			value = default(Ty);
			return false;
		}
		float num = 0f;
		foreach (Ty ty in items)
		{
			num += ty.Weight;
		}
		float num2 = UnityEngine.Random.Range(0f, num);
		float num3 = 0f;
		for (int j = 0; j < items.Length - 1; j++)
		{
			Ty ty2 = items[j];
			num3 += ty2.Weight;
			if (num2 < num3)
			{
				value = ty2;
				return true;
			}
		}
		value = items[items.Length - 1];
		return true;
	}

	// Token: 0x06001BDA RID: 7130 RVA: 0x00084870 File Offset: 0x00082A70
	public static Ty SelectValue<Ty>(this Ty[] items) where Ty : WeightedItem
	{
		Ty result;
		if (!items.TrySelectValue(out result))
		{
			return default(Ty);
		}
		return result;
	}
}
