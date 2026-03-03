using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C08 RID: 3080
	[ActionCategory(ActionCategory.UnityObject)]
	[ActionTarget(typeof(Component), "targetProperty", false)]
	[ActionTarget(typeof(GameObject), "targetProperty", false)]
	[Tooltip("Gets the value of any public property or field on the targeted Unity Object and stores it in a variable. E.g., Drag and drop any component attached to a Game Object to access its properties.")]
	public class GetProperty : FsmStateAction
	{
		// Token: 0x060040AB RID: 16555 RVA: 0x0016AACD File Offset: 0x00168CCD
		public override void Reset()
		{
			this.targetProperty = new FsmProperty
			{
				setProperty = false
			};
			this.everyFrame = false;
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x0016AAE8 File Offset: 0x00168CE8
		public override void OnEnter()
		{
			this.targetProperty.GetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x0016AB03 File Offset: 0x00168D03
		public override void OnUpdate()
		{
			this.targetProperty.GetValue();
		}

		// Token: 0x040044FA RID: 17658
		public FsmProperty targetProperty;

		// Token: 0x040044FB RID: 17659
		public bool everyFrame;
	}
}
