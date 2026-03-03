using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003FB RID: 1019
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(tk2dSpriteAnimator))]
[RequireComponent(typeof(AudioSource))]
public class WaterDrip : MonoBehaviour
{
	// Token: 0x06001730 RID: 5936 RVA: 0x0006DF44 File Offset: 0x0006C144
	private void Awake()
	{
		this.col = base.GetComponent<Collider2D>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x0006DF76 File Offset: 0x0006C176
	private void Start()
	{
		this.startPos = base.transform.position;
		base.StartCoroutine(this.Drip());
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x0006DF9B File Offset: 0x0006C19B
	private IEnumerator Drip()
	{
		for (;;)
		{
			this.anim.Play("Idle");
			this.body.gravityScale = 0f;
			this.body.velocity = Vector2.zero;
			this.col.enabled = false;
			yield return new WaitForSeconds(UnityEngine.Random.Range(this.idleTimeMin, this.idleTimeMax));
			this.col.enabled = true;
			yield return this.StartCoroutine(this.anim.PlayAnimWait("Drip"));
			this.anim.Play("Fall");
			this.body.gravityScale = 1f;
			this.body.velocity = new Vector2(0f, this.fallVelocity);
			this.impacted = false;
			while (!this.impacted)
			{
				yield return null;
			}
			this.body.gravityScale = 0f;
			this.body.velocity = Vector2.zero;
			this.col.enabled = false;
			this.impactAudioClipTable.PlayOneShot(this.source);
			this.transform.position += new Vector3(0f, this.impactTranslation, 0f);
			yield return this.StartCoroutine(this.anim.PlayAnimWait("Impact"));
			this.transform.position = this.startPos;
		}
		yield break;
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x0006DFAA File Offset: 0x0006C1AA
	private void OnCollisionEnter2D(Collision2D collision)
	{
		this.impacted = true;
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x0006DFB3 File Offset: 0x0006C1B3
	public WaterDrip()
	{
		this.idleTimeMin = 2f;
		this.idleTimeMax = 8f;
		this.fallVelocity = -7f;
		this.impactTranslation = -0.5f;
		base..ctor();
	}

	// Token: 0x04001BFD RID: 7165
	public float idleTimeMin;

	// Token: 0x04001BFE RID: 7166
	public float idleTimeMax;

	// Token: 0x04001BFF RID: 7167
	public float fallVelocity;

	// Token: 0x04001C00 RID: 7168
	public RandomAudioClipTable impactAudioClipTable;

	// Token: 0x04001C01 RID: 7169
	public float impactTranslation;

	// Token: 0x04001C02 RID: 7170
	private bool impacted;

	// Token: 0x04001C03 RID: 7171
	private Vector2 startPos;

	// Token: 0x04001C04 RID: 7172
	private Collider2D col;

	// Token: 0x04001C05 RID: 7173
	private Rigidbody2D body;

	// Token: 0x04001C06 RID: 7174
	private tk2dSpriteAnimator anim;

	// Token: 0x04001C07 RID: 7175
	private AudioSource source;
}
