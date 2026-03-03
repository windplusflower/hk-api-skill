using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008EE RID: 2286
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the layer's current weight")]
	public class GetAnimatorLayerWeight : FsmStateActionAnimatorBase
	{
		// Token: 0x060032C6 RID: 12998 RVA: 0x001332BA File Offset: 0x001314BA
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.layerWeight = null;
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x001332D8 File Offset: 0x001314D8
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
			this.GetLayerWeight();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x0013333C File Offset: 0x0013153C
		public override void OnActionUpdate()
		{
			this.GetLayerWeight();
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00133344 File Offset: 0x00131544
		private void GetLayerWeight()
		{
			if (this._animator != null)
			{
				this.layerWeight.Value = this._animator.GetLayerWeight(this.layerIndex.Value);
			}
		}

		// Token: 0x0400342C RID: 13356
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400342D RID: 13357
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x0400342E RID: 13358
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer's current weight")]
		public FsmFloat layerWeight;

		// Token: 0x0400342F RID: 13359
		private Animator _animator;
	}
}
