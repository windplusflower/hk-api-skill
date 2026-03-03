using System;
using UnityEngine;

// Token: 0x020005A4 RID: 1444
[ExecuteInEditMode]
[AddComponentMenu("2D Toolkit/UI/tk2dUIScrollableArea")]
public class tk2dUIScrollableArea : MonoBehaviour
{
	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06002040 RID: 8256 RVA: 0x000A23AF File Offset: 0x000A05AF
	// (set) Token: 0x06002041 RID: 8257 RVA: 0x000A23B7 File Offset: 0x000A05B7
	public float ContentLength
	{
		get
		{
			return this.contentLength;
		}
		set
		{
			this.ContentLengthVisibleAreaLengthChange(this.contentLength, value, this.visibleAreaLength, this.visibleAreaLength);
		}
	}

	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x06002042 RID: 8258 RVA: 0x000A23D2 File Offset: 0x000A05D2
	// (set) Token: 0x06002043 RID: 8259 RVA: 0x000A23DA File Offset: 0x000A05DA
	public float VisibleAreaLength
	{
		get
		{
			return this.visibleAreaLength;
		}
		set
		{
			this.ContentLengthVisibleAreaLengthChange(this.contentLength, this.contentLength, this.visibleAreaLength, value);
		}
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06002044 RID: 8260 RVA: 0x000A23F5 File Offset: 0x000A05F5
	// (set) Token: 0x06002045 RID: 8261 RVA: 0x000A2400 File Offset: 0x000A0600
	public tk2dUILayout BackgroundLayoutItem
	{
		get
		{
			return this.backgroundLayoutItem;
		}
		set
		{
			if (this.backgroundLayoutItem != value)
			{
				if (this.backgroundLayoutItem != null)
				{
					this.backgroundLayoutItem.OnReshape -= this.LayoutReshaped;
				}
				this.backgroundLayoutItem = value;
				if (this.backgroundLayoutItem != null)
				{
					this.backgroundLayoutItem.OnReshape += this.LayoutReshaped;
				}
			}
		}
	}

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x06002046 RID: 8262 RVA: 0x000A246C File Offset: 0x000A066C
	// (set) Token: 0x06002047 RID: 8263 RVA: 0x000A2474 File Offset: 0x000A0674
	public tk2dUILayoutContainer ContentLayoutContainer
	{
		get
		{
			return this.contentLayoutContainer;
		}
		set
		{
			if (this.contentLayoutContainer != value)
			{
				if (this.contentLayoutContainer != null)
				{
					this.contentLayoutContainer.OnChangeContent -= this.ContentLayoutChangeCallback;
				}
				this.contentLayoutContainer = value;
				if (this.contentLayoutContainer != null)
				{
					this.contentLayoutContainer.OnChangeContent += this.ContentLayoutChangeCallback;
				}
			}
		}
	}

	// Token: 0x17000433 RID: 1075
	// (get) Token: 0x06002048 RID: 8264 RVA: 0x000A24E0 File Offset: 0x000A06E0
	// (set) Token: 0x06002049 RID: 8265 RVA: 0x000A24FD File Offset: 0x000A06FD
	public GameObject SendMessageTarget
	{
		get
		{
			if (this.backgroundUIItem != null)
			{
				return this.backgroundUIItem.sendMessageTarget;
			}
			return null;
		}
		set
		{
			if (this.backgroundUIItem != null && this.backgroundUIItem.sendMessageTarget != value)
			{
				this.backgroundUIItem.sendMessageTarget = value;
			}
		}
	}

	// Token: 0x1400004C RID: 76
	// (add) Token: 0x0600204A RID: 8266 RVA: 0x000A252C File Offset: 0x000A072C
	// (remove) Token: 0x0600204B RID: 8267 RVA: 0x000A2564 File Offset: 0x000A0764
	public event Action<tk2dUIScrollableArea> OnScroll;

	// Token: 0x17000434 RID: 1076
	// (get) Token: 0x0600204C RID: 8268 RVA: 0x000A2599 File Offset: 0x000A0799
	// (set) Token: 0x0600204D RID: 8269 RVA: 0x000A25A8 File Offset: 0x000A07A8
	public float Value
	{
		get
		{
			return Mathf.Clamp01(this.percent);
		}
		set
		{
			value = Mathf.Clamp(value, 0f, 1f);
			if (value != this.percent)
			{
				this.UnpressAllUIItemChildren();
				this.percent = value;
				if (this.OnScroll != null)
				{
					this.OnScroll(this);
				}
				if (this.isBackgroundButtonDown || this.isSwipeScrollingInProgress)
				{
					if (tk2dUIManager.Instance__NoCreate != null)
					{
						tk2dUIManager.Instance.OnInputUpdate -= this.BackgroundOverUpdate;
					}
					this.isBackgroundButtonDown = false;
					this.isSwipeScrollingInProgress = false;
				}
				this.TargetOnScrollCallback();
			}
			if (this.scrollBar != null)
			{
				this.scrollBar.SetScrollPercentWithoutEvent(this.percent);
			}
			this.SetContentPosition();
		}
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x000A2660 File Offset: 0x000A0860
	public void SetScrollPercentWithoutEvent(float newScrollPercent)
	{
		this.percent = Mathf.Clamp(newScrollPercent, 0f, 1f);
		this.UnpressAllUIItemChildren();
		if (this.scrollBar != null)
		{
			this.scrollBar.SetScrollPercentWithoutEvent(this.percent);
		}
		this.SetContentPosition();
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x000A26B0 File Offset: 0x000A08B0
	public float MeasureContentLength()
	{
		Vector3 vector = new Vector3(float.MinValue, float.MinValue, float.MinValue);
		Vector3 vector2 = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		Vector3[] array = new Vector3[]
		{
			vector2,
			vector
		};
		Transform transform = this.contentContainer.transform;
		tk2dUIScrollableArea.GetRendererBoundsInChildren(transform.worldToLocalMatrix, array, transform);
		if (!(array[0] != vector2) || !(array[1] != vector))
		{
			Debug.LogError("Unable to measure content length");
			return this.VisibleAreaLength * 0.9f;
		}
		array[0] = Vector3.Min(array[0], Vector3.zero);
		array[1] = Vector3.Max(array[1], Vector3.zero);
		if (this.scrollAxes != tk2dUIScrollableArea.Axes.YAxis)
		{
			return array[1].x - array[0].x;
		}
		return array[1].y - array[0].y;
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000A27C0 File Offset: 0x000A09C0
	private void OnEnable()
	{
		if (this.scrollBar != null)
		{
			this.scrollBar.OnScroll += this.ScrollBarMove;
		}
		if (this.backgroundUIItem != null)
		{
			this.backgroundUIItem.OnDown += this.BackgroundButtonDown;
			this.backgroundUIItem.OnRelease += this.BackgroundButtonRelease;
			this.backgroundUIItem.OnHoverOver += this.BackgroundButtonHoverOver;
			this.backgroundUIItem.OnHoverOut += this.BackgroundButtonHoverOut;
		}
		if (this.backgroundLayoutItem != null)
		{
			this.backgroundLayoutItem.OnReshape += this.LayoutReshaped;
		}
		if (this.contentLayoutContainer != null)
		{
			this.contentLayoutContainer.OnChangeContent += this.ContentLayoutChangeCallback;
		}
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000A28A8 File Offset: 0x000A0AA8
	private void OnDisable()
	{
		if (this.scrollBar != null)
		{
			this.scrollBar.OnScroll -= this.ScrollBarMove;
		}
		if (this.backgroundUIItem != null)
		{
			this.backgroundUIItem.OnDown -= this.BackgroundButtonDown;
			this.backgroundUIItem.OnRelease -= this.BackgroundButtonRelease;
			this.backgroundUIItem.OnHoverOver -= this.BackgroundButtonHoverOver;
			this.backgroundUIItem.OnHoverOut -= this.BackgroundButtonHoverOut;
		}
		if (this.isBackgroundButtonOver)
		{
			if (tk2dUIManager.Instance__NoCreate != null)
			{
				tk2dUIManager.Instance.OnScrollWheelChange -= this.BackgroundHoverOverScrollWheelChange;
			}
			this.isBackgroundButtonOver = false;
		}
		if (this.isBackgroundButtonDown || this.isSwipeScrollingInProgress)
		{
			if (tk2dUIManager.Instance__NoCreate != null)
			{
				tk2dUIManager.Instance.OnInputUpdate -= this.BackgroundOverUpdate;
			}
			this.isBackgroundButtonDown = false;
			this.isSwipeScrollingInProgress = false;
		}
		if (this.backgroundLayoutItem != null)
		{
			this.backgroundLayoutItem.OnReshape -= this.LayoutReshaped;
		}
		if (this.contentLayoutContainer != null)
		{
			this.contentLayoutContainer.OnChangeContent -= this.ContentLayoutChangeCallback;
		}
		this.swipeCurrVelocity = 0f;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x000A2A0C File Offset: 0x000A0C0C
	private void Start()
	{
		this.UpdateScrollbarActiveState();
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x000A2A14 File Offset: 0x000A0C14
	private void BackgroundHoverOverScrollWheelChange(float mouseWheelChange)
	{
		if (mouseWheelChange <= 0f)
		{
			if (mouseWheelChange < 0f)
			{
				if (this.scrollBar)
				{
					this.scrollBar.ScrollDownFixed();
					return;
				}
				this.Value += 0.1f;
			}
			return;
		}
		if (this.scrollBar)
		{
			this.scrollBar.ScrollUpFixed();
			return;
		}
		this.Value -= 0.1f;
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x000A2A88 File Offset: 0x000A0C88
	private void ScrollBarMove(tk2dUIScrollbar scrollBar)
	{
		this.Value = scrollBar.Value;
		this.isSwipeScrollingInProgress = false;
		if (this.isBackgroundButtonDown)
		{
			this.BackgroundButtonRelease();
		}
	}

	// Token: 0x17000435 RID: 1077
	// (get) Token: 0x06002055 RID: 8277 RVA: 0x000A2AAB File Offset: 0x000A0CAB
	// (set) Token: 0x06002056 RID: 8278 RVA: 0x000A2AD6 File Offset: 0x000A0CD6
	private Vector3 ContentContainerOffset
	{
		get
		{
			return Vector3.Scale(new Vector3(-1f, 1f, 1f), this.contentContainer.transform.localPosition);
		}
		set
		{
			this.contentContainer.transform.localPosition = Vector3.Scale(new Vector3(-1f, 1f, 1f), value);
		}
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x000A2B04 File Offset: 0x000A0D04
	private void SetContentPosition()
	{
		Vector3 contentContainerOffset = this.ContentContainerOffset;
		float num = (this.contentLength - this.visibleAreaLength) * this.Value;
		if (num < 0f)
		{
			num = 0f;
		}
		if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
		{
			contentContainerOffset.x = num;
		}
		else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
		{
			contentContainerOffset.y = num;
		}
		this.ContentContainerOffset = contentContainerOffset;
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x000A2B68 File Offset: 0x000A0D68
	private void BackgroundButtonDown()
	{
		if (this.allowSwipeScrolling && this.contentLength > this.visibleAreaLength)
		{
			if (!this.isBackgroundButtonDown && !this.isSwipeScrollingInProgress)
			{
				tk2dUIManager.Instance.OnInputUpdate += this.BackgroundOverUpdate;
			}
			this.swipeScrollingPressDownStartLocalPos = base.transform.InverseTransformPoint(this.CalculateClickWorldPos(this.backgroundUIItem));
			this.swipePrevScrollingContentPressLocalPos = this.swipeScrollingPressDownStartLocalPos;
			this.swipeScrollingContentStartLocalPos = this.ContentContainerOffset;
			this.swipeScrollingContentDestLocalPos = this.swipeScrollingContentStartLocalPos;
			this.isBackgroundButtonDown = true;
			this.swipeCurrVelocity = 0f;
		}
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x000A2C08 File Offset: 0x000A0E08
	private void BackgroundOverUpdate()
	{
		if (this.isBackgroundButtonDown)
		{
			this.UpdateSwipeScrollDestintationPosition();
		}
		if (this.isSwipeScrollingInProgress)
		{
			float num = this.percent;
			float num2 = 0f;
			if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
			{
				num2 = this.swipeScrollingContentDestLocalPos.x;
			}
			else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
			{
				num2 = this.swipeScrollingContentDestLocalPos.y;
			}
			float num3 = 0f;
			float num4 = this.contentLength - this.visibleAreaLength;
			if (this.isBackgroundButtonDown)
			{
				if (num2 < num3)
				{
					num2 += -num2 / this.visibleAreaLength / 2f;
					if (num2 > num3)
					{
						num2 = num3;
					}
				}
				else if (num2 > num4)
				{
					num2 -= (num2 - num4) / this.visibleAreaLength / 2f;
					if (num2 < num4)
					{
						num2 = num4;
					}
				}
				if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
				{
					this.swipeScrollingContentDestLocalPos.x = num2;
				}
				else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
				{
					this.swipeScrollingContentDestLocalPos.y = num2;
				}
				if (this.contentLength - this.visibleAreaLength > Mathf.Epsilon)
				{
					num = num2 / (this.contentLength - this.visibleAreaLength);
				}
				else
				{
					num = 0f;
				}
			}
			else
			{
				float num5 = this.visibleAreaLength * 0.001f;
				if (num2 < num3 || num2 > num4)
				{
					float num6 = (num2 < num3) ? num3 : num4;
					num2 = Mathf.SmoothDamp(num2, num6, ref this.snapBackVelocity, 0.05f, float.PositiveInfinity, tk2dUITime.deltaTime);
					if (Mathf.Abs(this.snapBackVelocity) < num5)
					{
						num2 = num6;
						this.snapBackVelocity = 0f;
					}
					this.swipeCurrVelocity = 0f;
				}
				else if (this.swipeCurrVelocity != 0f)
				{
					num2 += this.swipeCurrVelocity * tk2dUITime.deltaTime * 20f;
					if (this.swipeCurrVelocity > num5 || this.swipeCurrVelocity < -num5)
					{
						this.swipeCurrVelocity = Mathf.Lerp(this.swipeCurrVelocity, 0f, tk2dUITime.deltaTime * 2.5f);
					}
					else
					{
						this.swipeCurrVelocity = 0f;
					}
				}
				else
				{
					this.isSwipeScrollingInProgress = false;
					tk2dUIManager.Instance.OnInputUpdate -= this.BackgroundOverUpdate;
				}
				if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
				{
					this.swipeScrollingContentDestLocalPos.x = num2;
				}
				else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
				{
					this.swipeScrollingContentDestLocalPos.y = num2;
				}
				num = num2 / (this.contentLength - this.visibleAreaLength);
			}
			if (num != this.percent)
			{
				this.percent = num;
				this.ContentContainerOffset = this.swipeScrollingContentDestLocalPos;
				if (this.OnScroll != null)
				{
					this.OnScroll(this);
				}
				this.TargetOnScrollCallback();
			}
			if (this.scrollBar != null)
			{
				float scrollPercentWithoutEvent = this.percent;
				if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
				{
					scrollPercentWithoutEvent = this.ContentContainerOffset.x / (this.contentLength - this.visibleAreaLength);
				}
				else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
				{
					scrollPercentWithoutEvent = this.ContentContainerOffset.y / (this.contentLength - this.visibleAreaLength);
				}
				this.scrollBar.SetScrollPercentWithoutEvent(scrollPercentWithoutEvent);
			}
		}
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x000A2EEC File Offset: 0x000A10EC
	private void UpdateSwipeScrollDestintationPosition()
	{
		Vector3 vector = base.transform.InverseTransformPoint(this.CalculateClickWorldPos(this.backgroundUIItem));
		Vector3 vector2 = vector - this.swipeScrollingPressDownStartLocalPos;
		vector2.x *= -1f;
		float f = 0f;
		if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
		{
			f = vector2.x;
			this.swipeCurrVelocity = -(vector.x - this.swipePrevScrollingContentPressLocalPos.x);
		}
		else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
		{
			f = vector2.y;
			this.swipeCurrVelocity = vector.y - this.swipePrevScrollingContentPressLocalPos.y;
		}
		if (!this.isSwipeScrollingInProgress && Mathf.Abs(f) > 0.02f)
		{
			this.isSwipeScrollingInProgress = true;
			tk2dUIManager.Instance.OverrideClearAllChildrenPresses(this.backgroundUIItem);
		}
		if (this.isSwipeScrollingInProgress)
		{
			Vector3 vector3 = this.swipeScrollingContentStartLocalPos + vector2;
			vector3.z = this.ContentContainerOffset.z;
			if (this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis)
			{
				vector3.y = this.ContentContainerOffset.y;
			}
			else if (this.scrollAxes == tk2dUIScrollableArea.Axes.YAxis)
			{
				vector3.x = this.ContentContainerOffset.x;
			}
			vector3.z = this.ContentContainerOffset.z;
			this.swipeScrollingContentDestLocalPos = vector3;
			this.swipePrevScrollingContentPressLocalPos = vector;
		}
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000A3030 File Offset: 0x000A1230
	private void BackgroundButtonRelease()
	{
		if (this.allowSwipeScrolling)
		{
			if (this.isBackgroundButtonDown && !this.isSwipeScrollingInProgress)
			{
				tk2dUIManager.Instance.OnInputUpdate -= this.BackgroundOverUpdate;
			}
			this.isBackgroundButtonDown = false;
		}
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000A3067 File Offset: 0x000A1267
	private void BackgroundButtonHoverOver()
	{
		if (this.allowScrollWheel)
		{
			if (!this.isBackgroundButtonOver)
			{
				tk2dUIManager.Instance.OnScrollWheelChange += this.BackgroundHoverOverScrollWheelChange;
			}
			this.isBackgroundButtonOver = true;
		}
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000A3096 File Offset: 0x000A1296
	private void BackgroundButtonHoverOut()
	{
		if (this.isBackgroundButtonOver)
		{
			tk2dUIManager.Instance.OnScrollWheelChange -= this.BackgroundHoverOverScrollWheelChange;
		}
		this.isBackgroundButtonOver = false;
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x000A30C0 File Offset: 0x000A12C0
	private Vector3 CalculateClickWorldPos(tk2dUIItem btn)
	{
		Vector2 position = btn.Touch.position;
		Camera uicameraForControl = tk2dUIManager.Instance.GetUICameraForControl(base.gameObject);
		Vector3 result = uicameraForControl.ScreenToWorldPoint(new Vector3(position.x, position.y, btn.transform.position.z - uicameraForControl.transform.position.z));
		result.z = btn.transform.position.z;
		return result;
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000A3140 File Offset: 0x000A1340
	private void UpdateScrollbarActiveState()
	{
		bool flag = this.contentLength > this.visibleAreaLength;
		if (this.scrollBar != null && this.scrollBar.gameObject.activeSelf != flag)
		{
			tk2dUIBaseItemControl.ChangeGameObjectActiveState(this.scrollBar.gameObject, flag);
		}
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000A3190 File Offset: 0x000A1390
	private void ContentLengthVisibleAreaLengthChange(float prevContentLength, float newContentLength, float prevVisibleAreaLength, float newVisibleAreaLength)
	{
		float value;
		if (newContentLength - this.visibleAreaLength != 0f)
		{
			value = (prevContentLength - prevVisibleAreaLength) * this.Value / (newContentLength - newVisibleAreaLength);
		}
		else
		{
			value = 0f;
		}
		this.contentLength = newContentLength;
		this.visibleAreaLength = newVisibleAreaLength;
		this.UpdateScrollbarActiveState();
		this.Value = value;
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x00003603 File Offset: 0x00001803
	private void UnpressAllUIItemChildren()
	{
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x000A31E0 File Offset: 0x000A13E0
	private void TargetOnScrollCallback()
	{
		if (this.SendMessageTarget != null && this.SendMessageOnScrollMethodName.Length > 0)
		{
			this.SendMessageTarget.SendMessage(this.SendMessageOnScrollMethodName, this, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000A3214 File Offset: 0x000A1414
	private static void GetRendererBoundsInChildren(Matrix4x4 rootWorldToLocal, Vector3[] minMax, Transform t)
	{
		MeshFilter component = t.GetComponent<MeshFilter>();
		if (component != null && component.sharedMesh != null)
		{
			Bounds bounds = component.sharedMesh.bounds;
			Matrix4x4 matrix4x = rootWorldToLocal * t.localToWorldMatrix;
			for (int i = 0; i < 8; i++)
			{
				Vector3 point = bounds.center + Vector3.Scale(bounds.extents, tk2dUIScrollableArea.boxExtents[i]);
				Vector3 rhs = matrix4x.MultiplyPoint(point);
				minMax[0] = Vector3.Min(minMax[0], rhs);
				minMax[1] = Vector3.Max(minMax[1], rhs);
			}
		}
		int childCount = t.childCount;
		for (int j = 0; j < childCount; j++)
		{
			Transform child = t.GetChild(j);
			if (t.gameObject.activeSelf)
			{
				tk2dUIScrollableArea.GetRendererBoundsInChildren(rootWorldToLocal, minMax, child);
			}
		}
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000A3300 File Offset: 0x000A1500
	private void LayoutReshaped(Vector3 dMin, Vector3 dMax)
	{
		this.VisibleAreaLength += ((this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis) ? (dMax.x - dMin.x) : (dMax.y - dMin.y));
	}

	// Token: 0x06002065 RID: 8293 RVA: 0x000A3334 File Offset: 0x000A1534
	private void ContentLayoutChangeCallback()
	{
		if (this.contentLayoutContainer != null)
		{
			Vector2 innerSize = this.contentLayoutContainer.GetInnerSize();
			this.ContentLength = ((this.scrollAxes == tk2dUIScrollableArea.Axes.XAxis) ? innerSize.x : innerSize.y);
		}
	}

	// Token: 0x06002066 RID: 8294 RVA: 0x000A3378 File Offset: 0x000A1578
	public tk2dUIScrollableArea()
	{
		this.contentLength = 1f;
		this.visibleAreaLength = 1f;
		this.scrollAxes = tk2dUIScrollableArea.Axes.YAxis;
		this.allowSwipeScrolling = true;
		this.allowScrollWheel = true;
		this.swipeScrollingPressDownStartLocalPos = Vector3.zero;
		this.swipeScrollingContentStartLocalPos = Vector3.zero;
		this.swipeScrollingContentDestLocalPos = Vector3.zero;
		this.swipePrevScrollingContentPressLocalPos = Vector3.zero;
		this.SendMessageOnScrollMethodName = "";
		base..ctor();
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x000A33F0 File Offset: 0x000A15F0
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dUIScrollableArea()
	{
		tk2dUIScrollableArea.boxExtents = new Vector3[]
		{
			new Vector3(-1f, -1f, -1f),
			new Vector3(1f, -1f, -1f),
			new Vector3(-1f, 1f, -1f),
			new Vector3(1f, 1f, -1f),
			new Vector3(-1f, -1f, 1f),
			new Vector3(1f, -1f, 1f),
			new Vector3(-1f, 1f, 1f),
			new Vector3(1f, 1f, 1f)
		};
	}

	// Token: 0x04002600 RID: 9728
	[SerializeField]
	private float contentLength;

	// Token: 0x04002601 RID: 9729
	[SerializeField]
	private float visibleAreaLength;

	// Token: 0x04002602 RID: 9730
	public GameObject contentContainer;

	// Token: 0x04002603 RID: 9731
	public tk2dUIScrollbar scrollBar;

	// Token: 0x04002604 RID: 9732
	public tk2dUIItem backgroundUIItem;

	// Token: 0x04002605 RID: 9733
	public tk2dUIScrollableArea.Axes scrollAxes;

	// Token: 0x04002606 RID: 9734
	public bool allowSwipeScrolling;

	// Token: 0x04002607 RID: 9735
	public bool allowScrollWheel;

	// Token: 0x04002608 RID: 9736
	[SerializeField]
	[HideInInspector]
	private tk2dUILayout backgroundLayoutItem;

	// Token: 0x04002609 RID: 9737
	[SerializeField]
	[HideInInspector]
	private tk2dUILayoutContainer contentLayoutContainer;

	// Token: 0x0400260A RID: 9738
	private bool isBackgroundButtonDown;

	// Token: 0x0400260B RID: 9739
	private bool isBackgroundButtonOver;

	// Token: 0x0400260C RID: 9740
	private Vector3 swipeScrollingPressDownStartLocalPos;

	// Token: 0x0400260D RID: 9741
	private Vector3 swipeScrollingContentStartLocalPos;

	// Token: 0x0400260E RID: 9742
	private Vector3 swipeScrollingContentDestLocalPos;

	// Token: 0x0400260F RID: 9743
	private bool isSwipeScrollingInProgress;

	// Token: 0x04002610 RID: 9744
	private const float SWIPE_SCROLLING_FIRST_SCROLL_THRESHOLD = 0.02f;

	// Token: 0x04002611 RID: 9745
	private const float WITHOUT_SCROLLBAR_FIXED_SCROLL_WHEEL_PERCENT = 0.1f;

	// Token: 0x04002612 RID: 9746
	private Vector3 swipePrevScrollingContentPressLocalPos;

	// Token: 0x04002613 RID: 9747
	private float swipeCurrVelocity;

	// Token: 0x04002614 RID: 9748
	private float snapBackVelocity;

	// Token: 0x04002616 RID: 9750
	public string SendMessageOnScrollMethodName;

	// Token: 0x04002617 RID: 9751
	private float percent;

	// Token: 0x04002618 RID: 9752
	private static readonly Vector3[] boxExtents;

	// Token: 0x020005A5 RID: 1445
	public enum Axes
	{
		// Token: 0x0400261A RID: 9754
		XAxis,
		// Token: 0x0400261B RID: 9755
		YAxis
	}
}
