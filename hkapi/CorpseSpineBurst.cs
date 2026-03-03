using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200016E RID: 366
public class CorpseSpineBurst : Corpse
{
	// Token: 0x06000873 RID: 2163 RVA: 0x0002E894 File Offset: 0x0002CA94
	protected override void LandEffects()
	{
		if (this.spellBurn)
		{
			base.transform.SetPositionZ(0.009f);
			base.StartCoroutine(this.DoLandEffects(false));
			return;
		}
		base.StartCoroutine(this.DoLandEffects(true));
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x0002E8CB File Offset: 0x0002CACB
	private IEnumerator DoLandEffects(bool burst = true)
	{
		this.body.isKinematic = true;
		this.body.velocity = Vector3.zero;
		if (burst)
		{
			yield return new WaitForSeconds(1f);
			this.spriteAnimator.Play("Burst Antic");
			this.shakerExplode.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
			yield return new WaitForSeconds(0.9f);
			this.spriteAnimator.Play("Burst");
			this.zombiePrep.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
			this.zombieShoot.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
			if (this.spineHit)
			{
				this.spineHit.SetActive(true);
			}
			if (this.lines)
			{
				this.lines.SetActive(true);
			}
			if (Vector2.Distance(HeroController.instance.transform.position, this.transform.position) <= 44f)
			{
				GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
				if (gameCameras)
				{
					gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
				}
			}
		}
		HealthManager component = this.GetComponent<HealthManager>();
		if (component)
		{
			component.IsInvincible = false;
		}
		yield break;
	}

	// Token: 0x0400095C RID: 2396
	[Header("Spine Burst Variables")]
	public AudioEvent shakerExplode;

	// Token: 0x0400095D RID: 2397
	public AudioEvent zombiePrep;

	// Token: 0x0400095E RID: 2398
	public AudioEvent zombieShoot;

	// Token: 0x0400095F RID: 2399
	[Space]
	public GameObject spineHit;

	// Token: 0x04000960 RID: 2400
	public GameObject lines;
}
