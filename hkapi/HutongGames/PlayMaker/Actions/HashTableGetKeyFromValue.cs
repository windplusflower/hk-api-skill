using System;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x02000938 RID: 2360
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Return the key for a value ofna PlayMaker hashtable Proxy component. It will return the first entry found.")]
	public class HashTableGetKeyFromValue : HashTableActions
	{
		// Token: 0x0600340B RID: 13323 RVA: 0x00137B7F File Offset: 0x00135D7F
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x00137B8F File Offset: 0x00135D8F
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				this.SortHashTableByValues();
			}
			base.Finish();
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x00137BC4 File Offset: 0x00135DC4
		public void SortHashTableByValues()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			object valueFromFsmVar = PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.theValue);
			foreach (object obj in this.proxy.hashTable)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				if (dictionaryEntry.Value.Equals(valueFromFsmVar))
				{
					this.result.Value = (string)dictionaryEntry.Key;
					base.Fsm.Event(this.KeyFoundEvent);
					return;
				}
			}
			base.Fsm.Event(this.KeyNotFoundEvent);
		}

		// Token: 0x0400359C RID: 13724
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400359D RID: 13725
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400359E RID: 13726
		[ActionSection("Value")]
		[RequiredField]
		[Tooltip("The value to search")]
		public FsmVar theValue;

		// Token: 0x0400359F RID: 13727
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The key of that value")]
		public FsmString result;

		// Token: 0x040035A0 RID: 13728
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when value is found")]
		public FsmEvent KeyFoundEvent;

		// Token: 0x040035A1 RID: 13729
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when value is not found")]
		public FsmEvent KeyNotFoundEvent;
	}
}
