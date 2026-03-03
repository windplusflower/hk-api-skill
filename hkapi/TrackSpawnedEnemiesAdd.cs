using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020001D3 RID: 467
[ActionCategory("Hollow Knight")]
public class TrackSpawnedEnemiesAdd : FsmStateAction
{
	// Token: 0x06000A45 RID: 2629 RVA: 0x00038252 File Offset: 0x00036452
	public override void Reset()
	{
		this.Target = null;
		this.SpawnedEnemy = null;
		this.UsesEnemySpawner = null;
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x0003826C File Offset: 0x0003646C
	public override void OnEnter()
	{
		GameObject safe = this.Target.GetSafe(this);
		if (safe && this.SpawnedEnemy.Value)
		{
			TrackSpawnedEnemies track = safe.GetComponent<TrackSpawnedEnemies>() ?? safe.AddComponent<TrackSpawnedEnemies>();
			if (this.UsesEnemySpawner.Value)
			{
				EnemySpawner component = this.SpawnedEnemy.Value.GetComponent<EnemySpawner>();
				if (component)
				{
					component.OnEnemySpawned += delegate(GameObject enemy)
					{
						this.AddTracked(track, enemy);
					};
				}
			}
			else
			{
				this.AddTracked(track, this.SpawnedEnemy.Value);
			}
		}
		base.Finish();
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00038320 File Offset: 0x00036520
	private void AddTracked(TrackSpawnedEnemies tracker, GameObject obj)
	{
		HealthManager component = obj.GetComponent<HealthManager>();
		if (component)
		{
			tracker.Add(component);
		}
	}

	// Token: 0x04000B5C RID: 2908
	public FsmOwnerDefault Target;

	// Token: 0x04000B5D RID: 2909
	public FsmGameObject SpawnedEnemy;

	// Token: 0x04000B5E RID: 2910
	public FsmBool UsesEnemySpawner;
}
