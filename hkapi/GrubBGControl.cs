using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003CC RID: 972
public class GrubBGControl : MonoBehaviour
{
	// Token: 0x0600164B RID: 5707 RVA: 0x0006992C File Offset: 0x00067B2C
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x0600164C RID: 5708 RVA: 0x0006993C File Offset: 0x00067B3C
	private void Start()
	{
		int playerDataInt = GameManager.instance.GetPlayerDataInt("grubsCollected");
		if (this.grubNumber > playerDataInt)
		{
			base.gameObject.SetActive(false);
			return;
		}
		this.idleRoutine = base.StartCoroutine(this.Idle());
		if (this.waveRegion)
		{
			this.waveRegion.OnTriggerEntered += delegate(Collider2D col, GameObject sender)
			{
				if (this.waveRoutine == null)
				{
					this.waveRoutine = base.StartCoroutine(this.Wave());
				}
			};
		}
	}

	// Token: 0x0600164D RID: 5709 RVA: 0x000699A5 File Offset: 0x00067BA5
	private IEnumerator Idle()
	{
		this.anim.Play("Home Bounce");
		for (;;)
		{
			yield return new WaitForSeconds(UnityEngine.Random.Range(3f, 10f));
			this.idleSounds.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		}
		yield break;
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x000699B4 File Offset: 0x00067BB4
	private IEnumerator Wave()
	{
		if (this.idleRoutine != null)
		{
			this.StopCoroutine(this.idleRoutine);
		}
		Vector3 position = this.transform.position;
		position.z = 0f;
		this.waveSounds.SpawnAndPlayOneShot(this.audioSourcePrefab, position);
		yield return this.StartCoroutine(this.anim.PlayAnimWait("Home Wave"));
		this.waveRoutine = null;
		this.idleRoutine = this.StartCoroutine(this.Idle());
		yield break;
	}

	// Token: 0x04001ACE RID: 6862
	public int grubNumber;

	// Token: 0x04001ACF RID: 6863
	[Space]
	public TriggerEnterEvent waveRegion;

	// Token: 0x04001AD0 RID: 6864
	[Space]
	public AudioSource audioSourcePrefab;

	// Token: 0x04001AD1 RID: 6865
	public AudioEventRandom idleSounds;

	// Token: 0x04001AD2 RID: 6866
	public AudioEventRandom waveSounds;

	// Token: 0x04001AD3 RID: 6867
	private Coroutine idleRoutine;

	// Token: 0x04001AD4 RID: 6868
	private Coroutine waveRoutine;

	// Token: 0x04001AD5 RID: 6869
	private tk2dSpriteAnimator anim;
}
