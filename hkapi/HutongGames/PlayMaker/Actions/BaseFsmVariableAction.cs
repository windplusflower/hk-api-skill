using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B30 RID: 2864
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	public abstract class BaseFsmVariableAction : FsmStateAction
	{
		// Token: 0x06003D40 RID: 15680 RVA: 0x001606D0 File Offset: 0x0015E8D0
		public override void Reset()
		{
			this.fsmNotFound = null;
			this.variableNotFound = null;
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x001606E0 File Offset: 0x0015E8E0
		protected bool UpdateCache(GameObject go, string fsmName)
		{
			if (go == null)
			{
				return false;
			}
			if (this.fsm == null || this.cachedGameObject != go || this.cachedFsmName != fsmName)
			{
				this.fsm = ActionHelpers.GetGameObjectFsm(go, fsmName);
				this.cachedGameObject = go;
				this.cachedFsmName = fsmName;
				if (this.fsm == null)
				{
					base.LogWarning("Could not find FSM: " + fsmName);
					base.Fsm.Event(this.fsmNotFound);
				}
			}
			return true;
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x0016076E File Offset: 0x0015E96E
		protected void DoVariableNotFound(string variableName)
		{
			base.LogWarning("Could not find variable: " + variableName);
			base.Fsm.Event(this.variableNotFound);
		}

		// Token: 0x0400414C RID: 16716
		[ActionSection("Events")]
		[Tooltip("The event to send if the FSM is not found.")]
		public FsmEvent fsmNotFound;

		// Token: 0x0400414D RID: 16717
		[Tooltip("The event to send if the Variable is not found.")]
		public FsmEvent variableNotFound;

		// Token: 0x0400414E RID: 16718
		private GameObject cachedGameObject;

		// Token: 0x0400414F RID: 16719
		private string cachedFsmName;

		// Token: 0x04004150 RID: 16720
		protected PlayMakerFSM fsm;
	}
}
