using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C28 RID: 3112
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Measures the Distance betweens 2 Game Objects and stores the result in a Float Variable. Y axis only.")]
	public class GetYDistance : FsmStateAction
	{
		// Token: 0x0600413A RID: 16698 RVA: 0x0016BFE4 File Offset: 0x0016A1E4
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.storeResult = null;
			this.everyFrame = true;
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x0016C002 File Offset: 0x0016A202
		public override void OnEnter()
		{
			this.DoGetDistance();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x0016C018 File Offset: 0x0016A218
		public override void OnUpdate()
		{
			this.DoGetDistance();
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x0016C020 File Offset: 0x0016A220
		private void DoGetDistance()
		{
			GameObject gameObject = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (gameObject == null || this.target.Value == null || this.storeResult == null)
			{
				return;
			}
			float num = gameObject.transform.position.y - this.target.Value.transform.position.y;
			if (num < 0f)
			{
				num *= -1f;
			}
			this.storeResult.Value = num;
		}

		// Token: 0x0400457D RID: 17789
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400457E RID: 17790
		[RequiredField]
		public FsmGameObject target;

		// Token: 0x0400457F RID: 17791
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		// Token: 0x04004580 RID: 17792
		public bool everyFrame;
	}
}
