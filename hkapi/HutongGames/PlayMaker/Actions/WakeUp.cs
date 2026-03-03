using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D24 RID: 3364
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Forces a Game Object's Rigid Body to wake up.")]
	public class WakeUp : ComponentAction<Rigidbody>
	{
		// Token: 0x060045AD RID: 17837 RVA: 0x00179CF8 File Offset: 0x00177EF8
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00179D01 File Offset: 0x00177F01
		public override void OnEnter()
		{
			this.DoWakeUp();
			base.Finish();
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00179D10 File Offset: 0x00177F10
		private void DoWakeUp()
		{
			GameObject go = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (base.UpdateCache(go))
			{
				base.rigidbody.WakeUp();
			}
		}

		// Token: 0x04004A16 RID: 18966
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;
	}
}
