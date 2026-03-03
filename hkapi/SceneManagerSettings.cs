using System;
using GlobalEnums;
using UnityEngine;

// Token: 0x0200052C RID: 1324
[Serializable]
public class SceneManagerSettings
{
	// Token: 0x06001D0E RID: 7438 RVA: 0x00087390 File Offset: 0x00085590
	public SceneManagerSettings(MapZone mapZone, Color defaultColor, float defaultIntensity, float saturation, AnimationCurve redChannel, AnimationCurve greenChannel, AnimationCurve blueChannel, Color heroLightColor)
	{
		this.mapZone = mapZone;
		this.defaultColor = defaultColor;
		this.defaultIntensity = defaultIntensity;
		this.saturation = saturation;
		this.redChannel = redChannel;
		this.greenChannel = greenChannel;
		this.blueChannel = blueChannel;
		this.heroLightColor = heroLightColor;
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x0000310E File Offset: 0x0000130E
	public SceneManagerSettings()
	{
	}

	// Token: 0x04002279 RID: 8825
	[SerializeField]
	public MapZone mapZone;

	// Token: 0x0400227A RID: 8826
	[SerializeField]
	public Color defaultColor;

	// Token: 0x0400227B RID: 8827
	public float defaultIntensity;

	// Token: 0x0400227C RID: 8828
	public float saturation;

	// Token: 0x0400227D RID: 8829
	[SerializeField]
	public AnimationCurve redChannel;

	// Token: 0x0400227E RID: 8830
	[SerializeField]
	public AnimationCurve greenChannel;

	// Token: 0x0400227F RID: 8831
	[SerializeField]
	public AnimationCurve blueChannel;

	// Token: 0x04002280 RID: 8832
	[SerializeField]
	public Color heroLightColor;
}
