using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D6 RID: 2518
	[ActionCategory("GameObject")]
	[Tooltip("Set Mesh Renderer to active or inactive. Can only be one Mesh Renderer on object. ")]
	public class GetMeshRendererBounds : FsmStateAction
	{
		// Token: 0x06003709 RID: 14089 RVA: 0x0014439A File Offset: 0x0014259A
		public override void Reset()
		{
			this.gameObject = null;
			this.width = null;
			this.height = null;
			this.widthMax = null;
			this.heightMax = null;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x001443C0 File Offset: 0x001425C0
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				MeshRenderer component = ownerDefaultTarget.GetComponent<MeshRenderer>();
				if (component != null)
				{
					this.width.Value = component.bounds.size.x;
				}
				foreach (object obj in ownerDefaultTarget.transform)
				{
					MeshRenderer component2 = ((Transform)obj).GetComponent<MeshRenderer>();
					if (component2 != null)
					{
						float x = component2.bounds.size.x;
						float y = component2.bounds.size.y;
						if (x > this.width.Value)
						{
							this.width.Value = x;
						}
						if (y > this.height.Value)
						{
							this.height.Value = y;
						}
					}
				}
				if (!this.widthMax.IsNone && this.width.Value > this.widthMax.Value)
				{
					this.width.Value = 0f;
				}
				this.height.Value = component.bounds.size.y;
				if (!this.heightMax.IsNone && this.height.Value > this.heightMax.Value)
				{
					this.height.Value = 0f;
				}
			}
			base.Finish();
		}

		// Token: 0x04003922 RID: 14626
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003923 RID: 14627
		[UIHint(UIHint.Variable)]
		public FsmFloat width;

		// Token: 0x04003924 RID: 14628
		[UIHint(UIHint.Variable)]
		public FsmFloat height;

		// Token: 0x04003925 RID: 14629
		public FsmFloat widthMax;

		// Token: 0x04003926 RID: 14630
		public FsmFloat heightMax;
	}
}
