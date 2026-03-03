using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace Modding.Converters
{
	/// <inheritdoc />
	// Token: 0x02000DF2 RID: 3570
	public abstract class JsonConverter<TClass> : JsonConverter
	{
		/// <inheritdoc />
		// Token: 0x060049B2 RID: 18866 RVA: 0x0018D1CD File Offset: 0x0018B3CD
		public override bool CanConvert(Type objectType)
		{
			return typeof(TClass) == objectType;
		}

		/// <inheritdoc />
		// Token: 0x060049B3 RID: 18867 RVA: 0x0018D1E0 File Offset: 0x0018B3E0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (typeof(TClass) == objectType)
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				reader.Read();
				while (reader.TokenType == JsonToken.PropertyName)
				{
					string key = (string)reader.Value;
					reader.Read();
					dictionary.Add(key, reader.Value);
					reader.Read();
				}
				return this.ReadJson(dictionary, existingValue);
			}
			return serializer.Deserialize(reader);
		}

		/// <inheritdoc />
		// Token: 0x060049B4 RID: 18868 RVA: 0x0018D254 File Offset: 0x0018B454
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteStartObject();
			this.WriteJson(writer, (TClass)((object)value));
			writer.WriteEndObject();
		}

		/// <summary>
		/// Read from token 
		/// </summary>
		/// <param name="token">JSON object</param>
		/// <param name="existingValue">Existing value</param>
		/// <returns></returns>
		// Token: 0x060049B5 RID: 18869
		[PublicAPI]
		public abstract TClass ReadJson(Dictionary<string, object> token, object existingValue);

		/// <summary>
		/// Write value into token
		/// </summary>
		/// <param name="writer">JSON Writer</param>
		/// <param name="value">Value to be written</param>
		// Token: 0x060049B6 RID: 18870
		[PublicAPI]
		public abstract void WriteJson(JsonWriter writer, TClass value);
	}
}
