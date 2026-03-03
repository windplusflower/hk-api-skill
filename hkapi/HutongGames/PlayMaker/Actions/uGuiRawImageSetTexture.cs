using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000AA6 RID: 2726
	[ActionCategory("uGui")]
	[Tooltip("Sets the texture of a UGui RawImage component.")]
	public class uGuiRawImageSetTexture : FsmStateAction
	{
		// Token: 0x06003AAE RID: 15022 RVA: 0x001548FB File Offset: 0x00152AFB
		public override void Reset()
		{
			this.gameObject = null;
			this.texture = null;
			this.resetOnExit = null;
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00154914 File Offset: 0x00152B14
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._texture = ownerDefaultTarget.GetComponent<RawImage>();
			}
			if (this.resetOnExit.Value)
			{
				this._originalTexture = this._texture.texture;
			}
			this.DoSetValue();
			base.Finish();
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00154972 File Offset: 0x00152B72
		private void DoSetValue()
		{
			if (this._texture != null)
			{
				this._texture.texture = this.texture.Value;
			}
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00154998 File Offset: 0x00152B98
		public override void OnExit()
		{
			if (this._texture == null)
			{
				return;
			}
			if (this.resetOnExit.Value)
			{
				this._texture.texture = this._originalTexture;
			}
		}

		// Token: 0x04003E00 RID: 15872
		[RequiredField]
		[CheckForComponent(typeof(RawImage))]
		[Tooltip("The GameObject with the RawImage ui component.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003E01 RID: 15873
		[RequiredField]
		[Tooltip("The texture of the UGui RawImage component.")]
		public FsmTexture texture;

		// Token: 0x04003E02 RID: 15874
		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		// Token: 0x04003E03 RID: 15875
		private RawImage _texture;

		// Token: 0x04003E04 RID: 15876
		private Texture _originalTexture;
	}
}
