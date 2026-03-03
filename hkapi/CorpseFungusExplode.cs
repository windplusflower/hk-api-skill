using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000167 RID: 359
public class CorpseFungusExplode : Corpse
{
	// Token: 0x06000850 RID: 2128 RVA: 0x0002E157 File Offset: 0x0002C357
	protected override void LandEffects()
	{
		base.StartCoroutine(this.DoLandEffects());
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x0002E166 File Offset: 0x0002C366
	private IEnumerator DoLandEffects()
	{
		this.body.isKinematic = true;
		this.body.velocity = Vector3.zero;
		yield return new WaitForSeconds(1f);
		if (this.corpseFlame)
		{
			this.corpseFlame.Stop();
		}
		if (this.anticSteam)
		{
			this.anticSteam.Play();
		}
		this.body.velocity = Vector2.zero;
		this.gushSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		yield return this.StartCoroutine(this.Jitter(0.9f));
		this.explodeSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		if (this.anticSteam)
		{
			this.anticSteam.Stop();
		}
		GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
		if (gameCameras)
		{
			gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
		}
		if (this.gasAttack)
		{
			this.gasAttack.Play();
		}
		if (this.gasHitBox)
		{
			this.gasHitBox.SetActive(true);
			Vector3 localScale = this.gasHitBox.transform.localScale;
			this.gasHitBox.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
			iTween.ScaleTo(this.gasHitBox, iTween.Hash(new object[]
			{
				"scale",
				localScale,
				"time",
				0.4f,
				"easetype",
				iTween.EaseType.easeOutCirc,
				"islocal",
				true
			}));
			yield return new WaitForSeconds(0.4f);
		}
		this.meshRenderer.enabled = false;
		yield return new WaitForSeconds(0.4f);
		if (this.gasHitBox)
		{
			this.gasHitBox.SetActive(false);
		}
		yield break;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0002E175 File Offset: 0x0002C375
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

	// Token: 0x04000941 RID: 2369
	[Header("Fungus Explode Variables")]
	public ParticleSystem anticSteam;

	// Token: 0x04000942 RID: 2370
	public ParticleSystem gasAttack;

	// Token: 0x04000943 RID: 2371
	public AudioEvent gushSound;

	// Token: 0x04000944 RID: 2372
	public AudioEvent explodeSound;

	// Token: 0x04000945 RID: 2373
	public GameObject gasHitBox;
}
