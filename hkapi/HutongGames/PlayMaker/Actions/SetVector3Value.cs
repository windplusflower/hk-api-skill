using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE8 RID: 3304
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Sets the value of a Vector3 Variable.")]
	public class SetVector3Value : FsmStateAction
	{
		// Token: 0x060044AE RID: 17582 RVA: 0x001768BE File Offset: 0x00174ABE
		public override void Reset()
		{
			this.vector3Variable = null;
			this.vector3Value = null;
			this.everyFrame = false;
		}

		// Token: 0x060044AF RID: 17583 RVA: 0x001768D5 File Offset: 0x00174AD5
		public override void OnEnter()
		{
			this.vector3Variable.Value = this.vector3Value.Value;
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044B0 RID: 17584 RVA: 0x001768FB File Offset: 0x00174AFB
		public override void OnUpdate()
		{
			this.vector3Variable.Value = this.vector3Value.Value;
		}

		// Token: 0x040048F1 RID: 18673
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040048F2 RID: 18674
		[RequiredField]
		public FsmVector3 vector3Value;

		// Token: 0x040048F3 RID: 18675
		public bool everyFrame;
	}
}
