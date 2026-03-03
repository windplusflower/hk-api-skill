using System;

namespace Modding
{
	/// <summary>
	/// Delegates to load an unload a mod through the menu.
	/// </summary>
	// Token: 0x02000D63 RID: 3427
	public struct ModToggleDelegates
	{
		/// <summary>
		/// Sets the mod to an enabled or disabled state. This will not be updated until menu is hidden
		/// </summary>
		// Token: 0x04004B6E RID: 19310
		public Action<bool> SetModEnabled;

		/// <summary>
		/// Gets if the mod is enabled or disabled. This will not be updated until menu is hidden
		/// </summary>
		// Token: 0x04004B6F RID: 19311
		public Func<bool> GetModEnabled;

		/// <summary>
		/// Left in for backwards compatibility.
		/// </summary>
		// Token: 0x04004B70 RID: 19312
		[Obsolete("No longer needed to explicitly call this. Using 'SetModEnabled' is enough to toggle the state of the mod")]
		public Action ApplyChange;
	}
}
