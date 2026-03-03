using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A91 RID: 2705
	[ActionCategory("uGui")]
	[Tooltip("Sets the source image sprite of a UGui Image component.")]
	public class uGuiImageSetSprite : FsmStateAction
	{
		// Token: 0x06003A44 RID: 14916 RVA: 0x00153963 File Offset: 0x00151B63
		public override void Reset()
		{
			this.gameObject = null;
			this.resetOnExit = false;
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x00153978 File Offset: 0x00151B78
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._image = ownerDefaultTarget.GetComponent<Image>();
			}
			this.DoSetImageSourceValue();
			base.Finish();
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x001539B8 File Offset: 0x00151BB8
		private void DoSetImageSourceValue()
		{
			if (this._image == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._originalSprite = this._image.sprite;
			}
			this._image.sprite = (Sprite)this.sprite.Value;
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00153A0D File Offset: 0x00151C0D
		public override void OnExit()
		{
			if (this._image == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._image.sprite = this._originalSprite;
			}
		}

		// Token: 0x04003D9F RID: 15775
		[RequiredField]
		[CheckForComponent(typeof(Image))]
		[Tooltip("The GameObject with the Image ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003DA0 RID: 15776
		[RequiredField]
		[Tooltip("The source sprite of the UGui Image component.")]
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;

		// Token: 0x04003DA1 RID: 15777
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003DA2 RID: 15778
		private Image _image;

		// Token: 0x04003DA3 RID: 15779
		private Sprite _originalSprite;
	}
}
