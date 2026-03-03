using System;
using UnityEngine;

// Token: 0x02000460 RID: 1120
public class InvAnimateUpAndDown : MonoBehaviour
{
	// Token: 0x06001935 RID: 6453 RVA: 0x0007880D File Offset: 0x00076A0D
	private void Awake()
	{
		this.spriteAnimator = base.GetComponent<tk2dSpriteAnimator>();
		this.meshRenderer = base.GetComponent<MeshRenderer>();
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x00078828 File Offset: 0x00076A28
	private void Update()
	{
		if (this.animatingDown && !this.spriteAnimator.Playing)
		{
			this.meshRenderer.enabled = false;
			this.animatingDown = false;
		}
		if (this.timer > 0f)
		{
			this.timer -= Time.deltaTime;
		}
		if (this.readyingAnimUp && this.timer <= 0f)
		{
			this.animatingDown = false;
			this.meshRenderer.enabled = true;
			if (this.randomStartFrameSpriteMax > 0)
			{
				int frame = UnityEngine.Random.Range(0, this.randomStartFrameSpriteMax);
				this.spriteAnimator.PlayFromFrame(this.upAnimation, frame);
			}
			else
			{
				this.spriteAnimator.Play(this.upAnimation);
			}
			this.readyingAnimUp = false;
		}
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x000788E6 File Offset: 0x00076AE6
	public void AnimateUp()
	{
		this.readyingAnimUp = true;
		this.timer = this.upDelay;
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x000788FB File Offset: 0x00076AFB
	public void AnimateDown()
	{
		this.spriteAnimator.Play(this.downAnimation);
		this.animatingDown = true;
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x00078915 File Offset: 0x00076B15
	public void ReplayUpAnim()
	{
		this.meshRenderer.enabled = true;
		this.spriteAnimator.PlayFromFrame(0);
	}

	// Token: 0x04001E40 RID: 7744
	public string upAnimation;

	// Token: 0x04001E41 RID: 7745
	public string downAnimation;

	// Token: 0x04001E42 RID: 7746
	public float upDelay;

	// Token: 0x04001E43 RID: 7747
	public int randomStartFrameSpriteMax;

	// Token: 0x04001E44 RID: 7748
	private tk2dSpriteAnimator spriteAnimator;

	// Token: 0x04001E45 RID: 7749
	private MeshRenderer meshRenderer;

	// Token: 0x04001E46 RID: 7750
	private float timer;

	// Token: 0x04001E47 RID: 7751
	private bool animatingDown;

	// Token: 0x04001E48 RID: 7752
	private bool readyingAnimUp;
}
