using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AC5 RID: 2757
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Adds a 2d torque (rotational force) to a Game Object.")]
	public class AddTorque2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003B49 RID: 15177 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x00156355 File Offset: 0x00154555
		public override void Reset()
		{
			this.gameObject = null;
			this.torque = null;
			this.everyFrame = false;
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x0015636C File Offset: 0x0015456C
		public override void OnEnter()
		{
			this.DoAddTorque();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00156382 File Offset: 0x00154582
		public override void OnFixedUpdate()
		{
			this.DoAddTorque();
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x0015638C File Offset: 0x0015458C
		private void DoAddTorque()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.AddTorque(this.torque.Value, this.forceMode);
		}

		// Token: 0x04003EA4 RID: 16036
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to add torque to.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003EA5 RID: 16037
		[Tooltip("Option for applying the force")]
		public ForceMode2D forceMode;

		// Token: 0x04003EA6 RID: 16038
		[Tooltip("Torque")]
		public FsmFloat torque;

		// Token: 0x04003EA7 RID: 16039
		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;
	}
}
