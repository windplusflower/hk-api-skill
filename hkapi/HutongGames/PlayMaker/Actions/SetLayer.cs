using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC6 RID: 3270
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets a Game Object's Layer.")]
	public class SetLayer : FsmStateAction
	{
		// Token: 0x06004414 RID: 17428 RVA: 0x00174DAA File Offset: 0x00172FAA
		public override void Reset()
		{
			this.gameObject = null;
			this.layer = 0;
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x00174DBA File Offset: 0x00172FBA
		public override void OnEnter()
		{
			this.DoSetLayer();
			base.Finish();
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x00174DC8 File Offset: 0x00172FC8
		private void DoSetLayer()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			ownerDefaultTarget.layer = this.layer;
		}

		// Token: 0x04004870 RID: 18544
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004871 RID: 18545
		[UIHint(UIHint.Layer)]
		public int layer;
	}
}
