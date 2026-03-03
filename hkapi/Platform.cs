using System;
using System.Text;
using Modding;
using UnityEngine;

// Token: 0x02000376 RID: 886
public abstract class Platform : MonoBehaviour
{
	// Token: 0x1400002E RID: 46
	// (add) Token: 0x06001428 RID: 5160 RVA: 0x00059E44 File Offset: 0x00058044
	// (remove) Token: 0x06001429 RID: 5161 RVA: 0x00059E78 File Offset: 0x00058078
	public static event Action PlatformBecameCurrent;

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x0600142A RID: 5162
	public abstract string DisplayName { get; }

	// Token: 0x0600142B RID: 5163 RVA: 0x00059EAB File Offset: 0x000580AB
	public virtual SystemLanguage GetSystemLanguage()
	{
		return Application.systemLanguage;
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x0600142C RID: 5164
	public abstract bool ShowLanguageSelect { get; }

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x0600142D RID: 5165 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool IsFileSystemProtected
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x0600142E RID: 5166 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool WillPreloadSaveFiles
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x0600142F RID: 5167 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool IsSaveStoreMounted
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void MountSaveStore()
	{
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x0004E56C File Offset: 0x0004C76C
	public static bool IsSaveSlotIndexValid(int slotIndex)
	{
		return true;
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x00059EB4 File Offset: 0x000580B4
	protected string GetSaveSlotFileName(int slotIndex, Platform.SaveSlotFileNameUsage usage)
	{
		string text = (slotIndex == 0) ? "user.dat" : string.Format("user{0}.dat", slotIndex);
		string saveFileName = ModHooks.GetSaveFileName(slotIndex);
		text = (string.IsNullOrEmpty(saveFileName) ? text : saveFileName);
		if (usage != Platform.SaveSlotFileNameUsage.Backup)
		{
			if (usage == Platform.SaveSlotFileNameUsage.BackupMarkedForDeletion)
			{
				text += ".del";
			}
		}
		else
		{
			text += ".bak";
		}
		return text;
	}

	// Token: 0x06001433 RID: 5171
	public abstract void IsSaveSlotInUse(int slotIndex, Action<bool> callback);

	// Token: 0x06001434 RID: 5172
	public abstract void ReadSaveSlot(int slotIndex, Action<byte[]> callback);

	// Token: 0x06001435 RID: 5173
	public abstract void EnsureSaveSlotSpace(int slotIndex, Action<bool> callback);

	// Token: 0x06001436 RID: 5174
	public abstract void WriteSaveSlot(int slotIndex, byte[] binary, Action<bool> callback);

	// Token: 0x06001437 RID: 5175
	public abstract void ClearSaveSlot(int slotIndex, Action<bool> callback);

	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x06001438 RID: 5176
	public abstract Platform.ISharedData SharedData { get; }

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x06001439 RID: 5177
	public abstract Platform.ISharedData EncryptedSharedData { get; }

	// Token: 0x0600143A RID: 5178 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void AdjustGameSettings(GameSettings gameSettings)
	{
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x0600143B RID: 5179 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool IsFiringAchievementsFromSavesAllowed
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600143C RID: 5180
	public abstract bool? IsAchievementUnlocked(string achievementId);

	// Token: 0x0600143D RID: 5181
	public abstract void PushAchievementUnlock(string achievementId);

	// Token: 0x0600143E RID: 5182
	public abstract void ResetAchievements();

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x0600143F RID: 5183
	public abstract bool AreAchievementsFetched { get; }

	// Token: 0x1400002F RID: 47
	// (add) Token: 0x06001440 RID: 5184 RVA: 0x00059F18 File Offset: 0x00058118
	// (remove) Token: 0x06001441 RID: 5185 RVA: 0x00059F4C File Offset: 0x0005814C
	public static event Platform.AchievementsFetchedDelegate AchievementsFetched;

	// Token: 0x06001442 RID: 5186 RVA: 0x00059F7F File Offset: 0x0005817F
	protected void OnAchievementsFetched()
	{
		if (Platform.AchievementsFetched != null)
		{
			Platform.AchievementsFetched();
		}
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06001443 RID: 5187 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool HasNativeAchievementsDialog
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06001444 RID: 5188 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void ShowNativeAchievementsDialog()
	{
	}

	// Token: 0x06001445 RID: 5189 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void SetSocialPresence(string socialStatusKey, bool isActive)
	{
	}

	// Token: 0x06001446 RID: 5190 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void AddSocialStat(string name, int amount)
	{
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void FlushSocialEvents()
	{
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06001448 RID: 5192 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool WillManageResolution
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06001449 RID: 5193 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool WillDisplayGraphicsSettings
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void AdjustGraphicsSettings(GameSettings gameSettings)
	{
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x0600144B RID: 5195 RVA: 0x00059F92 File Offset: 0x00058192
	protected virtual Platform.GraphicsTiers InitialGraphicsTier
	{
		get
		{
			return Platform.GraphicsTiers.High;
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x0600144C RID: 5196 RVA: 0x00059F95 File Offset: 0x00058195
	public Platform.GraphicsTiers GraphicsTier
	{
		get
		{
			return this.graphicsTier;
		}
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x00059F9D File Offset: 0x0005819D
	protected void ChangeGraphicsTier(Platform.GraphicsTiers graphicsTier, bool isForced)
	{
		if (this.graphicsTier != graphicsTier || isForced)
		{
			this.graphicsTier = graphicsTier;
			Debug.LogFormat(this, "Graphics tier changed to {0}", new object[]
			{
				graphicsTier
			});
			this.OnGraphicsTierChanged(graphicsTier);
		}
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00059FD7 File Offset: 0x000581D7
	protected virtual void OnGraphicsTierChanged(Platform.GraphicsTiers graphicsTier)
	{
		Shader.globalMaximumLOD = Platform.GetMaximumShaderLOD(graphicsTier);
		if (Platform.GraphicsTierChanged != null)
		{
			Platform.GraphicsTierChanged(graphicsTier);
		}
	}

	// Token: 0x14000030 RID: 48
	// (add) Token: 0x0600144F RID: 5199 RVA: 0x00059FF8 File Offset: 0x000581F8
	// (remove) Token: 0x06001450 RID: 5200 RVA: 0x0005A02C File Offset: 0x0005822C
	public static event Platform.GraphicsTierChangedDelegate GraphicsTierChanged;

	// Token: 0x06001451 RID: 5201 RVA: 0x0005A05F File Offset: 0x0005825F
	public static int GetMaximumShaderLOD(Platform.GraphicsTiers graphicsTier)
	{
		switch (graphicsTier)
		{
		case Platform.GraphicsTiers.VeryLow:
			return 700;
		case Platform.GraphicsTiers.Low:
			return 800;
		case Platform.GraphicsTiers.Medium:
			return 900;
		case Platform.GraphicsTiers.High:
			return 1000;
		default:
			return int.MaxValue;
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06001452 RID: 5202 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool IsSpriteScalingApplied
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x06001453 RID: 5203 RVA: 0x0005A096 File Offset: 0x00058296
	public virtual float SpriteScalingFactor
	{
		get
		{
			return 1f;
		}
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06001454 RID: 5204 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool WillDisplayControllerSettings
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002B0 RID: 688
	// (get) Token: 0x06001455 RID: 5205 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool WillDisplayKeyboardSettings
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002B1 RID: 689
	// (get) Token: 0x06001456 RID: 5206 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool WillDisplayQuitButton
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x06001457 RID: 5207 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool IsControllerImplicit
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x06001458 RID: 5208 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool IsMouseSupported
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002B4 RID: 692
	// (get) Token: 0x06001459 RID: 5209 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool WillEverPauseOnControllerDisconnected
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x0600145A RID: 5210 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool IsPausingOnControllerDisconnected
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x0600145B RID: 5211
	public abstract Platform.AcceptRejectInputStyles AcceptRejectInputStyle { get; }

	// Token: 0x14000031 RID: 49
	// (add) Token: 0x0600145C RID: 5212 RVA: 0x0005A0A0 File Offset: 0x000582A0
	// (remove) Token: 0x0600145D RID: 5213 RVA: 0x0005A0D4 File Offset: 0x000582D4
	public static event Platform.AcceptRejectInputStyleChangedDelegate AcceptRejectInputStyleChanged;

	// Token: 0x0600145E RID: 5214 RVA: 0x0005A108 File Offset: 0x00058308
	public Platform.MenuActions GetMenuAction(bool menuSubmitInput, bool menuCancelInput, bool jumpInput, bool attackInput, bool castInput)
	{
		bool isControllerImplicit = this.IsControllerImplicit;
		if (isControllerImplicit)
		{
			if (menuSubmitInput)
			{
				return Platform.MenuActions.Submit;
			}
			if (menuCancelInput)
			{
				return Platform.MenuActions.Cancel;
			}
		}
		Platform.AcceptRejectInputStyles acceptRejectInputStyle = this.AcceptRejectInputStyle;
		if (acceptRejectInputStyle != Platform.AcceptRejectInputStyles.NonJapaneseStyle)
		{
			if (acceptRejectInputStyle == Platform.AcceptRejectInputStyles.JapaneseStyle)
			{
				if (castInput)
				{
					return Platform.MenuActions.Submit;
				}
				if (jumpInput || attackInput)
				{
					return Platform.MenuActions.Cancel;
				}
			}
		}
		else
		{
			if (jumpInput)
			{
				return Platform.MenuActions.Submit;
			}
			if (attackInput || castInput)
			{
				return Platform.MenuActions.Cancel;
			}
		}
		if (!isControllerImplicit)
		{
			if (menuSubmitInput)
			{
				return Platform.MenuActions.Submit;
			}
			if (menuCancelInput)
			{
				return Platform.MenuActions.Cancel;
			}
		}
		return Platform.MenuActions.None;
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x0600145F RID: 5215 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool FetchScenesBeforeFade
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x06001460 RID: 5216 RVA: 0x0000D576 File Offset: 0x0000B776
	public virtual float MaximumLoadDurationForNonCriticalGarbageCollection
	{
		get
		{
			return 0f;
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06001461 RID: 5217 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual int MaximumSceneTransitionsWithoutNonCriticalGarbageCollection
	{
		get
		{
			return 0;
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06001462 RID: 5218 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual Platform.EngagementRequirements EngagementRequirement
	{
		get
		{
			return Platform.EngagementRequirements.Invisible;
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x06001463 RID: 5219 RVA: 0x00058FB1 File Offset: 0x000571B1
	public virtual Platform.EngagementStates EngagementState
	{
		get
		{
			return Platform.EngagementStates.Engaged;
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06001464 RID: 5220 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool IsSavingAllowedByEngagement
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001465 RID: 5221 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void ClearEngagement()
	{
	}

	// Token: 0x06001466 RID: 5222 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void UpdateWaitingForEngagement()
	{
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06001467 RID: 5223 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool CanReEngage
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x06001468 RID: 5224 RVA: 0x000086D3 File Offset: 0x000068D3
	public virtual string EngagedDisplayName
	{
		get
		{
			return null;
		}
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x06001469 RID: 5225 RVA: 0x000086D3 File Offset: 0x000068D3
	public virtual Texture2D EngagedDisplayImage
	{
		get
		{
			return null;
		}
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x0600146A RID: 5226 RVA: 0x0005A163 File Offset: 0x00058363
	public Platform.IDisengageHandler DisengageHandler
	{
		get
		{
			return this.disengageHandler;
		}
	}

	// Token: 0x0600146B RID: 5227 RVA: 0x0005A16B File Offset: 0x0005836B
	public virtual void SetDisengageHandler(Platform.IDisengageHandler disengageHandler)
	{
		this.disengageHandler = disengageHandler;
	}

	// Token: 0x14000032 RID: 50
	// (add) Token: 0x0600146C RID: 5228 RVA: 0x0005A174 File Offset: 0x00058374
	// (remove) Token: 0x0600146D RID: 5229 RVA: 0x0005A1AC File Offset: 0x000583AC
	public event Platform.OnEngagedDisplayInfoChanged EngagedDisplayInfoChanged;

	// Token: 0x0600146E RID: 5230 RVA: 0x0005A1E1 File Offset: 0x000583E1
	public void NotifyEngagedDisplayInfoChanged()
	{
		if (this.EngagedDisplayInfoChanged != null)
		{
			this.EngagedDisplayInfoChanged();
		}
	}

	// Token: 0x170002C1 RID: 705
	// (get) Token: 0x0600146F RID: 5231 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool IsPlayerPrefsLoaded
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170002C2 RID: 706
	// (get) Token: 0x06001470 RID: 5232 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool RequiresPreferencesSyncOnEngage
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x06001471 RID: 5233 RVA: 0x0005A1F6 File Offset: 0x000583F6
	public static Platform Current
	{
		get
		{
			return Platform.current;
		}
	}

	// Token: 0x06001472 RID: 5234 RVA: 0x0005A1FD File Offset: 0x000583FD
	protected virtual void Awake()
	{
		this.ChangeGraphicsTier(this.InitialGraphicsTier, true);
	}

	// Token: 0x06001473 RID: 5235 RVA: 0x00003603 File Offset: 0x00001803
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00003603 File Offset: 0x00001803
	protected virtual void Update()
	{
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x0005A20C File Offset: 0x0005840C
	protected virtual void BecomeCurrent()
	{
		Platform.current = this;
		if (Platform.PlatformBecameCurrent != null)
		{
			Platform.PlatformBecameCurrent();
		}
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x0005A225 File Offset: 0x00058425
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void Init()
	{
		Platform.CreatePlatform().BecomeCurrent();
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x0005A231 File Offset: 0x00058431
	private static Platform CreatePlatform()
	{
		return Platform.CreatePlatform<DesktopPlatform>();
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x0005A238 File Offset: 0x00058438
	private static Platform CreatePlatform<PlatformTy>() where PlatformTy : Platform
	{
		GameObject gameObject = new GameObject(typeof(PlatformTy).Name);
		PlatformTy platformTy = gameObject.AddComponent<PlatformTy>();
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return platformTy;
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x06001479 RID: 5241 RVA: 0x0000D742 File Offset: 0x0000B942
	protected static bool IsPlatformSimulationEnabled
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x0005A26B File Offset: 0x0005846B
	// Note: this type is marked as 'beforefieldinit'.
	static Platform()
	{
		Platform.HollowKnightAESKeyBytes = Encoding.UTF8.GetBytes("UKu52ePUBwetZ9wNX88o54dnfKRu0T1l");
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x0005A281 File Offset: 0x00058481
	public static bool orig_IsSaveSlotIndexValid(int slotIndex)
	{
		return slotIndex >= 0 && slotIndex < 5;
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x0005A290 File Offset: 0x00058490
	protected string orig_GetSaveSlotFileName(int slotIndex, Platform.SaveSlotFileNameUsage usage)
	{
		string text;
		if (slotIndex == 0)
		{
			text = "user.dat";
		}
		else
		{
			text = string.Format("user{0}.dat", slotIndex);
		}
		if (usage != Platform.SaveSlotFileNameUsage.Backup)
		{
			if (usage == Platform.SaveSlotFileNameUsage.BackupMarkedForDeletion)
			{
				text += ".del";
			}
		}
		else
		{
			text += ".bak";
		}
		return text;
	}

	// Token: 0x040012EF RID: 4847
	protected static readonly byte[] HollowKnightAESKeyBytes;

	// Token: 0x040012F0 RID: 4848
	public const int SaveSlotCount = 5;

	// Token: 0x040012F1 RID: 4849
	protected const string FirstSaveFileName = "user.dat";

	// Token: 0x040012F2 RID: 4850
	protected const string NonFirstSaveFileNameFormat = "user{0}.dat";

	// Token: 0x040012F3 RID: 4851
	protected const string BackupSuffix = ".bak";

	// Token: 0x040012F4 RID: 4852
	protected const string BackupMarkedForDeletionSuffix = ".del";

	// Token: 0x040012F6 RID: 4854
	private Platform.GraphicsTiers graphicsTier;

	// Token: 0x040012F9 RID: 4857
	private Platform.IDisengageHandler disengageHandler;

	// Token: 0x040012FB RID: 4859
	private static Platform current;

	// Token: 0x02000377 RID: 887
	protected enum SaveSlotFileNameUsage
	{
		// Token: 0x040012FD RID: 4861
		Primary,
		// Token: 0x040012FE RID: 4862
		Backup,
		// Token: 0x040012FF RID: 4863
		BackupMarkedForDeletion
	}

	// Token: 0x02000378 RID: 888
	public interface ISharedData
	{
		// Token: 0x0600147E RID: 5246
		bool HasKey(string key);

		// Token: 0x0600147F RID: 5247
		void DeleteKey(string key);

		// Token: 0x06001480 RID: 5248
		void DeleteAll();

		// Token: 0x06001481 RID: 5249
		bool GetBool(string key, bool def);

		// Token: 0x06001482 RID: 5250
		void SetBool(string key, bool val);

		// Token: 0x06001483 RID: 5251
		int GetInt(string key, int def);

		// Token: 0x06001484 RID: 5252
		void SetInt(string key, int val);

		// Token: 0x06001485 RID: 5253
		float GetFloat(string key, float def);

		// Token: 0x06001486 RID: 5254
		void SetFloat(string key, float val);

		// Token: 0x06001487 RID: 5255
		string GetString(string key, string def);

		// Token: 0x06001488 RID: 5256
		void SetString(string key, string val);

		// Token: 0x06001489 RID: 5257
		void Save();
	}

	// Token: 0x02000379 RID: 889
	// (Invoke) Token: 0x0600148B RID: 5259
	public delegate void AchievementsFetchedDelegate();

	// Token: 0x0200037A RID: 890
	public enum GraphicsTiers
	{
		// Token: 0x04001301 RID: 4865
		VeryLow,
		// Token: 0x04001302 RID: 4866
		Low,
		// Token: 0x04001303 RID: 4867
		Medium,
		// Token: 0x04001304 RID: 4868
		High
	}

	// Token: 0x0200037B RID: 891
	// (Invoke) Token: 0x0600148F RID: 5263
	public delegate void GraphicsTierChangedDelegate(Platform.GraphicsTiers graphicsTier);

	// Token: 0x0200037C RID: 892
	public enum AcceptRejectInputStyles
	{
		// Token: 0x04001306 RID: 4870
		NonJapaneseStyle,
		// Token: 0x04001307 RID: 4871
		JapaneseStyle
	}

	// Token: 0x0200037D RID: 893
	// (Invoke) Token: 0x06001493 RID: 5267
	public delegate void AcceptRejectInputStyleChangedDelegate();

	// Token: 0x0200037E RID: 894
	public enum MenuActions
	{
		// Token: 0x04001309 RID: 4873
		None,
		// Token: 0x0400130A RID: 4874
		Submit,
		// Token: 0x0400130B RID: 4875
		Cancel
	}

	// Token: 0x0200037F RID: 895
	public enum EngagementRequirements
	{
		// Token: 0x0400130D RID: 4877
		Invisible,
		// Token: 0x0400130E RID: 4878
		MustDisplay
	}

	// Token: 0x02000380 RID: 896
	public enum EngagementStates
	{
		// Token: 0x04001310 RID: 4880
		NotEngaged,
		// Token: 0x04001311 RID: 4881
		EngagePending,
		// Token: 0x04001312 RID: 4882
		Engaged
	}

	// Token: 0x02000381 RID: 897
	public interface IDisengageHandler
	{
		// Token: 0x06001496 RID: 5270
		void OnDisengage(Action next);
	}

	// Token: 0x02000382 RID: 898
	// (Invoke) Token: 0x06001498 RID: 5272
	public delegate void OnEngagedDisplayInfoChanged();
}
