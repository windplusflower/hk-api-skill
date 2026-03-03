using System;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000B20 RID: 2848
	[NoActionTargets]
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Transfer a value from one array to another, basically a copy/cut paste action on steroids.")]
	public class ArrayTransferValue : FsmStateAction
	{
		// Token: 0x06003D0C RID: 15628 RVA: 0x0015F833 File Offset: 0x0015DA33
		public override void Reset()
		{
			this.arraySource = null;
			this.arrayTarget = null;
			this.indexToTransfer = null;
			this.copyType = ArrayTransferValue.ArrayTransferType.Copy;
			this.pasteType = ArrayTransferValue.ArrayPasteType.AsLastItem;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x0015F86C File Offset: 0x0015DA6C
		public override void OnEnter()
		{
			this.DoTransferValue();
			base.Finish();
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x0015F87C File Offset: 0x0015DA7C
		private void DoTransferValue()
		{
			if (this.arraySource.IsNone || this.arrayTarget.IsNone)
			{
				return;
			}
			int value = this.indexToTransfer.Value;
			if (value < 0 || value >= this.arraySource.Length)
			{
				base.Fsm.Event(this.indexOutOfRange);
				return;
			}
			object obj = this.arraySource.Values[value];
			if ((ArrayTransferValue.ArrayTransferType)this.copyType.Value == ArrayTransferValue.ArrayTransferType.Cut)
			{
				List<object> list = new List<object>(this.arraySource.Values);
				list.RemoveAt(value);
				this.arraySource.Values = list.ToArray();
			}
			else if ((ArrayTransferValue.ArrayTransferType)this.copyType.Value == ArrayTransferValue.ArrayTransferType.nullify)
			{
				this.arraySource.Values.SetValue(null, value);
			}
			if ((ArrayTransferValue.ArrayPasteType)this.pasteType.Value == ArrayTransferValue.ArrayPasteType.AsFirstItem)
			{
				List<object> list2 = new List<object>(this.arrayTarget.Values);
				list2.Insert(0, obj);
				this.arrayTarget.Values = list2.ToArray();
				return;
			}
			if ((ArrayTransferValue.ArrayPasteType)this.pasteType.Value == ArrayTransferValue.ArrayPasteType.AsLastItem)
			{
				this.arrayTarget.Resize(this.arrayTarget.Length + 1);
				this.arrayTarget.Set(this.arrayTarget.Length - 1, obj);
				return;
			}
			if ((ArrayTransferValue.ArrayPasteType)this.pasteType.Value == ArrayTransferValue.ArrayPasteType.InsertAtSameIndex)
			{
				if (value >= this.arrayTarget.Length)
				{
					base.Fsm.Event(this.indexOutOfRange);
				}
				List<object> list3 = new List<object>(this.arrayTarget.Values);
				list3.Insert(value, obj);
				this.arrayTarget.Values = list3.ToArray();
				return;
			}
			if ((ArrayTransferValue.ArrayPasteType)this.pasteType.Value == ArrayTransferValue.ArrayPasteType.ReplaceAtSameIndex)
			{
				if (value >= this.arrayTarget.Length)
				{
					base.Fsm.Event(this.indexOutOfRange);
					return;
				}
				this.arrayTarget.Set(value, obj);
			}
		}

		// Token: 0x04004108 RID: 16648
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable source.")]
		public FsmArray arraySource;

		// Token: 0x04004109 RID: 16649
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable target.")]
		public FsmArray arrayTarget;

		// Token: 0x0400410A RID: 16650
		[MatchFieldType("array")]
		[Tooltip("The index to transfer.")]
		public FsmInt indexToTransfer;

		// Token: 0x0400410B RID: 16651
		[ActionSection("Transfer Options")]
		[ObjectType(typeof(ArrayTransferValue.ArrayTransferType))]
		public FsmEnum copyType;

		// Token: 0x0400410C RID: 16652
		[ObjectType(typeof(ArrayTransferValue.ArrayPasteType))]
		public FsmEnum pasteType;

		// Token: 0x0400410D RID: 16653
		[ActionSection("Result")]
		[Tooltip("Event sent if this array source does not contains that element (described below)")]
		public FsmEvent indexOutOfRange;

		// Token: 0x02000B21 RID: 2849
		public enum ArrayTransferType
		{
			// Token: 0x0400410F RID: 16655
			Copy,
			// Token: 0x04004110 RID: 16656
			Cut,
			// Token: 0x04004111 RID: 16657
			nullify
		}

		// Token: 0x02000B22 RID: 2850
		public enum ArrayPasteType
		{
			// Token: 0x04004113 RID: 16659
			AsFirstItem,
			// Token: 0x04004114 RID: 16660
			AsLastItem,
			// Token: 0x04004115 RID: 16661
			InsertAtSameIndex,
			// Token: 0x04004116 RID: 16662
			ReplaceAtSameIndex
		}
	}
}
