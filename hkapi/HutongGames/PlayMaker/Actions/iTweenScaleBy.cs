using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D3B RID: 3387
	[ActionCategory("iTween")]
	[Tooltip("Multiplies a GameObject's scale over time.")]
	public class iTweenScaleBy : iTweenFsmAction
	{
		// Token: 0x0600461C RID: 17948 RVA: 0x0017DD8C File Offset: 0x0017BF8C
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
		}

		// Token: 0x0600461D RID: 17949 RVA: 0x0017DDFC File Offset: 0x0017BFFC
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x0017DE1F File Offset: 0x0017C01F
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x0017DE30 File Offset: 0x0017C030
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
			this.itweenType = "scale";
			iTween.ScaleBy(ownerDefaultTarget, iTween.Hash(new object[]
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
				!this.realTime.IsNone && this.realTime.Value
			}));
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x0017E00C File Offset: 0x0017C20C
		public iTweenScaleBy()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04004AE9 RID: 19177
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004AEA RID: 19178
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04004AEB RID: 19179
		[RequiredField]
		[Tooltip("A vector that will multiply current GameObjects scale.")]
		public FsmVector3 vector;

		// Token: 0x04004AEC RID: 19180
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04004AED RID: 19181
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04004AEE RID: 19182
		[Tooltip("Can be used instead of time to allow animation based on speed. When you define speed the time variable is ignored.")]
		public FsmFloat speed;

		// Token: 0x04004AEF RID: 19183
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04004AF0 RID: 19184
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;
	}
}
