using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A60 RID: 2656
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Follows a target GameObject smoothly in 2D space")]
	public class SmoothFollowTarget2D : FsmStateAction
	{
		// Token: 0x06003964 RID: 14692 RVA: 0x0014E47A File Offset: 0x0014C67A
		public override void Reset()
		{
			this.dampTime = 0.1f;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x0014E488 File Offset: 0x0014C688
		public override void OnEnter()
		{
			this.camera = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<Camera>();
			if (this.targetObject == null || this.camera == null)
			{
				return;
			}
			this.target = this.targetObject.Value;
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0014E4DC File Offset: 0x0014C6DC
		public override void OnUpdate()
		{
			Vector3 vector = this.camera.WorldToViewportPoint(this.target.transform.position);
			Vector3 b = this.target.transform.position - this.camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, vector.z));
			Vector3 vector2 = this.camera.transform.position + b;
			Vector3 zero = Vector3.zero;
			this.camera.transform.position = Vector3.SmoothDamp(this.camera.transform.position, vector2, ref zero, this.dampTime);
		}

		// Token: 0x04003C0C RID: 15372
		[RequiredField]
		[Tooltip("Camera to control.")]
		[CheckForComponent(typeof(Camera))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003C0D RID: 15373
		[Tooltip("The GameObject to follow.")]
		public FsmGameObject targetObject;

		// Token: 0x04003C0E RID: 15374
		[RequiredField]
		public float dampTime;

		// Token: 0x04003C0F RID: 15375
		private Camera camera;

		// Token: 0x04003C10 RID: 15376
		private GameObject target;

		// Token: 0x04003C11 RID: 15377
		private Transform transform;
	}
}
