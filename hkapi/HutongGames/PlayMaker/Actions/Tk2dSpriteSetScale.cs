using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200096F RID: 2415
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Set the scale of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteSetScale : FsmStateAction
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x0013B108 File Offset: 0x00139308
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0013B13D File Offset: 0x0013933D
		public override void Reset()
		{
			this.gameObject = null;
			this.scale = new Vector3(1f, 1f, 1f);
			this.everyframe = false;
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0013B16C File Offset: 0x0013936C
		public override void OnEnter()
		{
			this._getSprite();
			this.DoSetSpriteScale();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x0013B188 File Offset: 0x00139388
		public override void OnUpdate()
		{
			this.DoSetSpriteScale();
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x0013B190 File Offset: 0x00139390
		private void DoSetSpriteScale()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component");
				return;
			}
			if (this._sprite.scale != this.scale.Value)
			{
				this._sprite.scale = this.scale.Value;
			}
		}

		// Token: 0x040036A6 RID: 13990
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036A7 RID: 13991
		[Tooltip("The scale Id")]
		[UIHint(UIHint.FsmVector3)]
		public FsmVector3 scale;

		// Token: 0x040036A8 RID: 13992
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036A9 RID: 13993
		private tk2dBaseSprite _sprite;
	}
}
