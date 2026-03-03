using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000057 RID: 87
[RequireComponent(typeof(SpriteRenderer))]
public class BasicSpriteAnimator : MonoBehaviour
{
	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060001CB RID: 459 RVA: 0x0000C006 File Offset: 0x0000A206
	public float Length
	{
		get
		{
			return (float)this.frames.Length / this.fps;
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0000C018 File Offset: 0x0000A218
	private void Awake()
	{
		this.rend = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0000C026 File Offset: 0x0000A226
	private void OnEnable()
	{
		if (this.frames.Length > 1)
		{
			this.animRoutine = base.StartCoroutine(this.Animate());
		}
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0000C045 File Offset: 0x0000A245
	private void OnDisable()
	{
		if (this.animRoutine != null)
		{
			base.StopCoroutine(this.animRoutine);
		}
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000C05B File Offset: 0x0000A25B
	private IEnumerator Animate()
	{
		int index = 0;
		if (this.startRandom)
		{
			index = UnityEngine.Random.Range(0, this.frames.Length);
		}
		for (;;)
		{
			if (this.rend.enabled)
			{
				this.rend.sprite = this.frames[index];
			}
			yield return new WaitForSeconds(1f / this.fps);
			int num = index;
			index = num + 1;
			if (index >= this.frames.Length)
			{
				if (!this.looping)
				{
					break;
				}
				index = 0;
			}
		}
		yield break;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0000C06A File Offset: 0x0000A26A
	public BasicSpriteAnimator()
	{
		this.fps = 30f;
		this.startRandom = true;
		this.looping = true;
		base..ctor();
	}

	// Token: 0x04000175 RID: 373
	public float fps;

	// Token: 0x04000176 RID: 374
	[Space]
	public Sprite[] frames;

	// Token: 0x04000177 RID: 375
	public bool startRandom;

	// Token: 0x04000178 RID: 376
	public bool looping;

	// Token: 0x04000179 RID: 377
	private SpriteRenderer rend;

	// Token: 0x0400017A RID: 378
	private Coroutine animRoutine;
}
