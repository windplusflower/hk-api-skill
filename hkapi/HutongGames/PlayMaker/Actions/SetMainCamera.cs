using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CCE RID: 3278
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets the Main Camera.")]
	public class SetMainCamera : FsmStateAction
	{
		// Token: 0x06004438 RID: 17464 RVA: 0x00175117 File Offset: 0x00173317
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x06004439 RID: 17465 RVA: 0x00175120 File Offset: 0x00173320
		public override void OnEnter()
		{
			if (this.gameObject.Value != null)
			{
				if (Camera.main != null)
				{
					Camera.main.gameObject.tag = "Untagged";
				}
				this.gameObject.Value.tag = "MainCamera";
			}
			base.Finish();
		}

		// Token: 0x04004884 RID: 18564
		[RequiredField]
		[CheckForComponent(typeof(Camera))]
		[Tooltip("The GameObject to set as the main camera (should have a Camera component).")]
		public FsmGameObject gameObject;
	}
}
