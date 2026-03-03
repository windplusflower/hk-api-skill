using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000968 RID: 2408
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Get the sprite id of a sprite. \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
	public class Tk2dSpriteGetId : FsmStateAction
	{
		// Token: 0x060034E0 RID: 13536 RVA: 0x0013AC24 File Offset: 0x00138E24
		private void _getSprite()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this._sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0013AC59 File Offset: 0x00138E59
		public override void Reset()
		{
			this.gameObject = null;
			this.spriteID = null;
			this.everyframe = false;
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0013AC70 File Offset: 0x00138E70
		public override void OnEnter()
		{
			this._getSprite();
			this.DoGetSpriteID();
			if (!this.everyframe)
			{
				base.Finish();
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0013AC8C File Offset: 0x00138E8C
		public override void OnUpdate()
		{
			this.DoGetSpriteID();
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0013AC94 File Offset: 0x00138E94
		private void DoGetSpriteID()
		{
			if (this._sprite == null)
			{
				base.LogWarning("Missing tk2dBaseSprite component");
				return;
			}
			if (this.spriteID.Value != this._sprite.spriteId)
			{
				this.spriteID.Value = this._sprite.spriteId;
			}
		}

		// Token: 0x0400368D RID: 13965
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400368E RID: 13966
		[Tooltip("The sprite Id")]
		[UIHint(UIHint.FsmInt)]
		public FsmInt spriteID;

		// Token: 0x0400368F RID: 13967
		[ActionSection("")]
		[Tooltip("Repeat every frame.")]
		public bool everyframe;

		// Token: 0x04003690 RID: 13968
		private tk2dBaseSprite _sprite;
	}
}
