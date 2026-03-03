using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000929 RID: 2345
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Destroys a PlayMakerArrayListProxy Component of a Game Object.")]
	public class DestroyArrayList : ArrayListActions
	{
		// Token: 0x060033D0 RID: 13264 RVA: 0x00136EF4 File Offset: 0x001350F4
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.successEvent = null;
			this.notFoundEvent = null;
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00136F14 File Offset: 0x00135114
		public override void OnEnter()
		{
			if (base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.DoDestroyArrayList();
			}
			else
			{
				base.Fsm.Event(this.notFoundEvent);
			}
			base.Finish();
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00136F64 File Offset: 0x00135164
		private void DoDestroyArrayList()
		{
			foreach (PlayMakerArrayListProxy playMakerArrayListProxy in this.proxy.GetComponents<PlayMakerArrayListProxy>())
			{
				if (playMakerArrayListProxy.referenceName == this.reference.Value)
				{
					UnityEngine.Object.Destroy(playMakerArrayListProxy);
					base.Fsm.Event(this.successEvent);
					return;
				}
			}
			base.Fsm.Event(this.notFoundEvent);
		}

		// Token: 0x04003552 RID: 13650
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003553 RID: 13651
		[Tooltip("Author defined Reference of the PlayMaker ArrayList proxy component ( necessary if several component coexists on the same GameObject")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x04003554 RID: 13652
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the ArrayList proxy component is destroyed")]
		public FsmEvent successEvent;

		// Token: 0x04003555 RID: 13653
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the ArrayList proxy component was not found")]
		public FsmEvent notFoundEvent;
	}
}
