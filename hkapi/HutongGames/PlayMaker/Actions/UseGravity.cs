using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D11 RID: 3345
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sets whether a Game Object's Rigidy Body is affected by Gravity.")]
	public class UseGravity : ComponentAction<Rigidbody>
	{
		// Token: 0x06004560 RID: 17760 RVA: 0x00178ED9 File Offset: 0x001770D9
		public override void Reset()
		{
			this.gameObject = null;
			this.useGravity = true;
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00178EEE File Offset: 0x001770EE
		public override void OnEnter()
		{
			this.DoUseGravity();
			base.Finish();
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00178EFC File Offset: 0x001770FC
		private void DoUseGravity()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (base.UpdateCache(ownerDefaultTarget))
			{
				base.rigidbody.useGravity = this.useGravity.Value;
			}
		}

		// Token: 0x040049C6 RID: 18886
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040049C7 RID: 18887
		[RequiredField]
		public FsmBool useGravity;
	}
}
