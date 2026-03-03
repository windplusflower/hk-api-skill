using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000215 RID: 533
public class SpawnBloodTime : SpawnBlood
{
	// Token: 0x06000B79 RID: 2937 RVA: 0x0003CA49 File Offset: 0x0003AC49
	public override void Reset()
	{
		base.Reset();
		this.delay = new FsmFloat(0.1f);
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00003603 File Offset: 0x00001803
	public override void OnEnter()
	{
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x0003CA66 File Offset: 0x0003AC66
	public override void OnUpdate()
	{
		base.OnUpdate();
		if (Time.time > this.nextSpawnTime)
		{
			this.nextSpawnTime = Time.time + this.delay.Value;
			base.Spawn();
		}
	}

	// Token: 0x04000C71 RID: 3185
	public FsmFloat delay;

	// Token: 0x04000C72 RID: 3186
	private float nextSpawnTime;
}
