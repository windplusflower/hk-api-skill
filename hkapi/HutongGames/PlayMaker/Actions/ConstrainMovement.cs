using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009A9 RID: 2473
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Limits the distance the object can move in X/Y per update. Used to stop Climbers/Laser bugs etc from going into space when framerate dips")]
	public class ConstrainMovement : FsmStateAction
	{
		// Token: 0x0600362C RID: 13868 RVA: 0x0013FB1C File Offset: 0x0013DD1C
		public override void Reset()
		{
			this.gameObject = null;
			this.xConstrain = new FsmFloat();
			this.yConstrain = new FsmFloat();
			this.xPrev = 0f;
			this.yPrev = 0f;
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0013FB54 File Offset: 0x0013DD54
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			this.xPrev = ownerDefaultTarget.transform.position.x;
			this.yPrev = ownerDefaultTarget.transform.position.y;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0013FBA0 File Offset: 0x0013DDA0
		public override void OnUpdate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			float num = ownerDefaultTarget.transform.position.x;
			float num2 = ownerDefaultTarget.transform.position.y;
			if (num > this.xPrev + this.xConstrain.Value)
			{
				num = this.xPrev + this.xConstrain.Value;
			}
			else if (num < this.xPrev - this.xConstrain.Value)
			{
				num = this.xPrev - this.xConstrain.Value;
			}
			if (num2 > this.yPrev + this.yConstrain.Value)
			{
				num2 = this.yPrev + this.yConstrain.Value;
			}
			else if (num2 < this.yPrev - this.yConstrain.Value)
			{
				num2 = this.yPrev - this.yConstrain.Value;
			}
			ownerDefaultTarget.transform.position = new Vector3(num, num2, ownerDefaultTarget.transform.position.z);
			this.xPrev = ownerDefaultTarget.transform.position.x;
			this.yPrev = ownerDefaultTarget.transform.position.y;
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00003603 File Offset: 0x00001803
		public override void OnLateUpdate()
		{
		}

		// Token: 0x04003807 RID: 14343
		[RequiredField]
		[Tooltip("The GameObject to constrain.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003808 RID: 14344
		[Tooltip("Max difference in x pos allowed per update")]
		public FsmFloat xConstrain;

		// Token: 0x04003809 RID: 14345
		[Tooltip("Max difference in y pos allowed per update")]
		public FsmFloat yConstrain;

		// Token: 0x0400380A RID: 14346
		private float xPrev;

		// Token: 0x0400380B RID: 14347
		private float yPrev;
	}
}
