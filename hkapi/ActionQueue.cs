using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000356 RID: 854
public class ActionQueue
{
	// Token: 0x06001361 RID: 4961 RVA: 0x000580FF File Offset: 0x000562FF
	public ActionQueue()
	{
		this.pendingActions = new List<ActionQueue.ActionQueueCallback>();
		this.isRunning = false;
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0005811C File Offset: 0x0005631C
	public void Next()
	{
		while (this.pendingActions.Count > 0)
		{
			ActionQueue.ActionQueueCallback actionQueueCallback = this.pendingActions[0];
			this.pendingActions.RemoveAt(0);
			try
			{
				actionQueueCallback(new Action(this.Next));
				return;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}
		this.isRunning = false;
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00058184 File Offset: 0x00056384
	public void Enqueue(ActionQueue.ActionQueueCallback action)
	{
		if (action == null)
		{
			return;
		}
		this.pendingActions.Add(action);
		if (!this.isRunning)
		{
			this.isRunning = true;
			this.Next();
		}
	}

	// Token: 0x0400129A RID: 4762
	private readonly List<ActionQueue.ActionQueueCallback> pendingActions;

	// Token: 0x0400129B RID: 4763
	private bool isRunning;

	// Token: 0x02000357 RID: 855
	// (Invoke) Token: 0x06001365 RID: 4965
	public delegate void ActionQueueCallback(Action next);
}
