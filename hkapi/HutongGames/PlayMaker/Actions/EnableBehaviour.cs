using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B79 RID: 2937
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Enables/Disables a Behaviour on a GameObject. Optionally reset the Behaviour on exit - useful if you want the Behaviour to be active only while this state is active.")]
	public class EnableBehaviour : FsmStateAction
	{
		// Token: 0x06003E6D RID: 15981 RVA: 0x00164308 File Offset: 0x00162508
		public override void Reset()
		{
			this.gameObject = null;
			this.behaviour = null;
			this.component = null;
			this.enable = true;
			this.resetOnExit = true;
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x00164337 File Offset: 0x00162537
		public override void OnEnter()
		{
			this.DoEnableBehaviour(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x00164358 File Offset: 0x00162558
		private void DoEnableBehaviour(GameObject go)
		{
			if (go == null)
			{
				return;
			}
			if (this.component != null)
			{
				this.componentTarget = (this.component as Behaviour);
			}
			else
			{
				this.componentTarget = (go.GetComponent(ReflectionUtils.GetGlobalType(this.behaviour.Value)) as Behaviour);
			}
			if (this.componentTarget == null)
			{
				base.LogWarning(" " + go.name + " missing behaviour: " + this.behaviour.Value);
				return;
			}
			this.componentTarget.enabled = this.enable.Value;
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x001643FC File Offset: 0x001625FC
		public override void OnExit()
		{
			if (this.componentTarget == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this.componentTarget.enabled = !this.enable.Value;
			}
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x00164434 File Offset: 0x00162634
		public override string ErrorCheck()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null || this.component != null || this.behaviour.IsNone || string.IsNullOrEmpty(this.behaviour.Value))
			{
				return null;
			}
			if (!(ownerDefaultTarget.GetComponent(ReflectionUtils.GetGlobalType(this.behaviour.Value)) as Behaviour != null))
			{
				return "Behaviour missing";
			}
			return null;
		}

		// Token: 0x0400427F RID: 17023
		[RequiredField]
		[Tooltip("The GameObject that owns the Behaviour.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004280 RID: 17024
		[UIHint(UIHint.Behaviour)]
		[Tooltip("The name of the Behaviour to enable/disable.")]
		public FsmString behaviour;

		// Token: 0x04004281 RID: 17025
		[Tooltip("Optionally drag a component directly into this field (behavior name will be ignored).")]
		public Component component;

		// Token: 0x04004282 RID: 17026
		[RequiredField]
		[Tooltip("Set to True to enable, False to disable.")]
		public FsmBool enable;

		// Token: 0x04004283 RID: 17027
		public FsmBool resetOnExit;

		// Token: 0x04004284 RID: 17028
		private Behaviour componentTarget;
	}
}
