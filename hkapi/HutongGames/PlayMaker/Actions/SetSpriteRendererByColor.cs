using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A52 RID: 2642
	[ActionCategory("GameObject")]
	[Tooltip("Set sprite renderer to active or inactive based on the given current color. Can only be one sprite renderer on object. ")]
	public class SetSpriteRendererByColor : FsmStateAction
	{
		// Token: 0x06003923 RID: 14627 RVA: 0x0014D30B File Offset: 0x0014B50B
		public override void Reset()
		{
			this.gameObject = null;
			this.Color = new FsmColor
			{
				UseVariable = true
			};
			this.EveryFrame = new FsmBool
			{
				UseVariable = false,
				Value = true
			};
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x0014D340 File Offset: 0x0014B540
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				if (ownerDefaultTarget != null)
				{
					this.spriteRenderer = ownerDefaultTarget.GetComponent<SpriteRenderer>();
				}
			}
			if (this.spriteRenderer != null)
			{
				this.Apply();
			}
			if (this.spriteRenderer == null || !this.EveryFrame.Value)
			{
				base.Finish();
			}
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x0014D3B1 File Offset: 0x0014B5B1
		public override void OnUpdate()
		{
			this.Apply();
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x0014D3BC File Offset: 0x0014B5BC
		private void Apply()
		{
			if (this.spriteRenderer != null)
			{
				bool flag = this.Color.Value.a > Mathf.Epsilon;
				if (this.spriteRenderer.enabled != flag)
				{
					this.spriteRenderer.enabled = flag;
				}
			}
		}

		// Token: 0x04003BB8 RID: 15288
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BB9 RID: 15289
		[UIHint(UIHint.Variable)]
		public FsmColor Color;

		// Token: 0x04003BBA RID: 15290
		public FsmBool EveryFrame;

		// Token: 0x04003BBB RID: 15291
		private SpriteRenderer spriteRenderer;
	}
}
