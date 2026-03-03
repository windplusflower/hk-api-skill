using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000970 RID: 2416
	[ActionCategory("2D Toolkit/Sprite")]
	[Tooltip("Tween a sprite color \nNOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite)")]
	public class Tk2dSpriteTweenColor : FsmStateAction
	{
		// Token: 0x0600350B RID: 13579 RVA: 0x0013B1EA File Offset: 0x001393EA
		public override void Reset()
		{
			this.gameObject = null;
			this.color = null;
			this.duration = null;
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0013B204 File Offset: 0x00139404
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget == null)
			{
				return;
			}
			this.sprite = ownerDefaultTarget.GetComponent<tk2dBaseSprite>();
			iTween.ValueTo(ownerDefaultTarget, new Hashtable
			{
				{
					"from",
					this.sprite.color
				},
				{
					"to",
					this.color.Value
				},
				{
					"time",
					this.duration.Value
				},
				{
					"OnUpdate",
					"updateSpriteColor"
				},
				{
					"looptype",
					iTween.LoopType.pingPong
				},
				{
					"easetype",
					iTween.EaseType.linear
				}
			});
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x0013B2CA File Offset: 0x001394CA
		private void updateSpriteColor(Color color)
		{
			this.sprite.color = color;
			Debug.Log("wow");
		}

		// Token: 0x040036AA RID: 13994
		[RequiredField]
		[Tooltip("The Game Object to work with. NOTE: The Game Object must have a tk2dBaseSprite or derived component attached ( tk2dSprite, tk2dAnimatedSprite).")]
		[CheckForComponent(typeof(tk2dBaseSprite))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040036AB RID: 13995
		[RequiredField]
		[UIHint(UIHint.FsmColor)]
		public FsmColor color;

		// Token: 0x040036AC RID: 13996
		[RequiredField]
		public FsmFloat duration;

		// Token: 0x040036AD RID: 13997
		private tk2dBaseSprite sprite;
	}
}
