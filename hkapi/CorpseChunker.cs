using System;
using UnityEngine;

// Token: 0x02000160 RID: 352
public class CorpseChunker : Corpse
{
	// Token: 0x0600082C RID: 2092 RVA: 0x0002DAE4 File Offset: 0x0002BCE4
	protected override void LandEffects()
	{
		if (this.body)
		{
			this.body.velocity = Vector2.zero;
		}
		this.splatAudioClipTable.SpawnAndPlayOneShot(this.audioPlayerPrefab, base.transform.position);
		GlobalPrefabDefaults.Instance.SpawnBlood(base.transform.position, 30, 30, 5f, 30f, 60f, 120f, null);
		GameCameras gameCameras = UnityEngine.Object.FindObjectOfType<GameCameras>();
		if (gameCameras)
		{
			gameCameras.cameraShakeFSM.SendEvent("EnemyKillShake");
		}
		if (this.effects)
		{
			this.effects.SetActive(true);
		}
		if (this.chunks)
		{
			this.chunks.SetActive(true);
			this.chunks.transform.SetParent(null, true);
			FlingUtils.FlingChildren(new FlingUtils.ChildrenConfig
			{
				Parent = this.chunks,
				SpeedMin = 15f,
				SpeedMax = 20f,
				AngleMin = 60f,
				AngleMax = 120f,
				OriginVariationX = 0f,
				OriginVariationY = 0f
			}, base.transform, Vector3.zero);
		}
		this.meshRenderer.enabled = false;
	}

	// Token: 0x04000926 RID: 2342
	[Header("Chunker Variables")]
	public GameObject effects;

	// Token: 0x04000927 RID: 2343
	public GameObject chunks;
}
