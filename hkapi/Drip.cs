using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003B2 RID: 946
public class Drip : MonoBehaviour
{
	// Token: 0x060015BC RID: 5564 RVA: 0x00067853 File Offset: 0x00065A53
	private void Awake()
	{
		this.dripAnimator = this.dripSprite.GetComponent<Animator>();
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00067866 File Offset: 0x00065A66
	private void Start()
	{
		base.StartCoroutine(this.DripRoutine());
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00067875 File Offset: 0x00065A75
	private IEnumerator DripRoutine()
	{
		for (;;)
		{
			float seconds = UnityEngine.Random.Range(this.minWaitTime, this.maxWaitTime);
			yield return new WaitForSeconds(seconds);
			this.idleSprite.SetActive(false);
			this.dripSprite.SetActive(true);
			this.StartCoroutine(this.DropDrip());
			yield return new WaitForSeconds(this.dripAnimator.GetCurrentAnimatorStateInfo(0).length);
			this.idleSprite.SetActive(true);
			this.dripSprite.SetActive(false);
		}
		yield break;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00067884 File Offset: 0x00065A84
	private IEnumerator DropDrip()
	{
		yield return new WaitForSeconds(this.dripDelay);
		this.dripPrefab.Spawn(this.dripSpawnPoint.position).transform.SetPositionZ(0.003f);
		yield break;
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00067893 File Offset: 0x00065A93
	public Drip()
	{
		this.minWaitTime = 1f;
		this.maxWaitTime = 7f;
		this.dripDelay = 0.6f;
		base..ctor();
	}

	// Token: 0x04001A18 RID: 6680
	public float minWaitTime;

	// Token: 0x04001A19 RID: 6681
	public float maxWaitTime;

	// Token: 0x04001A1A RID: 6682
	public GameObject idleSprite;

	// Token: 0x04001A1B RID: 6683
	public GameObject dripSprite;

	// Token: 0x04001A1C RID: 6684
	private Animator dripAnimator;

	// Token: 0x04001A1D RID: 6685
	public Transform dripSpawnPoint;

	// Token: 0x04001A1E RID: 6686
	public float dripDelay;

	// Token: 0x04001A1F RID: 6687
	public GameObject dripPrefab;
}
