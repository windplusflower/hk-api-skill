using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000D20 RID: 3360
	[ActionCategory(ActionCategory.Vector3)]
	[Tooltip("Rotates a Vector3 direction from Current towards Target.")]
	public class Vector3RotateTowards : FsmStateAction
	{
		// Token: 0x0600459D RID: 17821 RVA: 0x00179A60 File Offset: 0x00177C60
		public override void Reset()
		{
			this.currentDirection = new FsmVector3
			{
				UseVariable = true
			};
			this.targetDirection = new FsmVector3
			{
				UseVariable = true
			};
			this.rotateSpeed = 360f;
			this.maxMagnitude = 1f;
		}

		// Token: 0x0600459E RID: 17822 RVA: 0x00179AB4 File Offset: 0x00177CB4
		public override void OnUpdate()
		{
			this.currentDirection.Value = Vector3.RotateTowards(this.currentDirection.Value, this.targetDirection.Value, this.rotateSpeed.Value * 0.017453292f * Time.deltaTime, this.maxMagnitude.Value);
		}

		// Token: 0x04004A08 RID: 18952
		[RequiredField]
		public FsmVector3 currentDirection;

		// Token: 0x04004A09 RID: 18953
		[RequiredField]
		public FsmVector3 targetDirection;

		// Token: 0x04004A0A RID: 18954
		[RequiredField]
		[Tooltip("Rotation speed in degrees per second")]
		public FsmFloat rotateSpeed;

		// Token: 0x04004A0B RID: 18955
		[RequiredField]
		[Tooltip("Max Magnitude per second")]
		public FsmFloat maxMagnitude;
	}
}
