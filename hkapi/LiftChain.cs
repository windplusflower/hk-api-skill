using System;
using UnityEngine;

// Token: 0x02000518 RID: 1304
[DisallowMultipleComponent]
public class LiftChain : MonoBehaviour
{
	// Token: 0x06001CAD RID: 7341 RVA: 0x00085FE2 File Offset: 0x000841E2
	protected void Awake()
	{
		this.spriteAnimators = base.GetComponentsInChildren<tk2dSpriteAnimator>();
		this.currentDirection = 0;
	}

	// Token: 0x06001CAE RID: 7342 RVA: 0x00085FF8 File Offset: 0x000841F8
	public void GoDown()
	{
		Debug.LogFormat(this, "Chain {0} going down.", new object[]
		{
			base.name
		});
		for (int i = 0; i < this.spriteAnimators.Length; i++)
		{
			tk2dSpriteAnimator tk2dSpriteAnimator = this.spriteAnimators[i];
			tk2dSpriteAnimator.Resume();
			if (this.currentDirection != -1)
			{
				tk2dSpriteAnimator.Play("Chain Down");
			}
		}
		this.currentDirection = -1;
	}

	// Token: 0x06001CAF RID: 7343 RVA: 0x0008605C File Offset: 0x0008425C
	public void GoUp()
	{
		Debug.LogFormat(this, "Chain {0} going up.", new object[]
		{
			base.name
		});
		for (int i = 0; i < this.spriteAnimators.Length; i++)
		{
			tk2dSpriteAnimator tk2dSpriteAnimator = this.spriteAnimators[i];
			tk2dSpriteAnimator.Resume();
			if (this.currentDirection != 1)
			{
				tk2dSpriteAnimator.Play("Chain Up");
			}
		}
		this.currentDirection = 1;
	}

	// Token: 0x06001CB0 RID: 7344 RVA: 0x000860C0 File Offset: 0x000842C0
	public void Stop()
	{
		Debug.LogFormat(this, "Chain {0} stopping.", new object[]
		{
			base.name
		});
		for (int i = 0; i < this.spriteAnimators.Length; i++)
		{
			this.spriteAnimators[i].Pause();
		}
	}

	// Token: 0x0400222D RID: 8749
	private tk2dSpriteAnimator[] spriteAnimators;

	// Token: 0x0400222E RID: 8750
	private int currentDirection;
}
