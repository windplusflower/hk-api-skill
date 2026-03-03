using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C23 RID: 3107
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Get Vector3 Length.")]
	public class GetVectorLength : FsmStateAction
	{
		// Token: 0x06004122 RID: 16674 RVA: 0x0016BC4F File Offset: 0x00169E4F
		public override void Reset()
		{
			this.vector3 = null;
			this.storeLength = null;
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x0016BC5F File Offset: 0x00169E5F
		public override void OnEnter()
		{
			this.DoVectorLength();
			base.Finish();
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x0016BC70 File Offset: 0x00169E70
		private void DoVectorLength()
		{
			if (this.vector3 == null)
			{
				return;
			}
			if (this.storeLength == null)
			{
				return;
			}
			this.storeLength.Value = this.vector3.Value.magnitude;
		}

		// Token: 0x04004568 RID: 17768
		public FsmVector3 vector3;

		// Token: 0x04004569 RID: 17769
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeLength;
	}
}
