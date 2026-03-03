using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CE9 RID: 3305
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Sets the XYZ channels of a Vector3 Variable. To leave any channel unchanged, set variable to 'None'.")]
	public class SetVector3XYZ : FsmStateAction
	{
		// Token: 0x060044B2 RID: 17586 RVA: 0x00176914 File Offset: 0x00174B14
		public override void Reset()
		{
			this.vector3Variable = null;
			this.vector3Value = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.z = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x0017696C File Offset: 0x00174B6C
		public override void OnEnter()
		{
			this.DoSetVector3XYZ();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060044B4 RID: 17588 RVA: 0x00176982 File Offset: 0x00174B82
		public override void OnUpdate()
		{
			this.DoSetVector3XYZ();
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x0017698C File Offset: 0x00174B8C
		private void DoSetVector3XYZ()
		{
			if (this.vector3Variable == null)
			{
				return;
			}
			Vector3 value = this.vector3Variable.Value;
			if (!this.vector3Value.IsNone)
			{
				value = this.vector3Value.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			if (!this.z.IsNone)
			{
				value.z = this.z.Value;
			}
			this.vector3Variable.Value = value;
		}

		// Token: 0x040048F4 RID: 18676
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Variable;

		// Token: 0x040048F5 RID: 18677
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector3Value;

		// Token: 0x040048F6 RID: 18678
		public FsmFloat x;

		// Token: 0x040048F7 RID: 18679
		public FsmFloat y;

		// Token: 0x040048F8 RID: 18680
		public FsmFloat z;

		// Token: 0x040048F9 RID: 18681
		public bool everyFrame;
	}
}
