using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A90 RID: 2704
	[ActionCategory("uGui")]
	[Tooltip("Gets the source image sprite of a UGui Image component.")]
	public class uGuiImageGetSprite : FsmStateAction
	{
		// Token: 0x06003A40 RID: 14912 RVA: 0x001538E6 File Offset: 0x00151AE6
		public override void Reset()
		{
			this.gameObject = null;
			this.sprite = null;
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x001538F8 File Offset: 0x00151AF8
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

		// Token: 0x06003A42 RID: 14914 RVA: 0x00153938 File Offset: 0x00151B38
		private void DoSetImageSourceValue()
		{
			if (this._image != null)
			{
				this._image.sprite = (Sprite)this.sprite.Value;
			}
		}

		// Token: 0x04003D9C RID: 15772
		[RequiredField]
		[CheckForComponent(typeof(Image))]
		[Tooltip("The GameObject with the Image ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003D9D RID: 15773
		[RequiredField]
		[Tooltip("The source sprite of the UGui Image component.")]
		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(Sprite))]
		public FsmObject sprite;

		// Token: 0x04003D9E RID: 15774
		private Image _image;
	}
}
