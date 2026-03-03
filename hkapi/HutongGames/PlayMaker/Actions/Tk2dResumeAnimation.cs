using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000962 RID: 2402
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Resume a sprite animation. Use Tk2dPauseAnimation for dynamic control. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W721")]
	public class Tk2dResumeAnimation : FsmStateAction
	{
		// Token: 0x060034BD RID: 13501 RVA: 0x0013A710 File Offset: 0x00138910
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x0013A745 File Offset: 0x00138945
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x0013A74E File Offset: 0x0013894E
		public override void OnEnter()
		{
			this._getSprite();
			this.DoResumeAnimation();
			base.Finish();
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x0013A762 File Offset: 0x00138962
		private void DoResumeAnimation()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component");
				return;
			}
			if (this._sprite.Paused)
			{
				this._sprite.Resume();
			}
		}

		// Token: 0x04003678 RID: 13944
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003679 RID: 13945
		private tk2dSpriteAnimator _sprite;
	}
}
