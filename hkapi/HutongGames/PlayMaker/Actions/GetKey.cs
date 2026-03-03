using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF2 RID: 3058
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the pressed state of a Key.")]
	public class GetKey : FsmStateAction
	{
		// Token: 0x06004052 RID: 16466 RVA: 0x0016A026 File Offset: 0x00168226
		public override void Reset()
		{
			this.key = KeyCode.None;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0016A03D File Offset: 0x0016823D
		public override void OnEnter()
		{
			this.DoGetKey();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0016A053 File Offset: 0x00168253
		public override void OnUpdate()
		{
			this.DoGetKey();
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0016A05B File Offset: 0x0016825B
		private void DoGetKey()
		{
			this.storeResult.Value = Input.GetKey(this.key);
		}

		// Token: 0x040044B7 RID: 17591
		[RequiredField]
		[Tooltip("The key to test.")]
		public KeyCode key;

		// Token: 0x040044B8 RID: 17592
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store if the key is down (True) or up (False).")]
		public FsmBool storeResult;

		// Token: 0x040044B9 RID: 17593
		[Tooltip("Repeat every frame. Useful if you're waiting for a key press/release.")]
		public bool everyFrame;
	}
}
