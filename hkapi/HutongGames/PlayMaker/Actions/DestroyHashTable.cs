using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200092C RID: 2348
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Destroys a PlayMakerHashTableProxy Component of a Game Object.")]
	public class DestroyHashTable : HashTableActions
	{
		// Token: 0x060033DC RID: 13276 RVA: 0x0013716F File Offset: 0x0013536F
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.successEvent = null;
			this.notFoundEvent = null;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00137190 File Offset: 0x00135390
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.SetUpHashTableProxyPointer(ownerDefaultTarget, this.reference.Value))
			{
				this.DoDestroyHashTable(ownerDefaultTarget);
			}
			else
			{
				base.Fsm.Event(this.notFoundEvent);
			}
			base.Finish();
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x001371E4 File Offset: 0x001353E4
		private void DoDestroyHashTable(GameObject go)
		{
			foreach (PlayMakerHashTableProxy playMakerHashTableProxy in this.proxy.GetComponents<PlayMakerHashTableProxy>())
			{
				if (playMakerHashTableProxy.referenceName == this.reference.Value)
				{
					UnityEngine.Object.Destroy(playMakerHashTableProxy);
					base.Fsm.Event(this.successEvent);
					return;
				}
			}
			base.Fsm.Event(this.notFoundEvent);
		}

		// Token: 0x0400355F RID: 13663
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003560 RID: 13664
		[Tooltip("Author defined Reference of the PlayMaker HashTable proxy component ( necessary if several component coexists on the same GameObject")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x04003561 RID: 13665
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the HashTable proxy component is destroyed")]
		public FsmEvent successEvent;

		// Token: 0x04003562 RID: 13666
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the HashTable proxy component was not found")]
		public FsmEvent notFoundEvent;
	}
}
