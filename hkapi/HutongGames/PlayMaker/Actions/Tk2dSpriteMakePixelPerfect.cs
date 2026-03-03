using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200096B RID: 2411
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Make a sprite pixelPerfect. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteMakePixelPerfect : FsmStateAction
	{
		// Token: 0x060034EF RID: 13551 RVA: 0x0013ADD0 File Offset: 0x00138FD0
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x0013AE05 File Offset: 0x00139005
		public override void Reset()
		{
			this.gameObject = null;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x0013AE0E File Offset: 0x0013900E
		public override void OnEnter()
		{
			this._getSprite();
			this.MakePixelPerfect();
			base.Finish();
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x0013AE22 File Offset: 0x00139022
		private void MakePixelPerfect()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component: ");
				return;
			}
			this._sprite.MakePixelPerfect();
		}

		// Token: 0x04003697 RID: 13975
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003698 RID: 13976
		private tk2dBaseSprite _sprite;
	}
}
