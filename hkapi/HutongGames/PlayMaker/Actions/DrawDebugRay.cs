using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B74 RID: 2932
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Draws a line from a Start point in a direction. Specify the start point as Game Objects or Vector3 world positions. If both are specified, position is used as a local offset from the Object's position.")]
	public class DrawDebugRay : FsmStateAction
	{
		// Token: 0x06003E5C RID: 15964 RVA: 0x00163F28 File Offset: 0x00162128
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
			this.direction = new FsmVector3
			{
				UseVariable = true
			};
			this.color = Color.white;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x00163F7B File Offset: 0x0016217B
		public override void OnUpdate()
		{
			Debug.DrawRay(ActionHelpers.GetPosition(this.fromObject, this.fromPosition), this.direction.Value, this.color.Value);
		}

		// Token: 0x04004269 RID: 17001
		[Tooltip("Draw ray from a GameObject.")]
		public FsmGameObject fromObject;

		// Token: 0x0400426A RID: 17002
		[Tooltip("Draw ray from a world position, or local offset from GameObject if provided.")]
		public FsmVector3 fromPosition;

		// Token: 0x0400426B RID: 17003
		[Tooltip("Direction vector of ray.")]
		public FsmVector3 direction;

		// Token: 0x0400426C RID: 17004
		[Tooltip("The color of the ray.")]
		public FsmColor color;
	}
}
