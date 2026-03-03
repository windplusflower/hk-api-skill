using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000249 RID: 585
public class BossSequenceDoor : MonoBehaviour
{
	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003EDF1 File Offset: 0x0003CFF1
	// (set) Token: 0x06000C54 RID: 3156 RVA: 0x0003EDF9 File Offset: 0x0003CFF9
	public BossSequenceDoor.Completion CurrentCompletion
	{
		get
		{
			return this.completion;
		}
		set
		{
			this.completion = value;
			this.SaveState();
		}
	}

	// Token: 0x06000C55 RID: 3157 RVA: 0x0003EE08 File Offset: 0x0003D008
	private void Start()
	{
		this.completion = (string.IsNullOrEmpty(this.playerDataString) ? BossSequenceDoor.Completion.None : GameManager.instance.GetPlayerDataVariable<BossSequenceDoor.Completion>(this.playerDataString));
		if (this.IsUnlocked() || this.completion.canUnlock)
		{
			this.SetDisplayState(this.completion);
			if (this.completion.unlocked || !this.doLockBreakSequence)
			{
				if (this.lockSet)
				{
					this.lockSet.SetActive(false);
				}
				if (this.unlockedSet)
				{
					this.unlockedSet.SetActive(true);
				}
			}
			else
			{
				this.doUnlockSequence = true;
				if (this.lockInteractPrompt)
				{
					this.lockInteractPrompt.SetActive(false);
				}
				if (this.unlockedSet)
				{
					this.unlockedSet.SetActive(false);
				}
			}
		}
		else
		{
			this.SetDisplayState(BossSequenceDoor.Completion.None);
			if (this.lockSet)
			{
				this.lockSet.SetActive(true);
			}
			if (this.unlockedSet)
			{
				this.unlockedSet.SetActive(false);
			}
			if (this.lockedUIPrefab && !BossSequenceDoor.lockedUI)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.lockedUIPrefab);
				BossSequenceDoor.lockedUI = gameObject.GetComponent<BossDoorLockUI>();
				gameObject.SetActive(false);
			}
		}
		if (this.challengeFSM && this.bossSequence && this.bossSequence.Count > 0)
		{
			this.challengeFSM.FsmVariables.FindFsmString("To Scene").Value = this.bossSequence.GetSceneAt(0);
		}
		if (this.dreamReturnGate)
		{
			GameObject gameObject2 = this.dreamReturnGate;
			gameObject2.name = gameObject2.name + "_" + base.gameObject.name;
		}
	}

	// Token: 0x06000C56 RID: 3158 RVA: 0x0003EFE3 File Offset: 0x0003D1E3
	private void SaveState()
	{
		GameManager.instance.SetPlayerDataVariable<BossSequenceDoor.Completion>(this.playerDataString, this.completion);
	}

	// Token: 0x06000C57 RID: 3159 RVA: 0x0003EFFB File Offset: 0x0003D1FB
	private bool IsUnlocked()
	{
		return this.completion.unlocked || (this.bossSequence && this.bossSequence.IsUnlocked());
	}

	// Token: 0x06000C58 RID: 3160 RVA: 0x0003F02C File Offset: 0x0003D22C
	private void SetDisplayState(BossSequenceDoor.Completion completion)
	{
		if (this.completedDisplay)
		{
			this.completedDisplay.SetActive(completion.completed);
		}
		if (this.completedAllDisplay)
		{
			this.completedAllDisplay.SetActive(completion.allBindings);
		}
		if (this.completedNoHitsDisplay)
		{
			this.completedNoHitsDisplay.SetActive(completion.noHits);
		}
		if (this.boundAllDisplay)
		{
			this.boundAllDisplay.SetActive(completion.allBindings);
		}
		if (this.boundAllBackboard)
		{
			this.boundAllBackboard.SetActive(completion.allBindings);
		}
		if (this.boundNailDisplay)
		{
			this.boundNailDisplay.SetActive(completion.boundNail && !completion.allBindings);
		}
		if (this.boundHeartDisplay)
		{
			this.boundHeartDisplay.SetActive(completion.boundShell && !completion.allBindings);
		}
		if (this.boundCharmsDisplay)
		{
			this.boundCharmsDisplay.SetActive(completion.boundCharms && !completion.allBindings);
		}
		if (this.boundSoulDisplay)
		{
			this.boundSoulDisplay.SetActive(completion.boundSoul && !completion.allBindings);
		}
	}

	// Token: 0x06000C59 RID: 3161 RVA: 0x0003F17F File Offset: 0x0003D37F
	public void ShowLockUI(bool value)
	{
		if (BossSequenceDoor.lockedUI)
		{
			if (value)
			{
				BossSequenceDoor.lockedUI.Show(this);
				return;
			}
			BossSequenceDoor.lockedUI.Hide();
		}
	}

	// Token: 0x06000C5A RID: 3162 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (this.doUnlockSequence && collision.gameObject.tag == "Player" && HeroController.instance.isHeroInPosition)
		{
			BossSequenceDoor[] array = this.requiredComplete;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].CurrentCompletion.completed)
				{
					return;
				}
			}
			this.doUnlockSequence = false;
			this.completion.unlocked = true;
			this.SaveState();
			base.StartCoroutine(this.DoorUnlockSequence());
		}
	}

	// Token: 0x06000C5B RID: 3163 RVA: 0x0003F22C File Offset: 0x0003D42C
	private void StartShake()
	{
		FSMUtility.SetBool(GameCameras.instance.cameraShakeFSM, "RumblingMed", true);
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(HeroController.instance.gameObject, "Roar Lock");
		if (playMakerFSM)
		{
			playMakerFSM.FsmVariables.FindFsmGameObject("Roar Object").Value = base.gameObject;
		}
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR ENTER", false);
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x0003F29B File Offset: 0x0003D49B
	private void StopShake()
	{
		FSMUtility.SetBool(GameCameras.instance.cameraShakeFSM, "RumblingMed", false);
		GameCameras.instance.cameraShakeFSM.SendEvent("StopRumble");
		FSMUtility.SendEventToGameObject(HeroController.instance.gameObject, "ROAR EXIT", false);
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0003F2DB File Offset: 0x0003D4DB
	private IEnumerator DoorUnlockSequence()
	{
		this.StartShake();
		if (this.cameraLock)
		{
			this.cameraLock.SetActive(true);
		}
		if (this.lockBreakAnticEffects)
		{
			this.lockBreakAnticEffects.SetActive(true);
		}
		if (this.lockBreakRumbleSound)
		{
			this.lockBreakRumbleSound.SetActive(true);
		}
		if (this.glowParticles)
		{
			this.glowParticles.main.duration = this.lockBreakAnticTime;
			this.glowParticles.Play();
		}
		if (this.glowSprites.Length != 0)
		{
			Material mat = new Material(this.spriteFlashMaterial);
			SpriteRenderer[] array = this.glowSprites;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].sharedMaterial = mat;
			}
			Color[] startColors = new Color[this.fadeSprites.Length];
			for (int j = 0; j < startColors.Length; j++)
			{
				startColors[j] = this.fadeSprites[j].color;
				this.fadeSprites[j].color = Color.clear;
				this.fadeSprites[j].gameObject.SetActive(true);
			}
			for (float elapsed = 0f; elapsed < this.lockBreakAnticTime; elapsed += Time.deltaTime)
			{
				float num = this.glowCurve.Evaluate(elapsed / this.lockBreakAnticTime);
				mat.SetFloat("_FlashAmount", num);
				for (int k = 0; k < startColors.Length; k++)
				{
					Color color = startColors[k];
					color.a *= num;
					this.fadeSprites[k].color = color;
				}
				yield return null;
			}
			mat = null;
			startColors = null;
		}
		else
		{
			yield return new WaitForSeconds(this.lockBreakAnticTime);
		}
		this.StopShake();
		if (this.cameraLock)
		{
			this.cameraLock.SetActive(false);
		}
		if (this.lockBreakRumbleSound)
		{
			this.lockBreakRumbleSound.SetActive(false);
		}
		if (this.lockSet)
		{
			this.lockSet.SetActive(false);
		}
		if (this.lockBreakEffects)
		{
			this.lockBreakEffects.SetActive(true);
		}
		if (this.unlockedSet)
		{
			this.unlockedSet.SetActive(true);
		}
		GameCameras.instance.cameraShakeFSM.SendEvent("BigShake");
		yield break;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0003F2EC File Offset: 0x0003D4EC
	public BossSequenceDoor()
	{
		this.doLockBreakSequence = true;
		this.glowCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});
		this.lockBreakAnticTime = 3.3f;
		base..ctor();
	}

	// Token: 0x04000D0F RID: 3343
	[Header("Door-specific")]
	public string playerDataString;

	// Token: 0x04000D10 RID: 3344
	private BossSequenceDoor.Completion completion;

	// Token: 0x04000D11 RID: 3345
	public BossSequence bossSequence;

	// Token: 0x04000D12 RID: 3346
	[Space]
	public string titleSuperKey;

	// Token: 0x04000D13 RID: 3347
	public string titleSuperSheet;

	// Token: 0x04000D14 RID: 3348
	public string titleMainKey;

	// Token: 0x04000D15 RID: 3349
	public string titleMainSheet;

	// Token: 0x04000D16 RID: 3350
	public string descriptionKey;

	// Token: 0x04000D17 RID: 3351
	public string descriptionSheet;

	// Token: 0x04000D18 RID: 3352
	[Space]
	public BossSequenceDoor[] requiredComplete;

	// Token: 0x04000D19 RID: 3353
	[Header("Prefab")]
	public GameObject completedDisplay;

	// Token: 0x04000D1A RID: 3354
	public GameObject completedAllDisplay;

	// Token: 0x04000D1B RID: 3355
	public GameObject completedNoHitsDisplay;

	// Token: 0x04000D1C RID: 3356
	[Space]
	public GameObject boundNailDisplay;

	// Token: 0x04000D1D RID: 3357
	public GameObject boundHeartDisplay;

	// Token: 0x04000D1E RID: 3358
	public GameObject boundCharmsDisplay;

	// Token: 0x04000D1F RID: 3359
	public GameObject boundSoulDisplay;

	// Token: 0x04000D20 RID: 3360
	public GameObject boundAllDisplay;

	// Token: 0x04000D21 RID: 3361
	public GameObject boundAllBackboard;

	// Token: 0x04000D22 RID: 3362
	[Space]
	public GameObject lockSet;

	// Token: 0x04000D23 RID: 3363
	public GameObject lockInteractPrompt;

	// Token: 0x04000D24 RID: 3364
	public GameObject cameraLock;

	// Token: 0x04000D25 RID: 3365
	public GameObject unlockedSet;

	// Token: 0x04000D26 RID: 3366
	public PlayMakerFSM challengeFSM;

	// Token: 0x04000D27 RID: 3367
	public GameObject dreamReturnGate;

	// Token: 0x04000D28 RID: 3368
	[Header("Lock Break Effects")]
	public bool doLockBreakSequence;

	// Token: 0x04000D29 RID: 3369
	public GameObject lockBreakAnticEffects;

	// Token: 0x04000D2A RID: 3370
	public GameObject lockBreakRumbleSound;

	// Token: 0x04000D2B RID: 3371
	public SpriteRenderer[] glowSprites;

	// Token: 0x04000D2C RID: 3372
	public Material spriteFlashMaterial;

	// Token: 0x04000D2D RID: 3373
	public SpriteRenderer[] fadeSprites;

	// Token: 0x04000D2E RID: 3374
	public AnimationCurve glowCurve;

	// Token: 0x04000D2F RID: 3375
	public ParticleSystem glowParticles;

	// Token: 0x04000D30 RID: 3376
	public float lockBreakAnticTime;

	// Token: 0x04000D31 RID: 3377
	public GameObject lockBreakEffects;

	// Token: 0x04000D32 RID: 3378
	private bool doUnlockSequence;

	// Token: 0x04000D33 RID: 3379
	[Space]
	public GameObject lockedUIPrefab;

	// Token: 0x04000D34 RID: 3380
	private static BossDoorLockUI lockedUI;

	// Token: 0x0200024A RID: 586
	[Serializable]
	public struct Completion
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0003F350 File Offset: 0x0003D550
		public static BossSequenceDoor.Completion None
		{
			get
			{
				return new BossSequenceDoor.Completion
				{
					canUnlock = false,
					unlocked = false,
					completed = false,
					allBindings = false,
					noHits = false,
					boundNail = false,
					boundShell = false,
					boundCharms = false,
					boundSoul = false,
					viewedBossSceneCompletions = new List<string>()
				};
			}
		}

		// Token: 0x04000D35 RID: 3381
		public bool canUnlock;

		// Token: 0x04000D36 RID: 3382
		public bool unlocked;

		// Token: 0x04000D37 RID: 3383
		public bool completed;

		// Token: 0x04000D38 RID: 3384
		public bool allBindings;

		// Token: 0x04000D39 RID: 3385
		public bool noHits;

		// Token: 0x04000D3A RID: 3386
		public bool boundNail;

		// Token: 0x04000D3B RID: 3387
		public bool boundShell;

		// Token: 0x04000D3C RID: 3388
		public bool boundCharms;

		// Token: 0x04000D3D RID: 3389
		public bool boundSoul;

		// Token: 0x04000D3E RID: 3390
		public List<string> viewedBossSceneCompletions;
	}
}
