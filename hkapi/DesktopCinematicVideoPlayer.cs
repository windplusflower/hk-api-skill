using System;
using System.IO;
using UnityEngine;

// Token: 0x0200006D RID: 109
public class DesktopCinematicVideoPlayer : EmbeddedCinematicVideoPlayer
{
	// Token: 0x0600024C RID: 588 RVA: 0x0000D836 File Offset: 0x0000BA36
	public DesktopCinematicVideoPlayer(CinematicVideoPlayerConfig config) : base(config)
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x0000D840 File Offset: 0x0000BA40
	protected override string GetAbsolutePath()
	{
		RuntimePlatform platform = Application.platform;
		if (platform <= RuntimePlatform.WindowsPlayer)
		{
			if (platform <= RuntimePlatform.OSXPlayer)
			{
				goto IL_28;
			}
			if (platform != RuntimePlatform.WindowsPlayer)
			{
				goto IL_28;
			}
		}
		else if (platform != RuntimePlatform.WindowsEditor)
		{
			if (platform != RuntimePlatform.LinuxPlayer && platform != RuntimePlatform.LinuxEditor)
			{
				goto IL_28;
			}
			goto IL_28;
		}
		CinematicFormats format = CinematicFormats.MP4_H264_1080_Any_AAC_48000;
		goto IL_2A;
		IL_28:
		format = CinematicFormats.WEBM_VP8_1080_Any_Vorbis_48000;
		IL_2A:
		return Path.GetFullPath(Path.Combine(Application.streamingAssetsPath, base.Config.VideoReference.VideoFileName + CinematicFormatUtils.GetExtension(format)));
	}
}
