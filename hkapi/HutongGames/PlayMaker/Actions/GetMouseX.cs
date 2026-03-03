using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BFF RID: 3071
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the X Position of the mouse and stores it in a Float Variable.")]
	public class GetMouseX : FsmStateAction
	{
		// Token: 0x06004086 RID: 16518 RVA: 0x0016A69D File Offset: 0x0016889D
		public override void Reset()
		{
			this.storeResult = null;
			this.normalize = true;
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x0016A6AD File Offset: 0x001688AD
		public override void OnEnter()
		{
			this.DoGetMouseX();
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x0016A6AD File Offset: 0x001688AD
		public override void OnUpdate()
		{
			this.DoGetMouseX();
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x0016A6B8 File Offset: 0x001688B8
		private void DoGetMouseX()
		{
			if (this.storeResult != null)
			{
				float num = Input.mousePosition.x;
				if (this.normalize)
				{
					num /= (float)Screen.width;
				}
				this.storeResult.Value = num;
			}
		}

		// Token: 0x040044E1 RID: 17633
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		// Token: 0x040044E2 RID: 17634
		public bool normalize;
	}
}
