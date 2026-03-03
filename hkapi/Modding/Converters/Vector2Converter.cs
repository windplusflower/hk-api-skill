using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Modding.Converters
{
	/// <inheritdoc />
	// Token: 0x02000DF6 RID: 3574
	public class Vector2Converter : JsonConverter<Vector2>
	{
		/// <inheritdoc />
		// Token: 0x060049C1 RID: 18881 RVA: 0x0018D54C File Offset: 0x0018B74C
		public override Vector2 ReadJson(Dictionary<string, object> token, object existingValue)
		{
			float x = Convert.ToSingle(token["x"]);
			float y = Convert.ToSingle(token["y"]);
			return new Vector2(x, y);
		}

		/// <inheritdoc />
		// Token: 0x060049C2 RID: 18882 RVA: 0x0018D580 File Offset: 0x0018B780
		public override void WriteJson(JsonWriter writer, Vector2 value)
		{
			writer.WritePropertyName("x");
			writer.WriteValue(value.x);
			writer.WritePropertyName("y");
			writer.WriteValue(value.y);
		}
	}
}
