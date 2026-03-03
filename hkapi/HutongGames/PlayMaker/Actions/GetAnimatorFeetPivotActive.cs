using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008E1 RID: 2273
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the feet pivot. At 0% blending point is body mass center. At 100% blending point is feet pivot")]
	public class GetAnimatorFeetPivotActive : FsmStateAction
	{
		// Token: 0x0600328F RID: 12943 RVA: 0x0013286D File Offset: 0x00130A6D
		public override void Reset()
		{
			this.gameObject = null;
			this.feetPivotActive = null;
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x00132880 File Offset: 0x00130A80
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
			this.DoGetFeetPivotActive();
			base.Finish();
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x001328DC File Offset: 0x00130ADC
		private void DoGetFeetPivotActive()
		{
			if (this._animator == null)
			{
				return;
			}
			this.feetPivotActive.Value = this._animator.feetPivotActive;
		}

		// Token: 0x040033F2 RID: 13298
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033F3 RID: 13299
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The feet pivot Blending. At 0% blending point is body mass center. At 100% blending point is feet pivot")]
		public FsmFloat feetPivotActive;

		// Token: 0x040033F4 RID: 13300
		private Animator _animator;
	}
}
