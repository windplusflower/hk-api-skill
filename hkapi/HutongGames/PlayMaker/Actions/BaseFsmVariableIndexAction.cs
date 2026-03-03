using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B31 RID: 2865
	[ActionCategory(ActionCategory.StateMachine)]
	[ActionTarget(typeof(PlayMakerFSM), "gameObject,fsmName", false)]
	public abstract class BaseFsmVariableIndexAction : FsmStateAction
	{
		// Token: 0x06003D44 RID: 15684 RVA: 0x00160792 File Offset: 0x0015E992
		public override void Reset()
		{
			this.fsmNotFound = null;
			this.variableNotFound = null;
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x001607A4 File Offset: 0x0015E9A4
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

		// Token: 0x06003D46 RID: 15686 RVA: 0x00160832 File Offset: 0x0015EA32
		protected void DoVariableNotFound(string variableName)
		{
			base.LogWarning("Could not find variable: " + variableName);
			base.Fsm.Event(this.variableNotFound);
		}

		// Token: 0x04004151 RID: 16721
		[ActionSection("Events")]
		[Tooltip("The event to trigger if the index is out of range")]
		public FsmEvent indexOutOfRange;

		// Token: 0x04004152 RID: 16722
		[Tooltip("The event to send if the FSM is not found.")]
		public FsmEvent fsmNotFound;

		// Token: 0x04004153 RID: 16723
		[Tooltip("The event to send if the Variable is not found.")]
		public FsmEvent variableNotFound;

		// Token: 0x04004154 RID: 16724
		private GameObject cachedGameObject;

		// Token: 0x04004155 RID: 16725
		private string cachedFsmName;

		// Token: 0x04004156 RID: 16726
		protected PlayMakerFSM fsm;
	}
}
