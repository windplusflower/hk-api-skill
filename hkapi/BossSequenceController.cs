using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

// Token: 0x02000237 RID: 567
public static class BossSequenceController
{
	// Token: 0x1700013D RID: 317
	// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0003E181 File Offset: 0x0003C381
	public static bool BoundNail
	{
		get
		{
			return BossSequenceController.currentData != null && (BossSequenceController.currentData.bindings & BossSequenceController.ChallengeBindings.Nail) == BossSequenceController.ChallengeBindings.Nail;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003E19B File Offset: 0x0003C39B
	public static bool BoundShell
	{
		get
		{
			return BossSequenceController.currentData != null && (BossSequenceController.currentData.bindings & BossSequenceController.ChallengeBindings.Shell) == BossSequenceController.ChallengeBindings.Shell;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003E1B5 File Offset: 0x0003C3B5
	public static bool BoundCharms
	{
		get
		{
			return BossSequenceController.currentData != null && (BossSequenceController.currentData.bindings & BossSequenceController.ChallengeBindings.Charms) == BossSequenceController.ChallengeBindings.Charms;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0003E1CF File Offset: 0x0003C3CF
	public static bool BoundSoul
	{
		get
		{
			return BossSequenceController.currentData != null && (BossSequenceController.currentData.bindings & BossSequenceController.ChallengeBindings.Soul) == BossSequenceController.ChallengeBindings.Soul;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0003E1E9 File Offset: 0x0003C3E9
	// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0003E1FE File Offset: 0x0003C3FE
	public static bool KnightDamaged
	{
		get
		{
			return BossSequenceController.currentData != null && BossSequenceController.currentData.knightDamaged;
		}
		set
		{
			if (BossSequenceController.currentData != null)
			{
				BossSequenceController.currentData.knightDamaged = value;
			}
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0003E212 File Offset: 0x0003C412
	public static BossSequenceDoor.Completion PreviousCompletion
	{
		get
		{
			return BossSequenceController.currentData.previousCompletion;
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003E21E File Offset: 0x0003C41E
	// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0003E237 File Offset: 0x0003C437
	public static float Timer
	{
		get
		{
			if (BossSequenceController.currentData == null)
			{
				return 0f;
			}
			return BossSequenceController.currentData.timer;
		}
		set
		{
			if (BossSequenceController.currentData != null)
			{
				BossSequenceController.currentData.timer = value;
			}
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0003E24B File Offset: 0x0003C44B
	// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0003E252 File Offset: 0x0003C452
	public static bool WasCompleted { get; private set; }

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003E25A File Offset: 0x0003C45A
	public static bool IsInSequence
	{
		get
		{
			return BossSequenceController.currentData != null && BossSequenceController.currentSequence != null;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0003E270 File Offset: 0x0003C470
	public static bool IsLastBossScene
	{
		get
		{
			return BossSequenceController.bossIndex >= BossSequenceController.currentSequence.Count - 1;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0003E288 File Offset: 0x0003C488
	public static int BossIndex
	{
		get
		{
			return BossSequenceController.bossIndex;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0003E28F File Offset: 0x0003C48F
	public static int BossCount
	{
		get
		{
			if (!BossSequenceController.currentSequence)
			{
				return 0;
			}
			return BossSequenceController.currentSequence.Count;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0003E2AC File Offset: 0x0003C4AC
	public static bool ShouldUnlockGGMode
	{
		get
		{
			if (GameManager.instance.GetStatusRecordInt("RecBossRushMode") <= 0)
			{
				int num = 0;
				foreach (FieldInfo fieldInfo in typeof(PlayerData).GetFields())
				{
					if (fieldInfo.FieldType == typeof(BossSequenceDoor.Completion) && ((BossSequenceDoor.Completion)fieldInfo.GetValue(GameManager.instance.playerData)).completed)
					{
						num++;
					}
				}
				return num >= 3;
			}
			return false;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0003E330 File Offset: 0x0003C530
	public static int BoundMaxHealth
	{
		get
		{
			int num = (GameManager.instance.playerData.GetBool("equippedCharm_23") && !GameManager.instance.playerData.GetBool("brokenCharm_23")) ? 2 : 0;
			return BossSequenceController.currentSequence.maxHealth + num;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003E37C File Offset: 0x0003C57C
	public static int BoundNailDamage
	{
		get
		{
			int @int = GameManager.instance.playerData.GetInt("nailDamage");
			if (@int <= BossSequenceController.currentSequence.nailDamage)
			{
				return Mathf.RoundToInt((float)@int * BossSequenceController.currentSequence.lowerNailDamagePercentage);
			}
			return BossSequenceController.currentSequence.nailDamage;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
	public static bool ForceAssetUnload
	{
		get
		{
			return BossSequenceController.currentSequence && BossSequenceController.bossIndex < BossSequenceController.currentSequence.Count && BossSequenceController.bossIndex >= 0 && BossSequenceController.currentSequence.GetBossScene(BossSequenceController.bossIndex).ForceAssetUnload;
		}
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0003E405 File Offset: 0x0003C605
	public static void Reset()
	{
		BossSequenceController.currentData = null;
		BossSequenceController.currentSequence = null;
		BossSequenceController.bossIndex = 0;
	}

	// Token: 0x06000C21 RID: 3105 RVA: 0x0003E41C File Offset: 0x0003C61C
	public static void SetupNewSequence(BossSequence sequence, BossSequenceController.ChallengeBindings bindings, string playerData)
	{
		BossSequenceController.currentSequence = sequence;
		StaticVariableList.SetValue<string>("currentBossDoorPD", playerData);
		BossSequenceController.bossIndex = 0;
		BossSequenceController.currentData = new BossSequenceController.BossSequenceData
		{
			bindings = bindings,
			timer = 0f,
			playerData = playerData,
			bossSequenceName = BossSequenceController.currentSequence.name,
			previousCompletion = GameManager.instance.GetPlayerDataVariable<BossSequenceDoor.Completion>(playerData)
		};
		BossSequenceController.WasCompleted = false;
		GameManager.instance.playerData.SetVariableSwappedArgs<BossSequenceController.BossSequenceData>(null, "currentBossSequence");
		BossSequenceController.SetupBossScene();
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x0003E4A4 File Offset: 0x0003C6A4
	public static void CheckLoadSequence(MonoBehaviour caller)
	{
		if (BossSequenceController.currentSequence == null)
		{
			BossSequenceController.LoadCurrentSequence(caller);
		}
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x0003E4BC File Offset: 0x0003C6BC
	private static void LoadCurrentSequence(MonoBehaviour caller)
	{
		BossSequenceController.currentData = GameManager.instance.playerData.GetVariable<BossSequenceController.BossSequenceData>("currentBossSequence");
		if (BossSequenceController.currentData == null || string.IsNullOrEmpty(BossSequenceController.currentData.bossSequenceName))
		{
			Debug.LogError("Cannot load existing boss sequence if there is none!");
			return;
		}
		BossSequenceController.currentSequence = Resources.Load<BossSequence>(Path.Combine("GG", BossSequenceController.currentData.bossSequenceName));
		if (BossSequenceController.currentSequence)
		{
			string name = BossSceneController.Instance.gameObject.scene.name;
			BossSequenceController.bossIndex = -1;
			for (int i = 0; i < BossSequenceController.currentSequence.Count; i++)
			{
				if (BossSequenceController.currentSequence.GetSceneAt(i) == name)
				{
					BossSequenceController.bossIndex = i;
					break;
				}
			}
			if (BossSequenceController.bossIndex < 0)
			{
				Debug.LogError(string.Format("Could not find current scene {0} in boss sequence {1}", name, BossSequenceController.currentSequence.name));
			}
			BossSequenceController.SetupBossScene();
			caller.StartCoroutine(BossSequenceController.ResetBindingDisplay());
			return;
		}
		Debug.LogError("Boss sequence couldn't be loaded by name!");
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
	public static void ApplyBindings()
	{
		if (BossSequenceController.BoundNail)
		{
			EventRegister.SendEvent("SHOW BOUND NAIL");
		}
		if (BossSequenceController.BoundCharms)
		{
			BossSequenceController.currentData.previousEquippedCharms = GameManager.instance.playerData.GetVariable<List<int>>("equippedCharms").ToArray();
			GameManager.instance.playerData.GetVariable<List<int>>("equippedCharms").Clear();
			BossSequenceController.currentData.wasOvercharmed = GameManager.instance.playerData.GetBool("overcharmed");
			GameManager.instance.playerData.SetBoolSwappedArgs(false, "overcharmed");
			BossSequenceController.SetCharmsEquipped(false);
			EventRegister.SendEvent("SHOW BOUND CHARMS");
		}
		HeroController.instance.CharmUpdate();
		PlayMakerFSM.BroadcastEvent("CHARM EQUIP CHECK");
		EventRegister.SendEvent("UPDATE BLUE HEALTH");
		PlayMakerFSM.BroadcastEvent("HUD IN");
		if (BossSequenceController.BoundSoul)
		{
			EventRegister.SendEvent("BIND VESSEL ORB");
		}
		GameManager.instance.playerData.ClearMP();
		GameManager.instance.soulOrb_fsm.SendEvent("MP LOSE");
		GameManager.instance.soulVessel_fsm.SendEvent("MP RESERVE DOWN");
		PlayMakerFSM.BroadcastEvent("CHARM INDICATOR CHECK");
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x0003E6E0 File Offset: 0x0003C8E0
	public static void RestoreBindings()
	{
		if (!GameManager.instance || !HeroController.instance)
		{
			return;
		}
		if (BossSequenceController.BoundCharms)
		{
			GameManager.instance.playerData.SetVariableSwappedArgs<List<int>>(new List<int>(BossSequenceController.currentData.previousEquippedCharms), "equippedCharms");
			BossSequenceController.SetCharmsEquipped(true);
			GameManager.instance.playerData.SetBoolSwappedArgs(BossSequenceController.currentData.wasOvercharmed, "overcharmed");
		}
		HeroController.instance.CharmUpdate();
		if (BossSequenceController.currentData != null)
		{
			BossSequenceController.currentData.bindings = BossSequenceController.ChallengeBindings.None;
		}
		GameManager.instance.playerData.ClearMP();
		GameManager.instance.playerData.MaxHealth();
		EventRegister.SendEvent("UPDATE BLUE HEALTH");
		EventRegister.SendEvent("HIDE BOUND NAIL");
		PlayMakerFSM.BroadcastEvent("CHARM EQUIP CHECK");
		EventRegister.SendEvent("HIDE BOUND CHARMS");
		GameManager.instance.soulOrb_fsm.SendEvent("MP LOSE");
		EventRegister.SendEvent("UNBIND VESSEL ORB");
		PlayMakerFSM.BroadcastEvent("CHARM INDICATOR CHECK");
		PlayMakerFSM.BroadcastEvent("HUD IN");
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
	private static IEnumerator ResetBindingDisplay()
	{
		while (!GameCameras.instance.hudCamera.gameObject.activeInHierarchy)
		{
			yield return null;
		}
		BossSequenceController.ApplyBindings();
		yield break;
	}

	// Token: 0x06000C27 RID: 3111 RVA: 0x0003E7F0 File Offset: 0x0003C9F0
	private static void SetupBossScene()
	{
		BossSceneController.SetupEventDelegate setupEvent = null;
		setupEvent = delegate(BossSceneController self)
		{
			self.DreamReturnEvent = "DREAM EXIT";
			bool flag = false;
			if (self.customExitPoint)
			{
				if (BossSequenceController.currentSequence.GetSceneAt(BossSequenceController.bossIndex - 1) != self.gameObject.scene.name)
				{
					BossSequenceController.IncrementBossIndex();
				}
				if (BossSequenceController.bossIndex >= BossSequenceController.currentSequence.Count)
				{
					Debug.LogError("The last Boss Scene in a sequence can not have a custom exit point!");
				}
				else
				{
					string sceneAt = BossSequenceController.currentSequence.GetSceneAt(BossSequenceController.bossIndex);
					string entryPoint = "door_dreamEnter";
					self.customExitPoint.targetScene = sceneAt;
					self.customExitPoint.entryPoint = entryPoint;
				}
				BossSceneController.SetupEvent = setupEvent;
			}
			if (BossSequenceController.bossIndex == 0)
			{
				self.ApplyBindings();
			}
			if (!flag)
			{
				self.OnBossSceneComplete += delegate()
				{
					BossSequenceController.FinishBossScene(self, setupEvent);
				};
			}
		};
		BossSceneController.SetupEvent = setupEvent;
	}

	// Token: 0x06000C28 RID: 3112 RVA: 0x0003E81A File Offset: 0x0003CA1A
	private static void IncrementBossIndex()
	{
		BossSequenceController.bossIndex++;
		if (BossSequenceController.bossIndex < BossSequenceController.currentSequence.Count && !BossSequenceController.currentSequence.CanLoad(BossSequenceController.bossIndex))
		{
			BossSequenceController.IncrementBossIndex();
		}
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x0003E850 File Offset: 0x0003CA50
	private static void FinishBossScene(BossSceneController self, BossSceneController.SetupEventDelegate setupEvent)
	{
		BossSequenceController.IncrementBossIndex();
		if (BossSequenceController.bossIndex >= BossSequenceController.currentSequence.Count)
		{
			BossSequenceController.FinishLastBossScene(self);
			return;
		}
		Debug.Log("Continuing boss sequence...");
		GameManager.instance.playerData.SetVariableSwappedArgs<BossSequenceController.BossSequenceData>(BossSequenceController.currentData, "currentBossSequence");
		PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(self.gameObject, "Dream Enter Next Scene");
		if (playMakerFSM)
		{
			playMakerFSM.FsmVariables.FindFsmString("To Scene").Value = BossSequenceController.currentSequence.GetSceneAt(BossSequenceController.bossIndex);
			playMakerFSM.FsmVariables.FindFsmString("Entry Door").Value = "door_dreamEnter";
			playMakerFSM.SendEvent("DREAM RETURN");
		}
		BossSceneController.SetupEvent = setupEvent;
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x0003E908 File Offset: 0x0003CB08
	private static void FinishLastBossScene(BossSceneController self)
	{
		BossSequenceController.WasCompleted = true;
		if (!string.IsNullOrEmpty(BossSequenceController.currentSequence.achievementKey))
		{
			GameManager.instance.QueueAchievement(BossSequenceController.currentSequence.achievementKey);
		}
		BossSequenceDoor.Completion previousCompletion = BossSequenceController.currentData.previousCompletion;
		previousCompletion.completed = true;
		if (BossSequenceController.BoundNail)
		{
			previousCompletion.boundNail = true;
		}
		if (BossSequenceController.BoundShell)
		{
			previousCompletion.boundShell = true;
		}
		if (BossSequenceController.BoundCharms)
		{
			previousCompletion.boundCharms = true;
		}
		if (BossSequenceController.BoundSoul)
		{
			previousCompletion.boundSoul = true;
		}
		if (BossSequenceController.BoundNail && BossSequenceController.BoundShell && BossSequenceController.BoundCharms && BossSequenceController.BoundSoul)
		{
			previousCompletion.allBindings = true;
		}
		if (!BossSequenceController.KnightDamaged)
		{
			previousCompletion.noHits = true;
		}
		GameManager.instance.SetPlayerDataVariable<BossSequenceDoor.Completion>(BossSequenceController.currentData.playerData, previousCompletion);
		HeroController.instance.MaxHealth();
		string value = "GG_End_Sequence";
		if (!string.IsNullOrEmpty(BossSequenceController.currentSequence.customEndScene))
		{
			if (string.IsNullOrEmpty(BossSequenceController.currentSequence.customEndScenePlayerData) || !GameManager.instance.GetPlayerDataBool(BossSequenceController.currentSequence.customEndScenePlayerData))
			{
				value = BossSequenceController.currentSequence.customEndScene;
			}
			if (!string.IsNullOrEmpty(BossSequenceController.currentSequence.customEndScenePlayerData))
			{
				GameManager.instance.SetPlayerDataBool(BossSequenceController.currentSequence.customEndScenePlayerData, true);
			}
		}
		StaticVariableList.SetValue<string>("ggEndScene", value);
		self.DoDreamReturn();
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x0003EA61 File Offset: 0x0003CC61
	public static bool CheckIfSequence(BossSequence sequence)
	{
		return BossSequenceController.currentSequence == sequence;
	}

	// Token: 0x06000C2C RID: 3116 RVA: 0x0003EA6E File Offset: 0x0003CC6E
	private static void SetMinValue(ref int variable, params int[] values)
	{
		variable = Mathf.Min(variable, Mathf.Min(values));
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x0003EA80 File Offset: 0x0003CC80
	private static void SetCharmsEquipped(bool value)
	{
		if (BossSequenceController.currentData != null)
		{
			foreach (int num in BossSequenceController.currentData.previousEquippedCharms)
			{
				GameManager.instance.SetPlayerDataBool("equippedCharm_" + num.ToString(), value);
			}
		}
	}

	// Token: 0x04000CEF RID: 3311
	private static BossSequenceController.BossSequenceData currentData;

	// Token: 0x04000CF0 RID: 3312
	private static BossSequence currentSequence;

	// Token: 0x04000CF1 RID: 3313
	private static int bossIndex;

	// Token: 0x02000238 RID: 568
	[Flags]
	public enum ChallengeBindings
	{
		// Token: 0x04000CF3 RID: 3315
		None = 0,
		// Token: 0x04000CF4 RID: 3316
		Nail = 1,
		// Token: 0x04000CF5 RID: 3317
		Shell = 2,
		// Token: 0x04000CF6 RID: 3318
		Charms = 4,
		// Token: 0x04000CF7 RID: 3319
		Soul = 8
	}

	// Token: 0x02000239 RID: 569
	[Serializable]
	public class BossSequenceData
	{
		// Token: 0x04000CF8 RID: 3320
		public BossSequenceController.ChallengeBindings bindings;

		// Token: 0x04000CF9 RID: 3321
		public float timer;

		// Token: 0x04000CFA RID: 3322
		public bool knightDamaged;

		// Token: 0x04000CFB RID: 3323
		public string playerData;

		// Token: 0x04000CFC RID: 3324
		public BossSequenceDoor.Completion previousCompletion;

		// Token: 0x04000CFD RID: 3325
		public int[] previousEquippedCharms;

		// Token: 0x04000CFE RID: 3326
		public bool wasOvercharmed;

		// Token: 0x04000CFF RID: 3327
		public string bossSequenceName;
	}
}
