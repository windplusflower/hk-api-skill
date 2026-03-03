using System;
using UnityEngine;

// Token: 0x02000123 RID: 291
public class BeatControl : MonoBehaviour
{
	// Token: 0x060006BD RID: 1725 RVA: 0x00027390 File Offset: 0x00025590
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.B))
		{
			this.beatIncrease += 0.25f;
		}
		if (this.beatIncrease != this.oldBeatValue)
		{
			this.oldBeatValue = this.beatIncrease;
			Shader.SetGlobalFloat("_BeatSpeedIncrease", this.beatIncrease);
			Shader.SetGlobalFloat("_BeatMagnitudeIncrease", this.beatIncrease);
		}
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x000273F2 File Offset: 0x000255F2
	private void OnDestroy()
	{
		Shader.SetGlobalFloat("_BeatSpeedIncrease", 0f);
		Shader.SetGlobalFloat("_BeatMagnitudeIncrease", 0f);
	}

	// Token: 0x04000759 RID: 1881
	public float beatIncrease;

	// Token: 0x0400075A RID: 1882
	private float oldBeatValue;
}
