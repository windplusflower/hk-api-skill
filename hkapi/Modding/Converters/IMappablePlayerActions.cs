using System;

namespace Modding.Converters
{
	/// <summary>
	/// An interface to signify mappable player actions to be used in conjunction with <c>PlayerActionSetConverter</c>.
	/// </summary>
	// Token: 0x02000DF5 RID: 3573
	public interface IMappablePlayerActions
	{
		/// <summary>
		/// Checks if the passed in string should be read/written from the JSON stream
		/// </summary>
		/// <param name="name">The name of the player action</param>
		/// <returns></returns>
		// Token: 0x060049C0 RID: 18880
		bool IsMappable(string name);
	}
}
