using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A3D RID: 2621
	[ActionCategory("Physics 2d")]
	[Tooltip("Set the dimensions of the first BoxCollider 2D on object. Uses vector2s")]
	public class SetBoxCollider2DSizeVector : FsmStateAction
	{
		// Token: 0x060038D9 RID: 14553 RVA: 0x0014C8A8 File Offset: 0x0014AAA8
		public override void Reset()
		{
			this.size = new FsmVector2
			{
				UseVariable = true
			};
			this.offset = new FsmVector2
			{
				UseVariable = true
			};
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0014C8D0 File Offset: 0x0014AAD0
		public void SetDimensions()
		{
			BoxCollider2D component = base.Fsm.GetOwnerDefaultTarget(this.gameObject1).GetComponent<BoxCollider2D>();
			if (!this.size.IsNone)
			{
				component.size = this.size.Value;
			}
			if (!this.offset.IsNone)
			{
				component.offset = this.offset.Value;
			}
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0014C930 File Offset: 0x0014AB30
		public override void OnEnter()
		{
			this.SetDimensions();
			base.Finish();
		}

		// Token: 0x04003B83 RID: 15235
		[RequiredField]
		public FsmOwnerDefault gameObject1;

		// Token: 0x04003B84 RID: 15236
		public FsmVector2 size;

		// Token: 0x04003B85 RID: 15237
		public FsmVector2 offset;
	}
}
