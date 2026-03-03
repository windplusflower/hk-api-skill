using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008DE RID: 2270
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Check the active Transition name on a specified layer. Format is 'CURRENT_STATE -> NEXT_STATE'.")]
	public class GetAnimatorCurrentTransitionInfoIsName : FsmStateActionAnimatorBase
	{
		// Token: 0x06003280 RID: 12928 RVA: 0x00132568 File Offset: 0x00130768
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.name = null;
			this.nameMatch = null;
			this.nameMatchEvent = null;
			this.nameDoNotMatchEvent = null;
		}

		// Token: 0x06003281 RID: 12929 RVA: 0x0013259C File Offset: 0x0013079C
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

		// Token: 0x06003282 RID: 12930 RVA: 0x00132600 File Offset: 0x00130800
		public override void OnActionUpdate()
		{
			this.IsName();
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x00132608 File Offset: 0x00130808
		private void IsName()
		{
			if (this._animator != null)
			{
				if (this._animator.GetAnimatorTransitionInfo(this.layerIndex.Value).IsName(this.name.Value))
				{
					this.nameMatch.Value = true;
					base.Fsm.Event(this.nameMatchEvent);
					return;
				}
				this.nameMatch.Value = false;
				base.Fsm.Event(this.nameDoNotMatchEvent);
			}
		}

		// Token: 0x040033DF RID: 13279
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033E0 RID: 13280
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x040033E1 RID: 13281
		[Tooltip("The name to check the transition against.")]
		public FsmString name;

		// Token: 0x040033E2 RID: 13282
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if name matches")]
		public FsmBool nameMatch;

		// Token: 0x040033E3 RID: 13283
		[Tooltip("Event send if name matches")]
		public FsmEvent nameMatchEvent;

		// Token: 0x040033E4 RID: 13284
		[Tooltip("Event send if name doesn't match")]
		public FsmEvent nameDoNotMatchEvent;

		// Token: 0x040033E5 RID: 13285
		private Animator _animator;
	}
}
