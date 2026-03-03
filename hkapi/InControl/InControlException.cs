using System;

namespace InControl
{
	// Token: 0x020006E1 RID: 1761
	[Serializable]
	public class InControlException : Exception
	{
		// Token: 0x06002A81 RID: 10881 RVA: 0x000E9173 File Offset: 0x000E7373
		public InControlException()
		{
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x000E917B File Offset: 0x000E737B
		public InControlException(string message) : base(message)
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x000E9184 File Offset: 0x000E7384
		public InControlException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
