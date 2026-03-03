using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000960 RID: 2400
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Plays a sprite animation. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	public class Tk2dPlayAnimation : FsmStateAction
	{
		// Token: 0x060034B1 RID: 13489 RVA: 0x0013A4C0 File Offset: 0x001386C0
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x0013A4F5 File Offset: 0x001386F5
		public override void Reset()
		{
			this.gameObject = null;
			this.animLibName = null;
			this.clipName = null;
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x0013A50C File Offset: 0x0013870C
		public override void OnEnter()
		{
			this._getSprite();
			this.DoPlayAnimation();
			base.Finish();
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x0013A520 File Offset: 0x00138720
		private void DoPlayAnimation()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component");
				return;
			}
			this.animLibName.Value.Equals("");
			this._sprite.Play(this.clipName.Value);
		}

		// Token: 0x0400366F RID: 13935
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003670 RID: 13936
		[Tooltip("The anim Lib name. Leave empty to use the one current selected")]
		public FsmString animLibName;

		// Token: 0x04003671 RID: 13937
		[RequiredField]
		[Tooltip("The clip name to play")]
		public FsmString clipName;

		// Token: 0x04003672 RID: 13938
		private tk2dSpriteAnimator _sprite;
	}
}
