using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200096D RID: 2413
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Set the sprite id of a sprite. Can use id or name. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteSetId : FsmStateAction
	{
		// Token: 0x060034FA RID: 13562 RVA: 0x0013AF18 File Offset: 0x00139118
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x0013AF4D File Offset: 0x0013914D
		public override void Reset()
		{
			this.gameObject = null;
			this.spriteID = null;
			this.ORSpriteName = null;
			this.spriteCollection = new FsmGameObject
			{
				UseVariable = true
			};
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x0013AF76 File Offset: 0x00139176
		public override void OnEnter()
		{
			this._getSprite();
			this.DoSetSpriteID();
			base.Finish();
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x0013AF8C File Offset: 0x0013918C
		private void DoSetSpriteID()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component: " + this._sprite.gameObject.name);
				return;
			}
			tk2dSpriteCollectionData collection = this._sprite.Collection;
			if (!this.spriteCollection.IsNone)
			{
				GameObject value = this.spriteCollection.Value;
				if (value != null)
				{
					tk2dSpriteCollection component = value.GetComponent<tk2dSpriteCollection>();
					if (component != null)
					{
						collection = component.spriteCollection;
					}
				}
			}
			int value2 = this.spriteID.Value;
			if (this.ORSpriteName.Value != "")
			{
				this._sprite.SetSprite(collection, this.ORSpriteName.Value);
				return;
			}
			if (value2 != this._sprite.spriteId)
			{
				this._sprite.SetSprite(collection, value2);
			}
		}

		// Token: 0x0400369D RID: 13981
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400369E RID: 13982
		[Tooltip("The sprite Id")]
		[UIHint(UIHint.FsmInt)]
		public FsmInt spriteID;

		// Token: 0x0400369F RID: 13983
		[Tooltip("OR The sprite name ")]
		[UIHint(UIHint.FsmString)]
		public FsmString ORSpriteName;

		// Token: 0x040036A0 RID: 13984
		[CheckForComponent(typeof(tk2dSpriteCollection))]
		public FsmGameObject spriteCollection;

		// Token: 0x040036A1 RID: 13985
		private tk2dBaseSprite _sprite;
	}
}
