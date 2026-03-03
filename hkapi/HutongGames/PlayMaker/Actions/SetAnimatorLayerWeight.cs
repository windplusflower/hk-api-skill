using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000902 RID: 2306
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Sets the layer's current weight")]
	public class SetAnimatorLayerWeight : FsmStateAction
	{
		// Token: 0x06003328 RID: 13096 RVA: 0x001346C2 File Offset: 0x001328C2
		public override void Reset()
		{
			this.gameObject = null;
			this.layerIndex = null;
			this.layerWeight = null;
			this.everyFrame = false;
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x001346E0 File Offset: 0x001328E0
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
			this.DoLayerWeight();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00134744 File Offset: 0x00132944
		public override void OnUpdate()
		{
			this.DoLayerWeight();
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x0013474C File Offset: 0x0013294C
		private void DoLayerWeight()
		{
			if (this._animator == null)
			{
				return;
			}
			this._animator.SetLayerWeight(this.layerIndex.Value, this.layerWeight.Value);
		}

		// Token: 0x04003491 RID: 13457
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003492 RID: 13458
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x04003493 RID: 13459
		[RequiredField]
		[Tooltip("Sets the layer's current weight")]
		public FsmFloat layerWeight;

		// Token: 0x04003494 RID: 13460
		[Tooltip("Repeat every frame. Useful for changing over time.")]
		public bool everyFrame;

		// Token: 0x04003495 RID: 13461
		private Animator _animator;
	}
}
