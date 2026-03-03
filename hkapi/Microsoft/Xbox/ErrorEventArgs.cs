using System;

namespace Microsoft.Xbox
{
	// Token: 0x020008B7 RID: 2231
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x0012E740 File Offset: 0x0012C940
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x0012E748 File Offset: 0x0012C948
		public string ErrorCode { get; private set; }

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x0012E751 File Offset: 0x0012C951
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x0012E759 File Offset: 0x0012C959
		public string ErrorMessage { get; private set; }

		// Token: 0x060031A5 RID: 12709 RVA: 0x0012E762 File Offset: 0x0012C962
		public ErrorEventArgs(string errorCode, string errorMessage)
		{
			this.ErrorCode = errorCode;
			this.ErrorMessage = errorMessage;
		}
	}
}
