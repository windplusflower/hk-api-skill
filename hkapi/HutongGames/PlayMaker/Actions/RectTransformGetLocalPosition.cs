using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A13 RID: 2579
	[ActionCategory("RectTransform")]
	[Tooltip("Get the Local position of this RectTransform. This is Screen Space values using the anchoring as reference, so 0,0 is the center of the screen if the anchor is te center of the screen.")]
	public class RectTransformGetLocalPosition : FsmStateActionAdvanced
	{
		// Token: 0x0600381F RID: 14367 RVA: 0x00149650 File Offset: 0x00147850
		public override void Reset()
		{
			base.Reset();
			this.gameObject = null;
			this.reference = RectTransformGetLocalPosition.LocalPositionReference.Anchor;
			this.position = null;
			this.position2d = null;
			this.x = null;
			this.y = null;
			this.z = null;
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x0014968C File Offset: 0x0014788C
		public override void OnEnter()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			if (ownerDefaultTarget != null)
			{
				this._rt = ownerDefaultTarget.GetComponent<RectTransform>();
			}
			this.DoGetValues();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x001496D4 File Offset: 0x001478D4
		public override void OnActionUpdate()
		{
			this.DoGetValues();
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x001496DC File Offset: 0x001478DC
		private void DoGetValues()
		{
			if (this._rt == null)
			{
				return;
			}
			Vector3 localPosition = this._rt.localPosition;
			if (this.reference == RectTransformGetLocalPosition.LocalPositionReference.CenterPosition)
			{
				localPosition.x += this._rt.rect.center.x;
				localPosition.y += this._rt.rect.center.y;
			}
			if (!this.position.IsNone)
			{
				this.position.Value = localPosition;
			}
			if (!this.position2d.IsNone)
			{
				this.position2d.Value = new Vector2(localPosition.x, localPosition.y);
			}
			if (!this.x.IsNone)
			{
				this.x.Value = localPosition.x;
			}
			if (!this.y.IsNone)
			{
				this.y.Value = localPosition.y;
			}
			if (!this.z.IsNone)
			{
				this.z.Value = localPosition.z;
			}
		}

		// Token: 0x04003AAD RID: 15021
		[RequiredField]
		[CheckForComponent(typeof(RectTransform))]
		[Tooltip("The GameObject target.")]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003AAE RID: 15022
		public RectTransformGetLocalPosition.LocalPositionReference reference;

		// Token: 0x04003AAF RID: 15023
		[Tooltip("The position")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 position;

		// Token: 0x04003AB0 RID: 15024
		[Tooltip("The position in a Vector 2d ")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 position2d;

		// Token: 0x04003AB1 RID: 15025
		[Tooltip("The x component of the Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat x;

		// Token: 0x04003AB2 RID: 15026
		[Tooltip("The y component of the Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat y;

		// Token: 0x04003AB3 RID: 15027
		[Tooltip("The z component of the Position")]
		[UIHint(UIHint.Variable)]
		public FsmFloat z;

		// Token: 0x04003AB4 RID: 15028
		private RectTransform _rt;

		// Token: 0x02000A14 RID: 2580
		public enum LocalPositionReference
		{
			// Token: 0x04003AB6 RID: 15030
			Anchor,
			// Token: 0x04003AB7 RID: 15031
			CenterPosition
		}
	}
}
