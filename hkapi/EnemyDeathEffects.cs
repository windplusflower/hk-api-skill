using System;
using HutongGames.PlayMaker;
using Modding;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x0200017B RID: 379
public class EnemyDeathEffects : MonoBehaviour
{
	// Token: 0x060008A4 RID: 2212 RVA: 0x0002F4E4 File Offset: 0x0002D6E4
	protected void Start()
	{
		this.PreInstantiate();
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x0002F4EC File Offset: 0x0002D6EC
	public void PreInstantiate()
	{
		if (!this.corpse && this.corpsePrefab)
		{
			this.corpse = UnityEngine.Object.Instantiate<GameObject>(this.corpsePrefab, base.transform.position + this.corpseSpawnPoint, Quaternion.identity, base.transform);
			tk2dSprite[] componentsInChildren = this.corpse.GetComponentsInChildren<tk2dSprite>(true);
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].ForceBuild();
			}
			this.corpse.SetActive(false);
		}
		if (!EnemyDeathEffects.journalUpdateMessageSpawned && this.journalUpdateMessagePrefab)
		{
			EnemyDeathEffects.journalUpdateMessageSpawned = UnityEngine.Object.Instantiate<GameObject>(this.journalUpdateMessagePrefab);
			EnemyDeathEffects.journalUpdateMessageSpawned.SetActive(false);
		}
		PersonalObjectPool component = base.GetComponent<PersonalObjectPool>();
		if (component)
		{
			component.CreateStartupPools();
		}
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x0002F5BD File Offset: 0x0002D7BD
	public void RecieveDeathEvent(float? attackDirection, bool resetDeathEvent = false, bool spellBurn = false, bool isWatery = false)
	{
		ModHooks.OnRecieveDeathEvent(this, this.didFire, ref attackDirection, ref resetDeathEvent, ref spellBurn, ref isWatery);
		this.orig_RecieveDeathEvent(attackDirection, resetDeathEvent, spellBurn, isWatery);
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x0002F5E0 File Offset: 0x0002D7E0
	private void RecordKillForJournal()
	{
		string killedBoolPlayerDataLookupKey = "killed" + this.playerDataName;
		string killCountIntPlayerDataLookupKey = "kills" + this.playerDataName;
		string newDataBoolPlayerDataLookupKey = "newData" + this.playerDataName;
		ModHooks.OnRecordKillForJournal(this, this.playerDataName, killedBoolPlayerDataLookupKey, killCountIntPlayerDataLookupKey, newDataBoolPlayerDataLookupKey);
		this.orig_RecordKillForJournal();
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x0002F638 File Offset: 0x0002D838
	private void EmitCorpse(float? attackDirection, bool isWatery, bool spellBurn = false)
	{
		if (this.corpse == null)
		{
			return;
		}
		this.corpse.transform.SetParent(null);
		this.corpse.transform.SetPositionZ(UnityEngine.Random.Range(0.008f, 0.009f));
		this.corpse.SetActive(true);
		PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(this.corpse, "corpse");
		if (playMakerFSM != null)
		{
			FsmBool fsmBool = playMakerFSM.FsmVariables.GetFsmBool("spellBurn");
			if (fsmBool != null)
			{
				fsmBool.Value = false;
			}
		}
		Corpse component = this.corpse.GetComponent<Corpse>();
		if (component)
		{
			component.Setup(isWatery, spellBurn);
		}
		if (isWatery)
		{
			return;
		}
		this.corpse.transform.SetRotation2D(this.rotateCorpse ? base.transform.GetRotation2D() : 0f);
		if (Mathf.Abs(base.transform.eulerAngles.z) >= 45f)
		{
			Collider2D component2 = base.GetComponent<Collider2D>();
			Collider2D component3 = this.corpse.GetComponent<Collider2D>();
			if (!this.rotateCorpse && component2 && component3)
			{
				Vector3 b = component2.bounds.center - component3.bounds.center;
				b.z = 0f;
				this.corpse.transform.position += b;
			}
		}
		float d = 1f;
		if (attackDirection == null)
		{
			d = 0f;
		}
		int cardinalDirection = DirectionUtils.GetCardinalDirection(attackDirection.GetValueOrDefault());
		Rigidbody2D component4 = this.corpse.GetComponent<Rigidbody2D>();
		if (component4 != null && !component4.isKinematic)
		{
			float num = this.corpseFlingSpeed;
			float num2;
			switch (cardinalDirection)
			{
			case 0:
				num2 = (this.lowCorpseArc ? 10f : 60f);
				this.corpse.transform.SetScaleX(this.corpse.transform.localScale.x * (this.corpseFacesRight ? -1f : 1f) * Mathf.Sign(base.transform.localScale.x));
				break;
			case 1:
				num2 = UnityEngine.Random.Range(75f, 105f);
				num *= 1.3f;
				break;
			case 2:
				num2 = (this.lowCorpseArc ? 170f : 120f);
				this.corpse.transform.SetScaleX(this.corpse.transform.localScale.x * (this.corpseFacesRight ? 1f : -1f) * Mathf.Sign(base.transform.localScale.x));
				break;
			case 3:
				num2 = 270f;
				break;
			default:
				num2 = 90f;
				break;
			}
			component4.velocity = new Vector2(Mathf.Cos(num2 * 0.017453292f), Mathf.Sin(num2 * 0.017453292f)) * num * d;
		}
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x0002F950 File Offset: 0x0002DB50
	protected virtual void EmitEffects()
	{
		EnemyDeathTypes enemyDeathTypes = this.enemyDeathType;
		if (enemyDeathTypes == EnemyDeathTypes.Infected)
		{
			this.EmitInfectedEffects();
			return;
		}
		if (enemyDeathTypes == EnemyDeathTypes.SmallInfected)
		{
			this.EmitSmallInfectedEffects();
			return;
		}
		if (enemyDeathTypes != EnemyDeathTypes.LargeInfected)
		{
			Debug.LogWarningFormat(this, "Enemy death type {0} not implemented!", new object[]
			{
				this.enemyDeathType
			});
			return;
		}
		this.EmitLargeInfectedEffects();
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x0002F9A5 File Offset: 0x0002DBA5
	public void EmitSound()
	{
		this.enemyDeathSwordAudio.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		this.enemyDamageAudio.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0002F9E0 File Offset: 0x0002DBE0
	private void EmitInfectedEffects()
	{
		this.EmitSound();
		if (this.corpse != null)
		{
			SpriteFlash component = this.corpse.GetComponent<SpriteFlash>();
			if (component != null)
			{
				component.flashInfected();
			}
		}
		GameObject gameObject = this.deathWaveInfectedPrefab.Spawn(base.transform.position + this.effectOrigin);
		gameObject.transform.SetScaleX(1.25f);
		gameObject.transform.SetScaleY(1.25f);
		GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 8, 10, 15f, 20f, 0f, 360f, null);
		this.deathPuffMedPrefab.Spawn(base.transform.position + this.effectOrigin);
		this.ShakeCameraIfVisible("EnemyKillShake");
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002FACC File Offset: 0x0002DCCC
	private void EmitSmallInfectedEffects()
	{
		AudioEvent audioEvent = default(AudioEvent);
		audioEvent.Clip = this.enemyDeathSwordClip;
		audioEvent.PitchMin = 1.2f;
		audioEvent.PitchMax = 1.4f;
		audioEvent.Volume = 1f;
		audioEvent.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		audioEvent = default(AudioEvent);
		audioEvent.Clip = this.enemyDamageClip;
		audioEvent.PitchMin = 1.2f;
		audioEvent.PitchMax = 1.4f;
		audioEvent.Volume = 1f;
		audioEvent.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.deathWaveInfectedSmallPrefab != null)
		{
			GameObject gameObject = this.deathWaveInfectedSmallPrefab.Spawn(base.transform.position + this.effectOrigin);
			Vector3 localScale = gameObject.transform.localScale;
			localScale.x = 0.5f;
			localScale.y = 0.5f;
			gameObject.transform.localScale = localScale;
		}
		GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 8, 10, 15f, 20f, 0f, 360f, null);
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0002FC1C File Offset: 0x0002DE1C
	private void EmitLargeInfectedEffects()
	{
		AudioEvent audioEvent = default(AudioEvent);
		audioEvent.Clip = this.enemyDeathSwordClip;
		audioEvent.PitchMin = 0.75f;
		audioEvent.PitchMax = 0.75f;
		audioEvent.Volume = 1f;
		audioEvent.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		audioEvent = default(AudioEvent);
		audioEvent.Clip = this.enemyDamageClip;
		audioEvent.PitchMin = 0.75f;
		audioEvent.PitchMax = 0.75f;
		audioEvent.Volume = 1f;
		audioEvent.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		if (this.corpse != null)
		{
			SpriteFlash component = this.corpse.GetComponent<SpriteFlash>();
			if (component != null)
			{
				component.flashInfected();
			}
		}
		if (!(this.deathPuffLargePrefab == null))
		{
			this.deathPuffLargePrefab.Spawn(base.transform.position + this.effectOrigin);
		}
		this.ShakeCameraIfVisible("AverageShake");
		if (!(this.deathWaveInfectedPrefab == null))
		{
			GameObject gameObject = this.deathWaveInfectedPrefab.Spawn(base.transform.position + this.effectOrigin);
			gameObject.transform.SetScaleX(2f);
			gameObject.transform.SetScaleY(2f);
		}
		GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position + this.effectOrigin, 75, 80, 20f, 25f, 0f, 360f, null);
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
	protected void ShakeCameraIfVisible(string eventName)
	{
		Renderer renderer = base.GetComponent<Renderer>();
		if (renderer == null)
		{
			renderer = base.GetComponentInChildren<Renderer>();
		}
		if (renderer != null && renderer.isVisible)
		{
			GameCameras.instance.cameraShakeFSM.SendEvent(eventName);
		}
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0002FE08 File Offset: 0x0002E008
	private void EmitEssence()
	{
		PlayerData playerData = GameManager.instance.playerData;
		if (!playerData.GetBool("hasDreamNail"))
		{
			return;
		}
		bool @bool = playerData.GetBool("equippedCharm_30");
		bool flag = playerData.GetInt("dreamOrbsSpent") > 0;
		int maxExclusive;
		if (@bool && flag)
		{
			maxExclusive = 40;
		}
		else if (@bool && !flag)
		{
			maxExclusive = 200;
		}
		else if (playerData.GetInt("dreamOrbsSpent") <= 0)
		{
			maxExclusive = 300;
		}
		else
		{
			maxExclusive = 60;
		}
		if (UnityEngine.Random.Range(0, maxExclusive) == 0)
		{
			this.dreamEssenceCorpseGetPrefab.Spawn(base.transform.position + this.effectOrigin);
			PlayerData playerData2 = playerData;
			playerData2.SetIntSwappedArgs(playerData2.GetInt("dreamOrbs") + 1, "dreamOrbs");
			PlayerData playerData3 = playerData;
			playerData3.SetIntSwappedArgs(playerData3.GetInt("dreamOrbsSpent") - 1, "dreamOrbsSpent");
			EventRegister.SendEvent("DREAM ORB COLLECT");
		}
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x0002FEDF File Offset: 0x0002E0DF
	public EnemyDeathEffects()
	{
		this.doKillFreeze = true;
		base..ctor();
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
	public void orig_RecieveDeathEvent(float? attackDirection, bool resetDeathEvent = false, bool spellBurn = false, bool isWatery = false)
	{
		if (this.didFire)
		{
			return;
		}
		this.didFire = true;
		this.RecordKillForJournal();
		if (this.corpse != null)
		{
			this.EmitCorpse(attackDirection, isWatery, spellBurn);
		}
		if (!isWatery)
		{
			this.EmitEffects();
		}
		if (this.doKillFreeze)
		{
			GameManager.instance.FreezeMoment(1);
		}
		if ((this.enemyDeathType == EnemyDeathTypes.Infected || this.enemyDeathType == EnemyDeathTypes.LargeInfected || this.enemyDeathType == EnemyDeathTypes.SmallInfected || this.enemyDeathType == EnemyDeathTypes.Uninfected) && !BossSceneController.IsBossScene)
		{
			this.EmitEssence();
		}
		if (this.audioSnapshotOnDeath != null)
		{
			this.audioSnapshotOnDeath.TransitionTo(2f);
		}
		if (!string.IsNullOrEmpty(this.deathBroadcastEvent))
		{
			Debug.LogWarningFormat(this, "Death broadcast event '{0}' not implemented!", new object[]
			{
				this.deathBroadcastEvent
			});
		}
		if (resetDeathEvent)
		{
			FSMUtility.SendEventToGameObject(base.gameObject, "CENTIPEDE DEATH", false);
			this.didFire = false;
			return;
		}
		PersistentBoolItem component = base.GetComponent<PersistentBoolItem>();
		if (component)
		{
			component.SaveState();
		}
		if (this.recycle)
		{
			PlayMakerFSM playMakerFSM = FSMUtility.LocateFSM(base.gameObject, "health_manager_enemy");
			if (playMakerFSM != null)
			{
				playMakerFSM.FsmVariables.GetFsmBool("Activated").Value = false;
			}
			HealthManager component2 = base.GetComponent<HealthManager>();
			if (component2 != null)
			{
				component2.SetIsDead(false);
			}
			this.didFire = false;
			base.gameObject.Recycle();
			return;
		}
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x00030060 File Offset: 0x0002E260
	private void orig_RecordKillForJournal()
	{
		PlayerData playerData = GameManager.instance.playerData;
		string boolName = "killed" + this.playerDataName;
		string intName = "kills" + this.playerDataName;
		string boolName2 = "newData" + this.playerDataName;
		bool flag = false;
		if (!playerData.GetBool(boolName))
		{
			flag = true;
			playerData.SetBool(boolName, true);
			playerData.SetBool(boolName2, true);
		}
		bool flag2 = false;
		int num = playerData.GetInt(intName);
		if (num > 0)
		{
			num--;
			playerData.SetInt(intName, num);
			if (num <= 0)
			{
				flag2 = true;
			}
		}
		if (playerData.GetBool("hasJournal"))
		{
			bool flag3 = false;
			if (flag2)
			{
				flag3 = true;
				PlayerData playerData2 = playerData;
				playerData2.SetIntSwappedArgs(playerData2.GetInt("journalEntriesCompleted") + 1, "journalEntriesCompleted");
			}
			else if (flag)
			{
				flag3 = true;
				PlayerData playerData3 = playerData;
				playerData3.SetIntSwappedArgs(playerData3.GetInt("journalNotesCompleted") + 1, "journalNotesCompleted");
			}
			if (flag3)
			{
				if (EnemyDeathEffects.journalUpdateMessageSpawned)
				{
					if (EnemyDeathEffects.journalUpdateMessageSpawned.activeSelf)
					{
						EnemyDeathEffects.journalUpdateMessageSpawned.SetActive(false);
					}
					EnemyDeathEffects.journalUpdateMessageSpawned.SetActive(true);
					PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(EnemyDeathEffects.journalUpdateMessageSpawned, "Journal Msg");
					if (playMakerFSM)
					{
						FSMUtility.SetBool(playMakerFSM, "Full", flag2);
						FSMUtility.SetBool(playMakerFSM, "Should Recycle", true);
						return;
					}
				}
				else
				{
					Debug.LogWarning("Previously spawned Journal Update Msg has been destroyed!", this);
				}
			}
		}
	}

	// Token: 0x04000998 RID: 2456
	[SerializeField]
	private GameObject corpsePrefab;

	// Token: 0x04000999 RID: 2457
	[SerializeField]
	private bool corpseFacesRight;

	// Token: 0x0400099A RID: 2458
	[SerializeField]
	private float corpseFlingSpeed;

	// Token: 0x0400099B RID: 2459
	[SerializeField]
	public Vector3 corpseSpawnPoint;

	// Token: 0x0400099C RID: 2460
	[SerializeField]
	private string deathBroadcastEvent;

	// Token: 0x0400099D RID: 2461
	[SerializeField]
	public Vector3 effectOrigin;

	// Token: 0x0400099E RID: 2462
	[SerializeField]
	private bool lowCorpseArc;

	// Token: 0x0400099F RID: 2463
	[SerializeField]
	private string playerDataName;

	// Token: 0x040009A0 RID: 2464
	[SerializeField]
	private bool recycle;

	// Token: 0x040009A1 RID: 2465
	[SerializeField]
	private bool rotateCorpse;

	// Token: 0x040009A2 RID: 2466
	[SerializeField]
	private AudioMixerSnapshot audioSnapshotOnDeath;

	// Token: 0x040009A3 RID: 2467
	[SerializeField]
	private GameObject journalUpdateMessagePrefab;

	// Token: 0x040009A4 RID: 2468
	private static GameObject journalUpdateMessageSpawned;

	// Token: 0x040009A5 RID: 2469
	[SerializeField]
	private EnemyDeathTypes enemyDeathType;

	// Token: 0x040009A6 RID: 2470
	[SerializeField]
	protected AudioSource audioPlayerPrefab;

	// Token: 0x040009A7 RID: 2471
	[SerializeField]
	protected AudioEvent enemyDeathSwordAudio;

	// Token: 0x040009A8 RID: 2472
	[SerializeField]
	protected AudioEvent enemyDamageAudio;

	// Token: 0x040009A9 RID: 2473
	[SerializeField]
	protected AudioClip enemyDeathSwordClip;

	// Token: 0x040009AA RID: 2474
	[SerializeField]
	protected AudioClip enemyDamageClip;

	// Token: 0x040009AB RID: 2475
	[SerializeField]
	protected GameObject deathWaveInfectedPrefab;

	// Token: 0x040009AC RID: 2476
	[SerializeField]
	protected GameObject deathWaveInfectedSmallPrefab;

	// Token: 0x040009AD RID: 2477
	[SerializeField]
	protected GameObject spatterOrangePrefab;

	// Token: 0x040009AE RID: 2478
	[SerializeField]
	protected GameObject deathPuffMedPrefab;

	// Token: 0x040009AF RID: 2479
	[SerializeField]
	protected GameObject deathPuffLargePrefab;

	// Token: 0x040009B0 RID: 2480
	[SerializeField]
	protected GameObject dreamEssenceCorpseGetPrefab;

	// Token: 0x040009B1 RID: 2481
	protected GameObject corpse;

	// Token: 0x040009B2 RID: 2482
	private bool didFire;

	// Token: 0x040009B3 RID: 2483
	[HideInInspector]
	public bool doKillFreeze;
}
