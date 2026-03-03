using System;
using System.Collections;
using UnityEngine;

// Token: 0x020002B1 RID: 689
public class GeoControl : MonoBehaviour
{
	// Token: 0x06000E8E RID: 3726 RVA: 0x000483B8 File Offset: 0x000465B8
	private void Awake()
	{
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
		this.audioSource = base.GetComponent<AudioSource>();
		this.rend = base.GetComponent<Renderer>();
		this.body = base.GetComponent<Rigidbody2D>();
		this.boxCollider = base.GetComponent<BoxCollider2D>();
		this.spriteFlash = base.GetComponent<SpriteFlash>();
		this.defaultGravity = this.body.gravityScale;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x0004841E File Offset: 0x0004661E
	private void Start()
	{
		this.hero = HeroController.instance;
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x0004842C File Offset: 0x0004662C
	private void OnEnable()
	{
		if (BossSceneController.IsBossScene)
		{
			base.gameObject.Recycle();
			return;
		}
		this.SetSize(this.type);
		base.transform.SetPositionZ(UnityEngine.Random.Range(0.001f, 0.002f));
		this.activated = false;
		this.attracted = false;
		this.body.gravityScale = this.defaultGravity;
		if (this.rend)
		{
			this.rend.enabled = true;
		}
		if (this.getterBug)
		{
			this.getterBug.SetActive(false);
		}
		if (this.acidEffect)
		{
			this.acidEffect.gameObject.SetActive(false);
		}
		this.boxCollider.isTrigger = false;
		if (GameManager.instance.GetCurrentMapZone() == "COLOSSEUM" || GameManager.instance.sceneName == "Crossroads_38")
		{
			return;
		}
		if (GameManager.instance.GetPlayerDataBool("equippedCharm_1"))
		{
			this.getterRoutine = base.StartCoroutine(this.Getter());
		}
		this.pickupStartTime = Time.time + 0.25f;
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00048550 File Offset: 0x00046750
	private void FixedUpdate()
	{
		if (this.attracted)
		{
			Vector2 vector = new Vector2(this.hero.transform.position.x - base.transform.position.x, this.hero.transform.position.y - 0.5f - base.transform.position.y);
			vector = Vector2.ClampMagnitude(vector, 1f);
			vector = new Vector2(vector.x * 150f, vector.y * 150f);
			this.body.AddForce(vector);
			Vector2 vector2 = this.body.velocity;
			vector2 = Vector2.ClampMagnitude(vector2, 20f);
			this.body.velocity = vector2;
		}
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x0004861C File Offset: 0x0004681C
	public void SetSize(int index)
	{
		if (index >= this.sizes.Length)
		{
			index = this.sizes.Length - 1;
		}
		else if (index < 0)
		{
			index = 0;
		}
		this.size = this.sizes[index];
		if (this.anim)
		{
			this.anim.Play(this.size.airAnim);
		}
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00048682 File Offset: 0x00046882
	public void SetFlashing()
	{
		if (this.spriteFlash)
		{
			this.spriteFlash.GeoFlash();
		}
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x0004869C File Offset: 0x0004689C
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (this.anim)
		{
			tk2dSpriteAnimationClip clipByName = this.anim.GetClipByName(this.size.idleAnim);
			if (clipByName != null)
			{
				this.anim.PlayFromFrame(clipByName, UnityEngine.Random.Range(0, clipByName.frames.Length));
			}
		}
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x000486EC File Offset: 0x000468EC
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.activated || Time.time < this.pickupStartTime)
		{
			return;
		}
		bool flag = false;
		float num = 0f;
		if (collision.tag == "HeroBox")
		{
			this.hero.AddGeo(this.size.value);
			VibrationManager.PlayVibrationClipOneShot(this.pickupVibration, null, false, "");
			num = Mathf.Max(num, this.PlayCollectSound());
			flag = true;
		}
		else if (collision.tag == "Acid")
		{
			if (this.acidEffect)
			{
				this.acidEffect.gameObject.SetActive(true);
				num = Mathf.Max(num, this.acidEffect.main.duration + this.acidEffect.main.startLifetime.constant);
			}
			flag = true;
		}
		if (flag)
		{
			if (this.getterRoutine != null)
			{
				base.StopCoroutine(this.getterRoutine);
			}
			this.Disable(num);
		}
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x000487F4 File Offset: 0x000469F4
	private float PlayCollectSound()
	{
		if (this.audioSource && this.pickupSounds.Length != 0)
		{
			AudioClip audioClip = this.pickupSounds[UnityEngine.Random.Range(0, this.pickupSounds.Length)];
			if (audioClip)
			{
				this.audioSource.PlayOneShot(audioClip);
				return audioClip.length;
			}
			Debug.LogError("GeoControl encountered missing audio!", this);
		}
		return 0f;
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00048858 File Offset: 0x00046A58
	public void Disable(float waitTime)
	{
		this.activated = true;
		if (this.rend)
		{
			this.rend.enabled = false;
		}
		if (this.getterBug)
		{
			this.getterBug.SetActive(false);
		}
		base.StartCoroutine(this.DisableAfterTime(waitTime));
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x000488AC File Offset: 0x00046AAC
	private IEnumerator DisableAfterTime(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		this.gameObject.Recycle();
		yield break;
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x000488C2 File Offset: 0x00046AC2
	private IEnumerator Getter()
	{
		yield return new WaitForSeconds(UnityEngine.Random.Range(1f, 1.7f));
		if (this.getterBug)
		{
			this.getterBug.SetActive(true);
			Vector3 destination = new Vector3(-0.06624349f, 0.1932119f, -0.001f);
			Vector3 source = destination + new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(0.5f, 1.5f), 0f);
			float easeTime = UnityEngine.Random.Range(0.3f, 0.5f);
			for (float timer = 0f; timer < easeTime; timer += Time.deltaTime)
			{
				float t = Mathf.Sin(timer / easeTime * 1.5707964f);
				this.getterBug.transform.localPosition = Vector3.Lerp(source, destination, t);
				yield return null;
			}
			this.getterBug.transform.localPosition = destination;
			this.boxCollider.isTrigger = true;
			this.body.gravityScale = 0f;
			this.attracted = true;
			destination = default(Vector3);
			source = default(Vector3);
		}
		yield break;
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x000488D4 File Offset: 0x00046AD4
	public GeoControl()
	{
		this.sizes = new GeoControl.Size[]
		{
			new GeoControl.Size("Small Idle", "Small Air", 1),
			new GeoControl.Size("Med Idle", "Med Air", 5),
			new GeoControl.Size("Large Idle", "Large Air", 25)
		};
		base..ctor();
	}

	// Token: 0x04000F42 RID: 3906
	public GeoControl.Size[] sizes;

	// Token: 0x04000F43 RID: 3907
	public int type;

	// Token: 0x04000F44 RID: 3908
	private GeoControl.Size size;

	// Token: 0x04000F45 RID: 3909
	[Space]
	public AudioClip[] pickupSounds;

	// Token: 0x04000F46 RID: 3910
	[Space]
	public VibrationData pickupVibration;

	// Token: 0x04000F47 RID: 3911
	[Space]
	public ParticleSystem acidEffect;

	// Token: 0x04000F48 RID: 3912
	public GameObject getterBug;

	// Token: 0x04000F49 RID: 3913
	private Coroutine getterRoutine;

	// Token: 0x04000F4A RID: 3914
	private HeroController hero;

	// Token: 0x04000F4B RID: 3915
	private Transform player;

	// Token: 0x04000F4C RID: 3916
	private bool activated;

	// Token: 0x04000F4D RID: 3917
	private bool attracted;

	// Token: 0x04000F4E RID: 3918
	private const float pickupStartDelay = 0.25f;

	// Token: 0x04000F4F RID: 3919
	private float pickupStartTime;

	// Token: 0x04000F50 RID: 3920
	private float defaultGravity;

	// Token: 0x04000F51 RID: 3921
	private tk2dSpriteAnimator anim;

	// Token: 0x04000F52 RID: 3922
	private AudioSource audioSource;

	// Token: 0x04000F53 RID: 3923
	private Renderer rend;

	// Token: 0x04000F54 RID: 3924
	private Rigidbody2D body;

	// Token: 0x04000F55 RID: 3925
	private BoxCollider2D boxCollider;

	// Token: 0x04000F56 RID: 3926
	private SpriteFlash spriteFlash;

	// Token: 0x020002B2 RID: 690
	[Serializable]
	public struct Size
	{
		// Token: 0x06000E9B RID: 3739 RVA: 0x00048939 File Offset: 0x00046B39
		public Size(string idleAnim, string airAnim, int value)
		{
			this.idleAnim = idleAnim;
			this.airAnim = airAnim;
			this.value = value;
		}

		// Token: 0x04000F57 RID: 3927
		public string idleAnim;

		// Token: 0x04000F58 RID: 3928
		public string airAnim;

		// Token: 0x04000F59 RID: 3929
		public int value;
	}
}
