using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B73 RID: 2931
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Draws a line from a Start point to an End point. Specify the points as Game Objects or Vector3 world positions. If both are specified, position is used as a local offset from the Object's position.")]
	public class DrawDebugLine : FsmStateAction
	{
		// Token: 0x06003E59 RID: 15961 RVA: 0x00163E7C File Offset: 0x0016207C
		public override void Reset()
		{
			this.fromObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.fromPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.toObject = new FsmGameObject
			{
				UseVariable = true
			};
			this.toPosition = new FsmVector3
			{
				UseVariable = true
			};
			this.color = Color.white;
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x00163EE4 File Offset: 0x001620E4
		public override void OnUpdate()
		{
			Vector3 position = ActionHelpers.GetPosition(this.fromObject, this.fromPosition);
			Vector3 position2 = ActionHelpers.GetPosition(this.toObject, this.toPosition);
			Debug.DrawLine(position, position2, this.color.Value);
		}

		// Token: 0x04004264 RID: 16996
		[Tooltip("Draw line from a GameObject.")]
		public FsmGameObject fromObject;

		// Token: 0x04004265 RID: 16997
		[Tooltip("Draw line from a world position, or local offset from GameObject if provided.")]
		public FsmVector3 fromPosition;

		// Token: 0x04004266 RID: 16998
		[Tooltip("Draw line to a GameObject.")]
		public FsmGameObject toObject;

		// Token: 0x04004267 RID: 16999
		[Tooltip("Draw line to a world position, or local offset from GameObject if provided.")]
		public FsmVector3 toPosition;

		// Token: 0x04004268 RID: 17000
		[Tooltip("The color of the line.")]
		public FsmColor color;
	}
}
