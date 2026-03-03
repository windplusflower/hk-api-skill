using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008EC RID: 2284
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the Animator controller layer count")]
	public class GetAnimatorLayerCount : FsmStateAction
	{
		// Token: 0x060032BE RID: 12990 RVA: 0x0013317D File Offset: 0x0013137D
		public override void Reset()
		{
			this.gameObject = null;
			this.layerCount = null;
		}

		// Token: 0x060032BF RID: 12991 RVA: 0x00133190 File Offset: 0x00131390
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
			this.DoGetLayerCount();
			base.Finish();
		}

		// Token: 0x060032C0 RID: 12992 RVA: 0x001331EC File Offset: 0x001313EC
		private void DoGetLayerCount()
		{
			if (this._animator == null)
			{
				return;
			}
			this.layerCount.Value = this._animator.layerCount;
		}

		// Token: 0x04003425 RID: 13349
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The Target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003426 RID: 13350
		[ActionSection("Results")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Animator controller layer count")]
		public FsmInt layerCount;

		// Token: 0x04003427 RID: 13351
		private Animator _animator;
	}
}
