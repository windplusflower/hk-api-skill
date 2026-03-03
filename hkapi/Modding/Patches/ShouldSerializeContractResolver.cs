using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Modding.Patches
{
	/// <inheritdoc />
	// Token: 0x02000DAB RID: 3499
	public class ShouldSerializeContractResolver : DefaultContractResolver
	{
		/// <inheritdoc />
		// Token: 0x0600488E RID: 18574 RVA: 0x00189294 File Offset: 0x00187494
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			JsonProperty jsonProperty = base.CreateProperty(member, memberSerialization);
			bool? flag;
			if (member == null)
			{
				flag = null;
			}
			else
			{
				Type declaringType = member.DeclaringType;
				flag = ((declaringType != null) ? new bool?(declaringType.Assembly.FullName.StartsWith("UnityEngine")) : null);
			}
			bool? flag2 = flag;
			if (flag2.GetValueOrDefault())
			{
				jsonProperty.Ignored = true;
			}
			return jsonProperty;
		}

		// Token: 0x06004890 RID: 18576 RVA: 0x00189300 File Offset: 0x00187500
		// Note: this type is marked as 'beforefieldinit'.
		static ShouldSerializeContractResolver()
		{
			ShouldSerializeContractResolver.Instance = new ShouldSerializeContractResolver();
		}

		/// <summary>
		/// Instance to cache reflection calls.
		/// </summary>
		// Token: 0x04004C99 RID: 19609
		public static readonly ShouldSerializeContractResolver Instance;
	}
}
