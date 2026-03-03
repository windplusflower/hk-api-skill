using System;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x020000C2 RID: 194
public class RegionSetAudio : MonoBehaviour
{
	// Token: 0x06000402 RID: 1026 RVA: 0x00014214 File Offset: 0x00012414
	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if (!this.entered)
		{
			if (this.atmosSnapshotEnter != null)
			{
				this.atmosSnapshotEnter.TransitionTo(this.transitionTime);
			}
			if (this.enviroSnapshotEnter != null)
			{
				this.enviroSnapshotEnter.TransitionTo(this.transitionTime);
			}
			this.entered = true;
		}
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00014270 File Offset: 0x00012470
	private void OnTriggerStay2D(Collider2D otherCollider)
	{
		if (!this.entered)
		{
			if (this.atmosSnapshotEnter != null)
			{
				this.atmosSnapshotEnter.TransitionTo(this.transitionTime);
			}
			if (this.enviroSnapshotEnter != null)
			{
				this.enviroSnapshotEnter.TransitionTo(this.transitionTime);
			}
			this.entered = true;
		}
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x000142CC File Offset: 0x000124CC
	private void OnTriggerExit2D(Collider2D otherCollider)
	{
		if (this.entered)
		{
			if (this.atmosSnapshotExit != null)
			{
				this.atmosSnapshotExit.TransitionTo(this.transitionTime);
			}
			if (this.enviroSnapshotExit != null)
			{
				this.enviroSnapshotExit.TransitionTo(this.transitionTime);
			}
			this.entered = false;
		}
	}

	// Token: 0x04000384 RID: 900
	public AudioMixerSnapshot atmosSnapshotEnter;

	// Token: 0x04000385 RID: 901
	public AudioMixerSnapshot enviroSnapshotEnter;

	// Token: 0x04000386 RID: 902
	public AudioMixerSnapshot atmosSnapshotExit;

	// Token: 0x04000387 RID: 903
	public AudioMixerSnapshot enviroSnapshotExit;

	// Token: 0x04000388 RID: 904
	public float transitionTime;

	// Token: 0x04000389 RID: 905
	private bool entered;
}
