using System;
using System.Collections;
using GlobalEnums;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000690 RID: 1680
	public class MenuPreventDeselect : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler, ICancelHandler
	{
		// Token: 0x060027DF RID: 10207 RVA: 0x000E032C File Offset: 0x000DE52C
		private void Start()
		{
			this.HookUpAudioPlayer();
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x000E0334 File Offset: 0x000DE534
		public void OnSelect(BaseEventData eventData)
		{
			if (this.leftCursor != null)
			{
				this.leftCursor.SetTrigger("show");
				this.leftCursor.ResetTrigger("hide");
			}
			if (this.rightCursor != null)
			{
				this.rightCursor.SetTrigger("show");
				this.rightCursor.ResetTrigger("hide");
			}
			if (!this.dontPlaySelectSound)
			{
				this.uiAudioPlayer.PlaySelect();
				return;
			}
			this.dontPlaySelectSound = false;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000E03B8 File Offset: 0x000DE5B8
		public void OnDeselect(BaseEventData eventData)
		{
			base.StartCoroutine(this.ValidateDeselect());
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x000E03C7 File Offset: 0x000DE5C7
		public void OnCancel(BaseEventData eventData)
		{
			if (this.cancelAction == CancelAction.GoToExtrasMenu && this.customCancelAction != null)
			{
				this.ForceDeselect();
				this.customCancelAction(this);
				this.uiAudioPlayer.PlayCancel();
				return;
			}
			this.orig_OnCancel(eventData);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x000E0400 File Offset: 0x000DE600
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

		// Token: 0x060027E4 RID: 10212 RVA: 0x000E040F File Offset: 0x000DE60F
		protected void HookUpAudioPlayer()
		{
			this.uiAudioPlayer = UIManager.instance.uiAudioPlayer;
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x000E0421 File Offset: 0x000DE621
		public void ForceDeselect()
		{
			if (EventSystem.current.currentSelectedGameObject != null)
			{
				this.deselectWasForced = true;
				EventSystem.current.SetSelectedGameObject(null);
			}
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x000E0447 File Offset: 0x000DE647
		public void SimulateSubmit()
		{
			this.ForceDeselect();
			UIManager.instance.uiAudioPlayer.PlaySubmit();
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x000E045E File Offset: 0x000DE65E
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x000E0466 File Offset: 0x000DE666
		public Action<MenuPreventDeselect> customCancelAction { get; set; }

		// Token: 0x060027EA RID: 10218 RVA: 0x000E0470 File Offset: 0x000DE670
		public void orig_OnCancel(BaseEventData eventData)
		{
			bool flag = true;
			if (this.cancelAction != CancelAction.DoNothing)
			{
				this.ForceDeselect();
			}
			if (this.cancelAction == CancelAction.DoNothing)
			{
				flag = false;
			}
			else if (this.cancelAction == CancelAction.GoToMainMenu)
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
				flag = false;
			}
			if (flag)
			{
				this.uiAudioPlayer.PlayCancel();
			}
		}

		// Token: 0x04002CF4 RID: 11508
		[Header("On Cancel")]
		public CancelAction cancelAction;

		// Token: 0x04002CF5 RID: 11509
		[Header("Fleurs")]
		public Animator leftCursor;

		// Token: 0x04002CF6 RID: 11510
		public Animator rightCursor;

		// Token: 0x04002CF7 RID: 11511
		private MenuAudioController uiAudioPlayer;

		// Token: 0x04002CF8 RID: 11512
		private GameObject prevSelectedObject;

		// Token: 0x04002CF9 RID: 11513
		private bool dontPlaySelectSound;

		// Token: 0x04002CFA RID: 11514
		private bool deselectWasForced;
	}
}
