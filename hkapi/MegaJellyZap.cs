using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200034C RID: 844
public class MegaJellyZap : MonoBehaviour
{
	// Token: 0x06001331 RID: 4913 RVA: 0x000574CA File Offset: 0x000556CA
	private void Awake()
	{
		this.col = base.GetComponent<CircleCollider2D>();
		this.fade = base.GetComponentInChildren<ColorFader>();
		if (this.anim)
		{
			this.animMesh = this.anim.GetComponent<MeshRenderer>();
		}
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x00057502 File Offset: 0x00055702
	private void OnEnable()
	{
		this.routine = base.StartCoroutine((this.type == MegaJellyZap.Type.Zap) ? this.ZapSequence() : this.MultiZapSequence());
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00057526 File Offset: 0x00055726
	private void OnDisable()
	{
		if (this.routine != null)
		{
			base.StopCoroutine(this.routine);
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x0005753C File Offset: 0x0005573C
	private IEnumerator ZapSequence()
	{
		this.col.enabled = false;
		this.ptAttack.Stop();
		this.ptAntic.Play();
		if (this.fade)
		{
			this.fade.Fade(true);
		}
		yield return new WaitForSeconds(0.5f);
		this.zapBugPt1.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		this.col.enabled = true;
		this.ptAttack.Play();
		yield return new WaitForSeconds(1f);
		this.zapBugPt2.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		if (this.fade)
		{
			this.fade.Fade(false);
		}
		this.ptAttack.Stop();
		this.ptAntic.Stop();
		this.col.enabled = false;
		yield return new WaitForSeconds(1f);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x0005754B File Offset: 0x0005574B
	private IEnumerator MultiZapSequence()
	{
		this.animMesh.enabled = false;
		this.col.enabled = false;
		this.ptAttack.Stop();
		this.transform.SetScaleX((float)((UnityEngine.Random.Range(0, 2) == 0) ? 1 : -1));
		this.transform.SetRotation2D(UnityEngine.Random.Range(0f, 360f));
		yield return new WaitForSeconds(UnityEngine.Random.Range(0f, 0.5f));
		this.anim.Play("Zap Antic");
		this.animMesh.enabled = true;
		yield return new WaitForSeconds(0.8f);
		this.col.enabled = true;
		this.ptAttack.Play();
		this.anim.Play("Zap");
		yield return new WaitForSeconds(1f);
		this.ptAttack.Stop();
		this.col.enabled = false;
		yield return this.StartCoroutine(this.anim.PlayAnimWait("Zap End"));
		this.animMesh.enabled = false;
		yield return new WaitForSeconds(0.5f);
		this.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x04001263 RID: 4707
	public MegaJellyZap.Type type;

	// Token: 0x04001264 RID: 4708
	public ParticleSystem ptAttack;

	// Token: 0x04001265 RID: 4709
	public ParticleSystem ptAntic;

	// Token: 0x04001266 RID: 4710
	public AudioSource audioSourcePrefab;

	// Token: 0x04001267 RID: 4711
	public AudioEvent zapBugPt1;

	// Token: 0x04001268 RID: 4712
	public AudioEvent zapBugPt2;

	// Token: 0x04001269 RID: 4713
	public tk2dSpriteAnimator anim;

	// Token: 0x0400126A RID: 4714
	private MeshRenderer animMesh;

	// Token: 0x0400126B RID: 4715
	private CircleCollider2D col;

	// Token: 0x0400126C RID: 4716
	private ColorFader fade;

	// Token: 0x0400126D RID: 4717
	private Coroutine routine;

	// Token: 0x0200034D RID: 845
	public enum Type
	{
		// Token: 0x0400126F RID: 4719
		Zap,
		// Token: 0x04001270 RID: 4720
		MultiZap
	}
}
