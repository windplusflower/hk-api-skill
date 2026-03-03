using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CED RID: 3309
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Action version of Unity's Smooth Follow script.")]
	public class SmoothFollowAction : FsmStateAction
	{
		// Token: 0x060044C7 RID: 17607 RVA: 0x00176CCC File Offset: 0x00174ECC
		public override void Reset()
		{
			this.gameObject = null;
			this.targetObject = null;
			this.distance = 10f;
			this.height = 5f;
			this.heightDamping = 2f;
			this.rotationDamping = 3f;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x001593EE File Offset: 0x001575EE
		public override void OnPreprocess()
		{
			base.Fsm.HandleLateUpdate = true;
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00176D28 File Offset: 0x00174F28
		public override void OnLateUpdate()
		{
			if (this.targetObject.Value == null)
			{
				return;
			}
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.cachedObject != ownerDefaultTarget)
			{
				this.cachedObject = ownerDefaultTarget;
				this.myTransform = ownerDefaultTarget.transform;
			}
			if (this.cachedTarget != this.targetObject.Value)
			{
				this.cachedTarget = this.targetObject.Value;
				this.targetTransform = this.cachedTarget.transform;
			}
			float y = this.targetTransform.eulerAngles.y;
			float b = this.targetTransform.position.y + this.height.Value;
			float num = this.myTransform.eulerAngles.y;
			float num2 = this.myTransform.position.y;
			num = Mathf.LerpAngle(num, y, this.rotationDamping.Value * Time.deltaTime);
			num2 = Mathf.Lerp(num2, b, this.heightDamping.Value * Time.deltaTime);
			Quaternion rotation = Quaternion.Euler(0f, num, 0f);
			this.myTransform.position = this.targetTransform.position;
			this.myTransform.position -= rotation * Vector3.forward * this.distance.Value;
			this.myTransform.position = new Vector3(this.myTransform.position.x, num2, this.myTransform.position.z);
			this.myTransform.LookAt(this.targetTransform);
		}

		// Token: 0x04004907 RID: 18695
		[RequiredField]
		[Tooltip("The game object to control. E.g. The camera.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004908 RID: 18696
		[Tooltip("The GameObject to follow.")]
		public FsmGameObject targetObject;

		// Token: 0x04004909 RID: 18697
		[RequiredField]
		[Tooltip("The distance in the x-z plane to the target.")]
		public FsmFloat distance;

		// Token: 0x0400490A RID: 18698
		[RequiredField]
		[Tooltip("The height we want the camera to be above the target")]
		public FsmFloat height;

		// Token: 0x0400490B RID: 18699
		[RequiredField]
		[Tooltip("How much to dampen height movement.")]
		public FsmFloat heightDamping;

		// Token: 0x0400490C RID: 18700
		[RequiredField]
		[Tooltip("How much to dampen rotation changes.")]
		public FsmFloat rotationDamping;

		// Token: 0x0400490D RID: 18701
		private GameObject cachedObject;

		// Token: 0x0400490E RID: 18702
		private Transform myTransform;

		// Token: 0x0400490F RID: 18703
		private GameObject cachedTarget;

		// Token: 0x04004910 RID: 18704
		private Transform targetTransform;
	}
}
