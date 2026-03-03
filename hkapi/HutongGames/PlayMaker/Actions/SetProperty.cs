using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CDA RID: 3290
	[ActionCategory(ActionCategory.UnityObject)]
	[ActionTarget(typeof(Component), "targetProperty", false)]
	[ActionTarget(typeof(GameObject), "targetProperty", false)]
	[Tooltip("Sets the value of any public property or field on the targeted Unity Object. E.g., Drag and drop any component attached to a Game Object to access its properties.")]
	public class SetProperty : FsmStateAction
	{
		// Token: 0x0600446B RID: 17515 RVA: 0x00175BD1 File Offset: 0x00173DD1
		public override void Reset()
		{
			this.targetProperty = new FsmProperty
			{
				setProperty = true
			};
			this.everyFrame = false;
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x00175BEC File Offset: 0x00173DEC
		public override void OnEnter()
		{
			this.targetProperty.SetValue();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x00175C07 File Offset: 0x00173E07
		public override void OnUpdate()
		{
			this.targetProperty.SetValue();
		}

		// Token: 0x040048B5 RID: 18613
		public FsmProperty targetProperty;

		// Token: 0x040048B6 RID: 18614
		public bool everyFrame;
	}
}
