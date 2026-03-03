using System;
using System.Collections.Generic;
using System.Reflection;

namespace InControl
{
	// Token: 0x02000730 RID: 1840
	public static class Reflector
	{
		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000F4C2B File Offset: 0x000F2E2B
		public static IEnumerable<Type> AllAssemblyTypes
		{
			get
			{
				IEnumerable<Type> result;
				if ((result = Reflector.assemblyTypes) == null)
				{
					result = (Reflector.assemblyTypes = Reflector.GetAllAssemblyTypes());
				}
				return result;
			}
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000F4C44 File Offset: 0x000F2E44
		private static bool IgnoreAssemblyWithName(string assemblyName)
		{
			foreach (string value in Reflector.ignoreAssemblies)
			{
				if (assemblyName.StartsWith(value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000F4C78 File Offset: 0x000F2E78
		private static IEnumerable<Type> GetAllAssemblyTypes()
		{
			List<Type> list = new List<Type>();
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				if (!Reflector.IgnoreAssemblyWithName(assembly.GetName().Name))
				{
					Type[] array = null;
					try
					{
						array = assembly.GetTypes();
					}
					catch
					{
					}
					if (array != null)
					{
						list.AddRange(array);
					}
				}
			}
			return list;
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000F4CE8 File Offset: 0x000F2EE8
		// Note: this type is marked as 'beforefieldinit'.
		static Reflector()
		{
			Reflector.ignoreAssemblies = new string[]
			{
				"Unity",
				"UnityEngine",
				"UnityEditor",
				"mscorlib",
				"Microsoft",
				"System",
				"Mono",
				"JetBrains",
				"nunit",
				"ExCSS",
				"ICSharpCode",
				"AssetStoreTools"
			};
		}

		// Token: 0x040032D3 RID: 13011
		private static readonly string[] ignoreAssemblies;

		// Token: 0x040032D4 RID: 13012
		private static IEnumerable<Type> assemblyTypes;
	}
}
