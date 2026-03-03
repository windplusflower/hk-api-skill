using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020005B9 RID: 1465
[AddComponentMenu("2D Toolkit/UI/Core/tk2dUIManager")]
public class tk2dUIManager : MonoBehaviour
{
	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x06002141 RID: 8513 RVA: 0x000A7160 File Offset: 0x000A5360
	public static tk2dUIManager Instance
	{
		get
		{
			if (tk2dUIManager.instance == null)
			{
				tk2dUIManager.instance = (UnityEngine.Object.FindObjectOfType(typeof(tk2dUIManager)) as tk2dUIManager);
				if (tk2dUIManager.instance == null)
				{
					tk2dUIManager.instance = new GameObject("tk2dUIManager").AddComponent<tk2dUIManager>();
				}
			}
			return tk2dUIManager.instance;
		}
	}

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x06002142 RID: 8514 RVA: 0x000A71B9 File Offset: 0x000A53B9
	public static tk2dUIManager Instance__NoCreate
	{
		get
		{
			return tk2dUIManager.instance;
		}
	}

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06002143 RID: 8515 RVA: 0x000A71C0 File Offset: 0x000A53C0
	// (set) Token: 0x06002144 RID: 8516 RVA: 0x000A71C8 File Offset: 0x000A53C8
	public Camera UICamera
	{
		get
		{
			return this.uiCamera;
		}
		set
		{
			this.uiCamera = value;
		}
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x000A71D4 File Offset: 0x000A53D4
	public Camera GetUICameraForControl(GameObject go)
	{
		int num = 1 << go.layer;
		int count = tk2dUIManager.allCameras.Count;
		for (int i = 0; i < count; i++)
		{
			tk2dUICamera tk2dUICamera = tk2dUIManager.allCameras[i];
			if ((tk2dUICamera.FilteredMask & num) != 0)
			{
				return tk2dUICamera.HostCamera;
			}
		}
		Debug.LogError("Unable to find UI camera for " + go.name);
		return null;
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x000A723C File Offset: 0x000A543C
	public static void RegisterCamera(tk2dUICamera cam)
	{
		tk2dUIManager.allCameras.Add(cam);
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x000A7249 File Offset: 0x000A5449
	public static void UnregisterCamera(tk2dUICamera cam)
	{
		tk2dUIManager.allCameras.Remove(cam);
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06002148 RID: 8520 RVA: 0x000A7257 File Offset: 0x000A5457
	// (set) Token: 0x06002149 RID: 8521 RVA: 0x000A725F File Offset: 0x000A545F
	public bool InputEnabled
	{
		get
		{
			return this.inputEnabled;
		}
		set
		{
			if (!this.inputEnabled || value)
			{
				this.inputEnabled = value;
				return;
			}
			this.SortCameras();
			this.inputEnabled = value;
			if (this.useMultiTouch)
			{
				this.CheckMultiTouchInputs();
				return;
			}
			this.CheckInputs();
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x0600214A RID: 8522 RVA: 0x000A7296 File Offset: 0x000A5496
	public tk2dUIItem PressedUIItem
	{
		get
		{
			if (!this.useMultiTouch)
			{
				return this.pressedUIItem;
			}
			if (this.pressedUIItems.Length != 0)
			{
				return this.pressedUIItems[this.pressedUIItems.Length - 1];
			}
			return null;
		}
	}

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x0600214B RID: 8523 RVA: 0x000A72C3 File Offset: 0x000A54C3
	public tk2dUIItem[] PressedUIItems
	{
		get
		{
			return this.pressedUIItems;
		}
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x0600214C RID: 8524 RVA: 0x000A72CB File Offset: 0x000A54CB
	// (set) Token: 0x0600214D RID: 8525 RVA: 0x000A72D3 File Offset: 0x000A54D3
	public bool UseMultiTouch
	{
		get
		{
			return this.useMultiTouch;
		}
		set
		{
			if (this.useMultiTouch != value && this.inputEnabled)
			{
				this.InputEnabled = false;
				this.useMultiTouch = value;
				this.InputEnabled = true;
				return;
			}
			this.useMultiTouch = value;
		}
	}

	// Token: 0x1400005F RID: 95
	// (add) Token: 0x0600214E RID: 8526 RVA: 0x000A7304 File Offset: 0x000A5504
	// (remove) Token: 0x0600214F RID: 8527 RVA: 0x000A733C File Offset: 0x000A553C
	public event Action OnAnyPress;

	// Token: 0x14000060 RID: 96
	// (add) Token: 0x06002150 RID: 8528 RVA: 0x000A7374 File Offset: 0x000A5574
	// (remove) Token: 0x06002151 RID: 8529 RVA: 0x000A73AC File Offset: 0x000A55AC
	public event Action OnInputUpdate;

	// Token: 0x14000061 RID: 97
	// (add) Token: 0x06002152 RID: 8530 RVA: 0x000A73E4 File Offset: 0x000A55E4
	// (remove) Token: 0x06002153 RID: 8531 RVA: 0x000A741C File Offset: 0x000A561C
	public event Action<float> OnScrollWheelChange;

	// Token: 0x06002154 RID: 8532 RVA: 0x000A7454 File Offset: 0x000A5654
	private void SortCameras()
	{
		this.sortedCameras.Clear();
		int count = tk2dUIManager.allCameras.Count;
		for (int i = 0; i < count; i++)
		{
			tk2dUICamera tk2dUICamera = tk2dUIManager.allCameras[i];
			if (tk2dUICamera != null)
			{
				this.sortedCameras.Add(tk2dUICamera);
			}
		}
		this.sortedCameras.Sort((tk2dUICamera a, tk2dUICamera b) => b.GetComponent<Camera>().depth.CompareTo(a.GetComponent<Camera>().depth));
	}

	// Token: 0x06002155 RID: 8533 RVA: 0x000A74D0 File Offset: 0x000A56D0
	private void Awake()
	{
		if (tk2dUIManager.instance == null)
		{
			tk2dUIManager.instance = this;
			if (tk2dUIManager.instance.transform.childCount != 0)
			{
				Debug.LogError("You should not attach anything to the tk2dUIManager object. The tk2dUIManager will not get destroyed between scene switches and any children will persist as well.");
			}
			if (Application.isPlaying)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
		}
		else if (tk2dUIManager.instance != this)
		{
			Debug.Log("Discarding unnecessary tk2dUIManager instance.");
			if (this.uiCamera != null)
			{
				this.HookUpLegacyCamera(this.uiCamera);
				this.uiCamera = null;
			}
			UnityEngine.Object.Destroy(this);
			return;
		}
		tk2dUITime.Init();
		this.Setup();
	}

	// Token: 0x06002156 RID: 8534 RVA: 0x000A7569 File Offset: 0x000A5769
	private void HookUpLegacyCamera(Camera cam)
	{
		if (cam.GetComponent<tk2dUICamera>() == null)
		{
			cam.gameObject.AddComponent<tk2dUICamera>().AssignRaycastLayerMask(this.raycastLayerMask);
		}
	}

	// Token: 0x06002157 RID: 8535 RVA: 0x000A7590 File Offset: 0x000A5790
	private void Start()
	{
		if (this.uiCamera != null)
		{
			Debug.Log("It is no longer necessary to hook up a camera to the tk2dUIManager. You can simply attach a tk2dUICamera script to the cameras that interact with UI.");
			this.HookUpLegacyCamera(this.uiCamera);
			this.uiCamera = null;
		}
		if (tk2dUIManager.allCameras.Count == 0)
		{
			Debug.LogError("Unable to find any tk2dUICameras, and no cameras are connected to the tk2dUIManager. You will not be able to interact with the UI.");
		}
	}

	// Token: 0x06002158 RID: 8536 RVA: 0x000A75DE File Offset: 0x000A57DE
	private void Setup()
	{
		if (!this.areHoverEventsTracked)
		{
			this.checkForHovers = false;
		}
	}

	// Token: 0x06002159 RID: 8537 RVA: 0x000A75F0 File Offset: 0x000A57F0
	private void Update()
	{
		tk2dUITime.Update();
		if (this.inputEnabled)
		{
			this.SortCameras();
			if (this.useMultiTouch)
			{
				this.CheckMultiTouchInputs();
			}
			else
			{
				this.CheckInputs();
			}
			if (this.OnInputUpdate != null)
			{
				this.OnInputUpdate();
			}
			if (this.OnScrollWheelChange != null)
			{
				float axis = Input.GetAxis("Mouse ScrollWheel");
				if (axis != 0f)
				{
					this.OnScrollWheelChange(axis);
				}
			}
		}
	}

	// Token: 0x0600215A RID: 8538 RVA: 0x000A7660 File Offset: 0x000A5860
	private void CheckInputs()
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		this.primaryTouch = default(tk2dUITouch);
		this.secondaryTouch = default(tk2dUITouch);
		this.resultTouch = default(tk2dUITouch);
		this.hitUIItem = null;
		if (this.inputEnabled)
		{
			int touchCount = Input.touchCount;
			if (Input.touchCount > 0)
			{
				for (int i = 0; i < touchCount; i++)
				{
					Touch touch = Input.GetTouch(i);
					if (touch.phase == TouchPhase.Began)
					{
						this.primaryTouch = new tk2dUITouch(touch);
						flag = true;
						flag3 = true;
					}
					else if (this.pressedUIItem != null && touch.fingerId == this.firstPressedUIItemTouch.fingerId)
					{
						this.secondaryTouch = new tk2dUITouch(touch);
						flag2 = true;
					}
				}
				this.checkForHovers = false;
			}
			else if (Input.GetMouseButtonDown(0))
			{
				this.primaryTouch = new tk2dUITouch(TouchPhase.Began, 9999, Input.mousePosition, Vector2.zero, 0f);
				flag = true;
				flag3 = true;
			}
			else if (Input.GetMouseButton(0) || Input.GetMouseButtonUp(0))
			{
				Vector2 vector = Vector2.zero;
				TouchPhase phase = TouchPhase.Moved;
				if (this.pressedUIItem != null)
				{
					vector = this.firstPressedUIItemTouch.position - new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				if (Input.GetMouseButtonUp(0))
				{
					phase = TouchPhase.Ended;
				}
				else if (vector == Vector2.zero)
				{
					phase = TouchPhase.Stationary;
				}
				this.secondaryTouch = new tk2dUITouch(phase, 9999, Input.mousePosition, vector, tk2dUITime.deltaTime);
				flag2 = true;
			}
		}
		if (flag)
		{
			this.resultTouch = this.primaryTouch;
		}
		else if (flag2)
		{
			this.resultTouch = this.secondaryTouch;
		}
		if (flag || flag2)
		{
			this.hitUIItem = this.RaycastForUIItem(this.resultTouch.position);
			if (this.resultTouch.phase == TouchPhase.Began)
			{
				if (this.pressedUIItem != null)
				{
					this.pressedUIItem.CurrentOverUIItem(this.hitUIItem);
					if (this.pressedUIItem != this.hitUIItem)
					{
						this.pressedUIItem.Release();
						this.pressedUIItem = null;
					}
					else
					{
						this.firstPressedUIItemTouch = this.resultTouch;
					}
				}
				if (this.hitUIItem != null)
				{
					this.hitUIItem.Press(this.resultTouch);
				}
				this.pressedUIItem = this.hitUIItem;
				this.firstPressedUIItemTouch = this.resultTouch;
			}
			else if (this.resultTouch.phase == TouchPhase.Ended)
			{
				if (this.pressedUIItem != null)
				{
					this.pressedUIItem.CurrentOverUIItem(this.hitUIItem);
					this.pressedUIItem.UpdateTouch(this.resultTouch);
					this.pressedUIItem.Release();
					this.pressedUIItem = null;
				}
			}
			else if (this.pressedUIItem != null)
			{
				this.pressedUIItem.CurrentOverUIItem(this.hitUIItem);
				this.pressedUIItem.UpdateTouch(this.resultTouch);
			}
		}
		else if (this.pressedUIItem != null)
		{
			this.pressedUIItem.CurrentOverUIItem(null);
			this.pressedUIItem.Release();
			this.pressedUIItem = null;
		}
		if (this.checkForHovers)
		{
			if (this.inputEnabled)
			{
				if (!flag && !flag2 && this.hitUIItem == null && !Input.GetMouseButton(0))
				{
					this.hitUIItem = this.RaycastForUIItem(Input.mousePosition);
				}
				else if (Input.GetMouseButton(0))
				{
					this.hitUIItem = null;
				}
			}
			if (this.hitUIItem != null)
			{
				if (this.hitUIItem.isHoverEnabled)
				{
					if (!this.hitUIItem.HoverOver(this.overUIItem) && this.overUIItem != null)
					{
						this.overUIItem.HoverOut(this.hitUIItem);
					}
					this.overUIItem = this.hitUIItem;
				}
				else if (this.overUIItem != null)
				{
					this.overUIItem.HoverOut(null);
				}
			}
			else if (this.overUIItem != null)
			{
				this.overUIItem.HoverOut(null);
			}
		}
		if (flag3 && this.OnAnyPress != null)
		{
			this.OnAnyPress();
		}
	}

	// Token: 0x0600215B RID: 8539 RVA: 0x000A7A8C File Offset: 0x000A5C8C
	private void CheckMultiTouchInputs()
	{
		bool flag = false;
		this.touchCounter = 0;
		if (this.inputEnabled)
		{
			if (Input.touchCount > 0)
			{
				foreach (Touch touch in Input.touches)
				{
					if (this.touchCounter >= 5)
					{
						break;
					}
					this.allTouches[this.touchCounter] = new tk2dUITouch(touch);
					this.touchCounter++;
				}
			}
			else if (Input.GetMouseButtonDown(0))
			{
				this.allTouches[this.touchCounter] = new tk2dUITouch(TouchPhase.Began, 9999, Input.mousePosition, Vector2.zero, 0f);
				this.mouseDownFirstPos = Input.mousePosition;
				this.touchCounter++;
			}
			else if (Input.GetMouseButton(0) || Input.GetMouseButtonUp(0))
			{
				Vector2 vector = this.mouseDownFirstPos - new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				TouchPhase phase = TouchPhase.Moved;
				if (Input.GetMouseButtonUp(0))
				{
					phase = TouchPhase.Ended;
				}
				else if (vector == Vector2.zero)
				{
					phase = TouchPhase.Stationary;
				}
				this.allTouches[this.touchCounter] = new tk2dUITouch(phase, 9999, Input.mousePosition, vector, tk2dUITime.deltaTime);
				this.touchCounter++;
			}
		}
		for (int j = 0; j < this.touchCounter; j++)
		{
			this.pressedUIItems[j] = this.RaycastForUIItem(this.allTouches[j].position);
		}
		for (int k = 0; k < this.prevPressedUIItemList.Count; k++)
		{
			this.prevPressedItem = this.prevPressedUIItemList[k];
			if (this.prevPressedItem != null)
			{
				int fingerId = this.prevPressedItem.Touch.fingerId;
				bool flag2 = false;
				int l = 0;
				while (l < this.touchCounter)
				{
					this.currTouch = this.allTouches[l];
					if (this.currTouch.fingerId == fingerId)
					{
						flag2 = true;
						this.currPressedItem = this.pressedUIItems[l];
						if (this.currTouch.phase == TouchPhase.Began)
						{
							this.prevPressedItem.CurrentOverUIItem(this.currPressedItem);
							if (this.prevPressedItem != this.currPressedItem)
							{
								this.prevPressedItem.Release();
								this.prevPressedUIItemList.RemoveAt(k);
								k--;
								break;
							}
							break;
						}
						else
						{
							if (this.currTouch.phase == TouchPhase.Ended)
							{
								this.prevPressedItem.CurrentOverUIItem(this.currPressedItem);
								this.prevPressedItem.UpdateTouch(this.currTouch);
								this.prevPressedItem.Release();
								this.prevPressedUIItemList.RemoveAt(k);
								k--;
								break;
							}
							this.prevPressedItem.CurrentOverUIItem(this.currPressedItem);
							this.prevPressedItem.UpdateTouch(this.currTouch);
							break;
						}
					}
					else
					{
						l++;
					}
				}
				if (!flag2)
				{
					this.prevPressedItem.CurrentOverUIItem(null);
					this.prevPressedItem.Release();
					this.prevPressedUIItemList.RemoveAt(k);
					k--;
				}
			}
		}
		for (int m = 0; m < this.touchCounter; m++)
		{
			this.currPressedItem = this.pressedUIItems[m];
			this.currTouch = this.allTouches[m];
			if (this.currTouch.phase == TouchPhase.Began)
			{
				if (this.currPressedItem != null && this.currPressedItem.Press(this.currTouch))
				{
					this.prevPressedUIItemList.Add(this.currPressedItem);
				}
				flag = true;
			}
		}
		if (flag && this.OnAnyPress != null)
		{
			this.OnAnyPress();
		}
	}

	// Token: 0x0600215C RID: 8540 RVA: 0x000A7E6C File Offset: 0x000A606C
	private tk2dUIItem RaycastForUIItem(Vector2 screenPos)
	{
		int count = this.sortedCameras.Count;
		for (int i = 0; i < count; i++)
		{
			tk2dUICamera tk2dUICamera = this.sortedCameras[i];
			if (tk2dUICamera.RaycastType == tk2dUICamera.tk2dRaycastType.Physics3D)
			{
				this.ray = tk2dUICamera.HostCamera.ScreenPointToRay(screenPos);
				if (Physics.Raycast(this.ray, out this.hit, tk2dUICamera.HostCamera.farClipPlane - tk2dUICamera.HostCamera.nearClipPlane, tk2dUICamera.FilteredMask))
				{
					return this.hit.collider.GetComponent<tk2dUIItem>();
				}
			}
			else if (tk2dUICamera.RaycastType == tk2dUICamera.tk2dRaycastType.Physics2D)
			{
				Collider2D collider2D = Physics2D.OverlapPoint(tk2dUICamera.HostCamera.ScreenToWorldPoint(screenPos), tk2dUICamera.FilteredMask);
				if (collider2D != null)
				{
					return collider2D.GetComponent<tk2dUIItem>();
				}
			}
		}
		return null;
	}

	// Token: 0x0600215D RID: 8541 RVA: 0x000A7F4C File Offset: 0x000A614C
	public void OverrideClearAllChildrenPresses(tk2dUIItem item)
	{
		if (this.useMultiTouch)
		{
			for (int i = 0; i < this.pressedUIItems.Length; i++)
			{
				tk2dUIItem tk2dUIItem = this.pressedUIItems[i];
				if (tk2dUIItem != null && item.CheckIsUIItemChildOfMe(tk2dUIItem))
				{
					tk2dUIItem.CurrentOverUIItem(item);
				}
			}
			return;
		}
		if (this.pressedUIItem != null && item.CheckIsUIItemChildOfMe(this.pressedUIItem))
		{
			this.pressedUIItem.CurrentOverUIItem(item);
		}
	}

	// Token: 0x0600215E RID: 8542 RVA: 0x000A7FC0 File Offset: 0x000A61C0
	public tk2dUIManager()
	{
		this.sortedCameras = new List<tk2dUICamera>();
		this.raycastLayerMask = -1;
		this.inputEnabled = true;
		this.areHoverEventsTracked = true;
		this.checkForHovers = true;
		this.allTouches = new tk2dUITouch[5];
		this.prevPressedUIItemList = new List<tk2dUIItem>();
		this.pressedUIItems = new tk2dUIItem[5];
		this.mouseDownFirstPos = Vector2.zero;
		base..ctor();
	}

	// Token: 0x0600215F RID: 8543 RVA: 0x000A802D File Offset: 0x000A622D
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dUIManager()
	{
		tk2dUIManager.version = 1.0;
		tk2dUIManager.releaseId = 0;
		tk2dUIManager.allCameras = new List<tk2dUICamera>();
	}

	// Token: 0x040026B1 RID: 9905
	public static double version;

	// Token: 0x040026B2 RID: 9906
	public static int releaseId;

	// Token: 0x040026B3 RID: 9907
	private static tk2dUIManager instance;

	// Token: 0x040026B4 RID: 9908
	[SerializeField]
	private Camera uiCamera;

	// Token: 0x040026B5 RID: 9909
	private static List<tk2dUICamera> allCameras;

	// Token: 0x040026B6 RID: 9910
	private List<tk2dUICamera> sortedCameras;

	// Token: 0x040026B7 RID: 9911
	public LayerMask raycastLayerMask;

	// Token: 0x040026B8 RID: 9912
	private bool inputEnabled;

	// Token: 0x040026B9 RID: 9913
	public bool areHoverEventsTracked;

	// Token: 0x040026BA RID: 9914
	private tk2dUIItem pressedUIItem;

	// Token: 0x040026BB RID: 9915
	private tk2dUIItem overUIItem;

	// Token: 0x040026BC RID: 9916
	private tk2dUITouch firstPressedUIItemTouch;

	// Token: 0x040026BD RID: 9917
	private bool checkForHovers;

	// Token: 0x040026BE RID: 9918
	[SerializeField]
	private bool useMultiTouch;

	// Token: 0x040026BF RID: 9919
	private const int MAX_MULTI_TOUCH_COUNT = 5;

	// Token: 0x040026C0 RID: 9920
	private tk2dUITouch[] allTouches;

	// Token: 0x040026C1 RID: 9921
	private List<tk2dUIItem> prevPressedUIItemList;

	// Token: 0x040026C2 RID: 9922
	private tk2dUIItem[] pressedUIItems;

	// Token: 0x040026C3 RID: 9923
	private int touchCounter;

	// Token: 0x040026C4 RID: 9924
	private Vector2 mouseDownFirstPos;

	// Token: 0x040026C5 RID: 9925
	private const string MOUSE_WHEEL_AXES_NAME = "Mouse ScrollWheel";

	// Token: 0x040026C6 RID: 9926
	private tk2dUITouch primaryTouch;

	// Token: 0x040026C7 RID: 9927
	private tk2dUITouch secondaryTouch;

	// Token: 0x040026C8 RID: 9928
	private tk2dUITouch resultTouch;

	// Token: 0x040026C9 RID: 9929
	private tk2dUIItem hitUIItem;

	// Token: 0x040026CA RID: 9930
	private RaycastHit hit;

	// Token: 0x040026CB RID: 9931
	private Ray ray;

	// Token: 0x040026CC RID: 9932
	private tk2dUITouch currTouch;

	// Token: 0x040026CD RID: 9933
	private tk2dUIItem currPressedItem;

	// Token: 0x040026CE RID: 9934
	private tk2dUIItem prevPressedItem;
}
