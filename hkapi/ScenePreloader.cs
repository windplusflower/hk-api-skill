using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200052D RID: 1325
public class ScenePreloader : MonoBehaviour
{
	// Token: 0x06001D10 RID: 7440 RVA: 0x000873E0 File Offset: 0x000855E0
	private void Start()
	{
		this.loadTime = null;
		if (this.sceneNameToLoad != "")
		{
			if (this.needsPlayerDataBool != "" && GameManager.instance.GetPlayerDataBool(this.needsPlayerDataBool) != this.playerDataBoolValue)
			{
				return;
			}
			base.StartCoroutine(this.LoadRoutine());
		}
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x00087444 File Offset: 0x00085644
	private void OnGUI()
	{
		if ((Debug.isDebugBuild || Application.isEditor || Application.platform == RuntimePlatform.Switch) && this.loadTime != null)
		{
			GUI.Label(new Rect(10f, 5f, 500f, 50f), string.Format("Preloaded Level:{0}, Time: {1}", this.sceneNameToLoad, this.loadTime));
		}
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x000874AE File Offset: 0x000856AE
	private IEnumerator LoadRoutine()
	{
		yield return null;
		AsyncOperation async = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(this.sceneNameToLoad, LoadSceneMode.Additive);
		async.allowSceneActivation = false;
		ScenePreloader.pendingOperations.Add(new ScenePreloader.SceneLoadOp(this.sceneNameToLoad, async));
		this.startLoadTime = Time.unscaledTime;
		while (async.progress < 0.9f)
		{
			yield return null;
		}
		this.endLoadTime = Time.unscaledTime;
		this.loadTime = new float?(this.endLoadTime - this.startLoadTime);
		yield break;
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x000874BD File Offset: 0x000856BD
	public static IEnumerator FinishPendingOperations()
	{
		return new ScenePreloader.<FinishPendingOperations>d__12(0);
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x000874C8 File Offset: 0x000856C8
	public static void Cleanup()
	{
		if (ScenePreloader.completedOperations != null)
		{
			foreach (ScenePreloader.SceneLoadOp sceneLoadOp in ScenePreloader.completedOperations)
			{
				UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(sceneLoadOp.sceneName);
			}
			ScenePreloader.completedOperations.Clear();
		}
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x00087530 File Offset: 0x00085730
	public ScenePreloader()
	{
		this.sceneNameToLoad = "";
		this.needsPlayerDataBool = "";
		base..ctor();
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x0008754E File Offset: 0x0008574E
	// Note: this type is marked as 'beforefieldinit'.
	static ScenePreloader()
	{
		ScenePreloader.pendingOperations = new List<ScenePreloader.SceneLoadOp>();
		ScenePreloader.completedOperations = new List<ScenePreloader.SceneLoadOp>();
	}

	// Token: 0x04002281 RID: 8833
	public string sceneNameToLoad;

	// Token: 0x04002282 RID: 8834
	public string needsPlayerDataBool;

	// Token: 0x04002283 RID: 8835
	public bool playerDataBoolValue;

	// Token: 0x04002284 RID: 8836
	private float startLoadTime;

	// Token: 0x04002285 RID: 8837
	private float endLoadTime;

	// Token: 0x04002286 RID: 8838
	private float? loadTime;

	// Token: 0x04002287 RID: 8839
	private static List<ScenePreloader.SceneLoadOp> pendingOperations;

	// Token: 0x04002288 RID: 8840
	private static List<ScenePreloader.SceneLoadOp> completedOperations;

	// Token: 0x0200052E RID: 1326
	public class SceneLoadOp
	{
		// Token: 0x06001D17 RID: 7447 RVA: 0x00087564 File Offset: 0x00085764
		public SceneLoadOp(string sceneName, AsyncOperation operation)
		{
			this.sceneName = sceneName;
			this.operation = operation;
		}

		// Token: 0x04002289 RID: 8841
		public AsyncOperation operation;

		// Token: 0x0400228A RID: 8842
		public string sceneName;
	}
}
