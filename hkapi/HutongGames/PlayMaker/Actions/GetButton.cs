using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BCE RID: 3022
	[ActionCategory(ActionCategory.Input)]
	[Tooltip("Gets the pressed state of the specified Button and stores it in a Bool Variable. See Unity Input Manager docs.")]
	public class GetButton : FsmStateAction
	{
		// Token: 0x06003FB1 RID: 16305 RVA: 0x001681D2 File Offset: 0x001663D2
		public override void Reset()
		{
			this.buttonName = "Fire1";
			this.storeResult = null;
			this.everyFrame = true;
		}

		// Token: 0x06003FB2 RID: 16306 RVA: 0x001681F2 File Offset: 0x001663F2
		public override void OnEnter()
		{
			this.DoGetButton();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x00168208 File Offset: 0x00166408
		public override void OnUpdate()
		{
			this.DoGetButton();
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x00168210 File Offset: 0x00166410
		private void DoGetButton()
		{
			this.storeResult.Value = Input.GetButton(this.buttonName.Value);
		}

		// Token: 0x040043E4 RID: 17380
		[RequiredField]
		[Tooltip("The name of the button. Set in the Unity Input Manager.")]
		public FsmString buttonName;

		// Token: 0x040043E5 RID: 17381
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool storeResult;

		// Token: 0x040043E6 RID: 17382
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
