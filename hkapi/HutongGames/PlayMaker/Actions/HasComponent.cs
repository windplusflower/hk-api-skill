using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C2A RID: 3114
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Checks if an Object has a Component. Optionally remove the Component on exiting the state.")]
	public class HasComponent : FsmStateAction
	{
		// Token: 0x06004142 RID: 16706 RVA: 0x0016C100 File Offset: 0x0016A300
		public override void Reset()
		{
			this.aComponent = null;
			this.gameObject = null;
			this.trueEvent = null;
			this.falseEvent = null;
			this.component = null;
			this.store = null;
			this.everyFrame = false;
		}

		// Token: 0x06004143 RID: 16707 RVA: 0x0016C133 File Offset: 0x0016A333
		public override void OnEnter()
		{
			this.DoHasComponent((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004144 RID: 16708 RVA: 0x0016C16E File Offset: 0x0016A36E
		public override void OnUpdate()
		{
			this.DoHasComponent((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
		}

		// Token: 0x06004145 RID: 16709 RVA: 0x0016C19B File Offset: 0x0016A39B
		public override void OnExit()
		{
			if (this.removeOnExit.Value && this.aComponent != null)
			{
				UnityEngine.Object.Destroy(this.aComponent);
			}
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x0016C1C4 File Offset: 0x0016A3C4
		private void DoHasComponent(GameObject go)
		{
			if (go == null)
			{
				if (!this.store.IsNone)
				{
					this.store.Value = false;
				}
				base.Fsm.Event(this.falseEvent);
				return;
			}
			this.aComponent = go.GetComponent(this.component.Value);
			if (!this.store.IsNone)
			{
				this.store.Value = (this.aComponent != null);
			}
			base.Fsm.Event((this.aComponent != null) ? this.trueEvent : this.falseEvent);
		}

		// Token: 0x04004581 RID: 17793
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004582 RID: 17794
		[RequiredField]
		[UIHint(UIHint.ScriptComponent)]
		public FsmString component;

		// Token: 0x04004583 RID: 17795
		public FsmBool removeOnExit;

		// Token: 0x04004584 RID: 17796
		public FsmEvent trueEvent;

		// Token: 0x04004585 RID: 17797
		public FsmEvent falseEvent;

		// Token: 0x04004586 RID: 17798
		[UIHint(UIHint.Variable)]
		public FsmBool store;

		// Token: 0x04004587 RID: 17799
		public bool everyFrame;

		// Token: 0x04004588 RID: 17800
		private Component aComponent;
	}
}
