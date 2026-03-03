using System;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A1C RID: 2588
	[ActionCategory("RectTransform")]
	[Tooltip("Convert a given point in screen space into a pixel correct point.")]
	public class RectTransformPixelAdjustPoint : FsmStateActionAdvanced
	{
		// Token: 0x06003847 RID: 14407 RVA: 0x00149F94 File Offset: 0x00148194
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.canvas = new FsmGameObject
			{
				UseVariable = true
			};
			this.screenPoint = null;
			this.pixelPoint = null;
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x00149FC4 File Offset: 0x001481C4
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

		// Token: 0x06003849 RID: 14409 RVA: 0x0014A060 File Offset: 0x00148260
		public override void OnActionUpdate()
		{
			this.DoAction();
		}

		// Token: 0x0600384A RID: 14410 RVA: 0x0014A068 File Offset: 0x00148268
		private void DoAction()
		{
			this.pixelPoint.Value = RectTransformUtility.PixelAdjustPoint(this.screenPoint.Value, this._rt, this._canvas);
		}

		// Token: 0x04003ADD RID: 15069
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003ADE RID: 15070
		[RequiredField]
		[CheckForComponent(typeof(Canvas))]
		[Tooltip("The canvas. Leave to none to use the canvas of the gameObject")]
		public FsmGameObject canvas;

		// Token: 0x04003ADF RID: 15071
		[Tooltip("The screen position.")]
		public FsmVector2 screenPoint;

		// Token: 0x04003AE0 RID: 15072
		[ActionSection("Result")]
		[RequiredField]
		[Tooltip("Pixel adjusted point from the screen position.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 pixelPoint;

		// Token: 0x04003AE1 RID: 15073
		private RectTransform _rt;

		// Token: 0x04003AE2 RID: 15074
		private Canvas _canvas;
	}
}
