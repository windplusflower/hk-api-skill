using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200092B RID: 2347
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Adds a PlayMakerHashTableProxy Component to a Game Object. Use this to create arrayList on the fly instead of during authoring.\n Optionally remove the HashTable component on exiting the state.\n Simply point to existing if the reference exists already.")]
	public class HashTableCreate : HashTableActions
	{
		// Token: 0x060033D7 RID: 13271 RVA: 0x00137092 File Offset: 0x00135292
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.alreadyExistsEvent = null;
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x001370A9 File Offset: 0x001352A9
		public override void OnEnter()
		{
			this.DoAddPlayMakerHashTable();
			base.Finish();
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x001370B7 File Offset: 0x001352B7
		public override void OnExit()
		{
			if (this.removeOnExit.Value && this.addedComponent != null)
			{
				UnityEngine.Object.Destroy(this.addedComponent);
			}
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x001370E0 File Offset: 0x001352E0
		private void DoAddPlayMakerHashTable()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.GetHashTableProxyPointer(ownerDefaultTarget, this.reference.Value, true) != null)
			{
				base.Fsm.Event(this.alreadyExistsEvent);
				return;
			}
			this.addedComponent = ownerDefaultTarget.AddComponent<PlayMakerHashTableProxy>();
			if (this.addedComponent == null)
			{
				Debug.LogError("Can't add PlayMakerHashTableProxy");
				return;
			}
			this.addedComponent.referenceName = this.reference.Value;
		}

		// Token: 0x0400355A RID: 13658
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The Game Object to add the Hashtable Component to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400355B RID: 13659
		[Tooltip("Author defined Reference of the PlayMaker arrayList proxy component ( necessary if several component coexists on the same GameObject")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x0400355C RID: 13660
		[Tooltip("Remove the Component when this State is exited.")]
		public FsmBool removeOnExit;

		// Token: 0x0400355D RID: 13661
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the hashtable exists already")]
		public FsmEvent alreadyExistsEvent;

		// Token: 0x0400355E RID: 13662
		private PlayMakerHashTableProxy addedComponent;
	}
}
