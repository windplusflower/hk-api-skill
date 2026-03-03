using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C48 RID: 3144
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Set the isTrigger option of a Collider2D. Optionally set all collider2D found on the gameobject Target.")]
	public class SetCollider2dIsTrigger : FsmStateAction
	{
		// Token: 0x060041CF RID: 16847 RVA: 0x0016DF66 File Offset: 0x0016C166
		public override void Reset()
		{
			this.gameObject = null;
			this.isTrigger = false;
			this.setAllColliders = false;
		}

		// Token: 0x060041D0 RID: 16848 RVA: 0x0016DF82 File Offset: 0x0016C182
		public override void OnEnter()
		{
			this.DoSetIsTrigger();
			base.Finish();
		}

		// Token: 0x060041D1 RID: 16849 RVA: 0x0016DF90 File Offset: 0x0016C190
		private void DoSetIsTrigger()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.setAllColliders)
			{
				Collider2D[] components = ownerDefaultTarget.GetComponents<Collider2D>();
				for (int i = 0; i < components.Length; i++)
				{
					components[i].isTrigger = this.isTrigger.Value;
				}
				return;
			}
			if (ownerDefaultTarget.GetComponent<Collider2D>() != null)
			{
				ownerDefaultTarget.GetComponent<Collider2D>().isTrigger = this.isTrigger.Value;
			}
		}

		// Token: 0x04004632 RID: 17970
		[RequiredField]
		[CheckForComponent(typeof(Collider2D))]
		[Tooltip("The GameObject with the Collider2D attached")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004633 RID: 17971
		[RequiredField]
		[Tooltip("The flag value")]
		public FsmBool isTrigger;

		// Token: 0x04004634 RID: 17972
		[Tooltip("Set all Colliders on the GameObject target")]
		public bool setAllColliders;
	}
}
