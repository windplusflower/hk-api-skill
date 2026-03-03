using System;
using UnityEngine;

// Token: 0x020003D5 RID: 981
public class JellyEgg : MonoBehaviour
{
	// Token: 0x0600167D RID: 5757 RVA: 0x0006A624 File Offset: 0x00068824
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (otherCollider.gameObject.tag == "Nail Attack" || otherCollider.gameObject.tag == "Hero Spell" || otherCollider.gameObject.tag == "HeroBox")
		{
			this.Burst();
		}
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x0006A67C File Offset: 0x0006887C
	private void Burst()
	{
		this.meshRenderer.enabled = false;
		this.popEffect.Play();
		this.audioSource.Play();
		this.circleCollider.enabled = false;
		if (this.bomb)
		{
			this.explosionObject.Spawn(base.transform.position, base.transform.localRotation);
			return;
		}
		float num = UnityEngine.Random.Range(1f, 1.5f);
		this.strikeEffect.transform.localScale = new Vector3(num, num, num);
		this.strikeEffect.transform.localEulerAngles = new Vector3(this.strikeEffect.transform.localEulerAngles.x, this.strikeEffect.transform.localEulerAngles.y, UnityEngine.Random.Range(0f, 360f));
		this.strikeEffect.SetActive(true);
		if (this.falseShiny != null)
		{
			this.falseShiny.SetActive(false);
		}
		if (this.shinyItem != null)
		{
			this.shinyItem.SetActive(true);
		}
		VibrationManager.PlayVibrationClipOneShot(this.popVibration, null, false, "");
	}

	// Token: 0x04001B08 RID: 6920
	public bool bomb;

	// Token: 0x04001B09 RID: 6921
	public GameObject explosionObject;

	// Token: 0x04001B0A RID: 6922
	public ParticleSystem popEffect;

	// Token: 0x04001B0B RID: 6923
	public GameObject strikeEffect;

	// Token: 0x04001B0C RID: 6924
	public MeshRenderer meshRenderer;

	// Token: 0x04001B0D RID: 6925
	public AudioSource audioSource;

	// Token: 0x04001B0E RID: 6926
	public VibrationData popVibration;

	// Token: 0x04001B0F RID: 6927
	public CircleCollider2D circleCollider;

	// Token: 0x04001B10 RID: 6928
	public GameObject falseShiny;

	// Token: 0x04001B11 RID: 6929
	public GameObject shinyItem;
}
