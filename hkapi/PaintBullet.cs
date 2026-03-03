using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000351 RID: 849
[RequireComponent(typeof(Rigidbody2D))]
public class PaintBullet : MonoBehaviour
{
	// Token: 0x06001345 RID: 4933 RVA: 0x000578D1 File Offset: 0x00055AD1
	private void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.col = base.GetComponent<Collider2D>();
		this.sprite = base.GetComponent<SpriteRenderer>();
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x000578F8 File Offset: 0x00055AF8
	private void OnEnable()
	{
		this.active = true;
		this.scale = UnityEngine.Random.Range(this.scaleMin, this.scaleMax);
		this.sprite.enabled = true;
		this.col.enabled = true;
		this.trailParticle.Play();
		this.body.isKinematic = false;
		this.body.velocity = Vector2.zero;
		this.body.angularVelocity = 0f;
		this.splatList = new List<SpriteRenderer>();
		if (this.colour == 0)
		{
			this.SetBlue();
			return;
		}
		if (this.colour == 1)
		{
			this.SetRed();
			return;
		}
		if (this.colour == 2)
		{
			this.SetPink();
		}
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x000579AC File Offset: 0x00055BAC
	private void Update()
	{
		if (this.active)
		{
			float rotation = Mathf.Atan2(this.body.velocity.y, this.body.velocity.x) * 57.295776f;
			base.transform.SetRotation2D(rotation);
			float num = 1f - this.body.velocity.magnitude * this.stretchFactor * 0.01f;
			float num2 = 1f + this.body.velocity.magnitude * this.stretchFactor * 0.01f;
			if (num2 < this.stretchMinX)
			{
				num2 = this.stretchMinX;
			}
			if (num > this.stretchMaxY)
			{
				num = this.stretchMaxY;
			}
			num *= this.scale;
			num2 *= this.scale;
			base.transform.localScale = new Vector3(num2, num, base.transform.localScale.z);
		}
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x00057AA0 File Offset: 0x00055CA0
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.active && collision.tag == "HeroBox")
		{
			this.active = false;
			base.StartCoroutine(this.Collision(Vector2.zero, false));
		}
		if (this.active && collision.tag == "Extra Tag")
		{
			this.splatList.Add(collision.gameObject.GetComponent<SpriteRenderer>());
		}
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x00057B11 File Offset: 0x00055D11
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (this.active && collision.tag == "Extra Tag")
		{
			this.splatList.Remove(collision.gameObject.GetComponent<SpriteRenderer>());
		}
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x00057B44 File Offset: 0x00055D44
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.active)
		{
			this.active = false;
			base.StartCoroutine(this.Collision(collision.GetSafeContact().Normal, true));
		}
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00057B70 File Offset: 0x00055D70
	public void OrbitShieldHit(Transform shield)
	{
		if (this.active)
		{
			this.active = false;
			Vector2 normal = base.transform.position - shield.position;
			normal.Normalize();
			base.StartCoroutine(this.Collision(normal, true));
		}
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00057BBE File Offset: 0x00055DBE
	private IEnumerator Collision(Vector2 normal, bool doRotation)
	{
		this.transform.localScale = new Vector3(this.scale, this.scale, this.transform.localScale.z);
		this.body.isKinematic = true;
		this.body.velocity = Vector2.zero;
		this.body.angularVelocity = 0f;
		this.sprite.enabled = false;
		this.impactParticle.Play();
		this.trailParticle.Stop();
		this.splatEffect.SetActive(true);
		if (!doRotation || (normal.y >= 0.75f && Mathf.Abs(normal.x) < 0.5f))
		{
			this.transform.SetRotation2D(0f);
		}
		else if (normal.y <= 0.75f && Mathf.Abs(normal.x) < 0.5f)
		{
			this.transform.SetRotation2D(180f);
		}
		else if (normal.x >= 0.75f && Mathf.Abs(normal.y) < 0.5f)
		{
			this.transform.SetRotation2D(270f);
		}
		else if (normal.x <= 0.75f && Mathf.Abs(normal.y) < 0.5f)
		{
			this.transform.SetRotation2D(90f);
		}
		AudioClip clip = this.splatClips[UnityEngine.Random.Range(0, this.splatClips.Count - 1)];
		UnityEngine.Random.Range(0.9f, 1.1f);
		this.audioSourcePrefab.PlayOneShot(clip);
		this.chance = 100;
		this.painting = true;
		foreach (SpriteRenderer spriteRenderer in this.splatList)
		{
			if (this.painting)
			{
				if (UnityEngine.Random.Range(1, 100) <= this.chance)
				{
					spriteRenderer.color = this.sprite.color;
					this.chance /= 2;
				}
				else
				{
					this.painting = false;
				}
			}
		}
		yield return null;
		this.col.enabled = false;
		yield return new WaitForSeconds(1f);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00057BDB File Offset: 0x00055DDB
	public void SetColourBlue()
	{
		this.colour = 0;
		this.SetBlue();
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00057BEA File Offset: 0x00055DEA
	public void SetColourRed()
	{
		this.colour = 1;
		this.SetRed();
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x00057BFC File Offset: 0x00055DFC
	public void SetBlue()
	{
		this.sprite.color = this.colourBlue;
		this.splatEffectSprite.color = this.colourBlue;
		this.impactParticle.startColor = this.colourBlue;
		this.trailParticle.startColor = this.colourBlue;
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x00057C50 File Offset: 0x00055E50
	public void SetRed()
	{
		this.sprite.color = this.colourRed;
		this.splatEffectSprite.color = this.colourRed;
		this.impactParticle.startColor = this.colourRed;
		this.trailParticle.startColor = this.colourRed;
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x00057CA4 File Offset: 0x00055EA4
	public void SetPink()
	{
		this.sprite.color = this.colourPink;
		this.splatEffectSprite.color = this.colourPink;
		this.impactParticle.startColor = this.colourPink;
		this.trailParticle.startColor = this.colourPink;
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x00057CF5 File Offset: 0x00055EF5
	public PaintBullet()
	{
		this.scaleMin = 1.15f;
		this.scaleMax = 1.45f;
		this.stretchFactor = 1.2f;
		this.stretchMinX = 0.75f;
		this.stretchMaxY = 1.75f;
		base..ctor();
	}

	// Token: 0x04001278 RID: 4728
	public float scaleMin;

	// Token: 0x04001279 RID: 4729
	public float scaleMax;

	// Token: 0x0400127A RID: 4730
	private float scale;

	// Token: 0x0400127B RID: 4731
	[Space]
	public float stretchFactor;

	// Token: 0x0400127C RID: 4732
	public float stretchMinX;

	// Token: 0x0400127D RID: 4733
	public float stretchMaxY;

	// Token: 0x0400127E RID: 4734
	[Space]
	public AudioSource audioSourcePrefab;

	// Token: 0x0400127F RID: 4735
	public List<AudioClip> splatClips;

	// Token: 0x04001280 RID: 4736
	[Space]
	public ParticleSystem impactParticle;

	// Token: 0x04001281 RID: 4737
	public ParticleSystem trailParticle;

	// Token: 0x04001282 RID: 4738
	public GameObject splatEffect;

	// Token: 0x04001283 RID: 4739
	public tk2dSprite splatEffectSprite;

	// Token: 0x04001284 RID: 4740
	[Space]
	public Color colourBlue;

	// Token: 0x04001285 RID: 4741
	public Color colourRed;

	// Token: 0x04001286 RID: 4742
	public Color colourPink;

	// Token: 0x04001287 RID: 4743
	private bool active;

	// Token: 0x04001288 RID: 4744
	public int colour;

	// Token: 0x04001289 RID: 4745
	[Space]
	private List<SpriteRenderer> splatList;

	// Token: 0x0400128A RID: 4746
	private int chance;

	// Token: 0x0400128B RID: 4747
	private bool painting;

	// Token: 0x0400128C RID: 4748
	private Rigidbody2D body;

	// Token: 0x0400128D RID: 4749
	private Collider2D col;

	// Token: 0x0400128E RID: 4750
	private SpriteRenderer sprite;
}
