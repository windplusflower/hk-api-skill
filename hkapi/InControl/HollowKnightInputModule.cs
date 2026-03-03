using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace InControl
{
	// Token: 0x0200073A RID: 1850
	[AddComponentMenu("Event/Hollow Knight Input Module")]
	public class HollowKnightInputModule : StandaloneInputModule
	{
		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x000F7904 File Offset: 0x000F5B04
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x000F790C File Offset: 0x000F5B0C
		public PlayerAction SubmitAction { get; set; }

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000F7915 File Offset: 0x000F5B15
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x000F791D File Offset: 0x000F5B1D
		public PlayerAction CancelAction { get; set; }

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x000F7926 File Offset: 0x000F5B26
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x000F792E File Offset: 0x000F5B2E
		public PlayerAction JumpAction { get; set; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000F7937 File Offset: 0x000F5B37
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x000F793F File Offset: 0x000F5B3F
		public PlayerAction CastAction { get; set; }

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000F7948 File Offset: 0x000F5B48
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x000F7950 File Offset: 0x000F5B50
		public PlayerAction AttackAction { get; set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x000F7959 File Offset: 0x000F5B59
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x000F7961 File Offset: 0x000F5B61
		public PlayerTwoAxisAction MoveAction { get; set; }

		// Token: 0x06002E87 RID: 11911 RVA: 0x000F796C File Offset: 0x000F5B6C
		protected HollowKnightInputModule()
		{
			this.analogMoveThreshold = 0.5f;
			this.moveRepeatFirstDuration = 0.8f;
			this.moveRepeatDelayDuration = 0.1f;
			this.allowMouseInput = true;
			base..ctor();
			this.direction = new TwoAxisInputControl();
			this.direction.StateThreshold = this.analogMoveThreshold;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000F79C3 File Offset: 0x000F5BC3
		public override void UpdateModule()
		{
			this.lastMousePosition = this.thisMousePosition;
			this.thisMousePosition = Input.mousePosition;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000F79DC File Offset: 0x000F5BDC
		public override bool IsModuleSupported()
		{
			return this.forceModuleActive || Input.mousePresent;
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000F79F0 File Offset: 0x000F5BF0
		public override bool ShouldActivateModule()
		{
			if (!base.enabled || !base.gameObject.activeInHierarchy)
			{
				return false;
			}
			this.UpdateInputState();
			bool flag = false;
			flag |= this.SubmitAction.WasPressed;
			flag |= this.CancelAction.WasPressed;
			flag |= this.JumpAction.WasPressed;
			flag |= this.CastAction.WasPressed;
			flag |= this.AttackAction.WasPressed;
			flag |= this.VectorWasPressed;
			if (this.allowMouseInput)
			{
				flag |= this.MouseHasMoved;
				flag |= this.MouseButtonIsPressed;
			}
			if (Input.touchCount > 0)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000F7A90 File Offset: 0x000F5C90
		public override void ActivateModule()
		{
			base.ActivateModule();
			this.thisMousePosition = Input.mousePosition;
			this.lastMousePosition = Input.mousePosition;
			GameObject gameObject = base.eventSystem.currentSelectedGameObject;
			if (gameObject == null)
			{
				gameObject = base.eventSystem.firstSelectedGameObject;
			}
			base.eventSystem.SetSelectedGameObject(gameObject, this.GetBaseEventData());
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000F7AEC File Offset: 0x000F5CEC
		public override void Process()
		{
			bool flag = base.SendUpdateEventToSelectedObject();
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
			if (this.allowMouseInput)
			{
				base.ProcessMouseEvent();
			}
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000F7B30 File Offset: 0x000F5D30
		private bool SendButtonEventToSelectedObject()
		{
			if (base.eventSystem.currentSelectedGameObject == null)
			{
				return false;
			}
			if (UIManager.instance.IsFadingMenu)
			{
				return false;
			}
			BaseEventData baseEventData = this.GetBaseEventData();
			Platform.MenuActions menuAction = Platform.Current.GetMenuAction(this.SubmitAction.WasPressed, this.CancelAction.WasPressed, this.JumpAction.WasPressed, this.AttackAction.WasPressed, this.CastAction.WasPressed);
			if (menuAction == Platform.MenuActions.Submit)
			{
				ExecuteEvents.Execute<ISubmitHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.submitHandler);
			}
			else if (menuAction == Platform.MenuActions.Cancel)
			{
				PlayerAction playerAction = this.AttackAction.WasPressed ? this.AttackAction : this.CastAction;
				if (!playerAction.WasPressed || playerAction.FindBinding(new MouseBindingSource(Mouse.LeftButton)) == null)
				{
					ExecuteEvents.Execute<ICancelHandler>(base.eventSystem.currentSelectedGameObject, baseEventData, ExecuteEvents.cancelHandler);
				}
			}
			return baseEventData.used;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000F7C24 File Offset: 0x000F5E24
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

		// Token: 0x06002E8F RID: 11919 RVA: 0x000F7CBC File Offset: 0x000F5EBC
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

		// Token: 0x06002E90 RID: 11920 RVA: 0x000F7D06 File Offset: 0x000F5F06
		private void Update()
		{
			this.direction.Filter(this.Device.Direction, Time.deltaTime);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000F7D24 File Offset: 0x000F5F24
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
			if (this.VectorIsReleased)
			{
				this.nextMoveRepeatTime = 0f;
			}
			if (this.VectorIsPressed)
			{
				if (this.lastVectorState == Vector2.zero)
				{
					if (Time.realtimeSinceStartup > this.lastVectorPressedTime + 0.1f)
					{
						this.nextMoveRepeatTime = Time.realtimeSinceStartup + this.moveRepeatFirstDuration;
					}
					else
					{
						this.nextMoveRepeatTime = Time.realtimeSinceStartup + this.moveRepeatDelayDuration;
					}
				}
				this.lastVectorPressedTime = Time.realtimeSinceStartup;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x000F7E25 File Offset: 0x000F6025
		// (set) Token: 0x06002E92 RID: 11922 RVA: 0x000F7E1C File Offset: 0x000F601C
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

		// Token: 0x06002E94 RID: 11924 RVA: 0x000F7E36 File Offset: 0x000F6036
		private void SetVectorRepeatTimer()
		{
			this.nextMoveRepeatTime = Mathf.Max(this.nextMoveRepeatTime, Time.realtimeSinceStartup + this.moveRepeatDelayDuration);
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x000F7E55 File Offset: 0x000F6055
		private bool VectorIsPressed
		{
			get
			{
				return this.thisVectorState != Vector2.zero;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000F7E67 File Offset: 0x000F6067
		private bool VectorIsReleased
		{
			get
			{
				return this.thisVectorState == Vector2.zero;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x000F7E79 File Offset: 0x000F6079
		private bool VectorHasChanged
		{
			get
			{
				return this.thisVectorState != this.lastVectorState;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000F7E8C File Offset: 0x000F608C
		private bool VectorWasPressed
		{
			get
			{
				return (this.VectorIsPressed && Time.realtimeSinceStartup > this.nextMoveRepeatTime) || (this.VectorIsPressed && this.lastVectorState == Vector2.zero);
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x000F7EC0 File Offset: 0x000F60C0
		private bool MouseHasMoved
		{
			get
			{
				return (this.thisMousePosition - this.lastMousePosition).sqrMagnitude > 0f;
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000F7EED File Offset: 0x000F60ED
		private bool MouseButtonIsPressed
		{
			get
			{
				return Input.GetMouseButtonDown(0);
			}
		}

		// Token: 0x040032F7 RID: 13047
		[Range(0.1f, 0.9f)]
		public float analogMoveThreshold;

		// Token: 0x040032F8 RID: 13048
		public float moveRepeatFirstDuration;

		// Token: 0x040032F9 RID: 13049
		public float moveRepeatDelayDuration;

		// Token: 0x040032FA RID: 13050
		[FormerlySerializedAs("allowMobileDevice")]
		public new bool forceModuleActive;

		// Token: 0x040032FB RID: 13051
		public bool allowMouseInput;

		// Token: 0x040032FC RID: 13052
		public bool focusOnMouseHover;

		// Token: 0x040032FD RID: 13053
		private InputDevice inputDevice;

		// Token: 0x040032FE RID: 13054
		private Vector3 thisMousePosition;

		// Token: 0x040032FF RID: 13055
		private Vector3 lastMousePosition;

		// Token: 0x04003300 RID: 13056
		private Vector2 thisVectorState;

		// Token: 0x04003301 RID: 13057
		private Vector2 lastVectorState;

		// Token: 0x04003302 RID: 13058
		private float nextMoveRepeatTime;

		// Token: 0x04003303 RID: 13059
		private float lastVectorPressedTime;

		// Token: 0x04003304 RID: 13060
		private TwoAxisInputControl direction;
	}
}
