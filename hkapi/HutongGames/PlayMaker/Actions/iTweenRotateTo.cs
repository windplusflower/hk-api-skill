using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D38 RID: 3384
	[ActionCategory("iTween")]
	[Tooltip("Rotates a GameObject to the supplied Euler angles in degrees over time.")]
	public class iTweenRotateTo : iTweenFsmAction
	{
		// Token: 0x0600460C RID: 17932 RVA: 0x0017D4D8 File Offset: 0x0017B6D8
		public override void Reset()
		{
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.transformRotation = new FsmGameObject
			{
				UseVariable = true
			};
			this.vectorRotation = new FsmVector3
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
			this.space = Space.World;
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x0017D561 File Offset: 0x0017B761
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x0017D584 File Offset: 0x0017B784
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x0017D594 File Offset: 0x0017B794
		private void DoiTween()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 vector = this.vectorRotation.IsNone ? Vector3.zero : this.vectorRotation.Value;
			if (!this.transformRotation.IsNone && this.transformRotation.Value)
			{
				vector = ((this.space == Space.World) ? (this.transformRotation.Value.transform.eulerAngles + vector) : (this.transformRotation.Value.transform.localEulerAngles + vector));
			}
			this.itweenType = "rotate";
			iTween.RotateTo(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"rotation",
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
				!this.realTime.IsNone && this.realTime.Value,
				"islocal",
				this.space == Space.Self
			}));
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x0017D7EC File Offset: 0x0017B9EC
		public iTweenRotateTo()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004AD0 RID: 19152
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AD1 RID: 19153
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AD2 RID: 19154
		[Tooltip("Rotate to a transform rotation.")]
		public FsmGameObject transformRotation;

		// Token: 0x04004AD3 RID: 19155
		[Tooltip("A rotation the GameObject will animate from.")]
		public FsmVector3 vectorRotation;

		// Token: 0x04004AD4 RID: 19156
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AD5 RID: 19157
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AD6 RID: 19158
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004AD7 RID: 19159
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004AD8 RID: 19160
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004AD9 RID: 19161
		[Tooltip("Whether to animate in local or world space.")]
		public Space space;
	}
}
