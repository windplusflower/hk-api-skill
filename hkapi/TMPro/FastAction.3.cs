using System;
using System.Collections.Generic;

namespace TMPro
{
	// Token: 0x020005CE RID: 1486
	public class FastAction<A, B>
	{
		// Token: 0x060022AC RID: 8876 RVA: 0x000B3AD3 File Offset: 0x000B1CD3
		public void Add(Action<A, B> rhs)
		{
			if (this.lookup.ContainsKey(rhs))
			{
				return;
			}
			this.lookup[rhs] = this.delegates.AddLast(rhs);
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000B3AFC File Offset: 0x000B1CFC
		public void Remove(Action<A, B> rhs)
		{
			LinkedListNode<Action<A, B>> node;
			if (this.lookup.TryGetValue(rhs, out node))
			{
				this.lookup.Remove(rhs);
				this.delegates.Remove(node);
			}
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000B3B34 File Offset: 0x000B1D34
		public void Call(A a, B b)
		{
			for (LinkedListNode<Action<A, B>> linkedListNode = this.delegates.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				linkedListNode.Value(a, b);
			}
		}

		// Token: 0x0400275E RID: 10078
		private LinkedList<Action<A, B>> delegates = new LinkedList<Action<A, B>>();

		// Token: 0x0400275F RID: 10079
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup = new Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>>();
	}
}
