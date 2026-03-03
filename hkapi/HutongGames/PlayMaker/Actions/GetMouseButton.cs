using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BFC RID: 3068
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the pressed state of the specified Mouse Button and stores it in a Bool Variable. See Unity Input Manager doc.")]
	public class GetMouseButton : FsmStateAction
	{
		// Token: 0x06004078 RID: 16504 RVA: 0x0016A595 File Offset: 0x00168795
		public override void Reset()
		{
			this.button = MouseButton.Left;
			this.storeResult = null;
		}

		// Token: 0x06004079 RID: 16505 RVA: 0x0016A5A5 File Offset: 0x001687A5
		public override void OnEnter()
		{
			this.storeResult.Value = Input.GetMouseButton((int)this.button);
		}

		// Token: 0x0600407A RID: 16506 RVA: 0x0016A5A5 File Offset: 0x001687A5
		public override void OnUpdate()
		{
			this.storeResult.Value = Input.GetMouseButton((int)this.button);
		}

		// Token: 0x040044D7 RID: 17623
		[RequiredField]
		[Tooltip("The mouse button to test.")]
		public MouseButton button;

		// Token: 0x040044D8 RID: 17624
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the pressed state in a Bool Variable.")]
		public FsmBool storeResult;
	}
}
