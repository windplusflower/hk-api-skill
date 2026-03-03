using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000928 RID: 2344
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Adds a PlayMakerArrayList Component to a Game Object. Use this to create arrayList on the fly instead of during authoring.\n Optionally remove the ArrayList component on exiting the state.\n Simply point to existing if the reference exists already.")]
	public class ArrayListCreate : ArrayListActions
	{
		// Token: 0x060033CB RID: 13259 RVA: 0x00136E1C File Offset: 0x0013501C
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.alreadyExistsEvent = null;
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00136E33 File Offset: 0x00135033
		public override void OnEnter()
		{
			this.DoAddPlayMakerArrayList();
			base.Finish();
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00136E41 File Offset: 0x00135041
		public override void OnExit()
		{
			if (this.removeOnExit.Value && this.addedComponent != null)
			{
				UnityEngine.Object.Destroy(this.addedComponent);
			}
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00136E6C File Offset: 0x0013506C
		private void DoAddPlayMakerArrayList()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.GetArrayListProxyPointer(ownerDefaultTarget, this.reference.Value, true) != null)
			{
				base.Fsm.Event(this.alreadyExistsEvent);
				return;
			}
			this.addedComponent = ownerDefaultTarget.AddComponent<PlayMakerArrayListProxy>();
			if (this.addedComponent == null)
			{
				base.LogError("Can't add PlayMakerArrayListProxy");
				return;
			}
			this.addedComponent.referenceName = this.reference.Value;
		}

		// Token: 0x0400354D RID: 13645
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject to add the PlayMaker ArrayList Proxy component to")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400354E RID: 13646
		[Tooltip("Author defined Reference of the PlayMaker arrayList proxy component ( necessary if several component coexists on the same GameObject")]
		[UIHint(UIHint.FsmString)]
		public FsmString reference;

		// Token: 0x0400354F RID: 13647
		[Tooltip("Remove the Component when this State is exited.")]
		public FsmBool removeOnExit;

		// Token: 0x04003550 RID: 13648
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the arrayList exists already")]
		public FsmEvent alreadyExistsEvent;

		// Token: 0x04003551 RID: 13649
		private PlayMakerArrayListProxy addedComponent;
	}
}
