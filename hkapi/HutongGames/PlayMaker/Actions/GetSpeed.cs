using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C13 RID: 3091
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets the Speed of a Game Object and stores it in a Float Variable. NOTE: The Game Object must have a rigid body.")]
	public class GetSpeed : ComponentAction<Rigidbody>
	{
		// Token: 0x060040DB RID: 16603 RVA: 0x0016B211 File Offset: 0x00169411
		public override void Reset()
		{
			this.gameObject = null;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x0016B228 File Offset: 0x00169428
		public override void OnEnter()
		{
			this.DoGetSpeed();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x0016B23E File Offset: 0x0016943E
		public override void OnUpdate()
		{
			this.DoGetSpeed();
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x0016B248 File Offset: 0x00169448
		private void DoGetSpeed()
		{
			if (this.storeResult == null)
			{
				return;
			}
			GameObject go = (this.gameObject.OwnerOption == OwnerDefaultOption.UseOwner) ? base.Owner : this.gameObject.GameObject.Value;
			if (base.UpdateCache(go))
			{
				Vector3 velocity = base.rigidbody.velocity;
				this.storeResult.Value = velocity.magnitude;
			}
		}

		// Token: 0x04004524 RID: 17700
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject with a Rigidbody.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004525 RID: 17701
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the speed in a float variable.")]
		public FsmFloat storeResult;

		// Token: 0x04004526 RID: 17702
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
