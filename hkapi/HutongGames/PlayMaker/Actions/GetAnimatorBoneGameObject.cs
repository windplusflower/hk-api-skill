using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008D7 RID: 2263
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the GameObject mapped to this human bone id")]
	public class GetAnimatorBoneGameObject : FsmStateAction
	{
		// Token: 0x0600325F RID: 12895 RVA: 0x00131D3A File Offset: 0x0012FF3A
		public override void Reset()
		{
			this.gameObject = null;
			this.bone = HumanBodyBones.Hips;
			this.boneGameObject = null;
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00131D5C File Offset: 0x0012FF5C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				base.Finish();
				return;
			}
			this._animator = ownerDefaultTarget.GetComponent<Animator>();
			if (this._animator == null)
			{
				base.Finish();
				return;
			}
			this.GetBoneTransform();
			base.Finish();
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00131DB8 File Offset: 0x0012FFB8
		private void GetBoneTransform()
		{
			this.boneGameObject.Value = this._animator.GetBoneTransform((HumanBodyBones)this.bone.Value).gameObject;
		}

		// Token: 0x040033B1 RID: 13233
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target. An Animator component is required")]
		public FsmOwnerDefault gameObject;

		// Token: 0x040033B2 RID: 13234
		[Tooltip("The bone reference")]
		[ObjectType(typeof(HumanBodyBones))]
		public FsmEnum bone;

		// Token: 0x040033B3 RID: 13235
		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bone's GameObject")]
		public FsmGameObject boneGameObject;

		// Token: 0x040033B4 RID: 13236
		private Animator _animator;
	}
}
