using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace InControl
{
	// Token: 0x020006F2 RID: 1778
	[AddComponentMenu("Event/InControl Input Module")]
	public class InControlInputModule : PointerInputModule
	{
		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000EB871 File Offset: 0x000E9A71
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x000EB879 File Offset: 0x000E9A79
		public PlayerAction SubmitAction { get; set; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000EB882 File Offset: 0x000E9A82
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x000EB88A File Offset: 0x000E9A8A
		public PlayerAction CancelAction { get; set; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000EB893 File Offset: 0x000E9A93
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x000EB89B File Offset: 0x000E9A9B
		public PlayerTwoAxisAction MoveAction { get; set; }

		// Token: 0x06002B74 RID: 11124 RVA: 0x000EB8A4 File Offset: 0x000E9AA4
		protected InControlInputModule()
		{
			this.submitButton = InControlInputModule.Button.Action1;
			this.cancelButton = InControlInputModule.Button.Action2;
			this.analogMoveThreshold = 0.5f;
			this.moveRepeatFirstDuration = 0.8f;
			this.moveRepeatDelayDuration = 0.1f;
			this.allowMouseInput = true;
			this.allowTouchInput = true;
			base..ctor();
			this.direction = new TwoAxisInputControl();
			this.direction.StateThreshold = this.analogMoveThreshold;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000EB912 File Offset: 0x000E9B12
		public override void UpdateModule()
		{
			this.lastMousePosition = this.thisMousePosition;
			this.thisMousePosition = InputManager.MouseProvider.GetPosition();
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000EB935 File Offset: 0x000E9B35
		public override bool IsModuleSupported()
		{
			return this.forceModuleActive || InputManager.MouseProvider.HasMousePresent() || Input.touchSupported;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000EB958 File Offset: 0x000E9B58
		public override bool ShouldActivateModule()
		{
			if (!base.enabled || !base.gameObject.activeInHierarchy)
			{
				return false;
			}
			this.UpdateInputState();
			bool flag = false;
			flag |= this.SubmitWasPressed;
			flag |= this.CancelWasPressed;
			flag |= this.VectorWasPressed;
			if (this.allowMouseInput)
			{
				flag |= this.MouseHasMoved;
				flag |= InControlInputModule.MouseButtonWasPressed;
			}
			if (this.allowTouchInput)
			{
				flag |= (Input.touchCount > 0);
			}
			return flag;
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000EB9CC File Offset: 0x000E9BCC
		public override void ActivateModule()
		{
			base.ActivateModule();
			this.thisMousePosition = InputManager.MouseProvider.GetPosition();
			this.lastMousePosition = this.thisMousePosition;
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000EBA34 File Offset: 0x000E9C34
		public override void Process()
		{
			bool flag = this.SendUpdateEventToSelectedObject();
			if (base.eventSystem.sendNavigationEvents)
			{
				if (!flag)
				{
					flag = this.SendVectorEventToSelectedObject();
				}
				if (!flag)
				{
					this.SendButtonEventToSelectedObject();
				}
			}
			if (this.allowTouchInput && this.ProcessTouchEvents())
			{
				return;
			}
			if (this.allowMouseInput)
			{
				this.ProcessMouseEvent();
			}
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000EBA88 File Offset: 0x000E9C88
		private bool ProcessTouchEvents()
		{
			int touchCount = Input.touchCount;
			for (int i = 0; i < touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.type != TouchType.Indirect)
				{
					bool pressed;
					bool flag;
					PointerEventData touchPointerEventData = base.GetTouchPointerEventData(touch, out pressed, out flag);
					this.ProcessTouchPress(touchPointerEventData, pressed, flag);
					if (!flag)
					{
						this.ProcessMove(touchPointerEventData);
						this.ProcessDrag(touchPointerEventData);
					}
					else
					{
						base.RemovePointerData(touchPointerEventData);
					}
				}
			}
			return touchCount > 0;
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000EBAF4 File Offset: 0x000E9CF4
		private bool SendButtonEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			if (this.SubmitWasPressed)
			{
				ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
			}
			else
			{
				bool submitWasReleased = this.SubmitWasReleased;
			}
			if (this.CancelWasPressed)
			{
				ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
			}
			return baseEventData.used;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x000EBB6C File Offset: 0x000E9D6C
		private bool SendVectorEventToSelectedObject()
		{
			if (!this.VectorWasPressed)
			{
				return false;
			}
			AxisEventData axisEventData = this.GetAxisEventData(this.thisVectorState.x, this.thisVectorState.y, 0.5f);
			if (axisEventData.moveDir != MoveDirection.None)
			{
				if (base.eventSystem.currentSelectedGameObject == null)
				{
					base.eventSystem.SetSelectedGameObject(base.eventSystem.firstSelectedGameObject, this.GetBaseEventData());
				}
				else
				{
					ExecuteEvents.Execute<IMoveHandler>(base.eventSystem.currentSelectedGameObject, axisEventData, ExecuteEvents.moveHandler);
				}
				this.SetVectorRepeatTimer();
			}
			return axisEventData.used;
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000EBC04 File Offset: 0x000E9E04
		protected override void ProcessMove(PointerEventData pointerEvent)
		{
			GameObject pointerEnter = pointerEvent.pointerEnter;
			base.ProcessMove(pointerEvent);
			if (this.focusOnMouseHover && pointerEnter != pointerEvent.pointerEnter)
			{
				GameObject eventHandler = ExecuteEvents.GetEventHandler<ISelectHandler>(pointerEvent.pointerEnter);
				base.eventSystem.SetSelectedGameObject(eventHandler, pointerEvent);
			}
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x000EBC4E File Offset: 0x000E9E4E
		private void Update()
		{
			this.direction.Filter(this.Device.Direction, Time.deltaTime);
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x000EBC6C File Offset: 0x000E9E6C
		private void UpdateInputState()
		{
			this.lastVectorState = this.thisVectorState;
			this.thisVectorState = Vector2.zero;
			TwoAxisInputControl twoAxisInputControl = this.MoveAction ?? this.direction;
			if (Utility.AbsoluteIsOverThreshold(twoAxisInputControl.X, this.analogMoveThreshold))
			{
				this.thisVectorState.x = Mathf.Sign(twoAxisInputControl.X);
			}
			if (Utility.AbsoluteIsOverThreshold(twoAxisInputControl.Y, this.analogMoveThreshold))
			{
				this.thisVectorState.y = Mathf.Sign(twoAxisInputControl.Y);
			}
			this.moveWasRepeated = false;
			if (this.VectorIsReleased)
			{
				this.nextMoveRepeatTime = 0f;
			}
			else if (this.VectorIsPressed)
			{
				float realtimeSinceStartup = Time.realtimeSinceStartup;
				if (this.lastVectorState == Vector2.zero)
				{
					this.nextMoveRepeatTime = realtimeSinceStartup + this.moveRepeatFirstDuration;
				}
				else if (realtimeSinceStartup >= this.nextMoveRepeatTime)
				{
					this.moveWasRepeated = true;
					this.nextMoveRepeatTime = realtimeSinceStartup + this.moveRepeatDelayDuration;
				}
			}
			this.lastSubmitState = this.thisSubmitState;
			this.thisSubmitState = ((this.SubmitAction == null) ? this.SubmitButton.IsPressed : this.SubmitAction.IsPressed);
			this.lastCancelState = this.thisCancelState;
			this.thisCancelState = ((this.CancelAction == null) ? this.CancelButton.IsPressed : this.CancelAction.IsPressed);
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000EBDCA File Offset: 0x000E9FCA
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x000EBDC1 File Offset: 0x000E9FC1
		public InputDevice Device
		{
			get
			{
				return this.inputDevice ?? InputManager.ActiveDevice;
			}
			set
			{
				this.inputDevice = value;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002B82 RID: 11138 RVA: 0x000EBDDB File Offset: 0x000E9FDB
		private InputControl SubmitButton
		{
			get
			{
				return this.Device.GetControl((InputControlType)this.submitButton);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000EBDEE File Offset: 0x000E9FEE
		private InputControl CancelButton
		{
			get
			{
				return this.Device.GetControl((InputControlType)this.cancelButton);
			}
		}

		// Token: 0x06002B84 RID: 11140 RVA: 0x000EBE01 File Offset: 0x000EA001
		private void SetVectorRepeatTimer()
		{
			this.nextMoveRepeatTime = Mathf.Max(this.nextMoveRepeatTime, Time.realtimeSinceStartup + this.moveRepeatDelayDuration);
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000EBE20 File Offset: 0x000EA020
		private bool VectorIsPressed
		{
			get
			{
				return this.thisVectorState != Vector2.zero;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000EBE32 File Offset: 0x000EA032
		private bool VectorIsReleased
		{
			get
			{
				return this.thisVectorState == Vector2.zero;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000EBE44 File Offset: 0x000EA044
		private bool VectorHasChanged
		{
			get
			{
				return this.thisVectorState != this.lastVectorState;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000EBE57 File Offset: 0x000EA057
		private bool VectorWasPressed
		{
			get
			{
				return this.moveWasRepeated || (this.VectorIsPressed && this.lastVectorState == Vector2.zero);
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x000EBE7D File Offset: 0x000EA07D
		private bool SubmitWasPressed
		{
			get
			{
				return this.thisSubmitState && this.thisSubmitState != this.lastSubmitState;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000EBE9A File Offset: 0x000EA09A
		private bool SubmitWasReleased
		{
			get
			{
				return !this.thisSubmitState && this.thisSubmitState != this.lastSubmitState;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x000EBEB7 File Offset: 0x000EA0B7
		private bool CancelWasPressed
		{
			get
			{
				return this.thisCancelState && this.thisCancelState != this.lastCancelState;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000EBED4 File Offset: 0x000EA0D4
		private bool MouseHasMoved
		{
			get
			{
				return (this.thisMousePosition - this.lastMousePosition).sqrMagnitude > 0f;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000EBF01 File Offset: 0x000EA101
		private static bool MouseButtonWasPressed
		{
			get
			{
				return InputManager.MouseProvider.GetButtonWasPressed(Mouse.LeftButton);
			}
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000EBF10 File Offset: 0x000EA110
		protected bool SendUpdateEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			ExecuteEvents.Execute<IUpdateSelectedHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.updateSelectedHandler);
			return baseEventData.used;
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x000EBF56 File Offset: 0x000EA156
		protected void ProcessMouseEvent()
		{
			this.ProcessMouseEvent(0);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x000EBF60 File Offset: 0x000EA160
		protected void ProcessMouseEvent(int id)
		{
			PointerInputModule.MouseState mousePointerEventData = this.GetMousePointerEventData(id);
			PointerInputModule.MouseButtonEventData eventData = mousePointerEventData.GetButtonState(PointerEventData.InputButton.Left).eventData;
			this.ProcessMousePress(eventData);
			this.ProcessMove(eventData.buttonData);
			this.ProcessDrag(eventData.buttonData);
			this.ProcessMousePress(mousePointerEventData.GetButtonState(PointerEventData.InputButton.Right).eventData);
			this.ProcessDrag(mousePointerEventData.GetButtonState(PointerEventData.InputButton.Right).eventData.buttonData);
			this.ProcessMousePress(mousePointerEventData.GetButtonState(PointerEventData.InputButton.Middle).eventData);
			this.ProcessDrag(mousePointerEventData.GetButtonState(PointerEventData.InputButton.Middle).eventData.buttonData);
			if (!Mathf.Approximately(eventData.buttonData.scrollDelta.sqrMagnitude, 0f))
			{
				ExecuteEvents.ExecuteHierarchy<IScrollHandler>(ExecuteEvents.GetEventHandler<IScrollHandler>(eventData.buttonData.pointerCurrentRaycast.gameObject), eventData.buttonData, ExecuteEvents.scrollHandler);
			}
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x000EC03C File Offset: 0x000EA23C
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			PointerEventData buttonData = data.buttonData;
			GameObject gameObject = buttonData.pointerCurrentRaycast.gameObject;
			if (data.PressedThisFrame())
			{
				buttonData.eligibleForClick = true;
				buttonData.delta = Vector2.zero;
				buttonData.dragging = false;
				buttonData.useDragThreshold = true;
				buttonData.pressPosition = buttonData.position;
				buttonData.pointerPressRaycast = buttonData.pointerCurrentRaycast;
				base.DeselectIfSelectionChanged(gameObject, buttonData);
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, buttonData, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				float unscaledTime = Time.unscaledTime;
				if (gameObject2 == buttonData.lastPress)
				{
					if (unscaledTime - buttonData.clickTime < 0.3f)
					{
						PointerEventData pointerEventData = buttonData;
						int clickCount = pointerEventData.clickCount + 1;
						pointerEventData.clickCount = clickCount;
					}
					else
					{
						buttonData.clickCount = 1;
					}
					buttonData.clickTime = unscaledTime;
				}
				else
				{
					buttonData.clickCount = 1;
				}
				buttonData.pointerPress = gameObject2;
				buttonData.rawPointerPress = gameObject;
				buttonData.clickTime = unscaledTime;
				buttonData.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (buttonData.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(buttonData.pointerDrag, buttonData, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (data.ReleasedThisFrame())
			{
				ExecuteEvents.Execute<IPointerUpHandler>(buttonData.pointerPress, buttonData, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (buttonData.pointerPress == eventHandler && buttonData.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(buttonData.pointerPress, buttonData, ExecuteEvents.pointerClickHandler);
				}
				else if (buttonData.pointerDrag != null && buttonData.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, buttonData, ExecuteEvents.dropHandler);
				}
				buttonData.eligibleForClick = false;
				buttonData.pointerPress = null;
				buttonData.rawPointerPress = null;
				if (buttonData.pointerDrag != null && buttonData.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(buttonData.pointerDrag, buttonData, ExecuteEvents.endDragHandler);
				}
				buttonData.dragging = false;
				buttonData.pointerDrag = null;
				if (gameObject != buttonData.pointerEnter)
				{
					base.HandlePointerExitAndEnter(buttonData, null);
					base.HandlePointerExitAndEnter(buttonData, gameObject);
				}
			}
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x000EC238 File Offset: 0x000EA438
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			GameObject gameObject = pointerEvent.pointerCurrentRaycast.gameObject;
			if (pressed)
			{
				pointerEvent.eligibleForClick = true;
				pointerEvent.delta = Vector2.zero;
				pointerEvent.dragging = false;
				pointerEvent.useDragThreshold = true;
				pointerEvent.pressPosition = pointerEvent.position;
				pointerEvent.pointerPressRaycast = pointerEvent.pointerCurrentRaycast;
				base.DeselectIfSelectionChanged(gameObject, pointerEvent);
				if (pointerEvent.pointerEnter != gameObject)
				{
					base.HandlePointerExitAndEnter(pointerEvent, gameObject);
					pointerEvent.pointerEnter = gameObject;
				}
				GameObject gameObject2 = ExecuteEvents.ExecuteHierarchy<IPointerDownHandler>(gameObject, pointerEvent, ExecuteEvents.pointerDownHandler);
				if (gameObject2 == null)
				{
					gameObject2 = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				}
				float unscaledTime = Time.unscaledTime;
				if (gameObject2 == pointerEvent.lastPress)
				{
					if (unscaledTime - pointerEvent.clickTime < 0.3f)
					{
						int clickCount = pointerEvent.clickCount + 1;
						pointerEvent.clickCount = clickCount;
					}
					else
					{
						pointerEvent.clickCount = 1;
					}
					pointerEvent.clickTime = unscaledTime;
				}
				else
				{
					pointerEvent.clickCount = 1;
				}
				pointerEvent.pointerPress = gameObject2;
				pointerEvent.rawPointerPress = gameObject;
				pointerEvent.clickTime = unscaledTime;
				pointerEvent.pointerDrag = ExecuteEvents.GetEventHandler<IDragHandler>(gameObject);
				if (pointerEvent.pointerDrag != null)
				{
					ExecuteEvents.Execute<IInitializePotentialDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.initializePotentialDrag);
				}
			}
			if (released)
			{
				ExecuteEvents.Execute<IPointerUpHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerUpHandler);
				GameObject eventHandler = ExecuteEvents.GetEventHandler<IPointerClickHandler>(gameObject);
				if (pointerEvent.pointerPress == eventHandler && pointerEvent.eligibleForClick)
				{
					ExecuteEvents.Execute<IPointerClickHandler>(pointerEvent.pointerPress, pointerEvent, ExecuteEvents.pointerClickHandler);
				}
				else if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.ExecuteHierarchy<IDropHandler>(gameObject, pointerEvent, ExecuteEvents.dropHandler);
				}
				pointerEvent.eligibleForClick = false;
				pointerEvent.pointerPress = null;
				pointerEvent.rawPointerPress = null;
				if (pointerEvent.pointerDrag != null && pointerEvent.dragging)
				{
					ExecuteEvents.Execute<IEndDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);
				}
				pointerEvent.dragging = false;
				pointerEvent.pointerDrag = null;
				if (pointerEvent.pointerDrag != null)
				{
					ExecuteEvents.Execute<IEndDragHandler>(pointerEvent.pointerDrag, pointerEvent, ExecuteEvents.endDragHandler);
				}
				pointerEvent.pointerDrag = null;
				ExecuteEvents.ExecuteHierarchy<IPointerExitHandler>(pointerEvent.pointerEnter, pointerEvent, ExecuteEvents.pointerExitHandler);
				pointerEvent.pointerEnter = null;
			}
		}

		// Token: 0x04003149 RID: 12617
		public InControlInputModule.Button submitButton;

		// Token: 0x0400314A RID: 12618
		public InControlInputModule.Button cancelButton;

		// Token: 0x0400314B RID: 12619
		[Range(0.1f, 0.9f)]
		public float analogMoveThreshold;

		// Token: 0x0400314C RID: 12620
		public float moveRepeatFirstDuration;

		// Token: 0x0400314D RID: 12621
		public float moveRepeatDelayDuration;

		// Token: 0x0400314E RID: 12622
		[FormerlySerializedAs("allowMobileDevice")]
		public bool forceModuleActive;

		// Token: 0x0400314F RID: 12623
		public bool allowMouseInput;

		// Token: 0x04003150 RID: 12624
		public bool focusOnMouseHover;

		// Token: 0x04003151 RID: 12625
		public bool allowTouchInput;

		// Token: 0x04003152 RID: 12626
		private InputDevice inputDevice;

		// Token: 0x04003153 RID: 12627
		private Vector3 thisMousePosition;

		// Token: 0x04003154 RID: 12628
		private Vector3 lastMousePosition;

		// Token: 0x04003155 RID: 12629
		private Vector2 thisVectorState;

		// Token: 0x04003156 RID: 12630
		private Vector2 lastVectorState;

		// Token: 0x04003157 RID: 12631
		private bool thisSubmitState;

		// Token: 0x04003158 RID: 12632
		private bool lastSubmitState;

		// Token: 0x04003159 RID: 12633
		private bool thisCancelState;

		// Token: 0x0400315A RID: 12634
		private bool lastCancelState;

		// Token: 0x0400315B RID: 12635
		private bool moveWasRepeated;

		// Token: 0x0400315C RID: 12636
		private float nextMoveRepeatTime;

		// Token: 0x0400315D RID: 12637
		private TwoAxisInputControl direction;

		// Token: 0x020006F3 RID: 1779
		public enum Button
		{
			// Token: 0x04003162 RID: 12642
			Action1 = 19,
			// Token: 0x04003163 RID: 12643
			Action2,
			// Token: 0x04003164 RID: 12644
			Action3,
			// Token: 0x04003165 RID: 12645
			Action4
		}
	}
}
