using System;

namespace Microsoft.Xbox
{
	// Token: 0x020008B8 RID: 2232
	public class GameSaveLoadedArgs : EventArgs
	{
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0012E778 File Offset: 0x0012C978
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0012E780 File Offset: 0x0012C980
		public byte[] Data { get; private set; }

		// Token: 0x060031A8 RID: 12712 RVA: 0x0012E789 File Offset: 0x0012C989
		public GameSaveLoadedArgs(byte[] data)
		{
			this.Data = data;
		}
	}
}
