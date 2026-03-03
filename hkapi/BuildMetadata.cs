using System;
using System.IO;
using UnityEngine;

// Token: 0x020004D0 RID: 1232
[Serializable]
public class BuildMetadata
{
	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00083176 File Offset: 0x00081376
	public string BranchName
	{
		get
		{
			return this.branchName;
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0008317E File Offset: 0x0008137E
	public string Revision
	{
		get
		{
			return this.revision;
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00083186 File Offset: 0x00081386
	public DateTime CommitTime
	{
		get
		{
			return DateTime.FromBinary(this.commitTime);
		}
	}

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06001B52 RID: 6994 RVA: 0x00083193 File Offset: 0x00081393
	public string MachineName
	{
		get
		{
			return this.machineName;
		}
	}

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06001B53 RID: 6995 RVA: 0x0008319B File Offset: 0x0008139B
	public DateTime BuildTime
	{
		get
		{
			return DateTime.FromBinary(this.buildTime);
		}
	}

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000831A8 File Offset: 0x000813A8
	public static BuildMetadata Embedded
	{
		get
		{
			if (!BuildMetadata.didLoad)
			{
				BuildMetadata.didLoad = true;
				try
				{
					BuildMetadata objectToOverwrite = new BuildMetadata();
					JsonUtility.FromJsonOverwrite(File.ReadAllText(Path.Combine(Application.streamingAssetsPath, "BuildMetadata.json")), objectToOverwrite);
					BuildMetadata.embedded = objectToOverwrite;
				}
				catch (FileNotFoundException)
				{
				}
				catch (Exception exception)
				{
					Debug.LogException(exception);
				}
			}
			return BuildMetadata.embedded;
		}
	}

	// Token: 0x06001B55 RID: 6997 RVA: 0x00083218 File Offset: 0x00081418
	public static BuildMetadata Create(string branchName, string revision, DateTime commitTime, string machineName, DateTime buildTime)
	{
		return new BuildMetadata
		{
			branchName = branchName,
			revision = revision,
			commitTime = commitTime.ToBinary(),
			machineName = machineName,
			buildTime = buildTime.ToBinary()
		};
	}

	// Token: 0x040020C7 RID: 8391
	[SerializeField]
	private string branchName;

	// Token: 0x040020C8 RID: 8392
	[SerializeField]
	private string revision;

	// Token: 0x040020C9 RID: 8393
	[SerializeField]
	private long commitTime;

	// Token: 0x040020CA RID: 8394
	[SerializeField]
	private string machineName;

	// Token: 0x040020CB RID: 8395
	[SerializeField]
	private long buildTime;

	// Token: 0x040020CC RID: 8396
	private static bool didLoad;

	// Token: 0x040020CD RID: 8397
	private static BuildMetadata embedded;

	// Token: 0x040020CE RID: 8398
	public const string EmbeddedFileName = "BuildMetadata.json";
}
