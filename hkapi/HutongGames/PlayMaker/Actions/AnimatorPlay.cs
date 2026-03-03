using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D0 RID: 2256
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Plays a state. This could be used to synchronize your animation with audio or synchronize an Animator over the network.")]
	public class AnimatorPlay : FsmStateAction
	{
		// Token: 0x06003245 RID: 12869 RVA: 0x00131887 File Offset: 0x0012FA87
		public override void Reset()
		{
			this.gameObject = null;
			this.stateName = null;
			this.layer = new FsmInt
			{
				UseVariable = true
			};
			this.normalizedTime = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x001318C4 File Offset: 0x0012FAC4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			this.DoAnimatorPlay();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x00131913 File Offset: 0x0012FB13
		public override void OnUpdate()
		{
			this.DoAnimatorPlay();
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x0013191C File Offset: 0x0012FB1C
		private void DoAnimatorPlay()
		{
			if (this._animator != null)
			{
				int num = this.layer.IsNone ? -1 : this.layer.Value;
				float num2 = this.normalizedTime.IsNone ? float.NegativeInfinity : this.normalizedTime.Value;
				this._animator.Play(this.stateName.Value, num, num2);
			}
		}

		// Token: 0x04003399 RID: 13209
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400339A RID: 13210
		[Tooltip("The name of the state that will be played.")]
		public FsmString stateName;

		// Token: 0x0400339B RID: 13211
		[Tooltip("The layer where the state is.")]
		public FsmInt layer;

		// Token: 0x0400339C RID: 13212
		[Tooltip("The normalized time at which the state will play")]
		public FsmFloat normalizedTime;

		// Token: 0x0400339D RID: 13213
		[Tooltip("Repeat every frame. Useful when using normalizedTime to manually control the animation.")]
		public bool everyFrame;

		// Token: 0x0400339E RID: 13214
		private Animator _animator;
	}
}
