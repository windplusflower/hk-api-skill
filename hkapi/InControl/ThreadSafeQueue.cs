using System;
using System.Collections.Generic;

namespace InControl
{
	// Token: 0x02000733 RID: 1843
	internal class ThreadSafeQueue<T>
	{
		// Token: 0x06002E14 RID: 11796 RVA: 0x000F5080 File Offset: 0x000F3280
		public ThreadSafeQueue()
		{
			this.sync = new object();
			this.data = new Queue<T>();
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x000F509E File Offset: 0x000F329E
		public ThreadSafeQueue(int capacity)
		{
			this.sync = new object();
			this.data = new Queue<T>(capacity);
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x000F50C0 File Offset: 0x000F32C0
		public void Enqueue(T item)
		{
			object obj = this.sync;
			lock (obj)
			{
				this.data.Enqueue(item);
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000F5108 File Offset: 0x000F3308
		public bool Dequeue(out T item)
		{
			object obj = this.sync;
			lock (obj)
			{
				if (this.data.Count > 0)
				{
					item = this.data.Dequeue();
					return true;
				}
			}
			item = default(T);
			return false;
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x000F5170 File Offset: 0x000F3370
		public T Dequeue()
		{
			object obj = this.sync;
			lock (obj)
			{
				if (this.data.Count > 0)
				{
					return this.data.Dequeue();
				}
			}
			return default(T);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x000F51D4 File Offset: 0x000F33D4
		public int Dequeue(ref IList<T> list)
		{
			object obj = this.sync;
			int result;
			lock (obj)
			{
				int count = this.data.Count;
				for (int i = 0; i < count; i++)
				{
					list.Add(this.data.Dequeue());
				}
				result = count;
			}
			return result;
		}

		// Token: 0x040032DC RID: 13020
		private object sync;

		// Token: 0x040032DD RID: 13021
		private Queue<T> data;
	}
}
