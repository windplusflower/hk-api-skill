using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A01 RID: 2561
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Goto a specific frame for current animation.")]
	public class Tk2dPlayFrame : FsmStateAction
	{
		// Token: 0x060037C8 RID: 14280 RVA: 0x00147F5C File Offset: 0x0014615C
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x00147F91 File Offset: 0x00146191
		public override void Reset()
		{
			this.gameObject = null;
			this.frame = 0;
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x00147FA8 File Offset: 0x001461A8
		public override void OnEnter()
		{
			this._getSprite();
			if (this._sprite)
			{
				this._sprite.PlayFromFrame(this.frame.Value);
			}
			else
			{
				Debug.LogWarning("No tk2d sprite animator found on " + base.Owner.name);
			}
			base.Finish();
		}

		// Token: 0x04003A4A RID: 14922
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003A4B RID: 14923
		[RequiredField]
		public FsmInt frame;

		// Token: 0x04003A4C RID: 14924
		private tk2dSpriteAnimator _sprite;
	}
}
