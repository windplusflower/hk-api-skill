using System;
using UnityEngine;

// Token: 0x0200013A RID: 314
public class JumpEffects : MonoBehaviour
{
	// Token: 0x06000752 RID: 1874 RVA: 0x00029DA0 File Offset: 0x00027FA0
	private void OnEnable()
	{
		if (this.pd == null)
		{
			this.pd = GameManager.instance.playerData;
		}
		foreach (object obj in base.transform)
		{
			((Transform)obj).gameObject.SetActive(false);
		}
		this.fallTimer = 0.1f;
		this.recycleTimer = 1f;
		this.dripTimer = 0f;
		this.dripEndTimer = 0f;
		this.dripping = false;
		this.checkForFall = false;
		this.trailAttached = false;
		switch (this.pd.GetInt("environmentType"))
		{
		case 1:
			this.grassEffects.SetActive(true);
			this.checkForFall = true;
			this.GetHero();
			this.PlayJumpPuff();
			this.PlayTrail();
			return;
		case 2:
			this.boneEffects.SetActive(true);
			this.checkForFall = true;
			this.GetHero();
			this.PlayJumpPuff();
			this.PlayTrail();
			return;
		case 3:
			this.GetHero();
			this.SplashOut();
			return;
		case 6:
			this.splash.SetActive(true);
			if (UnityEngine.Random.Range(1, 100) > 50)
			{
				this.splash.transform.localScale = new Vector3(-this.splash.transform.localScale.x, this.splash.transform.localScale.y, this.splash.transform.localScale.z);
				return;
			}
			return;
		}
		this.dustEffects.SetActive(true);
		this.checkForFall = true;
		this.GetHero();
		this.PlayJumpPuff();
		this.PlayTrail();
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00029F78 File Offset: 0x00028178
	private void Update()
	{
		if (this.checkForFall)
		{
			if (this.fallTimer >= 0f)
			{
				this.fallTimer -= Time.deltaTime;
			}
			else
			{
				this.CheckForFall();
			}
		}
		if (this.recycleTimer <= 0f)
		{
			base.gameObject.Recycle();
		}
		else
		{
			this.recycleTimer -= Time.deltaTime;
		}
		if (this.trailAttached)
		{
			Vector3 position = this.heroObject.transform.position;
			this.dustTrail.transform.position = new Vector3(position.x, position.y - 1.5f, position.z + 0.001f);
		}
		if (this.dripping)
		{
			if (this.dripTimer <= 0f)
			{
				Vector3 position2 = new Vector3(this.heroObject.transform.position.x + UnityEngine.Random.Range(-0.25f, 0.25f), this.heroObject.transform.position.y + UnityEngine.Random.Range(-0.5f, 0.5f), this.heroObject.transform.position.z);
				this.spatterWhitePrefab.Spawn(position2);
				this.dripTimer += 0.025f;
			}
			else
			{
				this.dripTimer -= Time.deltaTime;
			}
			if (this.dripEndTimer <= 0f)
			{
				this.dripping = false;
				return;
			}
			this.dripEndTimer -= Time.deltaTime;
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0002A107 File Offset: 0x00028307
	private void GetHero()
	{
		this.heroObject = HeroController.instance.gameObject;
		this.heroRigidBody = this.heroObject.GetComponent<Rigidbody2D>();
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x0002A12A File Offset: 0x0002832A
	private void CheckForFall()
	{
		if (this.heroRigidBody.velocity.y <= 0f)
		{
			this.jumpPuff.SetActive(false);
			this.dustTrail.GetComponent<ParticleSystem>().Stop();
			this.checkForFall = false;
		}
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x0002A166 File Offset: 0x00028366
	private void PlayTrail()
	{
		this.dustTrail.SetActive(true);
		this.trailAttached = true;
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x0002A17C File Offset: 0x0002837C
	private void PlayJumpPuff()
	{
		float z = this.heroRigidBody.velocity.x * -3f + 2.6f;
		this.jumpPuff.transform.localEulerAngles = new Vector3(0f, 0f, z);
		this.jumpPuff.SetActive(true);
		if (this.jumpPuffAnimator == null)
		{
			this.jumpPuffAnimator = this.jumpPuff.GetComponent<tk2dSpriteAnimator>();
		}
		this.jumpPuffAnimator.PlayFromFrame(0);
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0002A200 File Offset: 0x00028400
	private void SplashOut()
	{
		this.dripEndTimer = 0.4f;
		this.dripping = true;
		Vector3 position = this.heroObject.transform.position;
		for (int i = 1; i <= 11; i++)
		{
			GameObject gameObject = this.spatterWhitePrefab.Spawn(position);
			Vector3 position2 = gameObject.transform.position;
			Vector3 position3 = gameObject.transform.position;
			Vector3 position4 = gameObject.transform.position;
			float num = UnityEngine.Random.Range(5f, 12f);
			float num2 = UnityEngine.Random.Range(80f, 110f);
			float x = num * Mathf.Cos(num2 * 0.017453292f);
			float y = num * Mathf.Sin(num2 * 0.017453292f);
			Vector2 velocity;
			velocity.x = x;
			velocity.y = y;
			gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
		}
	}

	// Token: 0x0400081F RID: 2079
	public GameObject dustEffects;

	// Token: 0x04000820 RID: 2080
	public GameObject grassEffects;

	// Token: 0x04000821 RID: 2081
	public GameObject boneEffects;

	// Token: 0x04000822 RID: 2082
	public GameObject splash;

	// Token: 0x04000823 RID: 2083
	public GameObject jumpPuff;

	// Token: 0x04000824 RID: 2084
	public GameObject dustTrail;

	// Token: 0x04000825 RID: 2085
	public GameObject spatterWhitePrefab;

	// Token: 0x04000826 RID: 2086
	private PlayerData pd;

	// Token: 0x04000827 RID: 2087
	private GameObject heroObject;

	// Token: 0x04000828 RID: 2088
	private Rigidbody2D heroRigidBody;

	// Token: 0x04000829 RID: 2089
	private tk2dSpriteAnimator jumpPuffAnimator;

	// Token: 0x0400082A RID: 2090
	private float recycleTimer;

	// Token: 0x0400082B RID: 2091
	private float fallTimer;

	// Token: 0x0400082C RID: 2092
	private float dripTimer;

	// Token: 0x0400082D RID: 2093
	private float dripEndTimer;

	// Token: 0x0400082E RID: 2094
	private bool dripping;

	// Token: 0x0400082F RID: 2095
	private bool checkForFall;

	// Token: 0x04000830 RID: 2096
	private bool trailAttached;
}
