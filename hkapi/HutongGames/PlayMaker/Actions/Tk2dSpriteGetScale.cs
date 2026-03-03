using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200096A RID: 2410
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Get the scale of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteGetScale : FsmStateAction
	{
		// Token: 0x060034E9 RID: 13545 RVA: 0x0013AD04 File Offset: 0x00138F04
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x0013AD39 File Offset: 0x00138F39
		public override void Reset()
		{
			this.gameObject = null;
			this.scale = null;
			this.everyframe = false;
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x0013AD50 File Offset: 0x00138F50
		public override void OnEnter()
		{
			this._getSprite();
			this.DoGetSpriteScale();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x0013AD6C File Offset: 0x00138F6C
		public override void OnUpdate()
		{
			this.DoGetSpriteScale();
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x0013AD74 File Offset: 0x00138F74
		private void DoGetSpriteScale()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component");
				return;
			}
			if (this._sprite.scale != this.scale.Value)
			{
				this.scale.Value = this._sprite.scale;
			}
		}

		// Token: 0x04003693 RID: 13971
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003694 RID: 13972
		[Tooltip("The scale Id")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 scale;

		// Token: 0x04003695 RID: 13973
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x04003696 RID: 13974
		private tk2dBaseSprite _sprite;
	}
}
