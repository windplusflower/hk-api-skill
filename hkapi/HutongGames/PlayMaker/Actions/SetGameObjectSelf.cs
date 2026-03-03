using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CBE RID: 3262
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Sets the value of a Game Object Variable.")]
	public class SetGameObjectSelf : FsmStateAction
	{
		// Token: 0x060043F3 RID: 17395 RVA: 0x00174A15 File Offset: 0x00172C15
		public override void Reset()
		{
			this.variable = null;
			this.gameObject = new FsmOwnerDefault();
			this.everyFrame = false;
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00174A30 File Offset: 0x00172C30
		public override void OnEnter()
		{
			GameObject safe = this.gameObject.GetSafe(this);
			if (safe != null)
			{
				this.variable.Value = safe;
			}
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00174A70 File Offset: 0x00172C70
		public override void OnUpdate()
		{
			GameObject safe = this.gameObject.GetSafe(this);
			if (safe != null)
			{
				this.variable.Value = safe;
			}
		}

		// Token: 0x0400485A RID: 18522
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmGameObject variable;

		// Token: 0x0400485B RID: 18523
		public FsmOwnerDefault gameObject;

		// Token: 0x0400485C RID: 18524
		public bool everyFrame;
	}
}
