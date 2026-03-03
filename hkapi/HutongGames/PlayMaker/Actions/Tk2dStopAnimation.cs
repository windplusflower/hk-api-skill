using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000964 RID: 2404
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Stops a sprite animation. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	public class Tk2dStopAnimation : FsmStateAction
	{
		// Token: 0x060034C8 RID: 13512 RVA: 0x0013A848 File Offset: 0x00138A48
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x0013A87D File Offset: 0x00138A7D
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x0013A886 File Offset: 0x00138A86
		public override void OnEnter()
		{
			this._getSprite();
			this.DoStopAnimation();
			base.Finish();
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x0013A89A File Offset: 0x00138A9A
		private void DoStopAnimation()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component: " + this._sprite.gameObject.name);
				return;
			}
			this._sprite.Stop();
		}

		// Token: 0x0400367E RID: 13950
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400367F RID: 13951
		private tk2dSpriteAnimator _sprite;
	}
}
