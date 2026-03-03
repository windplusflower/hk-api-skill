using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TMPro
{
	// Token: 0x02000607 RID: 1543
	internal class TMP_ObjectPool<T> where T : new()
	{
		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600245A RID: 9306 RVA: 0x000BBBCA File Offset: 0x000B9DCA
		// (set) Token: 0x0600245B RID: 9307 RVA: 0x000BBBD2 File Offset: 0x000B9DD2
		public int countAll { get; private set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600245C RID: 9308 RVA: 0x000BBBDB File Offset: 0x000B9DDB
		public int countActive
		{
			get
			{
				return this.countAll - this.countInactive;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000BBBEA File Offset: 0x000B9DEA
		public int countInactive
		{
			get
			{
				return this.m_Stack.Count;
			}
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x000BBBF7 File Offset: 0x000B9DF7
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
			this.m_ActionOnGet = actionOnGet;
			this.m_ActionOnRelease = actionOnRelease;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x000BBC18 File Offset: 0x000B9E18
		public T Get()
		{
			T t;
			if (this.m_Stack.Count == 0)
			{
				t = Activator.CreateInstance<T>();
				int countAll = this.countAll;
				this.countAll = countAll + 1;
			}
			else
			{
				t = this.m_Stack.Pop();
			}
			if (this.m_ActionOnGet != null)
			{
				this.m_ActionOnGet(t);
			}
			return t;
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x000BBC6C File Offset: 0x000B9E6C
		public void Release(T element)
		{
			if (this.m_Stack.Count > 0 && this.m_Stack.Peek() == element)
			{
				Debug.LogError("Internal error. Trying to destroy object that is already released to pool.");
			}
			if (this.m_ActionOnRelease != null)
			{
				this.m_ActionOnRelease(element);
			}
			this.m_Stack.Push(element);
		}

		// Token: 0x04002879 RID: 10361
		private readonly Stack<T> m_Stack = new Stack<T>();

		// Token: 0x0400287A RID: 10362
		private readonly UnityAction<T> m_ActionOnGet;

		// Token: 0x0400287B RID: 10363
		private readonly UnityAction<T> m_ActionOnRelease;
	}
}
