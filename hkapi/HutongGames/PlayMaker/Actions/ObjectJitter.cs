using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009FF RID: 2559
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Jitter an object around using its Transform.")]
	public class ObjectJitter : FsmStateAction
	{
		// Token: 0x060037BC RID: 14268 RVA: 0x00147C37 File Offset: 0x00145E37
		public override void Reset()
		{
			this.gameObject = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
			this.z = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x00147C78 File Offset: 0x00145E78
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.startX = ownerDefaultTarget.transform.position.x;
			this.startY = ownerDefaultTarget.transform.position.y;
			this.startZ = ownerDefaultTarget.transform.position.z;
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x00147CE3 File Offset: 0x00145EE3
		public override void OnFixedUpdate()
		{
			this.DoTranslate();
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x00147CEC File Offset: 0x00145EEC
		private void DoTranslate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			if (this.allowMovement.Value)
			{
				ownerDefaultTarget.transform.Translate(UnityEngine.Random.Range(-this.x.Value, this.x.Value), UnityEngine.Random.Range(-this.y.Value, this.y.Value), UnityEngine.Random.Range(-this.z.Value, this.z.Value));
				return;
			}
			Vector3 position = new Vector3(this.startX + UnityEngine.Random.Range(-this.x.Value, this.x.Value), this.startY + UnityEngine.Random.Range(-this.y.Value, this.y.Value), this.startZ + UnityEngine.Random.Range(-this.z.Value, this.z.Value));
			ownerDefaultTarget.transform.position = position;
		}

		// Token: 0x04003A3B RID: 14907
		[RequiredField]
		[Tooltip("The game object to translate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A3C RID: 14908
		[Tooltip("Jitter along x axis.")]
		public FsmFloat x;

		// Token: 0x04003A3D RID: 14909
		[Tooltip("Jitter along y axis.")]
		public FsmFloat y;

		// Token: 0x04003A3E RID: 14910
		[Tooltip("Jitter along z axis.")]
		public FsmFloat z;

		// Token: 0x04003A3F RID: 14911
		[Tooltip("If true, don't jitter around start pos")]
		public FsmBool allowMovement;

		// Token: 0x04003A40 RID: 14912
		private float startX;

		// Token: 0x04003A41 RID: 14913
		private float startY;

		// Token: 0x04003A42 RID: 14914
		private float startZ;
	}
}
