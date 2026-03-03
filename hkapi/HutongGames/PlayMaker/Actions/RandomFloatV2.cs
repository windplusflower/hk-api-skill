using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A0A RID: 2570
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float Variable to a random value between Min/Max.")]
	public class RandomFloatV2 : FsmStateAction
	{
		// Token: 0x060037EA RID: 14314 RVA: 0x0014868F File Offset: 0x0014688F
		public override void Reset()
		{
			this.min = 0f;
			this.max = 1f;
			this.storeResult = null;
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x001486B8 File Offset: 0x001468B8
		public override void OnEnter()
		{
			this.Randomise();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x001486CE File Offset: 0x001468CE
		public override void OnFixedUpdate()
		{
			this.Randomise();
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x001486D6 File Offset: 0x001468D6
		private void Randomise()
		{
			this.storeResult.Value = UnityEngine.Random.Range(this.min.Value, this.max.Value);
		}

		// Token: 0x04003A70 RID: 14960
		[RequiredField]
		public FsmFloat min;

		// Token: 0x04003A71 RID: 14961
		[RequiredField]
		public FsmFloat max;

		// Token: 0x04003A72 RID: 14962
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		// Token: 0x04003A73 RID: 14963
		public bool everyFrame;
	}
}
