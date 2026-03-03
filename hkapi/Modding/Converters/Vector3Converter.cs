using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Modding.Converters
{
	/// <inheritdoc />
	// Token: 0x02000DF7 RID: 3575
	public class Vector3Converter : JsonConverter<Vector3>
	{
		/// <inheritdoc />
		// Token: 0x060049C4 RID: 18884 RVA: 0x0018D5B8 File Offset: 0x0018B7B8
		public override Vector3 ReadJson(Dictionary<string, object> token, object existingValue)
		{
			float x = Convert.ToSingle(token["x"]);
			float y = Convert.ToSingle(token["y"]);
			float z = Convert.ToSingle(token["z"]);
			return new Vector3(x, y, z);
		}

		/// <inheritdoc />
		// Token: 0x060049C5 RID: 18885 RVA: 0x0018D600 File Offset: 0x0018B800
		public override void WriteJson(JsonWriter writer, Vector3 value)
		{
			writer.WritePropertyName("x");
			writer.WriteValue(value.x);
			writer.WritePropertyName("y");
			writer.WriteValue(value.y);
			writer.WritePropertyName("z");
			writer.WriteValue(value.z);
		}
	}
}
