using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AD9 RID: 2777
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a 2d Game Object on it's z axis so its forward vector points at a Target.")]
	public class LookAt2dGameObject : FsmStateAction
	{
		// Token: 0x06003BAC RID: 15276 RVA: 0x001582E4 File Offset: 0x001564E4
		public override void Reset()
		{
			this.gameObject = null;
			this.targetObject = null;
			this.debug = false;
			this.debugLineColor = Color.green;
			this.everyFrame = true;
		}

		// Token: 0x06003BAD RID: 15277 RVA: 0x00158317 File Offset: 0x00156517
		public override void OnEnter()
		{
			this.DoLookAt();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x0015832D File Offset: 0x0015652D
		public override void OnUpdate()
		{
			this.DoLookAt();
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00158338 File Offset: 0x00156538
		private void DoLookAt()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.goTarget = this.targetObject.Value;
			if (this.go == null || this.targetObject == null)
			{
				return;
			}
			Vector3 vector = this.goTarget.transform.position - this.go.transform.position;
			vector.Normalize();
			float num = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			this.go.transform.rotation = Quaternion.Euler(0f, 0f, num - this.rotationOffset.Value);
			if (this.debug.Value)
			{
				Debug.DrawLine(this.go.transform.position, this.goTarget.transform.position, this.debugLineColor.Value);
			}
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x00158432 File Offset: 0x00156632
		public LookAt2dGameObject()
		{
			this.everyFrame = true;
			base..ctor();
		}

		// Token: 0x04003F45 RID: 16197
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003F46 RID: 16198
		[Tooltip("The GameObject to Look At.")]
		public FsmGameObject targetObject;

		// Token: 0x04003F47 RID: 16199
		[Tooltip("Set the GameObject starting offset. In degrees. 0 if your object is facing right, 180 if facing left etc...")]
		public FsmFloat rotationOffset;

		// Token: 0x04003F48 RID: 16200
		[Title("Draw Debug Line")]
		[Tooltip("Draw a debug line from the GameObject to the Target.")]
		public FsmBool debug;

		// Token: 0x04003F49 RID: 16201
		[Tooltip("Color to use for the debug line.")]
		public FsmColor debugLineColor;

		// Token: 0x04003F4A RID: 16202
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		// Token: 0x04003F4B RID: 16203
		private GameObject go;

		// Token: 0x04003F4C RID: 16204
		private GameObject goTarget;
	}
}
