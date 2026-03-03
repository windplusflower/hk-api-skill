using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x020001D1 RID: 465
public class TrackSpawnedEnemies : MonoBehaviour
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x000381CD File Offset: 0x000363CD
	public int TotalTracked
	{
		get
		{
			return this.trackedEnemies.Count;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000A3F RID: 2623 RVA: 0x000381DA File Offset: 0x000363DA
	public int TotalAlive
	{
		get
		{
			return (from enemy in this.trackedEnemies
			where enemy && enemy.hp > 0
			select enemy).ToList<HealthManager>().Count;
		}
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00038210 File Offset: 0x00036410
	public void Add(HealthManager enemyHealthManager)
	{
		this.trackedEnemies.Add(enemyHealthManager);
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x0003821E File Offset: 0x0003641E
	public TrackSpawnedEnemies()
	{
		this.trackedEnemies = new List<HealthManager>();
		base..ctor();
	}

	// Token: 0x04000B59 RID: 2905
	private List<HealthManager> trackedEnemies;
}
