using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000556 RID: 1366
[AddComponentMenu("")]
public class tk2dUpdateManager : MonoBehaviour
{
	// Token: 0x170003CA RID: 970
	// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000955D8 File Offset: 0x000937D8
	private static tk2dUpdateManager Instance
	{
		get
		{
			if (tk2dUpdateManager.inst == null)
			{
				tk2dUpdateManager.inst = (UnityEngine.Object.FindObjectOfType(typeof(tk2dUpdateManager)) as tk2dUpdateManager);
				if (tk2dUpdateManager.inst == null)
				{
					GameObject gameObject = new GameObject("@tk2dUpdateManager");
					gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
					tk2dUpdateManager.inst = gameObject.AddComponent<tk2dUpdateManager>();
					UnityEngine.Object.DontDestroyOnLoad(gameObject);
				}
			}
			return tk2dUpdateManager.inst;
		}
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x0009563E File Offset: 0x0009383E
	public static void QueueCommit(tk2dTextMesh textMesh)
	{
		tk2dUpdateManager.Instance.QueueCommitInternal(textMesh);
	}

	// Token: 0x06001DFB RID: 7675 RVA: 0x0009564B File Offset: 0x0009384B
	public static void FlushQueues()
	{
		tk2dUpdateManager.Instance.FlushQueuesInternal();
	}

	// Token: 0x06001DFC RID: 7676 RVA: 0x00095657 File Offset: 0x00093857
	private void OnEnable()
	{
		base.StartCoroutine(this.coSuperLateUpdate());
	}

	// Token: 0x06001DFD RID: 7677 RVA: 0x00095666 File Offset: 0x00093866
	private void LateUpdate()
	{
		this.FlushQueuesInternal();
	}

	// Token: 0x06001DFE RID: 7678 RVA: 0x0009566E File Offset: 0x0009386E
	private IEnumerator coSuperLateUpdate()
	{
		this.FlushQueuesInternal();
		yield break;
	}

	// Token: 0x06001DFF RID: 7679 RVA: 0x0009567D File Offset: 0x0009387D
	private void QueueCommitInternal(tk2dTextMesh textMesh)
	{
		this.textMeshes.Add(textMesh);
	}

	// Token: 0x06001E00 RID: 7680 RVA: 0x0009568C File Offset: 0x0009388C
	private void FlushQueuesInternal()
	{
		int count = this.textMeshes.Count;
		for (int i = 0; i < count; i++)
		{
			tk2dTextMesh tk2dTextMesh = this.textMeshes[i];
			if (tk2dTextMesh != null)
			{
				tk2dTextMesh.DoNotUse__CommitInternal();
			}
		}
		this.textMeshes.Clear();
	}

	// Token: 0x06001E01 RID: 7681 RVA: 0x000956D8 File Offset: 0x000938D8
	public tk2dUpdateManager()
	{
		this.textMeshes = new List<tk2dTextMesh>(64);
		base..ctor();
	}

	// Token: 0x040023A6 RID: 9126
	private static tk2dUpdateManager inst;

	// Token: 0x040023A7 RID: 9127
	[SerializeField]
	private List<tk2dTextMesh> textMeshes;
}
