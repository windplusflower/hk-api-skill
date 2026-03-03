using System;
using UnityEngine;

// Token: 0x020004D3 RID: 1235
public static class CommandLineArguments
{
	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0008333E File Offset: 0x0008153E
	// (set) Token: 0x06001B5A RID: 7002 RVA: 0x00083345 File Offset: 0x00081545
	public static bool ShowPerformanceHUD { get; private set; }

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0008334D File Offset: 0x0008154D
	// (set) Token: 0x06001B5C RID: 7004 RVA: 0x00083354 File Offset: 0x00081554
	public static string RemoteSaveDirectory { get; private set; }

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0008335C File Offset: 0x0008155C
	// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00083363 File Offset: 0x00081563
	public static bool EnableDeveloperCheats { get; private set; }

	// Token: 0x06001B5F RID: 7007 RVA: 0x0008336C File Offset: 0x0008156C
	static CommandLineArguments()
	{
		if (Application.isEditor)
		{
			return;
		}
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs == null)
		{
			return;
		}
		foreach (string text in commandLineArgs)
		{
			if (text.Equals("--show-performance-hud", StringComparison.OrdinalIgnoreCase))
			{
				CommandLineArguments.ShowPerformanceHUD = true;
			}
			else if (text.Equals("--enable-developer-cheats", StringComparison.OrdinalIgnoreCase))
			{
				CommandLineArguments.EnableDeveloperCheats = true;
			}
			else if (text.StartsWith("--remote-save-directory=", StringComparison.OrdinalIgnoreCase))
			{
				CommandLineArguments.RemoteSaveDirectory = text.Substring("--remote-save-directory=".Length);
			}
		}
	}

	// Token: 0x040020D3 RID: 8403
	private const StringComparison ArgumentComparison = StringComparison.OrdinalIgnoreCase;

	// Token: 0x040020D4 RID: 8404
	private const string ShowPerformanceHUDFlag = "--show-performance-hud";

	// Token: 0x040020D6 RID: 8406
	private const string RemoteSaveDirectoryPrefix = "--remote-save-directory=";

	// Token: 0x040020D8 RID: 8408
	private const string EnableDeveloperCheatsFlag = "--enable-developer-cheats";
}
