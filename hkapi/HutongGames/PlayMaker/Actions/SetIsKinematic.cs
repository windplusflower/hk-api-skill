using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CC4 RID: 3268
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Controls whether physics affects the Game Object.")]
	public class SetIsKinematic : ComponentAction<Rigidbody>
	{
		// Token: 0x0600440D RID: 17421 RVA: 0x00174CCD File Offset: 0x00172ECD
		public override void Reset()
		{
			this.gameObject = null;
			this.isKinematic = false;
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00174CE2 File Offset: 0x00172EE2
		public override void OnEnter()
		{
			this.DoSetIsKinematic();
			base.Finish();
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00174CF0 File Offset: 0x00172EF0
		private void DoSetIsKinematic()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.rigidbody.isKinematic = this.isKinematic.Value;
			}
		}

		// Token: 0x0400486C RID: 18540
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400486D RID: 18541
		[RequiredField]
		public FsmBool isKinematic;
	}
}
