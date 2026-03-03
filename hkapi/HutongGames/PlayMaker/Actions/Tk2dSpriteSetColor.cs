using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200096C RID: 2412
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Set the color of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteSetColor : FsmStateAction
	{
		// Token: 0x060034F4 RID: 13556 RVA: 0x0013AE4C File Offset: 0x0013904C
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x0013AE81 File Offset: 0x00139081
		public override void Reset()
		{
			this.gameObject = null;
			this.color = null;
			this.everyframe = false;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x0013AE98 File Offset: 0x00139098
		public override void OnEnter()
		{
			this._getSprite();
			this.DoSetSpriteColor();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x0013AEB4 File Offset: 0x001390B4
		public override void OnUpdate()
		{
			this.DoSetSpriteColor();
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x0013AEBC File Offset: 0x001390BC
		private void DoSetSpriteColor()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component");
				return;
			}
			if (this._sprite.color != this.color.Value)
			{
				this._sprite.color = this.color.Value;
			}
		}

		// Token: 0x04003699 RID: 13977
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400369A RID: 13978
		[Tooltip("The color")]
		[UIHint(UIHint.FsmColor)]
		public FsmColor color;

		// Token: 0x0400369B RID: 13979
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x0400369C RID: 13980
		private tk2dBaseSprite _sprite;
	}
}
