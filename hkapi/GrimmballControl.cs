using System;
using System.Collections;
using UnityEngine;

// Token: 0x020002B5 RID: 693
public class GrimmballControl : MonoBehaviour
{
	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00048B8D File Offset: 0x00046D8D
	// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x00048B95 File Offset: 0x00046D95
	public float Force
	{
		get
		{
			return this.force;
		}
		set
		{
			this.force = value;
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x06000EAA RID: 3754 RVA: 0x00048B9E File Offset: 0x00046D9E
	// (set) Token: 0x06000EAB RID: 3755 RVA: 0x00048BA6 File Offset: 0x00046DA6
	public float TweenY
	{
		get
		{
			return this.tweenY;
		}
		set
		{
			this.tweenY = value;
		}
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00048BAF File Offset: 0x00046DAF
	private void Awake()
	{
		this.col = base.GetComponent<Collider2D>();
		this.body = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00048BCC File Offset: 0x00046DCC
	private void OnEnable()
	{
		this.force = 0f;
		this.tweenY = 0f;
		this.col.enabled = true;
		this.hit = false;
		this.ptFlame.Play();
		this.ptSmoke.Play();
		base.transform.localScale = Vector3.one;
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00048C28 File Offset: 0x00046E28
	private void OnDisable()
	{
		iTween.Stop(base.gameObject);
		if (this.fireRoutine != null)
		{
			base.StopCoroutine(this.fireRoutine);
			this.fireRoutine = null;
		}
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00048C50 File Offset: 0x00046E50
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.layer == 8 && this.shrinkRoutine == null && !this.hit)
		{
			this.DoHit();
		}
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00048C76 File Offset: 0x00046E76
	public void DoHit()
	{
		this.hit = true;
		if (this.fireRoutine != null)
		{
			base.StopCoroutine(this.fireRoutine);
			this.fireRoutine = null;
		}
		this.shrinkRoutine = base.StartCoroutine(this.Shrink());
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00048CAC File Offset: 0x00046EAC
	public void Fire()
	{
		if (this.fireRoutine == null)
		{
			this.fireRoutine = base.StartCoroutine(this.DoFire());
		}
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00048CC8 File Offset: 0x00046EC8
	private IEnumerator DoFire()
	{
		Vector3 vector = new Vector3(0f, this.tweenY + UnityEngine.Random.Range(-0.2f, 0.2f), 0f);
		iTween.MoveBy(this.gameObject, iTween.Hash(new object[]
		{
			"amount",
			vector,
			"time",
			0.7f,
			"easetype",
			iTween.EaseType.easeOutSine,
			"space",
			Space.World
		}));
		for (float elapsed = 0f; elapsed < this.maxLifeTime; elapsed += Time.fixedDeltaTime)
		{
			this.body.AddForce(new Vector2(this.force, 0f), ForceMode2D.Force);
			yield return new WaitForFixedUpdate();
		}
		this.DoHit();
		yield break;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00048CD7 File Offset: 0x00046ED7
	private IEnumerator Shrink()
	{
		this.ptFlame.Stop();
		this.ptSmoke.Stop();
		this.col.enabled = false;
		float time = 0.5f;
		iTween.ScaleTo(this.gameObject, iTween.Hash(new object[]
		{
			"scale",
			Vector3.zero,
			"time",
			time,
			"easetype",
			iTween.EaseType.linear
		}));
		for (float elapsed = 0f; elapsed < time; elapsed += Time.deltaTime)
		{
			this.body.velocity *= 0.85f;
			yield return null;
		}
		this.shrinkRoutine = null;
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00048CE6 File Offset: 0x00046EE6
	public GrimmballControl()
	{
		this.maxLifeTime = 10f;
		base..ctor();
	}

	// Token: 0x04000F65 RID: 3941
	public ParticleSystem ptFlame;

	// Token: 0x04000F66 RID: 3942
	public ParticleSystem ptSmoke;

	// Token: 0x04000F67 RID: 3943
	public float maxLifeTime;

	// Token: 0x04000F68 RID: 3944
	private Collider2D col;

	// Token: 0x04000F69 RID: 3945
	private Rigidbody2D body;

	// Token: 0x04000F6A RID: 3946
	private Coroutine fireRoutine;

	// Token: 0x04000F6B RID: 3947
	private Coroutine shrinkRoutine;

	// Token: 0x04000F6C RID: 3948
	private float force;

	// Token: 0x04000F6D RID: 3949
	private float tweenY;

	// Token: 0x04000F6E RID: 3950
	private bool hit;

	// Token: 0x04000F6F RID: 3951
	private bool addForce;
}
