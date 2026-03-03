using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000CDC RID: 3292
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets Random Rotation for a Game Object. Uncheck an axis to keep its current value.")]
	public class SetRandomRotation : FsmStateAction
	{
		// Token: 0x06004473 RID: 17523 RVA: 0x00175D2B File Offset: 0x00173F2B
		public override void Reset()
		{
			this.gameObject = null;
			this.x = true;
			this.y = true;
			this.z = true;
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00175D58 File Offset: 0x00173F58
		public override void OnEnter()
		{
			this.DoRandomRotation();
			base.Finish();
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00175D68 File Offset: 0x00173F68
		private void DoRandomRotation()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 localEulerAngles = ownerDefaultTarget.transform.localEulerAngles;
			float num = localEulerAngles.x;
			float num2 = localEulerAngles.y;
			float num3 = localEulerAngles.z;
			if (this.x.Value)
			{
				num = (float)UnityEngine.Random.Range(0, 360);
			}
			if (this.y.Value)
			{
				num2 = (float)UnityEngine.Random.Range(0, 360);
			}
			if (this.z.Value)
			{
				num3 = (float)UnityEngine.Random.Range(0, 360);
			}
			ownerDefaultTarget.transform.localEulerAngles = new Vector3(num, num2, num3);
		}

		// Token: 0x040048BA RID: 18618
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x040048BB RID: 18619
		[RequiredField]
		public FsmBool x;

		// Token: 0x040048BC RID: 18620
		[RequiredField]
		public FsmBool y;

		// Token: 0x040048BD RID: 18621
		[RequiredField]
		public FsmBool z;
	}
}
