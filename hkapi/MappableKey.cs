using System;
using System.Collections.Generic;
using GlobalEnums;
using InControl;
using Language;
using Modding;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x0200047E RID: 1150
public class MappableKey : MenuButton, ISubmitHandler, IEventSystemHandler, IPointerClickHandler, ICancelHandler
{
	// Token: 0x060019DE RID: 6622 RVA: 0x0007CAD3 File Offset: 0x0007ACD3
	private new void Start()
	{
		if (Application.isPlaying)
		{
			this.active = true;
			this.SetupRefs();
		}
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x0007CAE9 File Offset: 0x0007ACE9
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

	// Token: 0x060019E0 RID: 6624 RVA: 0x0007CB06 File Offset: 0x0007AD06
	public void GetBinding()
	{
		this.SetupRefs();
		if (this.actionSet != null)
		{
			this.currentBinding = this.playerAction.GetKeyOrMouseBinding();
			return;
		}
		this.orig_GetBinding();
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0007CB30 File Offset: 0x0007AD30
	public void ListenForNewButton()
	{
		this.playerAction.ClearBindings();
		this.oldFontSize = this.keymapText.fontSize;
		this.oldAlignment = this.keymapText.alignment;
		this.oldSprite = this.keymapSprite.sprite;
		this.oldText = this.keymapText.text;
		this.keymapSprite.sprite = this.uibs.blankKey;
		this.keymapText.text = Language.Get("KEYBOARD_PRESSKEY", "MainMenu");
		this.keymapText.fontSize = this.blankFontSize;
		this.keymapText.alignment = this.blankAlignment;
		this.keymapText.horizontalOverflow = this.blankOverflow;
		base.interactable = false;
		this.SetupBindingListenOptions();
		this.isListening = true;
		this.uibs.ListeningForKeyRebind(this);
		this.playerAction.ListenForBinding();
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0007CC1C File Offset: 0x0007AE1C
	public void ShowCurrentBinding()
	{
		if (!this.active)
		{
			this.Start();
		}
		if (InputHandler.KeyOrMouseBinding.IsNone(this.currentBinding))
		{
			this.keymapSprite.sprite = this.uibs.blankKey;
			this.keymapText.text = Language.Get("KEYBOARD_UNMAPPED", "MainMenu");
			this.keymapText.fontSize = this.blankFontSize;
			this.keymapText.alignment = this.blankAlignment;
			this.keymapText.resizeTextForBestFit = this.blankBestFit;
			this.keymapText.horizontalOverflow = this.blankOverflow;
			this.keymapText.GetComponent<FixVerticalAlign>().AlignText();
		}
		else
		{
			ButtonSkin keyboardSkinFor = this.uibs.GetKeyboardSkinFor(this.playerAction);
			this.keymapSprite.sprite = keyboardSkinFor.sprite;
			this.keymapText.text = keyboardSkinFor.symbol;
			if (keyboardSkinFor.skinType == ButtonSkinType.SQUARE)
			{
				this.keymapText.fontSize = this.sqrFontSize;
				this.keymapText.alignment = this.sqrAlignment;
				this.keymapText.rectTransform.anchoredPosition = new Vector2(this.sqrX, this.keymapText.rectTransform.anchoredPosition.y);
				this.keymapText.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.sqrWidth);
				this.keymapText.resizeTextForBestFit = this.sqrBestFit;
				this.keymapText.resizeTextMinSize = this.sqrMinFont;
				this.keymapText.resizeTextMaxSize = this.sqrMaxFont;
				this.keymapText.horizontalOverflow = this.sqrHOverflow;
			}
			else if (keyboardSkinFor.skinType == ButtonSkinType.WIDE)
			{
				this.keymapText.fontSize = this.wideFontSize;
				this.keymapText.alignment = this.wideAlignment;
				this.keymapText.rectTransform.anchoredPosition = new Vector2(this.wideX, this.keymapText.rectTransform.anchoredPosition.y);
				this.keymapText.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.wideWidth);
				this.keymapText.resizeTextForBestFit = this.wideBestFit;
				this.keymapText.horizontalOverflow = this.wideHOverflow;
			}
			else
			{
				this.keymapText.alignment = this.uibs.labelAlignment;
			}
			if (this.keymapSprite.sprite == null)
			{
				Debug.LogError("Could not find a suitable skin for the new button map: " + this.currentBinding.ToString());
				this.keymapSprite.sprite = this.uibs.blankKey;
			}
			this.keymapText.GetComponent<FixVerticalAlign>().AlignTextKeymap();
		}
		base.interactable = true;
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x0007CED1 File Offset: 0x0007B0D1
	public void AbortRebind()
	{
		if (this.isListening)
		{
			this.ShowCurrentBinding();
			base.interactable = true;
			this.isListening = false;
		}
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0007CEEF File Offset: 0x0007B0EF
	public void StopActionListening()
	{
		this.playerAction.StopListeningForBinding();
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x0007CEFC File Offset: 0x0007B0FC
	public bool OnBindingFound(PlayerAction action, BindingSource binding)
	{
		if (this.unmappableKeys.Contains(binding as KeyBindingSource))
		{
			this.uibs.FinishedListeningForKey();
			action.StopListeningForBinding();
			this.AbortRebind();
			Debug.LogFormat("Cancelled new {0} button binding", new object[]
			{
				action.Name
			});
			return false;
		}
		return true;
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x0007CF50 File Offset: 0x0007B150
	public void OnBindingAdded(PlayerAction action, BindingSource binding)
	{
		Debug.Log("New binding added for " + action.Name + ": " + binding.Name);
		this.isListening = false;
		base.interactable = true;
		this.changePending = true;
		this.uibs.FinishedListeningForKey();
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x0007CFA0 File Offset: 0x0007B1A0
	public void OnBindingRejected(PlayerAction action, BindingSource binding, BindingSourceRejectionType rejection)
	{
		if (rejection == BindingSourceRejectionType.DuplicateBindingOnAction)
		{
			Debug.LogFormat("{0} is already bound to {1}, cancelling rebind", new object[]
			{
				binding.Name,
				action.Name
			});
			this.uibs.FinishedListeningForKey();
			this.AbortRebind();
			action.StopListeningForBinding();
			this.isListening = false;
			return;
		}
		if (rejection == BindingSourceRejectionType.DuplicateBindingOnActionSet)
		{
			Debug.LogErrorFormat("{0} is already bound to another key.", new object[]
			{
				binding.Name
			});
			return;
		}
		Debug.Log("Binding rejected for " + action.Name + ": " + rejection.ToString());
		this.uibs.FinishedListeningForKey();
		this.AbortRebind();
		action.StopListeningForBinding();
		this.isListening = false;
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x0007D055 File Offset: 0x0007B255
	public new void OnSubmit(BaseEventData eventData)
	{
		if (!this.isListening)
		{
			this.ListenForNewButton();
		}
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x0007D065 File Offset: 0x0007B265
	public new void OnPointerClick(PointerEventData eventData)
	{
		this.OnSubmit(eventData);
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x0007D06E File Offset: 0x0007B26E
	public new void OnCancel(BaseEventData eventData)
	{
		if (this.isListening)
		{
			this.StopListeningForNewKey();
			return;
		}
		base.OnCancel(eventData);
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x0007D086 File Offset: 0x0007B286
	private void StopListeningForNewKey()
	{
		this.uibs.FinishedListeningForKey();
		this.StopActionListening();
		this.AbortRebind();
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0007D0A0 File Offset: 0x0007B2A0
	private void SetupUnmappableKeys()
	{
		this.unmappableKeys = new List<KeyBindingSource>();
		this.unmappableKeys.Add(new KeyBindingSource(new Key[]
		{
			Key.Escape
		}));
		this.unmappableKeys.Add(new KeyBindingSource(new Key[]
		{
			Key.Return
		}));
		this.unmappableKeys.Add(new KeyBindingSource(new Key[]
		{
			Key.Numlock
		}));
		this.unmappableKeys.Add(new KeyBindingSource(new Key[]
		{
			Key.LeftCommand
		}));
		this.unmappableKeys.Add(new KeyBindingSource(new Key[]
		{
			Key.RightCommand
		}));
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x0007D140 File Offset: 0x0007B340
	private void SetupBindingListenOptions()
	{
		if (this.actionSet != null)
		{
			this.actionSet.ListenOptions = new BindingListenOptions
			{
				IncludeControllers = false,
				IncludeNonStandardControls = false,
				IncludeMouseButtons = true,
				IncludeKeys = true,
				IncludeModifiersAsFirstClassKeys = true,
				IncludeUnknownControllers = false,
				MaxAllowedBindingsPerType = 1U,
				OnBindingFound = new Func<PlayerAction, BindingSource, bool>(this.OnBindingFound),
				OnBindingAdded = new Action<PlayerAction, BindingSource>(this.OnBindingAdded),
				OnBindingRejected = new Action<PlayerAction, BindingSource, BindingSourceRejectionType>(this.OnBindingRejected),
				UnsetDuplicateBindingsOnSet = true
			};
			return;
		}
		this.orig_SetupBindingListenOptions();
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x0007D1DC File Offset: 0x0007B3DC
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
			this.SetupUnmappableKeys();
			this.uibs.AddMappableKey(this);
			return;
		}
		this.orig_SetupRefs();
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x0007D264 File Offset: 0x0007B464
	public MappableKey()
	{
		this.sqrX = 32f;
		this.sqrWidth = 65f;
		this.sqrBestFit = true;
		this.sqrFontSize = 46;
		this.sqrMinFont = 20;
		this.sqrMaxFont = 46;
		this.sqrAlignment = TextAnchor.MiddleCenter;
		this.wideWidth = 137f;
		this.wideFontSize = 34;
		this.wideAlignment = TextAnchor.MiddleCenter;
		this.blankWidth = 162f;
		this.blankFontSize = 46;
		this.blankOverflow = HorizontalWrapMode.Overflow;
		this.blankAlignment = TextAnchor.MiddleRight;
		base..ctor();
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x0007D2EE File Offset: 0x0007B4EE
	public void InitCustomActions(PlayerActionSet actionSet, PlayerAction playerAction)
	{
		this.actionSet = actionSet;
		this.playerAction = playerAction;
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x0007D2FE File Offset: 0x0007B4FE
	private new void OnDestroy()
	{
		if (this.uibs != null)
		{
			this.uibs.RemoveMappableKey(this);
		}
		base.OnDestroy();
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x0007D320 File Offset: 0x0007B520
	public void orig_GetBinding()
	{
		this.currentBinding = this.ih.GetKeyBindingForAction(this.playerAction);
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x0007D33C File Offset: 0x0007B53C
	private void orig_SetupBindingListenOptions()
	{
		BindingListenOptions bindingListenOptions = new BindingListenOptions();
		bindingListenOptions.IncludeControllers = false;
		bindingListenOptions.IncludeNonStandardControls = false;
		bindingListenOptions.IncludeMouseButtons = true;
		bindingListenOptions.IncludeKeys = true;
		bindingListenOptions.IncludeModifiersAsFirstClassKeys = true;
		bindingListenOptions.IncludeUnknownControllers = false;
		bindingListenOptions.MaxAllowedBindingsPerType = 1U;
		bindingListenOptions.OnBindingFound = new Func<PlayerAction, BindingSource, bool>(this.OnBindingFound);
		bindingListenOptions.OnBindingAdded = new Action<PlayerAction, BindingSource>(this.OnBindingAdded);
		bindingListenOptions.OnBindingRejected = new Action<PlayerAction, BindingSource, BindingSourceRejectionType>(this.OnBindingRejected);
		bindingListenOptions.UnsetDuplicateBindingsOnSet = true;
		this.ih.inputActions.ListenOptions = bindingListenOptions;
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x0007D3D0 File Offset: 0x0007B5D0
	private void orig_SetupRefs()
	{
		this.gm = GameManager.instance;
		this.ui = this.gm.ui;
		this.uibs = this.ui.uiButtonSkins;
		this.ih = this.gm.inputHandler;
		this.gs = this.gm.gameSettings;
		this.playerAction = this.ih.ActionButtonToPlayerAction(this.actionButtonType);
		base.HookUpAudioPlayer();
		this.SetupUnmappableKeys();
	}

	// Token: 0x04001F34 RID: 7988
	private GameManager gm;

	// Token: 0x04001F35 RID: 7989
	private InputHandler ih;

	// Token: 0x04001F36 RID: 7990
	private UIManager ui;

	// Token: 0x04001F37 RID: 7991
	private UIButtonSkins uibs;

	// Token: 0x04001F38 RID: 7992
	private GameSettings gs;

	// Token: 0x04001F39 RID: 7993
	private PlayerAction playerAction;

	// Token: 0x04001F3A RID: 7994
	private bool active;

	// Token: 0x04001F3B RID: 7995
	private bool isListening;

	// Token: 0x04001F3C RID: 7996
	private bool changePending;

	// Token: 0x04001F3D RID: 7997
	private int oldFontSize;

	// Token: 0x04001F3E RID: 7998
	private TextAnchor oldAlignment;

	// Token: 0x04001F3F RID: 7999
	private Sprite oldSprite;

	// Token: 0x04001F40 RID: 8000
	private string oldText;

	// Token: 0x04001F41 RID: 8001
	private InputHandler.KeyOrMouseBinding currentBinding;

	// Token: 0x04001F42 RID: 8002
	private List<KeyBindingSource> unmappableKeys;

	// Token: 0x04001F43 RID: 8003
	private float sqrX;

	// Token: 0x04001F44 RID: 8004
	private float sqrWidth;

	// Token: 0x04001F45 RID: 8005
	private bool sqrBestFit;

	// Token: 0x04001F46 RID: 8006
	private int sqrFontSize;

	// Token: 0x04001F47 RID: 8007
	private int sqrMinFont;

	// Token: 0x04001F48 RID: 8008
	private int sqrMaxFont;

	// Token: 0x04001F49 RID: 8009
	private HorizontalWrapMode sqrHOverflow;

	// Token: 0x04001F4A RID: 8010
	private TextAnchor sqrAlignment;

	// Token: 0x04001F4B RID: 8011
	private float wideX;

	// Token: 0x04001F4C RID: 8012
	private float wideWidth;

	// Token: 0x04001F4D RID: 8013
	private bool wideBestFit;

	// Token: 0x04001F4E RID: 8014
	private int wideFontSize;

	// Token: 0x04001F4F RID: 8015
	private HorizontalWrapMode wideHOverflow;

	// Token: 0x04001F50 RID: 8016
	private TextAnchor wideAlignment;

	// Token: 0x04001F51 RID: 8017
	private float blankX;

	// Token: 0x04001F52 RID: 8018
	private float blankWidth;

	// Token: 0x04001F53 RID: 8019
	private bool blankBestFit;

	// Token: 0x04001F54 RID: 8020
	private int blankFontSize;

	// Token: 0x04001F55 RID: 8021
	private HorizontalWrapMode blankOverflow;

	// Token: 0x04001F56 RID: 8022
	private TextAnchor blankAlignment;

	// Token: 0x04001F57 RID: 8023
	[Space(6f)]
	[Header("Button Mapping")]
	public HeroActionButton actionButtonType;

	// Token: 0x04001F58 RID: 8024
	public Text keymapText;

	// Token: 0x04001F59 RID: 8025
	public Image keymapSprite;

	// Token: 0x04001F5A RID: 8026
	public PlayerActionSet actionSet;
}
