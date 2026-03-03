using System;
using UnityEngine;

// Token: 0x020005A3 RID: 1443
[AddComponentMenu("2D Toolkit/UI/tk2dUIProgressBar")]
public class tk2dUIProgressBar : MonoBehaviour
{
	// Token: 0x1400004B RID: 75
	// (add) Token: 0x06002039 RID: 8249 RVA: 0x000A20DC File Offset: 0x000A02DC
	// (remove) Token: 0x0600203A RID: 8250 RVA: 0x000A2114 File Offset: 0x000A0314
	public event Action OnProgressComplete;

	// Token: 0x0600203B RID: 8251 RVA: 0x000A2149 File Offset: 0x000A0349
	private void Start()
	{
		this.InitializeSlicedSpriteDimensions();
		this.Value = this.percent;
	}

	// Token: 0x1700042E RID: 1070
	// (get) Token: 0x0600203C RID: 8252 RVA: 0x000A215D File Offset: 0x000A035D
	// (set) Token: 0x0600203D RID: 8253 RVA: 0x000A2168 File Offset: 0x000A0368
	public float Value
	{
		get
		{
			return this.percent;
		}
		set
		{
			this.percent = Mathf.Clamp(value, 0f, 1f);
			if (Application.isPlaying)
			{
				if (this.clippedSpriteBar != null)
				{
					this.clippedSpriteBar.clipTopRight = new Vector2(this.Value, 1f);
				}
				else if (this.scalableBar != null)
				{
					this.scalableBar.localScale = new Vector3(this.Value, this.scalableBar.localScale.y, this.scalableBar.localScale.z);
				}
				else if (this.slicedSpriteBar != null)
				{
					this.InitializeSlicedSpriteDimensions();
					float newX = Mathf.Lerp(this.emptySlicedSpriteDimensions.x, this.fullSlicedSpriteDimensions.x, this.Value);
					this.currentDimensions.Set(newX, this.fullSlicedSpriteDimensions.y);
					this.slicedSpriteBar.dimensions = this.currentDimensions;
				}
				if (!this.isProgressComplete && this.Value == 1f)
				{
					this.isProgressComplete = true;
					if (this.OnProgressComplete != null)
					{
						this.OnProgressComplete();
					}
					if (this.sendMessageTarget != null && this.SendMessageOnProgressCompleteMethodName.Length > 0)
					{
						this.sendMessageTarget.SendMessage(this.SendMessageOnProgressCompleteMethodName, this, SendMessageOptions.RequireReceiver);
						return;
					}
				}
				else if (this.isProgressComplete && this.Value < 1f)
				{
					this.isProgressComplete = false;
				}
			}
		}
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000A22E4 File Offset: 0x000A04E4
	private void InitializeSlicedSpriteDimensions()
	{
		if (!this.initializedSlicedSpriteDimensions)
		{
			if (this.slicedSpriteBar != null)
			{
				tk2dSpriteDefinition currentSprite = this.slicedSpriteBar.CurrentSprite;
				Vector3 vector = currentSprite.boundsData[1];
				this.fullSlicedSpriteDimensions = this.slicedSpriteBar.dimensions;
				this.emptySlicedSpriteDimensions.Set((this.slicedSpriteBar.borderLeft + this.slicedSpriteBar.borderRight) * vector.x / currentSprite.texelSize.x, this.fullSlicedSpriteDimensions.y);
			}
			this.initializedSlicedSpriteDimensions = true;
		}
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000A237B File Offset: 0x000A057B
	public tk2dUIProgressBar()
	{
		this.emptySlicedSpriteDimensions = Vector2.zero;
		this.fullSlicedSpriteDimensions = Vector2.zero;
		this.currentDimensions = Vector2.zero;
		this.SendMessageOnProgressCompleteMethodName = "";
		base..ctor();
	}

	// Token: 0x040025F5 RID: 9717
	public Transform scalableBar;

	// Token: 0x040025F6 RID: 9718
	public tk2dClippedSprite clippedSpriteBar;

	// Token: 0x040025F7 RID: 9719
	public tk2dSlicedSprite slicedSpriteBar;

	// Token: 0x040025F8 RID: 9720
	private bool initializedSlicedSpriteDimensions;

	// Token: 0x040025F9 RID: 9721
	private Vector2 emptySlicedSpriteDimensions;

	// Token: 0x040025FA RID: 9722
	private Vector2 fullSlicedSpriteDimensions;

	// Token: 0x040025FB RID: 9723
	private Vector2 currentDimensions;

	// Token: 0x040025FC RID: 9724
	[SerializeField]
	private float percent;

	// Token: 0x040025FD RID: 9725
	private bool isProgressComplete;

	// Token: 0x040025FE RID: 9726
	public GameObject sendMessageTarget;

	// Token: 0x040025FF RID: 9727
	public string SendMessageOnProgressCompleteMethodName;
}
