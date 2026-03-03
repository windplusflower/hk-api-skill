using System;
using UnityEngine;

// Token: 0x0200005A RID: 90
public class ChainSequence : SkippableSequence
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000C236 File Offset: 0x0000A436
	private SkippableSequence CurrentSequence
	{
		get
		{
			if (this.currentSequenceIndex < 0 || this.currentSequenceIndex >= this.sequences.Length)
			{
				return null;
			}
			return this.sequences[this.currentSequenceIndex];
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000C260 File Offset: 0x0000A460
	public bool IsCurrentSkipped
	{
		get
		{
			return this.CurrentSequence != null && this.CurrentSequence.IsSkipped;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000C27D File Offset: 0x0000A47D
	public override bool IsSkipped
	{
		get
		{
			return this.isSkipped;
		}
	}

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x060001E5 RID: 485 RVA: 0x0000C288 File Offset: 0x0000A488
	// (remove) Token: 0x060001E6 RID: 486 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
	public event ChainSequence.TransitionedToNextSequenceDelegate TransitionedToNextSequence;

	// Token: 0x060001E7 RID: 487 RVA: 0x0000C2F5 File Offset: 0x0000A4F5
	protected void Awake()
	{
		this.fadeByController = 1f;
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0000C302 File Offset: 0x0000A502
	protected void Update()
	{
		if (this.CurrentSequence != null && !this.CurrentSequence.IsPlaying && !this.isSkipped)
		{
			this.Next();
		}
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0000C32D File Offset: 0x0000A52D
	public override void Begin()
	{
		this.isSkipped = false;
		this.currentSequenceIndex = -1;
		this.Next();
	}

	// Token: 0x060001EA RID: 490 RVA: 0x0000C344 File Offset: 0x0000A544
	private void Next()
	{
		SkippableSequence currentSequence = this.CurrentSequence;
		if (currentSequence != null)
		{
			currentSequence.gameObject.SetActive(false);
		}
		this.currentSequenceIndex++;
		if (!this.isSkipped)
		{
			if (this.CurrentSequence != null)
			{
				this.CurrentSequence.gameObject.SetActive(true);
				this.CurrentSequence.Begin();
			}
			if (this.TransitionedToNextSequence != null)
			{
				this.TransitionedToNextSequence();
			}
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060001EB RID: 491 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
	public override bool IsPlaying
	{
		get
		{
			return this.currentSequenceIndex < this.sequences.Length - 1 || (!(this.CurrentSequence == null) && this.CurrentSequence.IsPlaying);
		}
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
	public override void Skip()
	{
		this.isSkipped = true;
		for (int i = 0; i < this.sequences.Length; i++)
		{
			this.sequences[i].Skip();
		}
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000C428 File Offset: 0x0000A628
	public void SkipSingle()
	{
		if (this.CurrentSequence != null)
		{
			this.CurrentSequence.Skip();
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060001EE RID: 494 RVA: 0x0000C443 File Offset: 0x0000A643
	// (set) Token: 0x060001EF RID: 495 RVA: 0x0000C44C File Offset: 0x0000A64C
	public override float FadeByController
	{
		get
		{
			return this.fadeByController;
		}
		set
		{
			this.fadeByController = Mathf.Clamp01(value);
			for (int i = 0; i < this.sequences.Length; i++)
			{
				this.sequences[i].FadeByController = this.fadeByController;
			}
		}
	}

	// Token: 0x0400017F RID: 383
	[SerializeField]
	private SkippableSequence[] sequences;

	// Token: 0x04000180 RID: 384
	private int currentSequenceIndex;

	// Token: 0x04000181 RID: 385
	private float fadeByController;

	// Token: 0x04000182 RID: 386
	private bool isSkipped;

	// Token: 0x0200005B RID: 91
	// (Invoke) Token: 0x060001F2 RID: 498
	public delegate void TransitionedToNextSequenceDelegate();
}
