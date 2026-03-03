using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AEA RID: 2794
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Rigid bodies 2D start sleeping when they come to rest. This action wakes up all rigid bodies 2D in the scene. E.g., if you Set Gravity 2D and want objects at rest to respond.")]
	public class WakeAllRigidBodies2d : FsmStateAction
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x00159BA8 File Offset: 0x00157DA8
		public override void Reset()
		{
			this.everyFrame = false;
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00159BB1 File Offset: 0x00157DB1
		public override void OnEnter()
		{
			this.DoWakeAll();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00159BC7 File Offset: 0x00157DC7
		public override void OnUpdate()
		{
			this.DoWakeAll();
		}

		// Token: 0x06003C05 RID: 15365 RVA: 0x00159BD0 File Offset: 0x00157DD0
		private void DoWakeAll()
		{
			Rigidbody2D[] array = UnityEngine.Object.FindObjectsOfType(typeof(Rigidbody2D)) as Rigidbody2D[];
			if (array != null)
			{
				Rigidbody2D[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].WakeUp();
				}
			}
		}

		// Token: 0x04003FB1 RID: 16305
		[Tooltip("Repeat every frame. Note: This would be very expensive!")]
		public bool everyFrame;
	}
}
