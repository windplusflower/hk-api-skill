using System;
using System.Collections.Generic;
using Modding.Converters;
using Newtonsoft.Json;

namespace Modding
{
	/// <summary>
	/// Wrapper over converters used for Unity types with JSON.NET
	/// </summary>
	// Token: 0x02000D67 RID: 3431
	public static class JsonConverterTypes
	{
		/// <summary>
		/// Converters used for serializing Unity vectors.
		/// </summary>
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x0018081F File Offset: 0x0017EA1F
		public static List<JsonConverter> ConverterTypes { get; } = new List<JsonConverter>
		{
			new Vector2Converter(),
			new Vector3Converter()
		};
	}
}
