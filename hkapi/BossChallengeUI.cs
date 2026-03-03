using System;
using System.Collections;
using Language;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000270 RID: 624
public class BossChallengeUI : MonoBehaviour
{
	// Token: 0x14000017 RID: 23
	// (add) Token: 0x06000D15 RID: 3349 RVA: 0x00041AD4 File Offset: 0x0003FCD4
	// (remove) Token: 0x06000D16 RID: 3350 RVA: 0x00041B0C File Offset: 0x0003FD0C
	public event BossChallengeUI.HideEvent OnCancel;

	// Token: 0x14000018 RID: 24
	// (add) Token: 0x06000D17 RID: 3351 RVA: 0x00041B44 File Offset: 0x0003FD44
	// (remove) Token: 0x06000D18 RID: 3352 RVA: 0x00041B7C File Offset: 0x0003FD7C
	public event BossChallengeUI.LevelSelectedEvent OnLevelSelected;

	// Token: 0x06000D19 RID: 3353 RVA: 0x00041BB4 File Offset: 0x0003FDB4
	private void Awake()
	{
		this.canvas = base.GetComponent<Canvas>();
		this.animator = base.GetComponent<Animator>();
		this.group = base.GetComponent<CanvasGroup>();
		if (this.group)
		{
			this.group.alpha = 0f;
		}
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00041C04 File Offset: 0x0003FE04
	private void Start()
	{
		if (this.canvas && GameCameras.instance && GameCameras.instance.hudCamera)
		{
			this.canvas.worldCamera = GameCameras.instance.hudCamera;
		}
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00041C50 File Offset: 0x0003FE50
	public void Setup(BossStatue bossStatue, string bossNameSheet, string bossNameKey, string descriptionSheet, string descriptionKey)
	{
		this.bossStatue = bossStatue;
		if (this.bossNameText)
		{
			this.bossNameText.text = Language.Get(bossNameKey, bossNameSheet);
		}
		if (this.descriptionText)
		{
			this.descriptionText.text = Language.Get(descriptionKey, descriptionSheet);
		}
		if (!bossStatue.hasNoTiers)
		{
			BossStatue.Completion completion = bossStatue.UsingDreamVersion ? bossStatue.DreamStatueState : bossStatue.StatueState;
			this.tier1Button.SetState(completion.completedTier1);
			this.tier2Button.SetState(completion.completedTier2);
			this.tier3Button.SetState(completion.completedTier3);
			this.tier1Button.SetupNavigation(true, completion.completedTier2 ? this.tier3Button : this.tier2Button, this.tier2Button);
			this.tier2Button.SetupNavigation(true, this.tier1Button, completion.completedTier2 ? this.tier3Button : this.tier1Button);
			this.tier3Button.SetupNavigation(completion.completedTier2, this.tier2Button, this.tier1Button);
			if (this.tier3UnlockEffect && completion.completedTier2 && !completion.seenTier3Unlock)
			{
				base.StartCoroutine(this.ShowUnlockEffect());
			}
			base.StartCoroutine(this.SetFirstSelected());
			return;
		}
		this.LoadBoss(0, false);
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00041DA6 File Offset: 0x0003FFA6
	private IEnumerator ShowUnlockEffect()
	{
		BossStatue.Completion state = this.bossStatue.UsingDreamVersion ? this.bossStatue.DreamStatueState : this.bossStatue.StatueState;
		yield return new WaitForSeconds(this.tier3UnlockEffectDelay);
		this.tier3UnlockEffect.SetActive(true);
		state.seenTier3Unlock = true;
		if (this.bossStatue.UsingDreamVersion)
		{
			this.bossStatue.DreamStatueState = state;
		}
		else
		{
			this.bossStatue.StatueState = state;
		}
		yield break;
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00041DB5 File Offset: 0x0003FFB5
	private IEnumerator SetFirstSelected()
	{
		MenuSelectable select = this.firstSelected;
		if (BossChallengeUI.lastSelectedButton >= 0)
		{
			switch (BossChallengeUI.lastSelectedButton)
			{
			case 0:
				if (this.tier1Button.button && this.tier1Button.button.interactable)
				{
					select = this.tier1Button.button;
				}
				break;
			case 1:
				if (this.tier2Button.button && this.tier2Button.button.interactable)
				{
					select = this.tier2Button.button;
				}
				break;
			case 2:
				if (this.tier3Button.button && this.tier3Button.button.interactable)
				{
					select = this.tier3Button.button;
				}
				break;
			}
		}
		if (select)
		{
			select.ForceDeselect();
			yield return null;
			select.DontPlaySelectSound = true;
			select.Select();
			InputHandler.Instance.StartUIInput();
		}
		yield break;
	}

	// Token: 0x06000D1E RID: 3358 RVA: 0x00041DC4 File Offset: 0x0003FFC4
	public void Hide()
	{
		this.Hide(true);
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00041DCD File Offset: 0x0003FFCD
	public void Hide(bool doAnim)
	{
		if (doAnim)
		{
			base.StartCoroutine(this.HideAnim());
			return;
		}
		if (this.OnCancel != null)
		{
			this.OnCancel();
		}
		base.gameObject.SetActive(false);
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x00041DFF File Offset: 0x0003FFFF
	private IEnumerator HideAnim()
	{
		if (this.animator)
		{
			this.animator.Play(this.closeStateName);
			AnimatorClipInfo[] currentAnimatorClipInfo = this.animator.GetCurrentAnimatorClipInfo(0);
			yield return new WaitForSeconds(currentAnimatorClipInfo[0].clip.length);
		}
		if (this.tier3UnlockEffect)
		{
			this.tier3UnlockEffect.SetActive(false);
		}
		if (this.OnCancel != null)
		{
			this.OnCancel();
		}
		this.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00041E0E File Offset: 0x0004000E
	public void LoadBoss(int level)
	{
		this.LoadBoss(level, true);
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00041E18 File Offset: 0x00040018
	public void LoadBoss(int level, bool doHideAnim)
	{
		BossScene bossScene = this.bossStatue.UsingDreamVersion ? this.bossStatue.dreamBossScene : this.bossStatue.bossScene;
		string text = bossScene.sceneName;
		switch (level)
		{
		case 0:
			text = bossScene.Tier1Scene;
			break;
		case 1:
			text = bossScene.Tier2Scene;
			break;
		case 2:
			text = bossScene.Tier3Scene;
			break;
		}
		if (!Application.CanStreamedLevelBeLoaded(text))
		{
			this.Hide(doHideAnim);
			Debug.LogError(string.Format("Could not start boss scene. Scene: \"{0}\" does not exist!", text));
			return;
		}
		StaticVariableList.SetValue<string>("bossSceneToLoad", text);
		BossStatueLoadManager.RecordBossScene(bossScene);
		this.OnCancel = null;
		this.Hide(doHideAnim);
		GameManager.instance.playerData.SetStringSwappedArgs(this.bossStatue.dreamReturnGate.name, "bossReturnEntryGate");
		Action <>9__1;
		BossSceneController.SetupEvent = delegate(BossSceneController self)
		{
			self.BossLevel = level;
			self.DreamReturnEvent = "DREAM RETURN";
			BossSceneController self2 = self;
			Action value;
			if ((value = <>9__1) == null)
			{
				value = (<>9__1 = delegate()
				{
					string fieldName = this.bossStatue.UsingDreamVersion ? this.bossStatue.dreamStatueStatePD : this.bossStatue.statueStatePD;
					BossStatue.Completion playerDataVariable = GameManager.instance.GetPlayerDataVariable<BossStatue.Completion>(fieldName);
					switch (level)
					{
					case 0:
						playerDataVariable.completedTier1 = true;
						break;
					case 1:
						playerDataVariable.completedTier2 = true;
						break;
					case 2:
						playerDataVariable.completedTier3 = true;
						break;
					}
					GameManager.instance.SetPlayerDataVariable<BossStatue.Completion>(fieldName, playerDataVariable);
					GameManager.instance.playerData.SetStringSwappedArgs(this.bossStatue.UsingDreamVersion ? this.bossStatue.dreamStatueStatePD : this.bossStatue.statueStatePD, "currentBossStatueCompletionKey");
					GameManager.instance.playerData.SetIntSwappedArgs(level, "bossStatueTargetLevel");
				});
			}
			self2.OnBossesDead += value;
			self.OnBossSceneComplete += delegate()
			{
				self.DoDreamReturn();
			};
		};
		if (this.OnLevelSelected != null)
		{
			this.OnLevelSelected();
		}
	}

	// Token: 0x06000D23 RID: 3363 RVA: 0x00041F21 File Offset: 0x00040121
	public void RecordLastSelected(int index)
	{
		BossChallengeUI.lastSelectedButton = index;
	}

	// Token: 0x06000D24 RID: 3364 RVA: 0x00041F29 File Offset: 0x00040129
	public BossChallengeUI()
	{
		this.closeStateName = "GG_Challenge_Close";
		this.tier3UnlockEffectDelay = 0.5f;
		base..ctor();
	}

	// Token: 0x06000D25 RID: 3365 RVA: 0x00041F47 File Offset: 0x00040147
	// Note: this type is marked as 'beforefieldinit'.
	static BossChallengeUI()
	{
		BossChallengeUI.lastSelectedButton = -1;
	}

	// Token: 0x04000DFB RID: 3579
	private BossStatue bossStatue;

	// Token: 0x04000DFC RID: 3580
	public Text bossNameText;

	// Token: 0x04000DFD RID: 3581
	public Text descriptionText;

	// Token: 0x04000DFE RID: 3582
	[Space]
	public MenuSelectable firstSelected;

	// Token: 0x04000DFF RID: 3583
	public string closeStateName;

	// Token: 0x04000E00 RID: 3584
	public BossChallengeUI.ButtonDisplay tier1Button;

	// Token: 0x04000E01 RID: 3585
	public BossChallengeUI.ButtonDisplay tier2Button;

	// Token: 0x04000E02 RID: 3586
	public BossChallengeUI.ButtonDisplay tier3Button;

	// Token: 0x04000E03 RID: 3587
	public GameObject tier3UnlockEffect;

	// Token: 0x04000E04 RID: 3588
	public float tier3UnlockEffectDelay;

	// Token: 0x04000E05 RID: 3589
	private static int lastSelectedButton;

	// Token: 0x04000E06 RID: 3590
	private Canvas canvas;

	// Token: 0x04000E07 RID: 3591
	private Animator animator;

	// Token: 0x04000E08 RID: 3592
	private CanvasGroup group;

	// Token: 0x04000E09 RID: 3593
	private bool started;

	// Token: 0x02000271 RID: 625
	// (Invoke) Token: 0x06000D27 RID: 3367
	public delegate void HideEvent();

	// Token: 0x02000272 RID: 626
	// (Invoke) Token: 0x06000D2B RID: 3371
	public delegate void LevelSelectedEvent();

	// Token: 0x02000273 RID: 627
	[Serializable]
	public class ButtonDisplay
	{
		// Token: 0x06000D2E RID: 3374 RVA: 0x00041F50 File Offset: 0x00040150
		public void SetupNavigation(bool isActive, BossChallengeUI.ButtonDisplay selectOnUp, BossChallengeUI.ButtonDisplay selectOnDown)
		{
			this.button.interactable = isActive;
			Navigation navigation = this.button.navigation;
			navigation.selectOnUp = selectOnUp.button;
			navigation.selectOnDown = selectOnDown.button;
			this.button.navigation = navigation;
			CanvasGroup component = this.button.GetComponent<CanvasGroup>();
			if (component)
			{
				component.alpha = (isActive ? this.enabledAlpha : this.disabledAlpha);
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00041FC8 File Offset: 0x000401C8
		public void SetState(bool isComplete)
		{
			if (this.completeImage)
			{
				this.completeImage.gameObject.SetActive(isComplete);
			}
			if (this.incompleteImage)
			{
				this.incompleteImage.gameObject.SetActive(!isComplete);
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00042014 File Offset: 0x00040214
		public ButtonDisplay()
		{
			this.enabledAlpha = 1f;
			this.disabledAlpha = 0.5f;
			base..ctor();
		}

		// Token: 0x04000E0A RID: 3594
		public Image completeImage;

		// Token: 0x04000E0B RID: 3595
		public Image incompleteImage;

		// Token: 0x04000E0C RID: 3596
		public MenuSelectable button;

		// Token: 0x04000E0D RID: 3597
		public float enabledAlpha;

		// Token: 0x04000E0E RID: 3598
		public float disabledAlpha;
	}
}
