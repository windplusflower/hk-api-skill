using System;

namespace HutongGames.PlayMaker.Actions
{
	// Token: 0x0200092E RID: 2350
	[ActionCategory("ArrayMaker/HashTable")]
	[Tooltip("Add key/value pairs to a PlayMaker HashTable Proxy component (PlayMakerHashTableProxy).")]
	public class HashTableAddMany : HashTableActions
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x00137331 File Offset: 0x00135531
		public override void Reset()
		{
			this.gameObject = null;
			this.reference = null;
			this.keys = null;
			this.variables = null;
			this.successEvent = null;
			this.keyExistsAlreadyEvent = null;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00137360 File Offset: 0x00135560
		public override void OnEnter()
		{
			if (base.SetUpHashTableProxyPointer(base.Fsm.GetOwnerDefaultTarget(this.gameObject), this.reference.Value))
			{
				if (this.keyExistsAlreadyEvent != null)
				{
					foreach (FsmString fsmString in this.keys)
					{
						if (this.proxy.hashTable.ContainsKey(fsmString.Value))
						{
							base.Fsm.Event(this.keyExistsAlreadyEvent);
							base.Finish();
						}
					}
				}
				this.AddToHashTable();
				base.Fsm.Event(this.successEvent);
			}
			base.Finish();
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00137400 File Offset: 0x00135600
		public void AddToHashTable()
		{
			if (!base.isProxyValid())
			{
				return;
			}
			for (int i = 0; i < this.keys.Length; i++)
			{
				this.proxy.hashTable.Add(this.keys[i].Value, PlayMakerUtils.GetValueFromFsmVar(base.Fsm, this.variables[i]));
			}
		}

		// Token: 0x04003569 RID: 13673
		[ActionSection("Set up")]
		[RequiredField]
		[Tooltip("The gameObject with the PlayMaker HashTable Proxy component")]
		[CheckForComponent(typeof(PlayMakerHashTableProxy))]
		public FsmOwnerDefault gameObject;

		// Token: 0x0400356A RID: 13674
		[Tooltip("Author defined Reference of the PlayMaker HashTable Proxy component ( necessary if several component coexists on the same GameObject")]
		public FsmString reference;

		// Token: 0x0400356B RID: 13675
		[ActionSection("Data")]
		[CompoundArray("Count", "Key", "Value")]
		[RequiredField]
		[UIHint(UIHint.FsmString)]
		[Tooltip("The Key")]
		public FsmString[] keys;

		// Token: 0x0400356C RID: 13676
		[RequiredField]
		[Tooltip("The value for that key")]
		public FsmVar[] variables;

		// Token: 0x0400356D RID: 13677
		[ActionSection("Result")]
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when elements are added")]
		public FsmEvent successEvent;

		// Token: 0x0400356E RID: 13678
		[UIHint(UIHint.FsmEvent)]
		[Tooltip("The event to trigger when elements exists already")]
		public FsmEvent keyExistsAlreadyEvent;
	}
}
