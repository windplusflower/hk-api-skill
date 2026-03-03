using System;
using System.Collections;
using InControl;
using Language;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Token: 0x0200031A RID: 794
public class StartManager : MonoBehaviour
{
	// Token: 0x06001175 RID: 4469 RVA: 0x00051FF1 File Offset: 0x000501F1
	private void Awake()
	{
		this.platform = Application.platform;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00051FFE File Offset: 0x000501FE
	private IEnumerator Start()
	{
		StartManager.<Start>d__6 <Start>d__ = new StartManager.<Start>d__6(0);
		<Start>d__.<>4__this = this;
		return <Start>d__;
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x0005200D File Offset: 0x0005020D
	private Sprite GetControllerSpriteForPlatform(RuntimePlatform runtimePlatform)
	{
		if (runtimePlatform <= RuntimePlatform.WindowsPlayer)
		{
			if (runtimePlatform <= RuntimePlatform.OSXPlayer)
			{
				return this.osxController;
			}
			if (runtimePlatform != RuntimePlatform.WindowsPlayer)
			{
				goto IL_2A;
			}
		}
		else if (runtimePlatform != RuntimePlatform.WindowsEditor && runtimePlatform != RuntimePlatform.LinuxPlayer && runtimePlatform != RuntimePlatform.LinuxEditor)
		{
			goto IL_2A;
		}
		return this.winController;
		IL_2A:
		return null;
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x0005203A File Offset: 0x0005023A
	public void SwitchToMenuScene()
	{
		if (this.verboseMode)
		{
			Debug.Log("Switching Scenes");
		}
		this.loadop.allowSceneActivation = true;
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x0005205C File Offset: 0x0005025C
	public void SetLanguage(string newLanguage)
	{
		this.oldLanguage = Language.CurrentLanguage().ToString();
		this.selectedLanguage = newLanguage;
		Language.SwitchLanguage(this.selectedLanguage);
		this.languageConfirm.gameObject.SetActive(true);
		base.StartCoroutine(this.FadeIn(this.languageConfirm, 0.25f));
		AutoLocalizeTextUI[] componentsInChildren = this.languageConfirm.GetComponentsInChildren<AutoLocalizeTextUI>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].RefreshTextFromLocalization();
		}
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x000520E0 File Offset: 0x000502E0
	private IEnumerator FadeIn(CanvasGroup group, float duration)
	{
		group.alpha = 0f;
		for (float elapsed = 0f; elapsed < duration; elapsed += Time.deltaTime)
		{
			group.alpha = elapsed / duration;
			yield return new WaitForEndOfFrame();
		}
		group.alpha = 1f;
		PreselectOption component = group.GetComponent<PreselectOption>();
		if (component)
		{
			component.HighlightDefault(true);
		}
		yield break;
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x000520F6 File Offset: 0x000502F6
	private IEnumerator FadeOut(CanvasGroup group, float duration)
	{
		group.alpha = 1f;
		for (float elapsed = 0f; elapsed < duration; elapsed += Time.deltaTime)
		{
			group.alpha = 1f - elapsed / duration;
			yield return new WaitForEndOfFrame();
		}
		group.alpha = 0f;
		group.gameObject.SetActive(false);
		yield break;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x0005210C File Offset: 0x0005030C
	public bool CheckIsLanguageSet()
	{
		return Platform.Current.IsPlayerPrefsLoaded && Platform.Current.SharedData.GetBool("GameLangSet", false);
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00052134 File Offset: 0x00050334
	public void ConfirmLanguage()
	{
		Platform.Current.SharedData.SetInt("GameLangSet", 1);
		Platform.Current.SharedData.Save();
		this.controllerNoticeText.UpdateText();
		base.StartCoroutine(this.FadeOut(this.languageConfirm, 0.25f));
		this.confirmedLanguage = true;
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x0005218F File Offset: 0x0005038F
	public void CancelLanguage()
	{
		Language.SwitchLanguage(this.oldLanguage);
		base.StartCoroutine(this.FadeOut(this.languageConfirm, 0.25f));
		if (this.preselector)
		{
			this.preselector.HighlightDefault(true);
		}
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x000521CE File Offset: 0x000503CE
	private IEnumerator ShowLanguageSelect()
	{
		this.languageSelect.alpha = 0f;
		this.languageSelect.gameObject.SetActive(true);
		while ((double)this.languageSelect.alpha < 0.99)
		{
			this.languageSelect.alpha += Time.smoothDeltaTime * this.fadeSpeed;
			if ((double)this.languageSelect.alpha > 0.99)
			{
				this.languageSelect.alpha = 1f;
			}
			yield return null;
		}
		Cursor.lockState = CursorLockMode.None;
		this.preselector.HighlightDefault(false);
		yield return null;
		yield break;
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x000521DD File Offset: 0x000503DD
	private IEnumerator LanguageSettingDone()
	{
		Cursor.lockState = CursorLockMode.Locked;
		while ((double)this.languageSelect.alpha > 0.01)
		{
			this.languageSelect.alpha -= Time.smoothDeltaTime * this.fadeSpeed;
			if ((double)this.languageSelect.alpha < 0.01)
			{
				this.languageSelect.alpha = 0f;
			}
			yield return null;
		}
		this.languageSelect.gameObject.SetActive(false);
		ConfigManager.SaveConfig();
		yield break;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x000521EC File Offset: 0x000503EC
	public StartManager()
	{
		this.logoTrigger = "fadeLogo";
		this.controllerTrigger = "controllerNotice";
		this.loadingIconTrigger = "loading";
		this.fadeSpeed = 1.6f;
		base..ctor();
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00052220 File Offset: 0x00050420
	private IEnumerator orig_Start()
	{
		this.controllerImage.sprite = this.GetControllerSpriteForPlatform(this.platform);
		AsyncOperation loadOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Menu_Title");
		loadOperation.allowSceneActivation = false;
		if (!this.CheckIsLanguageSet() && Platform.Current.ShowLanguageSelect)
		{
			yield return this.StartCoroutine(this.ShowLanguageSelect());
			while (!this.confirmedLanguage)
			{
				yield return null;
			}
			yield return this.StartCoroutine(this.LanguageSettingDone());
		}
		this.startManagerAnimator.SetBool("WillShowControllerNotice", false);
		this.startManagerAnimator.SetBool("WillShowQuote", true);
		this.startManagerAnimator.SetTrigger("Start");
		int loadingIconNameHash = Animator.StringToHash("LoadingIcon");
		while (this.startManagerAnimator.GetCurrentAnimatorStateInfo(0).shortNameHash != loadingIconNameHash)
		{
			yield return null;
		}
		UnityEngine.Object.Instantiate<StandaloneLoadingSpinner>(this.loadSpinnerPrefab).Setup(null);
		bool didWaitForPlayerPrefs = false;
		while (!Platform.Current.IsPlayerPrefsLoaded)
		{
			if (!didWaitForPlayerPrefs)
			{
				didWaitForPlayerPrefs = true;
				Debug.LogFormat("Waiting for PlayerPrefs load...", Array.Empty<object>());
			}
			yield return null;
		}
		if (!didWaitForPlayerPrefs)
		{
			Debug.LogFormat("Didn't need to wait for PlayerPrefs load.", Array.Empty<object>());
		}
		else
		{
			Debug.LogFormat("Finished waiting for PlayerPrefs load.", Array.Empty<object>());
		}
		loadOperation.allowSceneActivation = true;
		yield return loadOperation;
		yield break;
	}

	// Token: 0x04001133 RID: 4403
	private bool verboseMode;

	// Token: 0x04001134 RID: 4404
	public Animator startManagerAnimator;

	// Token: 0x04001135 RID: 4405
	public Slider progressIndicator;

	// Token: 0x04001136 RID: 4406
	[SerializeField]
	private StandaloneLoadingSpinner loadSpinnerPrefab;

	// Token: 0x04001137 RID: 4407
	[Header("Controller Notice")]
	public SpriteRenderer controllerImage;

	// Token: 0x04001138 RID: 4408
	[Space(5f)]
	public Sprite winController;

	// Token: 0x04001139 RID: 4409
	public Sprite osxController;

	// Token: 0x0400113A RID: 4410
	public SetTextMeshProGameText controllerNoticeText;

	// Token: 0x0400113B RID: 4411
	[Header("Language Select")]
	public CanvasGroup languageSelect;

	// Token: 0x0400113C RID: 4412
	public Animator languageAnimator;

	// Token: 0x0400113D RID: 4413
	public PreselectOption preselector;

	// Token: 0x0400113E RID: 4414
	public CanvasGroup languageConfirm;

	// Token: 0x0400113F RID: 4415
	private string selectedLanguage;

	// Token: 0x04001140 RID: 4416
	private string oldLanguage;

	// Token: 0x04001141 RID: 4417
	[Header("Input")]
	public InControlInputModule inputModule;

	// Token: 0x04001142 RID: 4418
	[Header("Audio")]
	public MenuAudioController uiAudioPlayer;

	// Token: 0x04001143 RID: 4419
	[Header("Debug")]
	public bool showProgessIndicator;

	// Token: 0x04001144 RID: 4420
	private AsyncOperation loadop;

	// Token: 0x04001145 RID: 4421
	private RuntimePlatform platform;

	// Token: 0x04001146 RID: 4422
	private string logoTrigger;

	// Token: 0x04001147 RID: 4423
	private string controllerTrigger;

	// Token: 0x04001148 RID: 4424
	private string loadingIconTrigger;

	// Token: 0x04001149 RID: 4425
	private float fadeSpeed;

	// Token: 0x0400114A RID: 4426
	private bool confirmedLanguage;
}
