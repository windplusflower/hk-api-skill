using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D1F RID: 3359
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Multiplies a Vector3 variable by Time.deltaTime. Useful for frame rate independent motion.")]
	public class Vector3PerSecond : FsmStateAction
	{
		// Token: 0x06004599 RID: 17817 RVA: 0x001799FB File Offset: 0x00177BFB
		public override void Reset()
		{
			this.vector3Variable = null;
			this.everyFrame = false;
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x00179A0B File Offset: 0x00177C0B
		public override void OnEnter()
		{
			this.vector3Variable.Value = this.vector3Variable.Value * Time.deltaTime;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00179A3B File Offset: 0x00177C3B
		public override void OnUpdate()
		{
			this.vector3Variable.Value = this.vector3Variable.Value * Time.deltaTime;
		}

		// Token: 0x04004A06 RID: 18950
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x04004A07 RID: 18951
		public bool everyFrame;
	}
}
