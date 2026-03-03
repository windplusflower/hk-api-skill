using System;
using UnityEngine;

// Token: 0x02000367 RID: 871
public abstract class DesktopOnlineSubsystem : IDisposable
{
	// Token: 0x060013C1 RID: 5057 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void Dispose()
	{
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void Update()
	{
	}

	// Token: 0x060013C3 RID: 5059
	public abstract bool? IsAchievementUnlocked(string achievementId);

	// Token: 0x060013C4 RID: 5060
	public abstract void PushAchievementUnlock(string achievementId);

	// Token: 0x060013C5 RID: 5061
	public abstract void ResetAchievements();

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x060013C6 RID: 5062
	public abstract bool AreAchievementsFetched { get; }

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x060013C7 RID: 5063 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool HasNativeAchievementsDialog
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x060013C8 RID: 5064 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual bool HandlesGameSaves
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x060013C9 RID: 5065 RVA: 0x0004E56C File Offset: 0x0004C76C
	public virtual bool WillPreloadSaveFiles
	{
		get
		{
			return true;
		}
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void IsSaveSlotInUse(int slotIndex, Action<bool> callback)
	{
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void ReadSaveSlot(int slotIndex, Action<byte[]> callback)
	{
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void WriteSaveSlot(int slotIndex, byte[] bytes, Action<bool> callback)
	{
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x00003603 File Offset: 0x00001803
	public virtual void ClearSaveSlot(int slotIndex, Action<bool> callback)
	{
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060013CE RID: 5070 RVA: 0x0000D742 File Offset: 0x0000B942
	public virtual Platform.EngagementRequirements EngagementRequirement
	{
		get
		{
			return Platform.EngagementRequirements.Invisible;
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x060013CF RID: 5071 RVA: 0x00058FB1 File Offset: 0x000571B1
	public virtual Platform.EngagementStates EngagementState
	{
		get
		{
			return Platform.EngagementStates.Engaged;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060013D0 RID: 5072 RVA: 0x000086D3 File Offset: 0x000068D3
	public virtual string EngagedDisplayName
	{
		get
		{
			return null;
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x060013D1 RID: 5073 RVA: 0x000086D3 File Offset: 0x000068D3
	public virtual Texture2D EngagedDisplayImage
	{
		get
		{
			return null;
		}
	}
}
