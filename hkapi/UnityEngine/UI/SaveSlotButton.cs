using System;
using System.Collections;
using GlobalEnums;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200069B RID: 1691
	[Serializable]
	public class SaveSlotButton : MenuButton, ISelectHandler, IEventSystemHandler, IDeselectHandler, ISubmitHandler, IPointerClickHandler
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x000E16DA File Offset: 0x000DF8DA
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x000E16E2 File Offset: 0x000DF8E2
		public SaveSlotButton.SlotState state { get; private set; }

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x000E16EC File Offset: 0x000DF8EC
		private int SaveSlotIndex
		{
			get
			{
				switch (this.saveSlot)
				{
				case SaveSlotButton.SaveSlot.SLOT_1:
					return 1;
				case SaveSlotButton.SaveSlot.SLOT_2:
					return 2;
				case SaveSlotButton.SaveSlot.SLOT_3:
					return 3;
				case SaveSlotButton.SaveSlot.SLOT_4:
					return 4;
				default:
					return 0;
				}
			}
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000E1721 File Offset: 0x000DF921
		private new void Awake()
		{
			this.gm = GameManager.instance;
			this.clearSavePromptHighlight = this.clearSavePrompt.GetComponent<PreselectOption>();
			this.coroutineQueue = new CoroutineQueue(this.gm);
			this.SetupNavs();
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x000E1756 File Offset: 0x000DF956
		private new void OnEnable()
		{
			if (this.saveStats != null && this.saveFileState == SaveSlotButton.SaveFileStates.LoadedStats)
			{
				this.PresentSaveSlot(this.saveStats);
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000E1775 File Offset: 0x000DF975
		private new void Start()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.ui = UIManager.instance;
			this.ih = this.gm.inputHandler;
			base.HookUpAudioPlayer();
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000E17A4 File Offset: 0x000DF9A4
		public void Prepare(GameManager gameManager, bool isReload = false)
		{
			if (this.saveFileState == SaveSlotButton.SaveFileStates.NotStarted || (isReload && this.saveFileState == SaveSlotButton.SaveFileStates.Corrupted))
			{
				this.ChangeSaveFileState(SaveSlotButton.SaveFileStates.OperationInProgress);
				Action<SaveStats> <>9__1;
				Platform.Current.IsSaveSlotInUse(this.SaveSlotIndex, delegate(bool fileExists)
				{
					if (!fileExists)
					{
						this.ChangeSaveFileState(SaveSlotButton.SaveFileStates.Empty);
						return;
					}
					GameManager gameManager2 = gameManager;
					int saveSlotIndex = this.SaveSlotIndex;
					Action<SaveStats> callback;
					if ((callback = <>9__1) == null)
					{
						callback = (<>9__1 = delegate(SaveStats saveStats)
						{
							if (saveStats == null)
							{
								this.ChangeSaveFileState(SaveSlotButton.SaveFileStates.Corrupted);
								return;
							}
							this.saveStats = saveStats;
							this.ChangeSaveFileState(SaveSlotButton.SaveFileStates.LoadedStats);
						});
					}
					gameManager2.GetSaveStatsForSlot(saveSlotIndex, callback);
				});
			}
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000E17FC File Offset: 0x000DF9FC
		public void ClearCache()
		{
			this.saveFileState = SaveSlotButton.SaveFileStates.NotStarted;
			this.saveStats = null;
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000E180C File Offset: 0x000DFA0C
		private void ChangeSaveFileState(SaveSlotButton.SaveFileStates nextSaveFileState)
		{
			this.saveFileState = nextSaveFileState;
			if (base.isActiveAndEnabled)
			{
				this.ShowRelevantModeForSaveFileState();
			}
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x000E1824 File Offset: 0x000DFA24
		public new void OnSubmit(BaseEventData eventData)
		{
			if (this.saveFileState == SaveSlotButton.SaveFileStates.LoadedStats)
			{
				if (this.saveStats.permadeathMode == 2)
				{
					base.ForceDeselect();
					this.ClearSavePrompt();
				}
				else
				{
					this.gm.LoadGameFromUI(this.SaveSlotIndex);
				}
				base.OnSubmit(eventData);
				return;
			}
			if (this.saveFileState == SaveSlotButton.SaveFileStates.Empty)
			{
				this.gm.profileID = this.SaveSlotIndex;
				if (this.gm.GetStatusRecordInt("RecPermadeathMode") == 1 || this.gm.GetStatusRecordInt("RecBossRushMode") == 1)
				{
					this.ui.UIGoToPlayModeMenu();
				}
				else
				{
					this.ui.StartNewGame(false, false);
				}
				base.OnSubmit(eventData);
				return;
			}
			if (this.saveFileState == SaveSlotButton.SaveFileStates.Corrupted)
			{
				base.StartCoroutine(this.ReloadCorrupted());
			}
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x000E18E7 File Offset: 0x000DFAE7
		protected IEnumerator ReloadCorrupted()
		{
			this.ih.StopUIInput();
			this.Prepare(this.gm, true);
			while (this.saveFileState == SaveSlotButton.SaveFileStates.OperationInProgress)
			{
				yield return null;
			}
			this.ih.StartUIInput();
			yield break;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000E18F6 File Offset: 0x000DFAF6
		public new void OnPointerClick(PointerEventData eventData)
		{
			this.OnSubmit(eventData);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x000E1900 File Offset: 0x000DFB00
		public new void OnSelect(BaseEventData eventData)
		{
			this.highlight.ResetTrigger("hide");
			this.highlight.SetTrigger("show");
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
			base.OnSelect(eventData);
			if (!base.interactable)
			{
				try
				{
					this.uiAudioPlayer.PlaySelect();
				}
				catch (Exception ex)
				{
					string name = base.name;
					string str = " doesn't have a select sound specified. ";
					Exception ex2 = ex;
					Debug.LogError(name + str + ((ex2 != null) ? ex2.ToString() : null));
				}
			}
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x000E19DC File Offset: 0x000DFBDC
		public new void OnDeselect(BaseEventData eventData)
		{
			base.StartCoroutine(this.ValidateDeselect());
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x000E19EC File Offset: 0x000DFBEC
		public void ShowRelevantModeForSaveFileState()
		{
			switch (this.saveFileState)
			{
			case SaveSlotButton.SaveFileStates.Empty:
				this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.EMPTY_SLOT));
				return;
			case SaveSlotButton.SaveFileStates.LoadedStats:
				if (this.saveStats.permadeathMode == 2)
				{
					this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.DEFEATED));
					return;
				}
				this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.SAVE_PRESENT));
				return;
			case SaveSlotButton.SaveFileStates.Corrupted:
				this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.CORRUPTED));
				return;
			}
			this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.OPERATION_IN_PROGRESS));
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x000E1A88 File Offset: 0x000DFC88
		public void HideSaveSlot()
		{
			this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.HIDDEN));
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x000E1A9C File Offset: 0x000DFC9C
		public void ClearSavePrompt()
		{
			this.coroutineQueue.Enqueue(this.AnimateToSlotState(SaveSlotButton.SlotState.CLEAR_PROMPT));
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000E1AB0 File Offset: 0x000DFCB0
		public void CancelClearSave()
		{
			if (this.state == SaveSlotButton.SlotState.CLEAR_PROMPT)
			{
				this.ShowRelevantModeForSaveFileState();
			}
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000E1AC1 File Offset: 0x000DFCC1
		public void ClearSaveFile()
		{
			this.gm.ClearSaveFile(this.SaveSlotIndex, delegate(bool didClear)
			{
			});
			this.saveStats = null;
			this.ChangeSaveFileState(SaveSlotButton.SaveFileStates.Empty);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000E1B01 File Offset: 0x000DFD01
		private IEnumerator FadeInCanvasGroupAfterDelay(float delay, CanvasGroup cg)
		{
			for (float timer = 0f; timer < delay; timer += Time.unscaledDeltaTime)
			{
				yield return null;
			}
			yield return this.ui.FadeInCanvasGroup(cg);
			yield break;
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x000E1B1E File Offset: 0x000DFD1E
		private IEnumerator AnimateToSlotState(SaveSlotButton.SlotState nextState)
		{
			SaveSlotButton.SlotState state = this.state;
			if (state == nextState)
			{
				yield break;
			}
			if (this.currentLoadingTextFadeIn != null)
			{
				this.StopCoroutine(this.currentLoadingTextFadeIn);
				this.currentLoadingTextFadeIn = null;
			}
			if (this.verboseMode)
			{
				Debug.LogFormat("{0} SetState: {1} -> {2}", new object[]
				{
					this.name,
					this.state,
					nextState
				});
			}
			this.state = nextState;
			switch (nextState)
			{
			case SaveSlotButton.SlotState.HIDDEN:
			case SaveSlotButton.SlotState.OPERATION_IN_PROGRESS:
				this.navigation = this.noNav;
				break;
			case SaveSlotButton.SlotState.EMPTY_SLOT:
				this.navigation = this.emptySlotNav;
				break;
			case SaveSlotButton.SlotState.SAVE_PRESENT:
			case SaveSlotButton.SlotState.CORRUPTED:
			case SaveSlotButton.SlotState.DEFEATED:
				this.navigation = this.fullSlotNav;
				break;
			}
			if (state == SaveSlotButton.SlotState.HIDDEN)
			{
				if (nextState == SaveSlotButton.SlotState.OPERATION_IN_PROGRESS)
				{
					this.topFleur.ResetTrigger("hide");
					this.topFleur.SetTrigger("show");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.currentLoadingTextFadeIn = this.FadeInCanvasGroupAfterDelay(5f, this.loadingText));
				}
				else if (nextState == SaveSlotButton.SlotState.EMPTY_SLOT)
				{
					this.topFleur.ResetTrigger("hide");
					this.topFleur.SetTrigger("show");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.newGameText));
				}
				else if (nextState == SaveSlotButton.SlotState.SAVE_PRESENT)
				{
					this.topFleur.ResetTrigger("hide");
					this.topFleur.SetTrigger("show");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.backgroundCg));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.activeSaveSlot));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
				}
				else if (nextState == SaveSlotButton.SlotState.DEFEATED)
				{
					this.topFleur.ResetTrigger("hide");
					this.topFleur.SetTrigger("show");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.defeatedBackground));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.defeatedText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.brokenSteelOrb));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.myCanvasGroup.blocksRaycasts = true;
				}
				else if (nextState == SaveSlotButton.SlotState.CORRUPTED)
				{
					this.topFleur.ResetTrigger("hide");
					this.topFleur.SetTrigger("show");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.saveCorruptedText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.myCanvasGroup.blocksRaycasts = true;
				}
			}
			else if (state == SaveSlotButton.SlotState.OPERATION_IN_PROGRESS)
			{
				if (nextState == SaveSlotButton.SlotState.EMPTY_SLOT)
				{
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.loadingText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.newGameText));
				}
				else if (nextState == SaveSlotButton.SlotState.SAVE_PRESENT)
				{
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.loadingText));
					if (this.saveStats != null)
					{
						this.PresentSaveSlot(this.saveStats);
					}
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.backgroundCg));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.activeSaveSlot));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
				}
				else if (nextState == SaveSlotButton.SlotState.DEFEATED)
				{
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.loadingText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.defeatedBackground));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.defeatedText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.brokenSteelOrb));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.myCanvasGroup.blocksRaycasts = true;
				}
				else if (nextState == SaveSlotButton.SlotState.CORRUPTED)
				{
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.loadingText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.saveCorruptedText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.myCanvasGroup.blocksRaycasts = true;
				}
			}
			else if (state == SaveSlotButton.SlotState.SAVE_PRESENT)
			{
				if (nextState == SaveSlotButton.SlotState.CLEAR_PROMPT)
				{
					this.ih.StopUIInput();
					this.interactable = false;
					this.myCanvasGroup.blocksRaycasts = false;
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.activeSaveSlot));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.backgroundCg));
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = false;
					this.clearSaveBlocker.SetActive(true);
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSavePrompt));
					this.clearSavePrompt.interactable = true;
					this.clearSavePrompt.blocksRaycasts = true;
					this.clearSavePromptHighlight.HighlightDefault(false);
					this.ih.StartUIInput();
				}
				else if (nextState == SaveSlotButton.SlotState.HIDDEN)
				{
					this.topFleur.ResetTrigger("show");
					this.topFleur.SetTrigger("hide");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.backgroundCg));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.activeSaveSlot));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = false;
				}
			}
			else if (state == SaveSlotButton.SlotState.CLEAR_PROMPT)
			{
				if (nextState == SaveSlotButton.SlotState.SAVE_PRESENT)
				{
					this.ih.StopUIInput();
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSavePrompt));
					this.clearSaveBlocker.SetActive(false);
					this.clearSavePrompt.interactable = false;
					this.clearSavePrompt.blocksRaycasts = false;
					if (this.saveStats != null)
					{
						this.PresentSaveSlot(this.saveStats);
					}
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.activeSaveSlot));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.backgroundCg));
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.interactable = true;
					this.myCanvasGroup.blocksRaycasts = true;
					this.Select();
					this.ih.StartUIInput();
				}
				else if (nextState == SaveSlotButton.SlotState.EMPTY_SLOT)
				{
					this.ih.StopUIInput();
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.backgroundCg));
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSavePrompt));
					this.clearSavePrompt.interactable = false;
					this.clearSavePrompt.blocksRaycasts = false;
					this.clearSaveBlocker.SetActive(false);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.newGameText));
					this.myCanvasGroup.blocksRaycasts = true;
					this.Select();
					this.ih.StartUIInput();
				}
				else if (nextState == SaveSlotButton.SlotState.DEFEATED)
				{
					this.ih.StopUIInput();
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.backgroundCg));
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSavePrompt));
					this.clearSavePrompt.interactable = false;
					this.clearSavePrompt.blocksRaycasts = false;
					this.clearSaveBlocker.SetActive(false);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.defeatedBackground));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.defeatedText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.brokenSteelOrb));
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.myCanvasGroup.blocksRaycasts = true;
					this.Select();
					this.ih.StartUIInput();
				}
				else if (nextState == SaveSlotButton.SlotState.HIDDEN)
				{
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSavePrompt));
				}
				else if (nextState == SaveSlotButton.SlotState.CORRUPTED)
				{
					this.ih.StopUIInput();
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSavePrompt));
					this.clearSavePrompt.interactable = false;
					this.clearSavePrompt.blocksRaycasts = false;
					this.clearSaveBlocker.SetActive(false);
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeInCanvasGroup(this.saveCorruptedText));
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = true;
					this.myCanvasGroup.blocksRaycasts = true;
					this.Select();
					this.ih.StartUIInput();
				}
			}
			else if (state == SaveSlotButton.SlotState.EMPTY_SLOT)
			{
				if (nextState == SaveSlotButton.SlotState.HIDDEN)
				{
					this.topFleur.ResetTrigger("show");
					this.topFleur.SetTrigger("hide");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.backgroundCg));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.newGameText));
				}
			}
			else if (state == SaveSlotButton.SlotState.DEFEATED)
			{
				if (nextState == SaveSlotButton.SlotState.CLEAR_PROMPT)
				{
					this.ih.StopUIInput();
					this.interactable = false;
					this.myCanvasGroup.blocksRaycasts = false;
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.defeatedBackground));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.defeatedText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.brokenSteelOrb));
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = false;
					this.clearSaveBlocker.SetActive(true);
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSavePrompt));
					this.clearSavePrompt.interactable = true;
					this.clearSavePrompt.blocksRaycasts = true;
					this.clearSavePromptHighlight.HighlightDefault(false);
					this.interactable = false;
					this.myCanvasGroup.blocksRaycasts = false;
					this.ih.StartUIInput();
				}
				else if (nextState == SaveSlotButton.SlotState.HIDDEN)
				{
					this.topFleur.ResetTrigger("show");
					this.topFleur.SetTrigger("hide");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.backgroundCg));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.activeSaveSlot));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.defeatedBackground));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.defeatedText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.brokenSteelOrb));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = false;
				}
			}
			else if (state == SaveSlotButton.SlotState.CORRUPTED)
			{
				if (nextState == SaveSlotButton.SlotState.CLEAR_PROMPT)
				{
					this.ih.StopUIInput();
					this.interactable = false;
					this.myCanvasGroup.blocksRaycasts = false;
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.saveCorruptedText));
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = false;
					this.clearSaveBlocker.SetActive(true);
					yield return this.StartCoroutine(this.ui.FadeInCanvasGroup(this.clearSavePrompt));
					this.clearSavePrompt.interactable = true;
					this.clearSavePrompt.blocksRaycasts = true;
					this.clearSavePromptHighlight.HighlightDefault(false);
					this.interactable = false;
					this.myCanvasGroup.blocksRaycasts = false;
					this.ih.StartUIInput();
				}
				else if (nextState == SaveSlotButton.SlotState.HIDDEN)
				{
					this.topFleur.ResetTrigger("show");
					this.topFleur.SetTrigger("hide");
					yield return new WaitForSeconds(0.2f);
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.saveCorruptedText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.clearSaveButton.blocksRaycasts = false;
				}
				else if (nextState == SaveSlotButton.SlotState.OPERATION_IN_PROGRESS)
				{
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.slotNumberText));
					this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.saveCorruptedText));
					yield return this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.clearSaveButton));
					this.StartCoroutine(this.currentLoadingTextFadeIn = this.FadeInCanvasGroupAfterDelay(5f, this.loadingText));
				}
			}
			else if (state == SaveSlotButton.SlotState.OPERATION_IN_PROGRESS && nextState == SaveSlotButton.SlotState.HIDDEN)
			{
				this.topFleur.ResetTrigger("show");
				this.topFleur.SetTrigger("hide");
				yield return new WaitForSeconds(0.2f);
				this.StartCoroutine(this.ui.FadeOutCanvasGroup(this.loadingText));
			}
			yield break;
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000E1B34 File Offset: 0x000DFD34
		private void PresentSaveSlot(SaveStats saveStats)
		{
			this.geoIcon.enabled = true;
			this.geoText.enabled = true;
			this.completionText.enabled = true;
			if (saveStats.bossRushMode)
			{
				this.normalSoulOrbCg.alpha = 0f;
				this.hardcoreSoulOrbCg.alpha = 0f;
				this.ggSoulOrbCg.alpha = 1f;
				this.healthSlots.showHealth(saveStats.maxHealth, false);
				this.playTimeText.text = saveStats.GetPlaytimeHHMM();
				this.mpSlots.showMPSlots(saveStats.GetMPSlotsVisible(), false);
				this.geoIcon.enabled = false;
				this.geoText.enabled = false;
				this.completionText.enabled = false;
				AreaBackground areaBackground = this.saveSlots.GetBackground(MapZone.GODS_GLORY);
				if (areaBackground != null)
				{
					this.background.sprite = areaBackground.backgroundImage;
				}
			}
			else if (saveStats.permadeathMode == 0)
			{
				this.normalSoulOrbCg.alpha = 1f;
				this.hardcoreSoulOrbCg.alpha = 0f;
				this.ggSoulOrbCg.alpha = 0f;
				this.healthSlots.showHealth(saveStats.maxHealth, false);
				this.geoText.text = saveStats.geo.ToString();
				if (saveStats.unlockedCompletionRate)
				{
					this.completionText.text = saveStats.completionPercentage.ToString() + "%";
				}
				else
				{
					this.completionText.text = "";
				}
				this.playTimeText.text = saveStats.GetPlaytimeHHMM();
				this.mpSlots.showMPSlots(saveStats.GetMPSlotsVisible(), false);
				AreaBackground areaBackground2 = this.saveSlots.GetBackground(saveStats.mapZone);
				if (areaBackground2 != null)
				{
					this.background.sprite = areaBackground2.backgroundImage;
				}
			}
			else if (saveStats.permadeathMode == 1)
			{
				this.normalSoulOrbCg.alpha = 0f;
				this.hardcoreSoulOrbCg.alpha = 1f;
				this.ggSoulOrbCg.alpha = 0f;
				this.healthSlots.showHealth(saveStats.maxHealth, true);
				this.geoText.text = saveStats.geo.ToString();
				if (saveStats.unlockedCompletionRate)
				{
					this.completionText.text = saveStats.completionPercentage.ToString() + "%";
				}
				else
				{
					this.completionText.text = "";
				}
				this.playTimeText.text = saveStats.GetPlaytimeHHMM();
				this.mpSlots.showMPSlots(saveStats.GetMPSlotsVisible(), true);
				AreaBackground areaBackground3 = this.saveSlots.GetBackground(saveStats.mapZone);
				if (areaBackground3 != null)
				{
					this.background.sprite = areaBackground3.backgroundImage;
				}
			}
			else if (saveStats.permadeathMode == 2)
			{
				this.normalSoulOrbCg.alpha = 0f;
				this.hardcoreSoulOrbCg.alpha = 0f;
				this.ggSoulOrbCg.alpha = 0f;
			}
			this.locationText.text = this.gm.GetFormattedMapZoneString(saveStats.mapZone).Replace("<br>", Environment.NewLine);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x000E1E70 File Offset: 0x000E0070
		private void SetupNavs()
		{
			this.noNav = new Navigation
			{
				mode = Navigation.Mode.Explicit,
				selectOnLeft = null,
				selectOnRight = null,
				selectOnUp = base.navigation.selectOnUp,
				selectOnDown = base.navigation.selectOnDown
			};
			this.emptySlotNav = new Navigation
			{
				mode = Navigation.Mode.Explicit,
				selectOnRight = null,
				selectOnUp = base.navigation.selectOnUp,
				selectOnDown = base.navigation.selectOnDown
			};
			this.fullSlotNav = new Navigation
			{
				mode = Navigation.Mode.Explicit,
				selectOnRight = this.clearSaveButton.GetComponent<ClearSaveButton>(),
				selectOnUp = base.navigation.selectOnUp,
				selectOnDown = base.navigation.selectOnDown
			};
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x000E1F6A File Offset: 0x000E016A
		private IEnumerator ValidateDeselect()
		{
			this.prevSelectedObject = EventSystem.current.currentSelectedGameObject;
			yield return new WaitForEndOfFrame();
			if (EventSystem.current.currentSelectedGameObject != null)
			{
				this.leftCursor.ResetTrigger("show");
				this.rightCursor.ResetTrigger("show");
				this.highlight.ResetTrigger("show");
				this.leftCursor.SetTrigger("hide");
				this.rightCursor.SetTrigger("hide");
				this.highlight.SetTrigger("hide");
				this.deselectWasForced = false;
			}
			else if (this.deselectWasForced)
			{
				this.leftCursor.ResetTrigger("show");
				this.rightCursor.ResetTrigger("show");
				this.highlight.ResetTrigger("show");
				this.leftCursor.SetTrigger("hide");
				this.rightCursor.SetTrigger("hide");
				this.highlight.SetTrigger("hide");
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

		// Token: 0x04002D2F RID: 11567
		private bool verboseMode;

		// Token: 0x04002D30 RID: 11568
		[Header("Slot Number")]
		public SaveSlotButton.SaveSlot saveSlot;

		// Token: 0x04002D31 RID: 11569
		[Header("Animation")]
		public Animator topFleur;

		// Token: 0x04002D32 RID: 11570
		public Animator highlight;

		// Token: 0x04002D33 RID: 11571
		[Header("Canvas Groups")]
		public CanvasGroup newGameText;

		// Token: 0x04002D34 RID: 11572
		public CanvasGroup saveCorruptedText;

		// Token: 0x04002D35 RID: 11573
		public CanvasGroup loadingText;

		// Token: 0x04002D36 RID: 11574
		public CanvasGroup activeSaveSlot;

		// Token: 0x04002D37 RID: 11575
		public CanvasGroup clearSaveButton;

		// Token: 0x04002D38 RID: 11576
		public CanvasGroup clearSavePrompt;

		// Token: 0x04002D39 RID: 11577
		public CanvasGroup backgroundCg;

		// Token: 0x04002D3A RID: 11578
		public CanvasGroup slotNumberText;

		// Token: 0x04002D3B RID: 11579
		public CanvasGroup myCanvasGroup;

		// Token: 0x04002D3C RID: 11580
		public CanvasGroup defeatedText;

		// Token: 0x04002D3D RID: 11581
		public CanvasGroup defeatedBackground;

		// Token: 0x04002D3E RID: 11582
		public CanvasGroup brokenSteelOrb;

		// Token: 0x04002D3F RID: 11583
		[Header("Text Elements")]
		public Text geoText;

		// Token: 0x04002D40 RID: 11584
		public Text locationText;

		// Token: 0x04002D41 RID: 11585
		public Text playTimeText;

		// Token: 0x04002D42 RID: 11586
		public Text completionText;

		// Token: 0x04002D43 RID: 11587
		[Header("Soul Orbs")]
		public CanvasGroup normalSoulOrbCg;

		// Token: 0x04002D44 RID: 11588
		public CanvasGroup hardcoreSoulOrbCg;

		// Token: 0x04002D45 RID: 11589
		public CanvasGroup ggSoulOrbCg;

		// Token: 0x04002D46 RID: 11590
		[Header("Visual Elements")]
		public Image background;

		// Token: 0x04002D47 RID: 11591
		public Image soulOrbIcon;

		// Token: 0x04002D48 RID: 11592
		public SaveProfileHealthBar healthSlots;

		// Token: 0x04002D49 RID: 11593
		public Image geoIcon;

		// Token: 0x04002D4A RID: 11594
		public SaveProfileMPSlots mpSlots;

		// Token: 0x04002D4B RID: 11595
		public SaveSlotBackgrounds saveSlots;

		// Token: 0x04002D4C RID: 11596
		[Header("Raycast Blocker")]
		public GameObject clearSaveBlocker;

		// Token: 0x04002D4D RID: 11597
		private GameManager gm;

		// Token: 0x04002D4E RID: 11598
		private UIManager ui;

		// Token: 0x04002D4F RID: 11599
		private InputHandler ih;

		// Token: 0x04002D50 RID: 11600
		public SaveSlotButton.SaveFileStates saveFileState;

		// Token: 0x04002D52 RID: 11602
		private PreselectOption clearSavePromptHighlight;

		// Token: 0x04002D53 RID: 11603
		[SerializeField]
		private SaveStats saveStats;

		// Token: 0x04002D54 RID: 11604
		private Navigation noNav;

		// Token: 0x04002D55 RID: 11605
		private Navigation fullSlotNav;

		// Token: 0x04002D56 RID: 11606
		private Navigation emptySlotNav;

		// Token: 0x04002D57 RID: 11607
		private IEnumerator currentLoadingTextFadeIn;

		// Token: 0x04002D58 RID: 11608
		private bool didLoadSaveStats;

		// Token: 0x04002D59 RID: 11609
		private CoroutineQueue coroutineQueue;

		// Token: 0x0200069C RID: 1692
		public enum SaveFileStates
		{
			// Token: 0x04002D5B RID: 11611
			NotStarted,
			// Token: 0x04002D5C RID: 11612
			OperationInProgress,
			// Token: 0x04002D5D RID: 11613
			Empty,
			// Token: 0x04002D5E RID: 11614
			LoadedStats,
			// Token: 0x04002D5F RID: 11615
			Corrupted
		}

		// Token: 0x0200069D RID: 1693
		public enum SaveSlot
		{
			// Token: 0x04002D61 RID: 11617
			SLOT_1,
			// Token: 0x04002D62 RID: 11618
			SLOT_2,
			// Token: 0x04002D63 RID: 11619
			SLOT_3,
			// Token: 0x04002D64 RID: 11620
			SLOT_4
		}

		// Token: 0x0200069E RID: 1694
		public enum SlotState
		{
			// Token: 0x04002D66 RID: 11622
			HIDDEN,
			// Token: 0x04002D67 RID: 11623
			OPERATION_IN_PROGRESS,
			// Token: 0x04002D68 RID: 11624
			EMPTY_SLOT,
			// Token: 0x04002D69 RID: 11625
			SAVE_PRESENT,
			// Token: 0x04002D6A RID: 11626
			CORRUPTED,
			// Token: 0x04002D6B RID: 11627
			CLEAR_PROMPT,
			// Token: 0x04002D6C RID: 11628
			DEFEATED
		}
	}
}
