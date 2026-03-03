using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000717 RID: 1815
	[ExecuteInEditMode]
	public class TouchManager : SingletonMonoBehavior<TouchManager>
	{
		// Token: 0x14000071 RID: 113
		// (add) Token: 0x06002CDE RID: 11486 RVA: 0x000F1A14 File Offset: 0x000EFC14
		// (remove) Token: 0x06002CDF RID: 11487 RVA: 0x000F1A48 File Offset: 0x000EFC48
		public static event Action OnSetup;

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000F1A7B File Offset: 0x000EFC7B
		protected TouchManager()
		{
			this.controlsShowGizmos = TouchManager.GizmoShowOption.Always;
			this._controlsEnabled = true;
			this.controlsLayer = 5;
			this.mouseTouches = new Touch[3];
			base..ctor();
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000F1AA4 File Offset: 0x000EFCA4
		private void OnEnable()
		{
			if (base.GetComponent<InControlManager>() == null)
			{
				Logger.LogError("Touch Manager component can only be added to the InControl Manager object.");
				UnityEngine.Object.DestroyImmediate(this);
				return;
			}
			if (base.EnforceSingleton)
			{
				return;
			}
			this.touchControls = base.GetComponentsInChildren<TouchControl>(true);
			if (Application.isPlaying)
			{
				InputManager.OnSetup += this.Setup;
				InputManager.OnUpdateDevices += this.UpdateDevice;
				InputManager.OnCommitDevices += this.CommitDevice;
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000F1B20 File Offset: 0x000EFD20
		private void OnDisable()
		{
			if (Application.isPlaying)
			{
				InputManager.OnSetup -= this.Setup;
				InputManager.OnUpdateDevices -= this.UpdateDevice;
				InputManager.OnCommitDevices -= this.CommitDevice;
			}
			this.Reset();
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000F1B6D File Offset: 0x000EFD6D
		private void Setup()
		{
			this.UpdateScreenSize(this.GetCurrentScreenSize());
			this.CreateDevice();
			this.CreateTouches();
			if (TouchManager.OnSetup != null)
			{
				TouchManager.OnSetup();
				TouchManager.OnSetup = null;
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000F1BA0 File Offset: 0x000EFDA0
		private void Reset()
		{
			this.device = null;
			for (int i = 0; i < 3; i++)
			{
				this.mouseTouches[i] = null;
			}
			this.cachedTouches = null;
			this.activeTouches = null;
			this.readOnlyActiveTouches = null;
			this.touchControls = null;
			TouchManager.OnSetup = null;
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000F1BEB File Offset: 0x000EFDEB
		private IEnumerator UpdateScreenSizeAtEndOfFrame()
		{
			yield return new WaitForEndOfFrame();
			this.UpdateScreenSize(this.GetCurrentScreenSize());
			yield return null;
			yield break;
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000F1BFC File Offset: 0x000EFDFC
		private void Update()
		{
			Vector2 currentScreenSize = this.GetCurrentScreenSize();
			if (!this.isReady)
			{
				base.StartCoroutine(this.UpdateScreenSizeAtEndOfFrame());
				this.UpdateScreenSize(currentScreenSize);
				this.isReady = true;
				return;
			}
			if (this.screenSize != currentScreenSize)
			{
				this.UpdateScreenSize(currentScreenSize);
			}
			if (TouchManager.OnSetup != null)
			{
				TouchManager.OnSetup();
				TouchManager.OnSetup = null;
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x000F1C60 File Offset: 0x000EFE60
		private void CreateDevice()
		{
			this.device = new TouchInputDevice();
			this.device.AddControl(InputControlType.LeftStickLeft, "LeftStickLeft");
			this.device.AddControl(InputControlType.LeftStickRight, "LeftStickRight");
			this.device.AddControl(InputControlType.LeftStickUp, "LeftStickUp");
			this.device.AddControl(InputControlType.LeftStickDown, "LeftStickDown");
			this.device.AddControl(InputControlType.RightStickLeft, "RightStickLeft");
			this.device.AddControl(InputControlType.RightStickRight, "RightStickRight");
			this.device.AddControl(InputControlType.RightStickUp, "RightStickUp");
			this.device.AddControl(InputControlType.RightStickDown, "RightStickDown");
			this.device.AddControl(InputControlType.DPadUp, "DPadUp");
			this.device.AddControl(InputControlType.DPadDown, "DPadDown");
			this.device.AddControl(InputControlType.DPadLeft, "DPadLeft");
			this.device.AddControl(InputControlType.DPadRight, "DPadRight");
			this.device.AddControl(InputControlType.LeftTrigger, "LeftTrigger");
			this.device.AddControl(InputControlType.RightTrigger, "RightTrigger");
			this.device.AddControl(InputControlType.LeftBumper, "LeftBumper");
			this.device.AddControl(InputControlType.RightBumper, "RightBumper");
			for (InputControlType inputControlType = InputControlType.Action1; inputControlType <= InputControlType.Action12; inputControlType++)
			{
				this.device.AddControl(inputControlType, inputControlType.ToString());
			}
			this.device.AddControl(InputControlType.Menu, "Menu");
			for (InputControlType inputControlType2 = InputControlType.Button0; inputControlType2 <= InputControlType.Button19; inputControlType2++)
			{
				this.device.AddControl(inputControlType2, inputControlType2.ToString());
			}
			InputManager.AttachDevice(this.device);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x000F1E15 File Offset: 0x000F0015
		private void UpdateDevice(ulong updateTick, float deltaTime)
		{
			this.UpdateTouches(updateTick, deltaTime);
			this.SubmitControlStates(updateTick, deltaTime);
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x000F1E27 File Offset: 0x000F0027
		private void CommitDevice(ulong updateTick, float deltaTime)
		{
			this.CommitControlStates(updateTick, deltaTime);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x000F1E34 File Offset: 0x000F0034
		private void SubmitControlStates(ulong updateTick, float deltaTime)
		{
			int num = this.touchControls.Length;
			for (int i = 0; i < num; i++)
			{
				TouchControl touchControl = this.touchControls[i];
				if (touchControl.enabled && touchControl.gameObject.activeInHierarchy)
				{
					touchControl.SubmitControlState(updateTick, deltaTime);
				}
			}
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x000F1E7C File Offset: 0x000F007C
		private void CommitControlStates(ulong updateTick, float deltaTime)
		{
			int num = this.touchControls.Length;
			for (int i = 0; i < num; i++)
			{
				TouchControl touchControl = this.touchControls[i];
				if (touchControl.enabled && touchControl.gameObject.activeInHierarchy)
				{
					touchControl.CommitControlState(updateTick, deltaTime);
				}
			}
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x000F1EC4 File Offset: 0x000F00C4
		private void UpdateScreenSize(Vector2 currentScreenSize)
		{
			this.touchCamera.rect = new Rect(0f, 0f, 0.99f, 1f);
			this.touchCamera.rect = new Rect(0f, 0f, 1f, 1f);
			this.screenSize = currentScreenSize;
			this.halfScreenSize = this.screenSize / 2f;
			this.viewSize = this.ConvertViewToWorldPoint(Vector2.one) * 0.02f;
			this.percentToWorld = Mathf.Min(this.viewSize.x, this.viewSize.y);
			this.halfPercentToWorld = this.percentToWorld / 2f;
			if (this.touchCamera != null)
			{
				this.halfPixelToWorld = this.touchCamera.orthographicSize / this.screenSize.y;
				this.pixelToWorld = this.halfPixelToWorld * 2f;
			}
			if (this.touchControls != null)
			{
				int num = this.touchControls.Length;
				for (int i = 0; i < num; i++)
				{
					this.touchControls[i].ConfigureControl();
				}
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000F1FEC File Offset: 0x000F01EC
		private void CreateTouches()
		{
			this.cachedTouches = new TouchPool();
			for (int i = 0; i < 3; i++)
			{
				this.mouseTouches[i] = new Touch();
				this.mouseTouches[i].fingerId = -2;
			}
			this.activeTouches = new List<Touch>(32);
			this.readOnlyActiveTouches = new ReadOnlyCollection<Touch>(this.activeTouches);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000F204C File Offset: 0x000F024C
		private void UpdateTouches(ulong updateTick, float deltaTime)
		{
			this.activeTouches.Clear();
			this.cachedTouches.FreeEndedTouches();
			for (int i = 0; i < 3; i++)
			{
				if (this.mouseTouches[i].SetWithMouseData(i, updateTick, deltaTime))
				{
					this.activeTouches.Add(this.mouseTouches[i]);
				}
			}
			for (int j = 0; j < Input.touchCount; j++)
			{
				Touch touch = Input.GetTouch(j);
				Touch touch2 = this.cachedTouches.FindOrCreateTouch(touch.fingerId);
				touch2.SetWithTouchData(touch, updateTick, deltaTime);
				this.activeTouches.Add(touch2);
			}
			int count = this.cachedTouches.Touches.Count;
			for (int k = 0; k < count; k++)
			{
				Touch touch3 = this.cachedTouches.Touches[k];
				if (touch3.phase != TouchPhase.Ended && touch3.updateTick != updateTick)
				{
					touch3.phase = TouchPhase.Ended;
					this.activeTouches.Add(touch3);
				}
			}
			this.InvokeTouchEvents();
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000F2148 File Offset: 0x000F0348
		private void SendTouchBegan(Touch touch)
		{
			int num = this.touchControls.Length;
			for (int i = 0; i < num; i++)
			{
				TouchControl touchControl = this.touchControls[i];
				if (touchControl.enabled && touchControl.gameObject.activeInHierarchy)
				{
					touchControl.TouchBegan(touch);
				}
			}
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000F2190 File Offset: 0x000F0390
		private void SendTouchMoved(Touch touch)
		{
			int num = this.touchControls.Length;
			for (int i = 0; i < num; i++)
			{
				TouchControl touchControl = this.touchControls[i];
				if (touchControl.enabled && touchControl.gameObject.activeInHierarchy)
				{
					touchControl.TouchMoved(touch);
				}
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000F21D8 File Offset: 0x000F03D8
		private void SendTouchEnded(Touch touch)
		{
			int num = this.touchControls.Length;
			for (int i = 0; i < num; i++)
			{
				TouchControl touchControl = this.touchControls[i];
				if (touchControl.enabled && touchControl.gameObject.activeInHierarchy)
				{
					touchControl.TouchEnded(touch);
				}
			}
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x000F2220 File Offset: 0x000F0420
		private void InvokeTouchEvents()
		{
			int count = this.activeTouches.Count;
			if (this.enableControlsOnTouch && count > 0 && !this.controlsEnabled)
			{
				TouchManager.Device.RequestActivation();
				this.controlsEnabled = true;
			}
			for (int i = 0; i < count; i++)
			{
				Touch touch = this.activeTouches[i];
				switch (touch.phase)
				{
				case TouchPhase.Began:
					this.SendTouchBegan(touch);
					break;
				case TouchPhase.Moved:
					this.SendTouchMoved(touch);
					break;
				case TouchPhase.Stationary:
					break;
				case TouchPhase.Ended:
					this.SendTouchEnded(touch);
					break;
				case TouchPhase.Canceled:
					this.SendTouchEnded(touch);
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
			}
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x000F22C4 File Offset: 0x000F04C4
		private bool TouchCameraIsValid()
		{
			return !(this.touchCamera == null) && !Utility.IsZero(this.touchCamera.orthographicSize) && (!Utility.IsZero(this.touchCamera.rect.width) || !Utility.IsZero(this.touchCamera.rect.height)) && (!Utility.IsZero(this.touchCamera.pixelRect.width) || !Utility.IsZero(this.touchCamera.pixelRect.height));
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x000F2364 File Offset: 0x000F0564
		private Vector3 ConvertScreenToWorldPoint(Vector2 point)
		{
			if (this.TouchCameraIsValid())
			{
				return this.touchCamera.ScreenToWorldPoint(new Vector3(point.x, point.y, -this.touchCamera.transform.position.z));
			}
			return Vector3.zero;
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000F23B4 File Offset: 0x000F05B4
		private Vector3 ConvertViewToWorldPoint(Vector2 point)
		{
			if (this.TouchCameraIsValid())
			{
				return this.touchCamera.ViewportToWorldPoint(new Vector3(point.x, point.y, -this.touchCamera.transform.position.z));
			}
			return Vector3.zero;
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x000F2404 File Offset: 0x000F0604
		private Vector3 ConvertScreenToViewPoint(Vector2 point)
		{
			if (this.TouchCameraIsValid())
			{
				return this.touchCamera.ScreenToViewportPoint(new Vector3(point.x, point.y, -this.touchCamera.transform.position.z));
			}
			return Vector3.zero;
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x000F2451 File Offset: 0x000F0651
		private Vector2 GetCurrentScreenSize()
		{
			if (this.TouchCameraIsValid())
			{
				return new Vector2((float)this.touchCamera.pixelWidth, (float)this.touchCamera.pixelHeight);
			}
			return new Vector2((float)Screen.width, (float)Screen.height);
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002CF8 RID: 11512 RVA: 0x000F248A File Offset: 0x000F068A
		// (set) Token: 0x06002CF9 RID: 11513 RVA: 0x000F2494 File Offset: 0x000F0694
		public bool controlsEnabled
		{
			get
			{
				return this._controlsEnabled;
			}
			set
			{
				if (this._controlsEnabled != value)
				{
					int num = this.touchControls.Length;
					for (int i = 0; i < num; i++)
					{
						this.touchControls[i].enabled = value;
					}
					this._controlsEnabled = value;
				}
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002CFA RID: 11514 RVA: 0x000F24D4 File Offset: 0x000F06D4
		public static ReadOnlyCollection<Touch> Touches
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.readOnlyActiveTouches;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06002CFB RID: 11515 RVA: 0x000F24E0 File Offset: 0x000F06E0
		public static int TouchCount
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.activeTouches.Count;
			}
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x000F24F1 File Offset: 0x000F06F1
		public static Touch GetTouch(int touchIndex)
		{
			return SingletonMonoBehavior<TouchManager>.Instance.activeTouches[touchIndex];
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x000F2503 File Offset: 0x000F0703
		public static Touch GetTouchByFingerId(int fingerId)
		{
			return SingletonMonoBehavior<TouchManager>.Instance.cachedTouches.FindTouch(fingerId);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x000F2515 File Offset: 0x000F0715
		public static Vector3 ScreenToWorldPoint(Vector2 point)
		{
			return SingletonMonoBehavior<TouchManager>.Instance.ConvertScreenToWorldPoint(point);
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x000F2522 File Offset: 0x000F0722
		public static Vector3 ViewToWorldPoint(Vector2 point)
		{
			return SingletonMonoBehavior<TouchManager>.Instance.ConvertViewToWorldPoint(point);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x000F252F File Offset: 0x000F072F
		public static Vector3 ScreenToViewPoint(Vector2 point)
		{
			return SingletonMonoBehavior<TouchManager>.Instance.ConvertScreenToViewPoint(point);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x000F253C File Offset: 0x000F073C
		public static float ConvertToWorld(float value, TouchUnitType unitType)
		{
			return value * ((unitType == TouchUnitType.Pixels) ? TouchManager.PixelToWorld : TouchManager.PercentToWorld);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x000F2550 File Offset: 0x000F0750
		public static Rect PercentToWorldRect(Rect rect)
		{
			return new Rect((rect.xMin - 50f) * TouchManager.ViewSize.x, (rect.yMin - 50f) * TouchManager.ViewSize.y, rect.width * TouchManager.ViewSize.x, rect.height * TouchManager.ViewSize.y);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000F25B8 File Offset: 0x000F07B8
		public static Rect PixelToWorldRect(Rect rect)
		{
			return new Rect(Mathf.Round(rect.xMin - TouchManager.HalfScreenSize.x) * TouchManager.PixelToWorld, Mathf.Round(rect.yMin - TouchManager.HalfScreenSize.y) * TouchManager.PixelToWorld, Mathf.Round(rect.width) * TouchManager.PixelToWorld, Mathf.Round(rect.height) * TouchManager.PixelToWorld);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000F2628 File Offset: 0x000F0828
		public static Rect ConvertToWorld(Rect rect, TouchUnitType unitType)
		{
			if (unitType != TouchUnitType.Pixels)
			{
				return TouchManager.PercentToWorldRect(rect);
			}
			return TouchManager.PixelToWorldRect(rect);
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x000F263B File Offset: 0x000F083B
		public static Camera Camera
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.touchCamera;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000F2647 File Offset: 0x000F0847
		public static InputDevice Device
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.device;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x000F2653 File Offset: 0x000F0853
		public static Vector3 ViewSize
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.viewSize;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000F265F File Offset: 0x000F085F
		public static float PercentToWorld
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.percentToWorld;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x000F266B File Offset: 0x000F086B
		public static float HalfPercentToWorld
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.halfPercentToWorld;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000F2677 File Offset: 0x000F0877
		public static float PixelToWorld
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.pixelToWorld;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000F2683 File Offset: 0x000F0883
		public static float HalfPixelToWorld
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.halfPixelToWorld;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x000F268F File Offset: 0x000F088F
		public static Vector2 ScreenSize
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.screenSize;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000F269B File Offset: 0x000F089B
		public static Vector2 HalfScreenSize
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.halfScreenSize;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002D0E RID: 11534 RVA: 0x000F26A7 File Offset: 0x000F08A7
		public static TouchManager.GizmoShowOption ControlsShowGizmos
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.controlsShowGizmos;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000F26B3 File Offset: 0x000F08B3
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x000F26BF File Offset: 0x000F08BF
		public static bool ControlsEnabled
		{
			get
			{
				return SingletonMonoBehavior<TouchManager>.Instance.controlsEnabled;
			}
			set
			{
				SingletonMonoBehavior<TouchManager>.Instance.controlsEnabled = value;
			}
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000F26CC File Offset: 0x000F08CC
		public static implicit operator bool(TouchManager instance)
		{
			return instance != null;
		}

		// Token: 0x04003276 RID: 12918
		[Space(10f)]
		public Camera touchCamera;

		// Token: 0x04003277 RID: 12919
		public TouchManager.GizmoShowOption controlsShowGizmos;

		// Token: 0x04003278 RID: 12920
		[HideInInspector]
		public bool enableControlsOnTouch;

		// Token: 0x04003279 RID: 12921
		[SerializeField]
		[HideInInspector]
		private bool _controlsEnabled;

		// Token: 0x0400327A RID: 12922
		[HideInInspector]
		public int controlsLayer;

		// Token: 0x0400327C RID: 12924
		private InputDevice device;

		// Token: 0x0400327D RID: 12925
		private Vector3 viewSize;

		// Token: 0x0400327E RID: 12926
		private Vector2 screenSize;

		// Token: 0x0400327F RID: 12927
		private Vector2 halfScreenSize;

		// Token: 0x04003280 RID: 12928
		private float percentToWorld;

		// Token: 0x04003281 RID: 12929
		private float halfPercentToWorld;

		// Token: 0x04003282 RID: 12930
		private float pixelToWorld;

		// Token: 0x04003283 RID: 12931
		private float halfPixelToWorld;

		// Token: 0x04003284 RID: 12932
		private TouchControl[] touchControls;

		// Token: 0x04003285 RID: 12933
		private TouchPool cachedTouches;

		// Token: 0x04003286 RID: 12934
		private List<Touch> activeTouches;

		// Token: 0x04003287 RID: 12935
		private ReadOnlyCollection<Touch> readOnlyActiveTouches;

		// Token: 0x04003288 RID: 12936
		private bool isReady;

		// Token: 0x04003289 RID: 12937
		private readonly Touch[] mouseTouches;

		// Token: 0x02000718 RID: 1816
		public enum GizmoShowOption
		{
			// Token: 0x0400328B RID: 12939
			Never,
			// Token: 0x0400328C RID: 12940
			WhenSelected,
			// Token: 0x0400328D RID: 12941
			UnlessPlaying,
			// Token: 0x0400328E RID: 12942
			Always
		}
	}
}
