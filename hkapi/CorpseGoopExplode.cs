using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200016A RID: 362
public class CorpseGoopExplode : Corpse
{
	// Token: 0x06000860 RID: 2144 RVA: 0x0002E517 File Offset: 0x0002C717
	protected override void Start()
	{
		this.spellBurn = false;
		base.Start();
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0002E526 File Offset: 0x0002C726
	protected override void LandEffects()
	{
		base.StartCoroutine(this.DoLandEffects());
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0002E535 File Offset: 0x0002C735
	private IEnumerator DoLandEffects()
	{
		this.body.isKinematic = true;
		this.body.velocity = Vector3.zero;
		yield return new WaitForSeconds(1f);
		if (this.corpseFlame)
		{
			this.corpseFlame.Stop();
		}
		if (this.corpseSteam)
		{
			this.corpseSteam.Play();
		}
		this.body.velocity = Vector2.zero;
		this.gushSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		yield return this.StartCoroutine(this.Jitter(0.7f));
		if (this.corpseSteam)
		{
			this.corpseSteam.Stop();
		}
		GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
		if (gameCameras)
		{
			gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
		}
		if (this.gasExplosion)
		{
			UnityEngine.Object.Instantiate<GameObject>(this.gasExplosion, this.transform.position, Quaternion.identity);
		}
		this.meshRenderer.enabled = false;
		yield break;
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0002E544 File Offset: 0x0002C744
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

	// Token: 0x04000950 RID: 2384
	[Header("Goop Explode Variables")]
	public GameObject gasExplosion;

	// Token: 0x04000951 RID: 2385
	public AudioEvent gushSound;
}
