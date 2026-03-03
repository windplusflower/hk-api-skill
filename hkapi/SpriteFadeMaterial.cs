using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000091 RID: 145
public class SpriteFadeMaterial : MonoBehaviour
{
	// Token: 0x06000302 RID: 770 RVA: 0x0000FEC7 File Offset: 0x0000E0C7
	private void Awake()
	{
		this.sprites = base.GetComponentsInChildren<SpriteRenderer>();
	}

	// Token: 0x06000303 RID: 771 RVA: 0x0000FED8 File Offset: 0x0000E0D8
	private void Start()
	{
		SpriteRenderer[] array = this.sprites;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].sharedMaterial = this.initialMaterial;
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0000FF08 File Offset: 0x0000E108
	public void FadeBack()
	{
		if (this.fadeRoutine != null)
		{
			base.StopCoroutine(this.fadeRoutine);
		}
		if (this.onFadeEnd != null)
		{
			this.onFadeEnd();
			this.onFadeEnd = null;
		}
		this.fadeRoutine = base.StartCoroutine(this.FadeBackRoutine());
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0000FF55 File Offset: 0x0000E155
	private IEnumerator FadeBackRoutine()
	{
		SpriteRenderer[] newSprites = new SpriteRenderer[this.sprites.Length];
		for (int i = 0; i < newSprites.Length; i++)
		{
			newSprites[i] = UnityEngine.Object.Instantiate<SpriteRenderer>(this.sprites[i], this.sprites[i].transform.parent);
			newSprites[i].transform.Translate(new Vector3(0f, 0f, -0.001f), Space.World);
			newSprites[i].gameObject.name = this.sprites[i].gameObject.name;
			newSprites[i].sharedMaterial = this.initialMaterial;
			newSprites[i].color = Color.clear;
		}
		this.onFadeEnd = delegate()
		{
			SpriteRenderer[] newSprites2 = newSprites;
			for (int k = 0; k < newSprites2.Length; k++)
			{
				newSprites2[k].color = Color.white;
			}
			for (int l = 0; l < this.sprites.Length; l++)
			{
				UnityEngine.Object.DestroyImmediate(this.sprites[l].gameObject);
			}
			Animator component = this.GetComponent<Animator>();
			if (component)
			{
				component.Rebind();
			}
			this.sprites = newSprites;
		};
		for (float elapsed = 0f; elapsed <= this.fadeBackDuration; elapsed += Time.deltaTime)
		{
			SpriteRenderer[] newSprites3 = newSprites;
			for (int j = 0; j < newSprites3.Length; j++)
			{
				newSprites3[j].color = Color.Lerp(Color.clear, Color.white, elapsed / this.fadeBackDuration);
			}
			yield return null;
		}
		if (this.onFadeEnd != null)
		{
			this.onFadeEnd();
			this.onFadeEnd = null;
		}
		this.fadeRoutine = null;
		yield break;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0000FF64 File Offset: 0x0000E164
	public SpriteFadeMaterial()
	{
		this.fadeBackDuration = 1f;
		base..ctor();
	}

	// Token: 0x04000280 RID: 640
	public Material initialMaterial;

	// Token: 0x04000281 RID: 641
	public float fadeBackDuration;

	// Token: 0x04000282 RID: 642
	private SpriteRenderer[] sprites;

	// Token: 0x04000283 RID: 643
	private Coroutine fadeRoutine;

	// Token: 0x04000284 RID: 644
	private Action onFadeEnd;
}
