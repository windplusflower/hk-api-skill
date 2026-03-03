using System;
using System.Collections;
using UnityEngine;

// Token: 0x020003AA RID: 938
public class DreamPlant : MonoBehaviour
{
	// Token: 0x06001581 RID: 5505 RVA: 0x00066884 File Offset: 0x00064A84
	private void Awake()
	{
		this.spriteFlash = base.GetComponent<SpriteFlash>();
		PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
		if (component)
		{
			component.OnGetSaveState += delegate(ref bool value)
			{
				value = this.completed;
			};
			component.OnSetSaveState += delegate(bool value)
			{
				this.completed = value;
				if (this.completed)
				{
					this.activated = true;
					if (this.anim)
					{
						this.anim.Play("Completed");
					}
					if (this.dreamDialogue)
					{
						this.dreamDialogue.SetActive(true);
					}
				}
			};
		}
		this.audioSource = base.GetComponent<AudioSource>();
		this.anim = base.GetComponent<tk2dSpriteAnimator>();
	}

	// Token: 0x06001582 RID: 5506 RVA: 0x000668E8 File Offset: 0x00064AE8
	private void Start()
	{
		this.hasDreamNail = GameManager.instance.GetPlayerDataBool("hasDreamNail");
		this.seenDreamNailPrompt = GameManager.instance.GetPlayerDataBool("seenDreamNailPrompt");
		if (this.heroDetector && this.hasDreamNail)
		{
			this.heroDetector.OnEnter += delegate(Collider2D <p0>)
			{
				this.ShowPrompt(true);
			};
			this.heroDetector.OnExit += delegate(Collider2D <p0>)
			{
				this.ShowPrompt(false);
			};
		}
		if (this.completed && this.playerdataBool != "")
		{
			GameManager.instance.SetPlayerDataBool(this.playerdataBool, true);
		}
		if (this.hasDreamNail && !this.activated && this.dreamAreaEffect)
		{
			this.spawnedDreamAreaEffect = UnityEngine.Object.Instantiate<GameObject>(this.dreamAreaEffect);
			this.spawnedDreamAreaEffect.SetActive(false);
		}
		if (this.whiteFlash)
		{
			this.whiteFlash.SetActive(true);
			this.whiteFlash.SetActive(false);
		}
		this.dreamOrbs = UnityEngine.Object.FindObjectsOfType<DreamPlantOrb>();
		DreamPlantOrb.plant = this;
	}

	// Token: 0x06001583 RID: 5507 RVA: 0x00066A00 File Offset: 0x00064C00
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.activated)
		{
			return;
		}
		if (collision.tag == "Dream Attack")
		{
			this.activated = true;
			DreamPlantOrb[] array = this.dreamOrbs;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Show();
			}
			if (this.spriteFlash)
			{
				this.spriteFlash.flashFocusHeal();
			}
			if (this.glowFader)
			{
				this.glowFader.Fade(false);
			}
			if (this.anim)
			{
				this.anim.Play("Activate");
			}
			if (this.audioSource && this.hitSound)
			{
				this.audioSource.PlayOneShot(this.hitSound);
			}
			if (this.spawnedDreamAreaEffect)
			{
				this.spawnedDreamAreaEffect.SetActive(true);
			}
			if (this.whiteFlash)
			{
				this.whiteFlash.SetActive(true);
			}
			if (this.activateParticles)
			{
				this.activateParticles.gameObject.SetActive(true);
			}
			if (this.activatedParticles)
			{
				this.activatedParticles.gameObject.SetActive(true);
			}
			if (this.dreamImpact)
			{
				Vector3 vector = collision.bounds.center;
				Collider2D component = base.GetComponent<Collider2D>();
				if (component)
				{
					vector += component.bounds.center;
					vector /= 2f;
				}
				this.dreamImpact.Spawn(vector);
			}
			GameCameras instance = GameCameras.instance;
			if (instance)
			{
				instance.cameraShakeFSM.SendEvent("AverageShake");
			}
			EventRegister.SendEvent("DREAM PLANT HIT");
		}
	}

	// Token: 0x06001584 RID: 5508 RVA: 0x00066BBC File Offset: 0x00064DBC
	public void AddOrbCount()
	{
		this.spawnedOrbs++;
		if (this.checkOrbRoutine == null)
		{
			this.checkOrbRoutine = base.StartCoroutine(this.CheckOrbs());
		}
	}

	// Token: 0x06001585 RID: 5509 RVA: 0x00066BE6 File Offset: 0x00064DE6
	public void RemoveOrbCount()
	{
		this.spawnedOrbs--;
	}

	// Token: 0x06001586 RID: 5510 RVA: 0x00066BF8 File Offset: 0x00064DF8
	private void ShowPrompt(bool show)
	{
		if (this.activated)
		{
			return;
		}
		if (show)
		{
			if (!this.seenDreamNailPrompt)
			{
				this.seenDreamNailPrompt = true;
				GameManager.instance.SetPlayerDataBool("seenDreamNailPrompt", true);
				PlayMakerFSM.BroadcastEvent("REMINDER DREAM NAIL");
			}
			if (this.audioSource && this.glowSound)
			{
				this.audioSource.PlayOneShot(this.glowSound);
			}
			if (this.wiltedParticles)
			{
				this.wiltedParticles.Play();
			}
			base.SendMessage("flashWhitePulse");
			if (this.glowFader)
			{
				this.glowFader.Fade(true);
				return;
			}
		}
		else if (this.glowFader)
		{
			this.glowFader.Fade(false);
		}
	}

	// Token: 0x06001587 RID: 5511 RVA: 0x00066CBE File Offset: 0x00064EBE
	private IEnumerator CheckOrbs()
	{
		while (this.spawnedOrbs > 0)
		{
			yield return null;
		}
		this.completed = true;
		if (this.playerdataBool != "")
		{
			GameManager.instance.SetPlayerDataBool(this.playerdataBool, true);
		}
		GameManager.instance.SendMessage("AddToDreamPlantCList");
		yield return new WaitForSeconds(1f);
		PlayMakerFSM.BroadcastEvent("DREAM AREA DISABLE");
		if (this.activatedParticles)
		{
			this.activatedParticles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		if (this.completeGlowFader)
		{
			this.completeGlowFader.Fade(true);
		}
		if (this.audioSource && this.growChargeSound)
		{
			this.audioSource.PlayOneShot(this.growChargeSound);
		}
		if (this.completeChargeParticles)
		{
			this.completeChargeParticles.gameObject.SetActive(true);
		}
		yield return new WaitForSeconds(1f);
		if (this.completeChargeParticles)
		{
			this.completeChargeParticles.Stop(true, ParticleSystemStopBehavior.StopEmitting);
		}
		if (this.audioSource && this.growSound)
		{
			this.audioSource.PlayOneShot(this.growSound);
		}
		if (this.anim)
		{
			this.anim.Play("Complete");
		}
		if (this.whiteFlash)
		{
			this.whiteFlash.SetActive(true);
		}
		if (this.completeGlowFader)
		{
			this.completeGlowFader.Fade(false);
		}
		if (this.growParticles)
		{
			this.growParticles.gameObject.SetActive(true);
		}
		GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
		if (gameCameras)
		{
			gameCameras.cameraShakeFSM.SendEvent("AverageShake");
		}
		if (this.dreamDialogue)
		{
			this.dreamDialogue.SetActive(true);
		}
		yield break;
	}

	// Token: 0x040019C7 RID: 6599
	public HeroDetect heroDetector;

	// Token: 0x040019C8 RID: 6600
	public AudioClip glowSound;

	// Token: 0x040019C9 RID: 6601
	private AudioSource audioSource;

	// Token: 0x040019CA RID: 6602
	public ParticleSystem wiltedParticles;

	// Token: 0x040019CB RID: 6603
	[Space]
	public ColorFader glowFader;

	// Token: 0x040019CC RID: 6604
	public ColorFader completeGlowFader;

	// Token: 0x040019CD RID: 6605
	[Space]
	public AudioClip hitSound;

	// Token: 0x040019CE RID: 6606
	public GameObject dreamImpact;

	// Token: 0x040019CF RID: 6607
	public GameObject dreamAreaEffect;

	// Token: 0x040019D0 RID: 6608
	private GameObject spawnedDreamAreaEffect;

	// Token: 0x040019D1 RID: 6609
	public ParticleSystem activateParticles;

	// Token: 0x040019D2 RID: 6610
	public ParticleSystem activatedParticles;

	// Token: 0x040019D3 RID: 6611
	public GameObject whiteFlash;

	// Token: 0x040019D4 RID: 6612
	[Space]
	public AudioClip growChargeSound;

	// Token: 0x040019D5 RID: 6613
	public AudioClip growSound;

	// Token: 0x040019D6 RID: 6614
	public ParticleSystem completeChargeParticles;

	// Token: 0x040019D7 RID: 6615
	public ParticleSystem growParticles;

	// Token: 0x040019D8 RID: 6616
	public GameObject dreamDialogue;

	// Token: 0x040019D9 RID: 6617
	[Space]
	public string playerdataBool;

	// Token: 0x040019DA RID: 6618
	private tk2dSpriteAnimator anim;

	// Token: 0x040019DB RID: 6619
	private bool activated;

	// Token: 0x040019DC RID: 6620
	private bool completed;

	// Token: 0x040019DD RID: 6621
	private bool hasDreamNail;

	// Token: 0x040019DE RID: 6622
	private bool seenDreamNailPrompt;

	// Token: 0x040019DF RID: 6623
	private int spawnedOrbs;

	// Token: 0x040019E0 RID: 6624
	private Coroutine checkOrbRoutine;

	// Token: 0x040019E1 RID: 6625
	private DreamPlantOrb[] dreamOrbs;

	// Token: 0x040019E2 RID: 6626
	private SpriteFlash spriteFlash;
}
