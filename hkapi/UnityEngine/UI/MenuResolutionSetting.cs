using System;
using System.Collections;
using HKMenu;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000692 RID: 1682
	public class MenuResolutionSetting : MenuOptionHorizontal, ISubmitHandler, IEventSystemHandler, IMoveHandler, IPointerClickHandler, IMenuOptionListSetting
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000E07A4 File Offset: 0x000DE9A4
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x000E07AC File Offset: 0x000DE9AC
		public Resolution currentRes { get; private set; }

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x000E07B5 File Offset: 0x000DE9B5
		// (set) Token: 0x060027F4 RID: 10228 RVA: 0x000E07BD File Offset: 0x000DE9BD
		public Resolution screenRes { get; private set; }

		// Token: 0x060027F5 RID: 10229 RVA: 0x000E07C6 File Offset: 0x000DE9C6
		public new void OnEnable()
		{
			this.RefreshControls();
			this.UpdateApplyButton();
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x000E07D4 File Offset: 0x000DE9D4
		public void OnSubmit(BaseEventData eventData)
		{
			if (this.currentlyActiveResIndex != this.selectedOptionIndex)
			{
				base.ForceDeselect();
				this.uiAudioPlayer.PlaySubmit();
				this.ApplySettings();
			}
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000E07FB File Offset: 0x000DE9FB
		public new void OnMove(AxisEventData move)
		{
			if (base.MoveOption(move.moveDir))
			{
				this.UpdateApplyButton();
				return;
			}
			base.OnMove(move);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x000E0819 File Offset: 0x000DEA19
		public new void OnPointerClick(PointerEventData eventData)
		{
			base.OnPointerClick(eventData);
			if (eventData.button == PointerEventData.InputButton.Left || eventData.button == PointerEventData.InputButton.Right)
			{
				this.UpdateApplyButton();
			}
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000E083C File Offset: 0x000DEA3C
		public void ApplySettings()
		{
			if (this.selectedOptionIndex >= 0)
			{
				this.previousRes = this.currentRes;
				this.previousResIndex = this.currentlyActiveResIndex;
				Resolution currentRes = this.availableResolutions[this.selectedOptionIndex];
				Screen.SetResolution(currentRes.width, currentRes.height, Screen.fullScreen, currentRes.refreshRate);
				this.currentRes = currentRes;
				this.currentlyActiveResIndex = this.selectedOptionIndex;
				this.HideApplyButton();
				UIManager.instance.UIShowResolutionPrompt(true);
			}
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000E08BF File Offset: 0x000DEABF
		public void UpdateApplyButton()
		{
			if (this.currentlyActiveResIndex == this.selectedOptionIndex)
			{
				this.HideApplyButton();
				return;
			}
			this.ShowApplyButton();
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000E08DC File Offset: 0x000DEADC
		public void ResetToDefaultResolution()
		{
			Screen.SetResolution(1920, 1080, Screen.fullScreen);
			this.currentRes = Screen.currentResolution;
			base.StartCoroutine(this.RefreshOnNextFrame());
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000E090A File Offset: 0x000DEB0A
		public void RefreshControls()
		{
			this.RefreshAvailableResolutions();
			this.RefreshCurrentIndex();
			this.PushUpdateOptionList();
			this.UpdateText();
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000E0924 File Offset: 0x000DEB24
		public void RollbackResolution()
		{
			Screen.SetResolution(this.previousRes.width, this.previousRes.height, Screen.fullScreen);
			this.currentRes = Screen.currentResolution;
			base.StartCoroutine(this.RefreshOnNextFrame());
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000E0960 File Offset: 0x000DEB60
		public void RefreshCurrentIndex()
		{
			this.foundResolutionInList = false;
			for (int i = 0; i < this.availableResolutions.Length; i++)
			{
				if (this.currentRes.Equals(this.availableResolutions[i]))
				{
					this.selectedOptionIndex = i;
					this.currentlyActiveResIndex = i;
					this.foundResolutionInList = true;
					break;
				}
			}
			if (!this.foundResolutionInList)
			{
				Resolution[] array = new Resolution[this.availableResolutions.Length + 1];
				array[0] = this.currentRes;
				for (int j = 0; j < this.availableResolutions.Length; j++)
				{
					array[j + 1] = this.availableResolutions[j];
				}
				this.availableResolutions = array;
				this.selectedOptionIndex = 0;
				this.currentlyActiveResIndex = 0;
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000E0A28 File Offset: 0x000DEC28
		public void PushUpdateOptionList()
		{
			string[] array = new string[this.availableResolutions.Length];
			for (int i = 0; i < this.availableResolutions.Length; i++)
			{
				array[i] = this.availableResolutions[i].ToString();
			}
			base.SetOptionList(array);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x000E0A77 File Offset: 0x000DEC77
		private void HideApplyButton()
		{
			this.applyButton.alpha = 0f;
			this.applyButton.interactable = false;
			this.applyButton.blocksRaycasts = false;
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000E0AA1 File Offset: 0x000DECA1
		private void ShowApplyButton()
		{
			this.applyButton.alpha = 1f;
			this.applyButton.interactable = true;
			this.applyButton.blocksRaycasts = true;
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x000E0ACC File Offset: 0x000DECCC
		private void RefreshAvailableResolutions()
		{
			this.screenRes = Screen.currentResolution;
			if (!Screen.fullScreen)
			{
				this.currentRes = new Resolution
				{
					width = Screen.width,
					height = Screen.height,
					refreshRate = this.screenRes.refreshRate
				};
			}
			else
			{
				this.currentRes = this.screenRes;
			}
			this.availableResolutions = Screen.resolutions;
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x000E0B40 File Offset: 0x000DED40
		private IEnumerator RefreshOnNextFrame()
		{
			yield return null;
			this.RefreshAvailableResolutions();
			this.RefreshCurrentIndex();
			this.PushUpdateOptionList();
			this.UpdateApplyButton();
			this.UpdateText();
			yield break;
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x000E0B4F File Offset: 0x000DED4F
		public MenuResolutionSetting()
		{
			this.currentlyActiveResIndex = -1;
			base..ctor();
		}

		// Token: 0x04002D01 RID: 11521
		private Resolution[] availableResolutions;

		// Token: 0x04002D02 RID: 11522
		private Resolution previousRes;

		// Token: 0x04002D03 RID: 11523
		private bool foundResolutionInList;

		// Token: 0x04002D04 RID: 11524
		private int currentlyActiveResIndex;

		// Token: 0x04002D05 RID: 11525
		private int previousResIndex;

		// Token: 0x04002D06 RID: 11526
		[Header("Resolution Setting Specific")]
		public CanvasGroup applyButton;
	}
}
