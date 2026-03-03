using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000A7C RID: 2684
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends Events based on the comparison of 2 Vector3's.")]
	public class Vector3Compare : FsmStateAction
	{
		// Token: 0x060039DD RID: 14813 RVA: 0x00151A26 File Offset: 0x0014FC26
		public override void Reset()
		{
			this.vector3Variable1 = null;
			this.vector3Variable2 = null;
			this.tolerance = 0f;
			this.equal = null;
			this.notEqual = null;
			this.everyFrame = false;
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00151A5B File Offset: 0x0014FC5B
		public override void OnEnter()
		{
			this.DoCompare();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00151A71 File Offset: 0x0014FC71
		public override void OnUpdate()
		{
			this.DoCompare();
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00151A7C File Offset: 0x0014FC7C
		private void DoCompare()
		{
			if (this.vector3Variable1 == null || this.vector3Variable2 == null)
			{
				return;
			}
			if (Mathf.Abs(this.vector3Variable1.Value.x - this.vector3Variable2.Value.x) <= this.tolerance.Value && Mathf.Abs(this.vector3Variable1.Value.y - this.vector3Variable2.Value.y) <= this.tolerance.Value && Mathf.Abs(this.vector3Variable1.Value.z - this.vector3Variable2.Value.z) <= this.tolerance.Value)
			{
				base.Fsm.Event(this.equal);
				return;
			}
			base.Fsm.Event(this.notEqual);
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00151B56 File Offset: 0x0014FD56
		public override string ErrorCheck()
		{
			if (FsmEvent.IsNullOrEmpty(this.equal) && FsmEvent.IsNullOrEmpty(this.notEqual))
			{
				return "Action sends no events!";
			}
			return "";
		}

		// Token: 0x04003CF6 RID: 15606
		[RequiredField]
		public FsmVector3 vector3Variable1;

		// Token: 0x04003CF7 RID: 15607
		[RequiredField]
		public FsmVector3 vector3Variable2;

		// Token: 0x04003CF8 RID: 15608
		[RequiredField]
		public FsmFloat tolerance;

		// Token: 0x04003CF9 RID: 15609
		[Tooltip("Event sent if Vector3 1 equals Vector3 2 (within Tolerance)")]
		public FsmEvent equal;

		// Token: 0x04003CFA RID: 15610
		[Tooltip("Event sent if the Vector3's are not equal")]
		public FsmEvent notEqual;

		// Token: 0x04003CFB RID: 15611
		public bool everyFrame;
	}
}
