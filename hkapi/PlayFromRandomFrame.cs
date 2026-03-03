using System;
using UnityEngine;

// Token: 0x02000082 RID: 130
[RequireComponent(typeof(tk2dSpriteAnimator))]
public class PlayFromRandomFrame : MonoBehaviour
{
	// Token: 0x060002CC RID: 716 RVA: 0x0000F790 File Offset: 0x0000D990
	private void Start()
	{
		int frame = UnityEngine.Random.Range(0, this.frameCount);
		this.animator = base.GetComponent<tk2dSpriteAnimator>();
		this.animator.PlayFromFrame(frame);
	}

	// Token: 0x04000250 RID: 592
	[Tooltip("Number of frames in animation.")]
	public int frameCount;

	// Token: 0x04000251 RID: 593
	private tk2dSpriteAnimator animator;
}
