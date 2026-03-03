using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D3C RID: 3388
	[ActionCategory("iTween")]
	[Tooltip("Instantly changes a GameObject's scale then returns it to it's starting scale over time.")]
	public class iTweenScaleFrom : iTweenFsmAction
	{
		// Token: 0x06004621 RID: 17953 RVA: 0x0017E01C File Offset: 0x0017C21C
		public override void Reset()
		{
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.transformScale = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorScale = new FsmVector3
			{
				UseVariable = true
			};
			this.time = 1f;
			this.delay = 0f;
			this.loopType = iTween.LoopType.none;
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x06004622 RID: 17954 RVA: 0x0017E09E File Offset: 0x0017C29E
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x0017E0C1 File Offset: 0x0017C2C1
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x0017E0D0 File Offset: 0x0017C2D0
		private void DoiTween()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = this.vectorScale.IsNone ? Vector3.zero : this.vectorScale.Value;
			if (!this.transformScale.IsNone && this.transformScale.Value)
			{
				vector = this.transformScale.Value.transform.localScale + vector;
			}
			this.itweenType = "scale";
			iTween.ScaleFrom(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"scale",
				vector,
				"name",
				this.id.IsNone ? "" : this.id.Value,
				this.speed.IsNone ? "time" : "speed",
				this.speed.IsNone ? (this.time.IsNone ? 1f : this.time.Value) : this.speed.Value,
				"delay",
				this.delay.IsNone ? 0f : this.delay.Value,
				"easetype",
				this.easeType,
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

		// Token: 0x06004625 RID: 17957 RVA: 0x0017E2E8 File Offset: 0x0017C4E8
		public iTweenScaleFrom()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004AF1 RID: 19185
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AF2 RID: 19186
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AF3 RID: 19187
		[Tooltip("Scale From a transform scale.")]
		public FsmGameObject transformScale;

		// Token: 0x04004AF4 RID: 19188
		[Tooltip("A scale vector the GameObject will animate From.")]
		public FsmVector3 vectorScale;

		// Token: 0x04004AF5 RID: 19189
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AF6 RID: 19190
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AF7 RID: 19191
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004AF8 RID: 19192
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004AF9 RID: 19193
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;
	}
}
