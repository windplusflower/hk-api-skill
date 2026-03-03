using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000171 RID: 369
public class Crawler : MonoBehaviour
{
	// Token: 0x0600087E RID: 2174 RVA: 0x0002EB8D File Offset: 0x0002CD8D
	private void Awake()
	{
		this.body = base.GetComponent<Rigidbody2D>();
		this.recoil = base.GetComponent<Recoil>();
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0002EBB4 File Offset: 0x0002CDB4
	private void Start()
	{
		float z = base.transform.eulerAngles.z;
		if (z >= 45f && z <= 135f)
		{
			this.type = Crawler.CrawlerType.Wall;
			this.velocity = new Vector2(0f, Mathf.Sign(-base.transform.localScale.x) * this.speed);
		}
		else if (z >= 135f && z <= 225f)
		{
			this.type = ((base.transform.localScale.y > 0f) ? Crawler.CrawlerType.Roof : Crawler.CrawlerType.Floor);
			this.velocity = new Vector2(Mathf.Sign(base.transform.localScale.x) * this.speed, 0f);
		}
		else if (z >= 225f && z <= 315f)
		{
			this.type = Crawler.CrawlerType.Wall;
			this.velocity = new Vector2(0f, Mathf.Sign(base.transform.localScale.x) * this.speed);
		}
		else
		{
			this.type = ((base.transform.localScale.y > 0f) ? Crawler.CrawlerType.Floor : Crawler.CrawlerType.Roof);
			this.velocity = new Vector2(Mathf.Sign(-base.transform.localScale.x) * this.speed, 0f);
		}
		this.recoil.SetRecoilSpeed(0f);
		this.recoil.OnCancelRecoil += delegate()
		{
			this.body.velocity = this.velocity;
		};
		Crawler.CrawlerType crawlerType = this.type;
		if (crawlerType != Crawler.CrawlerType.Floor)
		{
			if (crawlerType - Crawler.CrawlerType.Roof <= 1)
			{
				this.body.gravityScale = 0f;
				this.recoil.freezeInPlace = true;
			}
		}
		else
		{
			this.body.gravityScale = 1f;
			this.recoil.freezeInPlace = false;
		}
		base.StartCoroutine(this.Walk());
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0002ED90 File Offset: 0x0002CF90
	private IEnumerator Walk()
	{
		for (;;)
		{
			this.anim.Play("Walk");
			this.body.velocity = this.velocity;
			bool hit = false;
			while (!hit)
			{
				if (this.CheckRayLocal(this.wallCheck.localPosition, (this.transform.localScale.x > 0f) ? Vector2.left : Vector2.right, 1f))
				{
					hit = true;
					break;
				}
				if (!this.CheckRayLocal(this.groundCheck.localPosition, (this.transform.localScale.y > 0f) ? Vector2.down : Vector2.up, 1f))
				{
					hit = true;
					break;
				}
				yield return null;
			}
			yield return this.StartCoroutine(this.Turn());
			yield return null;
		}
		yield break;
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x0002ED9F File Offset: 0x0002CF9F
	private IEnumerator Turn()
	{
		this.body.velocity = Vector2.zero;
		yield return this.StartCoroutine(this.anim.PlayAnimWait("Turn"));
		this.transform.SetScaleX(this.transform.localScale.x * -1f);
		this.velocity.x = this.velocity.x * -1f;
		this.velocity.y = this.velocity.y * -1f;
		yield break;
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0002EDB0 File Offset: 0x0002CFB0
	public bool CheckRayLocal(Vector2 originLocal, Vector2 directionLocal, float length)
	{
		Vector2 vector = base.transform.TransformPoint(originLocal);
		Vector2 vector2 = base.transform.TransformDirection(directionLocal);
		RaycastHit2D raycastHit2D = Physics2D.Raycast(vector, vector2, length, 256);
		Debug.DrawLine(vector, vector + vector2 * length);
		return raycastHit2D.collider != null;
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0002EE23 File Offset: 0x0002D023
	public Crawler()
	{
		this.speed = 2f;
		base..ctor();
	}

	// Token: 0x04000965 RID: 2405
	public float speed;

	// Token: 0x04000966 RID: 2406
	[Space]
	public Transform wallCheck;

	// Token: 0x04000967 RID: 2407
	public Transform groundCheck;

	// Token: 0x04000968 RID: 2408
	private Vector2 velocity;

	// Token: 0x04000969 RID: 2409
	private Crawler.CrawlerType type;

	// Token: 0x0400096A RID: 2410
	private Rigidbody2D body;

	// Token: 0x0400096B RID: 2411
	private Recoil recoil;

	// Token: 0x0400096C RID: 2412
	private tk2dSpriteAnimator anim;

	// Token: 0x02000172 RID: 370
	private enum CrawlerType
	{
		// Token: 0x0400096E RID: 2414
		Floor,
		// Token: 0x0400096F RID: 2415
		Roof,
		// Token: 0x04000970 RID: 2416
		Wall
	}
}
