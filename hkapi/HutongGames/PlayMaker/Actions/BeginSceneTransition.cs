using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000996 RID: 2454
	[ActionCategory("Game Manager")]
	[Tooltip("Perform a generic scene transition.")]
	public class BeginSceneTransition : FsmStateAction
	{
		// Token: 0x060035CC RID: 13772 RVA: 0x0013D8FC File Offset: 0x0013BAFC
		public override void Reset()
		{
			this.sceneName = "";
			this.entryGateName = "left1";
			this.entryDelay = 0f;
			this.visualization = new FsmEnum
			{
				Value = GameManager.SceneLoadVisualizations.Default
			};
			this.preventCameraFadeOut = false;
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x0013D958 File Offset: 0x0013BB58
		public override void OnEnter()
		{
			GameManager unsafeInstance = GameManager.UnsafeInstance;
			if (unsafeInstance == null)
			{
				base.LogError("Cannot BeginSceneTransition() before the game manager is loaded.");
			}
			else
			{
				unsafeInstance.BeginSceneTransition(new GameManager.SceneLoadInfo
				{
					SceneName = this.sceneName.Value,
					EntryGateName = this.entryGateName.Value,
					EntryDelay = this.entryDelay.Value,
					Visualization = (GameManager.SceneLoadVisualizations)this.visualization.Value,
					PreventCameraFadeOut = true,
					WaitForSceneTransitionCameraFade = !this.preventCameraFadeOut,
					AlwaysUnloadUnusedAssets = false
				});
			}
			base.Finish();
		}

		// Token: 0x04003767 RID: 14183
		public FsmString sceneName;

		// Token: 0x04003768 RID: 14184
		public FsmString entryGateName;

		// Token: 0x04003769 RID: 14185
		public FsmFloat entryDelay;

		// Token: 0x0400376A RID: 14186
		[ObjectType(typeof(GameManager.SceneLoadVisualizations))]
		public FsmEnum visualization;

		// Token: 0x0400376B RID: 14187
		public bool preventCameraFadeOut;
	}
}
