using System;

// Token: 0x0200050D RID: 1293
public abstract class VibrationMixer
{
	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06001C75 RID: 7285
	// (set) Token: 0x06001C76 RID: 7286
	public abstract bool IsPaused { get; set; }

	// Token: 0x06001C77 RID: 7287
	public abstract VibrationEmission PlayEmission(VibrationData vibrationData, VibrationTarget vibrationTarget, bool isLooping, string tag);

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06001C78 RID: 7288
	public abstract int PlayingEmissionCount { get; }

	// Token: 0x06001C79 RID: 7289
	public abstract VibrationEmission GetPlayingEmission(int playingEmissionIndex);

	// Token: 0x06001C7A RID: 7290
	public abstract void StopAllEmissions();

	// Token: 0x06001C7B RID: 7291
	public abstract void StopAllEmissionsWithTag(string tag);
}
