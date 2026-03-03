using System;
using UnityEngine;

// Token: 0x0200039B RID: 923
public class BreakablePole : MonoBehaviour, IHitResponder
{
	// Token: 0x06001553 RID: 5459 RVA: 0x00065B2C File Offset: 0x00063D2C
	protected void Reset()
	{
		this.inertBackgroundThreshold = -1f;
		this.inertForegroundThreshold = 1f;
	}

	// Token: 0x06001554 RID: 5460 RVA: 0x00065B44 File Offset: 0x00063D44
	protected void Start()
	{
		float z = base.transform.position.z;
		if (z < this.inertBackgroundThreshold || z > this.inertForegroundThreshold)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001555 RID: 5461 RVA: 0x00065B7C File Offset: 0x00063D7C
	public void Hit(HitInstance damageInstance)
	{
		int cardinalDirection = DirectionUtils.GetCardinalDirection(damageInstance.Direction);
		if (cardinalDirection != 2 && cardinalDirection != 0)
		{
			return;
		}
		this.spriteRenderer.sprite = this.brokenSprite;
		Transform transform = this.slashImpactPrefab.Spawn().transform;
		transform.eulerAngles = new Vector3(0f, 0f, UnityEngine.Random.Range(340f, 380f));
		Vector3 localScale = transform.localScale;
		localScale.x = ((cardinalDirection == 2) ? -1f : 1f);
		localScale.y = 1f;
		this.hitClip.SpawnAndPlayOneShot(this.audioSourcePrefab, base.transform.position);
		this.top.gameObject.SetActive(true);
		float num = (float)((cardinalDirection == 2) ? UnityEngine.Random.Range(120, 140) : UnityEngine.Random.Range(40, 60));
		this.top.velocity = new Vector2(Mathf.Cos(num * 0.017453292f), Mathf.Sin(num * 0.017453292f)) * 17f;
		base.enabled = false;
	}

	// Token: 0x04001990 RID: 6544
	[SerializeField]
	private SpriteRenderer spriteRenderer;

	// Token: 0x04001991 RID: 6545
	[SerializeField]
	private Sprite brokenSprite;

	// Token: 0x04001992 RID: 6546
	[SerializeField]
	private float inertBackgroundThreshold;

	// Token: 0x04001993 RID: 6547
	[SerializeField]
	private float inertForegroundThreshold;

	// Token: 0x04001994 RID: 6548
	[SerializeField]
	private AudioSource audioSourcePrefab;

	// Token: 0x04001995 RID: 6549
	[SerializeField]
	private RandomAudioClipTable hitClip;

	// Token: 0x04001996 RID: 6550
	[SerializeField]
	private GameObject slashImpactPrefab;

	// Token: 0x04001997 RID: 6551
	[SerializeField]
	private Rigidbody2D top;
}
