using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AF0 RID: 2800
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Adds a Component to a Game Object. Use this to change the behaviour of objects on the fly. Optionally remove the Component on exiting the state.")]
	public class AddComponent : FsmStateAction
	{
		// Token: 0x06003C1C RID: 15388 RVA: 0x0015A027 File Offset: 0x00158227
		public override void Reset()
		{
			this.gameObject = null;
			this.component = null;
			this.storeComponent = null;
		}

		// Token: 0x06003C1D RID: 15389 RVA: 0x0015A03E File Offset: 0x0015823E
		public override void OnEnter()
		{
			this.DoAddComponent();
			base.Finish();
		}

		// Token: 0x06003C1E RID: 15390 RVA: 0x0015A04C File Offset: 0x0015824C
		public override void OnExit()
		{
			if (this.removeOnExit.Value && this.addedComponent != null)
			{
				UnityEngine.Object.Destroy(this.addedComponent);
			}
		}

		// Token: 0x06003C1F RID: 15391 RVA: 0x0015A074 File Offset: 0x00158274
		private void DoAddComponent()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.addedComponent = ownerDefaultTarget.AddComponent(ReflectionUtils.GetGlobalType(this.component.Value));
			this.storeComponent.Value = this.addedComponent;
			if (this.addedComponent == null)
			{
				base.LogError("Can't add component: " + this.component.Value);
			}
		}

		// Token: 0x04003FC4 RID: 16324
		[RequiredField]
		[Tooltip("The GameObject to add the Component to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003FC5 RID: 16325
		[RequiredField]
		[UIHint(UIHint.ScriptComponent)]
		[Title("Component Type")]
		[Tooltip("The type of Component to add to the Game Object.")]
		public FsmString component;

		// Token: 0x04003FC6 RID: 16326
		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(Component))]
		[Tooltip("Store the component in an Object variable. E.g., to use with Set Property.")]
		public FsmObject storeComponent;

		// Token: 0x04003FC7 RID: 16327
		[Tooltip("Remove the Component when this State is exited.")]
		public FsmBool removeOnExit;

		// Token: 0x04003FC8 RID: 16328
		private Component addedComponent;
	}
}
