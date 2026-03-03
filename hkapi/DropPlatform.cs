using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003B7 RID: 951
public class DropPlatform : MonoBehaviour
{
	// Token: 0x060015D7 RID: 5591 RVA: 0x00067C16 File Offset: 0x00065E16
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x00067C24 File Offset: 0x00065E24
	private void Start()
	{
		this.Idle();
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x00067C2C File Offset: 0x00065E2C
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.flipRoutine == null && collision.gameObject.layer == 9 && collision.collider.bounds.min.y > this.collider.bounds.max.y)
		{
			this.flipRoutine = base.StartCoroutine(this.Flip());
		}
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x00067C94 File Offset: 0x00065E94
	private void PlaySound(AudioClip clip)
	{
		if (this.audioSource && clip)
		{
			this.audioSource.PlayOneShot(clip);
		}
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00067CB7 File Offset: 0x00065EB7
	private void Idle()
	{
		base.transform.SetPositionZ(0.003f);
		this.spriteAnimator.Play(this.idleAnim);
		if (this.collider)
		{
			this.collider.enabled = true;
		}
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00067CF3 File Offset: 0x00065EF3
	private IEnumerator Flip()
	{
		this.PlaySound(this.landSound);
		if (this.strikeEffect)
		{
			this.strikeEffect.SetActive(true);
		}
		yield return new WaitForSeconds(0.7f);
		if (this.collider)
		{
			this.collider.enabled = false;
		}
		this.PlaySound(this.dropSound);
		yield return this.StartCoroutine(this.spriteAnimator.PlayAnimWait(this.dropAnim));
		this.transform.SetPositionZ(0.007f);
		yield return new WaitForSeconds(1.5f);
		this.PlaySound(this.flipUpSound);
		yield return this.StartCoroutine(this.spriteAnimator.PlayAnimWait(this.raiseAnim));
		this.flipRoutine = null;
		this.Idle();
		yield break;
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00067D02 File Offset: 0x00065F02
	private IEnumerator Jitter(float duration)
	{
		Transform sprite = this.spriteAnimator.transform;
		Vector3 initialPos = sprite.position;
		for (float elapsed = 0f; elapsed < duration; elapsed += Time.deltaTime)
		{
			sprite.position = initialPos + new Vector3(UnityEngine.Random.Range(-0.1f, 0.1f), 0f, 0f);
			yield return null;
		}
		sprite.position = initialPos;
		yield break;
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x00067D18 File Offset: 0x00065F18
	public DropPlatform()
	{
		this.idleAnim = "Idle Small";
		this.dropAnim = "Drop Small";
		this.raiseAnim = "Raise Small";
		base..ctor();
	}

	// Token: 0x04001A2D RID: 6701
	public tk2dSpriteAnimator spriteAnimator;

	// Token: 0x04001A2E RID: 6702
	[Space]
	public string idleAnim;

	// Token: 0x04001A2F RID: 6703
	public string dropAnim;

	// Token: 0x04001A30 RID: 6704
	public string raiseAnim;

	// Token: 0x04001A31 RID: 6705
	[Space]
	public AudioClip landSound;

	// Token: 0x04001A32 RID: 6706
	public AudioClip dropSound;

	// Token: 0x04001A33 RID: 6707
	public AudioClip flipUpSound;

	// Token: 0x04001A34 RID: 6708
	[Space]
	public GameObject strikeEffect;

	// Token: 0x04001A35 RID: 6709
	[Space]
	public Collider2D collider;

	// Token: 0x04001A36 RID: 6710
	private Coroutine flipRoutine;

	// Token: 0x04001A37 RID: 6711
	private AudioSource audioSource;
}
