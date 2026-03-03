using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D33 RID: 3379
	[ActionCategory("iTween")]
	[Tooltip("Applies a jolt of force to a GameObject's scale and wobbles it back to its initial scale.")]
	public class iTweenPunchScale : iTweenFsmAction
	{
		// Token: 0x060045F4 RID: 17908 RVA: 0x0017C980 File Offset: 0x0017AB80
		public override void Reset()
		{
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.time = 1f;
			this.delay = 0f;
			this.loopType = iTween.LoopType.none;
			this.vector = new FsmVector3
			{
				UseVariable = true
			};
		}

		// Token: 0x060045F5 RID: 17909 RVA: 0x0017C9DE File Offset: 0x0017ABDE
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x060045F6 RID: 17910 RVA: 0x0017CA01 File Offset: 0x0017AC01
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060045F7 RID: 17911 RVA: 0x0017CA10 File Offset: 0x0017AC10
		private void DoiTween()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = Vector3.zero;
			if (!this.vector.IsNone)
			{
				vector = this.vector.Value;
			}
			this.itweenType = "punch";
			iTween.PunchScale(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"amount",
				vector,
				"name",
				this.id.IsNone ? "" : this.id.Value,
				"time",
				this.time.IsNone ? 1f : this.time.Value,
				"delay",
				this.delay.IsNone ? 0f : this.delay.Value,
				"looptype",
				this.loopType,
				"oncomplete",
				"iTweenOnComplete",
				"oncompleteparams",
				this.itweenID,
				"onstart",
				"iTweenOnStart",
				"onstartparams",
				this.itweenID,
				"ignoretimescale",
				!this.realTime.IsNone && this.realTime.Value
			}));
		}

		// Token: 0x04004AAA RID: 19114
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AAB RID: 19115
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AAC RID: 19116
		[RequiredField]
		[Tooltip("A vector punch range.")]
		public FsmVector3 vector;

		// Token: 0x04004AAD RID: 19117
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AAE RID: 19118
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AAF RID: 19119
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;
	}
}
