using System;

// Token: 0x02000069 RID: 105
public static class CinematicFormatUtils
{
	// Token: 0x0600022B RID: 555 RVA: 0x0000D4ED File Offset: 0x0000B6ED
	public static string GetExtension(CinematicFormats format)
	{
		if (format <= CinematicFormats.MP4_H264_1080_Any_AAC_48000)
		{
			return ".mp4";
		}
		if (format != CinematicFormats.WEBM_VP8_1080_Any_Vorbis_48000)
		{
			return "";
		}
		return ".webm";
	}
}
