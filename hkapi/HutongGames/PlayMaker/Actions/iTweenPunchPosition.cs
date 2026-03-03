using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D31 RID: 3377
	[ActionCategory("iTween")]
	[Tooltip("Applies a jolt of force to a GameObject's position and wobbles it back to its initial position.")]
	public class iTweenPunchPosition : iTweenFsmAction
	{
		// Token: 0x060045EA RID: 17898 RVA: 0x0017C4AC File Offset: 0x0017A6AC
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
			this.axis = iTweenFsmAction.AxisRestriction.none;
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x0017C518 File Offset: 0x0017A718
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x0017C53B File Offset: 0x0017A73B
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x0017C54C File Offset: 0x0017A74C
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
			iTween.PunchPosition(ownerDefaultTarget, iTween.Hash(new object[]
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
				this.space,
				"axis",
				(this.axis == iTweenFsmAction.AxisRestriction.none) ? "" : Enum.GetName(typeof(iTweenFsmAction.AxisRestriction), this.axis)
			}));
		}

		// Token: 0x04004A9B RID: 19099
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004A9C RID: 19100
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004A9D RID: 19101
		[RequiredField]
		[Tooltip("A vector punch range.")]
		public FsmVector3 vector;

		// Token: 0x04004A9E RID: 19102
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004A9F RID: 19103
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AA0 RID: 19104
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004AA1 RID: 19105
		public Space space;

		// Token: 0x04004AA2 RID: 19106
		[Tooltip("Restricts rotation to the supplied axis only.")]
		public iTweenFsmAction.AxisRestriction axis;
	}
}
