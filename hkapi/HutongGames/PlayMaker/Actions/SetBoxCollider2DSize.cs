using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A3C RID: 2620
	[ActionCategory("Physics 2d")]
	[Tooltip("Set the dimensions of the first BoxCollider 2D on object")]
	public class SetBoxCollider2DSize : FsmStateAction
	{
		// Token: 0x060038D5 RID: 14549 RVA: 0x0014C76C File Offset: 0x0014A96C
		public override void Reset()
		{
			this.width = new FsmFloat
			{
				UseVariable = true
			};
			this.height = new FsmFloat
			{
				UseVariable = true
			};
			this.offsetX = new FsmFloat
			{
				UseVariable = true
			};
			this.offsetY = new FsmFloat
			{
				UseVariable = true
			};
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0014C7C4 File Offset: 0x0014A9C4
		public void SetDimensions()
		{
			BoxCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject1).GetComponent<BoxCollider2D>();
			Vector2 size = component.size;
			if (!this.width.IsNone)
			{
				size.x = this.width.Value;
			}
			if (!this.height.IsNone)
			{
				size.y = this.height.Value;
			}
			if (!this.offsetX.IsNone)
			{
				component.offset = new Vector3(this.offsetX.Value, component.offset.y);
			}
			if (!this.offsetY.IsNone)
			{
				component.offset = new Vector3(component.offset.x, this.offsetY.Value);
			}
			component.size = size;
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x0014C89A File Offset: 0x0014AA9A
		public override void OnEnter()
		{
			this.SetDimensions();
			base.Finish();
		}

		// Token: 0x04003B7E RID: 15230
		[RequiredField]
		public FsmOwnerDefault gameObject1;

		// Token: 0x04003B7F RID: 15231
		public FsmFloat width;

		// Token: 0x04003B80 RID: 15232
		public FsmFloat height;

		// Token: 0x04003B81 RID: 15233
		public FsmFloat offsetX;

		// Token: 0x04003B82 RID: 15234
		public FsmFloat offsetY;
	}
}
