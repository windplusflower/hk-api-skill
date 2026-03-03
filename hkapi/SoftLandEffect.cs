using System;
using UnityEngine;

// Token: 0x0200014C RID: 332
public class SoftLandEffect : MonoBehaviour
{
	// Token: 0x060007BE RID: 1982 RVA: 0x0002BCC0 File Offset: 0x00029EC0
	private void OnEnable()
	{
		if (this.pd == null)
		{
			this.pd = GameManager.instance.playerData;
		}
		if (this.audioSource == null)
		{
			this.audioSource = base.gameObject.GetComponent<AudioSource>();
		}
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		this.recycleTimer = 1f;
		HeroController instance = HeroController.instance;
		if (instance != null && instance.isHeroInPosition)
		{
			switch (this.pd.GetInt("environmentType"))
			{
			case 1:
				this.grassEffects.SetActive(true);
				this.audioSource.PlayOneShot(this.softLandClip);
				return;
			case 2:
				this.boneEffects.SetActive(true);
				this.audioSource.PlayOneShot(this.softLandClip);
				return;
			case 3:
				this.audioSource.PlayOneShot(this.wetLandClip);
				return;
			case 5:
				return;
			case 6:
				this.audioSource.PlayOneShot(this.wetLandClip);
				this.splash.SetActive(true);
				if (UnityEngine.Random.Range(1, 100) > 50)
				{
					this.splash.transform.localScale = new Vector3(-this.splash.transform.localScale.x, this.splash.transform.localScale.y, this.splash.transform.localScale.z);
					return;
				}
				return;
			}
			this.dustEffects.SetActive(true);
			this.audioSource.PlayOneShot(this.softLandClip);
		}
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0002BE9C File Offset: 0x0002A09C
	private void Update()
	{
		if (this.recycleTimer <= 0f)
		{
			base.gameObject.Recycle();
			return;
		}
		this.recycleTimer -= Time.deltaTime;
	}

	// Token: 0x04000895 RID: 2197
	public GameObject dustEffects;

	// Token: 0x04000896 RID: 2198
	public GameObject grassEffects;

	// Token: 0x04000897 RID: 2199
	public GameObject boneEffects;

	// Token: 0x04000898 RID: 2200
	public GameObject splash;

	// Token: 0x04000899 RID: 2201
	public AudioClip softLandClip;

	// Token: 0x0400089A RID: 2202
	public AudioClip wetLandClip;

	// Token: 0x0400089B RID: 2203
	private PlayerData pd;

	// Token: 0x0400089C RID: 2204
	private GameObject heroObject;

	// Token: 0x0400089D RID: 2205
	private AudioSource audioSource;

	// Token: 0x0400089E RID: 2206
	private Rigidbody2D heroRigidBody;

	// Token: 0x0400089F RID: 2207
	private tk2dSpriteAnimator jumpPuffAnimator;

	// Token: 0x040008A0 RID: 2208
	private float recycleTimer;
}
