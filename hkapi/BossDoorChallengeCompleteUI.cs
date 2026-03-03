using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200027D RID: 637
public class BossDoorChallengeCompleteUI : MonoBehaviour
{
	// Token: 0x06000D51 RID: 3409 RVA: 0x000426DC File Offset: 0x000408DC
	private void Start()
	{
		base.StartCoroutine(this.Sequence());
		base.StartCoroutine(this.ShowAchievements());
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x000426F8 File Offset: 0x000408F8
	private void Update()
	{
		if (this.waitingForInput && (InputHandler.Instance.gameController.AnyButtonWasPressed || Input.anyKeyDown))
		{
			this.waitingForInput = false;
		}
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00042721 File Offset: 0x00040921
	private IEnumerator ShowAchievements()
	{
		yield return new WaitForSeconds(this.achievementShowDelay);
		GameManager.instance.AwardQueuedAchievements();
		yield break;
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00042730 File Offset: 0x00040930
	private IEnumerator Sequence()
	{
		GameObject[] array = this.coreFlashEffects;
		int j;
		for (j = 0; j < array.Length; j++)
		{
			array[j].SetActive(false);
		}
		BossSequenceDoor.Completion completion = BossSequenceController.IsInSequence ? BossSequenceController.PreviousCompletion : BossSequenceDoor.Completion.None;
		bool boundNail = !BossSequenceController.IsInSequence || BossSequenceController.BoundNail;
		bool boundShell = !BossSequenceController.IsInSequence || BossSequenceController.BoundShell;
		bool boundCharms = !BossSequenceController.IsInSequence || BossSequenceController.BoundCharms;
		bool boundSoul = !BossSequenceController.IsInSequence || BossSequenceController.BoundSoul;
		bool knightDamaged = !BossSequenceController.IsInSequence || BossSequenceController.KnightDamaged;
		if (this.completeCore)
		{
			this.completeCore.SetActive(false);
		}
		if (this.allBindingsCore)
		{
			this.allBindingsCore.SetActive(completion.allBindings);
		}
		if (this.noHitsCore)
		{
			this.noHitsCore.SetActive(completion.noHits && !completion.allBindings);
		}
		if (this.allBindingsNoHitsCore)
		{
			this.allBindingsNoHitsCore.SetActive(completion.noHits && completion.allBindings);
		}
		if (this.timerGroup)
		{
			this.timerGroup.alpha = 0f;
		}
		for (int k = 0; k < 4; k++)
		{
			BossDoorChallengeCompleteUI.BindingIcon bindingIcon = null;
			bool value = false;
			switch (k)
			{
			case 0:
				bindingIcon = this.bindingCapNail;
				value = completion.boundNail;
				break;
			case 1:
				bindingIcon = this.bindingCapShell;
				value = completion.boundShell;
				break;
			case 2:
				bindingIcon = this.bindingCapCharm;
				value = completion.boundCharms;
				break;
			case 3:
				bindingIcon = this.bindingCapSoul;
				value = completion.boundSoul;
				break;
			}
			if (bindingIcon != null)
			{
				bindingIcon.SetAlreadyVisible(value, completion.allBindings);
			}
		}
		yield return new WaitForSeconds(this.musicDelay);
		if (this.musicSource)
		{
			this.musicSource.Play();
		}
		yield return new WaitForSeconds(this.appearAnimDelay - this.musicDelay);
		if (this.animator)
		{
			this.animator.Play("Appear");
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length + this.appearEndWaitTime);
		}
		for (int i = 0; i < 4; i = j + 1)
		{
			BossDoorChallengeCompleteUI.BindingIcon bindingIcon2 = this.GetBindingIcon(i);
			if (bindingIcon2 != null)
			{
				this.StartCoroutine(bindingIcon2.DoAppearAnim(this.bindingCapAppearDelay));
				float num = (float)i * this.bindingAppearPitchIncrease;
				new AudioEvent
				{
					Clip = this.bindingAppearSound.Clip,
					PitchMin = this.bindingAppearSound.PitchMin + num,
					PitchMax = this.bindingAppearSound.PitchMax + num,
					Volume = this.bindingAppearSound.Volume
				}.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
				yield return new WaitForSeconds(this.bindingCapAnimDelay);
			}
			j = i;
		}
		bool allBindings = boundNail && boundShell && boundCharms && boundSoul;
		if (allBindings)
		{
			for (int l = 0; l < 4; l++)
			{
				BossDoorChallengeCompleteUI.BindingIcon bindingIcon3 = this.GetBindingIcon(l);
				if (bindingIcon3 != null)
				{
					this.StartCoroutine(bindingIcon3.DoAllAppearAnim(this.bindingCapAppearDelay));
				}
			}
			this.bindingAllAppearSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		}
		yield return new WaitForSeconds(this.completionCapAppearDelay);
		array = this.coreFlashEffects;
		for (j = 0; j < array.Length; j++)
		{
			array[j].SetActive(true);
		}
		this.coreAppearSound.SpawnAndPlayOneShot(this.audioSourcePrefab, this.transform.position);
		yield return new WaitForSeconds(this.bindingCapAppearDelay);
		if (this.completeCore)
		{
			this.completeCore.SetActive(!allBindings);
		}
		if (this.allBindingsCore && allBindings)
		{
			this.allBindingsCore.SetActive(true);
		}
		if (this.noHitsCore && !knightDamaged && !allBindings)
		{
			this.noHitsCore.SetActive(true);
		}
		if (this.allBindingsNoHitsCore && (!knightDamaged && allBindings))
		{
			this.allBindingsNoHitsCore.SetActive(true);
		}
		if (this.timerText)
		{
			int num2 = Mathf.RoundToInt(BossSequenceController.Timer);
			this.timerText.text = string.Format("{0:00}:{1:00}", num2 / 60, num2 % 60);
			if (this.timerGroup)
			{
				yield return new WaitForSeconds(this.timerFadeDelay);
				for (float elapsed = 0f; elapsed <= this.timerFadeTime; elapsed += Time.deltaTime)
				{
					this.timerGroup.alpha = elapsed / this.timerFadeTime;
					yield return null;
				}
			}
		}
		yield return new WaitForSeconds(this.endAnimDelay);
		this.waitingForInput = true;
		while (this.waitingForInput)
		{
			yield return null;
		}
		if (this.animator)
		{
			this.animator.Play("Disappear");
			yield return null;
			yield return new WaitForSeconds(this.animator.GetCurrentAnimatorStateInfo(0).length);
		}
		HeroController.instance.EnterWithoutInput(true);
		StaticVariableList.SetValue<bool>("finishedBossReturning", true);
		GameCameras.instance.cameraFadeFSM.SendEvent("FADE OUT INSTANT");
		yield return null;
		BossSequenceController.RestoreBindings();
		GameManager.instance.BeginSceneTransition(new GameManager.SceneLoadInfo
		{
			SceneName = (BossSequenceController.ShouldUnlockGGMode ? "GG_Unlock" : GameManager.instance.playerData.GetString("dreamReturnScene")),
			EntryGateName = GameManager.instance.playerData.GetString("bossReturnEntryGate"),
			EntryDelay = 0f,
			Visualization = GameManager.SceneLoadVisualizations.Dream,
			PreventCameraFadeOut = true,
			WaitForSceneTransitionCameraFade = false,
			AlwaysUnloadUnusedAssets = true
		});
		yield break;
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00042740 File Offset: 0x00040940
	private BossDoorChallengeCompleteUI.BindingIcon GetBindingIcon(int index)
	{
		BossDoorChallengeCompleteUI.BindingIcon result = null;
		switch (index)
		{
		case 0:
			if (BossSequenceController.BoundNail || !BossSequenceController.IsInSequence)
			{
				result = this.bindingCapNail;
			}
			break;
		case 1:
			if (BossSequenceController.BoundShell || !BossSequenceController.IsInSequence)
			{
				result = this.bindingCapShell;
			}
			break;
		case 2:
			if (BossSequenceController.BoundCharms || !BossSequenceController.IsInSequence)
			{
				result = this.bindingCapCharm;
			}
			break;
		case 3:
			if (BossSequenceController.BoundSoul || !BossSequenceController.IsInSequence)
			{
				result = this.bindingCapSoul;
			}
			break;
		}
		return result;
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x000427C4 File Offset: 0x000409C4
	public BossDoorChallengeCompleteUI()
	{
		this.achievementShowDelay = 0.5f;
		this.appearAnimDelay = 2f;
		this.appearEndWaitTime = 1f;
		this.bindingCapAnimDelay = 0.5f;
		this.bindingCapAppearDelay = 0.2f;
		this.completionCapAppearDelay = 0.75f;
		this.endAnimDelay = 2f;
		this.musicDelay = 1f;
		this.bindingAppearPitchIncrease = 0.05f;
		this.timerFadeDelay = 1f;
		this.timerFadeTime = 2f;
		base..ctor();
	}

	// Token: 0x04000E2B RID: 3627
	public float achievementShowDelay;

	// Token: 0x04000E2C RID: 3628
	public Animator animator;

	// Token: 0x04000E2D RID: 3629
	public float appearAnimDelay;

	// Token: 0x04000E2E RID: 3630
	public float appearEndWaitTime;

	// Token: 0x04000E2F RID: 3631
	public float bindingCapAnimDelay;

	// Token: 0x04000E30 RID: 3632
	public float bindingCapAppearDelay;

	// Token: 0x04000E31 RID: 3633
	public float completionCapAppearDelay;

	// Token: 0x04000E32 RID: 3634
	public float endAnimDelay;

	// Token: 0x04000E33 RID: 3635
	public AudioSource musicSource;

	// Token: 0x04000E34 RID: 3636
	public float musicDelay;

	// Token: 0x04000E35 RID: 3637
	[Space]
	public BossDoorChallengeCompleteUI.BindingIcon bindingCapNail;

	// Token: 0x04000E36 RID: 3638
	public BossDoorChallengeCompleteUI.BindingIcon bindingCapShell;

	// Token: 0x04000E37 RID: 3639
	public BossDoorChallengeCompleteUI.BindingIcon bindingCapCharm;

	// Token: 0x04000E38 RID: 3640
	public BossDoorChallengeCompleteUI.BindingIcon bindingCapSoul;

	// Token: 0x04000E39 RID: 3641
	public AudioSource audioSourcePrefab;

	// Token: 0x04000E3A RID: 3642
	public AudioEvent screenAppearSound;

	// Token: 0x04000E3B RID: 3643
	public AudioEvent bindingAppearSound;

	// Token: 0x04000E3C RID: 3644
	public float bindingAppearPitchIncrease;

	// Token: 0x04000E3D RID: 3645
	public AudioEvent bindingAllAppearSound;

	// Token: 0x04000E3E RID: 3646
	public AudioEvent coreAppearSound;

	// Token: 0x04000E3F RID: 3647
	[Space]
	public GameObject[] coreFlashEffects;

	// Token: 0x04000E40 RID: 3648
	public GameObject completeCore;

	// Token: 0x04000E41 RID: 3649
	public GameObject allBindingsCore;

	// Token: 0x04000E42 RID: 3650
	public GameObject noHitsCore;

	// Token: 0x04000E43 RID: 3651
	public GameObject allBindingsNoHitsCore;

	// Token: 0x04000E44 RID: 3652
	[Space]
	public CanvasGroup timerGroup;

	// Token: 0x04000E45 RID: 3653
	public float timerFadeDelay;

	// Token: 0x04000E46 RID: 3654
	public float timerFadeTime;

	// Token: 0x04000E47 RID: 3655
	public Text timerText;

	// Token: 0x04000E48 RID: 3656
	private bool waitingForInput;

	// Token: 0x0200027E RID: 638
	[Serializable]
	public class BindingIcon
	{
		// Token: 0x06000D57 RID: 3415 RVA: 0x00042850 File Offset: 0x00040A50
		public void SetAlreadyVisible(bool value, bool allUnlocked)
		{
			GameObject[] array = this.flashEffects;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(false);
			}
			if (this.icon)
			{
				this.icon.enabled = value;
			}
			this.alreadyVisible = value;
			if (allUnlocked)
			{
				this.SetAllUnlocked();
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000428A4 File Offset: 0x00040AA4
		public IEnumerator DoAppearAnim(float appearDelay)
		{
			if (!this.alreadyVisible && this.icon)
			{
				this.icon.enabled = false;
			}
			GameObject[] array = this.flashEffects;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].SetActive(true);
			}
			yield return new WaitForSeconds(appearDelay);
			if (this.icon)
			{
				this.icon.enabled = true;
			}
			yield break;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000428BA File Offset: 0x00040ABA
		public IEnumerator DoAllAppearAnim(float appearDelay)
		{
			foreach (GameObject gameObject in this.flashEffects)
			{
				gameObject.SetActive(false);
				gameObject.SetActive(true);
			}
			yield return new WaitForSeconds(appearDelay);
			this.SetAllUnlocked();
			yield break;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x000428D0 File Offset: 0x00040AD0
		private void SetAllUnlocked()
		{
			if (this.icon && this.allUnlockedSprite)
			{
				this.icon.sprite = this.allUnlockedSprite;
			}
		}

		// Token: 0x04000E49 RID: 3657
		public Image icon;

		// Token: 0x04000E4A RID: 3658
		public Sprite allUnlockedSprite;

		// Token: 0x04000E4B RID: 3659
		public GameObject[] flashEffects;

		// Token: 0x04000E4C RID: 3660
		private bool alreadyVisible;
	}
}
