using System;
using UnityEngine;

// Token: 0x020003F9 RID: 1017
public class VinePlatformCut : MonoBehaviour
{
	// Token: 0x06001729 RID: 5929 RVA: 0x0006DCD3 File Offset: 0x0006BED3
	private void Awake()
	{
		this.platform = base.GetComponentInParent<VinePlatform>();
		this.audioSource = base.GetComponentInParent<AudioSource>();
		this.col = base.GetComponent<Collider2D>();
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x0006DCFC File Offset: 0x0006BEFC
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.activated)
		{
			return;
		}
		if (collision.tag == "Nail Attack")
		{
			if (collision.transform.position.y < this.col.bounds.min.y || collision.transform.position.y > this.col.bounds.max.y)
			{
				return;
			}
			float value = PlayMakerFSM.FindFsmOnGameObject(collision.gameObject, "damages_enemy").FsmVariables.FindFsmFloat("direction").Value;
			if (value >= 45f)
			{
				if (value < 135f)
				{
					return;
				}
				if (value >= 225f && value < 360f)
				{
					return;
				}
			}
			Vector3 position = this.cutPointParticles.transform.position;
			position.y = collision.transform.position.y;
			if (this.cutEffectPrefab)
			{
				this.cutEffectPrefab.Spawn(position);
			}
			if (this.cutPointParticles)
			{
				this.cutPointParticles.transform.position = position;
				this.cutPointParticles.SetActive(true);
			}
			this.Cut();
		}
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x0006DE38 File Offset: 0x0006C038
	public void Cut()
	{
		this.activated = true;
		if (this.body)
		{
			this.body.isKinematic = false;
		}
		if (this.cutParticles)
		{
			this.cutParticles.SetActive(true);
		}
		if (this.platform.enemyDetector)
		{
			this.platform.enemyDetector.gameObject.SetActive(true);
		}
		this.platform.respondOnLand = false;
		if (this.platform.landRoutine != null)
		{
			base.StopCoroutine(this.platform.landRoutine);
		}
		if (this.audioSource && this.cutSound)
		{
			this.audioSource.PlayOneShot(this.cutSound);
		}
		this.Disable(false);
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x0006DF02 File Offset: 0x0006C102
	public void Disable(bool disableAll = false)
	{
		if (disableAll)
		{
			base.gameObject.SetActive(false);
			return;
		}
		if (this.sprites)
		{
			this.sprites.SetActive(false);
		}
	}

	// Token: 0x04001BF3 RID: 7155
	public Rigidbody2D body;

	// Token: 0x04001BF4 RID: 7156
	[Space]
	public GameObject sprites;

	// Token: 0x04001BF5 RID: 7157
	[Space]
	public GameObject cutParticles;

	// Token: 0x04001BF6 RID: 7158
	public GameObject cutPointParticles;

	// Token: 0x04001BF7 RID: 7159
	public GameObject cutEffectPrefab;

	// Token: 0x04001BF8 RID: 7160
	[Space]
	public AudioClip cutSound;

	// Token: 0x04001BF9 RID: 7161
	private bool activated;

	// Token: 0x04001BFA RID: 7162
	private VinePlatform platform;

	// Token: 0x04001BFB RID: 7163
	private AudioSource audioSource;

	// Token: 0x04001BFC RID: 7164
	private Collider2D col;
}
