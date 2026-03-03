using System;
using System.Collections;
using GlobalEnums;
using UnityEngine;

// Token: 0x02000095 RID: 149
public class StagTravel : MonoBehaviour
{
	// Token: 0x06000333 RID: 819 RVA: 0x00011830 File Offset: 0x0000FA30
	protected IEnumerator Start()
	{
		this.isAsync = Platform.Current.FetchScenesBeforeFade;
		GameCameras.instance.DisableImageEffects();
		if (!this.isAsync)
		{
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
			GameManager.instance.inputHandler.SetSkipMode(SkipPromptMode.SKIP_INSTANT);
			this.cinematicSequence.IsLooping = false;
			this.cinematicSequence.Begin();
			while (this.cinematicSequence.IsPlaying && !this.isSkipFadeComplete && this.cinematicSequence.VideoPlayer != null && this.cinematicSequence.VideoPlayer.CurrentTime < 3.9f)
			{
				yield return null;
			}
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE OUT INSTANT");
			yield return null;
			GameManager.instance.BeginSceneTransition(new GameManager.SceneLoadInfo
			{
				EntryGateName = "door_stagExit",
				SceneName = GameManager.instance.playerData.GetString("nextScene"),
				PreventCameraFadeOut = true,
				Visualization = GameManager.SceneLoadVisualizations.Custom
			});
			this.isReadyToActivate = true;
		}
		else
		{
			this.StartCoroutine("FadeInRoutine");
			this.cinematicSequence.IsLooping = true;
			this.cinematicSequence.Begin();
			GameManager.instance.BeginSceneTransition(new StagTravel.StagTravelAsyncLoadInfo(this)
			{
				EntryGateName = "door_stagExit",
				SceneName = GameManager.instance.playerData.GetString("nextScene"),
				PreventCameraFadeOut = true,
				Visualization = GameManager.SceneLoadVisualizations.Custom
			});
		}
		yield break;
	}

	// Token: 0x06000334 RID: 820 RVA: 0x0001183F File Offset: 0x0000FA3F
	private IEnumerator FadeInRoutine()
	{
		GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE OUT INSTANT");
		yield return new WaitForSeconds(1.5f);
		GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE IN");
		yield break;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00011848 File Offset: 0x0000FA48
	protected void Update()
	{
		this.currentDuration += Time.unscaledDeltaTime;
		if (this.isAsync && !this.isSkipping && this.isFetchComplete && this.currentDuration > this.minimumDuration)
		{
			base.StartCoroutine(this.Skip());
		}
	}

	// Token: 0x06000336 RID: 822 RVA: 0x0001189A File Offset: 0x0000FA9A
	protected void NotifyFetchComplete()
	{
		this.isFetchComplete = true;
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06000337 RID: 823 RVA: 0x000118A3 File Offset: 0x0000FAA3
	protected bool IsReadyToActivate
	{
		get
		{
			return this.isReadyToActivate;
		}
	}

	// Token: 0x06000338 RID: 824 RVA: 0x000118AB File Offset: 0x0000FAAB
	public IEnumerator Skip()
	{
		if (!this.isSkipping)
		{
			this.StopCoroutine("FadeInRoutine");
			this.isSkipping = true;
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE OUT");
			yield return new WaitForSecondsRealtime(0.5f);
			this.isSkipFadeComplete = true;
			this.isReadyToActivate = true;
		}
		yield break;
	}

	// Token: 0x0400029C RID: 668
	[SerializeField]
	private CinematicSequence cinematicSequence;

	// Token: 0x0400029D RID: 669
	[SerializeField]
	private float minimumDuration;

	// Token: 0x0400029E RID: 670
	[SerializeField]
	private float fadeRate;

	// Token: 0x0400029F RID: 671
	private bool isAsync;

	// Token: 0x040002A0 RID: 672
	private float currentDuration;

	// Token: 0x040002A1 RID: 673
	private bool isFetchComplete;

	// Token: 0x040002A2 RID: 674
	private bool isReadyToActivate;

	// Token: 0x040002A3 RID: 675
	private bool isSkipping;

	// Token: 0x040002A4 RID: 676
	private bool isSkipFadeComplete;

	// Token: 0x02000096 RID: 150
	private class StagTravelAsyncLoadInfo : GameManager.SceneLoadInfo
	{
		// Token: 0x0600033A RID: 826 RVA: 0x000118BA File Offset: 0x0000FABA
		public StagTravelAsyncLoadInfo(StagTravel stagTravel)
		{
			this.stagTravel = stagTravel;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000118C9 File Offset: 0x0000FAC9
		public override void NotifyFetchComplete()
		{
			base.NotifyFetchComplete();
			this.stagTravel.NotifyFetchComplete();
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000118DC File Offset: 0x0000FADC
		public override bool IsReadyToActivate()
		{
			return base.IsReadyToActivate() && this.stagTravel.IsReadyToActivate;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000118F3 File Offset: 0x0000FAF3
		public override void NotifyFinished()
		{
			base.NotifyFinished();
			GameCameras.instance.cameraFadeFSM.Fsm.Event("FADE SCENE OUT INSTANT");
			GameCameras.instance.EnableImageEffects(true, false);
		}

		// Token: 0x040002A5 RID: 677
		private StagTravel stagTravel;
	}
}
