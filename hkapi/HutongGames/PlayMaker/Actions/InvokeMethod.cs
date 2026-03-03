using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C34 RID: 3124
	[ActionCategory(ActionCategory.ScriptControl)]
	[Tooltip("Invokes a Method in a Behaviour attached to a Game Object. See Unity InvokeMethod docs.")]
	public class InvokeMethod : FsmStateAction
	{
		// Token: 0x0600416F RID: 16751 RVA: 0x0016C78C File Offset: 0x0016A98C
		public override void Reset()
		{
			this.gameObject = null;
			this.behaviour = null;
			this.methodName = "";
			this.delay = null;
			this.repeating = false;
			this.repeatDelay = 1f;
			this.cancelOnExit = false;
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x0016C7E6 File Offset: 0x0016A9E6
		public override void OnEnter()
		{
			this.DoInvokeMethod(base.Fsm.GetOwnerDefaultTarget(this.gameObject));
			base.Finish();
		}

		// Token: 0x06004171 RID: 16753 RVA: 0x0016C808 File Offset: 0x0016AA08
		private void DoInvokeMethod(GameObject go)
		{
			if (go == null)
			{
				return;
			}
			this.component = (go.GetComponent(ReflectionUtils.GetGlobalType(this.behaviour.Value)) as MonoBehaviour);
			if (this.component == null)
			{
				base.LogWarning("InvokeMethod: " + go.name + " missing behaviour: " + this.behaviour.Value);
				return;
			}
			if (this.repeating.Value)
			{
				this.component.InvokeRepeating(this.methodName.Value, this.delay.Value, this.repeatDelay.Value);
				return;
			}
			this.component.Invoke(this.methodName.Value, this.delay.Value);
		}

		// Token: 0x06004172 RID: 16754 RVA: 0x0016C8D0 File Offset: 0x0016AAD0
		public override void OnExit()
		{
			if (this.component == null)
			{
				return;
			}
			if (this.cancelOnExit.Value)
			{
				this.component.CancelInvoke(this.methodName.Value);
			}
		}

		// Token: 0x040045B2 RID: 17842
		[RequiredField]
		[Tooltip("The game object that owns the behaviour.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040045B3 RID: 17843
		[RequiredField]
		[UIHint(UIHint.Script)]
		[Tooltip("The behaviour that contains the method.")]
		public FsmString behaviour;

		// Token: 0x040045B4 RID: 17844
		[RequiredField]
		[UIHint(UIHint.Method)]
		[Tooltip("The name of the method to invoke.")]
		public FsmString methodName;

		// Token: 0x040045B5 RID: 17845
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Optional time delay in seconds.")]
		public FsmFloat delay;

		// Token: 0x040045B6 RID: 17846
		[Tooltip("Call the method repeatedly.")]
		public FsmBool repeating;

		// Token: 0x040045B7 RID: 17847
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Delay between repeated calls in seconds.")]
		public FsmFloat repeatDelay;

		// Token: 0x040045B8 RID: 17848
		[Tooltip("Stop calling the method when the state is exited.")]
		public FsmBool cancelOnExit;

		// Token: 0x040045B9 RID: 17849
		private MonoBehaviour component;
	}
}
