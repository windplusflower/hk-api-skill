using System;
using UnityEngine;

// Token: 0x02000507 RID: 1287
public class VibrationEffect : MonoBehaviour
{
	// Token: 0x06001C60 RID: 7264 RVA: 0x00085905 File Offset: 0x00083B05
	protected void OnEnable()
	{
		VibrationManager.PlayVibrationClipOneShot(this.vibrationData, new VibrationTarget?(this.vibrationSource), false, "");
	}

	// Token: 0x04002206 RID: 8710
	[SerializeField]
	private VibrationData vibrationData;

	// Token: 0x04002207 RID: 8711
	[SerializeField]
	private VibrationTarget vibrationSource;
}
