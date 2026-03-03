using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200005C RID: 92
public class CheckpointSprite : MonoBehaviour
{
	// Token: 0x060001F5 RID: 501 RVA: 0x0000C48B File Offset: 0x0000A68B
	protected void Awake()
	{
		this.image = base.GetComponent<Image>();
		this.audioSource = base.GetComponent<AudioSource>();
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000C4A5 File Offset: 0x0000A6A5
	protected void OnEnable()
	{
		this.state = CheckpointSprite.States.NotStarted;
		this.image.enabled = false;
		this.Update(0f);
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00003603 File Offset: 0x00001803
	protected void Start()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000C4C5 File Offset: 0x0000A6C5
	public void Show()
	{
		this.isShowing = true;
		if (base.isActiveAndEnabled)
		{
			this.Update(0f);
		}
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000C4E1 File Offset: 0x0000A6E1
	public void Hide()
	{
		this.isShowing = false;
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000C4EA File Offset: 0x0000A6EA
	protected void Update()
	{
		this.Update(Mathf.Min(0.016666668f, Time.unscaledDeltaTime));
	}

	// Token: 0x060001FB RID: 507 RVA: 0x0000C504 File Offset: 0x0000A704
	private void Update(float deltaTime)
	{
		bool flag = false;
		this.frameTimer += deltaTime * this.framesPerSecond;
		if (this.state == CheckpointSprite.States.NotStarted && this.isShowing)
		{
			this.frameTimer = 0f;
			this.state = CheckpointSprite.States.Starting;
			this.audioSource.Play();
			this.image.enabled = true;
		}
		if (this.state == CheckpointSprite.States.Starting)
		{
			int num = (int)this.frameTimer;
			if (num < this.startSprites.Length)
			{
				this.image.sprite = this.startSprites[num];
			}
			else
			{
				this.frameTimer -= (float)this.startSprites.Length;
				if (this.isShowing || flag)
				{
					this.state = CheckpointSprite.States.Looping;
				}
				else
				{
					this.state = CheckpointSprite.States.Ending;
				}
			}
		}
		if (this.state == CheckpointSprite.States.Looping)
		{
			int num2 = (int)this.frameTimer;
			if (num2 >= this.loopSprites.Length)
			{
				this.frameTimer -= (float)(this.loopSprites.Length * (num2 / this.loopSprites.Length));
				if (!this.isShowing && !flag)
				{
					this.state = CheckpointSprite.States.Ending;
				}
				else
				{
					this.image.sprite = this.loopSprites[num2 % this.loopSprites.Length];
				}
			}
			else
			{
				this.image.sprite = this.loopSprites[num2];
			}
		}
		if (this.state == CheckpointSprite.States.Ending)
		{
			int num3 = (int)this.frameTimer;
			if (num3 < this.endSprites.Length)
			{
				this.image.sprite = this.endSprites[num3];
				return;
			}
			this.image.enabled = false;
			this.state = CheckpointSprite.States.NotStarted;
		}
	}

	// Token: 0x04000184 RID: 388
	private Image image;

	// Token: 0x04000185 RID: 389
	private AudioSource audioSource;

	// Token: 0x04000186 RID: 390
	[SerializeField]
	private Sprite[] startSprites;

	// Token: 0x04000187 RID: 391
	[SerializeField]
	private Sprite[] loopSprites;

	// Token: 0x04000188 RID: 392
	[SerializeField]
	private Sprite[] endSprites;

	// Token: 0x04000189 RID: 393
	[SerializeField]
	private float framesPerSecond;

	// Token: 0x0400018A RID: 394
	private bool isShowing;

	// Token: 0x0400018B RID: 395
	private CheckpointSprite.States state;

	// Token: 0x0400018C RID: 396
	private float frameTimer;

	// Token: 0x0200005D RID: 93
	private enum States
	{
		// Token: 0x0400018E RID: 398
		NotStarted,
		// Token: 0x0400018F RID: 399
		Starting,
		// Token: 0x04000190 RID: 400
		Looping,
		// Token: 0x04000191 RID: 401
		Ending
	}
}
