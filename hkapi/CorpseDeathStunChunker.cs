using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000164 RID: 356
public class CorpseDeathStunChunker : CorpseChunker
{
	// Token: 0x0600083F RID: 2111 RVA: 0x0002DEA3 File Offset: 0x0002C0A3
	protected override void Start()
	{
		base.StartCoroutine(this.DeathStun());
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0002DEB2 File Offset: 0x0002C0B2
	private IEnumerator DeathStun()
	{
		if (this.stunSteam)
		{
			this.stunSteam.Play();
		}
		SpriteFlash spriteFlash = this.GetComponent<SpriteFlash>();
		if (spriteFlash)
		{
			spriteFlash.flashInfectedLoop();
		}
		Vector2 velocity = Vector2.zero;
		if (this.body)
		{
			velocity = this.body.velocity;
			this.body.isKinematic = true;
			this.body.velocity = Vector2.zero;
		}
		yield return this.StartCoroutine(this.Jitter(0.75f));
		if (spriteFlash)
		{
			spriteFlash.CancelFlash();
		}
		UnityEngine.Object.Instantiate<GameObject>(this.deathWaveInfectedPrefab, this.transform.position, Quaternion.identity).transform.localScale = new Vector3(2f, 2f, 2f);
		if (this.body)
		{
			this.body.isKinematic = false;
			this.body.velocity = velocity;
		}
		if (this.stunSteam)
		{
			this.stunSteam.Stop();
		}
		base.Start();
		yield break;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x0002DEC1 File Offset: 0x0002C0C1
	private IEnumerator Jitter(float duration)
	{
		Transform sprite = this.spriteAnimator.transform;
		Vector3 initialPos = sprite.position;
		for (float elapsed = 0f; elapsed < duration; elapsed += Time.deltaTime)
		{
			sprite.position = initialPos + new Vector3(UnityEngine.Random.Range(-0.15f, 0.15f), 0f, 0f);
			yield return null;
		}
		sprite.position = initialPos;
		yield break;
	}

	// Token: 0x04000934 RID: 2356
	[Header("Death Stun Variables")]
	public ParticleSystem stunSteam;
}
