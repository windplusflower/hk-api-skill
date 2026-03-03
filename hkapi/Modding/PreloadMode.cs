using System;
using JetBrains.Annotations;

namespace Modding
{
	/// <summary>
	///     Strategy preloading game objects
	/// </summary>
	// Token: 0x02000D73 RID: 3443
	[PublicAPI]
	public enum PreloadMode
	{
		/// <summary>
		///     Load the entire scene unmodified into memory
		/// </summary>
		// Token: 0x04004BDA RID: 19418
		FullScene,
		/// <summary>
		///     Preprocess the scenes into an assetbundle, containing filtered versions of the originals
		/// </summary>
		// Token: 0x04004BDB RID: 19419
		RepackScene,
		/// <summary>
		///     Preprocess the scenes into an assetbundle that contains individual game object assets
		/// </summary>
		// Token: 0x04004BDC RID: 19420
		RepackAssets
	}
}
