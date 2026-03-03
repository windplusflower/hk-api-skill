using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000916 RID: 2326
	[ActionCategory("ArrayMaker/ArrayList")]
	[Tooltip("Each time this action is called it gets the previous item from a PlayMaker ArrayList Proxy component. \nThis lets you quickly loop backward through all the children of an object to perform actions on them.\nNOTE: To get to specific item use ArrayListGet instead.")]
	public class ArrayListGetPrevious : ArrayListActions
	{
		// Token: 0x06003382 RID: 13186 RVA: 0x00135CD0 File Offset: 0x00133ED0
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.reset = null;
			this.startIndex = null;
			this.endIndex = null;
			this.loopEvent = null;
			this.finishedEvent = null;
			this.failureEvent = null;
			this.currentIndex = null;
			this.result = null;
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00135D24 File Offset: 0x00133F24
		public override void OnEnter()
		{
			if (this.reset.Value)
			{
				this.reset.Value = false;
				this.nextItemIndex = 0;
			}
			if (this.nextItemIndex == 0)
			{
				if (!base.SetUpArrayListProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
				{
					base.Fsm.Event(this.failureEvent);
					base.Finish();
				}
				this.countBase = this.proxy.arrayList.Count - 1;
				if (this.startIndex.Value > 0)
				{
					this.nextItemIndex = this.startIndex.Value;
				}
			}
			this.DoGetPreviousItem();
			base.Finish();
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00135DD8 File Offset: 0x00133FD8
		private void DoGetPreviousItem()
		{
			if (this.nextItemIndex > this.countBase)
			{
				this.nextItemIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.GetItemAtIndex();
			if (this.nextItemIndex >= this.countBase)
			{
				this.nextItemIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			if (this.endIndex.Value > 0 && this.nextItemIndex > this.countBase - this.endIndex.Value)
			{
				this.nextItemIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.nextItemIndex++;
			if (this.loopEvent != null)
			{
				base.Fsm.Event(this.loopEvent);
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00135EA4 File Offset: 0x001340A4
		public void GetItemAtIndex()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			this.currentIndex.Value = this.countBase - this.nextItemIndex;
			object value = null;
			try
			{
				value = this.proxy.arrayList[this.currentIndex.Value];
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				base.Fsm.Event(this.failureEvent);
				return;
			}
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.result, value);
		}

		// Token: 0x040034F4 RID: 13556
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker ArrayList Proxy component")]
		[CheckForComponent(typeof(PlayMakerArrayListProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040034F5 RID: 13557
		[Tooltip("Author defined Reference of the PlayMaker ArrayList Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040034F6 RID: 13558
		[Tooltip("Set to true to force iterating from the last item. This variable will be set to false as it carries on iterating, force it back to true if you want to renter this action back to the last item.")]
		[UIHint(UIHint.Variable)]
		public FsmBool reset;

		// Token: 0x040034F7 RID: 13559
		[Tooltip("From where to start iteration, leave to 0 to start from the end. index is relative to the last item, so if the start index is 2, this will start 2 items before the last item.")]
		public FsmInt startIndex;

		// Token: 0x040034F8 RID: 13560
		[Tooltip("When to end iteration, leave to 0 to iterate until the beginning, index is relative to the last item.")]
		public FsmInt endIndex;

		// Token: 0x040034F9 RID: 13561
		[Tooltip("Event to send to get the previous item.")]
		public FsmEvent loopEvent;

		// Token: 0x040034FA RID: 13562
		[Tooltip("Event to send when there are no more items.")]
		public FsmEvent finishedEvent;

		// Token: 0x040034FB RID: 13563
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the action fails ( likely and index is out of range exception)")]
		public FsmEvent failureEvent;

		// Token: 0x040034FC RID: 13564
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmInt currentIndex;

		// Token: 0x040034FD RID: 13565
		[UIHint(UIHint.Variable)]
		public FsmVar result;

		// Token: 0x040034FE RID: 13566
		private int nextItemIndex;

		// Token: 0x040034FF RID: 13567
		private int countBase;
	}
}
