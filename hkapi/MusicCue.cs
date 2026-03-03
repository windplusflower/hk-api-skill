using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000B7 RID: 183
[CreateAssetMenu(fileName = "MusicCue", menuName = "Hollow Knight/Music Cue", order = 1000)]
public class MusicCue : ScriptableObject
{
	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060003DB RID: 987 RVA: 0x00013B5D File Offset: 0x00011D5D
	public string OriginalMusicEventName
	{
		get
		{
			return this.originalMusicEventName;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060003DC RID: 988 RVA: 0x00013B65 File Offset: 0x00011D65
	public int OriginalMusicTrackNumber
	{
		get
		{
			return this.originalMusicTrackNumber;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060003DD RID: 989 RVA: 0x00013B6D File Offset: 0x00011D6D
	public AudioMixerSnapshot Snapshot
	{
		get
		{
			return this.snapshot;
		}
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00013B78 File Offset: 0x00011D78
	public MusicCue.MusicChannelInfo GetChannelInfo(MusicChannels channel)
	{
		if (channel < MusicChannels.Main || channel >= (MusicChannels)this.channelInfos.Length)
		{
			return null;
		}
		return this.channelInfos[(int)channel];
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00013BA0 File Offset: 0x00011DA0
	public MusicCue ResolveAlternatives(PlayerData playerData)
	{
		if (this.alternatives != null)
		{
			int i = 0;
			while (i < this.alternatives.Length)
			{
				MusicCue.Alternative alternative = this.alternatives[i];
				if (playerData.GetBool(alternative.PlayerDataBoolKey))
				{
					MusicCue cue = alternative.Cue;
					if (!(cue != null))
					{
						return null;
					}
					return cue.ResolveAlternatives(playerData);
				}
				else
				{
					i++;
				}
			}
		}
		return this;
	}

	// Token: 0x04000360 RID: 864
	[SerializeField]
	private string originalMusicEventName;

	// Token: 0x04000361 RID: 865
	[SerializeField]
	private int originalMusicTrackNumber;

	// Token: 0x04000362 RID: 866
	[SerializeField]
	private AudioMixerSnapshot snapshot;

	// Token: 0x04000363 RID: 867
	[SerializeField]
	[ArrayForEnum(typeof(MusicChannels))]
	private MusicCue.MusicChannelInfo[] channelInfos;

	// Token: 0x04000364 RID: 868
	[SerializeField]
	private MusicCue.Alternative[] alternatives;

	// Token: 0x020000B8 RID: 184
	[Serializable]
	public class MusicChannelInfo
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00013BFE File Offset: 0x00011DFE
		public AudioClip Clip
		{
			get
			{
				return this.clip;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00013C06 File Offset: 0x00011E06
		public bool IsEnabled
		{
			get
			{
				return this.clip != null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00013C14 File Offset: 0x00011E14
		public bool IsSyncRequired
		{
			get
			{
				if (this.sync == MusicChannelSync.Implicit)
				{
					return this.clip != null;
				}
				return this.sync == MusicChannelSync.ExplicitOn;
			}
		}

		// Token: 0x04000365 RID: 869
		[SerializeField]
		private AudioClip clip;

		// Token: 0x04000366 RID: 870
		[SerializeField]
		private MusicChannelSync sync;
	}

	// Token: 0x020000B9 RID: 185
	[Serializable]
	public struct Alternative
	{
		// Token: 0x04000367 RID: 871
		public string PlayerDataBoolKey;

		// Token: 0x04000368 RID: 872
		public MusicCue Cue;
	}
}
