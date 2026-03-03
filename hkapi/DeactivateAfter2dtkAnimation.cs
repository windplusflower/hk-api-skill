using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class DeactivateAfter2dtkAnimation : MonoBehaviour
{
	// Token: 0x06000269 RID: 617 RVA: 0x0000DCC5 File Offset: 0x0000BEC5
	private void OnEnable()
	{
		this.timer = 0f;
		if (this.spriteAnimator == null)
		{
			this.spriteAnimator = base.GetComponent<tk2dSpriteAnimator>();
		}
		this.spriteAnimator.PlayFromFrame(0);
	}

	// Token: 0x0600026A RID: 618 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
	private void Update()
	{
		if (this.timer > 0.1f)
		{
			this.timer -= Time.deltaTime;
			return;
		}
		if (!this.spriteAnimator.Playing)
		{
			base.gameObject.SetActive(false);
		}
	}

	// Token: 0x04000205 RID: 517
	public tk2dSpriteAnimator spriteAnimator;

	// Token: 0x04000206 RID: 518
	private float timer;
}
