using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A6F RID: 2671
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Plays a sprite animation. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	public class Tk2dPlayAnimationV2 : FsmStateAction
	{
		// Token: 0x06003996 RID: 14742 RVA: 0x0014FEC0 File Offset: 0x0014E0C0
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x0014FEF5 File Offset: 0x0014E0F5
		public override void Reset()
		{
			this.gameObject = null;
			this.animLibName = null;
			this.clipName = null;
			this.doNotResetCurrentClip = false;
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x0014FF13 File Offset: 0x0014E113
		public override void OnEnter()
		{
			this._getSprite();
			this.DoPlayAnimation();
			base.Finish();
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x0014FF28 File Offset: 0x0014E128
		private void DoPlayAnimation()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component");
				return;
			}
			if (this.doNotResetCurrentClip && this.clipName.Value == this._sprite.CurrentClip.name)
			{
				return;
			}
			this._sprite.Play(this.clipName.Value);
		}

		// Token: 0x04003C97 RID: 15511
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003C98 RID: 15512
		[Tooltip("The anim Lib name. Leave empty to use the one current selected")]
		public FsmString animLibName;

		// Token: 0x04003C99 RID: 15513
		[RequiredField]
		[Tooltip("The clip name to play")]
		public FsmString clipName;

		// Token: 0x04003C9A RID: 15514
		[Tooltip("If true and requested anim clip is same as current clip, don't replay clip from the start")]
		public bool doNotResetCurrentClip;

		// Token: 0x04003C9B RID: 15515
		private tk2dSpriteAnimator _sprite;
	}
}
