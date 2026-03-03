using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008DF RID: 2271
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Check the active Transition user-specified name on a specified layer.")]
	public class GetAnimatorCurrentTransitionInfoIsUserName : FsmStateActionAnimatorBase
	{
		// Token: 0x06003285 RID: 12933 RVA: 0x00132689 File Offset: 0x00130889
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.userName = null;
			this.nameMatch = null;
			this.nameMatchEvent = null;
			this.nameDoNotMatchEvent = null;
		}

		// Token: 0x06003286 RID: 12934 RVA: 0x001326BC File Offset: 0x001308BC
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

		// Token: 0x06003287 RID: 12935 RVA: 0x00132720 File Offset: 0x00130920
		public override void OnActionUpdate()
		{
			this.IsName();
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x00132728 File Offset: 0x00130928
		private void IsName()
		{
			if (this._animator != null)
			{
				bool flag = this._animator.GetAnimatorTransitionInfo(this.layerIndex.Value).IsUserName(this.userName.Value);
				if (!this.nameMatch.IsNone)
				{
					this.nameMatch.Value = flag;
				}
				if (flag)
				{
					base.Fsm.Event(this.nameMatchEvent);
					return;
				}
				base.Fsm.Event(this.nameDoNotMatchEvent);
			}
		}

		// Token: 0x040033E6 RID: 13286
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033E7 RID: 13287
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x040033E8 RID: 13288
		[Tooltip("The user-specified name to check the transition against.")]
		public FsmString userName;

		// Token: 0x040033E9 RID: 13289
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if name matches")]
		public FsmBool nameMatch;

		// Token: 0x040033EA RID: 13290
		[Tooltip("Event send if name matches")]
		public FsmEvent nameMatchEvent;

		// Token: 0x040033EB RID: 13291
		[Tooltip("Event send if name doesn't match")]
		public FsmEvent nameDoNotMatchEvent;

		// Token: 0x040033EC RID: 13292
		private Animator _animator;
	}
}
