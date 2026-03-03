using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009DF RID: 2527
	[ActionCategory("Sprite Renderer")]
	public class GetSpriteRendererSprite : FsmStateAction
	{
		// Token: 0x0600372A RID: 14122 RVA: 0x00144A89 File Offset: 0x00142C89
		public override void Reset()
		{
			this.gameObject = null;
			this.sprite = null;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00144A9C File Offset: 0x00142C9C
		public override void OnEnter()
		{
			if (this.gameObject != null)
			{
				GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
				this.sprite.Value = ownerDefaultTarget.GetComponent<SpriteRenderer>().sprite;
			}
			base.Finish();
		}

		// Token: 0x04003943 RID: 14659
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003944 RID: 14660
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;
	}
}
