using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A00 RID: 2560
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Jitter an object around using its Transform.")]
	public class ObjectJitterLocal : FsmStateAction
	{
		// Token: 0x060037C2 RID: 14274 RVA: 0x00147DFE File Offset: 0x00145FFE
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

		// Token: 0x060037C3 RID: 14275 RVA: 0x00070581 File Offset: 0x0006E781
		public override void OnPreprocess()
		{
			base.Fsm.HandleFixedUpdate = true;
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x00147E40 File Offset: 0x00146040
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.startX = ownerDefaultTarget.transform.localPosition.x;
			this.startY = ownerDefaultTarget.transform.localPosition.y;
			this.startZ = ownerDefaultTarget.transform.localPosition.z;
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x00147EAB File Offset: 0x001460AB
		public override void OnFixedUpdate()
		{
			this.DoTranslate();
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x00147EB4 File Offset: 0x001460B4
		private void DoTranslate()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			Vector3 localPosition = new Vector3(this.startX + UnityEngine.Random.Range(-this.x.Value, this.x.Value), this.startY + UnityEngine.Random.Range(-this.y.Value, this.y.Value), this.startZ + UnityEngine.Random.Range(-this.z.Value, this.z.Value));
			ownerDefaultTarget.transform.localPosition = localPosition;
		}

		// Token: 0x04003A43 RID: 14915
		[RequiredField]
		[Tooltip("The game object to translate.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A44 RID: 14916
		[Tooltip("Jitter along x axis.")]
		public FsmFloat x;

		// Token: 0x04003A45 RID: 14917
		[Tooltip("Jitter along y axis.")]
		public FsmFloat y;

		// Token: 0x04003A46 RID: 14918
		[Tooltip("Jitter along z axis.")]
		public FsmFloat z;

		// Token: 0x04003A47 RID: 14919
		private float startX;

		// Token: 0x04003A48 RID: 14920
		private float startY;

		// Token: 0x04003A49 RID: 14921
		private float startZ;
	}
}
