using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008EB RID: 2283
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns true if a parameter is controlled by an additional curve on an animation")]
	public class GetAnimatorIsParameterControlledByCurve : FsmStateAction
	{
		// Token: 0x060032BA RID: 12986 RVA: 0x00133096 File Offset: 0x00131296
		public override void Reset()
		{
			this.gameObject = null;
			this.parameterName = null;
			this.isControlledByCurve = null;
			this.isControlledByCurveEvent = null;
			this.isNotControlledByCurveEvent = null;
		}

		// Token: 0x060032BB RID: 12987 RVA: 0x001330BC File Offset: 0x001312BC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator == null)
			{
				base.Finish();
				return;
			}
			this.DoCheckIsParameterControlledByCurve();
			base.Finish();
		}

		// Token: 0x060032BC RID: 12988 RVA: 0x00133118 File Offset: 0x00131318
		private void DoCheckIsParameterControlledByCurve()
		{
			if (this._animator == null)
			{
				return;
			}
			bool flag = this._animator.IsParameterControlledByCurve(this.parameterName.Value);
			this.isControlledByCurve.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.isControlledByCurveEvent);
				return;
			}
			base.Fsm.Event(this.isNotControlledByCurveEvent);
		}

		// Token: 0x0400341F RID: 13343
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003420 RID: 13344
		[Tooltip("The parameter's name")]
		public FsmString parameterName;

		// Token: 0x04003421 RID: 13345
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if controlled by curve")]
		public FsmBool isControlledByCurve;

		// Token: 0x04003422 RID: 13346
		[Tooltip("Event send if controlled by curve")]
		public FsmEvent isControlledByCurveEvent;

		// Token: 0x04003423 RID: 13347
		[Tooltip("Event send if not controlled by curve")]
		public FsmEvent isNotControlledByCurveEvent;

		// Token: 0x04003424 RID: 13348
		private Animator _animator;
	}
}
