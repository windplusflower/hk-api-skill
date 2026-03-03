using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A1D RID: 2589
	[ActionCategory("RectTransform")]
	[Tooltip("Given a rect transform, return the corner points in pixel accurate coordinates.")]
	public class RectTransformPixelAdjustRect : FsmStateActionAdvanced
	{
		// Token: 0x0600384C RID: 14412 RVA: 0x0014A091 File Offset: 0x00148291
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.canvas = new FsmGameObject
			{
				UseVariable = true
			};
			this.pixelRect = null;
		}

		// Token: 0x0600384D RID: 14413 RVA: 0x0014A0BC File Offset: 0x001482BC
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			GameObject value = this.canvas.Value;
			if (value != null)
			{
				this._canvas = value.GetComponent<Canvas>();
			}
			if (this._canvas == null && ownerDefaultTarget != null)
			{
				Graphic component = ownerDefaultTarget.GetComponent<Graphic>();
				if (component != null)
				{
					this._canvas = component.canvas;
				}
			}
			this.DoAction();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600384E RID: 14414 RVA: 0x0014A158 File Offset: 0x00148358
		public override void OnActionUpdate()
		{
			this.DoAction();
		}

		// Token: 0x0600384F RID: 14415 RVA: 0x0014A160 File Offset: 0x00148360
		private void DoAction()
		{
			this.pixelRect.Value = RectTransformUtility.PixelAdjustRect(this._rt, this._canvas);
		}

		// Token: 0x04003AE3 RID: 15075
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AE4 RID: 15076
		[RequiredField]
		[CheckForComponent(typeof(Canvas))]
		[Tooltip("The canvas. Leave to none to use the canvas of the gameObject")]
		public FsmGameObject canvas;

		// Token: 0x04003AE5 RID: 15077
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("Pixel adjusted rect.")]
		[UIHint(UIHint.Variable)]
		public FsmRect pixelRect;

		// Token: 0x04003AE6 RID: 15078
		private RectTransform _rt;

		// Token: 0x04003AE7 RID: 15079
		private Canvas _canvas;
	}
}
