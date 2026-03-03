using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF8 RID: 3064
	[ActionCategory(ActionCategory.Camera)]
	[ActionTarget(typeof(Camera), "storeGameObject", false)]
	[Tooltip("Gets the GameObject tagged MainCamera from the scene")]
	public class GetMainCamera : FsmStateAction
	{
		// Token: 0x06004069 RID: 16489 RVA: 0x0016A1F5 File Offset: 0x001683F5
		public override void Reset()
		{
			this.storeGameObject = null;
		}

		// Token: 0x0600406A RID: 16490 RVA: 0x0016A1FE File Offset: 0x001683FE
		public override void OnEnter()
		{
			this.storeGameObject.Value = ((Camera.main != null) ? Camera.main.gameObject : null);
			base.Finish();
		}

		// Token: 0x040044CB RID: 17611
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject storeGameObject;
	}
}
