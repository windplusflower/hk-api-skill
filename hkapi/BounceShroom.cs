using System;
using System.Collections;
using UnityEngine;

// Token: 0x020000CB RID: 203
public class BounceShroom : MonoBehaviour
{
	// Token: 0x06000422 RID: 1058 RVA: 0x00014591 File Offset: 0x00012791
	private void Awake()
	{
		this.anim = base.GetComponentInChildren<tk2dSpriteAnimator>();
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x000145A0 File Offset: 0x000127A0
	private void Start()
	{
		if (!this.active)
		{
			return;
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.idleParticlePrefab);
		if (gameObject)
		{
			gameObject.transform.SetPositionX(base.transform.position.x);
			gameObject.transform.SetPositionY(base.transform.position.y);
		}
		this.idleRoutine = base.StartCoroutine(this.Idle());
		CollisionEnterEvent[] componentsInChildren = base.GetComponentsInChildren<CollisionEnterEvent>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].OnCollisionEnteredDirectional += delegate(CollisionEnterEvent.Direction direction, Collision2D collision)
			{
				switch (direction)
				{
				case CollisionEnterEvent.Direction.Left:
					HeroController.instance.SendMessage("RecoilLeft");
					break;
				case CollisionEnterEvent.Direction.Right:
					HeroController.instance.SendMessage("RecoilRight");
					break;
				case CollisionEnterEvent.Direction.Top:
					HeroController.instance.SendMessage("Bounce");
					HeroController.instance.SendMessage((UnityEngine.Random.Range(0, 2) == 0) ? "RecoilLeft" : "RecoilRight");
					break;
				}
				this.BounceSmall();
			};
		}
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x0001463B File Offset: 0x0001283B
	private IEnumerator Idle()
	{
		for (;;)
		{
			this.PlayAnims(BounceShroom.AnimType.Idle);
			yield return new WaitForSeconds(UnityEngine.Random.Range(2f, 8f));
			yield return new WaitForSeconds(this.PlayAnims(BounceShroom.AnimType.Bob));
		}
		yield break;
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x0001464C File Offset: 0x0001284C
	private float PlayAnims(BounceShroom.AnimType animType)
	{
		tk2dSpriteAnimationClip clipByName = this.anim.GetClipByName(this.GetAnimName(animType));
		this.anim.Play(clipByName);
		return clipByName.Duration;
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00014680 File Offset: 0x00012880
	private string GetAnimName(BounceShroom.AnimType animType)
	{
		string result = "NONE";
		switch (animType)
		{
		case BounceShroom.AnimType.Idle:
			result = this.idleAnim;
			break;
		case BounceShroom.AnimType.Bob:
			result = this.bobAnim;
			break;
		case BounceShroom.AnimType.Bounce:
			result = this.bounceAnim;
			break;
		}
		return result;
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x000146C4 File Offset: 0x000128C4
	protected void BounceSmall()
	{
		if (!this.active)
		{
			return;
		}
		if (this.bounceSmallPrefab)
		{
			this.bounceSmallPrefab.Spawn(base.transform.position).transform.SetPositionZ(-0.001f);
		}
		if (this.bounceRoutine == null)
		{
			this.bounceRoutine = base.StartCoroutine(this.Bounce());
		}
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00014726 File Offset: 0x00012926
	private IEnumerator Bounce()
	{
		if (this.idleRoutine != null)
		{
			this.StopCoroutine(this.idleRoutine);
		}
		this.hitSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		yield return new WaitForSeconds(this.PlayAnims(BounceShroom.AnimType.Bounce));
		this.bounceRoutine = null;
		this.idleRoutine = this.StartCoroutine(this.Idle());
		yield break;
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00014738 File Offset: 0x00012938
	public void BounceLarge(bool useEffects = true)
	{
		if (!this.active)
		{
			return;
		}
		if (useEffects)
		{
			if (Time.time >= BounceShroom.nextBounceParticleTime)
			{
				BounceShroom.nextBounceParticleTime = Time.time + 0.25f;
			}
			else
			{
				useEffects = false;
			}
		}
		if (this.bounceLargePrefab && useEffects)
		{
			this.bounceLargePrefab.Spawn(base.transform.position).transform.SetPositionZ(-0.001f);
		}
		if (this.bounceRoutine == null)
		{
			this.bounceRoutine = base.StartCoroutine(this.Bounce());
		}
		if (Time.time > BounceShroom.nextCamShakeTime)
		{
			GameCameras.instance.cameraShakeFSM.SendEvent("EnemyKillShake");
			BounceShroom.nextCamShakeTime = Time.time + 0.25f;
		}
		if (useEffects)
		{
			if (this.hitEffect)
			{
				this.hitEffect.SetActive(true);
			}
			if (this.heroParticlePrefab)
			{
				ParticleSystem particleSystem = BounceShroom.heroParticles ? BounceShroom.heroParticles.GetComponent<ParticleSystem>() : null;
				if (!BounceShroom.heroParticles || !BounceShroom.heroParticles.activeSelf || (particleSystem && !particleSystem.isEmitting))
				{
					BounceShroom.heroParticles = this.heroParticlePrefab.Spawn(HeroController.instance.transform, new Vector3(0f, -1.5f, -0.002f));
				}
			}
		}
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00014891 File Offset: 0x00012A91
	public BounceShroom()
	{
		this.idleAnim = "Idle 1";
		this.bobAnim = "Bob 1";
		this.bounceAnim = "Bounce 1";
		base..ctor();
	}

	// Token: 0x040003A4 RID: 932
	[Tooltip("Active false by default since this script may be used elsewhere as just a flag")]
	public bool active;

	// Token: 0x040003A5 RID: 933
	[Space]
	public GameObject idleParticlePrefab;

	// Token: 0x040003A6 RID: 934
	public GameObject bounceSmallPrefab;

	// Token: 0x040003A7 RID: 935
	public GameObject bounceLargePrefab;

	// Token: 0x040003A8 RID: 936
	public GameObject heroParticlePrefab;

	// Token: 0x040003A9 RID: 937
	private const float bounceParticleDelay = 0.25f;

	// Token: 0x040003AA RID: 938
	private static float nextBounceParticleTime;

	// Token: 0x040003AB RID: 939
	[Header("Animations")]
	public string idleAnim;

	// Token: 0x040003AC RID: 940
	public string bobAnim;

	// Token: 0x040003AD RID: 941
	public string bounceAnim;

	// Token: 0x040003AE RID: 942
	[Space]
	public GameObject hitEffect;

	// Token: 0x040003AF RID: 943
	[Space]
	public AudioSource audioSourcePrefab;

	// Token: 0x040003B0 RID: 944
	public RandomAudioClipTable hitSound;

	// Token: 0x040003B1 RID: 945
	private tk2dSpriteAnimator anim;

	// Token: 0x040003B2 RID: 946
	private Coroutine idleRoutine;

	// Token: 0x040003B3 RID: 947
	private Coroutine bounceRoutine;

	// Token: 0x040003B4 RID: 948
	private static GameObject heroParticles;

	// Token: 0x040003B5 RID: 949
	private static float nextCamShakeTime;

	// Token: 0x020000CC RID: 204
	private enum AnimType
	{
		// Token: 0x040003B7 RID: 951
		Idle,
		// Token: 0x040003B8 RID: 952
		Bob,
		// Token: 0x040003B9 RID: 953
		Bounce
	}
}
