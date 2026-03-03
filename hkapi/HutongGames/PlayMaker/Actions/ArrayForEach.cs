using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B16 RID: 2838
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Iterate through the items in an Array and run an FSM on each item. NOTE: The FSM has to Finish before being run on the next item.")]
	public class ArrayForEach : RunFSMAction
	{
		// Token: 0x06003CDE RID: 15582 RVA: 0x0015F0B0 File Offset: 0x0015D2B0
		public override void Reset()
		{
			this.array = null;
			this.fsmTemplateControl = new FsmTemplateControl();
			this.runFsm = null;
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x0015F0CB File Offset: 0x0015D2CB
		public override void Awake()
		{
			if (this.array != null && this.fsmTemplateControl.fsmTemplate != null && Application.isPlaying)
			{
				this.runFsm = base.Fsm.CreateSubFsm(this.fsmTemplateControl);
			}
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00130B3B File Offset: 0x0012ED3B
		public override void OnPreprocess()
		{
			base.OnPreprocess();
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x0015F106 File Offset: 0x0015D306
		public override void OnEnter()
		{
			if (this.array == null || this.runFsm == null)
			{
				base.Finish();
				return;
			}
			this.currentIndex = 0;
			this.StartFsm();
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x0015F12C File Offset: 0x0015D32C
		public override void OnUpdate()
		{
			this.runFsm.Update();
			if (!this.runFsm.Finished)
			{
				return;
			}
			this.StartNextFsm();
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x0015F14D File Offset: 0x0015D34D
		public override void OnFixedUpdate()
		{
			this.runFsm.LateUpdate();
			if (!this.runFsm.Finished)
			{
				return;
			}
			this.StartNextFsm();
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x0015F14D File Offset: 0x0015D34D
		public override void OnLateUpdate()
		{
			this.runFsm.LateUpdate();
			if (!this.runFsm.Finished)
			{
				return;
			}
			this.StartNextFsm();
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x0015F16E File Offset: 0x0015D36E
		private void StartNextFsm()
		{
			this.currentIndex++;
			this.StartFsm();
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x0015F184 File Offset: 0x0015D384
		private void StartFsm()
		{
			while (this.currentIndex < this.array.Length)
			{
				this.DoStartFsm();
				if (!this.runFsm.Finished)
				{
					return;
				}
				this.currentIndex++;
			}
			base.Fsm.Event(this.finishEvent);
			base.Finish();
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x0015F1E0 File Offset: 0x0015D3E0
		private void DoStartFsm()
		{
			this.storeItem.SetValue(this.array.Values[this.currentIndex]);
			this.fsmTemplateControl.UpdateValues();
			this.fsmTemplateControl.ApplyOverrides(this.runFsm);
			this.runFsm.OnEnable();
			if (!this.runFsm.Started)
			{
				this.runFsm.Start();
			}
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00003603 File Offset: 0x00001803
		protected override void CheckIfFinished()
		{
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x0015F249 File Offset: 0x0015D449
		public ArrayForEach()
		{
			this.fsmTemplateControl = new FsmTemplateControl();
			base..ctor();
		}

		// Token: 0x040040E3 RID: 16611
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Array to iterate through.")]
		public FsmArray array;

		// Token: 0x040040E4 RID: 16612
		[HideTypeFilter]
		[MatchElementType("array")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the item in a variable")]
		public FsmVar storeItem;

		// Token: 0x040040E5 RID: 16613
		[ActionSection("Run FSM")]
		public FsmTemplateControl fsmTemplateControl;

		// Token: 0x040040E6 RID: 16614
		[Tooltip("Event to send after iterating through all items in the Array.")]
		public FsmEvent finishEvent;

		// Token: 0x040040E7 RID: 16615
		private int currentIndex;
	}
}
