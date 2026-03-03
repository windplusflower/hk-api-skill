using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000071 RID: 113
public class CutsceneHelper : MonoBehaviour
{
	// Token: 0x06000257 RID: 599 RVA: 0x0000D97B File Offset: 0x0000BB7B
	private IEnumerator Start()
	{
		this.gm = GameManager.instance;
		if (this.resetOnStart)
		{
			this.gm.inputHandler.skippingCutscene = false;
		}
		if (this.startSkipLocked)
		{
			this.gm.inputHandler.SetSkipMode(SkipPromptMode.NOT_SKIPPABLE);
		}
		else
		{
			this.gm.inputHandler.SetSkipMode(this.skipMode);
		}
		GameCameras.instance.DisableHUDCamIfAllowed();
		yield return new WaitForSeconds(this.waitBeforeFadeIn);
		if (this.fadeInSpeed == CameraFadeInType.SLOW)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN SLOWLY");
		}
		else if (this.fadeInSpeed == CameraFadeInType.NORMAL)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
		}
		else if (this.fadeInSpeed == CameraFadeInType.INSTANT)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN INSTANT");
		}
		yield break;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x0000D98A File Offset: 0x0000BB8A
	public void LoadNextScene()
	{
		GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE INSTANT");
		this.DoSceneLoad();
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000D9AB File Offset: 0x0000BBAB
	public IEnumerator SkipCutscene()
	{
		PlayMakerFSM.BroadcastEvent("JUST FADE");
		yield return new WaitForSeconds(0.5f);
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		this.DoSceneLoad();
		yield break;
	}

	// Token: 0x0600025A RID: 602 RVA: 0x0000D9BA File Offset: 0x0000BBBA
	public void UnlockSkip()
	{
		this.gm.inputHandler.SetSkipMode(this.skipMode);
	}

	// Token: 0x0600025B RID: 603 RVA: 0x0000D9D4 File Offset: 0x0000BBD4
	private void DoSceneLoad()
	{
		switch (this.nextSceneType)
		{
		case CutsceneHelper.NextScene.SpecifyScene:
			GameManager.instance.LoadScene(this.nextScene);
			return;
		case CutsceneHelper.NextScene.MainMenu:
			GameManager.instance.StartCoroutine(GameManager.instance.ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes.SaveAndContinueOnFail, null));
			return;
		case CutsceneHelper.NextScene.PermaDeathUnlock:
			GameManager.instance.LoadPermadeathUnlockScene();
			return;
		case CutsceneHelper.NextScene.GameCompletionScreen:
			GameManager.instance.LoadScene("End_Game_Completion");
			return;
		case CutsceneHelper.NextScene.EndCredits:
			GameManager.instance.LoadScene("End_Credits");
			return;
		case CutsceneHelper.NextScene.MrMushroomUnlock:
			GameManager.instance.LoadMrMushromScene();
			return;
		case CutsceneHelper.NextScene.GGReturn:
			GameManager.instance.BeginSceneTransition(new GameManager.SceneLoadInfo
			{
				SceneName = this.nextScene,
				EntryGateName = GameManager.instance.playerData.GetString("bossReturnEntryGate"),
				EntryDelay = 0f,
				Visualization = GameManager.SceneLoadVisualizations.Dream,
				PreventCameraFadeOut = true,
				WaitForSceneTransitionCameraFade = false
			});
			return;
		case CutsceneHelper.NextScene.MainMenuNoSave:
			GameManager.instance.StartCoroutine(GameManager.instance.ReturnToMainMenu(GameManager.ReturnToMainMenuSaveModes.DontSave, null));
			return;
		default:
			return;
		}
	}

	// Token: 0x040001EE RID: 494
	public float waitBeforeFadeIn;

	// Token: 0x040001EF RID: 495
	public CameraFadeInType fadeInSpeed;

	// Token: 0x040001F0 RID: 496
	public SkipPromptMode skipMode;

	// Token: 0x040001F1 RID: 497
	[Tooltip("Prevents the skip action from taking place until the lock is released. Useful for animators delaying skip feature.")]
	public bool startSkipLocked;

	// Token: 0x040001F2 RID: 498
	[Tooltip("Reset any flags that may have been previously set.")]
	public bool resetOnStart;

	// Token: 0x040001F3 RID: 499
	public CutsceneHelper.NextScene nextSceneType;

	// Token: 0x040001F4 RID: 500
	public string nextScene;

	// Token: 0x040001F5 RID: 501
	private GameManager gm;

	// Token: 0x02000072 RID: 114
	public enum NextScene
	{
		// Token: 0x040001F7 RID: 503
		SpecifyScene,
		// Token: 0x040001F8 RID: 504
		MainMenu,
		// Token: 0x040001F9 RID: 505
		PermaDeathUnlock,
		// Token: 0x040001FA RID: 506
		GameCompletionScreen,
		// Token: 0x040001FB RID: 507
		EndCredits,
		// Token: 0x040001FC RID: 508
		MrMushroomUnlock,
		// Token: 0x040001FD RID: 509
		GGReturn,
		// Token: 0x040001FE RID: 510
		MainMenuNoSave
	}
}
