using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000963 RID: 2403
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Set the current clip frames per seconds on a animated sprite. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	public class Tk2dSetAnimationFrameRate : FsmStateAction
	{
		// Token: 0x060034C2 RID: 13506 RVA: 0x0013A798 File Offset: 0x00138998
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0013A7CD File Offset: 0x001389CD
		public override void Reset()
		{
			this.gameObject = null;
			this.framePerSeconds = 30f;
			this.everyFrame = false;
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x0013A7ED File Offset: 0x001389ED
		public override void OnEnter()
		{
			this._getSprite();
			this.DoSetAnimationFPS();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x0013A809 File Offset: 0x00138A09
		public override void OnUpdate()
		{
			this.DoSetAnimationFPS();
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x0013A811 File Offset: 0x00138A11
		private void DoSetAnimationFPS()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component");
				return;
			}
			this._sprite.CurrentClip.fps = this.framePerSeconds.Value;
		}

		// Token: 0x0400367A RID: 13946
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400367B RID: 13947
		[RequiredField]
		[Tooltip("The frame per seconds of the current clip")]
		public FsmFloat framePerSeconds;

		// Token: 0x0400367C RID: 13948
		[Tooltip("Repeat every Frame")]
		public bool everyFrame;

		// Token: 0x0400367D RID: 13949
		private tk2dSpriteAnimator _sprite;
	}
}
