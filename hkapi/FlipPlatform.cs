using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003BC RID: 956
public class FlipPlatform : MonoBehaviour
{
	// Token: 0x060015F6 RID: 5622 RVA: 0x000683B8 File Offset: 0x000665B8
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x000683C8 File Offset: 0x000665C8
	private void Start()
	{
		this.idleRoutine = base.StartCoroutine(this.Idle());
		if (this.topSpikes)
		{
			this.triggerEnter = this.topSpikes.GetComponent<TriggerEnterEvent>();
		}
		if (this.triggerEnter)
		{
			this.triggerEnter.OnTriggerEntered += delegate(Collider2D collider, GameObject sender)
			{
				if (collider.tag == "Nail Attack")
				{
					this.hitCancel = true;
				}
			};
		}
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x0006842C File Offset: 0x0006662C
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			if (this.idleRoutine != null)
			{
				base.StopCoroutine(this.idleRoutine);
			}
			if (this.flipRoutine == null)
			{
				this.flipRoutine = base.StartCoroutine(this.Flip());
			}
		}
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x0006847E File Offset: 0x0006667E
	private void PlaySound(AudioClip clip)
	{
		if (this.audioSource && clip)
		{
			this.audioSource.PlayOneShot(clip);
		}
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x000684A1 File Offset: 0x000666A1
	private IEnumerator Idle()
	{
		for (;;)
		{
			this.spriteAnimator.Play("Idle Up");
			yield return new WaitForSeconds(UnityEngine.Random.Range(2f, 5f));
			tk2dSpriteAnimationClip clipByName = this.spriteAnimator.GetClipByName("Glimmer Up");
			this.spriteAnimator.Play(clipByName);
			yield return new WaitForSeconds(clipByName.Duration);
		}
		yield break;
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x000684B0 File Offset: 0x000666B0
	private IEnumerator Flip()
	{
		this.PlaySound(this.flipSound);
		this.spriteAnimator.Play("Shake Up");
		if (this.strikeEffect)
		{
			this.strikeEffect.SetActive(true);
		}
		this.StartCoroutine(this.Jitter(0.5f));
		yield return new WaitForSeconds(0.5f);
		if (this.crystalParticles)
		{
			this.crystalParticles.Play();
		}
		yield return this.StartCoroutine(this.spriteAnimator.PlayAnimWait("Flip Down 1"));
		if (this.crystalParticles)
		{
			this.crystalParticles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		yield return this.StartCoroutine(this.spriteAnimator.PlayAnimWait("Flip Down 2"));
		if (this.topSpikes)
		{
			this.topSpikes.SetActive(true);
		}
		if (this.bottomSpikes)
		{
			this.bottomSpikes.SetActive(false);
		}
		this.spriteAnimator.Play("Idle Down");
		this.hitCancel = false;
		bool skipped = false;
		float elapsed = 0f;
		while (elapsed < 4f)
		{
			if (this.hitCancel)
			{
				skipped = true;
				if (this.nailStrikePrefab)
				{
					this.nailStrikePrefab.Spawn(this.transform.position);
				}
				if (this.crystalHitParticles)
				{
					this.crystalHitParticles.Play();
				}
				this.PlaySound(this.hitSound);
				GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
				if (gameCameras)
				{
					gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
					break;
				}
				break;
			}
			else
			{
				yield return null;
				elapsed += Time.deltaTime;
			}
		}
		this.PlaySound(this.flipBackSound);
		yield return this.StartCoroutine(this.spriteAnimator.PlayAnimWait(skipped ? "Flip Up 1N" : "Flip Up 1"));
		yield return this.StartCoroutine(this.spriteAnimator.PlayAnimWait("Flip Up 2"));
		if (this.topSpikes)
		{
			this.topSpikes.SetActive(false);
		}
		if (this.bottomSpikes)
		{
			this.bottomSpikes.SetActive(true);
		}
		this.flipRoutine = null;
		this.idleRoutine = this.StartCoroutine(this.Idle());
		yield break;
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x000684BF File Offset: 0x000666BF
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

	// Token: 0x04001A5C RID: 6748
	public tk2dSpriteAnimator spriteAnimator;

	// Token: 0x04001A5D RID: 6749
	[Space]
	public AudioClip flipSound;

	// Token: 0x04001A5E RID: 6750
	public AudioClip flipBackSound;

	// Token: 0x04001A5F RID: 6751
	public AudioClip hitSound;

	// Token: 0x04001A60 RID: 6752
	[Space]
	public GameObject strikeEffect;

	// Token: 0x04001A61 RID: 6753
	public GameObject nailStrikePrefab;

	// Token: 0x04001A62 RID: 6754
	[Space]
	public ParticleSystem crystalParticles;

	// Token: 0x04001A63 RID: 6755
	public ParticleSystem crystalHitParticles;

	// Token: 0x04001A64 RID: 6756
	[Space]
	public GameObject topSpikes;

	// Token: 0x04001A65 RID: 6757
	public GameObject bottomSpikes;

	// Token: 0x04001A66 RID: 6758
	private Coroutine idleRoutine;

	// Token: 0x04001A67 RID: 6759
	private Coroutine flipRoutine;

	// Token: 0x04001A68 RID: 6760
	private bool hitCancel;

	// Token: 0x04001A69 RID: 6761
	private TriggerEnterEvent triggerEnter;

	// Token: 0x04001A6A RID: 6762
	private AudioSource audioSource;
}
