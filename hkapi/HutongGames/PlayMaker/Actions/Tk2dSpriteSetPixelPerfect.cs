using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200096E RID: 2414
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Set the pixel perfect flag of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteSetPixelPerfect : FsmStateAction
	{
		// Token: 0x060034FF RID: 13567 RVA: 0x0013B064 File Offset: 0x00139264
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x0013B099 File Offset: 0x00139299
		public override void Reset()
		{
			this.gameObject = null;
			this.pixelPerfect = null;
			this.everyframe = false;
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x0013B0B0 File Offset: 0x001392B0
		public override void OnEnter()
		{
			this._getSprite();
			this.DoSetSpritePixelPerfect();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x0013B0CC File Offset: 0x001392CC
		public override void OnUpdate()
		{
			this.DoSetSpritePixelPerfect();
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x0013B0D4 File Offset: 0x001392D4
		private void DoSetSpritePixelPerfect()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component");
				return;
			}
			if (this.pixelPerfect.Value)
			{
				this._sprite.MakePixelPerfect();
			}
		}

		// Token: 0x040036A2 RID: 13986
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036A3 RID: 13987
		[Tooltip("Does the sprite needs to be kept pixelPerfect? This is only necessary when using a perspective camera.")]
		[UIHint(UIHint.FsmBool)]
		public FsmBool pixelPerfect;

		// Token: 0x040036A4 RID: 13988
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x040036A5 RID: 13989
		private tk2dBaseSprite _sprite;
	}
}
