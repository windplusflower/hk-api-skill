using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003F0 RID: 1008
public class TouchShake : MonoBehaviour
{
	// Token: 0x060016F8 RID: 5880 RVA: 0x0006D16D File Offset: 0x0006B36D
	private void Start()
	{
		if (this.anim)
		{
			this.anim.enabled = false;
		}
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0006D188 File Offset: 0x0006B388
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "HeroBox" || collision.tag == "Player")
		{
			if (this.anim)
			{
				if (!this.anim.gameObject.activeInHierarchy)
				{
					return;
				}
				if (this.anim && this.animateRoutine == null)
				{
					this.animateRoutine = base.StartCoroutine(this.DoAnimation());
					return;
				}
			}
			else if (this.tk2dAnim)
			{
				if (!this.tk2dAnim.gameObject.activeInHierarchy)
				{
					return;
				}
				if (this.tk2dAnim && this.animateRoutine == null)
				{
					this.animateRoutine = base.StartCoroutine(this.DoAnimation());
				}
			}
		}
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x0006D24B File Offset: 0x0006B44B
	private IEnumerator DoAnimation()
	{
		if (this.particles)
		{
			this.particles.Emit(this.emitParticles);
		}
		if (this.audioTable)
		{
			this.audioTable.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		}
		if (this.spriteRenderer && this.anim)
		{
			yield return this.StartCoroutine(this.SpriteAnimation());
		}
		else if (this.tk2dAnim)
		{
			yield return this.StartCoroutine(this.tk2dAnimation());
		}
		this.animateRoutine = null;
		yield break;
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0006D25A File Offset: 0x0006B45A
	private IEnumerator SpriteAnimation()
	{
		Sprite sprite = this.spriteRenderer.sprite;
		this.anim.enabled = true;
		yield return null;
		yield return new WaitForSeconds(this.anim.Length);
		this.anim.enabled = false;
		this.spriteRenderer.sprite = sprite;
		yield break;
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x0006D269 File Offset: 0x0006B469
	private IEnumerator tk2dAnimation()
	{
		this.tk2dAnim.PlayFromFrame(0);
		yield return new WaitForSeconds(this.tk2dAnim.CurrentClip.Duration);
		yield break;
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x0006D278 File Offset: 0x0006B478
	public TouchShake()
	{
		this.emitParticles = 20;
		base..ctor();
	}

	// Token: 0x04001BBE RID: 7102
	[Header("If using SpriteRenderer")]
	public SpriteRenderer spriteRenderer;

	// Token: 0x04001BBF RID: 7103
	public BasicSpriteAnimator anim;

	// Token: 0x04001BC0 RID: 7104
	[Header("If using tk2D")]
	public tk2dSpriteAnimator tk2dAnim;

	// Token: 0x04001BC1 RID: 7105
	private Coroutine animateRoutine;

	// Token: 0x04001BC2 RID: 7106
	[Header("General")]
	public ParticleSystem particles;

	// Token: 0x04001BC3 RID: 7107
	public int emitParticles;

	// Token: 0x04001BC4 RID: 7108
	public AudioSource audioSourcePrefab;

	// Token: 0x04001BC5 RID: 7109
	public RandomAudioClipTable audioTable;
}
