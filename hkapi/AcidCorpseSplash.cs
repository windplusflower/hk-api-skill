using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000052 RID: 82
public class AcidCorpseSplash : MonoBehaviour
{
	// Token: 0x060001B5 RID: 437 RVA: 0x0000BAEE File Offset: 0x00009CEE
	private void Start()
	{
		if (this.corpseDetector)
		{
			this.corpseDetector.OnTriggerEntered += delegate(Collider2D col, GameObject sender)
			{
				base.StartCoroutine(this.CorpseSplash(col.gameObject));
			};
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0000BB14 File Offset: 0x00009D14
	private IEnumerator CorpseSplash(GameObject corpseObject)
	{
		Corpse component = corpseObject.GetComponent<Corpse>();
		if (component)
		{
			component.Acid();
			Rigidbody2D body = corpseObject.GetComponent<Rigidbody2D>();
			this.splashSound.SpawnAndPlayOneShot(this.audioPlayerPefab, corpseObject.transform.position);
			Vector3 position = corpseObject.transform.position;
			if (this.corpseDetector)
			{
				BoxCollider2D component2 = this.corpseDetector.GetComponent<BoxCollider2D>();
				if (component2)
				{
					position.y = component2.bounds.max.y;
				}
			}
			if (this.acidSplashPrefab)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.acidSplashPrefab, position + new Vector3(0f, 0f, -0.1f), this.acidSplashPrefab.transform.rotation);
			}
			if (this.acidSteamPrefab)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.acidSteamPrefab, position, this.acidSteamPrefab.transform.rotation);
			}
			ParticleSystem acidBubble = null;
			if (this.bubCloudPrefab)
			{
				acidBubble = UnityEngine.Object.Instantiate<ParticleSystem>(this.bubCloudPrefab, position, this.bubCloudPrefab.transform.rotation);
				if (acidBubble)
				{
					acidBubble.Play();
				}
			}
			ParticleSystem acidSpore = null;
			if (this.sporeCloudPrefab)
			{
				acidSpore = UnityEngine.Object.Instantiate<ParticleSystem>(this.sporeCloudPrefab, position, this.sporeCloudPrefab.transform.rotation);
				if (acidSpore)
				{
					acidSpore.Play();
				}
			}
			for (float elapsed = 0f; elapsed <= 0.5f; elapsed += Time.fixedDeltaTime)
			{
				if (body)
				{
					body.velocity *= 0.1f;
				}
				yield return new WaitForFixedUpdate();
			}
			if (body)
			{
				body.isKinematic = true;
			}
			if (corpseObject)
			{
				tk2dSprite rend = corpseObject.GetComponent<tk2dSprite>();
				if (rend)
				{
					float elapsed = 0f;
					float fadeTime = 1f;
					while (elapsed <= fadeTime)
					{
						rend.color = Color.Lerp(Color.white, Color.clear, elapsed / fadeTime);
						yield return null;
						elapsed += Time.deltaTime;
					}
				}
				rend = null;
			}
			if (acidBubble)
			{
				acidBubble.Stop();
			}
			if (acidSpore)
			{
				acidSpore.Stop();
			}
			body = null;
			acidBubble = null;
			acidSpore = null;
		}
		yield break;
	}

	// Token: 0x0400015C RID: 348
	public TriggerEnterEvent corpseDetector;

	// Token: 0x0400015D RID: 349
	[Space]
	public GameObject acidSplashPrefab;

	// Token: 0x0400015E RID: 350
	public GameObject acidSteamPrefab;

	// Token: 0x0400015F RID: 351
	public ParticleSystem sporeCloudPrefab;

	// Token: 0x04000160 RID: 352
	public ParticleSystem bubCloudPrefab;

	// Token: 0x04000161 RID: 353
	[Space]
	public AudioSource audioPlayerPefab;

	// Token: 0x04000162 RID: 354
	public AudioEvent splashSound;
}
