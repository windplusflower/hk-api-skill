using System;

namespace Modding
{
	// Token: 0x02000D65 RID: 3429
	internal static class IModExtensions
	{
		// Token: 0x060046B1 RID: 18097 RVA: 0x0018074C File Offset: 0x0017E94C
		public static string GetVersionSafe(this IMod mod, string returnOnError)
		{
			string result;
			try
			{
				result = mod.GetVersion();
			}
			catch (Exception ex)
			{
				Loggable apilogger = Logger.APILogger;
				string str = "Error determining version for ";
				string name = mod.GetName();
				string str2 = "\n";
				Exception ex2 = ex;
				apilogger.LogError(str + name + str2 + ((ex2 != null) ? ex2.ToString() : null));
				result = returnOnError;
			}
			return result;
		}
	}
}
