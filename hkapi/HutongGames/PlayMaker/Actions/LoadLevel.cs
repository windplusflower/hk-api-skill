using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C38 RID: 3128
	[ActionCategory(ActionCategory.Level)]
	[Tooltip("Loads a Level by Name. NOTE: Before you can load a level, you have to add it to the list of levels defined in File->Build Settings...")]
	public class LoadLevel : FsmStateAction
	{
		// Token: 0x06004180 RID: 16768 RVA: 0x0016CA57 File Offset: 0x0016AC57
		public override void Reset()
		{
			this.levelName = "";
			this.additive = false;
			this.async = false;
			this.loadedEvent = null;
			this.dontDestroyOnLoad = false;
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0016CA8C File Offset: 0x0016AC8C
		public override void OnEnter()
		{
			if (!Application.CanStreamedLevelBeLoaded(this.levelName.Value))
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
				if (this.async)
				{
					this.asyncOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(this.levelName.Value, LoadSceneMode.Additive);
					Debug.Log("LoadLevelAdditiveAsyc: " + this.levelName.Value);
					return;
				}
				UnityEngine.SceneManagement.SceneManager.LoadScene(this.levelName.Value, LoadSceneMode.Additive);
				Debug.Log("LoadLevelAdditive: " + this.levelName.Value);
			}
			else
			{
				if (this.async)
				{
					this.asyncOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(this.levelName.Value, LoadSceneMode.Single);
					Debug.Log("LoadLevelAsync: " + this.levelName.Value);
					return;
				}
				UnityEngine.SceneManagement.SceneManager.LoadScene(this.levelName.Value, LoadSceneMode.Single);
				Debug.Log("LoadLevel: " + this.levelName.Value);
			}
			base.Log("LOAD COMPLETE");
			base.Fsm.Event(this.loadedEvent);
			base.Finish();
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x0016CBE0 File Offset: 0x0016ADE0
		public override void OnUpdate()
		{
			if (this.asyncOperation.isDone)
			{
				base.Fsm.Event(this.loadedEvent);
				base.Finish();
			}
		}

		// Token: 0x040045C4 RID: 17860
		[RequiredField]
		[Tooltip("The name of the level to load. NOTE: Must be in the list of levels defined in File->Build Settings... ")]
		public FsmString levelName;

		// Token: 0x040045C5 RID: 17861
		[Tooltip("Load the level additively, keeping the current scene.")]
		public bool additive;

		// Token: 0x040045C6 RID: 17862
		[Tooltip("Load the level asynchronously in the background.")]
		public bool async;

		// Token: 0x040045C7 RID: 17863
		[Tooltip("Event to send when the level has loaded. NOTE: This only makes sense if the FSM is still in the scene!")]
		public FsmEvent loadedEvent;

		// Token: 0x040045C8 RID: 17864
		[Tooltip("Keep this GameObject in the new level. NOTE: The GameObject and components is disabled then enabled on load; uncheck Reset On Disable to keep the active state.")]
		public FsmBool dontDestroyOnLoad;

		// Token: 0x040045C9 RID: 17865
		[Tooltip("Event to send if the level cannot be loaded.")]
		public FsmEvent failedEvent;

		// Token: 0x040045CA RID: 17866
		private AsyncOperation asyncOperation;
	}
}
