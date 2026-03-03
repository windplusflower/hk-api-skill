using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AE2 RID: 2786
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Controls whether 2D physics affects the Game Object.")]
	public class SetIsKinematic2d : ComponentAction<Rigidbody2D>
	{
		// Token: 0x06003BD8 RID: 15320 RVA: 0x00159020 File Offset: 0x00157220
		public override void Reset()
		{
			this.gameObject = null;
			this.isKinematic = false;
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00159035 File Offset: 0x00157235
		public override void OnEnter()
		{
			this.DoSetIsKinematic();
			base.Finish();
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00159044 File Offset: 0x00157244
		private void DoSetIsKinematic()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (!base.UpdateCache(ownerDefaultTarget))
			{
				return;
			}
			base.rigidbody2d.isKinematic = this.isKinematic.Value;
		}

		// Token: 0x04003F86 RID: 16262
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F87 RID: 16263
		[RequiredField]
		[Tooltip("The isKinematic value")]
		public FsmBool isKinematic;
	}
}
