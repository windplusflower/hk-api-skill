using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D14 RID: 3348
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Adds a XYZ values to Vector3 Variable.")]
	public class Vector3AddXYZ : FsmStateAction
	{
		// Token: 0x0600456D RID: 17773 RVA: 0x0017906C File Offset: 0x0017726C
		public override void Reset()
		{
			this.vector3Variable = null;
			this.addX = 0f;
			this.addY = 0f;
			this.addZ = 0f;
			this.everyFrame = false;
			this.perSecond = false;
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x001790BE File Offset: 0x001772BE
		public override void OnEnter()
		{
			this.DoVector3AddXYZ();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x001790D4 File Offset: 0x001772D4
		public override void OnUpdate()
		{
			this.DoVector3AddXYZ();
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x001790DC File Offset: 0x001772DC
		private void DoVector3AddXYZ()
		{
			Vector3 vector = new Vector3(this.addX.Value, this.addY.Value, this.addZ.Value);
			if (this.perSecond)
			{
				this.vector3Variable.Value += vector * Time.deltaTime;
				return;
			}
			this.vector3Variable.Value += vector;
		}

		// Token: 0x040049CF RID: 18895
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040049D0 RID: 18896
		public FsmFloat addX;

		// Token: 0x040049D1 RID: 18897
		public FsmFloat addY;

		// Token: 0x040049D2 RID: 18898
		public FsmFloat addZ;

		// Token: 0x040049D3 RID: 18899
		public bool everyFrame;

		// Token: 0x040049D4 RID: 18900
		public bool perSecond;
	}
}
