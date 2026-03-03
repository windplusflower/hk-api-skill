using System;
using UnityEngine;

// Token: 0x02000056 RID: 86
public class AnimatorSequence : SkippableSequence
{
	// Token: 0x060001C2 RID: 450 RVA: 0x0000BEF1 File Offset: 0x0000A0F1
	protected void Awake()
	{
		this.fadeByController = 1f;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0000BF00 File Offset: 0x0000A100
	protected void Update()
	{
		if (this.animator.isActiveAndEnabled && this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= Mathf.Min(this.normalizedFinishTime, 1f - Mathf.Epsilon))
		{
			this.animator.gameObject.SetActive(false);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x0000BF57 File Offset: 0x0000A157
	public override void Begin()
	{
		this.animator.gameObject.SetActive(true);
		this.animator.Play(this.animatorStateName, 0, 0f);
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000BF84 File Offset: 0x0000A184
	public override bool IsPlaying
	{
		get
		{
			return this.animator.isActiveAndEnabled && this.animator.GetCurrentAnimatorStateInfo(0).normalizedTime < Mathf.Min(this.normalizedFinishTime, 1f - Mathf.Epsilon);
		}
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0000BFCC File Offset: 0x0000A1CC
	public override void Skip()
	{
		this.isSkipped = true;
		this.animator.Update(1000f);
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000BFE5 File Offset: 0x0000A1E5
	public override bool IsSkipped
	{
		get
		{
			return this.isSkipped;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000BFED File Offset: 0x0000A1ED
	// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000BFF5 File Offset: 0x0000A1F5
	public override float FadeByController
	{
		get
		{
			return this.fadeByController;
		}
		set
		{
			this.fadeByController = value;
		}
	}

	// Token: 0x04000170 RID: 368
	[SerializeField]
	private Animator animator;

	// Token: 0x04000171 RID: 369
	[SerializeField]
	private string animatorStateName;

	// Token: 0x04000172 RID: 370
	[SerializeField]
	private float normalizedFinishTime;

	// Token: 0x04000173 RID: 371
	private float fadeByController;

	// Token: 0x04000174 RID: 372
	private bool isSkipped;
}
