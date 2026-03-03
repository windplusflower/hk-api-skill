using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000475 RID: 1141
public class LoadingSpinner : MonoBehaviour
{
	// Token: 0x17000325 RID: 805
	// (get) Token: 0x0600199C RID: 6556 RVA: 0x00079FDD File Offset: 0x000781DD
	// (set) Token: 0x0600199D RID: 6557 RVA: 0x00079FE5 File Offset: 0x000781E5
	public float DisplayDelayAdjustment
	{
		get
		{
			return this.displayDelayAdjustment;
		}
		set
		{
			this.displayDelayAdjustment = value;
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x0600199E RID: 6558 RVA: 0x00079FEE File Offset: 0x000781EE
	public float DisplayDelay
	{
		get
		{
			return this.displayDelay + this.displayDelayAdjustment;
		}
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x00079FFD File Offset: 0x000781FD
	protected void OnEnable()
	{
		this.fadeFactor = 0f;
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x0007A00A File Offset: 0x0007820A
	protected void Start()
	{
		this.image.color = new Color(1f, 1f, 1f, 0f);
		this.image.enabled = false;
		this.fadeFactor = 0f;
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x0007A048 File Offset: 0x00078248
	protected void Update()
	{
		float num = Mathf.Max(0.016666668f, Time.unscaledDeltaTime);
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (unsafeInstance != null)
		{
			float target = (unsafeInstance.CurrentLoadDuration > this.DisplayDelay && !unsafeInstance.IsUsingCustomLoadAnimation) ? 1f : 0f;
			this.fadeFactor = Mathf.MoveTowards(this.fadeFactor, target, num / this.fadeDuration);
			if (this.fadeFactor < Mathf.Epsilon)
			{
				if (this.image.enabled)
				{
					this.image.enabled = false;
				}
			}
			else
			{
				if (!this.image.enabled)
				{
					this.image.enabled = true;
				}
				this.image.color = new Color(1f, 1f, 1f, this.fadeFactor * (this.fadeAmount + this.fadeVariance * Mathf.Sin(unsafeInstance.CurrentLoadDuration * 3.1415927f * 2f / this.fadePulseDuration)));
			}
		}
		if (this.sprites.Length != 0)
		{
			this.frameTimer += num * this.frameRate;
			int num2 = (int)this.frameTimer;
			if (num2 > 0)
			{
				this.frameTimer -= (float)num2;
				this.frameIndex = (this.frameIndex + num2) % this.sprites.Length;
				this.image.sprite = this.sprites[this.frameIndex];
			}
		}
	}

	// Token: 0x04001EC4 RID: 7876
	[SerializeField]
	private Image image;

	// Token: 0x04001EC5 RID: 7877
	[SerializeField]
	private float displayDelay;

	// Token: 0x04001EC6 RID: 7878
	[SerializeField]
	private float fadeDuration;

	// Token: 0x04001EC7 RID: 7879
	[SerializeField]
	private float fadeAmount;

	// Token: 0x04001EC8 RID: 7880
	[SerializeField]
	private float fadeVariance;

	// Token: 0x04001EC9 RID: 7881
	[SerializeField]
	private float fadePulseDuration;

	// Token: 0x04001ECA RID: 7882
	[SerializeField]
	private Sprite[] sprites;

	// Token: 0x04001ECB RID: 7883
	[SerializeField]
	private float frameRate;

	// Token: 0x04001ECC RID: 7884
	private float fadeFactor;

	// Token: 0x04001ECD RID: 7885
	private float frameTimer;

	// Token: 0x04001ECE RID: 7886
	private int frameIndex;

	// Token: 0x04001ECF RID: 7887
	private float displayDelayAdjustment;
}
