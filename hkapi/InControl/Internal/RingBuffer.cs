using System;

namespace InControl.Internal
{
	// Token: 0x0200073C RID: 1852
	public class RingBuffer<T>
	{
		// Token: 0x06002EA5 RID: 11941 RVA: 0x000F8018 File Offset: 0x000F6218
		public RingBuffer(int size)
		{
			if (size <= 0)
			{
				throw new ArgumentException("RingBuffer size must be 1 or greater.");
			}
			this.size = size + 1;
			this.data = new T[this.size];
			this.head = 0;
			this.tail = 0;
			this.sync = new object();
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000F8070 File Offset: 0x000F6270
		public void Enqueue(T value)
		{
			object obj = this.sync;
			lock (obj)
			{
				if (this.size > 1)
				{
					this.head = (this.head + 1) % this.size;
					if (this.head == this.tail)
					{
						this.tail = (this.tail + 1) % this.size;
					}
				}
				this.data[this.head] = value;
			}
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000F8100 File Offset: 0x000F6300
		public T Dequeue()
		{
			object obj = this.sync;
			T result;
			lock (obj)
			{
				if (this.size > 1 && this.tail != this.head)
				{
					this.tail = (this.tail + 1) % this.size;
				}
				result = this.data[this.tail];
			}
			return result;
		}

		// Token: 0x0400330E RID: 13070
		private readonly int size;

		// Token: 0x0400330F RID: 13071
		private readonly T[] data;

		// Token: 0x04003310 RID: 13072
		private int head;

		// Token: 0x04003311 RID: 13073
		private int tail;

		// Token: 0x04003312 RID: 13074
		private readonly object sync;
	}
}
