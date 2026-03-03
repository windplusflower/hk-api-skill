using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C39 RID: 3129
	[ActionCategory(ActionCategory.Level)]
	[Tooltip("Loads a Level by Index number. Before you can load a level, you have to add it to the list of levels defined in File->Build Settings...")]
	public class LoadLevelNum : FsmStateAction
	{
		// Token: 0x06004184 RID: 16772 RVA: 0x0016CC06 File Offset: 0x0016AE06
		public override void Reset()
		{
			this.levelIndex = null;
			this.additive = false;
			this.loadedEvent = null;
			this.dontDestroyOnLoad = false;
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x0016CC2C File Offset: 0x0016AE2C
		public override void OnEnter()
		{
			if (!Application.CanStreamedLevelBeLoaded(this.levelIndex.Value))
			{
				base.Fsm.Event(this.failedEvent);
				base.Finish();
				return;
			}
			if (this.dontDestroyOnLoad.Value)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.Owner.transform.root.gameObject);
			}
			if (this.additive)
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(this.levelIndex.Value, LoadSceneMode.Additive);
			}
			else
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(this.levelIndex.Value, LoadSceneMode.Single);
			}
			base.Fsm.Event(this.loadedEvent);
			base.Finish();
		}

		// Token: 0x040045CB RID: 17867
		[RequiredField]
		[Tooltip("The level index in File->Build Settings")]
		public FsmInt levelIndex;

		// Token: 0x040045CC RID: 17868
		[Tooltip("Load the level additively, keeping the current scene.")]
		public bool additive;

		// Token: 0x040045CD RID: 17869
		[Tooltip("Event to send after the level is loaded.")]
		public FsmEvent loadedEvent;

		// Token: 0x040045CE RID: 17870
		[Tooltip("Keep this GameObject in the new level. NOTE: The GameObject and components is disabled then enabled on load; uncheck Reset On Disable to keep the active state.")]
		public FsmBool dontDestroyOnLoad;

		// Token: 0x040045CF RID: 17871
		[Tooltip("Event to send if the level cannot be loaded.")]
		public FsmEvent failedEvent;
	}
}
