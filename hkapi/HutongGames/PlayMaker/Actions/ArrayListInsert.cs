using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000919 RID: 2329
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Insert item at a specified index of a PlayMaker ArrayList Proxy component")]
	public class ArrayListInsert : ArrayListActions
	{
		// Token: 0x0600338F RID: 13199 RVA: 0x00136214 File Offset: 0x00134414
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.variable = null;
			this.failureEvent = null;
			this.index = null;
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00136239 File Offset: 0x00134439
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.doArrayListInsert();
			}
			base.Finish();
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x0013626C File Offset: 0x0013446C
		public void doArrayListInsert()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			try
			{
				this.proxy.arrayList.Insert(this.index.Value, PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variable));
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				base.Fsm.Event(this.failureEvent);
			}
		}

		// Token: 0x0400350E RID: 13582
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400350F RID: 13583
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x04003510 RID: 13584
		[UIHint(UIHint.FsmInt)]
		[Tooltip("The index to remove at")]
		public FsmInt index;

		// Token: 0x04003511 RID: 13585
		[ActionSection("Data")]
		[RequiredField]
		[Tooltip("The variable to add.")]
		public FsmVar variable;

		// Token: 0x04003512 RID: 13586
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the removeAt throw errors")]
		public FsmEvent failureEvent;
	}
}
