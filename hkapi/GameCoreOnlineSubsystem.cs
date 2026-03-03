using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XGamingRuntime;

// Token: 0x0200036B RID: 875
public class GameCoreOnlineSubsystem : DesktopOnlineSubsystem
{
	// Token: 0x060013E9 RID: 5097 RVA: 0x0005939F File Offset: 0x0005759F
	public static bool IsPackaged(DesktopPlatform desktopPlatform)
	{
		return desktopPlatform.IncludesPlugin(Path.Combine("x86_64", "XGamingRuntimeThunks.dll"));
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x000593B8 File Offset: 0x000575B8
	public GameCoreOnlineSubsystem(DesktopPlatform platform)
	{
		this.platform = platform;
		this.achievementIdMap = Resources.Load<AchievementIDMap>("XB1AchievementMap");
		this.awardedAchievements = new HashSet<int>();
		if (!GameCoreOnlineSubsystem.Succeeded(SDK.XGameRuntimeInitialize(), "Initialize gaming runtime"))
		{
			return;
		}
		SDK.XUserAddAsync(XUserAddOptions.AddDefaultUserAllowingUI, new XUserAddCompleted(this.AddUserComplete));
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00059411 File Offset: 0x00057611
	public override void Update()
	{
		base.Update();
		SDK.XTaskQueueDispatch(0U);
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060013EC RID: 5100 RVA: 0x0004E56C File Offset: 0x0004C76C
	public override Platform.EngagementRequirements EngagementRequirement
	{
		get
		{
			return Platform.EngagementRequirements.MustDisplay;
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x060013ED RID: 5101 RVA: 0x0005941F File Offset: 0x0005761F
	public override Platform.EngagementStates EngagementState
	{
		get
		{
			if (!string.IsNullOrEmpty(this.userDisplayName))
			{
				return Platform.EngagementStates.Engaged;
			}
			return Platform.EngagementStates.NotEngaged;
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x060013EE RID: 5102 RVA: 0x00059431 File Offset: 0x00057631
	public override string EngagedDisplayName
	{
		get
		{
			return this.userDisplayName;
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x060013EF RID: 5103 RVA: 0x00059439 File Offset: 0x00057639
	public override Texture2D EngagedDisplayImage
	{
		get
		{
			return this.userDisplayImage;
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0000D742 File Offset: 0x0000B942
	public override bool AreAchievementsFetched
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0004E56C File Offset: 0x0004C76C
	public override bool HasNativeAchievementsDialog
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x00059444 File Offset: 0x00057644
	public override void PushAchievementUnlock(string achievementId)
	{
		int? serviceId = (this.achievementIdMap != null) ? this.achievementIdMap.GetServiceIdForInternalId(achievementId) : null;
		if (serviceId == null || this.achievementIdMap == null)
		{
			return;
		}
		ulong xboxUserId;
		if (!GameCoreOnlineSubsystem.Succeeded(SDK.XUserGetId(this._userHandle, out xboxUserId), "Get Xbox user ID"))
		{
			return;
		}
		HashSet<int> currentAwardedAchievements = this.awardedAchievements;
		if (currentAwardedAchievements.Contains(serviceId.Value))
		{
			return;
		}
		SDK.XBL.XblAchievementsUpdateAchievementAsync(this._xblContextHandle, xboxUserId, serviceId.Value.ToString(), 100U, delegate(int hresult)
		{
			if (GameCoreOnlineSubsystem.Succeeded(hresult, "Unlock achievement"))
			{
				currentAwardedAchievements.Add(serviceId.Value);
			}
		});
	}

	// Token: 0x060013F3 RID: 5107 RVA: 0x0005950C File Offset: 0x0005770C
	public override bool? IsAchievementUnlocked(string achievementId)
	{
		return null;
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00003603 File Offset: 0x00001803
	public override void ResetAchievements()
	{
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00059522 File Offset: 0x00057722
	private string GetSaveContainerName(int slotIndex)
	{
		return "save" + slotIndex.ToString();
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x00059535 File Offset: 0x00057735
	private string GetSaveFileName(int slotIndex)
	{
		return "user" + slotIndex.ToString() + ".dat";
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0004E56C File Offset: 0x0004C76C
	public override bool HandlesGameSaves
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0000D742 File Offset: 0x0000B942
	public override bool WillPreloadSaveFiles
	{
		get
		{
			return false;
		}
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x00059550 File Offset: 0x00057750
	public override void IsSaveSlotInUse(int slotIndex, Action<bool> callback)
	{
		XGameSaveContainerInfo xgameSaveContainerInfo;
		if (GameCoreOnlineSubsystem.Succeeded(SDK.XGameSaveGetContainerInfo(this._gameSaveProviderHandle, this.GetSaveContainerName(slotIndex), out xgameSaveContainerInfo), "Get container info"))
		{
			this.ReadSaveSlot(slotIndex, delegate(byte[] bytes)
			{
				Action<bool> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(bytes != null);
			});
			return;
		}
		Action<bool> callback2 = callback;
		if (callback2 == null)
		{
			return;
		}
		callback2(false);
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x000595B0 File Offset: 0x000577B0
	public override void ReadSaveSlot(int slotIndex, Action<byte[]> callback)
	{
		GameCoreOnlineSubsystem.Succeeded(SDK.XGameSaveCreateContainer(this._gameSaveProviderHandle, this.GetSaveContainerName(slotIndex), out this._gameSaveContainerHandle), "Create container in Read");
		SDK.XGameSaveReadBlobDataAsync(this._gameSaveContainerHandle, new string[]
		{
			this.GetSaveFileName(slotIndex)
		}, delegate(int hresult, XGameSaveBlob[] blobs)
		{
			if (!GameCoreOnlineSubsystem.Succeeded(hresult, "Read Blob"))
			{
				Action<byte[]> callback2 = callback;
				if (callback2 == null)
				{
					return;
				}
				callback2(null);
				return;
			}
			else
			{
				byte[] obj = null;
				int num = 0;
				if (num < blobs.Length)
				{
					obj = blobs[num].Data;
				}
				Action<byte[]> callback3 = callback;
				if (callback3 == null)
				{
					return;
				}
				callback3(obj);
				return;
			}
		});
	}

	// Token: 0x060013FB RID: 5115 RVA: 0x00059614 File Offset: 0x00057814
	public override void WriteSaveSlot(int slotIndex, byte[] bytes, Action<bool> callback)
	{
		GameCoreOnlineSubsystem.Succeeded(SDK.XGameSaveCreateContainer(this._gameSaveProviderHandle, this.GetSaveContainerName(slotIndex), out this._gameSaveContainerHandle), "Create container in Write");
		XGameSaveUpdateHandle updateHandle;
		if (!GameCoreOnlineSubsystem.Succeeded(SDK.XGameSaveCreateUpdate(this._gameSaveContainerHandle, this.GetSaveContainerName(slotIndex), out updateHandle), "Update container"))
		{
			Action<bool> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(false);
			return;
		}
		else
		{
			if (GameCoreOnlineSubsystem.Succeeded(SDK.XGameSaveSubmitBlobWrite(updateHandle, this.GetSaveFileName(slotIndex), bytes), "Submit blob write"))
			{
				SDK.XGameSaveSubmitUpdateAsync(updateHandle, delegate(int hresult)
				{
					if (GameCoreOnlineSubsystem.Succeeded(hresult, "Game save submit update complete"))
					{
						Action<bool> callback4 = callback;
						if (callback4 == null)
						{
							return;
						}
						callback4(true);
						return;
					}
					else
					{
						Action<bool> callback5 = callback;
						if (callback5 == null)
						{
							return;
						}
						callback5(false);
						return;
					}
				});
				return;
			}
			Action<bool> callback3 = callback;
			if (callback3 == null)
			{
				return;
			}
			callback3(false);
			return;
		}
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x000596C1 File Offset: 0x000578C1
	public override void ClearSaveSlot(int slotIndex, Action<bool> callback)
	{
		if (!GameCoreOnlineSubsystem.Succeeded(SDK.XGameSaveDeleteContainer(this._gameSaveProviderHandle, this.GetSaveContainerName(slotIndex)), "Get container info"))
		{
			if (callback != null)
			{
				callback(false);
			}
			return;
		}
		if (callback != null)
		{
			callback(true);
		}
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x000596F8 File Offset: 0x000578F8
	private static bool Succeeded(int hresult, string operationFriendlyName)
	{
		bool result = false;
		if (hresult >= 0)
		{
			result = true;
		}
		else
		{
			string arg = hresult.ToString("X8");
			string arg2 = operationFriendlyName + " failed.";
			Debug.LogError(string.Format("{0} Error code: hr=0x{1}", arg2, arg));
		}
		return result;
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x0005973A File Offset: 0x0005793A
	private void AddUserComplete(int hresult, XUserHandle userHandle)
	{
		if (!GameCoreOnlineSubsystem.Succeeded(hresult, "Sign in."))
		{
			return;
		}
		Debug.Log("Signed in!");
		this._userHandle = userHandle;
		this.CompletePostSignInInitialization();
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x00059764 File Offset: 0x00057964
	private void CompletePostSignInInitialization()
	{
		string text;
		if (GameCoreOnlineSubsystem.Succeeded(SDK.XUserGetGamertag(this._userHandle, XUserGamertagComponent.UniqueModern, out text), "Get gamertag."))
		{
			Debug.Log("Got gamertag!");
			this.userDisplayName = text;
			this.platform.NotifyEngagedDisplayInfoChanged();
		}
		SDK.XUserGetGamerPictureAsync(this._userHandle, XUserGamerPictureSize.Small, delegate(int hresult, byte[] buffer)
		{
			if (!GameCoreOnlineSubsystem.Succeeded(hresult, "Get user display pic."))
			{
				return;
			}
			this.userDisplayImage = new Texture2D(64, 64, TextureFormat.BGRA32, false, false);
			this.userDisplayImage.LoadImage(buffer);
			this.platform.NotifyEngagedDisplayInfoChanged();
		});
		GameCoreOnlineSubsystem.Succeeded(SDK.XBL.XblInitialize("00000000-0000-0000-0000-00007abd14db"), "Initialize Xbox Live");
		GameCoreOnlineSubsystem.Succeeded(SDK.XBL.XblContextCreateHandle(this._userHandle, out this._xblContextHandle), "Create Xbox Live context");
		HashSet<int> hashSet = new HashSet<int>();
		this.awardedAchievements = hashSet;
		SDK.XGameSaveInitializeProviderAsync(this._userHandle, "00000000-0000-0000-0000-00007abd14db", false, delegate(int hresult, XGameSaveProviderHandle handle)
		{
			if (!GameCoreOnlineSubsystem.Succeeded(hresult, "Init game save provider"))
			{
				return;
			}
			this._gameSaveProviderHandle = handle;
			Debug.Log("Initialized game save provider!");
			this.MigrateLocalSaves();
		});
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x0005981C File Offset: 0x00057A1C
	private void MigrateLocalSaves()
	{
		for (int i = 1; i <= 4; i++)
		{
			int slotIndex = i;
			Action<bool> <>9__2;
			this.platform.LocalReadSaveSlot(slotIndex, delegate(byte[] localBytes)
			{
				if (localBytes == null)
				{
					return;
				}
				this.platform.ReadSaveSlot(slotIndex, delegate(byte[] bytes)
				{
					if (bytes != null)
					{
						return;
					}
					Platform platform = this.platform;
					int slotIndex = slotIndex;
					byte[] localBytes = localBytes;
					Action<bool> callback;
					if ((callback = <>9__2) == null)
					{
						callback = (<>9__2 = delegate(bool success)
						{
							Debug.Log(string.Format("Migrated local slot {0} to cloud.", slotIndex));
						});
					}
					platform.WriteSaveSlot(slotIndex, localBytes, callback);
				});
			});
		}
	}

	// Token: 0x040012C9 RID: 4809
	private const string SCID = "00000000-0000-0000-0000-00007abd14db";

	// Token: 0x040012CA RID: 4810
	private AchievementIDMap achievementIdMap;

	// Token: 0x040012CB RID: 4811
	private HashSet<int> awardedAchievements;

	// Token: 0x040012CC RID: 4812
	private XUserHandle _userHandle;

	// Token: 0x040012CD RID: 4813
	private XblContextHandle _xblContextHandle;

	// Token: 0x040012CE RID: 4814
	private XGameSaveProviderHandle _gameSaveProviderHandle;

	// Token: 0x040012CF RID: 4815
	private XGameSaveContainerHandle _gameSaveContainerHandle;

	// Token: 0x040012D0 RID: 4816
	private string userDisplayName;

	// Token: 0x040012D1 RID: 4817
	private Texture2D userDisplayImage;

	// Token: 0x040012D2 RID: 4818
	private DesktopPlatform platform;
}
