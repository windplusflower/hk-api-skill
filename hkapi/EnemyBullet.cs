using System;
using System.Collections;
using UnityEngine;

// Token: 0x020001E0 RID: 480
[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBullet : MonoBehaviour
{
	// Token: 0x06000A79 RID: 2681 RVA: 0x00038DCE File Offset: 0x00036FCE
	private void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		this.col = base.GetComponent<Collider2D>();
	}

	// Token: 0x06000A7A RID: 2682 RVA: 0x00038DF4 File Offset: 0x00036FF4
	private void OnEnable()
	{
		this.active = true;
		this.scale = UnityEngine.Random.Range(this.scaleMin, this.scaleMax);
		this.col.enabled = true;
		this.body.isKinematic = false;
		this.body.velocity = Vector2.zero;
		this.body.angularVelocity = 0f;
		this.anim.Play("Idle");
	}

	// Token: 0x06000A7B RID: 2683 RVA: 0x00038E68 File Offset: 0x00037068
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

	// Token: 0x06000A7C RID: 2684 RVA: 0x00038F5A File Offset: 0x0003715A
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.active)
		{
			this.active = false;
			base.StartCoroutine(this.Collision(collision.GetSafeContact().Normal, true));
		}
	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00038F84 File Offset: 0x00037184
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.active && collision.tag == "HeroBox")
		{
			this.active = false;
			base.StartCoroutine(this.Collision(Vector2.zero, false));
		}
	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x00038FBC File Offset: 0x000371BC
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

	// Token: 0x06000A7F RID: 2687 RVA: 0x0003900A File Offset: 0x0003720A
	private IEnumerator Collision(Vector2 normal, bool doRotation)
	{
		this.transform.localScale = new Vector3(this.scale, this.scale, this.transform.localScale.z);
		this.body.isKinematic = true;
		this.body.velocity = Vector2.zero;
		this.body.angularVelocity = 0f;
		tk2dSpriteAnimationClip impactAnim = this.anim.GetClipByName("Impact");
		this.anim.Play(impactAnim);
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
		this.impactSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		yield return null;
		this.col.enabled = false;
		yield return new WaitForSeconds((float)(impactAnim.frames.Length - 1) / impactAnim.fps);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06000A80 RID: 2688 RVA: 0x00039027 File Offset: 0x00037227
	public EnemyBullet()
	{
		this.scaleMin = 1.15f;
		this.scaleMax = 1.45f;
		this.stretchFactor = 1.2f;
		this.stretchMinX = 0.75f;
		this.stretchMaxY = 1.75f;
		base..ctor();
	}

	// Token: 0x04000B9F RID: 2975
	public float scaleMin;

	// Token: 0x04000BA0 RID: 2976
	public float scaleMax;

	// Token: 0x04000BA1 RID: 2977
	private float scale;

	// Token: 0x04000BA2 RID: 2978
	[Space]
	public float stretchFactor;

	// Token: 0x04000BA3 RID: 2979
	public float stretchMinX;

	// Token: 0x04000BA4 RID: 2980
	public float stretchMaxY;

	// Token: 0x04000BA5 RID: 2981
	[Space]
	public AudioSource audioSourcePrefab;

	// Token: 0x04000BA6 RID: 2982
	public AudioEvent impactSound;

	// Token: 0x04000BA7 RID: 2983
	private bool active;

	// Token: 0x04000BA8 RID: 2984
	private Rigidbody2D body;

	// Token: 0x04000BA9 RID: 2985
	private tk2dSpriteAnimator anim;

	// Token: 0x04000BAA RID: 2986
	private Collider2D col;
}
