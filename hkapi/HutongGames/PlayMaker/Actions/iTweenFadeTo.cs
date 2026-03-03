using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A7B RID: 2683
	[ActionCategory("iTween")]
	[Tooltip("Changes a GameObject's opacity over time.")]
	public class iTweenFadeTo : iTweenFsmAction
	{
		// Token: 0x060039D8 RID: 14808 RVA: 0x001517A8 File Offset: 0x0014F9A8
		public override void Reset()
		{
			base.Reset();
			this.id = new FsmString
			{
				UseVariable = true
			};
			this.alpha = 0f;
			this.includeChildren = true;
			this.namedValueColor = "_Color";
			this.time = 1f;
			this.delay = 0f;
		}

		// Token: 0x060039D9 RID: 14809 RVA: 0x00151819 File Offset: 0x0014FA19
		public override void OnEnter()
		{
			base.OnEnteriTween(this.gameObject);
			if (this.loopType != iTween.LoopType.none)
			{
				base.IsLoop(true);
			}
			this.DoiTween();
		}

		// Token: 0x060039DA RID: 14810 RVA: 0x0015183C File Offset: 0x0014FA3C
		public override void OnExit()
		{
			base.OnExitiTween(this.gameObject);
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x0015184C File Offset: 0x0014FA4C
		private void DoiTween()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.itweenType = "fade";
			iTween.FadeTo(ownerDefaultTarget, iTween.Hash(new object[]
			{
				"name",
				this.id.IsNone ? "" : this.id.Value,
				"alpha",
				this.alpha.Value,
				"includechildren",
				this.includeChildren.IsNone || this.includeChildren.Value,
				"NamedValueColor",
				this.namedValueColor.Value,
				"time",
				this.time.Value,
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

		// Token: 0x060039DC RID: 14812 RVA: 0x00151A16 File Offset: 0x0014FC16
		public iTweenFadeTo()
		{
			this.easeType = iTween.EaseType.linear;
			base..ctor();
		}

		// Token: 0x04003CED RID: 15597
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003CEE RID: 15598
		[Tooltip("iTween ID. If set you can use iTween Stop action to stop it by its id.")]
		public FsmString id;

		// Token: 0x04003CEF RID: 15599
		[Tooltip("The end alpha value of the animation.")]
		public FsmFloat alpha;

		// Token: 0x04003CF0 RID: 15600
		[Tooltip("Whether or not to include children of this GameObject. True by default.")]
		public FsmBool includeChildren;

		// Token: 0x04003CF1 RID: 15601
		[Tooltip("Which color of a shader to use. Uses '_Color' by default.")]
		public FsmString namedValueColor;

		// Token: 0x04003CF2 RID: 15602
		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		// Token: 0x04003CF3 RID: 15603
		[Tooltip("The time in seconds the animation will wait before beginning.")]
		public FsmFloat delay;

		// Token: 0x04003CF4 RID: 15604
		[Tooltip("The shape of the easing curve applied to the animation.")]
		public iTween.EaseType easeType;

		// Token: 0x04003CF5 RID: 15605
		[Tooltip("The type of loop to apply once the animation has completed.")]
		public iTween.LoopType loopType;
	}
}
