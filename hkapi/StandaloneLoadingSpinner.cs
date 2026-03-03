using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004BF RID: 1215
public class StandaloneLoadingSpinner : MonoBehaviour
{
	// Token: 0x06001AF5 RID: 6901 RVA: 0x000809EB File Offset: 0x0007EBEB
	public void Setup(GameManager lastGameManager)
	{
		this.lastGameManager = lastGameManager;
	}

	// Token: 0x06001AF6 RID: 6902 RVA: 0x000809F4 File Offset: 0x0007EBF4
	protected void OnEnable()
	{
		this.fadeFactor = 0f;
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x00080A04 File Offset: 0x0007EC04
	protected void Start()
	{
		this.image.color = new Color(1f, 1f, 1f, 0f);
		this.image.enabled = false;
		this.fadeFactor = 0f;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x00080A58 File Offset: 0x0007EC58
	protected void LateUpdate()
	{
		GameManager unsafeInstance = GameManager.UnsafeInstance;
		if (this.lastGameManager == null && unsafeInstance != null && (this.lastGameManager != unsafeInstance || this.lastGameManager == null) && !this.isComplete)
		{
			this.renderingCamera.enabled = false;
			this.isComplete = true;
		}
		this.timeRunning += Time.unscaledDeltaTime;
		float num = Mathf.Max(0.016666668f, Time.unscaledDeltaTime);
		float target = (this.timeRunning > this.displayDelay && !this.isComplete) ? 1f : 0f;
		this.fadeFactor = Mathf.MoveTowards(this.fadeFactor, target, num / this.fadeDuration);
		if (this.fadeFactor < Mathf.Epsilon)
		{
			if (this.image.enabled)
			{
				this.image.enabled = false;
			}
			if (this.isComplete)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
		else
		{
			if (!this.image.enabled)
			{
				this.image.enabled = true;
			}
			this.image.color = new Color(1f, 1f, 1f, this.fadeFactor * (this.fadeAmount + this.fadeVariance * Mathf.Sin(this.timeRunning * 3.1415927f * 2f / this.fadePulseDuration)));
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

	// Token: 0x04002045 RID: 8261
	[SerializeField]
	private Camera renderingCamera;

	// Token: 0x04002046 RID: 8262
	[SerializeField]
	private Image backgroundImage;

	// Token: 0x04002047 RID: 8263
	[SerializeField]
	private Image image;

	// Token: 0x04002048 RID: 8264
	[SerializeField]
	private float displayDelay;

	// Token: 0x04002049 RID: 8265
	[SerializeField]
	private float fadeDuration;

	// Token: 0x0400204A RID: 8266
	[SerializeField]
	private float fadeAmount;

	// Token: 0x0400204B RID: 8267
	[SerializeField]
	private float fadeVariance;

	// Token: 0x0400204C RID: 8268
	[SerializeField]
	private float fadePulseDuration;

	// Token: 0x0400204D RID: 8269
	[SerializeField]
	private Sprite[] sprites;

	// Token: 0x0400204E RID: 8270
	[SerializeField]
	private float frameRate;

	// Token: 0x0400204F RID: 8271
	private float fadeFactor;

	// Token: 0x04002050 RID: 8272
	private float frameTimer;

	// Token: 0x04002051 RID: 8273
	private int frameIndex;

	// Token: 0x04002052 RID: 8274
	private float timeRunning;

	// Token: 0x04002053 RID: 8275
	private bool isComplete;

	// Token: 0x04002054 RID: 8276
	private GameManager lastGameManager;
}
