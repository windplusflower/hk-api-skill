using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Modding
{
	// Token: 0x02000D86 RID: 3462
	internal class ModSavegameData
	{
		// Token: 0x060047EE RID: 18414 RVA: 0x001863F8 File Offset: 0x001845F8
		public ModSavegameData()
		{
			this.modData = new Dictionary<string, JToken>();
			base..ctor();
		}

		// Token: 0x04004C11 RID: 19473
		public Dictionary<string, string> loadedMods;

		// Token: 0x04004C12 RID: 19474
		public Dictionary<string, JToken> modData;
	}
}
