using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200001A RID: 26
public static class ObjectPoolExtensions
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00004CE8 File Offset: 0x00002EE8
	public static void CreatePool<T>(this T prefab) where T : Component
	{
		ObjectPool.CreatePool<T>(prefab, 0);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00004CF1 File Offset: 0x00002EF1
	public static void CreatePool<T>(this T prefab, int initialPoolSize) where T : Component
	{
		ObjectPool.CreatePool<T>(prefab, initialPoolSize);
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00004CFA File Offset: 0x00002EFA
	public static void CreatePool(this GameObject prefab)
	{
		ObjectPool.CreatePool(prefab, 0);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00004D03 File Offset: 0x00002F03
	public static void CreatePool(this GameObject prefab, int initialPoolSize)
	{
		ObjectPool.CreatePool(prefab, initialPoolSize);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00004D0C File Offset: 0x00002F0C
	public static T Spawn<T>(this T prefab, Transform parent, Vector3 position, Quaternion rotation) where T : Component
	{
		return ObjectPool.Spawn<T>(prefab, parent, position, rotation);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00004D17 File Offset: 0x00002F17
	public static T Spawn<T>(this T prefab, Vector3 position, Quaternion rotation) where T : Component
	{
		return ObjectPool.Spawn<T>(prefab, null, position, rotation);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00004D22 File Offset: 0x00002F22
	public static T Spawn<T>(this T prefab, Transform parent, Vector3 position) where T : Component
	{
		return ObjectPool.Spawn<T>(prefab, parent, position, Quaternion.identity);
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00004D31 File Offset: 0x00002F31
	public static T Spawn<T>(this T prefab, Vector3 position) where T : Component
	{
		return ObjectPool.Spawn<T>(prefab, null, position, Quaternion.identity);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00004D40 File Offset: 0x00002F40
	public static T Spawn<T>(this T prefab, Transform parent) where T : Component
	{
		return ObjectPool.Spawn<T>(prefab, parent, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00004D53 File Offset: 0x00002F53
	public static T Spawn<T>(this T prefab) where T : Component
	{
		return ObjectPool.Spawn<T>(prefab, null, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00004D66 File Offset: 0x00002F66
	public static GameObject Spawn(this GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
	{
		return ObjectPool.Spawn(prefab, parent, position, rotation);
	}

	// Token: 0x060000AC RID: 172 RVA: 0x0000431B File Offset: 0x0000251B
	public static GameObject Spawn(this GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return ObjectPool.Spawn(prefab, null, position, rotation);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x0000430C File Offset: 0x0000250C
	public static GameObject Spawn(this GameObject prefab, Transform parent, Vector3 position)
	{
		return ObjectPool.Spawn(prefab, parent, position, Quaternion.identity);
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00004339 File Offset: 0x00002539
	public static GameObject Spawn(this GameObject prefab, Vector3 position)
	{
		return ObjectPool.Spawn(prefab, null, position, Quaternion.identity);
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00004326 File Offset: 0x00002526
	public static GameObject Spawn(this GameObject prefab, Transform parent)
	{
		return ObjectPool.Spawn(prefab, parent, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00004348 File Offset: 0x00002548
	public static GameObject Spawn(this GameObject prefab)
	{
		return ObjectPool.Spawn(prefab, null, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00004D71 File Offset: 0x00002F71
	public static void Recycle<T>(this T obj) where T : Component
	{
		ObjectPool.Recycle<T>(obj);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00004D79 File Offset: 0x00002F79
	public static void Recycle(this GameObject obj)
	{
		ObjectPool.Recycle(obj);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00004D81 File Offset: 0x00002F81
	public static void RecycleAll<T>(this T prefab) where T : Component
	{
		ObjectPool.RecycleAll<T>(prefab);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00004D89 File Offset: 0x00002F89
	public static void RecycleAll(this GameObject prefab)
	{
		ObjectPool.RecycleAll(prefab);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00004D91 File Offset: 0x00002F91
	public static int CountPooled<T>(this T prefab) where T : Component
	{
		return ObjectPool.CountPooled<T>(prefab);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00004D99 File Offset: 0x00002F99
	public static int CountPooled(this GameObject prefab)
	{
		return ObjectPool.CountPooled(prefab);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00004DA1 File Offset: 0x00002FA1
	public static int CountSpawned<T>(this T prefab) where T : Component
	{
		return ObjectPool.CountSpawned<T>(prefab);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00004DA9 File Offset: 0x00002FA9
	public static int CountSpawned(this GameObject prefab)
	{
		return ObjectPool.CountSpawned(prefab);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00004DB1 File Offset: 0x00002FB1
	public static List<GameObject> GetSpawned(this GameObject prefab, List<GameObject> list, bool appendList)
	{
		return ObjectPool.GetSpawned(prefab, list, appendList);
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00004DBB File Offset: 0x00002FBB
	public static List<GameObject> GetSpawned(this GameObject prefab, List<GameObject> list)
	{
		return ObjectPool.GetSpawned(prefab, list, false);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00004DC5 File Offset: 0x00002FC5
	public static List<GameObject> GetSpawned(this GameObject prefab)
	{
		return ObjectPool.GetSpawned(prefab, null, false);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00004DCF File Offset: 0x00002FCF
	public static List<T> GetSpawned<T>(this T prefab, List<T> list, bool appendList) where T : Component
	{
		return ObjectPool.GetSpawned<T>(prefab, list, appendList);
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00004DD9 File Offset: 0x00002FD9
	public static List<T> GetSpawned<T>(this T prefab, List<T> list) where T : Component
	{
		return ObjectPool.GetSpawned<T>(prefab, list, false);
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00004DE3 File Offset: 0x00002FE3
	public static List<T> GetSpawned<T>(this T prefab) where T : Component
	{
		return ObjectPool.GetSpawned<T>(prefab, null, false);
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00004DED File Offset: 0x00002FED
	public static List<GameObject> GetPooled(this GameObject prefab, List<GameObject> list, bool appendList)
	{
		return ObjectPool.GetPooled(prefab, list, appendList);
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00004DF7 File Offset: 0x00002FF7
	public static List<GameObject> GetPooled(this GameObject prefab, List<GameObject> list)
	{
		return ObjectPool.GetPooled(prefab, list, false);
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00004E01 File Offset: 0x00003001
	public static List<GameObject> GetPooled(this GameObject prefab)
	{
		return ObjectPool.GetPooled(prefab, null, false);
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00004E0B File Offset: 0x0000300B
	public static List<T> GetPooled<T>(this T prefab, List<T> list, bool appendList) where T : Component
	{
		return ObjectPool.GetPooled<T>(prefab, list, appendList);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00004E15 File Offset: 0x00003015
	public static List<T> GetPooled<T>(this T prefab, List<T> list) where T : Component
	{
		return ObjectPool.GetPooled<T>(prefab, list, false);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00004E1F File Offset: 0x0000301F
	public static List<T> GetPooled<T>(this T prefab) where T : Component
	{
		return ObjectPool.GetPooled<T>(prefab, null, false);
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00004E29 File Offset: 0x00003029
	public static void DestroyPooled(this GameObject prefab)
	{
		ObjectPool.DestroyPooled(prefab);
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00004890 File Offset: 0x00002A90
	public static void DestroyPooled<T>(this T prefab) where T : Component
	{
		ObjectPool.DestroyPooled(prefab.gameObject);
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00004E31 File Offset: 0x00003031
	public static void DestroyAll(this GameObject prefab)
	{
		ObjectPool.DestroyAll(prefab);
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00004914 File Offset: 0x00002B14
	public static void DestroyAll<T>(this T prefab) where T : Component
	{
		ObjectPool.DestroyAll(prefab.gameObject);
	}
}
