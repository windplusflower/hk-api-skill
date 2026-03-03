using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A59 RID: 2649
	[ActionCategory("Trail Renderer")]
	[Tooltip("Set trail renderer parameters")]
	public class SetTrailRenderer : FsmStateAction
	{
		// Token: 0x0600393C RID: 14652 RVA: 0x0014D92D File Offset: 0x0014BB2D
		public override void Reset()
		{
			this.gameObject = null;
			this.startWidth = new FsmFloat
			{
				UseVariable = true
			};
			this.endWidth = new FsmFloat
			{
				UseVariable = true
			};
			this.time = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x0014D96C File Offset: 0x0014BB6C
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.trail = ownerDefaultTarget.GetComponent<TrailRenderer>();
				if (this.trail == null)
				{
					base.Finish();
				}
				this.DoSetTrail();
				if (!this.everyFrame)
				{
					base.Finish();
					return;
				}
			}
			else
			{
				base.Finish();
			}
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x0014D9CE File Offset: 0x0014BBCE
		public override void OnUpdate()
		{
			this.DoSetTrail();
		}

		// Token: 0x0600393F RID: 14655 RVA: 0x0014D9D8 File Offset: 0x0014BBD8
		private void DoSetTrail()
		{
			if (!this.startWidth.IsNone)
			{
				this.trail.startWidth = this.startWidth.Value;
			}
			if (!this.endWidth.IsNone)
			{
				this.trail.endWidth = this.endWidth.Value;
			}
			if (!this.time.IsNone)
			{
				this.trail.time = this.time.Value;
			}
		}

		// Token: 0x04003BDD RID: 15325
		[RequiredField]
		[Tooltip("The particle emitting GameObject")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BDE RID: 15326
		public FsmFloat startWidth;

		// Token: 0x04003BDF RID: 15327
		public FsmFloat endWidth;

		// Token: 0x04003BE0 RID: 15328
		public FsmFloat time;

		// Token: 0x04003BE1 RID: 15329
		public bool everyFrame;

		// Token: 0x04003BE2 RID: 15330
		private TrailRenderer trail;
	}
}
