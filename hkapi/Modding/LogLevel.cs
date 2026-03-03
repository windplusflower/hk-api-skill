using System;
using JetBrains.Annotations;

namespace Modding
{
	/// <summary>
	///     What level should logs be done at?
	/// </summary>
	// Token: 0x02000D6C RID: 3436
	[PublicAPI]
	public enum LogLevel
	{
		/// <summary>
		///     Finest Level of Logging - Developers Only
		/// </summary>
		// Token: 0x04004B88 RID: 19336
		Fine,
		/// <summary>
		///     Debug Level of Logging - Mostly Developers Only
		/// </summary>
		// Token: 0x04004B89 RID: 19337
		Debug,
		/// <summary>
		///     Normal Logging Level
		/// </summary>
		// Token: 0x04004B8A RID: 19338
		Info,
		/// <summary>
		///     Only Show Warnings and Above
		/// </summary>
		// Token: 0x04004B8B RID: 19339
		Warn,
		/// <summary>
		///     Only Show Full Errors
		/// </summary>
		// Token: 0x04004B8C RID: 19340
		Error,
		/// <summary>
		///     No Logging at all
		/// </summary>
		// Token: 0x04004B8D RID: 19341
		[UsedImplicitly]
		Off
	}
}
