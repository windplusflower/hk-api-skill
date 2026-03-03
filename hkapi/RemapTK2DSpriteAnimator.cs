using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000087 RID: 135
public class RemapTK2DSpriteAnimator : MonoBehaviour
{
	// Token: 0x060002DF RID: 735 RVA: 0x0000F97C File Offset: 0x0000DB7C
	private void Start()
	{
		if (this.sourceAnimator && this.targetAnimator)
		{
			this.shouldAnimate = true;
		}
		foreach (RemapTK2DSpriteAnimator.AnimationRemap animationRemap in this.animationsList)
		{
			this.animations[animationRemap.sourceClip] = animationRemap.targetClip;
		}
	}

	// Token: 0x060002E0 RID: 736 RVA: 0x0000FA00 File Offset: 0x0000DC00
	private void Update()
	{
		if (this.shouldAnimate)
		{
			string name = this.sourceAnimator.CurrentClip.name;
			if (name != this.lastSourceClip)
			{
				this.lastSourceClip = name;
				if (this.animations.ContainsKey(name))
				{
					this.targetAnimator.PlayFromFrame(this.animations[name], this.syncFrames ? this.sourceAnimator.CurrentFrame : 0);
				}
			}
		}
	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0000FA76 File Offset: 0x0000DC76
	public RemapTK2DSpriteAnimator()
	{
		this.syncFrames = true;
		this.animationsList = new List<RemapTK2DSpriteAnimator.AnimationRemap>();
		this.animations = new Dictionary<string, string>();
		base..ctor();
	}

	// Token: 0x0400025B RID: 603
	public tk2dSpriteAnimator sourceAnimator;

	// Token: 0x0400025C RID: 604
	public tk2dSpriteAnimator targetAnimator;

	// Token: 0x0400025D RID: 605
	public bool syncFrames;

	// Token: 0x0400025E RID: 606
	public List<RemapTK2DSpriteAnimator.AnimationRemap> animationsList;

	// Token: 0x0400025F RID: 607
	private Dictionary<string, string> animations;

	// Token: 0x04000260 RID: 608
	private bool shouldAnimate;

	// Token: 0x04000261 RID: 609
	private string lastSourceClip;

	// Token: 0x02000088 RID: 136
	[Serializable]
	public struct AnimationRemap
	{
		// Token: 0x04000262 RID: 610
		public string sourceClip;

		// Token: 0x04000263 RID: 611
		public string targetClip;
	}
}
