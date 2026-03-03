using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000967 RID: 2407
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Get the color of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteGetColor : FsmStateAction
	{
		// Token: 0x060034DA RID: 13530 RVA: 0x0013AB58 File Offset: 0x00138D58
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0013AB8D File Offset: 0x00138D8D
		public override void Reset()
		{
			this.gameObject = null;
			this.color = null;
			this.everyframe = false;
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0013ABA4 File Offset: 0x00138DA4
		public override void OnEnter()
		{
			this._getSprite();
			this.DoGetSpriteColor();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0013ABC0 File Offset: 0x00138DC0
		public override void OnUpdate()
		{
			this.DoGetSpriteColor();
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0013ABC8 File Offset: 0x00138DC8
		private void DoGetSpriteColor()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component");
				return;
			}
			if (this._sprite.color != this.color.Value)
			{
				this.color.Value = this._sprite.color;
			}
		}

		// Token: 0x04003689 RID: 13961
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400368A RID: 13962
		[Tooltip("The color")]
		[UIHint(UIHint.Variable)]
		public FsmColor color;

		// Token: 0x0400368B RID: 13963
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x0400368C RID: 13964
		private tk2dBaseSprite _sprite;
	}
}
