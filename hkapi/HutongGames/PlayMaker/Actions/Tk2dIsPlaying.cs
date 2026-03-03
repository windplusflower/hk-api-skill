using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200095E RID: 2398
	[ActionCategory("2D Toolkit/SpriteAnimator")]
	[Tooltip("Check if a sprite animation is playing. \nNOTE: The Game Object must have a tk2dSpriteAnimator attached.")]
	[HelpUrl("https://hutonggames.fogbugz.com/default.asp?W720")]
	public class Tk2dIsPlaying : FsmStateAction
	{
		// Token: 0x060034A5 RID: 13477 RVA: 0x0013A2C8 File Offset: 0x001384C8
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dSpriteAnimator>();
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x0013A2FD File Offset: 0x001384FD
		public override void Reset()
		{
			this.gameObject = null;
			this.clipName = null;
			this.everyframe = false;
			this.isPlayingEvent = null;
			this.isNotPlayingEvent = null;
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x0013A322 File Offset: 0x00138522
		public override void OnEnter()
		{
			this._getSprite();
			this.DoIsPlaying();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0013A33E File Offset: 0x0013853E
		public override void OnUpdate()
		{
			this.DoIsPlaying();
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x0013A348 File Offset: 0x00138548
		private void DoIsPlaying()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dSpriteAnimator component: " + this._sprite.gameObject.name);
				return;
			}
			bool flag = this._sprite.IsPlaying(this.clipName.Value);
			this.isPlaying.Value = flag;
			if (flag)
			{
				base.Fsm.Event(this.isPlayingEvent);
				return;
			}
			base.Fsm.Event(this.isNotPlayingEvent);
		}

		// Token: 0x04003664 RID: 13924
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dSpriteAnimator component attached.")]
		[CheckForComponent(typeof(tk2dSpriteAnimator))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003665 RID: 13925
		[RequiredField]
		[Tooltip("The clip name to play")]
		public FsmString clipName;

		// Token: 0x04003666 RID: 13926
		[Tooltip("is the clip playing?")]
		[UIHint(UIHint.Variable)]
		public FsmBool isPlaying;

		// Token: 0x04003667 RID: 13927
		[Tooltip("EVvnt sent if clip is playing")]
		public FsmEvent isPlayingEvent;

		// Token: 0x04003668 RID: 13928
		[Tooltip("Event sent if clip is not playing")]
		public FsmEvent isNotPlayingEvent;

		// Token: 0x04003669 RID: 13929
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x0400366A RID: 13930
		private tk2dSpriteAnimator _sprite;
	}
}
