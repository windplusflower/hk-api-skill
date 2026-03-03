using System;
using System.Collections;
using UnityEngine;

// Token: 0x020002B9 RID: 697
public class SoulOrb : MonoBehaviour
{
	// Token: 0x06000EC4 RID: 3780 RVA: 0x00048FE6 File Offset: 0x000471E6
	private void Awake()
	{
		this.sprite = base.GetComponent<SpriteRenderer>();
		this.trail = base.GetComponent<TrailRenderer>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.source = base.GetComponent<AudioSource>();
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00049018 File Offset: 0x00047218
	private void Start()
	{
		base.transform.SetPositionZ(UnityEngine.Random.Range(-0.001f, -0.1f));
		this.target = HeroController.instance.transform;
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00049044 File Offset: 0x00047244
	private void OnDisable()
	{
		if (this.sprite)
		{
			this.sprite.enabled = false;
		}
		if (this.trail)
		{
			this.trail.enabled = false;
		}
		if (this.body)
		{
			this.body.isKinematic = true;
		}
		GameManager.instance.UnloadingLevel -= this.SceneLoading;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x000490B4 File Offset: 0x000472B4
	private void OnEnable()
	{
		if (this.sprite)
		{
			this.sprite.enabled = true;
		}
		if (this.trail)
		{
			this.trail.enabled = true;
		}
		if (this.body)
		{
			this.body.isKinematic = false;
		}
		if (this.zoomRoutine != null)
		{
			base.StopCoroutine(this.zoomRoutine);
		}
		this.zoomRoutine = null;
		GameManager.instance.UnloadingLevel += this.SceneLoading;
		this.scaleModifier = UnityEngine.Random.Range(this.scaleModifierMin, this.scaleModifierMax);
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00049154 File Offset: 0x00047354
	private void Update()
	{
		if (this.body && this.body.velocity.magnitude < 2.5f && this.zoomRoutine == null)
		{
			this.zoomRoutine = base.StartCoroutine(this.Zoom(true));
		}
		this.FaceAngle();
		this.ProjectileSquash();
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x000491AF File Offset: 0x000473AF
	private void SceneLoading()
	{
		if (this.zoomRoutine != null)
		{
			base.StopCoroutine(this.zoomRoutine);
		}
		this.zoomRoutine = base.StartCoroutine(this.Zoom(false));
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x000491D8 File Offset: 0x000473D8
	private IEnumerator Zoom(bool doZoom = true)
	{
		if (doZoom)
		{
			this.speed = 0f;
			while (this.target)
			{
				this.speed += this.acceleration;
				this.speed = Mathf.Clamp(this.speed, 0f, 30f);
				this.acceleration += 0.07f;
				this.FireAtTarget();
				if (Vector2.Distance(this.target.position, this.transform.position) < 0.8f)
				{
					goto IL_E8;
				}
				yield return null;
			}
			Debug.LogError("Soul orb could not get player target!");
		}
		IL_E8:
		this.body.velocity = Vector2.zero;
		if (this.soulOrbCollectSounds)
		{
			this.soulOrbCollectSounds.PlayOneShot(this.source);
		}
		if (this.getParticles)
		{
			this.getParticles.Play();
		}
		if (this.sprite)
		{
			this.sprite.enabled = false;
		}
		if (this.awardSoul)
		{
			HeroController.instance.AddMPCharge(2);
		}
		SpriteFlash component = HeroController.instance.gameObject.GetComponent<SpriteFlash>();
		if (component)
		{
			component.flashSoulGet();
		}
		yield return new WaitForSeconds(0.4f);
		if (this.dontRecycle)
		{
			this.gameObject.SetActive(false);
		}
		else
		{
			this.gameObject.Recycle();
		}
		yield break;
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x000491F0 File Offset: 0x000473F0
	private void FireAtTarget()
	{
		float y = this.target.position.y - base.transform.position.y;
		float x = this.target.position.x - base.transform.position.x;
		float num = Mathf.Atan2(y, x) * 57.295776f;
		Vector2 velocity;
		velocity.x = this.speed * Mathf.Cos(num * 0.017453292f);
		velocity.y = this.speed * Mathf.Sin(num * 0.017453292f);
		this.body.velocity = velocity;
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00049290 File Offset: 0x00047490
	private void FaceAngle()
	{
		Vector2 velocity = this.body.velocity;
		float z = Mathf.Atan2(velocity.y, velocity.x) * 57.295776f;
		base.transform.localEulerAngles = new Vector3(0f, 0f, z);
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x000492DC File Offset: 0x000474DC
	private void ProjectileSquash()
	{
		float num = 1f - this.body.velocity.magnitude * this.stretchFactor * 0.01f;
		float num2 = 1f + this.body.velocity.magnitude * this.stretchFactor * 0.01f;
		if (num2 > this.stretchMaxX)
		{
			num2 = this.stretchMaxX;
		}
		if (num < this.stretchMinY)
		{
			num = this.stretchMinY;
		}
		num *= this.scaleModifier;
		num2 *= this.scaleModifier;
		base.transform.localScale = new Vector3(num2, num, base.transform.localScale.z);
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0004938C File Offset: 0x0004758C
	public SoulOrb()
	{
		this.awardSoul = true;
		this.stretchFactor = 2f;
		this.stretchMinY = 1f;
		this.stretchMaxX = 2f;
		this.scaleModifierMin = 1f;
		this.scaleModifierMax = 2f;
		base..ctor();
	}

	// Token: 0x04000F7C RID: 3964
	public RandomAudioClipTable soulOrbCollectSounds;

	// Token: 0x04000F7D RID: 3965
	public ParticleSystem getParticles;

	// Token: 0x04000F7E RID: 3966
	public bool awardSoul;

	// Token: 0x04000F7F RID: 3967
	public bool dontRecycle;

	// Token: 0x04000F80 RID: 3968
	private Transform target;

	// Token: 0x04000F81 RID: 3969
	private float speed;

	// Token: 0x04000F82 RID: 3970
	private float acceleration;

	// Token: 0x04000F83 RID: 3971
	private SpriteRenderer sprite;

	// Token: 0x04000F84 RID: 3972
	private TrailRenderer trail;

	// Token: 0x04000F85 RID: 3973
	private Rigidbody2D body;

	// Token: 0x04000F86 RID: 3974
	private AudioSource source;

	// Token: 0x04000F87 RID: 3975
	private Coroutine zoomRoutine;

	// Token: 0x04000F88 RID: 3976
	public float stretchFactor;

	// Token: 0x04000F89 RID: 3977
	public float stretchMinY;

	// Token: 0x04000F8A RID: 3978
	public float stretchMaxX;

	// Token: 0x04000F8B RID: 3979
	public float scaleModifier;

	// Token: 0x04000F8C RID: 3980
	public float scaleModifierMin;

	// Token: 0x04000F8D RID: 3981
	public float scaleModifierMax;
}
