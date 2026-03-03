using System;
using UnityEngine;

// Token: 0x02000555 RID: 1365
public class tk2dSystem : ScriptableObject
{
	// Token: 0x06001DED RID: 7661 RVA: 0x000953A0 File Offset: 0x000935A0
	private tk2dSystem()
	{
		this.assetPlatforms = new tk2dAssetPlatform[]
		{
			new tk2dAssetPlatform("1x", 1f),
			new tk2dAssetPlatform("2x", 2f),
			new tk2dAssetPlatform("4x", 4f)
		};
		this.allResourceEntries = new tk2dResourceTocEntry[0];
		base..ctor();
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00095404 File Offset: 0x00093604
	public static tk2dSystem inst
	{
		get
		{
			if (tk2dSystem._inst == null)
			{
				tk2dSystem._inst = (Resources.Load("tk2d/tk2dSystem", typeof(tk2dSystem)) as tk2dSystem);
				if (tk2dSystem._inst == null)
				{
					tk2dSystem._inst = ScriptableObject.CreateInstance<tk2dSystem>();
				}
				UnityEngine.Object.DontDestroyOnLoad(tk2dSystem._inst);
			}
			return tk2dSystem._inst;
		}
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00095462 File Offset: 0x00093662
	public static tk2dSystem inst_NoCreate
	{
		get
		{
			if (tk2dSystem._inst == null)
			{
				tk2dSystem._inst = (Resources.Load("tk2d/tk2dSystem", typeof(tk2dSystem)) as tk2dSystem);
			}
			return tk2dSystem._inst;
		}
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00095494 File Offset: 0x00093694
	// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x0009549B File Offset: 0x0009369B
	public static string CurrentPlatform
	{
		get
		{
			return tk2dSystem.currentPlatform;
		}
		set
		{
			if (value != tk2dSystem.currentPlatform)
			{
				tk2dSystem.currentPlatform = value;
			}
		}
	}

	// Token: 0x170003C9 RID: 969
	// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0000D742 File Offset: 0x0000B942
	public static bool OverrideBuildMaterial
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x000954B0 File Offset: 0x000936B0
	public static tk2dAssetPlatform GetAssetPlatform(string platform)
	{
		tk2dSystem inst_NoCreate = tk2dSystem.inst_NoCreate;
		if (inst_NoCreate == null)
		{
			return null;
		}
		for (int i = 0; i < inst_NoCreate.assetPlatforms.Length; i++)
		{
			if (inst_NoCreate.assetPlatforms[i].name == platform)
			{
				return inst_NoCreate.assetPlatforms[i];
			}
		}
		return null;
	}

	// Token: 0x06001DF4 RID: 7668 RVA: 0x00095500 File Offset: 0x00093700
	private T LoadResourceByGUIDImpl<T>(string guid) where T : UnityEngine.Object
	{
		tk2dResource tk2dResource = Resources.Load("tk2d/tk2d_" + guid, typeof(tk2dResource)) as tk2dResource;
		if (tk2dResource != null)
		{
			return tk2dResource.objectReference as T;
		}
		return default(T);
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x00095550 File Offset: 0x00093750
	private T LoadResourceByNameImpl<T>(string name) where T : UnityEngine.Object
	{
		for (int i = 0; i < this.allResourceEntries.Length; i++)
		{
			if (this.allResourceEntries[i] != null && this.allResourceEntries[i].assetName == name)
			{
				return this.LoadResourceByGUIDImpl<T>(this.allResourceEntries[i].assetGUID);
			}
		}
		return default(T);
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x000955AC File Offset: 0x000937AC
	public static T LoadResourceByGUID<T>(string guid) where T : UnityEngine.Object
	{
		return tk2dSystem.inst.LoadResourceByGUIDImpl<T>(guid);
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x000955B9 File Offset: 0x000937B9
	public static T LoadResourceByName<T>(string guid) where T : UnityEngine.Object
	{
		return tk2dSystem.inst.LoadResourceByNameImpl<T>(guid);
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x000955C6 File Offset: 0x000937C6
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dSystem()
	{
		tk2dSystem._inst = null;
		tk2dSystem.currentPlatform = "";
	}

	// Token: 0x0400239F RID: 9119
	public const string guidPrefix = "tk2d/tk2d_";

	// Token: 0x040023A0 RID: 9120
	public const string assetName = "tk2d/tk2dSystem";

	// Token: 0x040023A1 RID: 9121
	public const string assetFileName = "tk2dSystem.asset";

	// Token: 0x040023A2 RID: 9122
	[NonSerialized]
	public tk2dAssetPlatform[] assetPlatforms;

	// Token: 0x040023A3 RID: 9123
	private static tk2dSystem _inst;

	// Token: 0x040023A4 RID: 9124
	private static string currentPlatform;

	// Token: 0x040023A5 RID: 9125
	[SerializeField]
	private tk2dResourceTocEntry[] allResourceEntries;
}
