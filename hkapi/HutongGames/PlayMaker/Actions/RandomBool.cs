using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C69 RID: 3177
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Bool Variable to True or False randomly.")]
	public class RandomBool : FsmStateAction
	{
		// Token: 0x06004274 RID: 17012 RVA: 0x0016FE41 File Offset: 0x0016E041
		public override void Reset()
		{
			this.storeResult = null;
		}

		// Token: 0x06004275 RID: 17013 RVA: 0x0016FE4A File Offset: 0x0016E04A
		public override void OnEnter()
		{
			this.storeResult.Value = (UnityEngine.Random.Range(0, 100) < 50);
			base.Finish();
		}

		// Token: 0x040046BA RID: 18106
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;
	}
}
