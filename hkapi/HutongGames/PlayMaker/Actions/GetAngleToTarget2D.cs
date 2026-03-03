using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009CE RID: 2510
	[ActionCategory("Enemy AI")]
	[Tooltip("Get the angle from Game Object to the target. 0 is right, 90 is up etc.")]
	public class GetAngleToTarget2D : FsmStateAction
	{
		// Token: 0x060036E8 RID: 14056 RVA: 0x00143D8B File Offset: 0x00141F8B
		public override void Reset()
		{
			this.gameObject = null;
			this.target = null;
			this.offsetX = null;
			this.offsetY = null;
			this.storeAngle = null;
			this.everyFrame = false;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00143DB8 File Offset: 0x00141FB8
		public override void OnEnter()
		{
			this.self = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (this.offsetX.IsNone)
			{
				this.offsetX.Value = 0f;
			}
			if (this.offsetY.IsNone)
			{
				this.offsetY.Value = 0f;
			}
			this.DoGetAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00143E2F File Offset: 0x0014202F
		public override void OnUpdate()
		{
			this.DoGetAngle();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00143E48 File Offset: 0x00142048
		private void DoGetAngle()
		{
			float num = this.target.Value.transform.position.y + this.offsetY.Value - this.self.Value.transform.position.y;
			float num2 = this.target.Value.transform.position.x + this.offsetX.Value - this.self.Value.transform.position.x;
			float num3;
			for (num3 = Mathf.Atan2(num, num2) * 57.295776f; num3 < 0f; num3 += 360f)
			{
			}
			this.storeAngle.Value = num3;
		}

		// Token: 0x04003902 RID: 14594
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003903 RID: 14595
		[RequiredField]
		public FsmGameObject target;

		// Token: 0x04003904 RID: 14596
		public FsmFloat offsetX;

		// Token: 0x04003905 RID: 14597
		public FsmFloat offsetY;

		// Token: 0x04003906 RID: 14598
		[RequiredField]
		public FsmFloat storeAngle;

		// Token: 0x04003907 RID: 14599
		private FsmGameObject self;

		// Token: 0x04003908 RID: 14600
		private FsmFloat x;

		// Token: 0x04003909 RID: 14601
		private FsmFloat y;

		// Token: 0x0400390A RID: 14602
		public bool everyFrame;
	}
}
