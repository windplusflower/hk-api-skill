using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D32 RID: 3378
	[ActionCategory("iTween")]
	[Tooltip("Applies a jolt of force to a GameObject's rotation and wobbles it back to its initial rotation. NOTE: Due to the way iTween utilizes the Transform.Rotate method, PunchRotation works best with single axis usage rather than punching with a Vector3.")]
	public class iTweenPunchRotation : iTweenFsmAction
	{
		// Token: 0x060045EF RID: 17903 RVA: 0x0017C738 File Offset: 0x0017A938
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
			this.space = Space.World;
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x0017C79D File Offset: 0x0017A99D
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x0017C7C0 File Offset: 0x0017A9C0
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x0017C7D0 File Offset: 0x0017A9D0
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
			iTween.PunchRotation(ownerDefaultTarget, iTween.Hash(new object[]
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
				!this.realTime.IsNone && this.realTime.Value,
				"space",
				this.space
			}));
		}

		// Token: 0x04004AA3 RID: 19107
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AA4 RID: 19108
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AA5 RID: 19109
		[RequiredField]
		[Tooltip("A vector punch range.")]
		public FsmVector3 vector;

		// Token: 0x04004AA6 RID: 19110
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AA7 RID: 19111
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AA8 RID: 19112
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004AA9 RID: 19113
		public Space space;
	}
}
