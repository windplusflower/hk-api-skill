using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000358 RID: 856
public class CoreLoop : MonoBehaviour
{
	// Token: 0x06001368 RID: 4968 RVA: 0x000581AB File Offset: 0x000563AB
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		GameObject gameObject = new GameObject("CoreLoop");
		CoreLoop.instance = gameObject.AddComponent<CoreLoop>();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		CoreLoop.invokeNextActions = new List<Action>();
		CoreLoop.invokeNextActionsBuffer = new List<Action>();
		CoreLoop.isFiringInvokeNext = false;
		CoreLoop.delayedInvokes = new List<CoreLoop.DelayedInvoke>();
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x000581EB File Offset: 0x000563EB
	public static void InvokeNext(Action action)
	{
		CoreLoop.invokeNextActions.Add(action);
		CoreLoop.EnqueueInvokeNext();
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x000581FD File Offset: 0x000563FD
	private static void EnqueueInvokeNext()
	{
		if (!CoreLoop.isFiringInvokeNext)
		{
			CoreLoop.isFiringInvokeNext = true;
			CoreLoop.instance.Invoke("FireInvokeNext", 0f);
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x00058220 File Offset: 0x00056420
	protected void FireInvokeNext()
	{
		CoreLoop.isFiringInvokeNext = false;
		for (int i = 0; i < CoreLoop.invokeNextActions.Count; i++)
		{
			CoreLoop.invokeNextActionsBuffer.Add(CoreLoop.invokeNextActions[i]);
		}
		CoreLoop.invokeNextActions.Clear();
		for (int j = 0; j < CoreLoop.invokeNextActionsBuffer.Count; j++)
		{
			Action action = CoreLoop.invokeNextActionsBuffer[j];
			if (action != null)
			{
				try
				{
					action();
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
				}
			}
		}
		CoreLoop.invokeNextActionsBuffer.Clear();
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x000582B4 File Offset: 0x000564B4
	protected void Update()
	{
		for (int i = 0; i < CoreLoop.delayedInvokes.Count; i++)
		{
			CoreLoop.DelayedInvoke delayedInvoke = CoreLoop.delayedInvokes[i];
			delayedInvoke.TimeRemaining -= Time.unscaledDeltaTime;
			if (delayedInvoke.TimeRemaining <= 0f)
			{
				CoreLoop.delayedInvokes.RemoveAt(i--);
				CoreLoop.InvokeNext(delayedInvoke.Action);
			}
		}
	}

	// Token: 0x0400129C RID: 4764
	private static CoreLoop instance;

	// Token: 0x0400129D RID: 4765
	private static List<Action> invokeNextActions;

	// Token: 0x0400129E RID: 4766
	private static List<Action> invokeNextActionsBuffer;

	// Token: 0x0400129F RID: 4767
	private static bool isFiringInvokeNext;

	// Token: 0x040012A0 RID: 4768
	private static List<CoreLoop.DelayedInvoke> delayedInvokes;

	// Token: 0x02000359 RID: 857
	private class DelayedInvoke
	{
		// Token: 0x040012A1 RID: 4769
		public float TimeRemaining;

		// Token: 0x040012A2 RID: 4770
		public Action Action;
	}
}
