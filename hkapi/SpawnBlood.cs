using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x02000214 RID: 532
public class SpawnBlood : FsmStateAction
{
	// Token: 0x06000B75 RID: 2933 RVA: 0x0003C908 File Offset: 0x0003AB08
	public override void Reset()
	{
		this.spawnPoint = new FsmGameObject
		{
			UseVariable = true
		};
		this.position = new FsmVector3();
		this.spawnMin = null;
		this.spawnMax = null;
		this.speedMin = null;
		this.speedMax = null;
		this.angleMin = null;
		this.angleMax = null;
		this.colorOverride = new FsmColor
		{
			UseVariable = true
		};
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x0003C96E File Offset: 0x0003AB6E
	public override void OnEnter()
	{
		this.Spawn();
		base.Finish();
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x0003C97C File Offset: 0x0003AB7C
	protected void Spawn()
	{
		if (GlobalPrefabDefaults.Instance)
		{
			Vector3 a = this.position.Value;
			if (this.spawnPoint.Value)
			{
				a += this.spawnPoint.Value.transform.position;
			}
			GlobalPrefabDefaults.Instance.SpawnBlood(a, (short)this.spawnMin.Value, (short)this.spawnMax.Value, this.speedMin.Value, this.speedMax.Value, this.angleMin.Value, this.angleMax.Value, this.colorOverride.IsNone ? null : new Color?(this.colorOverride.Value));
		}
	}

	// Token: 0x04000C68 RID: 3176
	public FsmGameObject spawnPoint;

	// Token: 0x04000C69 RID: 3177
	public FsmVector3 position;

	// Token: 0x04000C6A RID: 3178
	public FsmInt spawnMin;

	// Token: 0x04000C6B RID: 3179
	public FsmInt spawnMax;

	// Token: 0x04000C6C RID: 3180
	public FsmFloat speedMin;

	// Token: 0x04000C6D RID: 3181
	public FsmFloat speedMax;

	// Token: 0x04000C6E RID: 3182
	public FsmFloat angleMin;

	// Token: 0x04000C6F RID: 3183
	public FsmFloat angleMax;

	// Token: 0x04000C70 RID: 3184
	public FsmColor colorOverride;
}
