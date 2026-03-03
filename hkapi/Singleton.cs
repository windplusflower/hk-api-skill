using System;
using UnityEngine;

// Token: 0x0200020B RID: 523
public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0003C158 File Offset: 0x0003A358
	public static T instance
	{
		get
		{
			T result;
			if (Singleton<T>.applicationIsQuitting)
			{
				string str = "[Singleton] Instance '";
				Type typeFromHandle = typeof(T);
				Debug.LogWarning(str + ((typeFromHandle != null) ? typeFromHandle.ToString() : null) + "' already destroyed on application quit. Won't create again - returning null.");
				result = default(T);
				return result;
			}
			object @lock = Singleton<T>._lock;
			lock (@lock)
			{
				if (Singleton<T>._instance == null)
				{
					Singleton<T>._instance = (T)((object)UnityEngine.Object.FindObjectOfType(typeof(T)));
					if (UnityEngine.Object.FindObjectsOfType(typeof(T)).Length > 1)
					{
						Debug.LogError("[Singleton] Something went really wrong  - there should never be more than one singleton! Reopening the scene might fix it.");
						return Singleton<T>._instance;
					}
					if (Singleton<T>._instance == null)
					{
						GameObject gameObject = new GameObject();
						Singleton<T>._instance = gameObject.AddComponent<T>();
						gameObject.name = "(singleton) " + typeof(T).ToString();
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
						string[] array = new string[5];
						array[0] = "[Singleton] An instance of ";
						int num = 1;
						Type typeFromHandle2 = typeof(T);
						array[num] = ((typeFromHandle2 != null) ? typeFromHandle2.ToString() : null);
						array[2] = " is needed in the scene, so '";
						int num2 = 3;
						GameObject gameObject2 = gameObject;
						array[num2] = ((gameObject2 != null) ? gameObject2.ToString() : null);
						array[4] = "' was created with DontDestroyOnLoad.";
						Debug.Log(string.Concat(array));
					}
				}
				result = Singleton<T>._instance;
			}
			return result;
		}
	}

	// Token: 0x06000B53 RID: 2899 RVA: 0x0003C2D4 File Offset: 0x0003A4D4
	public void Awake()
	{
		Debug.Log("TEST1 - AWAKE - " + base.GetInstanceID().ToString());
		if (Singleton<T>._instance == null)
		{
			Debug.Log("TEST2 - NEW INSTANCE - " + base.GetInstanceID().ToString());
			Singleton<T>._instance = (base.gameObject as T);
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			return;
		}
		if (this != Singleton<T>._instance)
		{
			Debug.Log("TEST3 - DESTROYED - " + base.GetInstanceID().ToString());
			UnityEngine.Object.DestroyImmediate(base.gameObject);
			return;
		}
		Debug.Log("TEST4 - CORRECT INSTANCE - " + base.GetInstanceID().ToString());
	}

	// Token: 0x06000B54 RID: 2900 RVA: 0x0003C3A6 File Offset: 0x0003A5A6
	public void OnDestroy()
	{
		Singleton<T>.applicationIsQuitting = true;
	}

	// Token: 0x04000C51 RID: 3153
	private static T _instance;

	// Token: 0x04000C52 RID: 3154
	private static object _lock = new object();

	// Token: 0x04000C53 RID: 3155
	private static bool applicationIsQuitting = false;
}
