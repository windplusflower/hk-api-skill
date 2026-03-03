using System;
using UnityEngine;

// Token: 0x0200044D RID: 1101
public class CursorHighlight : MonoBehaviour
{
	// Token: 0x060018B2 RID: 6322 RVA: 0x00073B3C File Offset: 0x00071D3C
	public void Awake()
	{
		this.myRect = base.GetComponent<RectTransform>();
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00073B4A File Offset: 0x00071D4A
	private void Start()
	{
		this.lerpTimer = this.lerpTime;
		this.cooldownTimer = 0f;
		this.startPos = this.myRect.anchoredPosition;
		this.targetPos = this.startPos;
		this.coolingDown = false;
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00073B88 File Offset: 0x00071D88
	private void Update()
	{
		if (!this.coolingDown)
		{
			if (this.lerpTimer > this.lerpTime)
			{
				this.lerpTimer = this.lerpTime;
				this.coolingDown = true;
			}
			else if (this.lerpTimer < this.lerpTime)
			{
				this.lerpTimer += Time.deltaTime;
			}
			float num = this.lerpTimer / this.lerpTime;
			num = num * num * (3f - 2f * num);
			this.myRect.anchoredPosition = Vector2.Lerp(this.startPos, this.targetPos, num);
			return;
		}
		if (this.cooldownTimer > this.cursorCooldown)
		{
			this.coolingDown = false;
			this.cooldownTimer = 0f;
			return;
		}
		this.cooldownTimer += Time.deltaTime;
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00073C51 File Offset: 0x00071E51
	public void MoveCursor(RectTransform buttonRect)
	{
		if (!this.coolingDown)
		{
			this.startPos = this.myRect.anchoredPosition;
			this.targetPos = buttonRect.anchoredPosition;
			this.lerpTimer = 0f;
		}
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00073C83 File Offset: 0x00071E83
	public CursorHighlight()
	{
		this.lerpTime = 1f;
		this.cursorCooldown = 0.1f;
		base..ctor();
	}

	// Token: 0x04001DAB RID: 7595
	private RectTransform myRect;

	// Token: 0x04001DAC RID: 7596
	private Vector2 startPos;

	// Token: 0x04001DAD RID: 7597
	private Vector2 targetPos;

	// Token: 0x04001DAE RID: 7598
	[Tooltip("The time it takes for the cursor to move from one option to another.")]
	public float lerpTime;

	// Token: 0x04001DAF RID: 7599
	[Tooltip("The wait period between the cursor moving from one option to another.")]
	public float cursorCooldown;

	// Token: 0x04001DB0 RID: 7600
	private float lerpTimer;

	// Token: 0x04001DB1 RID: 7601
	private float cooldownTimer;

	// Token: 0x04001DB2 RID: 7602
	private bool coolingDown;
}
