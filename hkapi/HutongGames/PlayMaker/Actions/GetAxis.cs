using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BCB RID: 3019
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the value of the specified Input Axis and stores it in a Float Variable. See Unity Input Manager docs.")]
	public class GetAxis : FsmStateAction
	{
		// Token: 0x06003FA9 RID: 16297 RVA: 0x00167F12 File Offset: 0x00166112
		public override void Reset()
		{
			this.axisName = "";
			this.multiplier = 1f;
			this.store = null;
			this.everyFrame = true;
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00167F42 File Offset: 0x00166142
		public override void OnEnter()
		{
			this.DoGetAxis();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00167F58 File Offset: 0x00166158
		public override void OnUpdate()
		{
			this.DoGetAxis();
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00167F60 File Offset: 0x00166160
		private void DoGetAxis()
		{
			if (FsmString.IsNullOrEmpty(this.axisName))
			{
				return;
			}
			float num = Input.GetAxis(this.axisName.Value);
			if (!this.multiplier.IsNone)
			{
				num *= this.multiplier.Value;
			}
			this.store.Value = num;
		}

		// Token: 0x040043D5 RID: 17365
		[RequiredField]
		[Tooltip("The name of the axis. Set in the Unity Input Manager.")]
		public FsmString axisName;

		// Token: 0x040043D6 RID: 17366
		[Tooltip("Axis values are in the range -1 to 1. Use the multiplier to set a larger range.")]
		public FsmFloat multiplier;

		// Token: 0x040043D7 RID: 17367
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a float variable.")]
		public FsmFloat store;

		// Token: 0x040043D8 RID: 17368
		[Tooltip("Repeat every frame. Typically this would be set to True.")]
		public bool everyFrame;
	}
}
