using System;
using UnityEngine;

// Token: 0x02000076 RID: 118
public class FadeSequence : SkippableSequence
{
	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600026C RID: 620 RVA: 0x0000DD33 File Offset: 0x0000BF33
	public override bool IsSkipped
	{
		get
		{
			return this.childSequence.IsSkipped;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x0600026D RID: 621 RVA: 0x0000DD40 File Offset: 0x0000BF40
	public float FadeRate
	{
		get
		{
			return this.fadeRate;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600026E RID: 622 RVA: 0x0000DD48 File Offset: 0x0000BF48
	// (set) Token: 0x0600026F RID: 623 RVA: 0x0000DD50 File Offset: 0x0000BF50
	public override float FadeByController
	{
		get
		{
			return this.fadeByController;
		}
		set
		{
			this.fadeByController = value;
			this.UpdateFade();
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x06000270 RID: 624 RVA: 0x0000DD5F File Offset: 0x0000BF5F
	public override bool IsPlaying
	{
		get
		{
			return this.childSequence.IsPlaying || this.fade > Mathf.Epsilon;
		}
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000DD7D File Offset: 0x0000BF7D
	protected void Awake()
	{
		this.fade = 0f;
		this.timer = 0f;
		this.fadeByController = 1f;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
	public override void Begin()
	{
		this.fade = 0f;
		this.timer = 0f;
		this.UpdateFade();
		this.childSequence.Begin();
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000DDCC File Offset: 0x0000BFCC
	protected void Update()
	{
		if (this.childSequence.IsPlaying)
		{
			this.timer += Time.deltaTime;
		}
		float target;
		if (this.timer >= this.fadeDelay && this.childSequence.IsPlaying)
		{
			target = 1f;
		}
		else
		{
			target = 0f;
		}
		this.fade = Mathf.MoveTowards(this.fade, target, this.fadeRate * Time.unscaledDeltaTime);
		this.UpdateFade();
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0000DE45 File Offset: 0x0000C045
	public override void Skip()
	{
		this.childSequence.Skip();
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0000DE52 File Offset: 0x0000C052
	private void UpdateFade()
	{
		this.childSequence.FadeByController = Mathf.Clamp01(this.fade * this.fadeByController);
	}

	// Token: 0x04000207 RID: 519
	[SerializeField]
	private SkippableSequence childSequence;

	// Token: 0x04000208 RID: 520
	private float fade;

	// Token: 0x04000209 RID: 521
	private float fadeByController;

	// Token: 0x0400020A RID: 522
	[SerializeField]
	private float fadeDelay;

	// Token: 0x0400020B RID: 523
	private float timer;

	// Token: 0x0400020C RID: 524
	[SerializeField]
	private float fadeRate;
}
