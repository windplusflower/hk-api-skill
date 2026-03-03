using System;
using System.Collections;
using System.Collections.Generic;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000226 RID: 550
public class BossSceneController : MonoBehaviour
{
	// Token: 0x14000012 RID: 18
	// (add) Token: 0x06000BAE RID: 2990 RVA: 0x0003D408 File Offset: 0x0003B608
	// (remove) Token: 0x06000BAF RID: 2991 RVA: 0x0003D440 File Offset: 0x0003B640
	public event Action OnBossesDead;

	// Token: 0x14000013 RID: 19
	// (add) Token: 0x06000BB0 RID: 2992 RVA: 0x0003D478 File Offset: 0x0003B678
	// (remove) Token: 0x06000BB1 RID: 2993 RVA: 0x0003D4B0 File Offset: 0x0003B6B0
	public event Action OnBossSceneComplete;

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0003D4E5 File Offset: 0x0003B6E5
	public static bool IsBossScene
	{
		get
		{
			return BossSceneController.Instance != null;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0003D4F2 File Offset: 0x0003B6F2
	// (set) Token: 0x06000BB4 RID: 2996 RVA: 0x0003D4FA File Offset: 0x0003B6FA
	public bool HasTransitionedIn { get; private set; }

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x0003D503 File Offset: 0x0003B703
	public static bool IsTransitioning
	{
		get
		{
			return BossSceneController.Instance != null && BossSceneController.Instance.isTransitioningOut;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0003D51E File Offset: 0x0003B71E
	// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0003D526 File Offset: 0x0003B726
	public bool CanTransition
	{
		get
		{
			return this.canTransition;
		}
		set
		{
			this.canTransition = value;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0003D52F File Offset: 0x0003B72F
	// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0003D537 File Offset: 0x0003B737
	public int BossLevel
	{
		get
		{
			return this.bossLevel;
		}
		set
		{
			this.bossLevel = value;
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0003D540 File Offset: 0x0003B740
	// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0003D548 File Offset: 0x0003B748
	public string DreamReturnEvent { get; set; }

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0003D551 File Offset: 0x0003B751
	// (set) Token: 0x06000BBD RID: 3005 RVA: 0x0003D559 File Offset: 0x0003B759
	public Dictionary<HealthManager, BossSceneController.BossHealthDetails> BossHealthLookup { get; private set; }

	// Token: 0x06000BBE RID: 3006 RVA: 0x0003D564 File Offset: 0x0003B764
	private void Awake()
	{
		BossSceneController.Instance = this;
		this.BossHealthLookup = new Dictionary<HealthManager, BossSceneController.BossHealthDetails>();
		if (BossSceneController.SetupEvent == null)
		{
			BossSequenceController.CheckLoadSequence(this);
			this.doTransition = false;
		}
		if (BossSceneController.SetupEvent != null)
		{
			BossSceneController.SetupEventDelegate setupEvent = BossSceneController.SetupEvent;
			BossSceneController.SetupEvent = null;
			setupEvent(this);
			this.Setup();
		}
		if (this.customExitPoint)
		{
			this.customExitPoint.OnBeforeTransition += delegate()
			{
				this.restoreBindingsOnDestroy = false;
			};
		}
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
	private void OnDestroy()
	{
		if (this.restoreBindingsOnDestroy)
		{
			this.RestoreBindings();
		}
		if (BossSceneController.Instance == this)
		{
			BossSceneController.Instance = null;
		}
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0003D5FB File Offset: 0x0003B7FB
	private IEnumerator Start()
	{
		if (GameManager.instance.sm && GameManager.instance.sm.mapZone != MapZone.GODS_GLORY)
		{
			Debug.LogError("SceneManager map zone not set to GODS_GLORY, boss logic and dream death may break!");
		}
		if (this.doTransition)
		{
			if (this.transitionPrefab)
			{
				UnityEngine.Object.Instantiate<GameObject>(this.transitionPrefab);
			}
			else
			{
				Debug.LogError("Boss Scene Controller has no transition prefab assigned!", this);
			}
			if (this.doTransitionIn)
			{
				if (this.transitionInHoldTime > 0f)
				{
					EventRegister.SendEvent("GG TRANSITION OUT INSTANT");
					yield return new WaitForSeconds(this.transitionInHoldTime);
				}
				EventRegister.SendEvent("GG TRANSITION IN");
			}
		}
		this.HasTransitionedIn = true;
		yield break;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x0003D60C File Offset: 0x0003B80C
	private void Update()
	{
		float timer = BossSequenceController.Timer;
		GameManager.instance.IncreaseGameTimer(ref timer);
		BossSequenceController.Timer = timer;
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0003D634 File Offset: 0x0003B834
	private void Setup()
	{
		for (int i = 0; i < this.bosses.Length; i++)
		{
			if (this.bosses[i])
			{
				this.bossesLeft++;
				this.bosses[i].OnDeath += delegate()
				{
					this.bossesLeft--;
					this.CheckBossesDead();
				};
			}
		}
		if (!BossSequenceController.KnightDamaged && HeroController.instance)
		{
			HeroController.instance.OnTakenDamage += this.SetKnightDamaged;
			this.knightDamagedSubscribed = true;
		}
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0003D6BA File Offset: 0x0003B8BA
	private void SetKnightDamaged()
	{
		BossSequenceController.KnightDamaged = true;
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x0003D6C2 File Offset: 0x0003B8C2
	private void CheckBossesDead()
	{
		if (this.bossesLeft > 0)
		{
			return;
		}
		this.EndBossScene();
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0003D6D4 File Offset: 0x0003B8D4
	public void EndBossScene()
	{
		if (!this.endedScene)
		{
			this.endedScene = true;
			if (this.knightDamagedSubscribed)
			{
				HeroController.instance.OnTakenDamage -= this.SetKnightDamaged;
			}
			if (this.OnBossesDead != null)
			{
				this.OnBossesDead();
			}
			base.StartCoroutine(this.EndSceneDelayed());
		}
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0003D72E File Offset: 0x0003B92E
	private IEnumerator EndSceneDelayed()
	{
		yield return new WaitForSeconds(this.bossesDeadWaitTime);
		bool waitingForTransition = false;
		if (this.doTransitionOut)
		{
			if (this.endTransitionEvent)
			{
				this.isTransitioningOut = true;
				waitingForTransition = true;
				this.endTransitionEvent.OnReceivedEvent += delegate()
				{
					waitingForTransition = false;
				};
			}
			else
			{
				Debug.LogError("Boss Scene controller has no end transition event assigned!", this);
			}
			if (BossSequenceController.IsInSequence)
			{
				if (BossSequenceController.IsLastBossScene)
				{
					EventRegister.SendEvent("GG TRANSITION FINAL");
				}
				else
				{
					EventRegister.SendEvent("GG TRANSITION OUT");
				}
			}
			else
			{
				EventRegister.SendEvent("GG TRANSITION OUT STATUE");
			}
		}
		yield return new WaitForSeconds(this.transitionOutHoldTime);
		while (waitingForTransition || HeroController.instance.cState.hazardRespawning || HeroController.instance.cState.hazardDeath || HeroController.instance.cState.spellQuake || !this.CanTransition)
		{
			yield return null;
		}
		if (HeroController.instance.cState.dead || HeroController.instance.cState.transitioning)
		{
			yield break;
		}
		Debug.Log("Boss scene ended");
		this.restoreBindingsOnDestroy = false;
		if (this.OnBossSceneComplete != null)
		{
			this.OnBossSceneComplete();
		}
		yield break;
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x0003D740 File Offset: 0x0003B940
	public void DoDreamReturn()
	{
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(base.gameObject, "Dream Return");
		if (playMakerFSM)
		{
			playMakerFSM.SendEvent(this.DreamReturnEvent);
		}
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0003D772 File Offset: 0x0003B972
	public void ApplyBindings()
	{
		BossSequenceController.ApplyBindings();
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x0003D779 File Offset: 0x0003B979
	public void RestoreBindings()
	{
		BossSequenceController.RestoreBindings();
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x0003D780 File Offset: 0x0003B980
	public static void ReportHealth(HealthManager healthManager, int baseHP, int adjustedHP, bool forceAdd = false)
	{
		if (BossSceneController.Instance)
		{
			bool flag = false;
			if (forceAdd)
			{
				flag = true;
			}
			else
			{
				HealthManager[] array = BossSceneController.Instance.bosses;
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i] == healthManager)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				BossSceneController.Instance.BossHealthLookup[healthManager] = new BossSceneController.BossHealthDetails
				{
					baseHP = baseHP,
					adjustedHP = adjustedHP
				};
			}
		}
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0003D7F6 File Offset: 0x0003B9F6
	public BossSceneController()
	{
		this.doTransitionIn = true;
		this.doTransitionOut = true;
		this.canTransition = true;
		this.bossesDeadWaitTime = 5f;
		this.restoreBindingsOnDestroy = true;
		this.doTransition = true;
		base..ctor();
	}

	// Token: 0x04000CAE RID: 3246
	public static BossSceneController Instance;

	// Token: 0x04000CAF RID: 3247
	public static BossSceneController.SetupEventDelegate SetupEvent;

	// Token: 0x04000CB2 RID: 3250
	public Transform heroSpawn;

	// Token: 0x04000CB3 RID: 3251
	public GameObject transitionPrefab;

	// Token: 0x04000CB4 RID: 3252
	public EventRegister endTransitionEvent;

	// Token: 0x04000CB5 RID: 3253
	public bool doTransitionIn;

	// Token: 0x04000CB7 RID: 3255
	public float transitionInHoldTime;

	// Token: 0x04000CB8 RID: 3256
	public bool doTransitionOut;

	// Token: 0x04000CB9 RID: 3257
	public float transitionOutHoldTime;

	// Token: 0x04000CBA RID: 3258
	private bool isTransitioningOut;

	// Token: 0x04000CBB RID: 3259
	private bool canTransition;

	// Token: 0x04000CBC RID: 3260
	[Space]
	[Tooltip("If scene end is handled elsewhere then leave empty. Only assign bosses here if you want the scene to end on HealthManager death event.")]
	public HealthManager[] bosses;

	// Token: 0x04000CBD RID: 3261
	private int bossesLeft;

	// Token: 0x04000CBE RID: 3262
	public float bossesDeadWaitTime;

	// Token: 0x04000CBF RID: 3263
	private int bossLevel;

	// Token: 0x04000CC0 RID: 3264
	private bool endedScene;

	// Token: 0x04000CC1 RID: 3265
	private bool knightDamagedSubscribed;

	// Token: 0x04000CC2 RID: 3266
	private bool restoreBindingsOnDestroy;

	// Token: 0x04000CC3 RID: 3267
	public TransitionPoint customExitPoint;

	// Token: 0x04000CC4 RID: 3268
	private bool doTransition;

	// Token: 0x02000227 RID: 551
	// (Invoke) Token: 0x06000BD0 RID: 3024
	public delegate void SetupEventDelegate(BossSceneController self);

	// Token: 0x02000228 RID: 552
	public struct BossHealthDetails
	{
		// Token: 0x04000CC7 RID: 3271
		public int baseHP;

		// Token: 0x04000CC8 RID: 3272
		public int adjustedHP;
	}
}
