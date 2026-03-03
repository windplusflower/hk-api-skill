using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000A6 RID: 166
[CreateAssetMenu(fileName = "NewAtmosCue", menuName = "Hollow Knight/Atmos Cue", order = 1000)]
public class AtmosCue : ScriptableObject
{
	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600038F RID: 911 RVA: 0x00012C3C File Offset: 0x00010E3C
	public AudioMixerSnapshot Snapshot
	{
		get
		{
			return this.snapshot;
		}
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00012C44 File Offset: 0x00010E44
	public bool IsChannelEnabled(AtmosChannels channel)
	{
		return channel >= AtmosChannels.CaveWind && channel < (AtmosChannels)this.isChannelEnabled.Length && this.isChannelEnabled[(int)channel];
	}

	// Token: 0x040002F6 RID: 758
	[SerializeField]
	private AudioMixerSnapshot snapshot;

	// Token: 0x040002F7 RID: 759
	[SerializeField]
	[ArrayForEnum(typeof(AtmosChannels))]
	private bool[] isChannelEnabled;
}
