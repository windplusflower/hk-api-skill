using System;
using UnityEngine;

// Token: 0x0200012D RID: 301
public class DashEffect : MonoBehaviour
{
	// Token: 0x060006F7 RID: 1783 RVA: 0x0002807C File Offset: 0x0002627C
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
				this.PlayDashPuff();
				this.PlayGrass();
				return;
			case 2:
				this.PlayDashPuff();
				this.PlayBone();
				return;
			case 3:
				this.PlaySpaEffects();
				return;
			case 6:
				return;
			}
			this.PlayDashPuff();
			this.PlayDust();
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x00028194 File Offset: 0x00026394
	private void PlayDashPuff()
	{
		this.heroDashPuff.SetActive(true);
		this.heroDashPuff_anim.PlayFromFrame(0);
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000281AE File Offset: 0x000263AE
	private void PlayDust()
	{
		this.dashDust.SetActive(true);
	}

	// Token: 0x060006FA RID: 1786 RVA: 0x000281BC File Offset: 0x000263BC
	private void PlayGrass()
	{
		this.dashGrass.SetActive(true);
	}

	// Token: 0x060006FB RID: 1787 RVA: 0x000281CA File Offset: 0x000263CA
	private void PlayBone()
	{
		this.dashBone.SetActive(true);
	}

	// Token: 0x060006FC RID: 1788 RVA: 0x000281D8 File Offset: 0x000263D8
	private void PlaySpaEffects()
	{
		this.waterCut.SetActive(true);
		this.audioSource.PlayOneShot(this.splashClip);
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x000281F7 File Offset: 0x000263F7
	private void Update()
	{
		if (this.recycleTimer <= 0f)
		{
			base.gameObject.Recycle();
			return;
		}
		this.recycleTimer -= Time.deltaTime;
	}

	// Token: 0x04000792 RID: 1938
	public GameObject heroDashPuff;

	// Token: 0x04000793 RID: 1939
	public GameObject dashDust;

	// Token: 0x04000794 RID: 1940
	public GameObject dashBone;

	// Token: 0x04000795 RID: 1941
	public GameObject dashGrass;

	// Token: 0x04000796 RID: 1942
	public GameObject waterCut;

	// Token: 0x04000797 RID: 1943
	public tk2dSpriteAnimator heroDashPuff_anim;

	// Token: 0x04000798 RID: 1944
	public AudioClip splashClip;

	// Token: 0x04000799 RID: 1945
	private PlayerData pd;

	// Token: 0x0400079A RID: 1946
	private GameObject heroObject;

	// Token: 0x0400079B RID: 1947
	private AudioSource audioSource;

	// Token: 0x0400079C RID: 1948
	private Rigidbody2D heroRigidBody;

	// Token: 0x0400079D RID: 1949
	private tk2dSpriteAnimator jumpPuffAnimator;

	// Token: 0x0400079E RID: 1950
	private float recycleTimer;
}
