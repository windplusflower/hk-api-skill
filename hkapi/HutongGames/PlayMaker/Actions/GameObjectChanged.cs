using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BC2 RID: 3010
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Tests if the value of a GameObject variable changed. Use this to send an event on change, or store a bool that can be used in other operations.")]
	public class GameObjectChanged : FsmStateAction
	{
		// Token: 0x06003F7E RID: 16254 RVA: 0x001678A5 File Offset: 0x00165AA5
		public override void Reset()
		{
			this.gameObjectVariable = null;
			this.changedEvent = null;
			this.storeResult = null;
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x001678BC File Offset: 0x00165ABC
		public override void OnEnter()
		{
			if (this.gameObjectVariable.IsNone)
			{
				base.Finish();
				return;
			}
			this.previousValue = this.gameObjectVariable.Value;
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x001678E4 File Offset: 0x00165AE4
		public override void OnUpdate()
		{
			this.storeResult.Value = false;
			if (this.gameObjectVariable.Value != this.previousValue)
			{
				this.storeResult.Value = true;
				base.Fsm.Event(this.changedEvent);
			}
		}

		// Token: 0x040043A7 RID: 17319
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject variable to watch for a change.")]
		public FsmGameObject gameObjectVariable;

		// Token: 0x040043A8 RID: 17320
		[Tooltip("Event to send if the variable changes.")]
		public FsmEvent changedEvent;

		// Token: 0x040043A9 RID: 17321
		[UIHint(UIHint.Variable)]
		[Tooltip("Set to True if the variable changes.")]
		public FsmBool storeResult;

		// Token: 0x040043AA RID: 17322
		private GameObject previousValue;
	}
}
