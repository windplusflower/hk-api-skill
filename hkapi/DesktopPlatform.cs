using System;
using System.Collections.Generic;
using System.IO;
using InControl;
using UnityEngine;

// Token: 0x02000360 RID: 864
public class DesktopPlatform : Platform, VibrationManager.IVibrationMixerProvider
{
	// Token: 0x0600138F RID: 5007 RVA: 0x000587D4 File Offset: 0x000569D4
	protected override void Awake()
	{
		base.Awake();
		this.saveDirPath = Application.persistentDataPath;
		this.sharedData = new PlayerPrefsSharedData(null);
		this.encryptedSharedData = new PlayerPrefsSharedData(Platform.HollowKnightAESKeyBytes);
		this.CreateOnlineSubsystem();
		if (this.onlineSubsystem == null)
		{
			this.OnOnlineSubsystemAchievementsFetched();
		}
		this.vibrationHelper = new PlatformVibrationHelper();
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x00058830 File Offset: 0x00056A30
	private void CreateOnlineSubsystem()
	{
		List<DesktopPlatform.CreateOnlineSubsystemDelegate> list = new List<DesktopPlatform.CreateOnlineSubsystemDelegate>();
		if (SteamOnlineSubsystem.IsPackaged(this))
		{
			list.Add(() => new SteamOnlineSubsystem(this));
		}
		if (GOGGalaxyOnlineSubsystem.IsPackaged(this))
		{
			list.Add(() => new GOGGalaxyOnlineSubsystem(this));
		}
		if (GameCoreOnlineSubsystem.IsPackaged(this))
		{
			list.Add(() => new GameCoreOnlineSubsystem(this));
		}
		if (list.Count == 0)
		{
			Debug.LogFormat(this, "No online subsystems packaged.", Array.Empty<object>());
			return;
		}
		if (list.Count > 1)
		{
			Debug.LogErrorFormat(this, "Multiple online subsystems packaged.", Array.Empty<object>());
			Application.Quit();
			return;
		}
		this.onlineSubsystem = list[0]();
		Debug.LogFormat(this, "Selected online subsystem " + this.onlineSubsystem.GetType().Name, Array.Empty<object>());
		GOGGalaxyOnlineSubsystem goggalaxyOnlineSubsystem = this.onlineSubsystem as GOGGalaxyOnlineSubsystem;
		if (goggalaxyOnlineSubsystem != null && !goggalaxyOnlineSubsystem.DidInitialize)
		{
			this.onlineSubsystem = null;
			Debug.LogError("GOG was not initialised, will not be used as online subsystem.");
		}
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00058928 File Offset: 0x00056B28
	protected override void OnDestroy()
	{
		if (this.onlineSubsystem != null)
		{
			this.onlineSubsystem.Dispose();
			this.onlineSubsystem = null;
		}
		this.vibrationHelper.Destroy();
		base.OnDestroy();
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x00058955 File Offset: 0x00056B55
	protected override void Update()
	{
		base.Update();
		if (this.onlineSubsystem != null)
		{
			this.onlineSubsystem.Update();
		}
		this.vibrationHelper.UpdateVibration();
	}

	// Token: 0x17000276 RID: 630
	// (get) Token: 0x06001393 RID: 5011 RVA: 0x0005897B File Offset: 0x00056B7B
	public override string DisplayName
	{
		get
		{
			return "Desktop";
		}
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00058982 File Offset: 0x00056B82
	private string GetSaveSlotPath(int slotIndex, Platform.SaveSlotFileNameUsage usage)
	{
		return Path.Combine(this.saveDirPath, base.GetSaveSlotFileName(slotIndex, usage));
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x00058997 File Offset: 0x00056B97
	public override void IsSaveSlotInUse(int slotIndex, Action<bool> callback)
	{
		DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
		if (desktopOnlineSubsystem != null && desktopOnlineSubsystem.HandlesGameSaves)
		{
			this.onlineSubsystem.IsSaveSlotInUse(slotIndex, callback);
			return;
		}
		this.LocalIsSaveSlotInUse(slotIndex, callback);
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x000589C4 File Offset: 0x00056BC4
	public void LocalIsSaveSlotInUse(int slotIndex, Action<bool> callback)
	{
		string saveSlotPath = this.GetSaveSlotPath(slotIndex, Platform.SaveSlotFileNameUsage.Primary);
		bool inUse;
		try
		{
			inUse = File.Exists(saveSlotPath);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			inUse = false;
		}
		CoreLoop.InvokeNext(delegate
		{
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(inUse);
		});
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00058A24 File Offset: 0x00056C24
	public override void ReadSaveSlot(int slotIndex, Action<byte[]> callback)
	{
		DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
		if (desktopOnlineSubsystem != null && desktopOnlineSubsystem.HandlesGameSaves)
		{
			this.onlineSubsystem.ReadSaveSlot(slotIndex, callback);
			return;
		}
		this.LocalReadSaveSlot(slotIndex, callback);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00058A50 File Offset: 0x00056C50
	public void LocalReadSaveSlot(int slotIndex, Action<byte[]> callback)
	{
		string saveSlotPath = this.GetSaveSlotPath(slotIndex, Platform.SaveSlotFileNameUsage.Primary);
		byte[] bytes;
		try
		{
			bytes = File.ReadAllBytes(saveSlotPath);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			bytes = null;
		}
		CoreLoop.InvokeNext(delegate
		{
			Action<byte[]> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(bytes);
		});
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x00058AB0 File Offset: 0x00056CB0
	public override void EnsureSaveSlotSpace(int slotIndex, Action<bool> callback)
	{
		CoreLoop.InvokeNext(delegate
		{
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(true);
		});
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00058AD0 File Offset: 0x00056CD0
	public override void WriteSaveSlot(int slotIndex, byte[] bytes, Action<bool> callback)
	{
		DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
		if (desktopOnlineSubsystem != null && desktopOnlineSubsystem.HandlesGameSaves)
		{
			this.onlineSubsystem.WriteSaveSlot(slotIndex, bytes, callback);
			return;
		}
		string saveSlotPath = this.GetSaveSlotPath(slotIndex, Platform.SaveSlotFileNameUsage.Primary);
		string saveSlotPath2 = this.GetSaveSlotPath(slotIndex, Platform.SaveSlotFileNameUsage.Backup);
		string text = saveSlotPath + ".new";
		if (File.Exists(text))
		{
			Debug.LogWarning(string.Format("Temp file <b>{0}</b> was found and is likely corrupted. The file has been deleted.", text));
		}
		try
		{
			File.WriteAllBytes(text, bytes);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		try
		{
			File.WriteAllBytes(saveSlotPath.Replace(".dat", "") + "_1.5.78.11833.dat", bytes);
		}
		catch (Exception exception2)
		{
			Debug.LogException(exception2);
		}
		bool successful;
		try
		{
			if (File.Exists(saveSlotPath))
			{
				File.Replace(text, saveSlotPath, saveSlotPath2 + this.GetBackupNumber(saveSlotPath2).ToString());
			}
			else
			{
				File.Move(text, saveSlotPath);
			}
			successful = true;
		}
		catch (Exception exception3)
		{
			Debug.LogException(exception3);
			successful = false;
		}
		CoreLoop.InvokeNext(delegate
		{
			if (callback != null)
			{
				callback(successful);
			}
		});
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00058C04 File Offset: 0x00056E04
	private int GetBackupNumber(string backupPath)
	{
		int num = 0;
		int num2 = 3;
		string[] files = Directory.GetFiles(Path.GetDirectoryName(backupPath));
		List<string> list = new List<string>();
		foreach (string text in files)
		{
			if (text.StartsWith(backupPath))
			{
				list.Add(text);
			}
		}
		if (list.Count > 0)
		{
			int index = 0;
			int num3 = int.MaxValue;
			int num4 = 0;
			for (int j = list.Count - 1; j >= 0; j--)
			{
				string text2 = list[j].Replace(backupPath, "");
				if (text2 != "")
				{
					try
					{
						num = int.Parse(text2);
						if (num < num3)
						{
							num3 = num;
							index = j;
						}
						if (num > num4)
						{
							num4 = num;
						}
					}
					catch
					{
						Debug.LogWarning(string.Format("Backup file: {0} does not have a numerical extension, and will be ignored.", list[j]));
					}
				}
			}
			num = num4;
			if (list.Count >= num2)
			{
				File.Delete(list[index]);
			}
		}
		return num + 1;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x00058D08 File Offset: 0x00056F08
	public override void ClearSaveSlot(int slotIndex, Action<bool> callback)
	{
		DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
		if (desktopOnlineSubsystem != null && desktopOnlineSubsystem.HandlesGameSaves)
		{
			this.onlineSubsystem.ClearSaveSlot(slotIndex, callback);
			return;
		}
		string saveSlotPath = this.GetSaveSlotPath(slotIndex, Platform.SaveSlotFileNameUsage.Primary);
		bool successful;
		try
		{
			File.Delete(saveSlotPath);
			successful = true;
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			successful = false;
		}
		CoreLoop.InvokeNext(delegate
		{
			if (callback != null)
			{
				callback(successful);
			}
		});
	}

	// Token: 0x17000277 RID: 631
	// (get) Token: 0x0600139D RID: 5021 RVA: 0x00058D90 File Offset: 0x00056F90
	public override Platform.ISharedData SharedData
	{
		get
		{
			return this.sharedData;
		}
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x0600139E RID: 5022 RVA: 0x00058D98 File Offset: 0x00056F98
	public override Platform.ISharedData EncryptedSharedData
	{
		get
		{
			return this.encryptedSharedData;
		}
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00058DA0 File Offset: 0x00056FA0
	public override bool? IsAchievementUnlocked(string achievementId)
	{
		if (this.onlineSubsystem != null)
		{
			return this.onlineSubsystem.IsAchievementUnlocked(achievementId);
		}
		return new bool?(this.EncryptedSharedData.GetBool(achievementId, false));
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x00058DC9 File Offset: 0x00056FC9
	public override void PushAchievementUnlock(string achievementId)
	{
		if (this.onlineSubsystem != null)
		{
			this.onlineSubsystem.PushAchievementUnlock(achievementId);
		}
		this.EncryptedSharedData.SetBool(achievementId, true);
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x00058DEC File Offset: 0x00056FEC
	public override void ResetAchievements()
	{
		if (this.onlineSubsystem != null)
		{
			this.onlineSubsystem.ResetAchievements();
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00058E01 File Offset: 0x00057001
	public override bool AreAchievementsFetched
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			return desktopOnlineSubsystem == null || desktopOnlineSubsystem.AreAchievementsFetched;
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00058E14 File Offset: 0x00057014
	public override bool HasNativeAchievementsDialog
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			if (desktopOnlineSubsystem == null)
			{
				return base.HasNativeAchievementsDialog;
			}
			return desktopOnlineSubsystem.HasNativeAchievementsDialog;
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x060013A4 RID: 5028 RVA: 0x0000D742 File Offset: 0x0000B942
	public override Platform.AcceptRejectInputStyles AcceptRejectInputStyle
	{
		get
		{
			return Platform.AcceptRejectInputStyles.NonJapaneseStyle;
		}
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x00058E2C File Offset: 0x0005702C
	public bool IncludesPlugin(string pluginName)
	{
		string path = "Plugins";
		string path2 = Path.Combine(Path.Combine(Application.dataPath, path), pluginName);
		return File.Exists(path2) || Directory.Exists(path2);
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x00058E61 File Offset: 0x00057061
	public void OnOnlineSubsystemAchievementsFetched()
	{
		base.OnAchievementsFetched();
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0004E56C File Offset: 0x0004C76C
	public override bool ShowLanguageSelect
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00058E69 File Offset: 0x00057069
	public override bool IsControllerImplicit
	{
		get
		{
			return InputHandler.Instance && InputHandler.Instance.lastActiveController == BindingSourceType.DeviceBindingSource;
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00058E87 File Offset: 0x00057087
	public override bool WillPreloadSaveFiles
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			if (desktopOnlineSubsystem == null)
			{
				return base.WillPreloadSaveFiles;
			}
			return desktopOnlineSubsystem.WillPreloadSaveFiles;
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x060013AA RID: 5034 RVA: 0x00058E9F File Offset: 0x0005709F
	public override Platform.EngagementRequirements EngagementRequirement
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			if (desktopOnlineSubsystem == null)
			{
				return base.EngagementRequirement;
			}
			return desktopOnlineSubsystem.EngagementRequirement;
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060013AB RID: 5035 RVA: 0x00058EB7 File Offset: 0x000570B7
	public override Platform.EngagementStates EngagementState
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			if (desktopOnlineSubsystem == null)
			{
				return base.EngagementState;
			}
			return desktopOnlineSubsystem.EngagementState;
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060013AC RID: 5036 RVA: 0x00058ECF File Offset: 0x000570CF
	public override string EngagedDisplayName
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			return ((desktopOnlineSubsystem != null) ? desktopOnlineSubsystem.EngagedDisplayName : null) ?? base.EngagedDisplayName;
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x060013AD RID: 5037 RVA: 0x00058EED File Offset: 0x000570ED
	public override Texture2D EngagedDisplayImage
	{
		get
		{
			DesktopOnlineSubsystem desktopOnlineSubsystem = this.onlineSubsystem;
			return ((desktopOnlineSubsystem != null) ? desktopOnlineSubsystem.EngagedDisplayImage : null) ?? base.EngagedDisplayImage;
		}
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00058F0B File Offset: 0x0005710B
	public VibrationMixer GetVibrationMixer()
	{
		return this.vibrationHelper.GetMixer();
	}

	// Token: 0x040012AF RID: 4783
	private string saveDirPath;

	// Token: 0x040012B0 RID: 4784
	private PlayerPrefsSharedData sharedData;

	// Token: 0x040012B1 RID: 4785
	private PlayerPrefsSharedData encryptedSharedData;

	// Token: 0x040012B2 RID: 4786
	private DesktopOnlineSubsystem onlineSubsystem;

	// Token: 0x040012B3 RID: 4787
	private PlatformVibrationHelper vibrationHelper;

	// Token: 0x02000361 RID: 865
	// (Invoke) Token: 0x060013B4 RID: 5044
	private delegate DesktopOnlineSubsystem CreateOnlineSubsystemDelegate();
}
