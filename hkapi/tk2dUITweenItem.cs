using System;
using System.Collections;
using UnityEngine;

// Token: 0x020005AD RID: 1453
[AddComponentMenu("2D Toolkit/UI/tk2dUITweenItem")]
public class tk2dUITweenItem : tk2dUIBaseItemControl
{
	// Token: 0x17000442 RID: 1090
	// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000A4E27 File Offset: 0x000A3027
	public bool UseOnReleaseInsteadOfOnUp
	{
		get
		{
			return this.useOnReleaseInsteadOfOnUp;
		}
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000A4E2F File Offset: 0x000A302F
	private void Awake()
	{
		this.onUpScale = base.transform.localScale;
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000A4E44 File Offset: 0x000A3044
	private void OnEnable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown += this.ButtonDown;
			if (this.canButtonBeHeldDown)
			{
				if (this.useOnReleaseInsteadOfOnUp)
				{
					this.uiItem.OnRelease += this.ButtonUp;
				}
				else
				{
					this.uiItem.OnUp += this.ButtonUp;
				}
			}
		}
		this.internalTweenInProgress = false;
		this.tweenTimeElapsed = 0f;
		base.transform.localScale = this.onUpScale;
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000A4ED8 File Offset: 0x000A30D8
	private void OnDisable()
	{
		if (this.uiItem)
		{
			this.uiItem.OnDown -= this.ButtonDown;
			if (this.canButtonBeHeldDown)
			{
				if (this.useOnReleaseInsteadOfOnUp)
				{
					this.uiItem.OnRelease -= this.ButtonUp;
					return;
				}
				this.uiItem.OnUp -= this.ButtonUp;
			}
		}
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000A4F48 File Offset: 0x000A3148
	private void ButtonDown()
	{
		if (this.tweenDuration <= 0f)
		{
			base.transform.localScale = this.onDownScale;
			return;
		}
		base.transform.localScale = this.onUpScale;
		this.tweenTargetScale = this.onDownScale;
		this.tweenStartingScale = base.transform.localScale;
		if (!this.internalTweenInProgress)
		{
			base.StartCoroutine(this.ScaleTween());
			this.internalTweenInProgress = true;
		}
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000A4FC0 File Offset: 0x000A31C0
	private void ButtonUp()
	{
		if (this.tweenDuration <= 0f)
		{
			base.transform.localScale = this.onUpScale;
			return;
		}
		this.tweenTargetScale = this.onUpScale;
		this.tweenStartingScale = base.transform.localScale;
		if (!this.internalTweenInProgress)
		{
			base.StartCoroutine(this.ScaleTween());
			this.internalTweenInProgress = true;
		}
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000A5025 File Offset: 0x000A3225
	private IEnumerator ScaleTween()
	{
		this.tweenTimeElapsed = 0f;
		while (this.tweenTimeElapsed < this.tweenDuration)
		{
			this.transform.localScale = Vector3.Lerp(this.tweenStartingScale, this.tweenTargetScale, this.tweenTimeElapsed / this.tweenDuration);
			yield return null;
			this.tweenTimeElapsed += tk2dUITime.deltaTime;
		}
		this.transform.localScale = this.tweenTargetScale;
		this.internalTweenInProgress = false;
		if (!this.canButtonBeHeldDown)
		{
			if (this.tweenDuration <= 0f)
			{
				this.transform.localScale = this.onUpScale;
			}
			else
			{
				this.tweenTargetScale = this.onUpScale;
				this.tweenStartingScale = this.transform.localScale;
				this.StartCoroutine(this.ScaleTween());
				this.internalTweenInProgress = true;
			}
		}
		yield break;
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000A5034 File Offset: 0x000A3234
	public void InternalSetUseOnReleaseInsteadOfOnUp(bool state)
	{
		this.useOnReleaseInsteadOfOnUp = state;
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000A5040 File Offset: 0x000A3240
	public tk2dUITweenItem()
	{
		this.onDownScale = new Vector3(0.9f, 0.9f, 0.9f);
		this.tweenDuration = 0.1f;
		this.canButtonBeHeldDown = true;
		this.tweenTargetScale = Vector3.one;
		this.tweenStartingScale = Vector3.one;
		base..ctor();
	}

	// Token: 0x0400265F RID: 9823
	private Vector3 onUpScale;

	// Token: 0x04002660 RID: 9824
	public Vector3 onDownScale;

	// Token: 0x04002661 RID: 9825
	public float tweenDuration;

	// Token: 0x04002662 RID: 9826
	public bool canButtonBeHeldDown;

	// Token: 0x04002663 RID: 9827
	[SerializeField]
	private bool useOnReleaseInsteadOfOnUp;

	// Token: 0x04002664 RID: 9828
	private bool internalTweenInProgress;

	// Token: 0x04002665 RID: 9829
	private Vector3 tweenTargetScale;

	// Token: 0x04002666 RID: 9830
	private Vector3 tweenStartingScale;

	// Token: 0x04002667 RID: 9831
	private float tweenTimeElapsed;
}
