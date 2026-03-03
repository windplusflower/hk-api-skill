using System;
using System.Text.RegularExpressions;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000735 RID: 1845
	[Serializable]
	public struct VersionInfo : IComparable<VersionInfo>
	{
		// Token: 0x06002E49 RID: 11849 RVA: 0x000F5C83 File Offset: 0x000F3E83
		public VersionInfo(int major, int minor, int patch, int build)
		{
			this.major = major;
			this.minor = minor;
			this.patch = patch;
			this.build = build;
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x000F5CA4 File Offset: 0x000F3EA4
		public static VersionInfo InControlVersion()
		{
			return new VersionInfo
			{
				major = 1,
				minor = 8,
				patch = 4,
				build = 9364
			};
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000F5CE0 File Offset: 0x000F3EE0
		public static VersionInfo UnityVersion()
		{
			Match match = Regex.Match(Application.unityVersion, "^(\\d+)\\.(\\d+)\\.(\\d+)[a-zA-Z](\\d+)");
			return new VersionInfo
			{
				major = Convert.ToInt32(match.Groups[1].Value),
				minor = Convert.ToInt32(match.Groups[2].Value),
				patch = Convert.ToInt32(match.Groups[3].Value),
				build = Convert.ToInt32(match.Groups[4].Value)
			};
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x000F5D7A File Offset: 0x000F3F7A
		public static VersionInfo Min
		{
			get
			{
				return new VersionInfo(int.MinValue, int.MinValue, int.MinValue, int.MinValue);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000F5D95 File Offset: 0x000F3F95
		public static VersionInfo Max
		{
			get
			{
				return new VersionInfo(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x000F5DB0 File Offset: 0x000F3FB0
		public VersionInfo Next
		{
			get
			{
				return new VersionInfo(this.major, this.minor, this.patch, this.build + 1);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000F5DD1 File Offset: 0x000F3FD1
		public int Build
		{
			get
			{
				return this.build;
			}
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x000F5DDC File Offset: 0x000F3FDC
		public int CompareTo(VersionInfo other)
		{
			if (this.major < other.major)
			{
				return -1;
			}
			if (this.major > other.major)
			{
				return 1;
			}
			if (this.minor < other.minor)
			{
				return -1;
			}
			if (this.minor > other.minor)
			{
				return 1;
			}
			if (this.patch < other.patch)
			{
				return -1;
			}
			if (this.patch > other.patch)
			{
				return 1;
			}
			if (this.build < other.build)
			{
				return -1;
			}
			if (this.build > other.build)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x000F5E6A File Offset: 0x000F406A
		public static bool operator ==(VersionInfo a, VersionInfo b)
		{
			return a.CompareTo(b) == 0;
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000F5E77 File Offset: 0x000F4077
		public static bool operator !=(VersionInfo a, VersionInfo b)
		{
			return a.CompareTo(b) != 0;
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x000F5E84 File Offset: 0x000F4084
		public static bool operator <=(VersionInfo a, VersionInfo b)
		{
			return a.CompareTo(b) <= 0;
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000F5E94 File Offset: 0x000F4094
		public static bool operator >=(VersionInfo a, VersionInfo b)
		{
			return a.CompareTo(b) >= 0;
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x000F5EA4 File Offset: 0x000F40A4
		public static bool operator <(VersionInfo a, VersionInfo b)
		{
			return a.CompareTo(b) < 0;
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000F5EB1 File Offset: 0x000F40B1
		public static bool operator >(VersionInfo a, VersionInfo b)
		{
			return a.CompareTo(b) > 0;
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000F5EBE File Offset: 0x000F40BE
		public override bool Equals(object other)
		{
			return other is VersionInfo && this == (VersionInfo)other;
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000F5EDB File Offset: 0x000F40DB
		public override int GetHashCode()
		{
			return this.major.GetHashCode() ^ this.minor.GetHashCode() ^ this.patch.GetHashCode() ^ this.build.GetHashCode();
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000F5F0C File Offset: 0x000F410C
		public override string ToString()
		{
			if (this.build == 0)
			{
				return string.Format("{0}.{1}.{2}", this.major, this.minor, this.patch);
			}
			return string.Format("{0}.{1}.{2} build {3}", new object[]
			{
				this.major,
				this.minor,
				this.patch,
				this.build
			});
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x000F5F98 File Offset: 0x000F4198
		public string ToShortString()
		{
			if (this.build == 0)
			{
				return string.Format("{0}.{1}.{2}", this.major, this.minor, this.patch);
			}
			return string.Format("{0}.{1}.{2}b{3}", new object[]
			{
				this.major,
				this.minor,
				this.patch,
				this.build
			});
		}

		// Token: 0x040032E0 RID: 13024
		[SerializeField]
		private int major;

		// Token: 0x040032E1 RID: 13025
		[SerializeField]
		private int minor;

		// Token: 0x040032E2 RID: 13026
		[SerializeField]
		private int patch;

		// Token: 0x040032E3 RID: 13027
		[SerializeField]
		private int build;
	}
}
