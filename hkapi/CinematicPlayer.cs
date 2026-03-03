using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x0200005E RID: 94
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(MeshRenderer))]
public class CinematicPlayer : MonoBehaviour
{
	// Token: 0x060001FD RID: 509 RVA: 0x0000C68A File Offset: 0x0000A88A
	private void Awake()
	{
		this.audioSource = base.GetComponent<AudioSource>();
		this.myRenderer = base.GetComponent<MeshRenderer>();
		if (this.videoType == CinematicPlayer.VideoType.InGameVideo)
		{
			this.myRenderer.enabled = false;
		}
	}

	// Token: 0x060001FE RID: 510 RVA: 0x0000C6B9 File Offset: 0x0000A8B9
	protected void OnDestroy()
	{
		if (this.cinematicVideoPlayer != null)
		{
			this.cinematicVideoPlayer.Dispose();
			this.cinematicVideoPlayer = null;
		}
	}

	// Token: 0x060001FF RID: 511 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
	private void Start()
	{
		this.gm = GameManager.instance;
		this.ui = UIManager.instance;
		this.pd = PlayerData.instance;
		if (this.startSkipLocked)
		{
			this.gm.inputHandler.SetSkipMode(SkipPromptMode.NOT_SKIPPABLE);
		}
		else
		{
			this.gm.inputHandler.SetSkipMode(this.skipMode);
		}
		if (this.playTrigger == CinematicPlayer.MovieTrigger.ON_START)
		{
			base.StartCoroutine(this.StartVideo());
		}
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000C74C File Offset: 0x0000A94C
	private void Update()
	{
		if (this.cinematicVideoPlayer != null)
		{
			this.cinematicVideoPlayer.Update();
		}
		if (Time.frameCount % 10 == 0)
		{
			this.Update10();
		}
	}

	// Token: 0x06000201 RID: 513 RVA: 0x0000C774 File Offset: 0x0000A974
	private void Update10()
	{
		if ((this.cinematicVideoPlayer == null || (!this.cinematicVideoPlayer.IsLoading && !this.cinematicVideoPlayer.IsPlaying)) && !this.loadingLevel && this.videoTriggered)
		{
			if (this.videoType == CinematicPlayer.VideoType.InGameVideo)
			{
				this.FinishInGameVideo();
				return;
			}
			this.FinishVideo();
		}
	}

	// Token: 0x06000202 RID: 514 RVA: 0x0000C7C9 File Offset: 0x0000A9C9
	public IEnumerator SkipVideo()
	{
		if (this.videoTriggered)
		{
			if (this.videoType == CinematicPlayer.VideoType.InGameVideo)
			{
				if (this.fadeOutSpeed != CinematicPlayer.FadeOutSpeed.NONE)
				{
					float duration = 0f;
					if (this.fadeOutSpeed == CinematicPlayer.FadeOutSpeed.NORMAL)
					{
						duration = 0.5f;
					}
					else if (this.fadeOutSpeed == CinematicPlayer.FadeOutSpeed.SLOW)
					{
						duration = 2.3f;
					}
					this.selfBlanker.enabled = true;
					float timer = 0f;
					while (this.videoTriggered)
					{
						if (timer >= duration)
						{
							break;
						}
						float a = Mathf.Clamp01(timer / duration);
						this.selfBlanker.material.color = new Color(0f, 0f, 0f, a);
						yield return null;
						timer += Time.unscaledDeltaTime;
					}
				}
				else
				{
					yield return null;
				}
			}
			else if (this.fadeOutSpeed == CinematicPlayer.FadeOutSpeed.NORMAL)
			{
				PlayMakerFSM.BroadcastEvent("JUST FADE");
				yield return new WaitForSeconds(0.5f);
			}
			else if (this.fadeOutSpeed == CinematicPlayer.FadeOutSpeed.SLOW)
			{
				PlayMakerFSM.BroadcastEvent("START FADE");
				yield return new WaitForSeconds(2.3f);
			}
			else
			{
				yield return null;
			}
			if (this.cinematicVideoPlayer != null)
			{
				this.cinematicVideoPlayer.Stop();
			}
		}
		yield break;
	}

	// Token: 0x06000203 RID: 515 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
	public void TriggerStartVideo()
	{
		base.StartCoroutine(this.StartVideo());
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000C7E7 File Offset: 0x0000A9E7
	public void TriggerStopVideo()
	{
		if (this.videoType == CinematicPlayer.VideoType.InGameVideo)
		{
			base.StartCoroutine(this.SkipVideo());
		}
	}

	// Token: 0x06000205 RID: 517 RVA: 0x0000C7FF File Offset: 0x0000A9FF
	public void UnlockSkip()
	{
		this.gm.inputHandler.SetSkipMode(this.skipMode);
	}

	// Token: 0x06000206 RID: 518 RVA: 0x0000C817 File Offset: 0x0000AA17
	private IEnumerator StartVideo()
	{
		if (this.masterOff != null)
		{
			this.masterOff.TransitionTo(0f);
		}
		this.videoTriggered = true;
		if (this.videoType == CinematicPlayer.VideoType.InGameVideo)
		{
			this.gm.gameState = GameState.CUTSCENE;
			if (this.cinematicVideoPlayer == null)
			{
				Debug.LogFormat("Creating new CinematicVideoPlayer for in game video", Array.Empty<object>());
				this.cinematicVideoPlayer = CinematicVideoPlayer.Create(new CinematicVideoPlayerConfig(this.videoClip, this.myRenderer, this.audioSource, this.faderStyle, GameManager.instance.GetImplicitCinematicVolume()));
			}
			Debug.LogFormat("Waiting for CinematicVideoPlayer in game video load...", Array.Empty<object>());
			while (this.cinematicVideoPlayer != null && this.cinematicVideoPlayer.IsLoading)
			{
				yield return null;
			}
			Debug.LogFormat("Starting cinematic video player in game video.", Array.Empty<object>());
			if (this.cinematicVideoPlayer != null)
			{
				this.cinematicVideoPlayer.IsLooping = this.loopVideo;
				this.cinematicVideoPlayer.Play();
				this.myRenderer.enabled = true;
			}
			if (this.additionalAudio != null)
			{
				this.additionalAudio.Play();
			}
			yield return new WaitForSeconds(this.delayBeforeFadeIn);
			if (this.fadeInSpeed == CinematicPlayer.FadeInSpeed.SLOW)
			{
				GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN SLOWLY");
			}
			else if (this.fadeInSpeed == CinematicPlayer.FadeInSpeed.NORMAL)
			{
				GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
			}
		}
		else if (this.videoType == CinematicPlayer.VideoType.StagTravel)
		{
			GameCameras.instance.DisableImageEffects();
			if (this.cinematicVideoPlayer == null)
			{
				this.cinematicVideoPlayer = CinematicVideoPlayer.Create(new CinematicVideoPlayerConfig(this.videoClip, this.myRenderer, this.audioSource, this.faderStyle, GameManager.instance.GetImplicitCinematicVolume()));
			}
			while (this.cinematicVideoPlayer != null && this.cinematicVideoPlayer.IsLoading)
			{
				yield return null;
			}
			if (this.cinematicVideoPlayer != null)
			{
				this.cinematicVideoPlayer.IsLooping = this.loopVideo;
				this.cinematicVideoPlayer.Play();
				this.myRenderer.enabled = true;
			}
			yield return new WaitForSeconds(this.delayBeforeFadeIn);
			if (this.fadeInSpeed == CinematicPlayer.FadeInSpeed.SLOW)
			{
				GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN SLOWLY");
			}
			else if (this.fadeInSpeed == CinematicPlayer.FadeInSpeed.NORMAL)
			{
				GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
			}
			this.StartCoroutine(this.WaitForStagFadeOut());
			this.pd.SetBoolSwappedArgs(true, "disablePause");
		}
		else
		{
			GameCameras.instance.DisableImageEffects();
			if (this.cinematicVideoPlayer == null)
			{
				this.cinematicVideoPlayer = CinematicVideoPlayer.Create(new CinematicVideoPlayerConfig(this.videoClip, this.myRenderer, this.audioSource, this.faderStyle, GameManager.instance.GetImplicitCinematicVolume()));
			}
			while (this.cinematicVideoPlayer != null && this.cinematicVideoPlayer.IsLoading)
			{
				yield return null;
			}
			if (this.cinematicVideoPlayer != null)
			{
				this.cinematicVideoPlayer.IsLooping = this.loopVideo;
				this.cinematicVideoPlayer.Play();
				this.myRenderer.enabled = true;
			}
			yield return new WaitForSeconds(this.delayBeforeFadeIn);
			if (this.fadeInSpeed == CinematicPlayer.FadeInSpeed.SLOW)
			{
				GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN SLOWLY");
			}
			else if (this.fadeInSpeed == CinematicPlayer.FadeInSpeed.NORMAL)
			{
				GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
			}
		}
		yield break;
	}

	// Token: 0x06000207 RID: 519 RVA: 0x0000C828 File Offset: 0x0000AA28
	private void FinishVideo()
	{
		GameCameras.instance.EnableImageEffects(this.gm.IsGameplayScene(), false);
		this.videoTriggered = false;
		if (this.videoType == CinematicPlayer.VideoType.OpeningCutscene)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("JUST FADE");
			this.ui.SetState(UIState.INACTIVE);
			this.loadingLevel = true;
			base.StartCoroutine(this.gm.LoadFirstScene());
			return;
		}
		if (this.videoType == CinematicPlayer.VideoType.OpeningPrologue)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("JUST FADE");
			this.ui.SetState(UIState.INACTIVE);
			this.loadingLevel = true;
			this.gm.LoadOpeningCinematic();
			return;
		}
		if (this.videoType == CinematicPlayer.VideoType.EndingA || this.videoType == CinematicPlayer.VideoType.EndingB || this.videoType == CinematicPlayer.VideoType.EndingC)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("JUST FADE");
			this.ui.SetState(UIState.INACTIVE);
			this.loadingLevel = true;
			this.gm.LoadScene("End_Credits");
			return;
		}
		if (this.videoType == CinematicPlayer.VideoType.StagTravel)
		{
			this.ui.SetState(UIState.INACTIVE);
			this.loadingLevel = true;
			this.gm.ChangeToScene(this.pd.GetString("nextScene"), "door_stagExit", 0f);
			return;
		}
		if (this.videoType == CinematicPlayer.VideoType.EndingGG)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("JUST FADE");
			this.ui.SetState(UIState.INACTIVE);
			this.loadingLevel = true;
			if (this.gm.playerData.GetBool("bossRushMode"))
			{
				this.gm.LoadScene("GG_End_Sequence");
				return;
			}
			this.gm.LoadScene("End_Credits");
		}
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
	private void FinishInGameVideo()
	{
		Debug.LogFormat("Finishing in-game video.", Array.Empty<object>());
		PlayMakerFSM.BroadcastEvent("CINEMATIC END");
		GameCameras.instance.EnableImageEffects(this.gm.IsGameplayScene(), false);
		this.myRenderer.enabled = false;
		this.selfBlanker.enabled = false;
		if (this.masterResume != null)
		{
			this.masterResume.TransitionTo(0f);
		}
		if (!this.additionalAudioContinuesPastVideo && this.additionalAudio != null)
		{
			this.additionalAudio.Stop();
		}
		if (this.cinematicVideoPlayer != null)
		{
			this.cinematicVideoPlayer.Stop();
			this.cinematicVideoPlayer.Dispose();
			this.cinematicVideoPlayer = null;
		}
		this.videoTriggered = false;
		this.gm.gameState = GameState.PLAYING;
	}

	// Token: 0x06000209 RID: 521 RVA: 0x0000CAAF File Offset: 0x0000ACAF
	private IEnumerator WaitForStagFadeOut()
	{
		yield return new WaitForSeconds(2.6f);
		GameCameras.instance.cameraFadeFSM.Fsm.Event("JUST FADE");
		yield break;
	}

	// Token: 0x04000192 RID: 402
	[SerializeField]
	private CinematicVideoReference videoClip;

	// Token: 0x04000193 RID: 403
	private CinematicVideoPlayer cinematicVideoPlayer;

	// Token: 0x04000194 RID: 404
	[SerializeField]
	private AudioSource additionalAudio;

	// Token: 0x04000195 RID: 405
	[SerializeField]
	private bool additionalAudioContinuesPastVideo;

	// Token: 0x04000196 RID: 406
	[SerializeField]
	private MeshRenderer selfBlanker;

	// Token: 0x04000197 RID: 407
	[Header("Cinematic Settings")]
	[Tooltip("Determines what will trigger the video playing.")]
	public CinematicPlayer.MovieTrigger playTrigger;

	// Token: 0x04000198 RID: 408
	[Tooltip("The speed of the fade in, comes in different flavours.")]
	public CinematicPlayer.FadeInSpeed fadeInSpeed;

	// Token: 0x04000199 RID: 409
	[Tooltip("The amount of time to wait before fading in the camera. Camera will stay black and the video will play.")]
	[Range(0f, 10f)]
	public float delayBeforeFadeIn;

	// Token: 0x0400019A RID: 410
	[Tooltip("Allows the player to skip the video.")]
	public SkipPromptMode skipMode;

	// Token: 0x0400019B RID: 411
	[Tooltip("Prevents the skip action from taking place until the lock is released. Useful for animators delaying skip feature.")]
	public bool startSkipLocked;

	// Token: 0x0400019C RID: 412
	[Tooltip("The speed of the fade in, comes in different flavours.")]
	public CinematicPlayer.FadeOutSpeed fadeOutSpeed;

	// Token: 0x0400019D RID: 413
	[Tooltip("Video keeps looping until the player is explicitly told to stop.")]
	public bool loopVideo;

	// Token: 0x0400019E RID: 414
	[Space(6f)]
	[Tooltip("The name of the scene to load when the video ends. Leaving this blank will load the \"next scene\" as set in PlayerData.")]
	public CinematicPlayer.VideoType videoType;

	// Token: 0x0400019F RID: 415
	public CinematicVideoFaderStyles faderStyle;

	// Token: 0x040001A0 RID: 416
	private AudioSource audioSource;

	// Token: 0x040001A1 RID: 417
	private MeshRenderer myRenderer;

	// Token: 0x040001A2 RID: 418
	private GameManager gm;

	// Token: 0x040001A3 RID: 419
	private UIManager ui;

	// Token: 0x040001A4 RID: 420
	private PlayerData pd;

	// Token: 0x040001A5 RID: 421
	private PlayMakerFSM cameraFSM;

	// Token: 0x040001A6 RID: 422
	private bool videoTriggered;

	// Token: 0x040001A7 RID: 423
	private bool loadingLevel;

	// Token: 0x040001A8 RID: 424
	[SerializeField]
	private AudioMixerSnapshot masterOff;

	// Token: 0x040001A9 RID: 425
	[SerializeField]
	private AudioMixerSnapshot masterResume;

	// Token: 0x0200005F RID: 95
	public enum MovieTrigger
	{
		// Token: 0x040001AB RID: 427
		ON_START,
		// Token: 0x040001AC RID: 428
		MANUAL_TRIGGER
	}

	// Token: 0x02000060 RID: 96
	public enum FadeInSpeed
	{
		// Token: 0x040001AE RID: 430
		NORMAL,
		// Token: 0x040001AF RID: 431
		SLOW,
		// Token: 0x040001B0 RID: 432
		NONE
	}

	// Token: 0x02000061 RID: 97
	public enum FadeOutSpeed
	{
		// Token: 0x040001B2 RID: 434
		NORMAL,
		// Token: 0x040001B3 RID: 435
		SLOW,
		// Token: 0x040001B4 RID: 436
		NONE
	}

	// Token: 0x02000062 RID: 98
	public enum VideoType
	{
		// Token: 0x040001B6 RID: 438
		OpeningCutscene,
		// Token: 0x040001B7 RID: 439
		StagTravel,
		// Token: 0x040001B8 RID: 440
		InGameVideo,
		// Token: 0x040001B9 RID: 441
		OpeningPrologue,
		// Token: 0x040001BA RID: 442
		EndingA,
		// Token: 0x040001BB RID: 443
		EndingB,
		// Token: 0x040001BC RID: 444
		EndingC,
		// Token: 0x040001BD RID: 445
		EndingGG
	}
}
