using System;
using HutongGames.PlayMaker;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[ActionCategory("Hollow Knight")]
public class PlayAudioEvent : FsmStateAction
{
	// Token: 0x06000398 RID: 920 RVA: 0x00012DE0 File Offset: 0x00010FE0
	public override void Reset()
	{
		this.audioClip = null;
		this.pitchMin = 1f;
		this.pitchMax = 1f;
		this.volume = 1f;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00012E1C File Offset: 0x0001101C
	public override void OnEnter()
	{
		AudioEvent audioEvent = new AudioEvent
		{
			Clip = (this.audioClip.Value as AudioClip),
			PitchMin = this.pitchMin.Value,
			PitchMax = this.pitchMax.Value,
			Volume = this.volume.Value
		};
		if (this.audioPlayerPrefab.Value)
		{
			Vector3 vector = this.spawnPosition.Value;
			GameObject safe = this.spawnPoint.GetSafe(this);
			if (safe)
			{
				vector += safe.transform.position;
			}
			audioEvent.SpawnAndPlayOneShot(this.audioPlayerPrefab.Value as AudioSource, vector);
		}
	}

	// Token: 0x04000300 RID: 768
	[ObjectType(typeof(AudioClip))]
	public FsmObject audioClip;

	// Token: 0x04000301 RID: 769
	public FsmFloat pitchMin;

	// Token: 0x04000302 RID: 770
	public FsmFloat pitchMax;

	// Token: 0x04000303 RID: 771
	public FsmFloat volume;

	// Token: 0x04000304 RID: 772
	[ObjectType(typeof(AudioSource))]
	public FsmObject audioPlayerPrefab;

	// Token: 0x04000305 RID: 773
	public FsmOwnerDefault spawnPoint;

	// Token: 0x04000306 RID: 774
	public FsmVector3 spawnPosition;
}
