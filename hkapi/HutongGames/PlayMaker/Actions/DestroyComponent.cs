using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B6A RID: 2922
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Destroys a Component of an Object.")]
	public class DestroyComponent : FsmStateAction
	{
		// Token: 0x06003E39 RID: 15929 RVA: 0x00163B39 File Offset: 0x00161D39
		public override void Reset()
		{
			this.aComponent = null;
			this.gameObject = null;
			this.component = null;
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x00163B50 File Offset: 0x00161D50
		public override void OnEnter()
		{
			this.DoDestroyComponent((this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value);
			base.Finish();
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x00163B84 File Offset: 0x00161D84
		private void DoDestroyComponent(GameObject go)
		{
			this.aComponent = go.GetComponent(ReflectionUtils.GetGlobalType(this.component.Value));
			if (this.aComponent == null)
			{
				base.LogError("No such component: " + this.component.Value);
				return;
			}
			UnityEngine.Object.Destroy(this.aComponent);
		}

		// Token: 0x04004253 RID: 16979
		[RequiredField]
		[Tooltip("The GameObject that owns the Component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004254 RID: 16980
		[RequiredField]
		[UIHint(UIHint.ScriptComponent)]
		[Tooltip("The name of the Component to destroy.")]
		public FsmString component;

		// Token: 0x04004255 RID: 16981
		private Component aComponent;
	}
}
