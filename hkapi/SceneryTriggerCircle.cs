using System;
using UnityEngine;

// Token: 0x0200014B RID: 331
public class SceneryTriggerCircle : MonoBehaviour
{
	// Token: 0x170000CC RID: 204
	// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0002BAE4 File Offset: 0x00029CE4
	// (set) Token: 0x060007B6 RID: 1974 RVA: 0x0002BAEC File Offset: 0x00029CEC
	public bool active { get; private set; }

	// Token: 0x060007B7 RID: 1975 RVA: 0x0002BAF8 File Offset: 0x00029CF8
	private void Awake()
	{
		this.col2ds = base.GetComponentsInChildren<CircleCollider2D>();
		this.animator = base.GetComponentInChildren<Animator>();
		if (this.col2ds.Length > 2 || this.col2ds.Length < 2)
		{
			Debug.LogError("Scenery Trigger requires exactly two Collider components attached to work correctly.");
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0002BB4C File Offset: 0x00029D4C
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.layer == 9)
		{
			if (this.enterCount == 0)
			{
				this.enterCount = 1;
				return;
			}
			if (this.enterCount == 1)
			{
				this.active = true;
				this.animator.Play("Show");
				if (this.activateSound != null && this.audioSource != null)
				{
					this.RandomizePitch(this.audioSource, 0.85f, 1.15f);
					this.audioSource.PlayOneShot(this.activateSound);
				}
				this.enterCount = 2;
			}
		}
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x0002BBE5 File Offset: 0x00029DE5
	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.layer == 9 && this.enterCount == 0)
		{
			this.enterCount = 1;
		}
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0002BC08 File Offset: 0x00029E08
	private void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.layer == 9)
		{
			if (this.enterCount == 1)
			{
				this.active = false;
				this.animator.Play("Hide");
				if (this.deactivateSound != null && this.audioSource != null)
				{
					this.RandomizePitch(this.audioSource, 0.85f, 1.15f);
					this.audioSource.PlayOneShot(this.deactivateSound);
				}
				this.enterCount = 0;
				return;
			}
			if (this.enterCount == 2)
			{
				this.enterCount = 1;
			}
		}
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x0002BCA4 File Offset: 0x00029EA4
	private void RandomizePitch(AudioSource src, float minPitch, float maxPitch)
	{
		float pitch = UnityEngine.Random.Range(minPitch, maxPitch);
		src.pitch = pitch;
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x000138A0 File Offset: 0x00011AA0
	private void ResetPitch(AudioSource src)
	{
		src.pitch = 1f;
	}

	// Token: 0x0400088E RID: 2190
	private Animator animator;

	// Token: 0x0400088F RID: 2191
	private CircleCollider2D[] col2ds;

	// Token: 0x04000890 RID: 2192
	private int enterCount;

	// Token: 0x04000892 RID: 2194
	public AudioSource audioSource;

	// Token: 0x04000893 RID: 2195
	public AudioClip activateSound;

	// Token: 0x04000894 RID: 2196
	public AudioClip deactivateSound;
}
