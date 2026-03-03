using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008ED RID: 2285
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the name of a layer from its index")]
	public class GetAnimatorLayerName : FsmStateAction
	{
		// Token: 0x060032C2 RID: 12994 RVA: 0x00133213 File Offset: 0x00131413
		public override void Reset()
		{
			this.gameObject = null;
			this.layerIndex = null;
			this.layerName = null;
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x0013322C File Offset: 0x0013142C
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
			this.DoGetLayerName();
			base.Finish();
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x00133288 File Offset: 0x00131488
		private void DoGetLayerName()
		{
			if (this._animator == null)
			{
				return;
			}
			this.layerName.Value = this._animator.GetLayerName(this.layerIndex.Value);
		}

		// Token: 0x04003428 RID: 13352
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003429 RID: 13353
		[RequiredField]
		[Tooltip("The layer index")]
		public FsmInt layerIndex;

		// Token: 0x0400342A RID: 13354
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer name")]
		public FsmString layerName;

		// Token: 0x0400342B RID: 13355
		private Animator _animator;
	}
}
