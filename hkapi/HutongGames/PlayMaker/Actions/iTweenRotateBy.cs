using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D36 RID: 3382
	[ActionCategory("iTween")]
	[Tooltip("Multiplies supplied values by 360 and rotates a GameObject by calculated amount over time.")]
	public class iTweenRotateBy : iTweenFsmAction
	{
		// Token: 0x06004602 RID: 17922 RVA: 0x0017CF08 File Offset: 0x0017B108
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
			this.speed = new FsmFloat
			{
				UseVariable = true
			};
			this.space = Space.World;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x0017CF7F File Offset: 0x0017B17F
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x0017CFA2 File Offset: 0x0017B1A2
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x0017CFB0 File Offset: 0x0017B1B0
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
			this.itweenType = "rotate";
			iTween.RotateBy(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"amount",
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
				"space",
				this.space
			}));
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x0017D1A4 File Offset: 0x0017B3A4
		public iTweenRotateBy()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004ABD RID: 19133
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004ABE RID: 19134
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004ABF RID: 19135
		[RequiredField]
		[Tooltip("A vector that will multiply current GameObjects rotation.")]
		public FsmVector3 vector;

		// Token: 0x04004AC0 RID: 19136
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AC1 RID: 19137
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AC2 RID: 19138
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004AC3 RID: 19139
		[Tooltip("For the shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004AC4 RID: 19140
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004AC5 RID: 19141
		public Space space;
	}
}
