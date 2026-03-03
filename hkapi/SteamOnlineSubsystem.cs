using System;
using System.IO;
using System.Text;
using Steamworks;
using UnityEngine;

// Token: 0x02000386 RID: 902
public class SteamOnlineSubsystem : DesktopOnlineSubsystem
{
	// Token: 0x060014B0 RID: 5296 RVA: 0x0005A5AC File Offset: 0x000587AC
	public static bool IsPackaged(DesktopPlatform desktopPlatform)
	{
		return desktopPlatform.IncludesPlugin(Path.Combine("x86_64", "steam_api64.dll"));
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x0005A5C4 File Offset: 0x000587C4
	public SteamOnlineSubsystem(DesktopPlatform platform)
	{
		this.platform = platform;
		if (!Packsize.Test())
		{
			Debug.LogErrorFormat("Steamworks packsize incorrect.", Array.Empty<object>());
		}
		if (!DllCheck.Test())
		{
			Debug.LogErrorFormat("Steamworks binaries out of date or missing.", Array.Empty<object>());
		}
		if (SteamAPI.RestartAppIfNecessary(new AppId_t(367520U)))
		{
			Debug.LogError("Application was not launched through Steam! Shutting down...");
			Application.Quit();
		}
		Debug.LogFormat("Steam initializing", Array.Empty<object>());
		if (this.didInitialize = SteamAPI.Init())
		{
			this.warningCallback = new SteamAPIWarningMessageHook_t(this.OnSteamLogMessage);
			SteamClient.SetWarningMessageHook(this.warningCallback);
			this.gameOverlayCallback = Callback<GameOverlayActivated_t>.Create(new Callback<GameOverlayActivated_t>.DispatchDelegate(this.OnGameOverlayActivated));
			this.statsReceivedCallback = Callback<UserStatsReceived_t>.Create(new Callback<UserStatsReceived_t>.DispatchDelegate(this.OnStatsReceived));
			this.steamShutdownCallback = Callback<SteamShutdown_t>.Create(new Callback<SteamShutdown_t>.DispatchDelegate(this.OnSteamShutdown));
			this.achievementStoredCallback = Callback<UserAchievementStored_t>.Create(new Callback<UserAchievementStored_t>.DispatchDelegate(this.OnAchievementStored));
			string personaName = SteamFriends.GetPersonaName();
			Debug.LogFormat("Steam logged in as {0}", new object[]
			{
				personaName
			});
			if (!SteamUserStats.RequestCurrentStats())
			{
				Debug.LogErrorFormat("Steam unable to request current stats.", Array.Empty<object>());
				return;
			}
		}
		else
		{
			Debug.LogErrorFormat("Steam failed to initialize", Array.Empty<object>());
		}
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x0005A705 File Offset: 0x00058905
	public override void Dispose()
	{
		if (this.didInitialize)
		{
			Debug.LogFormat("Shutting down Steam API.", Array.Empty<object>());
			SteamAPI.Shutdown();
		}
		base.Dispose();
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x0005A729 File Offset: 0x00058929
	public override void Update()
	{
		base.Update();
		SteamAPI.RunCallbacks();
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x0005A738 File Offset: 0x00058938
	private void OnSteamLogMessage(int severity, StringBuilder content)
	{
		string format = "Steam: " + content.ToString();
		if (severity == 1)
		{
			Debug.LogWarningFormat(format, Array.Empty<object>());
			return;
		}
		Debug.LogFormat(format, Array.Empty<object>());
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x0005A771 File Offset: 0x00058971
	private void OnGameOverlayActivated(GameOverlayActivated_t ev)
	{
		Debug.LogFormat("Steam overlay became {0}.", new object[]
		{
			(ev.m_bActive == 0) ? "closed" : "opened"
		});
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x0005A79C File Offset: 0x0005899C
	private void OnStatsReceived(UserStatsReceived_t ev)
	{
		if (ev.m_eResult == EResult.k_EResultOK)
		{
			this.statsReceived = true;
			Debug.LogFormat("Steam stats received.", Array.Empty<object>());
			this.platform.OnOnlineSubsystemAchievementsFetched();
			return;
		}
		Debug.LogErrorFormat("Steam failed to receive stats: {0}", new object[]
		{
			ev.m_eResult
		});
	}

	// Token: 0x170002C7 RID: 711
	// (get) Token: 0x060014B7 RID: 5303 RVA: 0x0005A7F2 File Offset: 0x000589F2
	public override bool AreAchievementsFetched
	{
		get
		{
			return this.statsReceived;
		}
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x0005A7FA File Offset: 0x000589FA
	private void OnSteamShutdown(SteamShutdown_t ev)
	{
		Debug.LogFormat("Steam shut down.", Array.Empty<object>());
		this.didInitialize = false;
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x0005A812 File Offset: 0x00058A12
	private void OnAchievementStored(UserAchievementStored_t ev)
	{
		Debug.LogFormat("Steam achievement {0} ({1}/{2}) upload complete", new object[]
		{
			ev.m_rgchAchievementName,
			ev.m_nCurProgress,
			ev.m_nMaxProgress
		});
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x0005A84C File Offset: 0x00058A4C
	public override void PushAchievementUnlock(string achievementId)
	{
		if (this.didInitialize)
		{
			try
			{
				SteamUserStats.SetAchievement(achievementId);
				SteamUserStats.StoreStats();
				Debug.LogFormat("Pushing achievement {0}", new object[]
				{
					achievementId
				});
				return;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return;
			}
		}
		Debug.LogErrorFormat("Unable to unlock achievement {0}, because Steam is not initialized", new object[]
		{
			achievementId
		});
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x0005A8B0 File Offset: 0x00058AB0
	public override bool? IsAchievementUnlocked(string achievementId)
	{
		if (this.didInitialize)
		{
			try
			{
				bool value;
				if (!SteamUserStats.GetAchievement(achievementId, out value))
				{
					Debug.LogErrorFormat("Failed to retrieve achievement state for {0}", new object[]
					{
						achievementId
					});
					return null;
				}
				return new bool?(value);
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return null;
			}
		}
		Debug.LogErrorFormat("Unable to retrieve achievement state for {0}, because Steam is not initialized", new object[]
		{
			achievementId
		});
		return null;
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x0005A938 File Offset: 0x00058B38
	public override void ResetAchievements()
	{
		if (this.didInitialize)
		{
			try
			{
				SteamUserStats.ResetAllStats(true);
				Debug.LogFormat("Reset all stats", Array.Empty<object>());
				return;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return;
			}
		}
		Debug.LogErrorFormat("Unable to reset all stats, because Steam is not initialized", Array.Empty<object>());
	}

	// Token: 0x04001317 RID: 4887
	private DesktopPlatform platform;

	// Token: 0x04001318 RID: 4888
	private bool didInitialize;

	// Token: 0x04001319 RID: 4889
	private bool statsReceived;

	// Token: 0x0400131A RID: 4890
	private SteamAPIWarningMessageHook_t warningCallback;

	// Token: 0x0400131B RID: 4891
	private Callback<GameOverlayActivated_t> gameOverlayCallback;

	// Token: 0x0400131C RID: 4892
	private Callback<UserStatsReceived_t> statsReceivedCallback;

	// Token: 0x0400131D RID: 4893
	private Callback<SteamShutdown_t> steamShutdownCallback;

	// Token: 0x0400131E RID: 4894
	private Callback<UserAchievementStored_t> achievementStoredCallback;
}
