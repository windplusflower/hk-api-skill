using System;
using GlobalEnums;
using InControl;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200044A RID: 1098
[RequireComponent(typeof(Image))]
public class ControllerDetect : MonoBehaviour
{
	// Token: 0x060018A5 RID: 6309 RVA: 0x00073718 File Offset: 0x00071918
	private void Awake()
	{
		this.gm = GameManager.instance;
		this.ih = this.gm.inputHandler;
		this.ui = UIManager.instance;
		this.controllerImage = base.GetComponent<Image>();
		this.profileYPos = base.GetComponent<RectTransform>().anchoredPosition.y;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00073770 File Offset: 0x00071970
	private void OnEnable()
	{
		this.LookForActiveController();
		Debug.LogFormat("Subscribing to controller detection.", Array.Empty<object>());
		InputManager.OnActiveDeviceChanged += this.ControllerActivated;
		InputManager.OnDeviceAttached += this.ControllerAttached;
		InputManager.OnDeviceDetached += this.ControllerDetached;
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x000737C8 File Offset: 0x000719C8
	private void OnDisable()
	{
		Debug.LogFormat("Unsubscribing from controller detection.", Array.Empty<object>());
		InputManager.OnActiveDeviceChanged -= this.ControllerActivated;
		InputManager.OnDeviceAttached -= this.ControllerAttached;
		InputManager.OnDeviceDetached -= this.ControllerDetached;
	}

	// Token: 0x060018A8 RID: 6312 RVA: 0x00073817 File Offset: 0x00071A17
	private void ControllerActivated(InputDevice inputDevice)
	{
		Debug.LogFormat("CD - Controller Activated: {0} : {1}", new object[]
		{
			this.ih.gamepadState,
			this.ih.activeGamepadType
		});
		this.LookForActiveController();
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00073855 File Offset: 0x00071A55
	private void ControllerAttached(InputDevice inputDevice)
	{
		Debug.LogFormat("CD - Controller Attached: {0} : {1}", new object[]
		{
			this.ih.gamepadState,
			this.ih.activeGamepadType
		});
		this.LookForActiveController();
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x00073894 File Offset: 0x00071A94
	private void ControllerDetached(InputDevice inputDevice)
	{
		Debug.LogFormat("CD - Controller Detached: {0} : {1}", new object[]
		{
			this.ih.gamepadState,
			this.ih.activeGamepadType
		});
		this.LookForActiveController();
		if (EventSystem.current != this.applyButton)
		{
			this.applyButton.Select();
		}
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x000738FC File Offset: 0x00071AFC
	private void ShowController(GamepadType gamepadType)
	{
		GamepadType gamepadType2;
		if (gamepadType == GamepadType.PS3_WIN)
		{
			gamepadType2 = GamepadType.PS4;
		}
		else
		{
			gamepadType2 = gamepadType;
		}
		for (int i = 0; i < this.controllerImages.Length; i++)
		{
			if (this.controllerImages[i].gamepadType == gamepadType2)
			{
				this.controllerImage.sprite = this.controllerImages[i].sprite;
				if (this.controllerImages[i].buttonPositions != null)
				{
					this.controllerImages[i].buttonPositions.gameObject.SetActive(true);
				}
				base.transform.localScale = new Vector3(this.controllerImages[i].displayScale, this.controllerImages[i].displayScale, 1f);
				RectTransform component = base.GetComponent<RectTransform>();
				Vector2 anchoredPosition = component.anchoredPosition;
				anchoredPosition.y = this.profileYPos + this.controllerImages[i].offsetY;
				component.anchoredPosition = anchoredPosition;
			}
			else if (this.controllerImages[i].buttonPositions != null)
			{
				this.controllerImages[i].buttonPositions.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060018AC RID: 6316 RVA: 0x00073A10 File Offset: 0x00071C10
	private void HideButtonLabels()
	{
		for (int i = 0; i < this.controllerImages.Length; i++)
		{
			if (this.controllerImages[i].buttonPositions != null)
			{
				this.controllerImages[i].buttonPositions.gameObject.SetActive(false);
			}
		}
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x00073A60 File Offset: 0x00071C60
	private void LookForActiveController()
	{
		if (this.ih.gamepadState == GamepadState.DETACHED)
		{
			this.HideButtonLabels();
			this.controllerImage.sprite = this.controllerImages[0].sprite;
			this.ui.ShowCanvasGroup(this.controllerPrompt);
			this.remapButton.gameObject.SetActive(false);
			return;
		}
		if (this.ih.activeGamepadType != GamepadType.NONE)
		{
			this.ui.HideCanvasGroup(this.controllerPrompt);
			this.remapButton.gameObject.SetActive(true);
			this.ShowController(this.ih.activeGamepadType);
		}
	}

	// Token: 0x04001D93 RID: 7571
	private bool verboseMode;

	// Token: 0x04001D94 RID: 7572
	private GameManager gm;

	// Token: 0x04001D95 RID: 7573
	private UIManager ui;

	// Token: 0x04001D96 RID: 7574
	private InputHandler ih;

	// Token: 0x04001D97 RID: 7575
	private Image controllerImage;

	// Token: 0x04001D98 RID: 7576
	[Header("Controller Menu Items")]
	public CanvasGroup controllerPrompt;

	// Token: 0x04001D99 RID: 7577
	public CanvasGroup remapDialog;

	// Token: 0x04001D9A RID: 7578
	public CanvasGroup menuControls;

	// Token: 0x04001D9B RID: 7579
	public CanvasGroup remapControls;

	// Token: 0x04001D9C RID: 7580
	[Header("Controller Menu Preselect")]
	public Selectable controllerMenuPreselect;

	// Token: 0x04001D9D RID: 7581
	public Selectable remapMenuPreselect;

	// Token: 0x04001D9E RID: 7582
	[Header("Remap Menu Controls")]
	public MenuSelectable remapApplyButton;

	// Token: 0x04001D9F RID: 7583
	public MenuSelectable defaultsButton;

	// Token: 0x04001DA0 RID: 7584
	[Header("Controller Menu Controls")]
	public MenuButton applyButton;

	// Token: 0x04001DA1 RID: 7585
	public MenuButton remapButton;

	// Token: 0x04001DA2 RID: 7586
	[SerializeField]
	public ControllerImage[] controllerImages;

	// Token: 0x04001DA3 RID: 7587
	private float profileYPos;
}
