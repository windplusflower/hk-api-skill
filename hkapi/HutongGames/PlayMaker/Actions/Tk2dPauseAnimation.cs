using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200095F RID: 2399
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Pause a sprite animation. Can work everyframe to pause resume animation on the fly. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W720")]
	public class Tk2dPauseAnimation : FsmStateAction
	{
		// Token: 0x060034AB RID: 13483 RVA: 0x0013A3D0 File Offset: 0x001385D0
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x0013A405 File Offset: 0x00138605
		public override void Reset()
		{
			this.gameObject = null;
			this.pause = true;
			this.everyframe = false;
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x0013A421 File Offset: 0x00138621
		public override void OnEnter()
		{
			this._getSprite();
			this.DoPauseAnimation();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x0013A43D File Offset: 0x0013863D
		public override void OnUpdate()
		{
			this.DoPauseAnimation();
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x0013A448 File Offset: 0x00138648
		private void DoPauseAnimation()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component: " + this._sprite.gameObject.name);
				return;
			}
			if (this._sprite.Paused != this.pause.Value)
			{
				if (this.pause.Value)
				{
					this._sprite.Pause();
					return;
				}
				this._sprite.Resume();
			}
		}

		// Token: 0x0400366B RID: 13931
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400366C RID: 13932
		[Tooltip("Pause flag")]
		public FsmBool pause;

		// Token: 0x0400366D RID: 13933
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x0400366E RID: 13934
		private tk2dSpriteAnimator _sprite;
	}
}
