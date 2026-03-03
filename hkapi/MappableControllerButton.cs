using System;
using System.Collections.Generic;
using GlobalEnums;
using InControl;
using Language;
using Modding;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200047D RID: 1149
public class MappableControllerButton : MenuButton, ISubmitHandler, IEventSystemHandler, IPointerClickHandler, ICancelHandler
{
	// Token: 0x060019C4 RID: 6596 RVA: 0x0007C147 File Offset: 0x0007A347
	private new void Start()
	{
		if (Application.isPlaying)
		{
			this.active = true;
			this.SetupRefs();
		}
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x0007C15D File Offset: 0x0007A35D
	private new void OnEnable()
	{
		if (Application.isPlaying)
		{
			if (!this.active)
			{
				this.Start();
			}
			this.GetBinding();
		}
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x0007C17A File Offset: 0x0007A37A
	private void GetBinding()
	{
		this.SetupRefs();
		if (this.actionSet != null)
		{
			this.currentBinding = this.playerAction.GetControllerButtonBinding();
			return;
		}
		this.orig_GetBinding();
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x0007C1A4 File Offset: 0x0007A3A4
	public void ListenForNewButton()
	{
		this.buttonmapSprite.sprite = this.uibs.blankKey;
		this.buttonmapText.text = "";
		this.listeningThrobber.gameObject.SetActive(true);
		base.interactable = false;
		this.SetupBindingListenOptions();
		this.isListening = true;
		this.uibs.ListeningForButtonRebind(this);
		this.playerAction.ListenForBinding();
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x0007C214 File Offset: 0x0007A414
	public void ShowCurrentBinding()
	{
		this.orig_ShowCurrentBinding();
		if (this.actionSet != null && this.currentBinding != InputControlType.None && (this.buttonmapSprite.sprite == null || this.buttonmapSprite.sprite == this.uibs.blankKey))
		{
			this.buttonmapText.text = Enum.GetName(typeof(InputControlType), this.currentBinding);
		}
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x0007C28C File Offset: 0x0007A48C
	public void AbortRebind()
	{
		if (this.isListening)
		{
			this.ShowCurrentBinding();
			base.interactable = true;
			this.isListening = false;
		}
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0007C2AA File Offset: 0x0007A4AA
	public void StopActionListening()
	{
		this.playerAction.StopListeningForBinding();
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x0007C2B8 File Offset: 0x0007A4B8
	public bool OnBindingFound(PlayerAction action, BindingSource binding)
	{
		DeviceBindingSource deviceBindingSource = (DeviceBindingSource)binding;
		if (this.unmappableButtons.Contains(binding as DeviceBindingSource))
		{
			this.uibs.FinishedListeningForButton();
			action.StopListeningForBinding();
			this.AbortRebind();
			if (this.verboseMode)
			{
				Debug.LogFormat("Cancelled new {0} button binding (Not allowed to bind {1})", new object[]
				{
					action.Name,
					deviceBindingSource.Control
				});
			}
			return false;
		}
		return true;
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x0007C328 File Offset: 0x0007A528
	public void OnBindingAdded(PlayerAction action, BindingSource binding)
	{
		DeviceBindingSource deviceBindingSource = (DeviceBindingSource)binding;
		if (this.verboseMode)
		{
			Debug.Log("New binding added for " + action.Name + ": " + deviceBindingSource.Control.ToString());
		}
		this.uibs.FinishedListeningForButton();
		this.isListening = false;
		base.interactable = true;
		this.changePending = true;
		this.ih.RemapUIButtons();
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
	public void OnBindingRejected(PlayerAction action, BindingSource binding, BindingSourceRejectionType rejection)
	{
		DeviceBindingSource deviceBindingSource = (DeviceBindingSource)binding;
		if (rejection == BindingSourceRejectionType.DuplicateBindingOnAction)
		{
			if (this.verboseMode)
			{
				Debug.LogFormat("{0}->{1} is already bound to {2}, cancelling rebind", new object[]
				{
					deviceBindingSource.DeviceName,
					deviceBindingSource.Control,
					action.Name
				});
			}
			this.uibs.FinishedListeningForButton();
			this.AbortRebind();
			action.StopListeningForBinding();
			this.isListening = false;
			return;
		}
		if (rejection == BindingSourceRejectionType.DuplicateBindingOnActionSet)
		{
			if (this.verboseMode)
			{
				string text = " |";
				for (int i = 0; i < action.Bindings.Count; i++)
				{
					text = text + action.Bindings[i].Name + "|";
				}
				text += "|";
				Debug.LogErrorFormat("{0}->{1} is already bound to another button: {2}", new object[]
				{
					deviceBindingSource.DeviceName,
					deviceBindingSource.Control,
					text
				});
				return;
			}
		}
		else
		{
			if (this.verboseMode)
			{
				Debug.Log("Binding rejected for " + action.Name + ": " + rejection.ToString());
			}
			this.uibs.FinishedListeningForButton();
			this.AbortRebind();
			action.StopListeningForBinding();
			this.isListening = false;
		}
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x0007C4DF File Offset: 0x0007A6DF
	public new void OnSubmit(BaseEventData eventData)
	{
		if (!this.isListening)
		{
			this.ListenForNewButton();
		}
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x0007C4EF File Offset: 0x0007A6EF
	public new void OnPointerClick(PointerEventData eventData)
	{
		this.OnSubmit(eventData);
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0007C4F8 File Offset: 0x0007A6F8
	public new void OnCancel(BaseEventData eventData)
	{
		if (this.isListening)
		{
			if (this.ih.lastActiveController == BindingSourceType.KeyBindingSource)
			{
				this.StopListeningForNewButton();
				return;
			}
		}
		else
		{
			base.OnCancel(eventData);
		}
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x0007C51E File Offset: 0x0007A71E
	private void StopListeningForNewButton()
	{
		this.uibs.FinishedListeningForButton();
		this.StopActionListening();
		this.AbortRebind();
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x0007C538 File Offset: 0x0007A738
	private void SetupUnmappableButtons()
	{
		if (this.actionSet != null)
		{
			this.unmappableButtons = new List<DeviceBindingSource>();
			this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Command));
			this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Options));
			return;
		}
		this.orig_SetupUnmappableButtons();
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x0007C588 File Offset: 0x0007A788
	private void SetupBindingListenOptions()
	{
		if (this.actionSet != null)
		{
			this.actionSet.ListenOptions = new BindingListenOptions
			{
				IncludeControllers = true,
				IncludeNonStandardControls = false,
				IncludeMouseButtons = false,
				IncludeKeys = false,
				IncludeModifiersAsFirstClassKeys = false,
				IncludeUnknownControllers = false,
				MaxAllowedBindingsPerType = 1U,
				OnBindingFound = new Func<PlayerAction, BindingSource, bool>(this.OnBindingFound),
				OnBindingAdded = new Action<PlayerAction, BindingSource>(this.OnBindingAdded),
				OnBindingRejected = new Action<PlayerAction, BindingSource, BindingSourceRejectionType>(this.OnBindingRejected),
				UnsetDuplicateBindingsOnSet = false
			};
			return;
		}
		this.orig_SetupBindingListenOptions();
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x0007C624 File Offset: 0x0007A824
	private void SetupRefs()
	{
		if (this.actionSet != null)
		{
			this.gm = GameManager.instance;
			this.ui = this.gm.ui;
			this.uibs = (UIButtonSkins)this.ui.uiButtonSkins;
			this.ih = this.gm.inputHandler;
			this.gs = this.gm.gameSettings;
			base.HookUpAudioPlayer();
			this.SetupUnmappableButtons();
			this.uibs.AddMappableControllerButton(this);
			return;
		}
		this.orig_SetupRefs();
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x0007C6B4 File Offset: 0x0007A8B4
	private void orig_SetupUnmappableButtons()
	{
		this.unmappableButtons = new List<DeviceBindingSource>();
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.DPadUp));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.DPadDown));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.DPadLeft));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.DPadRight));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.LeftStickUp));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.LeftStickDown));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.LeftStickLeft));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.LeftStickRight));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.RightStickUp));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.RightStickDown));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.RightStickLeft));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.RightStickRight));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.LeftStickButton));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.RightStickButton));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Start));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Select));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Command));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Back));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Menu));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Options));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.TouchPadButton));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Options));
		this.unmappableButtons.Add(new DeviceBindingSource(InputControlType.Share));
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x0007C868 File Offset: 0x0007AA68
	public void InitCustomActions(PlayerActionSet actionSet, PlayerAction playerAction)
	{
		this.actionSet = actionSet;
		this.playerAction = playerAction;
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x0007C878 File Offset: 0x0007AA78
	private new void OnDestroy()
	{
		if (this.uibs != null)
		{
			this.uibs.RemoveMappableControllerButton(this);
		}
		base.OnDestroy();
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0007C89A File Offset: 0x0007AA9A
	public void GetBindingPublic()
	{
		this.GetBinding();
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x0007C8A2 File Offset: 0x0007AAA2
	private void orig_GetBinding()
	{
		this.currentBinding = this.ih.GetButtonBindingForAction(this.playerAction);
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x0007C8BC File Offset: 0x0007AABC
	private void orig_SetupBindingListenOptions()
	{
		BindingListenOptions bindingListenOptions = new BindingListenOptions();
		bindingListenOptions.IncludeControllers = true;
		bindingListenOptions.IncludeNonStandardControls = false;
		bindingListenOptions.IncludeMouseButtons = false;
		bindingListenOptions.IncludeKeys = false;
		bindingListenOptions.IncludeModifiersAsFirstClassKeys = false;
		bindingListenOptions.IncludeUnknownControllers = false;
		bindingListenOptions.MaxAllowedBindingsPerType = 1U;
		bindingListenOptions.OnBindingFound = new Func<PlayerAction, BindingSource, bool>(this.OnBindingFound);
		bindingListenOptions.OnBindingAdded = new Action<PlayerAction, BindingSource>(this.OnBindingAdded);
		bindingListenOptions.OnBindingRejected = new Action<PlayerAction, BindingSource, BindingSourceRejectionType>(this.OnBindingRejected);
		bindingListenOptions.UnsetDuplicateBindingsOnSet = true;
		this.ih.inputActions.ListenOptions = bindingListenOptions;
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x0007C950 File Offset: 0x0007AB50
	public void orig_ShowCurrentBinding()
	{
		if (!this.active)
		{
			this.Start();
		}
		this.GetBinding();
		if (this.currentBinding == InputControlType.None)
		{
			this.buttonmapSprite.sprite = this.uibs.blankKey;
			this.buttonmapText.text = Language.Get("CTRL_UNMAPPED", "MainMenu");
			this.listeningThrobber.gameObject.SetActive(false);
		}
		else
		{
			ButtonSkin controllerButtonSkinFor = this.uibs.GetControllerButtonSkinFor(this.playerAction);
			this.buttonmapSprite.sprite = controllerButtonSkinFor.sprite;
			this.buttonmapText.text = "";
			this.listeningThrobber.gameObject.SetActive(false);
			if (this.buttonmapSprite.sprite == null)
			{
				Debug.LogError("Could not find a suitable skin for the new button map: " + this.currentBinding.ToString());
				this.buttonmapSprite.sprite = this.uibs.blankKey;
			}
		}
		base.interactable = true;
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0007CA54 File Offset: 0x0007AC54
	private void orig_SetupRefs()
	{
		this.gm = GameManager.instance;
		this.ui = this.gm.ui;
		this.uibs = this.ui.uiButtonSkins;
		this.ih = this.gm.inputHandler;
		this.gs = this.gm.gameSettings;
		this.playerAction = this.ih.ActionButtonToPlayerAction(this.actionButtonType);
		base.HookUpAudioPlayer();
		this.SetupUnmappableButtons();
	}

	// Token: 0x04001F23 RID: 7971
	private bool verboseMode;

	// Token: 0x04001F24 RID: 7972
	private GameManager gm;

	// Token: 0x04001F25 RID: 7973
	private InputHandler ih;

	// Token: 0x04001F26 RID: 7974
	private UIManager ui;

	// Token: 0x04001F27 RID: 7975
	private UIButtonSkins uibs;

	// Token: 0x04001F28 RID: 7976
	private GameSettings gs;

	// Token: 0x04001F29 RID: 7977
	private PlayerAction playerAction;

	// Token: 0x04001F2A RID: 7978
	private bool active;

	// Token: 0x04001F2B RID: 7979
	private bool isListening;

	// Token: 0x04001F2C RID: 7980
	private bool changePending;

	// Token: 0x04001F2D RID: 7981
	private InputControlType currentBinding;

	// Token: 0x04001F2E RID: 7982
	private List<DeviceBindingSource> unmappableButtons;

	// Token: 0x04001F2F RID: 7983
	[Space(6f)]
	[Header("Button Mapping")]
	public HeroActionButton actionButtonType;

	// Token: 0x04001F30 RID: 7984
	public Text buttonmapText;

	// Token: 0x04001F31 RID: 7985
	public Image buttonmapSprite;

	// Token: 0x04001F32 RID: 7986
	public Throbber listeningThrobber;

	// Token: 0x04001F33 RID: 7987
	public PlayerActionSet actionSet;
}
