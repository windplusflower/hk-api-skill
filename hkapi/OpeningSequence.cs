using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200007E RID: 126
public class OpeningSequence : MonoBehaviour
{
	// Token: 0x060002B0 RID: 688 RVA: 0x0000F14E File Offset: 0x0000D34E
	protected void OnEnable()
	{
		this.chainSequence.TransitionedToNextSequence += this.OnChangingSequences;
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000F167 File Offset: 0x0000D367
	protected void OnDisable()
	{
		this.chainSequence.TransitionedToNextSequence -= this.OnChangingSequences;
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0000F180 File Offset: 0x0000D380
	protected IEnumerator Start()
	{
		this.isAsync = Platform.Current.FetchScenesBeforeFade;
		if (this.isAsync)
		{
			return this.StartAsync();
		}
		return this.StartSync();
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0000F1A7 File Offset: 0x0000D3A7
	protected IEnumerator StartAsync()
	{
		GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
		GameCameras.instance.DisableImageEffects();
		PlayMakerFSM.BroadcastEvent("START FADE OUT");
		Debug.LogFormat(this, "Starting opening sequence.", Array.Empty<object>());
		GameManager.instance.ui.SetState(UIState.CUTSCENE);
		GameManager.instance.inputHandler.SetSkipMode(SkipPromptMode.NOT_SKIPPABLE_DUE_TO_LOADING);
		this.chainSequence.Begin();
		ThreadPriority lastLoadPriority = Application.backgroundLoadingPriority;
		Application.backgroundLoadingPriority = this.streamingLoadPriority;
		this.asyncKnightLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Knight_Pickup", LoadSceneMode.Additive);
		this.asyncKnightLoad.allowSceneActivation = false;
		this.asyncWorldLoad = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Tutorial_01", LoadSceneMode.Single);
		this.asyncWorldLoad.allowSceneActivation = false;
		this.isLevelReady = false;
		while (this.chainSequence.IsPlaying)
		{
			if (!this.isLevelReady)
			{
				this.isLevelReady = (OpeningSequence.IsLevelReady(this.asyncKnightLoad) && OpeningSequence.IsLevelReady(this.asyncWorldLoad));
				if (this.isLevelReady)
				{
					Debug.LogFormat(this, "Levels are ready before cinematics are finished. Cinematics made skippable.", Array.Empty<object>());
				}
			}
			SkipPromptMode skipPromptMode;
			if (this.chainSequence.IsCurrentSkipped || this.skipChargeTimer < this.skipChargeDuration)
			{
				skipPromptMode = SkipPromptMode.NOT_SKIPPABLE;
			}
			else if (!this.isLevelReady)
			{
				skipPromptMode = SkipPromptMode.NOT_SKIPPABLE_DUE_TO_LOADING;
			}
			else
			{
				skipPromptMode = SkipPromptMode.SKIP_PROMPT;
			}
			if (GameManager.instance.inputHandler.skipMode != skipPromptMode)
			{
				GameManager.instance.inputHandler.SetSkipMode(skipPromptMode);
			}
			yield return null;
		}
		if (!this.isLevelReady)
		{
			Debug.LogFormat(this, "Cinematics are finished before levels are ready. Blocking.", Array.Empty<object>());
		}
		Application.backgroundLoadingPriority = this.completedLoadPriority;
		GameManager.instance.inputHandler.SetSkipMode(SkipPromptMode.NOT_SKIPPABLE);
		yield return new WaitForSeconds(1.2f);
		this.asyncKnightLoad.allowSceneActivation = true;
		yield return this.asyncKnightLoad;
		this.asyncKnightLoad = null;
		GameManager.instance.OnWillActivateFirstLevel();
		this.asyncWorldLoad.allowSceneActivation = true;
		GameManager.instance.nextSceneName = "Tutorial_01";
		yield return this.asyncWorldLoad;
		this.asyncWorldLoad = null;
		Application.backgroundLoadingPriority = lastLoadPriority;
		UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(this.gameObject.scene);
		GameManager.instance.SetupSceneRefs(true);
		GameManager.instance.BeginScene();
		GameManager.instance.OnNextLevelReady();
		GameCameras.instance.EnableImageEffects(true, false);
		yield break;
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000F1B6 File Offset: 0x0000D3B6
	protected IEnumerator StartSync()
	{
		GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
		GameCameras.instance.DisableImageEffects();
		PlayMakerFSM.BroadcastEvent("START FADE OUT");
		Debug.LogFormat(this, "Starting opening sequence.", Array.Empty<object>());
		GameManager.instance.ui.SetState(UIState.CUTSCENE);
		this.chainSequence.Begin();
		while (this.chainSequence.IsPlaying)
		{
			SkipPromptMode skipPromptMode;
			if (this.chainSequence.IsCurrentSkipped || this.skipChargeTimer < this.skipChargeDuration)
			{
				skipPromptMode = SkipPromptMode.NOT_SKIPPABLE;
			}
			else
			{
				skipPromptMode = SkipPromptMode.SKIP_PROMPT;
			}
			if (GameManager.instance.inputHandler.skipMode != skipPromptMode)
			{
				GameManager.instance.inputHandler.SetSkipMode(skipPromptMode);
			}
			yield return null;
		}
		GameManager.instance.inputHandler.SetSkipMode(SkipPromptMode.NOT_SKIPPABLE);
		AsyncOperation asyncOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Knight_Pickup", LoadSceneMode.Additive);
		asyncOperation.allowSceneActivation = true;
		yield return asyncOperation;
		GameManager.instance.OnWillActivateFirstLevel();
		GameManager.instance.nextSceneName = "Tutorial_01";
		AsyncOperation asyncOperation2 = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Tutorial_01", LoadSceneMode.Single);
		asyncOperation2.allowSceneActivation = true;
		yield return asyncOperation2;
		UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(this.gameObject.scene);
		GameManager.instance.SetupSceneRefs(true);
		GameManager.instance.BeginScene();
		GameManager.instance.OnNextLevelReady();
		GameCameras.instance.EnableImageEffects(true, false);
		yield break;
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000F1C5 File Offset: 0x0000D3C5
	protected void Update()
	{
		this.skipChargeTimer += Time.unscaledDeltaTime;
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000F1D9 File Offset: 0x0000D3D9
	private static bool IsLevelReady(AsyncOperation operation)
	{
		return operation.progress >= 0.9f;
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x0000F1EB File Offset: 0x0000D3EB
	public IEnumerator Skip()
	{
		Debug.LogFormat("Opening sequience skipping.", Array.Empty<object>());
		this.chainSequence.SkipSingle();
		while (this.chainSequence.IsCurrentSkipped)
		{
			this.skipChargeTimer = 0f;
			yield return null;
		}
		yield break;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0000F1FC File Offset: 0x0000D3FC
	private void OnChangingSequences()
	{
		Debug.LogFormat("Opening sequience changing sequences.", Array.Empty<object>());
		this.skipChargeTimer = 0f;
		if (this.isAsync && this.asyncKnightLoad != null && !this.asyncKnightLoad.allowSceneActivation)
		{
			this.asyncKnightLoad.allowSceneActivation = true;
		}
	}

	// Token: 0x0400023D RID: 573
	[SerializeField]
	private ChainSequence chainSequence;

	// Token: 0x0400023E RID: 574
	[SerializeField]
	private ThreadPriority streamingLoadPriority;

	// Token: 0x0400023F RID: 575
	[SerializeField]
	private ThreadPriority completedLoadPriority;

	// Token: 0x04000240 RID: 576
	[SerializeField]
	private float skipChargeDuration;

	// Token: 0x04000241 RID: 577
	private bool isAsync;

	// Token: 0x04000242 RID: 578
	private bool isLevelReady;

	// Token: 0x04000243 RID: 579
	private AsyncOperation asyncKnightLoad;

	// Token: 0x04000244 RID: 580
	private AsyncOperation asyncWorldLoad;

	// Token: 0x04000245 RID: 581
	private float skipChargeTimer;
}
