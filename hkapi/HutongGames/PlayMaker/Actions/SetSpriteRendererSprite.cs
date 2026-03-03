using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A54 RID: 2644
	[ActionCategory("Sprite Renderer")]
	public class SetSpriteRendererSprite : FsmStateAction
	{
		// Token: 0x0600392C RID: 14636 RVA: 0x0014D516 File Offset: 0x0014B716
		public override void Reset()
		{
			this.gameObject = null;
			this.sprite = null;
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x0014D528 File Offset: 0x0014B728
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				Sprite sprite = this.sprite.Value as Sprite;
				SpriteRenderer component = ownerDefaultTarget.GetComponent<SpriteRenderer>();
				if (component != null)
				{
					component.sprite = sprite;
				}
			}
			base.Finish();
		}

		// Token: 0x04003BC0 RID: 15296
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003BC1 RID: 15297
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;
	}
}
