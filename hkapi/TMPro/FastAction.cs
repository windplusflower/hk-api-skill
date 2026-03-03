using System;
using System.Collections.Generic;

namespace TMPro
{
	// Token: 0x020005CC RID: 1484
	public class FastAction
	{
		// Token: 0x060022A4 RID: 8868 RVA: 0x000B3970 File Offset: 0x000B1B70
		public void Add(Action rhs)
		{
			if (this.lookup.ContainsKey(rhs))
			{
				return;
			}
			this.lookup[rhs] = this.delegates.AddLast(rhs);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x000B399C File Offset: 0x000B1B9C
		public void Remove(Action rhs)
		{
			LinkedListNode<Action> node;
			if (this.lookup.TryGetValue(rhs, out node))
			{
				this.lookup.Remove(rhs);
				this.delegates.Remove(node);
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x000B39D4 File Offset: 0x000B1BD4
		public void Call()
		{
			for (LinkedListNode<Action> linkedListNode = this.delegates.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				linkedListNode.Value();
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x000B3A04 File Offset: 0x000B1C04
		public FastAction()
		{
			this.delegates = new LinkedList<Action>();
			this.lookup = new Dictionary<Action, LinkedListNode<Action>>();
			base..ctor();
		}

		// Token: 0x0400275A RID: 10074
		private LinkedList<Action> delegates;

		// Token: 0x0400275B RID: 10075
		private Dictionary<Action, LinkedListNode<Action>> lookup;
	}
}
