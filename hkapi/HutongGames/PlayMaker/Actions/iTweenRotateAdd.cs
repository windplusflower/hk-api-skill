using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D35 RID: 3381
	[ActionCategory("iTween")]
	[Tooltip("Adds supplied Euler angles in degrees to a GameObject's rotation over time.")]
	public class iTweenRotateAdd : iTweenFsmAction
	{
		// Token: 0x060045FD RID: 17917 RVA: 0x0017CC5C File Offset: 0x0017AE5C
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

		// Token: 0x060045FE RID: 17918 RVA: 0x0017CCD3 File Offset: 0x0017AED3
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x0017CCF6 File Offset: 0x0017AEF6
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x0017CD04 File Offset: 0x0017AF04
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
			iTween.RotateAdd(ownerDefaultTarget, iTween.Hash(new object[]
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

		// Token: 0x06004601 RID: 17921 RVA: 0x0017CEF8 File Offset: 0x0017B0F8
		public iTweenRotateAdd()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004AB4 RID: 19124
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AB5 RID: 19125
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AB6 RID: 19126
		[RequiredField]
		[Tooltip("A vector that will be added to a GameObjects rotation.")]
		public FsmVector3 vector;

		// Token: 0x04004AB7 RID: 19127
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AB8 RID: 19128
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AB9 RID: 19129
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004ABA RID: 19130
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004ABB RID: 19131
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004ABC RID: 19132
		public Space space;
	}
}
