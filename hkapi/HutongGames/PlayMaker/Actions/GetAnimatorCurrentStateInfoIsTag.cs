using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008DC RID: 2268
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Does tag match the tag of the active state in the statemachine")]
	public class GetAnimatorCurrentStateInfoIsTag : FsmStateActionAnimatorBase
	{
		// Token: 0x06003276 RID: 12918 RVA: 0x001322DB File Offset: 0x001304DB
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.layerIndex = null;
			this.tag = null;
			this.tagMatch = null;
			this.tagMatchEvent = null;
			this.tagDoNotMatchEvent = null;
			this.everyFrame = false;
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00132314 File Offset: 0x00130514
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
			this.IsTag();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00132378 File Offset: 0x00130578
		public override void OnActionUpdate()
		{
			this.IsTag();
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00132380 File Offset: 0x00130580
		private void IsTag()
		{
			if (this._animator != null)
			{
				if (this._animator.GetCurrentAnimatorStateInfo(this.layerIndex.Value).IsTag(this.tag.Value))
				{
					this.tagMatch.Value = true;
					base.Fsm.Event(this.tagMatchEvent);
					return;
				}
				this.tagMatch.Value = false;
				base.Fsm.Event(this.tagDoNotMatchEvent);
			}
		}

		// Token: 0x040033D1 RID: 13265
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033D2 RID: 13266
		[RequiredField]
		[Tooltip("The layer's index")]
		public FsmInt layerIndex;

		// Token: 0x040033D3 RID: 13267
		[Tooltip("The tag to check the layer against.")]
		public FsmString tag;

		// Token: 0x040033D4 RID: 13268
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if tag matches")]
		public FsmBool tagMatch;

		// Token: 0x040033D5 RID: 13269
		[Tooltip("Event send if tag matches")]
		public FsmEvent tagMatchEvent;

		// Token: 0x040033D6 RID: 13270
		[Tooltip("Event send if tag matches")]
		public FsmEvent tagDoNotMatchEvent;

		// Token: 0x040033D7 RID: 13271
		private Animator _animator;
	}
}
