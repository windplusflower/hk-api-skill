using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C00 RID: 3072
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the Y Position of the mouse and stores it in a Float Variable.")]
	public class GetMouseY : FsmStateAction
	{
		// Token: 0x0600408B RID: 16523 RVA: 0x0016A6F5 File Offset: 0x001688F5
		public override void Reset()
		{
			this.storeResult = null;
			this.normalize = true;
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x0016A705 File Offset: 0x00168905
		public override void OnEnter()
		{
			this.DoGetMouseY();
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x0016A705 File Offset: 0x00168905
		public override void OnUpdate()
		{
			this.DoGetMouseY();
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x0016A710 File Offset: 0x00168910
		private void DoGetMouseY()
		{
			if (this.storeResult != null)
			{
				float num = Input.mousePosition.y;
				if (this.normalize)
				{
					num /= (float)Screen.height;
				}
				this.storeResult.Value = num;
			}
		}

		// Token: 0x040044E3 RID: 17635
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		// Token: 0x040044E4 RID: 17636
		public bool normalize;
	}
}
