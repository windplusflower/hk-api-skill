using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008DB RID: 2267
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Check the current State name on a specified layer, this is more than the layer name, it holds the current state as well.")]
	public class GetAnimatorCurrentStateInfoIsName : FsmStateActionAnimatorBase
	{
		// Token: 0x06003271 RID: 12913 RVA: 0x001321A8 File Offset: 0x001303A8
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.name = null;
			this.nameMatchEvent = null;
			this.nameDoNotMatchEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x06003272 RID: 12914 RVA: 0x001321DC File Offset: 0x001303DC
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
			this.IsName();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00132240 File Offset: 0x00130440
		public override void OnActionUpdate()
		{
			this.IsName();
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00132248 File Offset: 0x00130448
		private void IsName()
		{
			if (this._animator != null)
			{
				AnimatorStateInfo currentAnimatorStateInfo = this._animator.GetCurrentAnimatorStateInfo(this.layerIndex.Value);
				if (!this.isMatching.IsNone)
				{
					this.isMatching.Value = currentAnimatorStateInfo.IsName(this.name.Value);
				}
				if (currentAnimatorStateInfo.IsName(this.name.Value))
				{
					base.Fsm.Event(this.nameMatchEvent);
					return;
				}
				base.Fsm.Event(this.nameDoNotMatchEvent);
			}
		}

		// Token: 0x040033CA RID: 13258
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component and a PlayMakerAnimatorProxy component are required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033CB RID: 13259
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x040033CC RID: 13260
		[Tooltip("The name to check the layer against.")]
		public FsmString name;

		// Token: 0x040033CD RID: 13261
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if name matches")]
		public FsmBool isMatching;

		// Token: 0x040033CE RID: 13262
		[Tooltip("Event send if name matches")]
		public FsmEvent nameMatchEvent;

		// Token: 0x040033CF RID: 13263
		[Tooltip("Event send if name doesn't match")]
		public FsmEvent nameDoNotMatchEvent;

		// Token: 0x040033D0 RID: 13264
		private Animator _animator;
	}
}
