using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000BF9 RID: 3065
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets the Mass of a Game Object's Rigid Body.")]
	public class GetMass : ComponentAction<Rigidbody>
	{
		// Token: 0x0600406C RID: 16492 RVA: 0x0016A22B File Offset: 0x0016842B
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
		}

		// Token: 0x0600406D RID: 16493 RVA: 0x0016A23B File Offset: 0x0016843B
		public override void OnEnter()
		{
			this.DoGetMass();
			base.Finish();
		}

		// Token: 0x0600406E RID: 16494 RVA: 0x0016A24C File Offset: 0x0016844C
		private void DoGetMass()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				this.storeResult.Value = base.rigidbody.mass;
			}
		}

		// Token: 0x040044CC RID: 17612
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject that owns the Rigidbody")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040044CD RID: 17613
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the mass in a float variable.")]
		public FsmFloat storeResult;
	}
}
