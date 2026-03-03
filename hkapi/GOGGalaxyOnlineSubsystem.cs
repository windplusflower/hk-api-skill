using System;
using System.IO;
using Galaxy.Api;
using UnityEngine;

// Token: 0x02000368 RID: 872
public class GOGGalaxyOnlineSubsystem : DesktopOnlineSubsystem
{
	// Token: 0x060013D3 RID: 5075 RVA: 0x00058FB4 File Offset: 0x000571B4
	public static bool IsPackaged(DesktopPlatform desktopPlatform)
	{
		return desktopPlatform.IncludesPlugin(Path.Combine("x86_64", "GalaxyCSharpGlue.dll"));
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00058FCB File Offset: 0x000571CB
	public bool DidInitialize
	{
		get
		{
			return this.didInitialize;
		}
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00058FD4 File Offset: 0x000571D4
	public GOGGalaxyOnlineSubsystem(DesktopPlatform platform)
	{
		this.platform = platform;
		try
		{
			GalaxyInstance.Init(new InitParams("49793783576384298", "671f07c4f94af2359848f4780f9914dee9f3d7d7131d05c23f4258b2e7077d39"));
			this.didInitialize = true;
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
		}
		if (this.didInitialize)
		{
			IListenerRegistrar listenerRegistrar = GalaxyInstance.ListenerRegistrar();
			this.authorization = new GOGGalaxyOnlineSubsystem.Authorization(this);
			listenerRegistrar.Register(GalaxyTypeAwareListenerAuth.GetListenerType(), this.authorization);
			this.statistics = new GOGGalaxyOnlineSubsystem.Statistics(this);
			listenerRegistrar.Register(GalaxyTypeAwareListenerUserStatsAndAchievementsRetrieve.GetListenerType(), this.statistics);
			this.authorization.SignIn();
			return;
		}
		Debug.LogErrorFormat("GOG failed to initialize", Array.Empty<object>());
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00059084 File Offset: 0x00057284
	public override void Dispose()
	{
		if (this.statistics != null)
		{
			this.statistics.Dispose();
			this.statistics = null;
		}
		if (this.authorization != null)
		{
			this.authorization.Dispose();
			this.authorization = null;
		}
		if (this.didInitialize)
		{
			GalaxyInstance.Shutdown(true);
			this.didInitialize = false;
		}
		base.Dispose();
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x000590E0 File Offset: 0x000572E0
	public override void Update()
	{
		base.Update();
		if (this.didInitialize)
		{
			GalaxyInstance.ProcessData();
		}
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x000590F5 File Offset: 0x000572F5
	private void OnAuthorized()
	{
		this.statistics.Request();
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00059102 File Offset: 0x00057302
	public override bool AreAchievementsFetched
	{
		get
		{
			return this.statistics != null && this.statistics.DidReceive;
		}
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x00059119 File Offset: 0x00057319
	private void OnStatisticsReceived()
	{
		this.platform.OnOnlineSubsystemAchievementsFetched();
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00059128 File Offset: 0x00057328
	public override bool? IsAchievementUnlocked(string achievementId)
	{
		bool? result;
		if (!this.authorization.IsAuthorized || !this.statistics.DidReceive)
		{
			Debug.LogErrorFormat("Unable to get achievement {0}, because GOG is not authenticated.", new object[]
			{
				achievementId
			});
			result = null;
			return result;
		}
		bool value = false;
		uint num = 0U;
		try
		{
			GalaxyInstance.Stats().GetAchievement(achievementId, ref value, ref num);
			result = new bool?(value);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			result = null;
		}
		return result;
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x000591AC File Offset: 0x000573AC
	public override void PushAchievementUnlock(string achievementId)
	{
		if (this.authorization.IsAuthorized)
		{
			try
			{
				GalaxyInstance.Stats().SetAchievement(achievementId);
				GalaxyInstance.Stats().StoreStatsAndAchievements();
				return;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return;
			}
		}
		Debug.LogErrorFormat("Unable to push achievement {0}, because GOG is not authenticated.", new object[]
		{
			achievementId
		});
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x00059208 File Offset: 0x00057408
	public override void ResetAchievements()
	{
		if (this.authorization.IsAuthorized)
		{
			try
			{
				GalaxyInstance.Stats().ResetStatsAndAchievements();
				return;
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
				return;
			}
		}
		Debug.LogErrorFormat("Unable to reset achievements, because GOG is not authenticated.", Array.Empty<object>());
	}

	// Token: 0x040012BD RID: 4797
	private const string ClientId = "49793783576384298";

	// Token: 0x040012BE RID: 4798
	private const string ClientSecret = "671f07c4f94af2359848f4780f9914dee9f3d7d7131d05c23f4258b2e7077d39";

	// Token: 0x040012BF RID: 4799
	private DesktopPlatform platform;

	// Token: 0x040012C0 RID: 4800
	private bool didInitialize;

	// Token: 0x040012C1 RID: 4801
	private GOGGalaxyOnlineSubsystem.Authorization authorization;

	// Token: 0x040012C2 RID: 4802
	private GOGGalaxyOnlineSubsystem.Statistics statistics;

	// Token: 0x02000369 RID: 873
	private class Authorization : GlobalAuthListener
	{
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00059254 File Offset: 0x00057454
		public bool IsAuthorized
		{
			get
			{
				return this.isAuthorized;
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0005925C File Offset: 0x0005745C
		public Authorization(GOGGalaxyOnlineSubsystem subsystem)
		{
			this.subsystem = subsystem;
			this.isAuthorized = false;
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00059272 File Offset: 0x00057472
		public override void OnAuthSuccess()
		{
			this.isAuthorized = true;
			Debug.LogFormat("GOG authorized", Array.Empty<object>());
			this.subsystem.OnAuthorized();
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00059295 File Offset: 0x00057495
		public override void OnAuthFailure(IAuthListener.FailureReason failureReason)
		{
			this.isAuthorized = false;
			Debug.LogErrorFormat("GOG authorization failed: {0}", new object[]
			{
				failureReason
			});
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x000592B7 File Offset: 0x000574B7
		public override void OnAuthLost()
		{
			this.isAuthorized = false;
			Debug.LogErrorFormat("GOG authorization lost", Array.Empty<object>());
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x000592D0 File Offset: 0x000574D0
		public void SignIn()
		{
			try
			{
				Debug.LogFormat("GOG signing in...", Array.Empty<object>());
				this.user = GalaxyInstance.User();
				this.user.SignInGalaxy();
			}
			catch (Exception exception)
			{
				Debug.LogException(exception);
			}
		}

		// Token: 0x040012C3 RID: 4803
		private readonly GOGGalaxyOnlineSubsystem subsystem;

		// Token: 0x040012C4 RID: 4804
		private IUser user;

		// Token: 0x040012C5 RID: 4805
		private bool isAuthorized;
	}

	// Token: 0x0200036A RID: 874
	private class Statistics : GlobalUserStatsAndAchievementsRetrieveListener
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0005931C File Offset: 0x0005751C
		public bool DidReceive
		{
			get
			{
				return this.didReceive;
			}
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00059324 File Offset: 0x00057524
		public Statistics(GOGGalaxyOnlineSubsystem subsystem)
		{
			this.subsystem = subsystem;
			this.didReceive = false;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0005933A File Offset: 0x0005753A
		public override void OnUserStatsAndAchievementsRetrieveSuccess(GalaxyID userID)
		{
			Debug.LogFormat("Retrieved stats", Array.Empty<object>());
			this.didReceive = true;
			this.subsystem.OnStatisticsReceived();
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0005935D File Offset: 0x0005755D
		public override void OnUserStatsAndAchievementsRetrieveFailure(GalaxyID userID, IUserStatsAndAchievementsRetrieveListener.FailureReason failureReason)
		{
			Debug.LogErrorFormat("Failed to retrieve stats: {0}", new object[]
			{
				failureReason
			});
		}

		// Token: 0x060013E8 RID: 5096 RVA: 0x00059378 File Offset: 0x00057578
		public void Request()
		{
			Debug.LogFormat("GOG requesting user stats and achievements...", Array.Empty<object>());
			this.stats = GalaxyInstance.Stats();
			this.stats.RequestUserStatsAndAchievements();
		}

		// Token: 0x040012C6 RID: 4806
		private readonly GOGGalaxyOnlineSubsystem subsystem;

		// Token: 0x040012C7 RID: 4807
		private bool didReceive;

		// Token: 0x040012C8 RID: 4808
		private IStats stats;
	}
}
