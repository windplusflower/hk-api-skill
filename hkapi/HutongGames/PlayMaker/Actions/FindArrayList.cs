using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200092A RID: 2346
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Finds an ArrayList by reference. Warning: this function can be very slow.")]
	public class FindArrayList : CollectionsActions
	{
		// Token: 0x060033D4 RID: 13268 RVA: 0x00136FD0 File Offset: 0x001351D0
		public override void Reset()
		{
			this.ArrayListReference = "";
			this.store = null;
			this.foundEvent = null;
			this.notFoundEvent = null;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00136FF8 File Offset: 0x001351F8
		public override void OnEnter()
		{
			foreach (PlayMakerArrayListProxy playMakerArrayListProxy in UnityEngine.Object.FindObjectsOfType(typeof(PlayMakerArrayListProxy)) as PlayMakerArrayListProxy[])
			{
				if (playMakerArrayListProxy.referenceName == this.ArrayListReference.Value)
				{
					this.store.Value = playMakerArrayListProxy.gameObject;
					base.Fsm.Event(this.foundEvent);
					return;
				}
			}
			this.store.Value = null;
			base.Fsm.Event(this.notFoundEvent);
			base.Finish();
		}

		// Token: 0x04003556 RID: 13654
		[ActionSection("Set up")]
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component")]
		public FsmString ArrayListReference;

		// Token: 0x04003557 RID: 13655
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("Store the GameObject hosting the PlayMaker ArrayList Proxy component here")]
		public FsmGameObject store;

		// Token: 0x04003558 RID: 13656
		public FsmEvent foundEvent;

		// Token: 0x04003559 RID: 13657
		public FsmEvent notFoundEvent;
	}
}
