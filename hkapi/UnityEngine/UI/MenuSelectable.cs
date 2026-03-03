using System;
using System.Collections;
using GlobalEnums;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace UnityEngine.UI
{
	// Token: 0x02000695 RID: 1685
	public class MenuSelectable : Selectable, ISelectHandler, IEventSystemHandler, IDeselectHandler, ICancelHandler, IPointerExitHandler
	{
		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06002812 RID: 10258 RVA: 0x000E0CD8 File Offset: 0x000DEED8
		// (remove) Token: 0x06002813 RID: 10259 RVA: 0x000E0D10 File Offset: 0x000DEF10
		public event MenuSelectable.OnSelectedEvent OnSelected;

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002814 RID: 10260 RVA: 0x000E0D45 File Offset: 0x000DEF45
		// (set) Token: 0x06002815 RID: 10261 RVA: 0x000E0D4D File Offset: 0x000DEF4D
		public bool DontPlaySelectSound
		{
			get
			{
				return this.dontPlaySelectSound;
			}
			set
			{
				this.dontPlaySelectSound = value;
			}
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000E0D58 File Offset: 0x000DEF58
		private new void Awake()
		{
			base.transition = Selectable.Transition.None;
			if (base.navigation.mode != Navigation.Mode.Explicit)
			{
				base.navigation = new Navigation
				{
					mode = Navigation.Mode.Explicit
				};
			}
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000E0D94 File Offset: 0x000DEF94
		private new void Start()
		{
			this.HookUpAudioPlayer();
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000E0D9C File Offset: 0x000DEF9C
		public new void OnSelect(BaseEventData eventData)
		{
			if (!base.interactable)
			{
				return;
			}
			if (this.OnSelected != null)
			{
				this.OnSelected(this);
			}
			if (this.leftCursor != null)
			{
				this.leftCursor.ResetTrigger("hide");
				this.leftCursor.SetTrigger("show");
			}
			if (this.rightCursor != null)
			{
				this.rightCursor.ResetTrigger("hide");
				this.rightCursor.SetTrigger("show");
			}
			if (this.selectHighlight != null)
			{
				this.selectHighlight.ResetTrigger("hide");
				this.selectHighlight.SetTrigger("show");
			}
			if (this.descriptionText != null)
			{
				this.descriptionText.ResetTrigger("hide");
				this.descriptionText.SetTrigger("show");
			}
			if (!this.DontPlaySelectSound)
			{
				try
				{
					this.uiAudioPlayer.PlaySelect();
					return;
				}
				catch (Exception ex)
				{
					string name = base.name;
					string str = " doesn't have a select sound specified. ";
					Exception ex2 = ex;
					Debug.LogError(name + str + ((ex2 != null) ? ex2.ToString() : null));
					return;
				}
			}
			this.dontPlaySelectSound = false;
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000E0ED0 File Offset: 0x000DF0D0
		public new void OnDeselect(BaseEventData eventData)
		{
			base.StartCoroutine(this.ValidateDeselect());
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000E0EDF File Offset: 0x000DF0DF
		public void ForceDeselect()
		{
			if (EventSystem.current.currentSelectedGameObject != null)
			{
				this.deselectWasForced = true;
				EventSystem.current.SetSelectedGameObject(null);
			}
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x000E0F05 File Offset: 0x000DF105
		public void OnCancel(BaseEventData eventData)
		{
			if (this.cancelAction == CancelAction.GoToExtrasMenu && this.customCancelAction != null)
			{
				this.ForceDeselect();
				this.customCancelAction(this);
				this.PlayCancelSound();
				return;
			}
			this.orig_OnCancel(eventData);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000E0F39 File Offset: 0x000DF139
		private IEnumerator ValidateDeselect()
		{
			this.prevSelectedObject = EventSystem.current.currentSelectedGameObject;
			yield return new WaitForEndOfFrame();
			if (EventSystem.current.currentSelectedGameObject != null)
			{
				if (this.leftCursor != null)
				{
					this.leftCursor.ResetTrigger("show");
					this.leftCursor.SetTrigger("hide");
				}
				if (this.rightCursor != null)
				{
					this.rightCursor.ResetTrigger("show");
					this.rightCursor.SetTrigger("hide");
				}
				if (this.selectHighlight != null)
				{
					this.selectHighlight.ResetTrigger("show");
					this.selectHighlight.SetTrigger("hide");
				}
				if (this.descriptionText != null)
				{
					this.descriptionText.ResetTrigger("show");
					this.descriptionText.SetTrigger("hide");
				}
				this.deselectWasForced = false;
			}
			else if (this.deselectWasForced)
			{
				if (this.leftCursor != null)
				{
					this.leftCursor.ResetTrigger("show");
					this.leftCursor.SetTrigger("hide");
				}
				if (this.rightCursor != null)
				{
					this.rightCursor.ResetTrigger("show");
					this.rightCursor.SetTrigger("hide");
				}
				if (this.selectHighlight != null)
				{
					this.selectHighlight.ResetTrigger("show");
					this.selectHighlight.SetTrigger("hide");
				}
				if (this.descriptionText != null)
				{
					this.descriptionText.ResetTrigger("show");
					this.descriptionText.SetTrigger("hide");
				}
				this.deselectWasForced = false;
			}
			else
			{
				this.deselectWasForced = false;
				this.dontPlaySelectSound = true;
				EventSystem.current.SetSelectedGameObject(this.prevSelectedObject);
			}
			yield break;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x000E0F48 File Offset: 0x000DF148
		protected void HookUpAudioPlayer()
		{
			if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "Pre_Menu_Intro")
			{
				this.uiAudioPlayer = Object.FindObjectOfType<MenuAudioController>();
				return;
			}
			this.uiAudioPlayer = UIManager.instance.uiAudioPlayer;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x000E0F8A File Offset: 0x000DF18A
		protected void PlaySubmitSound()
		{
			if (this.playSubmitSound)
			{
				this.uiAudioPlayer.PlaySubmit();
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000E0F9F File Offset: 0x000DF19F
		protected void PlayCancelSound()
		{
			this.uiAudioPlayer.PlayCancel();
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000E0FAC File Offset: 0x000DF1AC
		protected void PlaySelectSound()
		{
			this.uiAudioPlayer.PlaySelect();
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000E0FB9 File Offset: 0x000DF1B9
		public MenuSelectable()
		{
			this.playSubmitSound = true;
			base..ctor();
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x000E0FC8 File Offset: 0x000DF1C8
		// (set) Token: 0x06002823 RID: 10275 RVA: 0x000E0FD0 File Offset: 0x000DF1D0
		public Action<MenuSelectable> customCancelAction { get; set; }

		// Token: 0x06002824 RID: 10276 RVA: 0x000E0FDC File Offset: 0x000DF1DC
		public void orig_OnCancel(BaseEventData eventData)
		{
			if (this.cancelAction != CancelAction.DoNothing)
			{
				this.ForceDeselect();
			}
			if (!this.parentList)
			{
				this.parentList = base.GetComponentInParent<MenuButtonList>();
			}
			if (this.parentList)
			{
				this.parentList.ClearLastSelected();
			}
			if (this.cancelAction != CancelAction.DoNothing)
			{
				if (this.cancelAction == CancelAction.GoToMainMenu)
				{
					UIManager.instance.UIGoToMainMenu();
				}
				else if (this.cancelAction == CancelAction.GoToOptionsMenu)
				{
					UIManager.instance.UIGoToOptionsMenu();
				}
				else if (this.cancelAction == CancelAction.GoToVideoMenu)
				{
					UIManager.instance.UIGoToVideoMenu(false);
				}
				else if (this.cancelAction == CancelAction.GoToPauseMenu)
				{
					UIManager.instance.UIGoToPauseMenu();
				}
				else if (this.cancelAction == CancelAction.LeaveOptionsMenu)
				{
					UIManager.instance.UILeaveOptionsMenu();
				}
				else if (this.cancelAction == CancelAction.GoToExitPrompt)
				{
					UIManager.instance.UIShowQuitGamePrompt();
				}
				else if (this.cancelAction == CancelAction.GoToProfileMenu)
				{
					UIManager.instance.UIGoToProfileMenu();
				}
				else if (this.cancelAction == CancelAction.GoToControllerMenu)
				{
					UIManager.instance.UIGoToControllerMenu();
				}
				else if (this.cancelAction == CancelAction.ApplyRemapGamepadSettings)
				{
					UIManager.instance.ApplyRemapGamepadMenuSettings();
				}
				else if (this.cancelAction == CancelAction.ApplyAudioSettings)
				{
					UIManager.instance.ApplyAudioMenuSettings();
				}
				else if (this.cancelAction == CancelAction.ApplyVideoSettings)
				{
					UIManager.instance.ApplyVideoMenuSettings();
				}
				else if (this.cancelAction == CancelAction.ApplyGameSettings)
				{
					UIManager.instance.ApplyGameMenuSettings();
				}
				else if (this.cancelAction == CancelAction.ApplyKeyboardSettings)
				{
					UIManager.instance.ApplyKeyboardMenuSettings();
				}
				else if (this.cancelAction == CancelAction.ApplyControllerSettings)
				{
					UIManager.instance.ApplyControllerMenuSettings();
				}
				else if (this.cancelAction == CancelAction.GoToExtrasMenu)
				{
					if (ContentPackDetailsUI.Instance)
					{
						ContentPackDetailsUI.Instance.UndoMenuStyle();
					}
					UIManager.instance.UIGoToExtrasMenu();
				}
				else if (this.cancelAction == CancelAction.GoToExplicitSwitchUser)
				{
					UIManager.instance.UIGoToEngageMenu();
				}
				else if (this.cancelAction == CancelAction.ReturnToProfileMenu)
				{
					UIManager.instance.UIReturnToProfileMenu();
				}
				else
				{
					Debug.LogError("CancelAction not implemented for this control");
				}
			}
			if (this.cancelAction != CancelAction.DoNothing)
			{
				this.PlayCancelSound();
			}
		}

		// Token: 0x04002D14 RID: 11540
		[Header("On Cancel")]
		public CancelAction cancelAction;

		// Token: 0x04002D15 RID: 11541
		[Header("Fleurs")]
		public Animator leftCursor;

		// Token: 0x04002D16 RID: 11542
		public Animator rightCursor;

		// Token: 0x04002D17 RID: 11543
		[Header("Highlight")]
		public Animator selectHighlight;

		// Token: 0x04002D18 RID: 11544
		public bool playSubmitSound;

		// Token: 0x04002D19 RID: 11545
		[Header("Description Text")]
		public Animator descriptionText;

		// Token: 0x04002D1A RID: 11546
		protected MenuAudioController uiAudioPlayer;

		// Token: 0x04002D1B RID: 11547
		protected GameObject prevSelectedObject;

		// Token: 0x04002D1C RID: 11548
		protected bool dontPlaySelectSound;

		// Token: 0x04002D1D RID: 11549
		protected bool deselectWasForced;

		// Token: 0x04002D1E RID: 11550
		private MenuButtonList parentList;

		// Token: 0x02000696 RID: 1686
		// (Invoke) Token: 0x06002826 RID: 10278
		public delegate void OnSelectedEvent(MenuSelectable self);
	}
}
