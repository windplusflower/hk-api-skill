using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A20 RID: 2592
	[ActionCategory("RectTransform")]
	[Tooltip("The position ( normalized or not) in the parent RectTransform keeping the anchor rect size intact. This lets you position the whole Rect in one go. Use this to easily animate movement (like IOS sliding UIView)")]
	public class RectTransformSetAnchorRectPosition : FsmStateActionAdvanced
	{
		// Token: 0x0600385B RID: 14427 RVA: 0x0014A38C File Offset: 0x0014858C
		public override void Reset()
		{
			base.Reset();
			this.normalized = true;
			this.gameObject = null;
			this.anchorReference = RectTransformSetAnchorRectPosition.AnchorReference.BottomLeft;
			this.anchor = null;
			this.x = new FsmFloat
			{
				UseVariable = true
			};
			this.y = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x0014A3E4 File Offset: 0x001485E4
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoSetAnchor();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0014A42C File Offset: 0x0014862C
		public override void OnActionUpdate()
		{
			this.DoSetAnchor();
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x0014A434 File Offset: 0x00148634
		private void DoSetAnchor()
		{
			this._anchorRect = default(Rect);
			this._anchorRect.min = this._rt.anchorMin;
			this._anchorRect.max = this._rt.anchorMax;
			Vector2 vector = Vector2.zero;
			vector = this._anchorRect.min;
			if (!this.anchor.IsNone)
			{
				if (this.normalized.Value)
				{
					vector = this.anchor.Value;
				}
				else
				{
					vector.x = this.anchor.Value.x / (float)Screen.width;
					vector.y = this.anchor.Value.y / (float)Screen.height;
				}
			}
			if (!this.x.IsNone)
			{
				if (this.normalized.Value)
				{
					vector.x = this.x.Value;
				}
				else
				{
					vector.x = this.x.Value / (float)Screen.width;
				}
			}
			if (!this.y.IsNone)
			{
				if (this.normalized.Value)
				{
					vector.y = this.y.Value;
				}
				else
				{
					vector.y = this.y.Value / (float)Screen.height;
				}
			}
			if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.BottomLeft)
			{
				this._anchorRect.x = vector.x;
				this._anchorRect.y = vector.y;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.Left)
			{
				this._anchorRect.x = vector.x;
				this._anchorRect.y = vector.y - 0.5f;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.TopLeft)
			{
				this._anchorRect.x = vector.x;
				this._anchorRect.y = vector.y - 1f;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.Top)
			{
				this._anchorRect.x = vector.x - 0.5f;
				this._anchorRect.y = vector.y - 1f;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.TopRight)
			{
				this._anchorRect.x = vector.x - 1f;
				this._anchorRect.y = vector.y - 1f;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.Right)
			{
				this._anchorRect.x = vector.x - 1f;
				this._anchorRect.y = vector.y - 0.5f;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.BottomRight)
			{
				this._anchorRect.x = vector.x - 1f;
				this._anchorRect.y = vector.y;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.Bottom)
			{
				this._anchorRect.x = vector.x - 0.5f;
				this._anchorRect.y = vector.y;
			}
			else if (this.anchorReference == RectTransformSetAnchorRectPosition.AnchorReference.Center)
			{
				this._anchorRect.x = vector.x - 0.5f;
				this._anchorRect.y = vector.y - 0.5f;
			}
			this._rt.anchorMin = this._anchorRect.min;
			this._rt.anchorMax = this._anchorRect.max;
		}

		// Token: 0x04003AF2 RID: 15090
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AF3 RID: 15091
		[Tooltip("The reference for the given position")]
		public RectTransformSetAnchorRectPosition.AnchorReference anchorReference;

		// Token: 0x04003AF4 RID: 15092
		[Tooltip("Are the supplied screen coordinates normalized (0-1), or in pixels.")]
		public FsmBool normalized;

		// Token: 0x04003AF5 RID: 15093
		[Tooltip("The Vector2 position, and/or set individual axis below.")]
		public FsmVector2 anchor;

		// Token: 0x04003AF6 RID: 15094
		[HasFloatSlider(0f, 1f)]
		public FsmFloat x;

		// Token: 0x04003AF7 RID: 15095
		[HasFloatSlider(0f, 1f)]
		public FsmFloat y;

		// Token: 0x04003AF8 RID: 15096
		private RectTransform _rt;

		// Token: 0x04003AF9 RID: 15097
		private Rect _anchorRect;

		// Token: 0x02000A21 RID: 2593
		public enum AnchorReference
		{
			// Token: 0x04003AFB RID: 15099
			TopLeft,
			// Token: 0x04003AFC RID: 15100
			Top,
			// Token: 0x04003AFD RID: 15101
			TopRight,
			// Token: 0x04003AFE RID: 15102
			Right,
			// Token: 0x04003AFF RID: 15103
			BottomRight,
			// Token: 0x04003B00 RID: 15104
			Bottom,
			// Token: 0x04003B01 RID: 15105
			BottomLeft,
			// Token: 0x04003B02 RID: 15106
			Left,
			// Token: 0x04003B03 RID: 15107
			Center
		}
	}
}
