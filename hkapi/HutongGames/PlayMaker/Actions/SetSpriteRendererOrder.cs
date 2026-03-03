using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A53 RID: 2643
	[ActionCategory("Sprite Renderer")]
	public class SetSpriteRendererOrder : FsmStateAction
	{
		// Token: 0x06003928 RID: 14632 RVA: 0x0014D409 File Offset: 0x0014B609
		public override void Reset()
		{
			this.gameObject = null;
			this.order = null;
			this.delay = null;
			this.timer = 0f;
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x0014D42C File Offset: 0x0014B62C
		public override void OnEnter()
		{
			this.timer = 0f;
			if (this.delay.IsNone || this.delay.Value == 0f)
			{
				if (this.gameObject != null)
				{
					SpriteRenderer component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<SpriteRenderer>();
					if (component != null)
					{
						component.sortingOrder = this.order.Value;
					}
				}
				base.Finish();
			}
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x0014D4A4 File Offset: 0x0014B6A4
		public override void OnUpdate()
		{
			if (this.timer < this.delay.Value)
			{
				this.timer += Time.deltaTime;
				return;
			}
			if (this.gameObject != null)
			{
				SpriteRenderer component = base.Fsm.GetOwnerDefaultTarget(this.gameObject).GetComponent<SpriteRenderer>();
				if (component != null)
				{
					component.sortingOrder = this.order.Value;
				}
			}
			base.Finish();
		}

		// Token: 0x04003BBC RID: 15292
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BBD RID: 15293
		public FsmInt order;

		// Token: 0x04003BBE RID: 15294
		public FsmFloat delay;

		// Token: 0x04003BBF RID: 15295
		private float timer;
	}
}
