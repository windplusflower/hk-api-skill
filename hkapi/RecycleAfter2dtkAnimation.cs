using System;
using UnityEngine;

// Token: 0x02000086 RID: 134
public class RecycleAfter2dtkAnimation : MonoBehaviour
{
	// Token: 0x060002DC RID: 732 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
	private void OnEnable()
	{
		this.timer = 0f;
		if (this.spriteAnimator == null)
		{
			this.spriteAnimator = base.GetComponent<tk2dSpriteAnimator>();
		}
		if (this.randomiseRotation)
		{
			base.transform.eulerAngles = new Vector3(base.transform.rotation.x, base.transform.rotation.y, (float)UnityEngine.Random.Range(0, 360));
		}
		this.spriteAnimator.PlayFromFrame(0);
	}

	// Token: 0x060002DD RID: 733 RVA: 0x0000F942 File Offset: 0x0000DB42
	private void Update()
	{
		if (this.timer > 0.1f)
		{
			this.timer -= Time.deltaTime;
			return;
		}
		if (!this.spriteAnimator.Playing)
		{
			base.gameObject.Recycle();
		}
	}

	// Token: 0x04000258 RID: 600
	public tk2dSpriteAnimator spriteAnimator;

	// Token: 0x04000259 RID: 601
	public bool randomiseRotation;

	// Token: 0x0400025A RID: 602
	private float timer;
}
