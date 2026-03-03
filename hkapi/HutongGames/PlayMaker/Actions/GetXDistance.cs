using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C27 RID: 3111
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Measures the Distance betweens 2 Game Objects and stores the result in a Float Variable. X axis only.")]
	public class GetXDistance : FsmStateAction
	{
		// Token: 0x06004135 RID: 16693 RVA: 0x0016BF08 File Offset: 0x0016A108
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.storeResult = null;
			this.everyFrame = true;
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x0016BF26 File Offset: 0x0016A126
		public override void OnEnter()
		{
			this.DoGetDistance();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x0016BF3C File Offset: 0x0016A13C
		public override void OnUpdate()
		{
			this.DoGetDistance();
		}

		// Token: 0x06004138 RID: 16696 RVA: 0x0016BF44 File Offset: 0x0016A144
		private void DoGetDistance()
		{
			GameObject gameObject = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (gameObject == null || this.target.Value == null || this.storeResult == null)
			{
				return;
			}
			float num = gameObject.transform.position.x - this.target.Value.transform.position.x;
			if (num < 0f)
			{
				num *= -1f;
			}
			this.storeResult.Value = num;
		}

		// Token: 0x04004579 RID: 17785
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400457A RID: 17786
		[RequiredField]
		public FsmGameObject target;

		// Token: 0x0400457B RID: 17787
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		// Token: 0x0400457C RID: 17788
		public bool everyFrame;
	}
}
