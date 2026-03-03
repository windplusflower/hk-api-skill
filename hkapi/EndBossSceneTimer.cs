using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200026E RID: 622
public class EndBossSceneTimer : MonoBehaviour
{
	// Token: 0x06000D0B RID: 3339 RVA: 0x00041A26 File Offset: 0x0003FC26
	private void OnEnable()
	{
		base.StartCoroutine(this.Delayed());
	}

	// Token: 0x06000D0C RID: 3340 RVA: 0x00003B7D File Offset: 0x00001D7D
	private void OnDisable()
	{
		base.StopAllCoroutines();
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00041A35 File Offset: 0x0003FC35
	private IEnumerator Delayed()
	{
		yield return new WaitForSeconds(this.delay);
		if (BossSceneController.Instance)
		{
			BossSceneController.Instance.EndBossScene();
		}
		yield break;
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00041A44 File Offset: 0x0003FC44
	public EndBossSceneTimer()
	{
		this.delay = 10f;
		base..ctor();
	}

	// Token: 0x04000DF5 RID: 3573
	[SerializeField]
	private float delay;
}
