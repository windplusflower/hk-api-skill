using System;
using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200093A RID: 2362
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Each time this action is called it gets the next item from a PlayMaker HashTable Proxy component. \nThis lets you quickly loop through all the children of an object to perform actions on them.\nNOTE: To get to specific item use HashTableGet instead.")]
	public class HashTableGetNext : HashTableActions
	{
		// Token: 0x06003413 RID: 13331 RVA: 0x00137D48 File Offset: 0x00135F48
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
			this.result = null;
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x00137D94 File Offset: 0x00135F94
		public override void OnEnter()
		{
			if (this.reset.Value)
			{
				this.reset.Value = false;
				this.nextItemIndex = 0;
			}
			if (this.nextItemIndex == 0)
			{
				if (!base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
				{
					base.Fsm.Event(this.failureEvent);
					base.Finish();
				}
				this._keys = new ArrayList(this.proxy.hashTable.Keys);
				if (this.startIndex.Value > 0)
				{
					this.nextItemIndex = this.startIndex.Value;
				}
			}
			this.DoGetNextItem();
			base.Finish();
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00137E4C File Offset: 0x0013604C
		private void DoGetNextItem()
		{
			if (this.nextItemIndex >= this._keys.Count)
			{
				this.nextItemIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			this.GetItemAtIndex();
			if (this.nextItemIndex >= this._keys.Count)
			{
				this.nextItemIndex = 0;
				base.Fsm.Event(this.finishedEvent);
				return;
			}
			if (this.endIndex.Value > 0 && this.nextItemIndex >= this.endIndex.Value)
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

		// Token: 0x06003416 RID: 13334 RVA: 0x00137F18 File Offset: 0x00136118
		public void GetItemAtIndex()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			object value = null;
			try
			{
				value = this.proxy.hashTable[this._keys[this.nextItemIndex]];
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
				base.Fsm.Event(this.failureEvent);
				return;
			}
			this.key.Value = (string)this._keys[this.nextItemIndex];
			PlayMakerUtils.ApplyValueToFsmVar(base.Fsm, this.result, value);
		}

		// Token: 0x040035A6 RID: 13734
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x040035A7 RID: 13735
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x040035A8 RID: 13736
		[Tooltip("Set to true to force iterating from the first item. This variable will be set to false as it carries on iterating, force it back to true if you want to renter this action back to the first item.")]
		[UIHint(UIHint.Variable)]
		public FsmBool reset;

		// Token: 0x040035A9 RID: 13737
		[Tooltip("From where to start iteration, leave to 0 to start from the beginning")]
		public FsmInt startIndex;

		// Token: 0x040035AA RID: 13738
		[Tooltip("When to end iteration, leave to 0 to iterate until the end")]
		public FsmInt endIndex;

		// Token: 0x040035AB RID: 13739
		[Tooltip("Event to send to get the next item.")]
		public FsmEvent loopEvent;

		// Token: 0x040035AC RID: 13740
		[Tooltip("Event to send when there are no more items.")]
		public FsmEvent finishedEvent;

		// Token: 0x040035AD RID: 13741
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger if the action fails ( likely and index is out of range exception)")]
		public FsmEvent failureEvent;

		// Token: 0x040035AE RID: 13742
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmString key;

		// Token: 0x040035AF RID: 13743
		[UIHint(UIHint.Variable)]
		public FsmVar result;

		// Token: 0x040035B0 RID: 13744
		private ArrayList _keys;

		// Token: 0x040035B1 RID: 13745
		private int nextItemIndex;
	}
}
