using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D41 RID: 3393
	[ActionCategory("iTween")]
	[Tooltip("Randomly shakes a GameObject's scale by a diminishing amount over time.")]
	public class iTweenShakeScale : iTweenFsmAction
	{
		// Token: 0x0600463B RID: 17979 RVA: 0x0017ECE8 File Offset: 0x0017CEE8
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

		// Token: 0x0600463C RID: 17980 RVA: 0x0017ED46 File Offset: 0x0017CF46
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x0017ED69 File Offset: 0x0017CF69
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x0017ED78 File Offset: 0x0017CF78
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
			this.itweenType = "shake";
			iTween.ShakeScale(ownerDefaultTarget, iTween.Hash(new object[]
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

		// Token: 0x04004B18 RID: 19224
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004B19 RID: 19225
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004B1A RID: 19226
		[RequiredField]
		[Tooltip("A vector shake range.")]
		public FsmVector3 vector;

		// Token: 0x04004B1B RID: 19227
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004B1C RID: 19228
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004B1D RID: 19229
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;
	}
}
