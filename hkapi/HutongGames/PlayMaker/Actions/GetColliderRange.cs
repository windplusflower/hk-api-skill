using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x020009D1 RID: 2513
	[ActionCategory("Physics 2d")]
	[Tooltip("Returns the X/Y Min and max bounds for a box2d collider (in world space)")]
	public class GetColliderRange : FsmStateAction
	{
		// Token: 0x060036F7 RID: 14071 RVA: 0x00143FB3 File Offset: 0x001421B3
		public override void Reset()
		{
			this.gameObject = null;
			this.minX = null;
			this.maxX = null;
			this.minY = null;
			this.maxY = null;
			this.everyFrame = false;
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00143FE0 File Offset: 0x001421E0
		public void GetRange()
		{
			GameObject ownerDefaultTarget = base.Fsm.GetOwnerDefaultTarget(this.gameObject);
			BoxCollider2D component = ownerDefaultTarget.GetComponent<BoxCollider2D>();
			Vector2 size = component.size;
			Vector3 vector = ownerDefaultTarget.transform.TransformPoint(component.offset);
			this.maxY.Value = vector.y + size.y / 2f;
			this.minY.Value = vector.y - size.y / 2f;
			this.minX.Value = vector.x - size.x / 2f;
			this.maxX.Value = vector.x + size.x / 2f;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x0014409A File Offset: 0x0014229A
		public override void OnEnter()
		{
			this.GetRange();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x001440B0 File Offset: 0x001422B0
		public override void OnUpdate()
		{
			this.GetRange();
		}

		// Token: 0x04003911 RID: 14609
		[RequiredField]
		public FsmOwnerDefault gameObject;

		// Token: 0x04003912 RID: 14610
		[UIHint(UIHint.Variable)]
		public FsmFloat minX;

		// Token: 0x04003913 RID: 14611
		[UIHint(UIHint.Variable)]
		public FsmFloat maxX;

		// Token: 0x04003914 RID: 14612
		[UIHint(UIHint.Variable)]
		public FsmFloat minY;

		// Token: 0x04003915 RID: 14613
		[UIHint(UIHint.Variable)]
		public FsmFloat maxY;

		// Token: 0x04003916 RID: 14614
		public bool everyFrame;
	}
}
