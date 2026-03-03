using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020008CC RID: 2252
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a 2d Game Object on it's z axis so its forward vector points at a Target. Rotates th eobject per frame via speed.")]
	public class LookAt2dGameObjectSmooth : FsmStateAction
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x001312D4 File Offset: 0x0012F4D4
		public override void Reset()
		{
			this.gameObject = null;
			this.targetObject = null;
			this.debug = false;
			this.debugLineColor = Color.green;
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x00131300 File Offset: 0x0012F500
		public override void OnEnter()
		{
			this.DoLookAt();
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x00131300 File Offset: 0x0012F500
		public override void OnUpdate()
		{
			this.DoLookAt();
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x00131308 File Offset: 0x0012F508
		private void DoLookAt()
		{
			this.go = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.goTarget = this.targetObject.Value;
			if (this.go == null || this.targetObject == null)
			{
				return;
			}
			float y = this.goTarget.transform.position.y - this.go.transform.position.y;
			float x = this.goTarget.transform.position.x - this.go.transform.position.x;
			float num;
			for (num = Mathf.Atan2(y, x) * 57.295776f; num < 0f; num += 360f)
			{
			}
			if (this.go.transform.eulerAngles.z < num - this.rotationOffset.Value)
			{
				this.go.transform.Rotate(0f, 0f, this.speed.Value);
				if (this.go.transform.eulerAngles.z > num - this.rotationOffset.Value)
				{
					this.go.transform.rotation = Quaternion.Euler(0f, 0f, num - this.rotationOffset.Value);
				}
			}
			if (this.go.transform.eulerAngles.z > num - this.rotationOffset.Value)
			{
				this.go.transform.Rotate(0f, 0f, -this.speed.Value);
				if (this.go.transform.eulerAngles.z < num - this.rotationOffset.Value)
				{
					this.go.transform.rotation = Quaternion.Euler(0f, 0f, num - this.rotationOffset.Value);
				}
			}
			if (this.debug.Value)
			{
				Debug.DrawLine(this.go.transform.position, this.goTarget.transform.position, this.debugLineColor.Value);
			}
		}

		// Token: 0x0400337B RID: 13179
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400337C RID: 13180
		[Tooltip("The GameObject to Look At.")]
		public FsmGameObject targetObject;

		// Token: 0x0400337D RID: 13181
		[Tooltip("Set the GameObject starting offset. In degrees. 0 if your object is facing right, 180 if facing left etc...")]
		public FsmFloat rotationOffset;

		// Token: 0x0400337E RID: 13182
		[RequiredField]
		[Tooltip("Speed the object rotates at to meet its target angle (in degrees per frame).")]
		public FsmFloat speed;

		// Token: 0x0400337F RID: 13183
		[Title("Draw Debug Line")]
		[Tooltip("Draw a debug line from the GameObject to the Target.")]
		public FsmBool debug;

		// Token: 0x04003380 RID: 13184
		[Tooltip("Color to use for the debug line.")]
		public FsmColor debugLineColor;

		// Token: 0x04003381 RID: 13185
		private GameObject go;

		// Token: 0x04003382 RID: 13186
		private GameObject goTarget;

		// Token: 0x04003383 RID: 13187
		private Vector3 lookAtPos;
	}
}
