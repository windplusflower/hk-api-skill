using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D23 RID: 3363
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Rigid bodies start sleeping when they come to rest. This action wakes up all rigid bodies in the scene. E.g., if you Set Gravity and want objects at rest to respond.")]
	public class WakeAllRigidBodies : FsmStateAction
	{
		// Token: 0x060045A8 RID: 17832 RVA: 0x00179C69 File Offset: 0x00177E69
		public override void Reset()
		{
			this.everyFrame = false;
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00179C72 File Offset: 0x00177E72
		public override void OnEnter()
		{
			this.bodies = (UnityEngine.Object.FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[]);
			this.DoWakeAll();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00179CA2 File Offset: 0x00177EA2
		public override void OnUpdate()
		{
			this.DoWakeAll();
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00179CAC File Offset: 0x00177EAC
		private void DoWakeAll()
		{
			this.bodies = (UnityEngine.Object.FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[]);
			if (this.bodies != null)
			{
				Rigidbody[] array = this.bodies;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].WakeUp();
				}
			}
		}

		// Token: 0x04004A14 RID: 18964
		public bool everyFrame;

		// Token: 0x04004A15 RID: 18965
		private Rigidbody[] bodies;
	}
}
