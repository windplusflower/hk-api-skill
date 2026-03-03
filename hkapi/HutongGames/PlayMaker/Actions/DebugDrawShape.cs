using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B5F RID: 2911
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Draw Gizmos in the Scene View.")]
	public class DebugDrawShape : FsmStateAction
	{
		// Token: 0x06003E1B RID: 15899 RVA: 0x00163614 File Offset: 0x00161814
		public override void Reset()
		{
			this.gameObject = null;
			this.shape = DebugDrawShape.ShapeType.Sphere;
			this.color = Color.grey;
			this.radius = 1f;
			this.size = new Vector3(1f, 1f, 1f);
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00163670 File Offset: 0x00161870
		public override void OnDrawActionGizmos()
		{
			Transform transform = base.Fsm.GetOwnerDefaultTarget(this.gameObject).transform;
			if (transform == null)
			{
				return;
			}
			Gizmos.color = this.color.Value;
			switch (this.shape)
			{
			case DebugDrawShape.ShapeType.Sphere:
				Gizmos.DrawSphere(transform.position, this.radius.Value);
				return;
			case DebugDrawShape.ShapeType.Cube:
				Gizmos.DrawCube(transform.position, this.size.Value);
				return;
			case DebugDrawShape.ShapeType.WireSphere:
				Gizmos.DrawWireSphere(transform.position, this.radius.Value);
				return;
			case DebugDrawShape.ShapeType.WireCube:
				Gizmos.DrawWireCube(transform.position, this.size.Value);
				return;
			default:
				return;
			}
		}

		// Token: 0x04004237 RID: 16951
		[RequiredField]
		[Tooltip("Draw the Gizmo at a GameObject's position.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04004238 RID: 16952
		[Tooltip("The type of Gizmo to draw:\nSphere, Cube, WireSphere, or WireCube.")]
		public DebugDrawShape.ShapeType shape;

		// Token: 0x04004239 RID: 16953
		[Tooltip("The color to use.")]
		public FsmColor color;

		// Token: 0x0400423A RID: 16954
		[Tooltip("Use this for sphere gizmos")]
		public FsmFloat radius;

		// Token: 0x0400423B RID: 16955
		[Tooltip("Use this for cube gizmos")]
		public FsmVector3 size;

		// Token: 0x02000B60 RID: 2912
		public enum ShapeType
		{
			// Token: 0x0400423D RID: 16957
			Sphere,
			// Token: 0x0400423E RID: 16958
			Cube,
			// Token: 0x0400423F RID: 16959
			WireSphere,
			// Token: 0x04004240 RID: 16960
			WireCube
		}
	}
}
