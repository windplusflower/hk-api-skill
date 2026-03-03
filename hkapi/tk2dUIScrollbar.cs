using System;
using UnityEngine;

// Token: 0x020005A6 RID: 1446
[ExecuteInEditMode]
[AddComponentMenu("2D Toolkit/UI/tk2dUIScrollbar")]
public class tk2dUIScrollbar : MonoBehaviour
{
	// Token: 0x17000436 RID: 1078
	// (get) Token: 0x06002068 RID: 8296 RVA: 0x000A34E0 File Offset: 0x000A16E0
	// (set) Token: 0x06002069 RID: 8297 RVA: 0x000A34E8 File Offset: 0x000A16E8
	public tk2dUILayout BarLayoutItem
	{
		get
		{
			return this.barLayoutItem;
		}
		set
		{
			if (this.barLayoutItem != value)
			{
				if (this.barLayoutItem != null)
				{
					this.barLayoutItem.OnReshape -= this.LayoutReshaped;
				}
				this.barLayoutItem = value;
				if (this.barLayoutItem != null)
				{
					this.barLayoutItem.OnReshape += this.LayoutReshaped;
				}
			}
		}
	}

	// Token: 0x1400004D RID: 77
	// (add) Token: 0x0600206A RID: 8298 RVA: 0x000A3554 File Offset: 0x000A1754
	// (remove) Token: 0x0600206B RID: 8299 RVA: 0x000A358C File Offset: 0x000A178C
	public event Action<tk2dUIScrollbar> OnScroll;

	// Token: 0x17000437 RID: 1079
	// (get) Token: 0x0600206C RID: 8300 RVA: 0x000A35C1 File Offset: 0x000A17C1
	// (set) Token: 0x0600206D RID: 8301 RVA: 0x000A35DE File Offset: 0x000A17DE
	public GameObject SendMessageTarget
	{
		get
		{
			if (this.barUIItem != null)
			{
				return this.barUIItem.sendMessageTarget;
			}
			return null;
		}
		set
		{
			if (this.barUIItem != null && this.barUIItem.sendMessageTarget != value)
			{
				this.barUIItem.sendMessageTarget = value;
			}
		}
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x0600206E RID: 8302 RVA: 0x000A360D File Offset: 0x000A180D
	// (set) Token: 0x0600206F RID: 8303 RVA: 0x000A3618 File Offset: 0x000A1818
	public float Value
	{
		get
		{
			return this.percent;
		}
		set
		{
			this.percent = Mathf.Clamp(value, 0f, 1f);
			if (this.OnScroll != null)
			{
				this.OnScroll(this);
			}
			this.SetScrollThumbPosition();
			if (this.SendMessageTarget != null && this.SendMessageOnScrollMethodName.Length > 0)
			{
				this.SendMessageTarget.SendMessage(this.SendMessageOnScrollMethodName, this, SendMessageOptions.RequireReceiver);
			}
		}
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x000A3684 File Offset: 0x000A1884
	public void SetScrollPercentWithoutEvent(float newScrollPercent)
	{
		this.percent = Mathf.Clamp(newScrollPercent, 0f, 1f);
		this.SetScrollThumbPosition();
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x000A36A4 File Offset: 0x000A18A4
	private void OnEnable()
	{
		if (this.barUIItem != null)
		{
			this.barUIItem.OnDown += this.ScrollTrackButtonDown;
			this.barUIItem.OnHoverOver += this.ScrollTrackButtonHoverOver;
			this.barUIItem.OnHoverOut += this.ScrollTrackButtonHoverOut;
		}
		if (this.thumbBtn != null)
		{
			this.thumbBtn.OnDown += this.ScrollThumbButtonDown;
			this.thumbBtn.OnRelease += this.ScrollThumbButtonRelease;
		}
		if (this.upButton != null)
		{
			this.upButton.OnDown += this.ScrollUpButtonDown;
			this.upButton.OnUp += this.ScrollUpButtonUp;
		}
		if (this.downButton != null)
		{
			this.downButton.OnDown += this.ScrollDownButtonDown;
			this.downButton.OnUp += this.ScrollDownButtonUp;
		}
		if (this.barLayoutItem != null)
		{
			this.barLayoutItem.OnReshape += this.LayoutReshaped;
		}
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000A37E0 File Offset: 0x000A19E0
	private void OnDisable()
	{
		if (this.barUIItem != null)
		{
			this.barUIItem.OnDown -= this.ScrollTrackButtonDown;
			this.barUIItem.OnHoverOver -= this.ScrollTrackButtonHoverOver;
			this.barUIItem.OnHoverOut -= this.ScrollTrackButtonHoverOut;
		}
		if (this.thumbBtn != null)
		{
			this.thumbBtn.OnDown -= this.ScrollThumbButtonDown;
			this.thumbBtn.OnRelease -= this.ScrollThumbButtonRelease;
		}
		if (this.upButton != null)
		{
			this.upButton.OnDown -= this.ScrollUpButtonDown;
			this.upButton.OnUp -= this.ScrollUpButtonUp;
		}
		if (this.downButton != null)
		{
			this.downButton.OnDown -= this.ScrollDownButtonDown;
			this.downButton.OnUp -= this.ScrollDownButtonUp;
		}
		if (this.isScrollThumbButtonDown)
		{
			if (tk2dUIManager.Instance__NoCreate != null)
			{
				tk2dUIManager.Instance.OnInputUpdate -= this.MoveScrollThumbButton;
			}
			this.isScrollThumbButtonDown = false;
		}
		if (this.isTrackHoverOver)
		{
			if (tk2dUIManager.Instance__NoCreate != null)
			{
				tk2dUIManager.Instance.OnScrollWheelChange -= this.TrackHoverScrollWheelChange;
			}
			this.isTrackHoverOver = false;
		}
		if (this.scrollUpDownButtonState != 0)
		{
			tk2dUIManager.Instance.OnInputUpdate -= this.CheckRepeatScrollUpDownButton;
			this.scrollUpDownButtonState = 0;
		}
		if (this.barLayoutItem != null)
		{
			this.barLayoutItem.OnReshape -= this.LayoutReshaped;
		}
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x000A39A2 File Offset: 0x000A1BA2
	private void Awake()
	{
		if (this.upButton != null)
		{
			this.hoverUpButton = this.upButton.GetComponent<tk2dUIHoverItem>();
		}
		if (this.downButton != null)
		{
			this.hoverDownButton = this.downButton.GetComponent<tk2dUIHoverItem>();
		}
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x000A39E2 File Offset: 0x000A1BE2
	private void Start()
	{
		this.SetScrollThumbPosition();
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000A39EA File Offset: 0x000A1BEA
	private void TrackHoverScrollWheelChange(float mouseWheelChange)
	{
		if (mouseWheelChange > 0f)
		{
			this.ScrollUpFixed();
			return;
		}
		if (mouseWheelChange < 0f)
		{
			this.ScrollDownFixed();
		}
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x000A3A0C File Offset: 0x000A1C0C
	private void SetScrollThumbPosition()
	{
		if (this.thumbTransform != null)
		{
			float num = -((this.scrollBarLength - this.thumbLength) * this.Value);
			Vector3 localPosition = this.thumbTransform.localPosition;
			if (this.scrollAxes == tk2dUIScrollbar.Axes.XAxis)
			{
				localPosition.x = -num;
			}
			else if (this.scrollAxes == tk2dUIScrollbar.Axes.YAxis)
			{
				localPosition.y = num;
			}
			this.thumbTransform.localPosition = localPosition;
		}
		if (this.highlightProgressBar != null)
		{
			this.highlightProgressBar.Value = this.Value;
		}
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000A3A98 File Offset: 0x000A1C98
	private void MoveScrollThumbButton()
	{
		this.ScrollToPosition(this.CalculateClickWorldPos(this.thumbBtn) + this.moveThumbBtnOffset);
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000A3AB8 File Offset: 0x000A1CB8
	private Vector3 CalculateClickWorldPos(tk2dUIItem btn)
	{
		Camera uicameraForControl = tk2dUIManager.Instance.GetUICameraForControl(base.gameObject);
		Vector2 position = btn.Touch.position;
		Vector3 result = uicameraForControl.ScreenToWorldPoint(new Vector3(position.x, position.y, btn.transform.position.z - uicameraForControl.transform.position.z));
		result.z = btn.transform.position.z;
		return result;
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000A3B38 File Offset: 0x000A1D38
	private void ScrollToPosition(Vector3 worldPos)
	{
		Vector3 vector = this.thumbTransform.parent.InverseTransformPoint(worldPos);
		float num = 0f;
		if (this.scrollAxes == tk2dUIScrollbar.Axes.XAxis)
		{
			num = vector.x;
		}
		else if (this.scrollAxes == tk2dUIScrollbar.Axes.YAxis)
		{
			num = -vector.y;
		}
		this.Value = num / (this.scrollBarLength - this.thumbLength);
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x000A3B94 File Offset: 0x000A1D94
	private void ScrollTrackButtonDown()
	{
		this.ScrollToPosition(this.CalculateClickWorldPos(this.barUIItem));
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000A3BA8 File Offset: 0x000A1DA8
	private void ScrollTrackButtonHoverOver()
	{
		if (this.allowScrollWheel)
		{
			if (!this.isTrackHoverOver)
			{
				tk2dUIManager.Instance.OnScrollWheelChange += this.TrackHoverScrollWheelChange;
			}
			this.isTrackHoverOver = true;
		}
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000A3BD7 File Offset: 0x000A1DD7
	private void ScrollTrackButtonHoverOut()
	{
		if (this.isTrackHoverOver)
		{
			tk2dUIManager.Instance.OnScrollWheelChange -= this.TrackHoverScrollWheelChange;
		}
		this.isTrackHoverOver = false;
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000A3C00 File Offset: 0x000A1E00
	private void ScrollThumbButtonDown()
	{
		if (!this.isScrollThumbButtonDown)
		{
			tk2dUIManager.Instance.OnInputUpdate += this.MoveScrollThumbButton;
		}
		this.isScrollThumbButtonDown = true;
		Vector3 b = this.CalculateClickWorldPos(this.thumbBtn);
		this.moveThumbBtnOffset = this.thumbBtn.transform.position - b;
		this.moveThumbBtnOffset.z = 0f;
		if (this.hoverUpButton != null)
		{
			this.hoverUpButton.IsOver = true;
		}
		if (this.hoverDownButton != null)
		{
			this.hoverDownButton.IsOver = true;
		}
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000A3CA0 File Offset: 0x000A1EA0
	private void ScrollThumbButtonRelease()
	{
		if (this.isScrollThumbButtonDown)
		{
			tk2dUIManager.Instance.OnInputUpdate -= this.MoveScrollThumbButton;
		}
		this.isScrollThumbButtonDown = false;
		if (this.hoverUpButton != null)
		{
			this.hoverUpButton.IsOver = false;
		}
		if (this.hoverDownButton != null)
		{
			this.hoverDownButton.IsOver = false;
		}
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000A3D08 File Offset: 0x000A1F08
	private void ScrollUpButtonDown()
	{
		this.timeOfUpDownButtonPressStart = Time.realtimeSinceStartup;
		this.repeatUpDownButtonHoldCounter = 0f;
		if (this.scrollUpDownButtonState == 0)
		{
			tk2dUIManager.Instance.OnInputUpdate += this.CheckRepeatScrollUpDownButton;
		}
		this.scrollUpDownButtonState = -1;
		this.ScrollUpFixed();
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000A3D56 File Offset: 0x000A1F56
	private void ScrollUpButtonUp()
	{
		if (this.scrollUpDownButtonState != 0)
		{
			tk2dUIManager.Instance.OnInputUpdate -= this.CheckRepeatScrollUpDownButton;
		}
		this.scrollUpDownButtonState = 0;
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000A3D80 File Offset: 0x000A1F80
	private void ScrollDownButtonDown()
	{
		this.timeOfUpDownButtonPressStart = Time.realtimeSinceStartup;
		this.repeatUpDownButtonHoldCounter = 0f;
		if (this.scrollUpDownButtonState == 0)
		{
			tk2dUIManager.Instance.OnInputUpdate += this.CheckRepeatScrollUpDownButton;
		}
		this.scrollUpDownButtonState = 1;
		this.ScrollDownFixed();
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x000A3D56 File Offset: 0x000A1F56
	private void ScrollDownButtonUp()
	{
		if (this.scrollUpDownButtonState != 0)
		{
			tk2dUIManager.Instance.OnInputUpdate -= this.CheckRepeatScrollUpDownButton;
		}
		this.scrollUpDownButtonState = 0;
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x000A3DCE File Offset: 0x000A1FCE
	public void ScrollUpFixed()
	{
		this.ScrollDirection(-1);
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x000A3DD7 File Offset: 0x000A1FD7
	public void ScrollDownFixed()
	{
		this.ScrollDirection(1);
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000A3DE0 File Offset: 0x000A1FE0
	private void CheckRepeatScrollUpDownButton()
	{
		if (this.scrollUpDownButtonState != 0)
		{
			float num = Time.realtimeSinceStartup - this.timeOfUpDownButtonPressStart;
			if (this.repeatUpDownButtonHoldCounter == 0f)
			{
				if (num > 0.55f)
				{
					this.repeatUpDownButtonHoldCounter += 1f;
					num -= 0.55f;
					this.ScrollDirection(this.scrollUpDownButtonState);
					return;
				}
			}
			else if (num > 0.45f)
			{
				this.repeatUpDownButtonHoldCounter += 1f;
				num -= 0.45f;
				this.ScrollDirection(this.scrollUpDownButtonState);
			}
		}
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000A3E70 File Offset: 0x000A2070
	public void ScrollDirection(int dir)
	{
		if (this.scrollAxes == tk2dUIScrollbar.Axes.XAxis)
		{
			this.Value -= this.CalcScrollPercentOffsetButtonScrollDistance() * (float)dir * this.buttonUpDownScrollDistance;
			return;
		}
		this.Value += this.CalcScrollPercentOffsetButtonScrollDistance() * (float)dir * this.buttonUpDownScrollDistance;
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x000A3EC0 File Offset: 0x000A20C0
	private float CalcScrollPercentOffsetButtonScrollDistance()
	{
		return 0.1f;
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000A3EC7 File Offset: 0x000A20C7
	private void LayoutReshaped(Vector3 dMin, Vector3 dMax)
	{
		this.scrollBarLength += ((this.scrollAxes == tk2dUIScrollbar.Axes.XAxis) ? (dMax.x - dMin.x) : (dMax.y - dMin.y));
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x000A3EFA File Offset: 0x000A20FA
	public tk2dUIScrollbar()
	{
		this.buttonUpDownScrollDistance = 1f;
		this.allowScrollWheel = true;
		this.scrollAxes = tk2dUIScrollbar.Axes.YAxis;
		this.moveThumbBtnOffset = Vector3.zero;
		this.SendMessageOnScrollMethodName = "";
		base..ctor();
	}

	// Token: 0x0400261C RID: 9756
	public tk2dUIItem barUIItem;

	// Token: 0x0400261D RID: 9757
	public float scrollBarLength;

	// Token: 0x0400261E RID: 9758
	public tk2dUIItem thumbBtn;

	// Token: 0x0400261F RID: 9759
	public Transform thumbTransform;

	// Token: 0x04002620 RID: 9760
	public float thumbLength;

	// Token: 0x04002621 RID: 9761
	public tk2dUIItem upButton;

	// Token: 0x04002622 RID: 9762
	private tk2dUIHoverItem hoverUpButton;

	// Token: 0x04002623 RID: 9763
	public tk2dUIItem downButton;

	// Token: 0x04002624 RID: 9764
	private tk2dUIHoverItem hoverDownButton;

	// Token: 0x04002625 RID: 9765
	public float buttonUpDownScrollDistance;

	// Token: 0x04002626 RID: 9766
	public bool allowScrollWheel;

	// Token: 0x04002627 RID: 9767
	public tk2dUIScrollbar.Axes scrollAxes;

	// Token: 0x04002628 RID: 9768
	public tk2dUIProgressBar highlightProgressBar;

	// Token: 0x04002629 RID: 9769
	[SerializeField]
	[HideInInspector]
	private tk2dUILayout barLayoutItem;

	// Token: 0x0400262A RID: 9770
	private bool isScrollThumbButtonDown;

	// Token: 0x0400262B RID: 9771
	private bool isTrackHoverOver;

	// Token: 0x0400262C RID: 9772
	private float percent;

	// Token: 0x0400262D RID: 9773
	private Vector3 moveThumbBtnOffset;

	// Token: 0x0400262E RID: 9774
	private int scrollUpDownButtonState;

	// Token: 0x0400262F RID: 9775
	private float timeOfUpDownButtonPressStart;

	// Token: 0x04002630 RID: 9776
	private float repeatUpDownButtonHoldCounter;

	// Token: 0x04002631 RID: 9777
	private const float WITHOUT_SCROLLBAR_FIXED_SCROLL_WHEEL_PERCENT = 0.1f;

	// Token: 0x04002632 RID: 9778
	private const float INITIAL_TIME_TO_REPEAT_UP_DOWN_SCROLL_BUTTON_SCROLLING_ON_HOLD = 0.55f;

	// Token: 0x04002633 RID: 9779
	private const float TIME_TO_REPEAT_UP_DOWN_SCROLL_BUTTON_SCROLLING_ON_HOLD = 0.45f;

	// Token: 0x04002635 RID: 9781
	public string SendMessageOnScrollMethodName;

	// Token: 0x020005A7 RID: 1447
	public enum Axes
	{
		// Token: 0x04002637 RID: 9783
		XAxis,
		// Token: 0x04002638 RID: 9784
		YAxis
	}
}
