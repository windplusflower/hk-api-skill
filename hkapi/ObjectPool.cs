using System;
using System.Collections.Generic;
using Modding;
using UnityEngine;

// Token: 0x02000018 RID: 24
public sealed class ObjectPool : MonoBehaviour
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000073 RID: 115 RVA: 0x00003E8C File Offset: 0x0000208C
	public static ObjectPool instance
	{
		get
		{
			if (ObjectPool._instance == null)
			{
				ObjectPool._instance = UnityEngine.Object.FindObjectOfType<ObjectPool>();
				if (ObjectPool._instance == null)
				{
					Debug.LogError("Couldn't find an Object Pool, make sure a Game Manager exists in the scene.");
				}
				else
				{
					UnityEngine.Object.DontDestroyOnLoad(ObjectPool._instance.gameObject);
				}
			}
			return ObjectPool._instance;
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00003EE0 File Offset: 0x000020E0
	private void Awake()
	{
		if (ObjectPool._instance == null)
		{
			ObjectPool._instance = this;
			UnityEngine.Object.DontDestroyOnLoad(this);
			return;
		}
		if (!(this != ObjectPool._instance))
		{
			return;
		}
		Debug.LogErrorFormat("An extra Global Object Pool has been created by {0} please remove this script. Master Object Pool: {1} (Scene: {2} at time: {3})", new object[]
		{
			base.transform.parent.name,
			ObjectPool._instance.name,
			Application.loadedLevelName,
			Time.realtimeSinceStartup
		});
		if (base.transform.parent.name == "_GameManager")
		{
			Debug.Log("Object Pool instance is no longer set to master object pool, another Object Pool exists in this scene. Instance currently set to : " + ObjectPool._instance.name);
			ObjectPool._instance = this;
			return;
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00003FA4 File Offset: 0x000021A4
	private void Start()
	{
		if (!ObjectPool.instance.startupPoolsCreated)
		{
			ObjectPool.CreateStartupPools();
			return;
		}
		for (int i = 0; i < this.startupPools.Length; i++)
		{
			this.startupPools[i].prefab.CreatePool(this.startupPools[i].size);
		}
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00003FF8 File Offset: 0x000021F8
	public static void CreateStartupPools()
	{
		if (!ObjectPool.instance.startupPoolsCreated)
		{
			ObjectPool.instance.startupPoolsCreated = true;
			ObjectPool.StartupPool[] array = ObjectPool.instance.startupPools;
			if (array != null && array.Length != 0)
			{
				for (int i = 0; i < array.Length; i++)
				{
					ObjectPool.CreatePool(array[i].prefab, array[i].size);
				}
			}
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00004051 File Offset: 0x00002251
	public static void CreatePool<T>(T prefab, int initialPoolSize) where T : Component
	{
		ObjectPool.CreatePool(prefab.gameObject, initialPoolSize);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00004064 File Offset: 0x00002264
	public static void CreatePool(GameObject prefab, int initialPoolSize)
	{
		try
		{
			ObjectPool.orig_CreatePool(prefab, initialPoolSize);
		}
		catch (NullReferenceException obj) when (!ModLoader.LoadState.HasFlag(ModLoader.ModLoadState.Preloaded))
		{
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000040B8 File Offset: 0x000022B8
	public void RevertToStartState()
	{
		ObjectPool.RecycleAll();
		List<GameObject> list = new List<GameObject>();
		using (Dictionary<GameObject, List<GameObject>>.Enumerator enumerator = this.pooledObjects.GetEnumerator())
		{
			IL_BE:
			while (enumerator.MoveNext())
			{
				KeyValuePair<GameObject, List<GameObject>> keyValuePair = enumerator.Current;
				GameObject key = keyValuePair.Key;
				List<GameObject> value = keyValuePair.Value;
				int num = 0;
				int i = 0;
				while (i < this.startupPools.Length)
				{
					ObjectPool.StartupPool startupPool = this.startupPools[i];
					if (startupPool.prefab == key)
					{
						num = startupPool.size;
						IL_8B:
						while (value.Count > num)
						{
							UnityEngine.Object.Destroy(value[0]);
							value.RemoveAt(0);
						}
						if (value.Count < num)
						{
							ObjectPool.CreatePool(key, num - value.Count);
							goto IL_BE;
						}
						if (num == 0)
						{
							list.Add(key);
							goto IL_BE;
						}
						goto IL_BE;
					}
					else
					{
						i++;
					}
				}
				goto IL_8B;
			}
		}
		foreach (GameObject key2 in list)
		{
			this.pooledObjects.Remove(key2);
		}
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000041F8 File Offset: 0x000023F8
	public static T Spawn<T>(T prefab, Transform parent, Vector3 position, Quaternion rotation) where T : Component
	{
		return ObjectPool.Spawn(prefab.gameObject, parent, position, rotation).GetComponent<T>();
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00004212 File Offset: 0x00002412
	public static T Spawn<T>(T prefab, Vector3 position, Quaternion rotation) where T : Component
	{
		return ObjectPool.Spawn(prefab.gameObject, null, position, rotation).GetComponent<T>();
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000422C File Offset: 0x0000242C
	public static T Spawn<T>(T prefab, Transform parent, Vector3 position) where T : Component
	{
		return ObjectPool.Spawn(prefab.gameObject, parent, position, Quaternion.identity).GetComponent<T>();
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0000424A File Offset: 0x0000244A
	public static T Spawn<T>(T prefab, Vector3 position) where T : Component
	{
		return ObjectPool.Spawn(prefab.gameObject, null, position, Quaternion.identity).GetComponent<T>();
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00004268 File Offset: 0x00002468
	public static T Spawn<T>(T prefab, Transform parent) where T : Component
	{
		return ObjectPool.Spawn(prefab.gameObject, parent, Vector3.zero, Quaternion.identity).GetComponent<T>();
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000428A File Offset: 0x0000248A
	public static T Spawn<T>(T prefab) where T : Component
	{
		return ObjectPool.Spawn(prefab.gameObject, null, Vector3.zero, Quaternion.identity).GetComponent<T>();
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000042AC File Offset: 0x000024AC
	public static GameObject Spawn(GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
	{
		GameObject result;
		try
		{
			result = ModHooks.OnObjectPoolSpawn(ObjectPool.orig_Spawn(prefab, parent, position, rotation));
		}
		catch (NullReferenceException obj) when (!ModLoader.LoadState.HasFlag(ModLoader.ModLoadState.Preloaded))
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0000430C File Offset: 0x0000250C
	public static GameObject Spawn(GameObject prefab, Transform parent, Vector3 position)
	{
		return ObjectPool.Spawn(prefab, parent, position, Quaternion.identity);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x0000431B File Offset: 0x0000251B
	public static GameObject Spawn(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return ObjectPool.Spawn(prefab, null, position, rotation);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00004326 File Offset: 0x00002526
	public static GameObject Spawn(GameObject prefab, Transform parent)
	{
		return ObjectPool.Spawn(prefab, parent, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00004339 File Offset: 0x00002539
	public static GameObject Spawn(GameObject prefab, Vector3 position)
	{
		return ObjectPool.Spawn(prefab, null, position, Quaternion.identity);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00004348 File Offset: 0x00002548
	public static GameObject Spawn(GameObject prefab)
	{
		return ObjectPool.Spawn(prefab, null, Vector3.zero, Quaternion.identity);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x0000435B File Offset: 0x0000255B
	public static void Recycle<T>(T obj) where T : Component
	{
		ObjectPool.Recycle(obj.gameObject);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00004370 File Offset: 0x00002570
	public static void Recycle(GameObject obj)
	{
		GameObject prefab;
		if (ObjectPool.instance != null && ObjectPool.instance.spawnedObjects.TryGetValue(obj, out prefab))
		{
			ObjectPool.Recycle(obj, prefab);
			return;
		}
		ObjectPoolAuditor.RecordDespawned(obj, false);
		UnityEngine.Object.Destroy(obj);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000043B4 File Offset: 0x000025B4
	private static void Recycle(GameObject obj, GameObject prefab)
	{
		ObjectPool.isRecycling = true;
		if (obj != null && prefab != null)
		{
			ObjectPool.instance.pooledObjects[prefab].Add(obj);
			ObjectPool.instance.spawnedObjects.Remove(obj);
			obj.transform.parent = ObjectPool.instance.transform;
			if (obj.GetComponent<ActiveRecycler>() != null)
			{
				obj.transform.SetPosition2D(ObjectPool.activeStashLocation);
				FSMUtility.SendEventToGameObject(obj, "A RECYCLE", false);
			}
			else
			{
				obj.SetActive(false);
			}
			ObjectPoolAuditor.RecordDespawned(obj, true);
		}
		ObjectPool.isRecycling = false;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00004458 File Offset: 0x00002658
	public static void RecycleAll<T>(T prefab) where T : Component
	{
		ObjectPool.RecycleAll(prefab.gameObject);
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000446C File Offset: 0x0000266C
	public static void RecycleAll(GameObject prefab)
	{
		foreach (KeyValuePair<GameObject, GameObject> keyValuePair in ObjectPool.instance.spawnedObjects)
		{
			if (keyValuePair.Value == prefab)
			{
				ObjectPool.tempList.Add(keyValuePair.Key);
			}
		}
		for (int i = 0; i < ObjectPool.tempList.Count; i++)
		{
			ObjectPool.Recycle(ObjectPool.tempList[i]);
		}
		ObjectPool.tempList.Clear();
	}

	// Token: 0x0600008B RID: 139 RVA: 0x0000450C File Offset: 0x0000270C
	public static void RecycleAll()
	{
		ObjectPool.tempList.AddRange(ObjectPool.instance.spawnedObjects.Keys);
		for (int i = 0; i < ObjectPool.tempList.Count; i++)
		{
			ObjectPool.Recycle(ObjectPool.tempList[i]);
		}
		ObjectPool.tempList.Clear();
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00004561 File Offset: 0x00002761
	public static bool IsSpawned(GameObject obj)
	{
		return ObjectPool.instance.spawnedObjects.ContainsKey(obj);
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004573 File Offset: 0x00002773
	public static int CountPooled<T>(T prefab) where T : Component
	{
		return ObjectPool.CountPooled(prefab.gameObject);
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00004588 File Offset: 0x00002788
	public static int CountPooled(GameObject prefab)
	{
		List<GameObject> list;
		if (ObjectPool.instance.pooledObjects.TryGetValue(prefab, out list))
		{
			return list.Count;
		}
		return 0;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000045B1 File Offset: 0x000027B1
	public static int CountSpawned<T>(T prefab) where T : Component
	{
		return ObjectPool.CountSpawned(prefab.gameObject);
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000045C4 File Offset: 0x000027C4
	public static int CountSpawned(GameObject prefab)
	{
		int num = 0;
		foreach (GameObject y in ObjectPool.instance.spawnedObjects.Values)
		{
			if (prefab == y)
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000462C File Offset: 0x0000282C
	public static int CountAllPooled()
	{
		int num = 0;
		foreach (List<GameObject> list in ObjectPool.instance.pooledObjects.Values)
		{
			num += list.Count;
		}
		return num;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00004690 File Offset: 0x00002890
	public static List<GameObject> GetPooled(GameObject prefab, List<GameObject> list, bool appendList)
	{
		if (list == null)
		{
			list = new List<GameObject>();
		}
		if (!appendList)
		{
			list.Clear();
		}
		List<GameObject> collection;
		if (ObjectPool.instance.pooledObjects.TryGetValue(prefab, out collection))
		{
			list.AddRange(collection);
		}
		return list;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000046D0 File Offset: 0x000028D0
	public static List<T> GetPooled<T>(T prefab, List<T> list, bool appendList) where T : Component
	{
		if (list == null)
		{
			list = new List<T>();
		}
		if (!appendList)
		{
			list.Clear();
		}
		List<GameObject> list2;
		if (ObjectPool.instance.pooledObjects.TryGetValue(prefab.gameObject, out list2))
		{
			for (int i = 0; i < list2.Count; i++)
			{
				list.Add(list2[i].GetComponent<T>());
			}
		}
		return list;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00004734 File Offset: 0x00002934
	public static List<GameObject> GetSpawned(GameObject prefab, List<GameObject> list, bool appendList)
	{
		if (list == null)
		{
			list = new List<GameObject>();
		}
		if (!appendList)
		{
			list.Clear();
		}
		foreach (KeyValuePair<GameObject, GameObject> keyValuePair in ObjectPool.instance.spawnedObjects)
		{
			if (keyValuePair.Value == prefab)
			{
				list.Add(keyValuePair.Key);
			}
		}
		return list;
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000047B8 File Offset: 0x000029B8
	public static List<T> GetSpawned<T>(T prefab, List<T> list, bool appendList) where T : Component
	{
		if (list == null)
		{
			list = new List<T>();
		}
		if (!appendList)
		{
			list.Clear();
		}
		GameObject gameObject = prefab.gameObject;
		foreach (KeyValuePair<GameObject, GameObject> keyValuePair in ObjectPool.instance.spawnedObjects)
		{
			if (keyValuePair.Value == gameObject)
			{
				list.Add(keyValuePair.Key.GetComponent<T>());
			}
		}
		return list;
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000484C File Offset: 0x00002A4C
	public static void DestroyPooled(GameObject prefab)
	{
		List<GameObject> list;
		if (ObjectPool.instance.pooledObjects.TryGetValue(prefab, out list))
		{
			for (int i = 0; i < list.Count; i++)
			{
				UnityEngine.Object.Destroy(list[i]);
			}
			list.Clear();
		}
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004890 File Offset: 0x00002A90
	public static void DestroyPooled<T>(T prefab) where T : Component
	{
		ObjectPool.DestroyPooled(prefab.gameObject);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000048A4 File Offset: 0x00002AA4
	public static void DestroyPooled(GameObject prefab, int amountToRemove)
	{
		ObjectPool.RecycleAll(prefab);
		List<GameObject> list;
		if (ObjectPool.instance.pooledObjects.TryGetValue(prefab, out list))
		{
			int num = 0;
			while (num < amountToRemove && list.Count > 0)
			{
				UnityEngine.Object.Destroy(list[0]);
				list.RemoveAt(0);
				num++;
			}
		}
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000048F3 File Offset: 0x00002AF3
	public static void DestroyPooled<T>(T prefab, int amount) where T : Component
	{
		ObjectPool.DestroyPooled(prefab.gameObject, amount);
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00004906 File Offset: 0x00002B06
	public static void DestroyAll(GameObject prefab)
	{
		ObjectPool.RecycleAll(prefab);
		ObjectPool.DestroyPooled(prefab);
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004914 File Offset: 0x00002B14
	public static void DestroyAll<T>(T prefab) where T : Component
	{
		ObjectPool.DestroyAll(prefab.gameObject);
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00004926 File Offset: 0x00002B26
	public ObjectPool()
	{
		this.pooledObjects = new Dictionary<GameObject, List<GameObject>>();
		this.spawnedObjects = new Dictionary<GameObject, GameObject>();
		base..ctor();
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00004944 File Offset: 0x00002B44
	// Note: this type is marked as 'beforefieldinit'.
	static ObjectPool()
	{
		ObjectPool.tempList = new List<GameObject>();
		ObjectPool.destroyList = new List<GameObject>();
		ObjectPool.activeStashLocation = new Vector2(-20f, -20f);
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00004970 File Offset: 0x00002B70
	public static GameObject orig_Spawn(GameObject prefab, Transform parent, Vector3 position, Quaternion rotation)
	{
		bool flag = prefab.GetComponent<ActiveRecycler>() != null;
		List<GameObject> list;
		if (ObjectPool.instance.pooledObjects.TryGetValue(prefab, out list))
		{
			GameObject gameObject = null;
			if (list.Count > 0)
			{
				while (gameObject == null && list.Count > 0)
				{
					gameObject = list[0];
					list.RemoveAt(0);
				}
				if (gameObject != null)
				{
					Transform transform = gameObject.transform;
					transform.parent = parent;
					transform.localPosition = position;
					transform.localRotation = rotation;
					if (flag)
					{
						FSMUtility.SendEventToGameObject(gameObject, "A SPAWN", false);
					}
					else
					{
						gameObject.SetActive(true);
					}
					ObjectPool.instance.spawnedObjects.Add(gameObject, prefab);
					ObjectPoolAuditor.RecordSpawned(prefab, false);
					return gameObject;
				}
			}
			Debug.LogWarningFormat("Object Pool attached to {0} has run out of {1} prefabs, Instantiating an additional one.", new object[]
			{
				ObjectPool.instance.name,
				prefab.name
			});
			gameObject = UnityEngine.Object.Instantiate<GameObject>(prefab);
			Transform transform2 = gameObject.transform;
			transform2.parent = parent;
			transform2.localPosition = position;
			transform2.localRotation = rotation;
			if (flag)
			{
				FSMUtility.SendEventToGameObject(gameObject, "A SPAWN", false);
			}
			ObjectPool.instance.spawnedObjects.Add(gameObject, prefab);
			ObjectPoolAuditor.RecordSpawned(prefab, true);
			return gameObject;
		}
		if (prefab == null)
		{
			Debug.LogErrorFormat("Object Pool attached to {0} was asked for a NULL prefab.", new object[]
			{
				ObjectPool.instance.name
			});
			return null;
		}
		Debug.LogWarningFormat("Object Pool attached to {0} could not find a copy of {1}, Instantiating a new one.", new object[]
		{
			ObjectPool.instance.name,
			prefab.name
		});
		ObjectPool.CreatePool(prefab.gameObject, 1);
		return ObjectPool.Spawn(prefab);
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00004B00 File Offset: 0x00002D00
	public static void orig_CreatePool(GameObject prefab, int initialPoolSize)
	{
		ObjectPoolAuditor.RecordPoolCreated(prefab, initialPoolSize);
		if (prefab != null)
		{
			List<GameObject> list;
			if (!ObjectPool.instance.pooledObjects.ContainsKey(prefab))
			{
				list = new List<GameObject>();
				ObjectPool.instance.pooledObjects.Add(prefab, list);
				if (initialPoolSize > 0)
				{
					bool activeSelf = prefab.activeSelf;
					bool flag;
					if (prefab.GetComponent<ActiveRecycler>() != null)
					{
						flag = true;
						prefab.SetActive(true);
					}
					else
					{
						flag = false;
						prefab.SetActive(false);
					}
					Transform transform = ObjectPool.instance.transform;
					while (list.Count < initialPoolSize)
					{
						GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(prefab);
						gameObject.transform.parent = transform;
						if (flag)
						{
							gameObject.transform.SetPosition2D(ObjectPool.activeStashLocation);
						}
						list.Add(gameObject);
					}
					prefab.SetActive(activeSelf);
				}
			}
			else
			{
				list = ObjectPool.instance.pooledObjects[prefab];
				if (initialPoolSize > 0)
				{
					int num = list.Count + initialPoolSize;
					bool activeSelf2 = prefab.activeSelf;
					bool flag2;
					if (prefab.GetComponent<ActiveRecycler>() != null)
					{
						flag2 = true;
						prefab.SetActive(true);
					}
					else
					{
						flag2 = false;
						prefab.SetActive(false);
					}
					Transform transform2 = ObjectPool.instance.transform;
					while (list.Count < num)
					{
						GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(prefab);
						gameObject2.transform.parent = transform2;
						if (flag2)
						{
							gameObject2.transform.SetPosition2D(ObjectPool.activeStashLocation);
						}
						list.Add(gameObject2);
					}
					prefab.SetActive(activeSelf2);
				}
			}
			if (list == null)
			{
				return;
			}
			using (List<GameObject>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					GameObject gameObject3 = enumerator.Current;
					tk2dSprite[] componentsInChildren = gameObject3.GetComponentsInChildren<tk2dSprite>(true);
					for (int i = 0; i < componentsInChildren.Length; i++)
					{
						componentsInChildren[i].ForceBuild();
					}
				}
				return;
			}
		}
		if (prefab == null)
		{
			Debug.LogError("Trying to create an Object Pool for a prefab that is null.");
		}
	}

	// Token: 0x04000060 RID: 96
	private static List<GameObject> tempList;

	// Token: 0x04000061 RID: 97
	private static List<GameObject> destroyList;

	// Token: 0x04000062 RID: 98
	private Dictionary<GameObject, List<GameObject>> pooledObjects;

	// Token: 0x04000063 RID: 99
	private Dictionary<GameObject, GameObject> spawnedObjects;

	// Token: 0x04000064 RID: 100
	public ObjectPool.StartupPool[] startupPools;

	// Token: 0x04000065 RID: 101
	private bool startupPoolsCreated;

	// Token: 0x04000066 RID: 102
	private static Vector2 activeStashLocation;

	// Token: 0x04000067 RID: 103
	private static bool isRecycling;

	// Token: 0x04000068 RID: 104
	private static ObjectPool _instance;

	// Token: 0x02000019 RID: 25
	[Serializable]
	public class StartupPool
	{
		// Token: 0x04000069 RID: 105
		public int size;

		// Token: 0x0400006A RID: 106
		public GameObject prefab;
	}
}
