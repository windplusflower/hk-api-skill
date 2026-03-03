using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D3F RID: 3391
	[ActionCategory("iTween")]
	[Tooltip("Randomly shakes a GameObject's position by a diminishing amount over time.")]
	public class iTweenShakePosition : iTweenFsmAction
	{
		// Token: 0x06004631 RID: 17969 RVA: 0x0017E81C File Offset: 0x0017CA1C
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

		// Token: 0x06004632 RID: 17970 RVA: 0x0017E888 File Offset: 0x0017CA88
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x0017E8AB File Offset: 0x0017CAAB
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x06004634 RID: 17972 RVA: 0x0017E8BC File Offset: 0x0017CABC
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
			iTween.ShakePosition(ownerDefaultTarget, iTween.Hash(new object[]
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

		// Token: 0x04004B09 RID: 19209
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004B0A RID: 19210
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004B0B RID: 19211
		[RequiredField]
		[Tooltip("A vector shake range.")]
		public FsmVector3 vector;

		// Token: 0x04004B0C RID: 19212
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004B0D RID: 19213
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004B0E RID: 19214
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;

		// Token: 0x04004B0F RID: 19215
		public Space space;

		// Token: 0x04004B10 RID: 19216
		[Tooltip("Restricts rotation to the supplied axis only. Just put there strinc like 'x' or 'xz'")]
		public iTweenFsmAction.AxisRestriction axis;
	}
}
