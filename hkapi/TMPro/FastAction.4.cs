using System;
using System.Collections.Generic;

namespace TMPro
{
	// Token: 0x020005CF RID: 1487
	public class FastAction<A, B, C>
	{
		// Token: 0x060022B0 RID: 8880 RVA: 0x000B3B84 File Offset: 0x000B1D84
		public void Add(Action<A, B, C> rhs)
		{
			if (this.lookup.ContainsKey(rhs))
			{
				return;
			}
			this.lookup[rhs] = this.delegates.AddLast(rhs);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x000B3BB0 File Offset: 0x000B1DB0
		public void Remove(Action<A, B, C> rhs)
		{
			LinkedListNode<Action<A, B, C>> node;
			if (this.lookup.TryGetValue(rhs, out node))
			{
				this.lookup.Remove(rhs);
				this.delegates.Remove(node);
			}
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x000B3BE8 File Offset: 0x000B1DE8
		public void Call(A a, B b, C c)
		{
			for (LinkedListNode<Action<A, B, C>> linkedListNode = this.delegates.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				linkedListNode.Value(a, b, c);
			}
		}

		// Token: 0x04002760 RID: 10080
		private LinkedList<Action<A, B, C>> delegates = new LinkedList<Action<A, B, C>>();

		// Token: 0x04002761 RID: 10081
		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup = new Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>>();
	}
}
