using System;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Modding.Utils
{
	/// <summary>
	/// Class containing extensions used by the Modding API for interacting with Unity types.
	/// </summary>
	// Token: 0x02000DA5 RID: 3493
	public static class UnityExtensions
	{
		/// <summary>
		/// Get the component of type T attached to GameObject go. If go does not have such a component, add
		/// that component (and return it).
		/// </summary>
		// Token: 0x06004884 RID: 18564 RVA: 0x00189144 File Offset: 0x00187344
		public static T GetOrAddComponent<T>(this GameObject go) where T : Component
		{
			T t = go.GetComponent<T>();
			if (t == null)
			{
				t = go.AddComponent<T>();
			}
			return t;
		}

		/// <summary>
		/// Find a game object by name in the scene. The object's name must be given in the hierarchy.
		/// </summary>
		/// <param name="scene">The scene to search.</param>
		/// <param name="objName">The name of the object in the hierarchy, with '/' separating parent GameObjects from child GameObjects.</param>
		/// <returns>The GameObject if found; null if not.</returns>
		/// <exception cref="T:System.ArgumentException">Thrown if the path to the game object is invalid.</exception>
		// Token: 0x06004885 RID: 18565 RVA: 0x0018916E File Offset: 0x0018736E
		public static GameObject FindGameObject(this Scene scene, string objName)
		{
			return UnityExtensions.GetGameObjectFromArray(scene.GetRootGameObjects(), objName);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x00189180 File Offset: 0x00187380
		internal static GameObject GetGameObjectFromArray(GameObject[] objects, string objName)
		{
			string text = null;
			int num = objName.IndexOf('/');
			string rootName;
			if (num == -1)
			{
				rootName = objName;
			}
			else
			{
				if (num == 0 || num == objName.Length - 1)
				{
					throw new ArgumentException("Invalid GameObject path");
				}
				rootName = objName.Substring(0, num);
				text = objName.Substring(num + 1);
			}
			GameObject gameObject = objects.FirstOrDefault((GameObject o) => o.name == rootName);
			if (gameObject == null)
			{
				return null;
			}
			if (text == null)
			{
				return gameObject;
			}
			Transform transform = gameObject.transform.Find(text);
			if (!(transform == null))
			{
				return transform.gameObject;
			}
			return null;
		}
	}
}
