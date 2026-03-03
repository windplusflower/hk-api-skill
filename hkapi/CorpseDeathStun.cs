using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000161 RID: 353
public class CorpseDeathStun : Corpse
{
	// Token: 0x0600082E RID: 2094 RVA: 0x0002DC47 File Offset: 0x0002BE47
	protected override void Start()
	{
		base.StartCoroutine(this.DeathStun());
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x0002DC56 File Offset: 0x0002BE56
	private IEnumerator DeathStun()
	{
		SpriteFlash spriteFlash = this.GetComponent<SpriteFlash>();
		if (spriteFlash)
		{
			spriteFlash.flashInfectedLoop();
		}
		Vector2 velocity = this.body.velocity;
		this.body.isKinematic = true;
		this.body.velocity = Vector2.zero;
		yield return this.StartCoroutine(this.Jitter(0.75f));
		if (spriteFlash)
		{
			spriteFlash.CancelFlash();
		}
		UnityEngine.Object.Instantiate<GameObject>(this.deathWaveInfectedPrefab, this.transform.position, Quaternion.identity).transform.localScale = new Vector3(2f, 2f, 2f);
		this.body.isKinematic = false;
		this.body.velocity = velocity;
		base.Start();
		yield break;
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x0002DC65 File Offset: 0x0002BE65
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
}
