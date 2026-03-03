using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A5A RID: 2650
	[ActionCategory("Vector2")]
	[Tooltip("Sets the XY channels of a Vector2 Variable. To leave any channel unchanged, set variable to 'None'.")]
	public class SetVector2XY : FsmStateAction
	{
		// Token: 0x06003941 RID: 14657 RVA: 0x0014DA4E File Offset: 0x0014BC4E
		public override void Reset()
		{
			this.vector2Variable = null;
			this.vector2Value = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.everyFrame = false;
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x0014DA89 File Offset: 0x0014BC89
		public override void OnEnter()
		{
			this.DoSetVector2XY();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x0014DA9F File Offset: 0x0014BC9F
		public override void OnUpdate()
		{
			this.DoSetVector2XY();
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x0014DAA8 File Offset: 0x0014BCA8
		private void DoSetVector2XY()
		{
			if (this.vector2Variable == null)
			{
				return;
			}
			Vector2 value = this.vector2Variable.Value;
			if (!this.vector2Value.IsNone)
			{
				value = this.vector2Value.Value;
			}
			if (!this.x.IsNone)
			{
				value.x = this.x.Value;
			}
			if (!this.y.IsNone)
			{
				value.y = this.y.Value;
			}
			this.vector2Variable.Value = value;
		}

		// Token: 0x04003BE3 RID: 15331
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Variable;

		// Token: 0x04003BE4 RID: 15332
		[UIHint(UIHint.Variable)]
		public FsmVector2 vector2Value;

		// Token: 0x04003BE5 RID: 15333
		public FsmFloat x;

		// Token: 0x04003BE6 RID: 15334
		public FsmFloat y;

		// Token: 0x04003BE7 RID: 15335
		public bool everyFrame;
	}
}
