using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D13 RID: 3347
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Adds a value to Vector3 Variable.")]
	public class Vector3Add : FsmStateAction
	{
		// Token: 0x06004568 RID: 17768 RVA: 0x00178FB8 File Offset: 0x001771B8
		public override void Reset()
		{
			this.vector3Variable = null;
			this.addVector = new FsmVector3
			{
				UseVariable = true
			};
			this.everyFrame = false;
			this.perSecond = false;
		}

		// Token: 0x06004569 RID: 17769 RVA: 0x00178FE1 File Offset: 0x001771E1
		public override void OnEnter()
		{
			this.DoVector3Add();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00178FF7 File Offset: 0x001771F7
		public override void OnUpdate()
		{
			this.DoVector3Add();
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00179000 File Offset: 0x00177200
		private void DoVector3Add()
		{
			if (this.perSecond)
			{
				this.vector3Variable.Value = this.vector3Variable.Value + this.addVector.Value * Time.deltaTime;
				return;
			}
			this.vector3Variable.Value = this.vector3Variable.Value + this.addVector.Value;
		}

		// Token: 0x040049CB RID: 18891
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040049CC RID: 18892
		[RequiredField]
		public FsmVector3 addVector;

		// Token: 0x040049CD RID: 18893
		public bool everyFrame;

		// Token: 0x040049CE RID: 18894
		public bool perSecond;
	}
}
