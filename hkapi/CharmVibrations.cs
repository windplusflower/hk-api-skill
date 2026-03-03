using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000504 RID: 1284
public class CharmVibrations : MonoBehaviour
{
	// Token: 0x06001C4B RID: 7243 RVA: 0x00085775 File Offset: 0x00083975
	public void PlayRegularPlace()
	{
		this.PlayDelayedVibration(this.regularPlace);
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x00085783 File Offset: 0x00083983
	public void PlayFailedPlace()
	{
		this.PlayDelayedVibration(this.failedPlace);
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x00085791 File Offset: 0x00083991
	public void PlayOvercharmPlace()
	{
		this.PlayDelayedVibration(this.overcharmPlace);
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x0008579F File Offset: 0x0008399F
	public void PlayOvercharmHit()
	{
		this.PlayDelayedVibration(this.overcharmHit);
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x000857AD File Offset: 0x000839AD
	public void PlayOvercharmFinalHit()
	{
		this.PlayDelayedVibration(this.overcharmFinalHit);
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x000857BB File Offset: 0x000839BB
	protected void PlayDelayedVibration(VibrationData vibrationData)
	{
		base.StartCoroutine(this.PlayDelayedVibrationRoutine(vibrationData));
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x000857CB File Offset: 0x000839CB
	protected IEnumerator PlayDelayedVibrationRoutine(VibrationData vibrationData)
	{
		yield return null;
		VibrationManager.PlayVibrationClipOneShot(vibrationData, new VibrationTarget?(new VibrationTarget(VibrationMotors.All)), false, "");
		yield break;
	}

	// Token: 0x040021FB RID: 8699
	[SerializeField]
	private VibrationData regularPlace;

	// Token: 0x040021FC RID: 8700
	[SerializeField]
	private VibrationData failedPlace;

	// Token: 0x040021FD RID: 8701
	[SerializeField]
	private VibrationData overcharmPlace;

	// Token: 0x040021FE RID: 8702
	[SerializeField]
	private VibrationData overcharmHit;

	// Token: 0x040021FF RID: 8703
	[SerializeField]
	private VibrationData overcharmFinalHit;
}
