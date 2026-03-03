using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200035A RID: 858
public class CoroutineQueue
{
	// Token: 0x0600136F RID: 4975 RVA: 0x0005831B File Offset: 0x0005651B
	public CoroutineQueue(MonoBehaviour runner)
	{
		this.runner = runner;
		this.pendingCoroutines = new List<IEnumerator>();
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00058335 File Offset: 0x00056535
	public void Enqueue(IEnumerator coroutine)
	{
		this.pendingCoroutines.Add(coroutine);
		if (!this.isRunning)
		{
			this.runner.StartCoroutine(this.Run());
		}
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x0005835D File Offset: 0x0005655D
	public IEnumerator Run()
	{
		this.isRunning = true;
		while (this.pendingCoroutines.Count > 0)
		{
			IEnumerator coroutine = this.pendingCoroutines[0];
			this.pendingCoroutines.RemoveAt(0);
			for (;;)
			{
				bool flag;
				try
				{
					flag = coroutine.MoveNext();
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
					break;
				}
				if (!flag)
				{
					break;
				}
				yield return coroutine.Current;
			}
			coroutine = null;
		}
		this.isRunning = false;
		yield break;
	}

	// Token: 0x040012A3 RID: 4771
	private readonly List<IEnumerator> pendingCoroutines;

	// Token: 0x040012A4 RID: 4772
	private readonly MonoBehaviour runner;

	// Token: 0x040012A5 RID: 4773
	private bool isRunning;
}
