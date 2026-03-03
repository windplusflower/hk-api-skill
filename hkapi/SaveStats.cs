using System;
using System.Collections.Generic;
using GlobalEnums;

// Token: 0x02000316 RID: 790
[Serializable]
public class SaveStats
{
	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06001143 RID: 4419 RVA: 0x0005109A File Offset: 0x0004F29A
	// (set) Token: 0x06001144 RID: 4420 RVA: 0x000510A2 File Offset: 0x0004F2A2
	public int maxHealth { get; private set; }

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06001145 RID: 4421 RVA: 0x000510AB File Offset: 0x0004F2AB
	// (set) Token: 0x06001146 RID: 4422 RVA: 0x000510B3 File Offset: 0x0004F2B3
	public int geo { get; private set; }

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06001147 RID: 4423 RVA: 0x000510BC File Offset: 0x0004F2BC
	// (set) Token: 0x06001148 RID: 4424 RVA: 0x000510C4 File Offset: 0x0004F2C4
	public MapZone mapZone { get; private set; }

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06001149 RID: 4425 RVA: 0x000510CD File Offset: 0x0004F2CD
	// (set) Token: 0x0600114A RID: 4426 RVA: 0x000510D5 File Offset: 0x0004F2D5
	public float playTime { get; private set; }

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x0600114B RID: 4427 RVA: 0x000510DE File Offset: 0x0004F2DE
	// (set) Token: 0x0600114C RID: 4428 RVA: 0x000510E6 File Offset: 0x0004F2E6
	public int maxMPReserve { get; private set; }

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x0600114D RID: 4429 RVA: 0x000510EF File Offset: 0x0004F2EF
	// (set) Token: 0x0600114E RID: 4430 RVA: 0x000510F7 File Offset: 0x0004F2F7
	public int permadeathMode { get; private set; }

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x0600114F RID: 4431 RVA: 0x00051100 File Offset: 0x0004F300
	// (set) Token: 0x06001150 RID: 4432 RVA: 0x00051108 File Offset: 0x0004F308
	public bool bossRushMode { get; private set; }

	// Token: 0x17000200 RID: 512
	// (get) Token: 0x06001151 RID: 4433 RVA: 0x00051111 File Offset: 0x0004F311
	// (set) Token: 0x06001152 RID: 4434 RVA: 0x00051119 File Offset: 0x0004F319
	public float completionPercentage { get; private set; }

	// Token: 0x17000201 RID: 513
	// (get) Token: 0x06001153 RID: 4435 RVA: 0x00051122 File Offset: 0x0004F322
	// (set) Token: 0x06001154 RID: 4436 RVA: 0x0005112A File Offset: 0x0004F32A
	public bool unlockedCompletionRate { get; private set; }

	// Token: 0x06001155 RID: 4437 RVA: 0x00051134 File Offset: 0x0004F334
	public SaveStats(int maxHealth, int geo, MapZone mapZone, float playTime, int maxMPReserve, int permadeathMode, bool bossRushMode, float completionPercentage, bool unlockedCompletionRate)
	{
		this.maxHealth = maxHealth;
		this.geo = geo;
		this.mapZone = mapZone;
		this.playTime = playTime;
		this.maxMPReserve = maxMPReserve;
		this.permadeathMode = permadeathMode;
		this.bossRushMode = bossRushMode;
		this.completionPercentage = completionPercentage;
		this.playTimeStruct.RawTime = playTime;
		this.unlockedCompletionRate = unlockedCompletionRate;
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x0005119C File Offset: 0x0004F39C
	public string GetPlaytimeHHMM()
	{
		if (this.playTimeStruct.HasHours)
		{
			return string.Format("{0:0}h {1:00}m", (int)this.playTimeStruct.Hours, (int)this.playTimeStruct.Minutes);
		}
		return string.Format("{0:0}m", (int)this.playTimeStruct.Minutes);
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x00051200 File Offset: 0x0004F400
	public string GetPlaytimeHHMMSS()
	{
		if (!this.playTimeStruct.HasHours)
		{
			return string.Format("{0:0}m {1:00}s", (int)this.playTimeStruct.Minutes, (int)this.playTimeStruct.Seconds);
		}
		if (!this.playTimeStruct.HasMinutes)
		{
			return string.Format("{0:0}s", (int)this.playTimeStruct.Seconds);
		}
		return string.Format("{0:0}h {1:00}m {2:00}s", (int)this.playTimeStruct.Hours, (int)this.playTimeStruct.Minutes, (int)this.playTimeStruct.Seconds);
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x000512B0 File Offset: 0x0004F4B0
	public string GetCompletionPercentage()
	{
		return this.completionPercentage.ToString() + "%";
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x000512D5 File Offset: 0x0004F4D5
	public int GetMPSlotsVisible()
	{
		return (int)((float)this.maxMPReserve / 33f);
	}

	// Token: 0x17000202 RID: 514
	// (get) Token: 0x0600115A RID: 4442 RVA: 0x000512E5 File Offset: 0x0004F4E5
	// (set) Token: 0x0600115B RID: 4443 RVA: 0x000512ED File Offset: 0x0004F4ED
	public Dictionary<string, string> LoadedMods { get; set; }

	// Token: 0x17000203 RID: 515
	// (get) Token: 0x0600115C RID: 4444 RVA: 0x000512F6 File Offset: 0x0004F4F6
	// (set) Token: 0x0600115D RID: 4445 RVA: 0x000512FE File Offset: 0x0004F4FE
	public string Name { get; set; }

	// Token: 0x040010FF RID: 4351
	private PlayTime playTimeStruct;
}
