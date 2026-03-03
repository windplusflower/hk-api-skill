using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A70 RID: 2672
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Randomly set the sprite id of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteSetIdRandom : FsmStateAction
	{
		// Token: 0x0600399B RID: 14747 RVA: 0x0014FF90 File Offset: 0x0014E190
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x0014FFC5 File Offset: 0x0014E1C5
		public override void Reset()
		{
			this.gameObject = null;
			this.spriteCollection = new FsmGameObject
			{
				UseVariable = true
			};
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x0014FFE0 File Offset: 0x0014E1E0
		public override void OnEnter()
		{
			this._getSprite();
			this.DoSetSpriteID();
			base.Finish();
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x0014FFF4 File Offset: 0x0014E1F4
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
			int newSpriteId = UnityEngine.Random.Range(0, collection.Count + 1);
			this._sprite.SetSprite(collection, newSpriteId);
		}

		// Token: 0x04003C9C RID: 15516
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003C9D RID: 15517
		[CheckForComponent(typeof(tk2dSpriteCollection))]
		public FsmGameObject spriteCollection;

		// Token: 0x04003C9E RID: 15518
		private tk2dBaseSprite _sprite;
	}
}
