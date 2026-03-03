using System;
using UnityEngine;

// Token: 0x0200039C RID: 924
public class BreakablePoleSimple : MonoBehaviour
{
	// Token: 0x06001557 RID: 5463 RVA: 0x00065C8E File Offset: 0x00063E8E
	private void Awake()
	{
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x00065C9C File Offset: 0x00063E9C
	private void Start()
	{
		if (Mathf.Abs(base.transform.position.z - 0.004f) > 1f)
		{
			if (this.source)
			{
				this.source.enabled = false;
			}
			Collider2D component = base.GetComponent<Collider2D>();
			if (component)
			{
				component.enabled = false;
			}
			base.enabled = false;
		}
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00065D04 File Offset: 0x00063F04
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.activated)
		{
			return;
		}
		bool flag = false;
		float num = 1f;
		if (collision.tag == "Nail Attack")
		{
			float value = PlayMakerFSM.FindFsmOnGameObject(collision.gameObject, "damages_enemy").FsmVariables.FindFsmFloat("direction").Value;
			if (value < 45f)
			{
				flag = true;
				num = 1f;
			}
			else if (value < 135f)
			{
				flag = false;
			}
			else if (value < 225f)
			{
				flag = true;
				num = -1f;
			}
			else if (value < 360f)
			{
				flag = false;
			}
		}
		else if (collision.tag == "Hero Spell")
		{
			flag = true;
		}
		if (flag)
		{
			SpriteRenderer component = base.GetComponent<SpriteRenderer>();
			if (component)
			{
				component.enabled = false;
			}
			if (this.bottom)
			{
				this.bottom.SetActive(true);
			}
			if (this.top)
			{
				this.top.SetActive(true);
				float num2 = UnityEngine.Random.Range(this.angleMin, this.angleMax);
				Vector2 velocity;
				velocity.x = this.speed * Mathf.Cos(num2 * 0.017453292f) * num;
				velocity.y = this.speed * Mathf.Sin(num2 * 0.017453292f);
				Rigidbody2D component2 = this.top.GetComponent<Rigidbody2D>();
				if (component2)
				{
					component2.velocity = velocity;
				}
			}
			if (this.slashEffectPrefab)
			{
				GameObject gameObject = this.slashEffectPrefab.Spawn(base.transform.position);
				gameObject.transform.SetScaleX(num);
				gameObject.transform.SetRotationZ(UnityEngine.Random.Range(this.slashAngleMin, this.slashAngleMax));
			}
			if (this.source)
			{
				this.source.pitch = UnityEngine.Random.Range(this.audioPitchMin, this.audioPitchMax);
				this.source.Play();
			}
			this.activated = true;
		}
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00065EE8 File Offset: 0x000640E8
	public BreakablePoleSimple()
	{
		this.speed = 17f;
		this.angleMin = 40f;
		this.angleMax = 60f;
		this.slashAngleMin = 340f;
		this.slashAngleMax = 380f;
		this.audioPitchMin = 0.85f;
		this.audioPitchMax = 1.15f;
		base..ctor();
	}

	// Token: 0x04001998 RID: 6552
	public GameObject bottom;

	// Token: 0x04001999 RID: 6553
	public GameObject top;

	// Token: 0x0400199A RID: 6554
	public float speed;

	// Token: 0x0400199B RID: 6555
	public float angleMin;

	// Token: 0x0400199C RID: 6556
	public float angleMax;

	// Token: 0x0400199D RID: 6557
	[Space]
	public GameObject slashEffectPrefab;

	// Token: 0x0400199E RID: 6558
	public float slashAngleMin;

	// Token: 0x0400199F RID: 6559
	public float slashAngleMax;

	// Token: 0x040019A0 RID: 6560
	[Space]
	public float audioPitchMin;

	// Token: 0x040019A1 RID: 6561
	public float audioPitchMax;

	// Token: 0x040019A2 RID: 6562
	private bool activated;

	// Token: 0x040019A3 RID: 6563
	private AudioSource source;
}
