using System;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000626 RID: 1574
	public struct TMP_XmlTagStack<T>
	{
		// Token: 0x060025F8 RID: 9720 RVA: 0x000C7DA3 File Offset: 0x000C5FA3
		public TMP_XmlTagStack(T[] tagStack)
		{
			this.itemStack = tagStack;
			this.index = 0;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000C7DB3 File Offset: 0x000C5FB3
		public void Clear()
		{
			this.index = 0;
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000C7DBC File Offset: 0x000C5FBC
		public void SetDefault(T item)
		{
			if (this.itemStack != null && this.itemStack.Length != 0)
			{
				this.itemStack[0] = item;
				this.index = 1;
				return;
			}
			Debug.LogError("TextMeshPro itemStack was null or empty!");
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000C7DEE File Offset: 0x000C5FEE
		public void Add(T item)
		{
			if (this.index < this.itemStack.Length)
			{
				this.itemStack[this.index] = item;
				this.index++;
			}
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000C7E20 File Offset: 0x000C6020
		public T Remove()
		{
			this.index--;
			if (this.index <= 0)
			{
				this.index = 0;
				return this.itemStack[0];
			}
			return this.itemStack[this.index - 1];
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000C7E60 File Offset: 0x000C6060
		public T CurrentItem()
		{
			if (this.index > 0)
			{
				return this.itemStack[this.index - 1];
			}
			return this.itemStack[0];
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000C7E8B File Offset: 0x000C608B
		public T PreviousItem()
		{
			if (this.index > 1)
			{
				return this.itemStack[this.index - 2];
			}
			return this.itemStack[0];
		}

		// Token: 0x040029F6 RID: 10742
		public T[] itemStack;

		// Token: 0x040029F7 RID: 10743
		public int index;
	}
}
