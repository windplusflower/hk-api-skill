using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200024F RID: 591
public class BossStatue : MonoBehaviour
{
	// Token: 0x14000014 RID: 20
	// (add) Token: 0x06000C6E RID: 3182 RVA: 0x0003F890 File Offset: 0x0003DA90
	// (remove) Token: 0x06000C6F RID: 3183 RVA: 0x0003F8C8 File Offset: 0x0003DAC8
	public event BossStatue.StatueSwapEndEvent OnStatueSwapFinished;

	// Token: 0x14000015 RID: 21
	// (add) Token: 0x06000C70 RID: 3184 RVA: 0x0003F900 File Offset: 0x0003DB00
	// (remove) Token: 0x06000C71 RID: 3185 RVA: 0x0003F938 File Offset: 0x0003DB38
	public event BossStatue.SeenNewStatueEvent OnSeenNewStatue;

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x06000C72 RID: 3186 RVA: 0x0003F96D File Offset: 0x0003DB6D
	// (set) Token: 0x06000C73 RID: 3187 RVA: 0x0003F97C File Offset: 0x0003DB7C
	public bool UsingDreamVersion
	{
		get
		{
			return this.StatueState.usingAltVersion;
		}
		private set
		{
			BossStatue.Completion statueState = this.StatueState;
			statueState.usingAltVersion = value;
			this.StatueState = statueState;
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000C74 RID: 3188 RVA: 0x0003F9A0 File Offset: 0x0003DBA0
	// (set) Token: 0x06000C75 RID: 3189 RVA: 0x0003FA05 File Offset: 0x0003DC05
	public BossStatue.Completion StatueState
	{
		get
		{
			if (string.IsNullOrEmpty(this.statueStatePD))
			{
				return BossStatue.Completion.None;
			}
			BossStatue.Completion playerDataVariable = GameManager.instance.GetPlayerDataVariable<BossStatue.Completion>(this.statueStatePD);
			if (!playerDataVariable.isUnlocked && this.bossScene && (this.bossScene.IsUnlocked(BossSceneCheckSource.Statue) || this.isAlwaysUnlocked))
			{
				playerDataVariable.isUnlocked = true;
			}
			return playerDataVariable;
		}
		set
		{
			if (!string.IsNullOrEmpty(this.statueStatePD))
			{
				GameManager.instance.SetPlayerDataVariable<BossStatue.Completion>(this.statueStatePD, value);
			}
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0003FA28 File Offset: 0x0003DC28
	// (set) Token: 0x06000C77 RID: 3191 RVA: 0x0003FA8D File Offset: 0x0003DC8D
	public BossStatue.Completion DreamStatueState
	{
		get
		{
			if (string.IsNullOrEmpty(this.dreamStatueStatePD))
			{
				return BossStatue.Completion.None;
			}
			BossStatue.Completion playerDataVariable = GameManager.instance.GetPlayerDataVariable<BossStatue.Completion>(this.dreamStatueStatePD);
			if (!playerDataVariable.isUnlocked && this.dreamBossScene && (this.dreamBossScene.IsUnlocked(BossSceneCheckSource.Statue) || this.isAlwaysUnlockedDream))
			{
				playerDataVariable.isUnlocked = true;
			}
			return playerDataVariable;
		}
		set
		{
			if (!string.IsNullOrEmpty(this.dreamStatueStatePD))
			{
				GameManager.instance.SetPlayerDataVariable<BossStatue.Completion>(this.dreamStatueStatePD, value);
			}
		}
	}

	// Token: 0x1700015F RID: 351
	// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0003FAAD File Offset: 0x0003DCAD
	public bool HasRegularVersion
	{
		get
		{
			return this.bossScene && !string.IsNullOrEmpty(this.statueStatePD);
		}
	}

	// Token: 0x17000160 RID: 352
	// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0003FACC File Offset: 0x0003DCCC
	public bool HasDreamVersion
	{
		get
		{
			return this.dreamBossScene && !string.IsNullOrEmpty(this.dreamStatueStatePD);
		}
	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x0003FAEC File Offset: 0x0003DCEC
	private void Awake()
	{
		this.dreamToggle = base.GetComponentInChildren<IBossStatueToggle>(false);
		if (this.dreamReturnGate)
		{
			GameObject gameObject = this.dreamReturnGate;
			gameObject.name = gameObject.name + "_" + base.gameObject.name;
		}
		if (this.cameraLock)
		{
			this.cameraLock.cameraYMin = (this.cameraLock.cameraYMax = base.transform.position.y + this.inspectCameraHeight);
		}
	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x0003FB78 File Offset: 0x0003DD78
	private void Start()
	{
		this.UpdateDetails();
		if (this.StatueState.isUnlocked)
		{
			foreach (GameObject gameObject in this.disableIfLocked)
			{
				if (gameObject)
				{
					gameObject.SetActive(true);
				}
			}
			GameObject[] array = this.enableIfLocked;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(false);
			}
			if (this.statueDisplay)
			{
				this.statueDisplay.SetActive(true);
			}
		}
		else
		{
			GameObject[] array = this.disableIfLocked;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(false);
			}
			array = this.enableIfLocked;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(true);
			}
			if (this.statueDisplay)
			{
				this.statueDisplay.SetActive(false);
			}
		}
		if (this.statueDisplayAlt)
		{
			this.statueDisplayAlt.SetActive(false);
		}
		if (this.dreamToggle != null)
		{
			this.dreamToggle.SetOwner(this);
		}
		if (this.DreamStatueState.isUnlocked)
		{
			if (this.dreamToggle != null)
			{
				this.dreamToggle.SetState(true);
			}
		}
		else if (this.dreamToggle != null)
		{
			this.dreamToggle.SetState(false);
		}
		Animator component = this.statueDisplay.GetComponent<Animator>();
		if (component)
		{
			component.enabled = false;
		}
		component = this.statueDisplayAlt.GetComponent<Animator>();
		if (component)
		{
			component.enabled = false;
		}
		if (this.lightTrigger)
		{
			this.lightTrigger.OnTriggerEntered += delegate(Collider2D collision, GameObject sender)
			{
				bool flag = false;
				BossStatue.Completion completion = this.StatueState;
				if (completion.isUnlocked && !completion.hasBeenSeen && !this.isAlwaysUnlocked)
				{
					completion.hasBeenSeen = true;
					this.StatueState = completion;
					flag = true;
				}
				completion = this.DreamStatueState;
				if (completion.isUnlocked && !completion.hasBeenSeen && !this.isAlwaysUnlockedDream)
				{
					completion.hasBeenSeen = true;
					this.DreamStatueState = completion;
					flag = true;
				}
				if (flag && this.OnSeenNewStatue != null)
				{
					this.OnSeenNewStatue();
				}
			};
		}
		this.SetPlaquesVisible((this.StatueState.isUnlocked && this.StatueState.hasBeenSeen) || this.isAlwaysUnlocked);
	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x0003FD38 File Offset: 0x0003DF38
	public void SetPlaquesVisible(bool isEnabled)
	{
		this.regularPlaque.gameObject.SetActive(false);
		this.altPlaqueL.gameObject.SetActive(false);
		this.altPlaqueR.gameObject.SetActive(false);
		if (isEnabled)
		{
			if (this.bossScene && !this.dreamBossScene)
			{
				this.regularPlaque.gameObject.SetActive(true);
				this.SetPlaqueState(this.StatueState, this.regularPlaque, this.statueStatePD);
			}
			else if (this.bossScene && this.dreamBossScene)
			{
				this.altPlaqueL.gameObject.SetActive(true);
				this.altPlaqueR.gameObject.SetActive(true);
				this.SetPlaqueState(this.StatueState, this.altPlaqueL, this.statueStatePD);
				this.SetPlaqueState(this.DreamStatueState, this.altPlaqueR, this.dreamStatueStatePD);
			}
		}
		this.lockedPlaque.enabled = !isEnabled;
	}

	// Token: 0x06000C7D RID: 3197 RVA: 0x0003FE40 File Offset: 0x0003E040
	public void SetPlaqueState(BossStatue.Completion statueState, BossStatueTrophyPlaque plaque, string playerDataKey)
	{
		PlayerData playerData = GameManager.instance.playerData;
		if (string.IsNullOrEmpty(playerData.GetString("currentBossStatueCompletionKey")) || playerData.GetString("currentBossStatueCompletionKey") != playerDataKey)
		{
			plaque.SetDisplay(BossStatueTrophyPlaque.GetDisplayType(statueState));
			return;
		}
		BossStatueTrophyPlaque.DisplayType displayType = BossStatueTrophyPlaque.GetDisplayType(statueState);
		plaque.SetDisplay(displayType);
		plaque.DoTierCompleteEffect((BossStatueTrophyPlaque.DisplayType)playerData.GetInt("bossStatueTargetLevel"));
		playerData.SetStringSwappedArgs("", "currentBossStatueCompletionKey");
		playerData.SetIntSwappedArgs(-1, "bossStatueTargetLevel");
	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x0003FEC8 File Offset: 0x0003E0C8
	public void SetDreamVersion(bool value, bool useAltStatue = false, bool doAnim = true)
	{
		this.UsingDreamVersion = value;
		if (useAltStatue && this.statueDisplayAlt && this.statueDisplay)
		{
			base.StartCoroutine(this.SwapStatues(doAnim));
		}
		else if (this.OnStatueSwapFinished != null)
		{
			this.OnStatueSwapFinished();
		}
		this.wasUsingDreamVersion = value;
		this.UpdateDetails();
	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x0003FF2C File Offset: 0x0003E12C
	private void UpdateDetails()
	{
		if (this.bossUIControlFSM)
		{
			BossStatue.BossUIDetails bossUIDetails = this.UsingDreamVersion ? this.dreamBossDetails : this.bossDetails;
			this.bossUIControlFSM.FsmVariables.FindFsmString("Boss Name Key").Value = bossUIDetails.nameKey;
			this.bossUIControlFSM.FsmVariables.FindFsmString("Boss Name Sheet").Value = bossUIDetails.nameSheet;
			this.bossUIControlFSM.FsmVariables.FindFsmString("Description Key").Value = bossUIDetails.descriptionKey;
			this.bossUIControlFSM.FsmVariables.FindFsmString("Description Sheet").Value = bossUIDetails.descriptionSheet;
		}
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0003FFE0 File Offset: 0x0003E1E0
	private IEnumerator SwapStatues(bool doAnim)
	{
		GameObject current = this.wasUsingDreamVersion ? this.statueDisplayAlt : this.statueDisplay;
		GameObject next = this.wasUsingDreamVersion ? this.statueDisplay : this.statueDisplayAlt;
		if (doAnim)
		{
			if (this.bossUIControlFSM)
			{
				FSMUtility.SendEventToGameObject(this.bossUIControlFSM.gameObject, "NPC CONTROL OFF", false);
			}
			yield return new WaitForSeconds(this.swapWaitTime);
			if (this.statueShakeParticles)
			{
				this.statueShakeParticles.Play();
			}
			if (this.statueShakeLoop)
			{
				this.statueShakeLoop.Play();
			}
			yield return this.StartCoroutine(this.Jitter(this.shakeTime, 0.1f, current));
			if (this.statueShakeLoop)
			{
				this.statueShakeLoop.Stop();
			}
			this.StartCoroutine(this.PlayAudioEventDelayed(this.statueDownSound, this.statueDownSoundDelay));
			yield return this.StartCoroutine(this.PlayAnimWait(current.GetComponent<Animator>(), "Down", 0f));
		}
		current.SetActive(false);
		if (doAnim)
		{
			yield return new WaitForSeconds(this.holdTime);
			this.StartCoroutine(this.PlayParticlesDelay(this.statueUpParticles, this.upParticleDelay));
			this.StartCoroutine(this.PlayAudioEventDelayed(this.statueUpSound, this.statueUpSoundDelay));
		}
		next.transform.position = current.transform.position;
		next.SetActive(true);
		if (doAnim)
		{
			yield return this.StartCoroutine(this.PlayAnimWait(next.GetComponent<Animator>(), "Up", 0f));
			if (this.bossUIControlFSM)
			{
				FSMUtility.SendEventToGameObject(this.bossUIControlFSM.gameObject, "CONVO CANCEL", false);
			}
		}
		if (this.OnStatueSwapFinished != null)
		{
			this.OnStatueSwapFinished();
		}
		yield break;
	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0003FFF6 File Offset: 0x0003E1F6
	private IEnumerator Jitter(float duration, float magnitude, GameObject obj)
	{
		Transform sprite = obj.transform;
		Vector3 initialPos = sprite.position;
		float elapsed = 0f;
		float half = magnitude / 2f;
		while (elapsed < duration)
		{
			sprite.position = initialPos + new Vector3(UnityEngine.Random.Range(-half, half), UnityEngine.Random.Range(-half, half), 0f);
			yield return null;
			elapsed += Time.deltaTime;
		}
		sprite.position = initialPos;
		yield break;
	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x00040013 File Offset: 0x0003E213
	private IEnumerator PlayAnimWait(Animator animator, string stateName, float normalizedTime)
	{
		if (animator)
		{
			animator.enabled = true;
			animator.Play(stateName, 0, normalizedTime);
			yield return null;
			yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
			animator.enabled = false;
		}
		yield break;
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x00040030 File Offset: 0x0003E230
	private IEnumerator PlayParticlesDelay(ParticleSystem system, float delay)
	{
		if (system)
		{
			yield return new WaitForSeconds(delay);
			system.Play();
		}
		yield break;
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x00040046 File Offset: 0x0003E246
	private IEnumerator PlayAudioEventDelayed(AudioEvent audioEvent, float delay)
	{
		yield return new WaitForSeconds(delay);
		audioEvent.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		yield break;
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x00040063 File Offset: 0x0003E263
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireSphere(base.transform.position + new Vector3(0f, this.inspectCameraHeight, 0f), 0.25f);
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x000400A0 File Offset: 0x0003E2A0
	public BossStatue()
	{
		this.inspectCameraHeight = 5.5f;
		this.statueUpSoundDelay = 0.3f;
		this.swapWaitTime = 0.25f;
		this.shakeTime = 1f;
		this.holdTime = 0.5f;
		this.upParticleDelay = 0.25f;
		base..ctor();
	}

	// Token: 0x04000D52 RID: 3410
	[Header("Boss Data")]
	public BossScene bossScene;

	// Token: 0x04000D53 RID: 3411
	public BossScene dreamBossScene;

	// Token: 0x04000D54 RID: 3412
	[Header("Statue Data")]
	[FormerlySerializedAs("statueStateInt")]
	public string statueStatePD;

	// Token: 0x04000D55 RID: 3413
	public BossStatue.BossUIDetails bossDetails;

	// Token: 0x04000D56 RID: 3414
	[Space]
	[FormerlySerializedAs("dreamStatueStateInt")]
	public string dreamStatueStatePD;

	// Token: 0x04000D57 RID: 3415
	public BossStatue.BossUIDetails dreamBossDetails;

	// Token: 0x04000D58 RID: 3416
	[Space]
	public bool hasNoTiers;

	// Token: 0x04000D59 RID: 3417
	public bool dontCountCompletion;

	// Token: 0x04000D5A RID: 3418
	public bool isAlwaysUnlocked;

	// Token: 0x04000D5B RID: 3419
	public bool isAlwaysUnlockedDream;

	// Token: 0x04000D5C RID: 3420
	public float inspectCameraHeight;

	// Token: 0x04000D5D RID: 3421
	public bool isHidden;

	// Token: 0x04000D5E RID: 3422
	[Header("Prefab Stuff")]
	public PlayMakerFSM bossUIControlFSM;

	// Token: 0x04000D5F RID: 3423
	[Space]
	public GameObject[] disableIfLocked;

	// Token: 0x04000D60 RID: 3424
	public GameObject[] enableIfLocked;

	// Token: 0x04000D61 RID: 3425
	public BossStatueTrophyPlaque regularPlaque;

	// Token: 0x04000D62 RID: 3426
	public BossStatueTrophyPlaque altPlaqueL;

	// Token: 0x04000D63 RID: 3427
	public BossStatueTrophyPlaque altPlaqueR;

	// Token: 0x04000D64 RID: 3428
	public SpriteRenderer lockedPlaque;

	// Token: 0x04000D65 RID: 3429
	[Space]
	public GameObject dreamReturnGate;

	// Token: 0x04000D66 RID: 3430
	public TriggerEnterEvent lightTrigger;

	// Token: 0x04000D67 RID: 3431
	public CameraLockArea cameraLock;

	// Token: 0x04000D68 RID: 3432
	[Header("Animation")]
	public GameObject statueDisplay;

	// Token: 0x04000D69 RID: 3433
	public GameObject statueDisplayAlt;

	// Token: 0x04000D6A RID: 3434
	public ParticleSystem statueShakeParticles;

	// Token: 0x04000D6B RID: 3435
	public ParticleSystem statueUpParticles;

	// Token: 0x04000D6C RID: 3436
	public AudioSource statueShakeLoop;

	// Token: 0x04000D6D RID: 3437
	public AudioSource audioSourcePrefab;

	// Token: 0x04000D6E RID: 3438
	public AudioEvent statueDownSound;

	// Token: 0x04000D6F RID: 3439
	public float statueDownSoundDelay;

	// Token: 0x04000D70 RID: 3440
	public AudioEvent statueUpSound;

	// Token: 0x04000D71 RID: 3441
	public float statueUpSoundDelay;

	// Token: 0x04000D72 RID: 3442
	public float swapWaitTime;

	// Token: 0x04000D73 RID: 3443
	public float shakeTime;

	// Token: 0x04000D74 RID: 3444
	public float holdTime;

	// Token: 0x04000D75 RID: 3445
	public float upParticleDelay;

	// Token: 0x04000D76 RID: 3446
	private IBossStatueToggle dreamToggle;

	// Token: 0x04000D77 RID: 3447
	private bool wasUsingDreamVersion;

	// Token: 0x02000250 RID: 592
	// (Invoke) Token: 0x06000C89 RID: 3209
	public delegate void StatueSwapEndEvent();

	// Token: 0x02000251 RID: 593
	// (Invoke) Token: 0x06000C8D RID: 3213
	public delegate void SeenNewStatueEvent();

	// Token: 0x02000252 RID: 594
	[Serializable]
	public struct Completion
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00040180 File Offset: 0x0003E380
		public static BossStatue.Completion None
		{
			get
			{
				return new BossStatue.Completion
				{
					hasBeenSeen = false,
					isUnlocked = false,
					completedTier1 = false,
					completedTier2 = false,
					completedTier3 = false,
					seenTier3Unlock = false,
					usingAltVersion = false
				};
			}
		}

		// Token: 0x04000D78 RID: 3448
		public bool hasBeenSeen;

		// Token: 0x04000D79 RID: 3449
		public bool isUnlocked;

		// Token: 0x04000D7A RID: 3450
		public bool completedTier1;

		// Token: 0x04000D7B RID: 3451
		public bool completedTier2;

		// Token: 0x04000D7C RID: 3452
		public bool completedTier3;

		// Token: 0x04000D7D RID: 3453
		public bool seenTier3Unlock;

		// Token: 0x04000D7E RID: 3454
		public bool usingAltVersion;
	}

	// Token: 0x02000253 RID: 595
	[Serializable]
	public struct BossUIDetails
	{
		// Token: 0x04000D7F RID: 3455
		public string nameKey;

		// Token: 0x04000D80 RID: 3456
		public string nameSheet;

		// Token: 0x04000D81 RID: 3457
		public string descriptionKey;

		// Token: 0x04000D82 RID: 3458
		public string descriptionSheet;
	}
}
