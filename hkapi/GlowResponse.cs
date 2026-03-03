using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003C5 RID: 965
public class GlowResponse : MonoBehaviour
{
	// Token: 0x0600162A RID: 5674 RVA: 0x00068FA5 File Offset: 0x000671A5
	private void OnValidate()
	{
		this.HandleUpgrade();
	}

	// Token: 0x0600162B RID: 5675 RVA: 0x00068FA5 File Offset: 0x000671A5
	private void Awake()
	{
		this.HandleUpgrade();
	}

	// Token: 0x0600162C RID: 5676 RVA: 0x00068FAD File Offset: 0x000671AD
	private void HandleUpgrade()
	{
		if (this.fadeSprite)
		{
			this.FadeSprites.Add(this.fadeSprite);
			this.fadeSprite = null;
		}
	}

	// Token: 0x0600162D RID: 5677 RVA: 0x00068FD4 File Offset: 0x000671D4
	private void Start()
	{
		foreach (SpriteRenderer spriteRenderer in this.FadeSprites)
		{
			if (spriteRenderer)
			{
				Color color = spriteRenderer.color;
				color.a = 0f;
				spriteRenderer.color = color;
			}
		}
		if (this.light)
		{
			this.lightStart = this.light.intensity;
			this.light.intensity = 0f;
			this.light.enabled = false;
		}
	}

	// Token: 0x0600162E RID: 5678 RVA: 0x0006907C File Offset: 0x0006727C
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.particles)
		{
			this.particles.Play();
		}
		Vector3 position = base.transform.position;
		position.z = 0f;
		this.soundEffect.SpawnAndPlayOneShot(this.audioPlayerPrefab, position);
		this.FadeTo(1f);
	}

	// Token: 0x0600162F RID: 5679 RVA: 0x000690D6 File Offset: 0x000672D6
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (this.particles)
		{
			this.particles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		this.FadeTo(0f);
	}

	// Token: 0x06001630 RID: 5680 RVA: 0x00069100 File Offset: 0x00067300
	private void FadeTo(float alpha)
	{
		foreach (SpriteRenderer spriteRenderer in this.FadeSprites)
		{
			if (this.fadeRoutines.ContainsKey(spriteRenderer) && this.fadeRoutines[spriteRenderer] != null)
			{
				base.StopCoroutine(this.fadeRoutines[spriteRenderer]);
			}
			if (base.gameObject.activeInHierarchy)
			{
				this.fadeRoutines[spriteRenderer] = base.StartCoroutine(this.Fade(alpha, spriteRenderer));
			}
		}
	}

	// Token: 0x06001631 RID: 5681 RVA: 0x000691A4 File Offset: 0x000673A4
	private IEnumerator Fade(float toAlpha, SpriteRenderer sprite)
	{
		float elapsed = 0f;
		Color initialColor = sprite ? sprite.color : Color.white;
		Color currentColor = initialColor;
		bool fadeUp = toAlpha > 0.1f;
		float startIntensity = this.light ? this.light.intensity : 0f;
		float toIntensity = fadeUp ? this.lightStart : 0f;
		if (this.light && fadeUp)
		{
			this.light.enabled = true;
		}
		while (elapsed < this.fadeTime)
		{
			if (sprite)
			{
				currentColor.a = Mathf.Lerp(initialColor.a, toAlpha, elapsed / this.fadeTime);
				sprite.color = currentColor;
			}
			if (this.light)
			{
				this.light.intensity = Mathf.Lerp(startIntensity, toIntensity, elapsed / this.fadeTime);
			}
			yield return null;
			elapsed += Time.deltaTime;
		}
		if (sprite)
		{
			currentColor.a = toAlpha;
			sprite.color = currentColor;
		}
		if (this.light && !fadeUp)
		{
			this.light.enabled = false;
		}
		yield break;
	}

	// Token: 0x06001632 RID: 5682 RVA: 0x000691C4 File Offset: 0x000673C4
	public void FadeEnd()
	{
		this.FadeTo(0f);
		if (this.particles)
		{
			this.particles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		CircleCollider2D component = base.GetComponent<CircleCollider2D>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	// Token: 0x06001633 RID: 5683 RVA: 0x0006920D File Offset: 0x0006740D
	public GlowResponse()
	{
		this.FadeSprites = new List<SpriteRenderer>();
		this.fadeTime = 0.5f;
		this.fadeRoutines = new Dictionary<SpriteRenderer, Coroutine>();
		base..ctor();
	}

	// Token: 0x04001A92 RID: 6802
	[HideInInspector]
	[SerializeField]
	private SpriteRenderer fadeSprite;

	// Token: 0x04001A93 RID: 6803
	public List<SpriteRenderer> FadeSprites;

	// Token: 0x04001A94 RID: 6804
	public float fadeTime;

	// Token: 0x04001A95 RID: 6805
	public ParticleSystem particles;

	// Token: 0x04001A96 RID: 6806
	public Light light;

	// Token: 0x04001A97 RID: 6807
	private float lightStart;

	// Token: 0x04001A98 RID: 6808
	public AudioSource audioPlayerPrefab;

	// Token: 0x04001A99 RID: 6809
	public AudioEventRandom soundEffect;

	// Token: 0x04001A9A RID: 6810
	private Dictionary<SpriteRenderer, Coroutine> fadeRoutines;
}
