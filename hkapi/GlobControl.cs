using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003C2 RID: 962
[RequireComponent(typeof(Collider2D))]
public class GlobControl : MonoBehaviour
{
	// Token: 0x0600161A RID: 5658 RVA: 0x00068B48 File Offset: 0x00066D48
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x0600161B RID: 5659 RVA: 0x00068B58 File Offset: 0x00066D58
	private void OnEnable()
	{
		float num = UnityEngine.Random.Range(this.minScale, this.maxScale);
		base.transform.localScale = new Vector3(num, num, 1f);
		if (this.splatChild)
		{
			this.splatChild.SetActive(false);
		}
		this.landed = false;
		this.broken = false;
	}

	// Token: 0x0600161C RID: 5660 RVA: 0x00068BB8 File Offset: 0x00066DB8
	private void Start()
	{
		CollisionEnterEvent collision = base.GetComponent<CollisionEnterEvent>();
		if (collision)
		{
			collision.OnCollisionEnteredDirectional += delegate(CollisionEnterEvent.Direction direction, Collision2D col)
			{
				if (!this.landed)
				{
					if (direction == CollisionEnterEvent.Direction.Bottom)
					{
						this.landed = true;
						collision.doCollisionStay = false;
						if (this.CheckForGround())
						{
							this.anim.Play(this.landAnim);
							return;
						}
						this.StartCoroutine(this.Break());
						return;
					}
					else
					{
						collision.doCollisionStay = true;
					}
				}
			};
		}
		TriggerEnterEvent componentInChildren = base.GetComponentInChildren<TriggerEnterEvent>();
		if (componentInChildren)
		{
			componentInChildren.OnTriggerEntered += delegate(Collider2D col, GameObject sender)
			{
				if (!this.landed || this.broken)
				{
					return;
				}
				if (col.gameObject.layer == 11)
				{
					this.anim.Play(this.wobbleAnim);
				}
			};
		}
	}

	// Token: 0x0600161D RID: 5661 RVA: 0x00068C24 File Offset: 0x00066E24
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (!this.landed || this.broken)
		{
			return;
		}
		if (col.tag == "Nail Attack")
		{
			base.StartCoroutine(this.Break());
			return;
		}
		if (col.tag == "HeroBox")
		{
			this.anim.Play(this.wobbleAnim);
		}
	}

	// Token: 0x0600161E RID: 5662 RVA: 0x00068C85 File Offset: 0x00066E85
	private IEnumerator Break()
	{
		this.broken = true;
		this.breakSound.SpawnAndPlayOneShot(this.audioPlayerPrefab, this.transform.position);
		GlobalPrefabDefaults.Instance.SpawnBlood(this.transform.position, 4, 5, 5f, 20f, 80f, 100f, new Color?(this.bloodColorOverride));
		if (this.splatChild)
		{
			this.splatChild.SetActive(true);
		}
		yield return this.anim.PlayAnimWait(this.breakAnim);
		if (this.rend)
		{
			this.rend.enabled = false;
		}
		yield break;
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00068C94 File Offset: 0x00066E94
	private bool CheckForGround()
	{
		if (!this.groundCollider)
		{
			return true;
		}
		Vector2 vector = this.groundCollider.bounds.min;
		Vector2 vector2 = this.groundCollider.bounds.max;
		float num = vector2.y - vector.y;
		vector.y = vector2.y;
		vector.x += 0.1f;
		vector2.x -= 0.1f;
		RaycastHit2D raycastHit2D = Physics2D.Raycast(vector, Vector2.down, num + 0.25f, 256);
		RaycastHit2D raycastHit2D2 = Physics2D.Raycast(vector2, Vector2.down, num + 0.25f, 256);
		return raycastHit2D.collider != null && raycastHit2D2.collider != null;
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00068D70 File Offset: 0x00066F70
	public GlobControl()
	{
		this.minScale = 0.6f;
		this.maxScale = 1.6f;
		this.landAnim = "Glob Land";
		this.wobbleAnim = "Glob Wobble";
		this.breakAnim = "Glob Break";
		this.bloodColorOverride = new Color(1f, 0.537f, 0.188f);
		base..ctor();
	}

	// Token: 0x04001A7F RID: 6783
	public Renderer rend;

	// Token: 0x04001A80 RID: 6784
	[Space]
	public float minScale;

	// Token: 0x04001A81 RID: 6785
	public float maxScale;

	// Token: 0x04001A82 RID: 6786
	[Space]
	public string landAnim;

	// Token: 0x04001A83 RID: 6787
	public string wobbleAnim;

	// Token: 0x04001A84 RID: 6788
	public string breakAnim;

	// Token: 0x04001A85 RID: 6789
	[Space]
	public AudioSource audioPlayerPrefab;

	// Token: 0x04001A86 RID: 6790
	public AudioEvent breakSound;

	// Token: 0x04001A87 RID: 6791
	public Color bloodColorOverride;

	// Token: 0x04001A88 RID: 6792
	[Space]
	public GameObject splatChild;

	// Token: 0x04001A89 RID: 6793
	[Space]
	public Collider2D groundCollider;

	// Token: 0x04001A8A RID: 6794
	private bool landed;

	// Token: 0x04001A8B RID: 6795
	private bool broken;

	// Token: 0x04001A8C RID: 6796
	private tk2dSpriteAnimator anim;
}
