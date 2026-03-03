using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF4 RID: 2804
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Adds a Script to a Game Object. Use this to change the behaviour of objects on the fly. Optionally remove the Script on exiting the state.")]
	public class AddScript : FsmStateAction
	{
		// Token: 0x06003C31 RID: 15409 RVA: 0x0015A433 File Offset: 0x00158633
		public override void Reset()
		{
			this.gameObject = null;
			this.script = null;
		}

		// Token: 0x06003C32 RID: 15410 RVA: 0x0015A443 File Offset: 0x00158643
		public override void OnEnter()
		{
			this.DoAddComponent((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
			base.Finish();
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x0015A476 File Offset: 0x00158676
		public override void OnExit()
		{
			if (this.removeOnExit.Value && this.addedComponent != null)
			{
				UnityEngine.Object.Destroy(this.addedComponent);
			}
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x0015A4A0 File Offset: 0x001586A0
		private void DoAddComponent(GameObject go)
		{
			this.addedComponent = go.AddComponent(ReflectionUtils.GetGlobalType(this.script.Value));
			if (this.addedComponent == null)
			{
				base.LogError("Can't add script: " + this.script.Value);
			}
		}

		// Token: 0x04003FDD RID: 16349
		[RequiredField]
		[Tooltip("The GameObject to add the script to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FDE RID: 16350
		[RequiredField]
		[Tooltip("The Script to add to the GameObject.")]
		[UIHint(UIHint.ScriptComponent)]
		public FsmString script;

		// Token: 0x04003FDF RID: 16351
		[Tooltip("Remove the script from the GameObject when this State is exited.")]
		public FsmBool removeOnExit;

		// Token: 0x04003FE0 RID: 16352
		private Component addedComponent;
	}
}
