using System;
using UnityEngine;

// Token: 0x020004DF RID: 1247
public static class FlingUtils
{
	// Token: 0x06001BB1 RID: 7089 RVA: 0x00083F64 File Offset: 0x00082164
	public static GameObject[] SpawnAndFling(FlingUtils.Config config, Transform spawnPoint, Vector3 positionOffset)
	{
		if (config.Prefab == null)
		{
			return null;
		}
		int num = UnityEngine.Random.Range(config.AmountMin, config.AmountMax + 1);
		Vector3 a = (spawnPoint != null) ? spawnPoint.TransformPoint(positionOffset) : positionOffset;
		GameObject[] array = new GameObject[num];
		for (int i = 0; i < num; i++)
		{
			Vector3 position = a + new Vector3(UnityEngine.Random.Range(-config.OriginVariationX, config.OriginVariationX), UnityEngine.Random.Range(-config.OriginVariationY, config.OriginVariationY), 0f);
			GameObject gameObject = config.Prefab.Spawn(position);
			Rigidbody2D component = gameObject.GetComponent<Rigidbody2D>();
			if (component != null)
			{
				float d = UnityEngine.Random.Range(config.SpeedMin, config.SpeedMax);
				float num2 = UnityEngine.Random.Range(config.AngleMin, config.AngleMax);
				component.velocity = new Vector2(Mathf.Cos(num2 * 0.017453292f), Mathf.Sin(num2 * 0.017453292f)) * d;
			}
			array[i] = gameObject;
		}
		return array;
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x00084074 File Offset: 0x00082274
	public static void FlingChildren(FlingUtils.ChildrenConfig config, Transform spawnPoint, Vector3 positionOffset)
	{
		if (config.Parent == null)
		{
			return;
		}
		Vector3 a = (spawnPoint != null) ? spawnPoint.TransformPoint(positionOffset) : positionOffset;
		int num = (config.AmountMax > 0) ? UnityEngine.Random.Range(config.AmountMin, config.AmountMax) : config.Parent.transform.childCount;
		for (int i = 0; i < num; i++)
		{
			Transform child = config.Parent.transform.GetChild(i);
			child.gameObject.SetActive(true);
			a + new Vector3(UnityEngine.Random.Range(-config.OriginVariationX, config.OriginVariationX), UnityEngine.Random.Range(-config.OriginVariationY, config.OriginVariationY), 0f);
			Rigidbody2D component = child.GetComponent<Rigidbody2D>();
			if (component != null)
			{
				float d = UnityEngine.Random.Range(config.SpeedMin, config.SpeedMax);
				float num2 = UnityEngine.Random.Range(config.AngleMin, config.AngleMax);
				component.velocity = new Vector2(Mathf.Cos(num2 * 0.017453292f), Mathf.Sin(num2 * 0.017453292f)) * d;
			}
		}
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00084198 File Offset: 0x00082398
	public static void FlingObject(FlingUtils.SelfConfig config, Transform spawnPoint, Vector3 positionOffset)
	{
		if (config.Object == null)
		{
			return;
		}
		if (spawnPoint != null)
		{
			spawnPoint.TransformPoint(positionOffset);
		}
		Rigidbody2D component = config.Object.GetComponent<Rigidbody2D>();
		if (component != null)
		{
			float d = UnityEngine.Random.Range(config.SpeedMin, config.SpeedMax);
			float num = UnityEngine.Random.Range(config.AngleMin, config.AngleMax);
			component.velocity = new Vector2(Mathf.Cos(num * 0.017453292f), Mathf.Sin(num * 0.017453292f)) * d;
		}
	}

	// Token: 0x020004E0 RID: 1248
	[Serializable]
	public struct Config
	{
		// Token: 0x0400219E RID: 8606
		public GameObject Prefab;

		// Token: 0x0400219F RID: 8607
		public float SpeedMin;

		// Token: 0x040021A0 RID: 8608
		public float SpeedMax;

		// Token: 0x040021A1 RID: 8609
		public float AngleMin;

		// Token: 0x040021A2 RID: 8610
		public float AngleMax;

		// Token: 0x040021A3 RID: 8611
		public float OriginVariationX;

		// Token: 0x040021A4 RID: 8612
		public float OriginVariationY;

		// Token: 0x040021A5 RID: 8613
		public int AmountMin;

		// Token: 0x040021A6 RID: 8614
		public int AmountMax;
	}

	// Token: 0x020004E1 RID: 1249
	public struct ChildrenConfig
	{
		// Token: 0x040021A7 RID: 8615
		public GameObject Parent;

		// Token: 0x040021A8 RID: 8616
		public int AmountMin;

		// Token: 0x040021A9 RID: 8617
		public int AmountMax;

		// Token: 0x040021AA RID: 8618
		public float SpeedMin;

		// Token: 0x040021AB RID: 8619
		public float SpeedMax;

		// Token: 0x040021AC RID: 8620
		public float AngleMin;

		// Token: 0x040021AD RID: 8621
		public float AngleMax;

		// Token: 0x040021AE RID: 8622
		public float OriginVariationX;

		// Token: 0x040021AF RID: 8623
		public float OriginVariationY;
	}

	// Token: 0x020004E2 RID: 1250
	public struct SelfConfig
	{
		// Token: 0x040021B0 RID: 8624
		public GameObject Object;

		// Token: 0x040021B1 RID: 8625
		public float SpeedMin;

		// Token: 0x040021B2 RID: 8626
		public float SpeedMax;

		// Token: 0x040021B3 RID: 8627
		public float AngleMin;

		// Token: 0x040021B4 RID: 8628
		public float AngleMax;
	}
}
