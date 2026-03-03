using System;
using UnityEngine;

// Token: 0x0200007A RID: 122
public class InfectedBurstSmall : MonoBehaviour
{
	// Token: 0x0600029F RID: 671 RVA: 0x0000EDDD File Offset: 0x0000CFDD
	private void Awake()
	{
		this.vibration = base.GetComponent<VibrationPlayer>();
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0000EDEB File Offset: 0x0000CFEB
	private void Start()
	{
		this.audioSource.pitch = UnityEngine.Random.Range(0.8f, 1.2f);
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0000EE08 File Offset: 0x0000D008
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag == "Nail Attack" || otherCollider.gameObject.tag == "Hero Spell" || (otherCollider.tag == "HeroBox" && HeroController.instance.cState.superDashing))
		{
			this.audioSource.Play();
			this.effects.SetActive(true);
			GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 5, 5, 10f, 20f, 40f, 140f, null);
			this.spriteRenderer.enabled = false;
			this.animator.enabled = false;
			this.circleCollider.enabled = false;
			if (this.vibration)
			{
				this.vibration.Play();
			}
		}
	}

	// Token: 0x04000227 RID: 551
	public AudioSource audioSource;

	// Token: 0x04000228 RID: 552
	public GameObject effects;

	// Token: 0x04000229 RID: 553
	public SpriteRenderer spriteRenderer;

	// Token: 0x0400022A RID: 554
	public Animator animator;

	// Token: 0x0400022B RID: 555
	public CircleCollider2D circleCollider;

	// Token: 0x0400022C RID: 556
	private VibrationPlayer vibration;
}
