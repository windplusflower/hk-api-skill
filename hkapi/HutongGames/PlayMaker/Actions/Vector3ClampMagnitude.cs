using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D15 RID: 3349
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Clamps the Magnitude of Vector3 Variable.")]
	public class Vector3ClampMagnitude : FsmStateAction
	{
		// Token: 0x06004572 RID: 17778 RVA: 0x00179152 File Offset: 0x00177352
		public override void Reset()
		{
			this.vector3Variable = null;
			this.maxLength = null;
			this.everyFrame = false;
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00179169 File Offset: 0x00177369
		public override void OnEnter()
		{
			this.DoVector3ClampMagnitude();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x0017917F File Offset: 0x0017737F
		public override void OnUpdate()
		{
			this.DoVector3ClampMagnitude();
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00179187 File Offset: 0x00177387
		private void DoVector3ClampMagnitude()
		{
			this.vector3Variable.Value = Vector3.ClampMagnitude(this.vector3Variable.Value, this.maxLength.Value);
		}

		// Token: 0x040049D5 RID: 18901
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040049D6 RID: 18902
		[RequiredField]
		public FsmFloat maxLength;

		// Token: 0x040049D7 RID: 18903
		public bool everyFrame;
	}
}
