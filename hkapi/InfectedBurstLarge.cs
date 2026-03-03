using System;
using UnityEngine;

// Token: 0x02000079 RID: 121
public class InfectedBurstLarge : MonoBehaviour
{
	// Token: 0x0600029B RID: 667 RVA: 0x0000ECC5 File Offset: 0x0000CEC5
	private void Awake()
	{
		this.vibration = base.GetComponent<VibrationPlayer>();
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0000ECD3 File Offset: 0x0000CED3
	private void Start()
	{
		this.audioSource.pitch = UnityEngine.Random.Range(0.8f, 1.2f);
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag == "Nail Attack" || otherCollider.gameObject.tag == "Hero Spell" || (otherCollider.tag == "HeroBox" && HeroController.instance.cState.superDashing))
		{
			this.audioSource.Play();
			this.effects.SetActive(true);
			GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 15, 15, 10f, 20f, 40f, 140f, null);
			this.spriteRenderer.enabled = false;
			this.animator.enabled = false;
			this.circleCollider.enabled = false;
			if (this.vibration)
			{
				this.vibration.Play();
			}
		}
	}

	// Token: 0x04000221 RID: 545
	public AudioSource audioSource;

	// Token: 0x04000222 RID: 546
	public GameObject effects;

	// Token: 0x04000223 RID: 547
	public SpriteRenderer spriteRenderer;

	// Token: 0x04000224 RID: 548
	public Animator animator;

	// Token: 0x04000225 RID: 549
	public CircleCollider2D circleCollider;

	// Token: 0x04000226 RID: 550
	private VibrationPlayer vibration;
}
