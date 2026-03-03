using System;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C77 RID: 3191
	[ActionCategory(ActionCategory.Level)]
	[Tooltip("Restarts current level.")]
	public class RestartLevel : FsmStateAction
	{
		// Token: 0x060042AB RID: 17067 RVA: 0x00170B74 File Offset: 0x0016ED74
		public override void OnEnter()
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name, LoadSceneMode.Single);
			base.Finish();
		}
	}
}
