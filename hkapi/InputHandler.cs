using System;
using System.Collections;
using System.Collections.Generic;
using GlobalEnums;
using InControl;
using Modding;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020002A5 RID: 677
[RequireComponent(typeof(GameManager))]
public class InputHandler : MonoBehaviour
{
	// Token: 0x1400001F RID: 31
	// (add) Token: 0x06000E23 RID: 3619 RVA: 0x00045590 File Offset: 0x00043790
	// (remove) Token: 0x06000E24 RID: 3620 RVA: 0x000455C8 File Offset: 0x000437C8
	public event InputHandler.CursorVisibilityChange OnCursorVisibilityChange;

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000455FD File Offset: 0x000437FD
	// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00045605 File Offset: 0x00043805
	public List<PlayerAction> mappableControllerActions { get; private set; }

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x06000E27 RID: 3623 RVA: 0x0004560E File Offset: 0x0004380E
	// (set) Token: 0x06000E28 RID: 3624 RVA: 0x00045616 File Offset: 0x00043816
	public List<PlayerAction> unmappedActions { get; private set; }

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0004561F File Offset: 0x0004381F
	// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00045627 File Offset: 0x00043827
	[SerializeField]
	public bool pauseAllowed { get; private set; }

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00045630 File Offset: 0x00043830
	// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00045638 File Offset: 0x00043838
	public SkipPromptMode skipMode { get; private set; }

	// Token: 0x14000020 RID: 32
	// (add) Token: 0x06000E2D RID: 3629 RVA: 0x00045644 File Offset: 0x00043844
	// (remove) Token: 0x06000E2E RID: 3630 RVA: 0x0004567C File Offset: 0x0004387C
	public event InputHandler.ActiveControllerSwitch RefreshActiveControllerEvent;

	// Token: 0x06000E2F RID: 3631 RVA: 0x000456B4 File Offset: 0x000438B4
	public void Awake()
	{
		InputHandler.Instance = this;
		this.gm = base.GetComponent<GameManager>();
		this.debugInfo = base.GetComponent<OnScreenDebugInfo>();
		this.gs = this.gm.gameSettings;
		this.gc = this.gm.gameConfig;
		this.inputActions = new HeroActions();
		this.acceptingInput = true;
		this.pauseAllowed = true;
		this.skipMode = SkipPromptMode.NOT_SKIPPABLE;
		SaveDataUpgradeHandler.UpgradeSystemData<InputHandler>(this);
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00045728 File Offset: 0x00043928
	public void Start()
	{
		this.playerData = this.gm.playerData;
		this.SetupNonMappableBindings();
		this.gs.LoadKeyboardSettings();
		this.MapKeyboardLayoutFromGameSettings();
		InputManager.OnDeviceAttached += this.ControllerAttached;
		InputManager.OnActiveDeviceChanged += this.ControllerActivated;
		InputManager.OnDeviceDetached += this.ControllerDetached;
		if (InputManager.ActiveDevice != null && InputManager.ActiveDevice.IsAttached)
		{
			this.ControllerActivated(InputManager.ActiveDevice);
		}
		else
		{
			this.gameController = InputDevice.Null;
		}
		Debug.LogFormat("Game controller set to {0}.", new object[]
		{
			this.gameController.Name
		});
		this.lastActiveController = BindingSourceType.None;
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x000457E0 File Offset: 0x000439E0
	private void OnDestroy()
	{
		InputManager.OnDeviceAttached -= this.ControllerAttached;
		InputManager.OnActiveDeviceChanged -= this.ControllerActivated;
		InputManager.OnDeviceDetached -= this.ControllerDetached;
		this.inputActions.Destroy();
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00045820 File Offset: 0x00043A20
	public void SceneInit()
	{
		if (this.gm.IsGameplayScene())
		{
			this.isGameplayScene = true;
		}
		else
		{
			this.isGameplayScene = false;
		}
		if (this.gm.IsTitleScreenScene())
		{
			this.isTitleScreenScene = true;
		}
		else
		{
			this.isTitleScreenScene = false;
		}
		if (this.gm.IsMenuScene())
		{
			this.isMenuScene = true;
		}
		else
		{
			this.isMenuScene = false;
		}
		if (this.gm.IsStagTravelScene())
		{
			this.isStagTravelScene = true;
			this.stagLockoutActive = true;
			base.Invoke("UnlockStagInput", this.stagLockoutDuration);
			return;
		}
		this.isStagTravelScene = false;
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x000458B8 File Offset: 0x00043AB8
	private void OnGUI()
	{
		Cursor.lockState = CursorLockMode.None;
		if (this.isTitleScreenScene)
		{
			Cursor.visible = false;
			return;
		}
		if (!this.isMenuScene)
		{
			ModHooks.OnCursor(this.gm);
			return;
		}
		if (this.controllerPressed)
		{
			Cursor.visible = false;
			return;
		}
		Cursor.visible = true;
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x000458F8 File Offset: 0x00043AF8
	private void SetCursorVisible(bool value)
	{
		InputHandler.SetCursorEnabled(value);
		if (this.OnCursorVisibilityChange != null)
		{
			this.OnCursorVisibilityChange(value);
		}
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00045914 File Offset: 0x00043B14
	private static void SetCursorEnabled(bool isEnabled)
	{
		if (isEnabled && Platform.Current.IsMouseSupported)
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			return;
		}
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00045940 File Offset: 0x00043B40
	private void Update()
	{
		this.UpdateActiveController();
		if (this.acceptingInput)
		{
			if (this.gm.gameState == GameState.PLAYING)
			{
				this.PlayingInput();
			}
			else if (this.gm.gameState == GameState.CUTSCENE)
			{
				if (this.isStagTravelScene)
				{
					if (!this.stagLockoutActive)
					{
						this.StagCutsceneInput();
					}
				}
				else
				{
					this.CutsceneInput();
				}
			}
			if (this.inputActions.pause.WasPressed && this.pauseAllowed && !this.playerData.GetBool("disablePause") && (this.gm.gameState == GameState.PLAYING || this.gm.gameState == GameState.PAUSED))
			{
				base.StartCoroutine(this.gm.PauseGameToggle());
			}
		}
		if (this.gc.enableDebugButtons)
		{
			if (Input.GetKeyDown(KeyCode.End) || Input.GetKeyDown(KeyCode.Quote))
			{
				this.debugInfo.ShowGameInfo();
			}
			if (Input.GetKeyDown(KeyCode.Home) || Input.GetKeyDown(KeyCode.Semicolon))
			{
				this.debugInfo.ShowFPS();
				this.debugInfo.ShowLoadingTime();
				this.debugInfo.ShowTargetFrameRate();
			}
		}
		if (this.controllerPressed)
		{
			if (Mathf.Abs(Input.GetAxisRaw("mouse x")) > 0.1f)
			{
				this.controllerPressed = false;
				return;
			}
		}
		else if (this.inputActions.ActiveDevice.AnyButtonIsPressed || this.inputActions.moveVector.WasPressed)
		{
			this.controllerPressed = true;
		}
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00045AAE File Offset: 0x00043CAE
	private void ControllerAttached(InputDevice inputDevice)
	{
		this.gamepadState = GamepadState.ATTACHED;
		this.gameController = inputDevice;
		Debug.LogFormat("Game controller {0} attached", new object[]
		{
			inputDevice.Name
		});
		this.SetActiveGamepadType(inputDevice);
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00045ADE File Offset: 0x00043CDE
	private void ControllerActivated(InputDevice inputDevice)
	{
		this.gamepadState = GamepadState.ACTIVATED;
		this.gameController = inputDevice;
		Debug.LogFormat("Game controller set to {0}.", new object[]
		{
			inputDevice.Name
		});
		this.SetActiveGamepadType(inputDevice);
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00045B10 File Offset: 0x00043D10
	private void ControllerDetached(InputDevice inputDevice)
	{
		this.gamepadState = GamepadState.DETACHED;
		this.activeGamepadType = GamepadType.NONE;
		this.gameController = InputDevice.Null;
		Debug.LogFormat("Game controller {0} detached.", new object[]
		{
			inputDevice.Name
		});
		UIManager instance = UIManager.instance;
		if (instance.uiButtonSkins.listeningButton != null)
		{
			instance.uiButtonSkins.listeningButton.StopActionListening();
			instance.uiButtonSkins.listeningButton.AbortRebind();
			instance.uiButtonSkins.RefreshButtonMappings();
		}
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00003603 File Offset: 0x00001803
	private void PlayingInput()
	{
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00045B94 File Offset: 0x00043D94
	private void CutsceneInput()
	{
		if (!Input.anyKeyDown && !this.gameController.AnyButton.WasPressed)
		{
			return;
		}
		if (this.skippingCutscene)
		{
			return;
		}
		switch (this.skipMode)
		{
		case SkipPromptMode.SKIP_PROMPT:
			if (!this.readyToSkipCutscene)
			{
				this.gm.ui.ShowCutscenePrompt(CinematicSkipPopup.Texts.Skip);
				this.readyToSkipCutscene = true;
				base.CancelInvoke("StopCutsceneInput");
				base.Invoke("StopCutsceneInput", 5f * Time.timeScale);
				this.skipCooldownTime = Time.time + 0.3f;
				return;
			}
			if (Time.time < this.skipCooldownTime)
			{
				return;
			}
			base.CancelInvoke("StopCutsceneInput");
			this.readyToSkipCutscene = false;
			this.skippingCutscene = true;
			this.gm.SkipCutscene();
			return;
		case SkipPromptMode.SKIP_INSTANT:
			this.skippingCutscene = true;
			this.gm.SkipCutscene();
			return;
		case SkipPromptMode.NOT_SKIPPABLE:
			break;
		case SkipPromptMode.NOT_SKIPPABLE_DUE_TO_LOADING:
			this.gm.ui.ShowCutscenePrompt(CinematicSkipPopup.Texts.Loading);
			base.CancelInvoke("StopCutsceneInput");
			base.Invoke("StopCutsceneInput", 5f * Time.timeScale);
			break;
		default:
			return;
		}
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x00045CAD File Offset: 0x00043EAD
	private void StagCutsceneInput()
	{
		if (Input.anyKeyDown || this.gameController.AnyButton.WasPressed)
		{
			this.gm.SkipCutscene();
		}
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00045CD3 File Offset: 0x00043ED3
	private void BetaEndInput()
	{
		if (Input.anyKeyDown || this.gameController.AnyButton.WasPressed)
		{
			base.StartCoroutine(this.gm.ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes.SaveAndContinueOnFail, null));
		}
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00045D02 File Offset: 0x00043F02
	public void AttachHeroController(HeroController heroController)
	{
		this.heroCtrl = heroController;
		this.cState = this.heroCtrl.cState;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00045D1C File Offset: 0x00043F1C
	public void StopAcceptingInput()
	{
		this.acceptingInput = false;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00045D25 File Offset: 0x00043F25
	public void StartAcceptingInput()
	{
		this.acceptingInput = true;
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00045D2E File Offset: 0x00043F2E
	public void PreventPause()
	{
		this.pauseAllowed = false;
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00045D37 File Offset: 0x00043F37
	public void AllowPause()
	{
		this.pauseAllowed = true;
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00045D40 File Offset: 0x00043F40
	public void UpdateActiveController()
	{
		if (this.lastActiveController != this.inputActions.LastInputType || this.lastInputDeviceStyle != this.inputActions.LastDeviceStyle)
		{
			this.lastActiveController = this.inputActions.LastInputType;
			this.lastInputDeviceStyle = this.inputActions.LastDeviceStyle;
			if (this.RefreshActiveControllerEvent != null)
			{
				this.RefreshActiveControllerEvent();
			}
		}
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00045DA8 File Offset: 0x00043FA8
	public void StopUIInput()
	{
		this.acceptingInput = false;
		EventSystem.current.sendNavigationEvents = false;
		UIManager.instance.inputModule.allowMouseInput = false;
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00045DCC File Offset: 0x00043FCC
	public void StartUIInput()
	{
		this.acceptingInput = true;
		EventSystem.current.sendNavigationEvents = true;
		UIManager.instance.inputModule.allowMouseInput = true;
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00045DF0 File Offset: 0x00043FF0
	public void StopMouseInput()
	{
		UIManager.instance.inputModule.allowMouseInput = false;
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00045E02 File Offset: 0x00044002
	public void EnableMouseInput()
	{
		UIManager.instance.inputModule.allowMouseInput = true;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00045E14 File Offset: 0x00044014
	public void SetSkipMode(SkipPromptMode newMode)
	{
		Debug.Log("Setting skip mode: " + newMode.ToString());
		if (newMode == SkipPromptMode.NOT_SKIPPABLE)
		{
			this.StopAcceptingInput();
		}
		else if (newMode == SkipPromptMode.SKIP_PROMPT)
		{
			this.readyToSkipCutscene = false;
			this.StartAcceptingInput();
		}
		else if (newMode == SkipPromptMode.SKIP_INSTANT)
		{
			this.StartAcceptingInput();
		}
		else if (newMode == SkipPromptMode.NOT_SKIPPABLE_DUE_TO_LOADING)
		{
			this.readyToSkipCutscene = false;
			this.StartAcceptingInput();
		}
		this.skipMode = newMode;
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00045E7F File Offset: 0x0004407F
	public void RefreshPlayerData()
	{
		this.playerData = PlayerData.instance;
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00045E8C File Offset: 0x0004408C
	public void ResetDefaultKeyBindings()
	{
		if (this.verboseMode)
		{
			Debug.LogFormat("Active Device: {0} GamePadState: {1} GamePadType: {2}", new object[]
			{
				InputManager.ActiveDevice.Name,
				this.gamepadState,
				this.activeGamepadType
			});
		}
		this.inputActions.jump.ClearBindings();
		this.inputActions.attack.ClearBindings();
		this.inputActions.dash.ClearBindings();
		this.inputActions.cast.ClearBindings();
		this.inputActions.superDash.ClearBindings();
		this.inputActions.dreamNail.ClearBindings();
		this.inputActions.quickMap.ClearBindings();
		this.inputActions.openInventory.ClearBindings();
		this.inputActions.quickCast.ClearBindings();
		this.inputActions.up.ClearBindings();
		this.inputActions.down.ClearBindings();
		this.inputActions.left.ClearBindings();
		this.inputActions.right.ClearBindings();
		this.MapDefaultKeyboardLayout();
		this.gs.jumpKey = Key.Z.ToString();
		this.gs.attackKey = Key.X.ToString();
		this.gs.dashKey = Key.C.ToString();
		this.gs.castKey = Key.A.ToString();
		this.gs.superDashKey = Key.S.ToString();
		this.gs.dreamNailKey = Key.D.ToString();
		this.gs.quickMapKey = Key.Tab.ToString();
		this.gs.inventoryKey = Key.I.ToString();
		this.gs.quickCastKey = Key.F.ToString();
		this.gs.upKey = Key.UpArrow.ToString();
		this.gs.downKey = Key.DownArrow.ToString();
		this.gs.leftKey = Key.LeftArrow.ToString();
		this.gs.rightKey = Key.RightArrow.ToString();
		this.gs.SaveKeyboardSettings();
		if (this.gameController != InputDevice.Null)
		{
			this.SetActiveGamepadType(this.gameController);
		}
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00046134 File Offset: 0x00044334
	public void ResetDefaultControllerButtonBindings()
	{
		if (this.verboseMode)
		{
			Debug.LogFormat("Active Device: {0} GamePadState: {1} GamePadType: {2}", new object[]
			{
				InputManager.ActiveDevice.Name,
				this.gamepadState,
				this.activeGamepadType
			});
		}
		this.inputActions.jump.ClearBindings();
		this.inputActions.attack.ClearBindings();
		this.inputActions.dash.ClearBindings();
		this.inputActions.cast.ClearBindings();
		this.inputActions.superDash.ClearBindings();
		this.inputActions.dreamNail.ClearBindings();
		this.inputActions.quickMap.ClearBindings();
		this.inputActions.quickCast.ClearBindings();
		this.MapKeyboardLayoutFromGameSettings();
		this.gs.ResetGamepadSettings(this.activeGamepadType);
		this.gs.SaveGamepadSettings(this.activeGamepadType);
		this.MapControllerButtons(this.activeGamepadType);
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00046238 File Offset: 0x00044438
	public void ResetAllControllerButtonBindings()
	{
		int num = Enum.GetNames(typeof(GamepadType)).Length;
		for (int i = 0; i < num; i++)
		{
			GamepadType gamepadType = (GamepadType)i;
			if (this.gs.LoadGamepadSettings(gamepadType))
			{
				this.gs.ResetGamepadSettings(gamepadType);
				this.gs.SaveGamepadSettings(gamepadType);
			}
		}
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x0004628C File Offset: 0x0004448C
	public void SendKeyBindingsToGameSettings()
	{
		this.gs.jumpKey = this.GetKeyBindingForAction(this.inputActions.jump).ToString();
		this.gs.attackKey = this.GetKeyBindingForAction(this.inputActions.attack).ToString();
		this.gs.dashKey = this.GetKeyBindingForAction(this.inputActions.dash).ToString();
		this.gs.castKey = this.GetKeyBindingForAction(this.inputActions.cast).ToString();
		this.gs.superDashKey = this.GetKeyBindingForAction(this.inputActions.superDash).ToString();
		this.gs.dreamNailKey = this.GetKeyBindingForAction(this.inputActions.dreamNail).ToString();
		this.gs.quickMapKey = this.GetKeyBindingForAction(this.inputActions.quickMap).ToString();
		this.gs.inventoryKey = this.GetKeyBindingForAction(this.inputActions.openInventory).ToString();
		this.gs.upKey = this.GetKeyBindingForAction(this.inputActions.up).ToString();
		this.gs.downKey = this.GetKeyBindingForAction(this.inputActions.down).ToString();
		this.gs.leftKey = this.GetKeyBindingForAction(this.inputActions.left).ToString();
		this.gs.rightKey = this.GetKeyBindingForAction(this.inputActions.right).ToString();
		this.gs.quickCastKey = this.GetKeyBindingForAction(this.inputActions.quickCast).ToString();
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x000464BC File Offset: 0x000446BC
	public void SendButtonBindingsToGameSettings()
	{
		this.gs.controllerMapping.jump = this.GetButtonBindingForAction(this.inputActions.jump);
		this.gs.controllerMapping.attack = this.GetButtonBindingForAction(this.inputActions.attack);
		this.gs.controllerMapping.dash = this.GetButtonBindingForAction(this.inputActions.dash);
		this.gs.controllerMapping.cast = this.GetButtonBindingForAction(this.inputActions.cast);
		this.gs.controllerMapping.superDash = this.GetButtonBindingForAction(this.inputActions.superDash);
		this.gs.controllerMapping.dreamNail = this.GetButtonBindingForAction(this.inputActions.dreamNail);
		this.gs.controllerMapping.quickMap = this.GetButtonBindingForAction(this.inputActions.quickMap);
		this.gs.controllerMapping.quickCast = this.GetButtonBindingForAction(this.inputActions.quickCast);
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x000465D4 File Offset: 0x000447D4
	public void MapControllerButtons(GamepadType gamePadType)
	{
		this.inputActions.Reset();
		this.MapKeyboardLayoutFromGameSettings();
		if (!this.gs.LoadGamepadSettings(gamePadType))
		{
			this.gs.ResetGamepadSettings(gamePadType);
		}
		this.inputActions.jump.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.jump));
		this.inputActions.attack.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.attack));
		this.inputActions.dash.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.dash));
		this.inputActions.cast.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.cast));
		this.inputActions.superDash.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.superDash));
		this.inputActions.dreamNail.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.dreamNail));
		this.inputActions.quickMap.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.quickMap));
		this.inputActions.quickCast.AddBinding(new DeviceBindingSource(this.gs.controllerMapping.quickCast));
		if (gamePadType == GamepadType.XBOX_360)
		{
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.Back));
			return;
		}
		if (gamePadType == GamepadType.PS4)
		{
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.TouchPadButton));
			this.inputActions.pause.AddDefaultBinding(new DeviceBindingSource(InputControlType.Options));
			return;
		}
		if (this.activeGamepadType == GamepadType.XBOX_ONE)
		{
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.View));
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.Back));
			this.inputActions.pause.AddDefaultBinding(new DeviceBindingSource(InputControlType.Menu));
			return;
		}
		if (gamePadType == GamepadType.PS3_WIN)
		{
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.Select));
			return;
		}
		if (this.activeGamepadType == GamepadType.SWITCH_JOYCON_DUAL || this.activeGamepadType == GamepadType.SWITCH_PRO_CONTROLLER)
		{
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.Select));
			this.inputActions.pause.AddDefaultBinding(new DeviceBindingSource(InputControlType.Start));
			return;
		}
		if (gamePadType == GamepadType.UNKNOWN)
		{
			this.inputActions.openInventory.AddBinding(new DeviceBindingSource(InputControlType.Select));
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00046860 File Offset: 0x00044A60
	public void RemapUIButtons()
	{
		this.inputActions.menuSubmit.ResetBindings();
		this.inputActions.menuCancel.ResetBindings();
		this.inputActions.paneLeft.ResetBindings();
		this.inputActions.paneRight.ResetBindings();
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x000468B0 File Offset: 0x00044AB0
	public PlayerAction ActionButtonToPlayerAction(HeroActionButton actionButtonType)
	{
		if (actionButtonType == HeroActionButton.JUMP)
		{
			return this.inputActions.jump;
		}
		if (actionButtonType == HeroActionButton.ATTACK)
		{
			return this.inputActions.attack;
		}
		if (actionButtonType == HeroActionButton.DASH)
		{
			return this.inputActions.dash;
		}
		if (actionButtonType == HeroActionButton.CAST)
		{
			return this.inputActions.cast;
		}
		if (actionButtonType == HeroActionButton.SUPER_DASH)
		{
			return this.inputActions.superDash;
		}
		if (actionButtonType == HeroActionButton.QUICK_MAP)
		{
			return this.inputActions.quickMap;
		}
		if (actionButtonType == HeroActionButton.QUICK_CAST)
		{
			return this.inputActions.quickCast;
		}
		if (actionButtonType == HeroActionButton.INVENTORY)
		{
			return this.inputActions.openInventory;
		}
		if (actionButtonType == HeroActionButton.DREAM_NAIL)
		{
			return this.inputActions.dreamNail;
		}
		if (actionButtonType == HeroActionButton.UP)
		{
			return this.inputActions.up;
		}
		if (actionButtonType == HeroActionButton.DOWN)
		{
			return this.inputActions.down;
		}
		if (actionButtonType == HeroActionButton.LEFT)
		{
			return this.inputActions.left;
		}
		if (actionButtonType == HeroActionButton.RIGHT)
		{
			return this.inputActions.right;
		}
		if (actionButtonType == HeroActionButton.MENU_SUBMIT)
		{
			return this.inputActions.menuSubmit;
		}
		if (actionButtonType == HeroActionButton.MENU_CANCEL)
		{
			return this.inputActions.menuCancel;
		}
		if (actionButtonType == HeroActionButton.MENU_PANE_LEFT)
		{
			return this.inputActions.paneLeft;
		}
		if (actionButtonType == HeroActionButton.MENU_PANE_RIGHT)
		{
			return this.inputActions.paneRight;
		}
		Debug.Log("No PlayerAction could be matched to HeroActionButton: " + actionButtonType.ToString());
		return null;
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x000469F4 File Offset: 0x00044BF4
	public InputHandler.KeyOrMouseBinding GetKeyBindingForAction(PlayerAction action)
	{
		if (this.inputActions.Actions.Contains(action))
		{
			int count = action.Bindings.Count;
			if (count == 0)
			{
				if (this.verboseMode)
				{
					Debug.LogFormat("{0} has no key or button bindings.", new object[]
					{
						action.Name
					});
				}
				return new InputHandler.KeyOrMouseBinding(Key.None);
			}
			if (count == 1)
			{
				BindingSource bindingSource = action.Bindings[0];
				if (bindingSource.BindingSourceType == BindingSourceType.KeyBindingSource || bindingSource.BindingSourceType == BindingSourceType.MouseBindingSource)
				{
					return this.GetKeyBindingForActionBinding(action, action.Bindings[0]);
				}
				if (this.verboseMode)
				{
					Debug.LogFormat("{0} has no key bindings, only a single other binding ({1}: {2}).", new object[]
					{
						action.Name,
						action.Bindings[0].BindingSourceType,
						action.Bindings[0].DeviceName
					});
				}
				return new InputHandler.KeyOrMouseBinding(Key.None);
			}
			else if (count > 1)
			{
				foreach (BindingSource bindingSource2 in action.Bindings)
				{
					if (bindingSource2.BindingSourceType == BindingSourceType.KeyBindingSource || bindingSource2.BindingSourceType == BindingSourceType.MouseBindingSource)
					{
						InputHandler.KeyOrMouseBinding keyBindingForActionBinding = this.GetKeyBindingForActionBinding(action, bindingSource2);
						if (!InputHandler.KeyOrMouseBinding.IsNone(keyBindingForActionBinding))
						{
							return keyBindingForActionBinding;
						}
					}
				}
				if (this.verboseMode)
				{
					Debug.LogFormat("This action has bindings but none are keyboard keys ({0})", new object[]
					{
						action.Name
					});
				}
				return new InputHandler.KeyOrMouseBinding(Key.None);
			}
		}
		if (this.verboseMode)
		{
			Debug.LogFormat("This action is not in inputActions set. ({0})", new object[]
			{
				action.Name
			});
		}
		return new InputHandler.KeyOrMouseBinding(Key.None);
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x00046B9C File Offset: 0x00044D9C
	private InputHandler.KeyOrMouseBinding GetKeyBindingForActionBinding(PlayerAction action, BindingSource bindingSource)
	{
		KeyBindingSource keyBindingSource = bindingSource as KeyBindingSource;
		if (keyBindingSource != null)
		{
			if (keyBindingSource.Control.Count == 0)
			{
				Debug.LogErrorFormat("This action has no key mapped but registered a key binding. ({0})", new object[]
				{
					action.Name
				});
				return new InputHandler.KeyOrMouseBinding(Key.None);
			}
			if (keyBindingSource.Control.Count == 1)
			{
				return new InputHandler.KeyOrMouseBinding(keyBindingSource.Control.Get(0));
			}
			if (keyBindingSource.Control.Count > 1)
			{
				if (this.verboseMode)
				{
					Debug.LogFormat("This action has a KeyCombo mapped, this is unsupported ({0})", new object[]
					{
						action.Name
					});
				}
				return new InputHandler.KeyOrMouseBinding(Key.None);
			}
			return new InputHandler.KeyOrMouseBinding(Key.None);
		}
		else
		{
			MouseBindingSource mouseBindingSource = bindingSource as MouseBindingSource;
			if (mouseBindingSource != null)
			{
				return new InputHandler.KeyOrMouseBinding(mouseBindingSource.Control);
			}
			Debug.LogErrorFormat("Keybinding Error - Action: {0} returned a null binding.", new object[]
			{
				action.Name
			});
			return new InputHandler.KeyOrMouseBinding(Key.None);
		}
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00046C90 File Offset: 0x00044E90
	public InputControlType GetButtonBindingForAction(PlayerAction action)
	{
		if (!this.inputActions.Actions.Contains(action))
		{
			if (this.verboseMode)
			{
				Debug.LogFormat("InputActions does not contain {0} as an action.", new object[]
				{
					action.Name
				});
			}
			return InputControlType.None;
		}
		if (action.Bindings.Count > 0)
		{
			for (int i = 0; i < action.Bindings.Count; i++)
			{
				if (action.Bindings[i].BindingSourceType == BindingSourceType.DeviceBindingSource)
				{
					DeviceBindingSource deviceBindingSource = action.Bindings[i] as DeviceBindingSource;
					if (deviceBindingSource != null)
					{
						return deviceBindingSource.Control;
					}
				}
			}
			if (this.verboseMode)
			{
				string str = "|";
				for (int j = 0; j < action.Bindings.Count; j++)
				{
					str = str + action.Bindings[j].Name + "|";
				}
			}
			return InputControlType.None;
		}
		if (this.verboseMode)
		{
			Debug.Log("No bindings found for this action: " + action.Name);
		}
		return InputControlType.None;
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00046D94 File Offset: 0x00044F94
	public PlayerAction GetActionForMappableControllerButton(InputControlType button)
	{
		for (int i = 0; i < this.mappableControllerActions.Count; i++)
		{
			PlayerAction playerAction = this.mappableControllerActions[i];
			if (this.GetButtonBindingForAction(playerAction) == button)
			{
				return playerAction;
			}
		}
		return null;
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00046DD4 File Offset: 0x00044FD4
	public PlayerAction GetActionForDefaultControllerButton(InputControlType button)
	{
		InputControl control = InputManager.ActiveDevice.GetControl(button);
		if (control != null)
		{
			if (this.verboseMode)
			{
				Debug.LogFormat("{0} button is mapped to {1}", new object[]
				{
					button,
					control
				});
			}
		}
		else if (this.verboseMode)
		{
			Debug.LogFormat("{0} button is not mapped to anything", new object[]
			{
				button
			});
		}
		return null;
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00046E3C File Offset: 0x0004503C
	public void PrintMappings(PlayerAction action)
	{
		if (this.inputActions.Actions.Contains(action))
		{
			using (IEnumerator<BindingSource> enumerator = action.Bindings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					BindingSource bindingSource = enumerator.Current;
					if (bindingSource.BindingSourceType == BindingSourceType.DeviceBindingSource)
					{
						DeviceBindingSource deviceBindingSource = (DeviceBindingSource)bindingSource;
						Debug.LogFormat("{0} : {1} of type {2}", new object[]
						{
							action.Name,
							deviceBindingSource.Control,
							bindingSource.BindingSourceType
						});
					}
					else
					{
						Debug.LogFormat("{0} : {1} of type {2}", new object[]
						{
							action.Name,
							bindingSource.Name,
							bindingSource.BindingSourceType
						});
					}
				}
				return;
			}
		}
		Debug.Log("Action Not Found");
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00046F20 File Offset: 0x00045120
	public string ActionButtonLocalizedKey(PlayerAction action)
	{
		return this.ActionButtonLocalizedKey(action.Name);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00046F30 File Offset: 0x00045130
	public string ActionButtonLocalizedKey(string actionName)
	{
		if (actionName == "Jump")
		{
			return "BUTTON_JUMP";
		}
		if (actionName == "Attack")
		{
			return "BUTTON_ATTACK";
		}
		if (actionName == "Dash")
		{
			return "BUTTON_DASH";
		}
		if (actionName == "Cast")
		{
			return "BUTTON_CAST";
		}
		if (actionName == "Super Dash")
		{
			return "BUTTON_SUPER_DASH";
		}
		if (actionName == "Quick Map")
		{
			return "BUTTON_MAP";
		}
		if (actionName == "Quick Cast")
		{
			return "BUTTON_QCAST";
		}
		if (actionName == "Inventory")
		{
			return "BUTTON_INVENTORY";
		}
		if (actionName == "Move")
		{
			return "BUTTON_MOVE";
		}
		if (actionName == "Look")
		{
			return "BUTTON_LOOK";
		}
		if (actionName == "Pause")
		{
			return "BUTTON_PAUSE";
		}
		if (actionName == "Dream Nail")
		{
			return "BUTTON_DREAM_NAIL";
		}
		Debug.Log("IH Unknown Key for action: " + actionName);
		return "unknownkey";
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00047036 File Offset: 0x00045236
	private void StopCutsceneInput()
	{
		this.readyToSkipCutscene = false;
		this.gm.ui.HideCutscenePrompt();
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x0004704F File Offset: 0x0004524F
	private void UnlockStagInput()
	{
		this.stagLockoutActive = false;
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00047058 File Offset: 0x00045258
	private IEnumerator SetupGamepadUIInputActions()
	{
		if (this.gm.ui.menuState == MainMenuState.GAMEPAD_MENU)
		{
			yield return new WaitForSeconds(0.5f);
		}
		else
		{
			yield return new WaitForEndOfFrame();
		}
		Platform.AcceptRejectInputStyles acceptRejectInputStyle = Platform.Current.AcceptRejectInputStyle;
		if (acceptRejectInputStyle != Platform.AcceptRejectInputStyles.NonJapaneseStyle)
		{
			if (acceptRejectInputStyle != Platform.AcceptRejectInputStyles.JapaneseStyle)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.inputActions.menuSubmit.AddDefaultBinding(InputControlType.Action2);
			this.inputActions.menuCancel.AddDefaultBinding(InputControlType.Action1);
		}
		else
		{
			this.inputActions.menuSubmit.AddDefaultBinding(InputControlType.Action1);
			this.inputActions.menuCancel.AddDefaultBinding(InputControlType.Action2);
		}
		yield break;
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00047068 File Offset: 0x00045268
	private void RemoveGamepadUIInputActions()
	{
		this.inputActions.menuSubmit.RemoveBinding(new DeviceBindingSource(InputControlType.Action1));
		this.inputActions.menuSubmit.RemoveBinding(new DeviceBindingSource(InputControlType.Action2));
		this.inputActions.menuCancel.RemoveBinding(new DeviceBindingSource(InputControlType.Action1));
		this.inputActions.menuCancel.RemoveBinding(new DeviceBindingSource(InputControlType.Action2));
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x000470D1 File Offset: 0x000452D1
	private void DestroyCurrentActionSet()
	{
		this.inputActions.Destroy();
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x000470E0 File Offset: 0x000452E0
	public void SetActiveGamepadType(InputDevice inputDevice)
	{
		if (this.verboseMode)
		{
			Debug.LogFormat("Setting Active Input Device: {0} Meta: {1}", new object[]
			{
				inputDevice.Name,
				inputDevice.Meta
			});
		}
		if (this.gamepadState != GamepadState.DETACHED)
		{
			Debug.Log("Controller Type: " + inputDevice.DeviceStyle.ToString());
			if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXPlayer || Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.LinuxPlayer || Application.platform == RuntimePlatform.LinuxEditor)
			{
				InputDeviceStyle deviceStyle = inputDevice.DeviceStyle;
				switch (deviceStyle)
				{
				case InputDeviceStyle.Xbox360:
					this.activeGamepadType = GamepadType.XBOX_360;
					goto IL_137;
				case InputDeviceStyle.XboxOne:
					this.activeGamepadType = GamepadType.XBOX_ONE;
					goto IL_137;
				case InputDeviceStyle.XboxSeriesX:
				case InputDeviceStyle.PlayStation2:
					break;
				case InputDeviceStyle.PlayStation3:
					this.activeGamepadType = GamepadType.PS3_WIN;
					goto IL_137;
				case InputDeviceStyle.PlayStation4:
					this.activeGamepadType = GamepadType.PS4;
					goto IL_137;
				default:
					if (deviceStyle == InputDeviceStyle.NintendoSwitch)
					{
						this.activeGamepadType = GamepadType.SWITCH_PRO_CONTROLLER;
						goto IL_137;
					}
					break;
				}
				Debug.LogError("Unable to match controller of name (" + inputDevice.Name + "), will attempt default mapping set.");
				this.activeGamepadType = GamepadType.XBOX_360;
			}
			else
			{
				Debug.LogError("Unsupported platform for InputHander " + Application.platform.ToString());
				this.activeGamepadType = GamepadType.XBOX_360;
			}
			IL_137:
			Debug.Log("Active Gamepad Type: " + this.activeGamepadType.ToString());
			this.MapControllerButtons(this.activeGamepadType);
			this.UpdateActiveController();
			this.SetupMappableControllerBindingsList();
			base.StartCoroutine(this.SetupGamepadUIInputActions());
		}
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x0004726C File Offset: 0x0004546C
	private void MapDefaultKeyboardLayout()
	{
		this.inputActions.jump.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.Z
		}));
		this.inputActions.attack.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.X
		}));
		this.inputActions.dash.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.C
		}));
		this.inputActions.cast.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.A
		}));
		this.inputActions.superDash.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.S
		}));
		this.inputActions.dreamNail.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.D
		}));
		this.inputActions.quickMap.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.Tab
		}));
		this.inputActions.openInventory.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.I
		}));
		this.inputActions.quickCast.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.F
		}));
		this.inputActions.up.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.UpArrow
		}));
		this.inputActions.down.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.DownArrow
		}));
		this.inputActions.left.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.LeftArrow
		}));
		this.inputActions.right.AddBinding(new KeyBindingSource(new Key[]
		{
			Key.RightArrow
		}));
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00047428 File Offset: 0x00045628
	private void MapKeyboardLayoutFromGameSettings()
	{
		InputHandler.AddKeyBinding(this.inputActions.jump, this.gs.jumpKey);
		InputHandler.AddKeyBinding(this.inputActions.attack, this.gs.attackKey);
		InputHandler.AddKeyBinding(this.inputActions.dash, this.gs.dashKey);
		InputHandler.AddKeyBinding(this.inputActions.cast, this.gs.castKey);
		InputHandler.AddKeyBinding(this.inputActions.superDash, this.gs.superDashKey);
		InputHandler.AddKeyBinding(this.inputActions.dreamNail, this.gs.dreamNailKey);
		InputHandler.AddKeyBinding(this.inputActions.quickMap, this.gs.quickMapKey);
		InputHandler.AddKeyBinding(this.inputActions.openInventory, this.gs.inventoryKey);
		InputHandler.AddKeyBinding(this.inputActions.quickCast, this.gs.quickCastKey);
		InputHandler.AddKeyBinding(this.inputActions.up, this.gs.upKey);
		InputHandler.AddKeyBinding(this.inputActions.down, this.gs.downKey);
		InputHandler.AddKeyBinding(this.inputActions.left, this.gs.leftKey);
		InputHandler.AddKeyBinding(this.inputActions.right, this.gs.rightKey);
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00047594 File Offset: 0x00045794
	private static void AddKeyBinding(PlayerAction action, string savedBinding)
	{
		Mouse mouse = Mouse.None;
		Key key;
		if (!Enum.TryParse<Key>(savedBinding, out key) && !Enum.TryParse<Mouse>(savedBinding, out mouse))
		{
			return;
		}
		if (mouse != Mouse.None)
		{
			action.AddBinding(new MouseBindingSource(mouse));
			return;
		}
		action.AddBinding(new KeyBindingSource(new Key[]
		{
			key
		}));
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x000475E0 File Offset: 0x000457E0
	private void SetupNonMappableBindings()
	{
		this.inputActions = new HeroActions();
		this.inputActions.menuSubmit.AddDefaultBinding(new Key[]
		{
			Key.Return
		});
		this.inputActions.menuCancel.AddDefaultBinding(new Key[]
		{
			Key.Escape
		});
		this.inputActions.left.AddDefaultBinding(InputControlType.DPadLeft);
		this.inputActions.left.AddDefaultBinding(InputControlType.LeftStickLeft);
		this.inputActions.right.AddDefaultBinding(InputControlType.DPadRight);
		this.inputActions.right.AddDefaultBinding(InputControlType.LeftStickRight);
		this.inputActions.up.AddDefaultBinding(InputControlType.DPadUp);
		this.inputActions.up.AddDefaultBinding(InputControlType.LeftStickUp);
		this.inputActions.down.AddDefaultBinding(InputControlType.DPadDown);
		this.inputActions.down.AddDefaultBinding(InputControlType.LeftStickDown);
		this.inputActions.rs_up.AddDefaultBinding(InputControlType.RightStickUp);
		this.inputActions.rs_down.AddDefaultBinding(InputControlType.RightStickDown);
		this.inputActions.rs_left.AddDefaultBinding(InputControlType.RightStickLeft);
		this.inputActions.rs_right.AddDefaultBinding(InputControlType.RightStickRight);
		this.inputActions.textSpeedup.AddDefaultBinding(new Key[]
		{
			Key.Z
		});
		this.inputActions.textSpeedup.AddDefaultBinding(new Key[]
		{
			Key.Return
		});
		this.inputActions.textSpeedup.AddDefaultBinding(new Key[]
		{
			Key.Space
		});
		this.inputActions.textSpeedup.AddDefaultBinding(InputControlType.Action1);
		this.inputActions.skipCutscene.AddDefaultBinding(new Key[]
		{
			Key.Return
		});
		this.inputActions.skipCutscene.AddDefaultBinding(new Key[]
		{
			Key.Space
		});
		this.inputActions.skipCutscene.AddDefaultBinding(InputControlType.Action2);
		this.inputActions.pause.AddDefaultBinding(new Key[]
		{
			Key.Escape
		});
		this.inputActions.pause.AddDefaultBinding(InputControlType.Start);
		this.inputActions.paneRight.AddDefaultBinding(new Key[]
		{
			Key.RightBracket
		});
		this.inputActions.paneRight.AddDefaultBinding(InputControlType.RightTrigger);
		this.inputActions.paneRight.AddDefaultBinding(InputControlType.RightBumper);
		this.inputActions.paneLeft.AddDefaultBinding(new Key[]
		{
			Key.LeftBracket
		});
		this.inputActions.paneLeft.AddDefaultBinding(InputControlType.LeftTrigger);
		this.inputActions.paneLeft.AddDefaultBinding(InputControlType.LeftBumper);
		this.nonMappableControllerActions = new List<PlayerAction>();
		this.nonMappableControllerActions.Add(this.inputActions.paneLeft);
		this.nonMappableControllerActions.Add(this.inputActions.paneRight);
		this.nonMappableControllerActions.Add(this.inputActions.pause);
		this.nonMappableControllerActions.Add(this.inputActions.textSpeedup);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x000478B8 File Offset: 0x00045AB8
	private void SetupMappableControllerBindingsList()
	{
		this.mappableControllerActions = new List<PlayerAction>();
		this.mappableControllerActions.Add(this.inputActions.jump);
		this.mappableControllerActions.Add(this.inputActions.attack);
		this.mappableControllerActions.Add(this.inputActions.dash);
		this.mappableControllerActions.Add(this.inputActions.cast);
		this.mappableControllerActions.Add(this.inputActions.superDash);
		this.mappableControllerActions.Add(this.inputActions.dreamNail);
		this.mappableControllerActions.Add(this.inputActions.quickMap);
		this.mappableControllerActions.Add(this.inputActions.quickCast);
		this.mappableControllerActions.Add(this.inputActions.openInventory);
		this.mappableControllerActions.Add(this.inputActions.up);
		this.mappableControllerActions.Add(this.inputActions.down);
		this.mappableControllerActions.Add(this.inputActions.left);
		this.mappableControllerActions.Add(this.inputActions.right);
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x000479EE File Offset: 0x00045BEE
	public InputHandler()
	{
		this.stagLockoutDuration = 1.2f;
		base..ctor();
	}

	// Token: 0x04000EFE RID: 3838
	public static InputHandler Instance;

	// Token: 0x04000F00 RID: 3840
	private bool verboseMode;

	// Token: 0x04000F01 RID: 3841
	private GameManager gm;

	// Token: 0x04000F02 RID: 3842
	private GameSettings gs;

	// Token: 0x04000F03 RID: 3843
	private GameConfig gc;

	// Token: 0x04000F04 RID: 3844
	public InputDevice gameController;

	// Token: 0x04000F05 RID: 3845
	public HeroActions inputActions;

	// Token: 0x04000F06 RID: 3846
	public BindingSourceType lastActiveController;

	// Token: 0x04000F07 RID: 3847
	public InputDeviceStyle lastInputDeviceStyle;

	// Token: 0x04000F08 RID: 3848
	public GamepadType activeGamepadType;

	// Token: 0x04000F09 RID: 3849
	public GamepadState gamepadState;

	// Token: 0x04000F0A RID: 3850
	private HeroController heroCtrl;

	// Token: 0x04000F0B RID: 3851
	private HeroControllerStates cState;

	// Token: 0x04000F0C RID: 3852
	private PlayerData playerData;

	// Token: 0x04000F0D RID: 3853
	private OnScreenDebugInfo debugInfo;

	// Token: 0x04000F0F RID: 3855
	private List<PlayerAction> nonMappableControllerActions;

	// Token: 0x04000F11 RID: 3857
	public float inputX;

	// Token: 0x04000F12 RID: 3858
	public float inputY;

	// Token: 0x04000F13 RID: 3859
	public bool acceptingInput;

	// Token: 0x04000F14 RID: 3860
	public bool skippingCutscene;

	// Token: 0x04000F16 RID: 3862
	private bool readyToSkipCutscene;

	// Token: 0x04000F18 RID: 3864
	private bool controllerDetected;

	// Token: 0x04000F19 RID: 3865
	private ControllerProfile currentControllerProfile;

	// Token: 0x04000F1A RID: 3866
	private InputHandler.TFRMode tfrMode;

	// Token: 0x04000F1B RID: 3867
	private bool isGameplayScene;

	// Token: 0x04000F1C RID: 3868
	private bool isTitleScreenScene;

	// Token: 0x04000F1D RID: 3869
	private bool isMenuScene;

	// Token: 0x04000F1E RID: 3870
	private bool isStagTravelScene;

	// Token: 0x04000F1F RID: 3871
	private float stagLockoutDuration;

	// Token: 0x04000F20 RID: 3872
	private bool stagLockoutActive;

	// Token: 0x04000F21 RID: 3873
	private float skipCooldownTime;

	// Token: 0x04000F22 RID: 3874
	private bool controllerPressed;

	// Token: 0x020002A6 RID: 678
	public readonly struct KeyOrMouseBinding
	{
		// Token: 0x06000E66 RID: 3686 RVA: 0x00047A01 File Offset: 0x00045C01
		public KeyOrMouseBinding(Key key)
		{
			this.Key = key;
			this.Mouse = Mouse.None;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00047A11 File Offset: 0x00045C11
		public KeyOrMouseBinding(Mouse mouse)
		{
			this.Key = Key.None;
			this.Mouse = mouse;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00047A21 File Offset: 0x00045C21
		public static bool IsNone(InputHandler.KeyOrMouseBinding val)
		{
			return val.Key == Key.None && val.Mouse == Mouse.None;
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00047A36 File Offset: 0x00045C36
		public override string ToString()
		{
			if (this.Mouse != Mouse.None)
			{
				return this.Mouse.ToString();
			}
			return this.Key.ToString();
		}

		// Token: 0x04000F24 RID: 3876
		public readonly Key Key;

		// Token: 0x04000F25 RID: 3877
		public readonly Mouse Mouse;
	}

	// Token: 0x020002A7 RID: 679
	// (Invoke) Token: 0x06000E6B RID: 3691
	public delegate void CursorVisibilityChange(bool isVisible);

	// Token: 0x020002A8 RID: 680
	private enum TFRMode
	{
		// Token: 0x04000F27 RID: 3879
		Off,
		// Token: 0x04000F28 RID: 3880
		MatchFrameRate,
		// Token: 0x04000F29 RID: 3881
		DoubleFrameRate
	}

	// Token: 0x020002A9 RID: 681
	// (Invoke) Token: 0x06000E6F RID: 3695
	public delegate void ActiveControllerSwitch();
}
