using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000C16 RID: 3094
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Gets the Right n characters from a String.")]
	public class GetStringRight : FsmStateAction
	{
		// Token: 0x060040EA RID: 16618 RVA: 0x0016B3B6 File Offset: 0x001695B6
		public override void Reset()
		{
			this.stringVariable = null;
			this.charCount = 0;
			this.storeResult = null;
			this.everyFrame = false;
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x0016B3D9 File Offset: 0x001695D9
		public override void OnEnter()
		{
			this.DoGetStringRight();
			if (!this.everyFrame)
			{
				base.Finish();
			}
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x0016B3EF File Offset: 0x001695EF
		public override void OnUpdate()
		{
			this.DoGetStringRight();
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x0016B3F8 File Offset: 0x001695F8
		private void DoGetStringRight()
		{
			if (this.stringVariable.IsNone)
			{
				return;
			}
			if (this.storeResult.IsNone)
			{
				return;
			}
			string value = this.stringVariable.Value;
			int num = Mathf.Clamp(this.charCount.Value, 0, value.Length);
			this.storeResult.Value = value.Substring(value.Length - num, num);
		}

		// Token: 0x0400452E RID: 17710
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString stringVariable;

		// Token: 0x0400452F RID: 17711
		[Tooltip("Number of characters to get.")]
		public FsmInt charCount;

		// Token: 0x04004530 RID: 17712
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

		// Token: 0x04004531 RID: 17713
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;
	}
}
