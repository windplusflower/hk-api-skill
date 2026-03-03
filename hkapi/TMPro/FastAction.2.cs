using System;
using System.Collections.Generic;

namespace TMPro
{
	// Token: 0x020005CD RID: 1485
	public class FastAction<A>
	{
		// Token: 0x060022A8 RID: 8872 RVA: 0x000B3A22 File Offset: 0x000B1C22
		public void Add(Action<A> rhs)
		{
			if (this.lookup.ContainsKey(rhs))
			{
				return;
			}
			this.lookup[rhs] = this.delegates.AddLast(rhs);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000B3A4C File Offset: 0x000B1C4C
		public void Remove(Action<A> rhs)
		{
			LinkedListNode<Action<A>> node;
			if (this.lookup.TryGetValue(rhs, out node))
			{
				this.lookup.Remove(rhs);
				this.delegates.Remove(node);
			}
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000B3A84 File Offset: 0x000B1C84
		public void Call(A a)
		{
			for (LinkedListNode<Action<A>> linkedListNode = this.delegates.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
			{
				linkedListNode.Value(a);
			}
		}

		// Token: 0x0400275C RID: 10076
		private LinkedList<Action<A>> delegates = new LinkedList<Action<A>>();

		// Token: 0x0400275D RID: 10077
		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup = new Dictionary<Action<A>, LinkedListNode<Action<A>>>();
	}
}
