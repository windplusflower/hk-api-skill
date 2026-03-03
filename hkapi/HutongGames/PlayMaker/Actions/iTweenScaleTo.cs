using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D3D RID: 3389
	[ActionCategory("iTween")]
	[Tooltip("Changes a GameObject's scale over time.")]
	public class iTweenScaleTo : iTweenFsmAction
	{
		// Token: 0x06004626 RID: 17958 RVA: 0x0017E2F8 File Offset: 0x0017C4F8
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

		// Token: 0x06004627 RID: 17959 RVA: 0x0017E37A File Offset: 0x0017C57A
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x0017E39D File Offset: 0x0017C59D
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x0017E3AC File Offset: 0x0017C5AC
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
			iTween.ScaleTo(ownerDefaultTarget, iTween.Hash(new object[]
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

		// Token: 0x0600462A RID: 17962 RVA: 0x0017E5C4 File Offset: 0x0017C7C4
		public iTweenScaleTo()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004AFA RID: 19194
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AFB RID: 19195
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AFC RID: 19196
		[Tooltip("Scale To a transform scale.")]
		public FsmGameObject transformScale;

		// Token: 0x04004AFD RID: 19197
		[Tooltip("A scale vector the GameObject will animate To.")]
		public FsmVector3 vectorScale;

		// Token: 0x04004AFE RID: 19198
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AFF RID: 19199
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004B00 RID: 19200
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004B01 RID: 19201
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004B02 RID: 19202
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;
	}
}
