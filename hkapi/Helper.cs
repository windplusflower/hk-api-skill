using System;
using System.IO;
using System.Linq;
using UnityEngine;

// Token: 0x020004E5 RID: 1253
public static class Helper
{
	// Token: 0x06001BBD RID: 7101 RVA: 0x000842B4 File Offset: 0x000824B4
	public static int GetCollidingLayerMaskForLayer(int layer)
	{
		int num = 0;
		for (int i = 0; i < 32; i++)
		{
			if (!Physics2D.GetIgnoreLayerCollision(layer, i))
			{
				num |= 1 << i;
			}
		}
		return num;
	}

	// Token: 0x06001BBE RID: 7102 RVA: 0x000842E4 File Offset: 0x000824E4
	public static float GetReflectedAngle(float angle, bool reflectHorizontal, bool reflectVertical)
	{
		if (reflectHorizontal)
		{
			angle = 180f - angle;
		}
		if (reflectVertical)
		{
			angle = -angle;
		}
		while (angle > 360f)
		{
			angle -= 360f;
		}
		while (angle < -360f)
		{
			angle += 360f;
		}
		return angle;
	}

	// Token: 0x06001BBF RID: 7103 RVA: 0x00084334 File Offset: 0x00082534
	public static Vector3 GetRandomVector3InRange(Vector3 min, Vector3 max)
	{
		float x = (min.x != max.x) ? UnityEngine.Random.Range(min.x, max.x) : min.x;
		float y = (min.y != max.y) ? UnityEngine.Random.Range(min.y, max.y) : min.y;
		float z = (min.z != max.z) ? UnityEngine.Random.Range(min.z, max.z) : min.z;
		return new Vector3(x, y, z);
	}

	// Token: 0x06001BC0 RID: 7104 RVA: 0x000843C0 File Offset: 0x000825C0
	public static Vector2 GetRandomVector2InRange(Vector2 min, Vector2 max)
	{
		float x = (min.x != max.x) ? UnityEngine.Random.Range(min.x, max.x) : min.x;
		float y = (min.y != max.y) ? UnityEngine.Random.Range(min.y, max.y) : min.y;
		return new Vector2(x, y);
	}

	// Token: 0x06001BC1 RID: 7105 RVA: 0x00084424 File Offset: 0x00082624
	public static bool IsRayHittingNoTriggers(Vector2 origin, Vector2 direction, float length, int layerMask, out RaycastHit2D closestHit)
	{
		if (Helper.rayHitStore == null)
		{
			Helper.rayHitStore = new RaycastHit2D[10];
		}
		int num = Physics2D.RaycastNonAlloc(origin, direction, Helper.rayHitStore, length, layerMask);
		bool flag = false;
		closestHit = default(RaycastHit2D);
		for (int i = 0; i < num; i++)
		{
			RaycastHit2D raycastHit2D = Helper.rayHitStore[i];
			Collider2D collider = raycastHit2D.collider;
			if (collider && !collider.isTrigger)
			{
				if (!flag || raycastHit2D.distance < closestHit.distance)
				{
					closestHit = raycastHit2D;
				}
				flag = true;
			}
			Helper.rayHitStore[i] = default(RaycastHit2D);
		}
		return flag;
	}

	// Token: 0x06001BC2 RID: 7106 RVA: 0x000844C0 File Offset: 0x000826C0
	public static bool IsRayHittingNoTriggers(Vector2 origin, Vector2 direction, float length, int layerMask)
	{
		RaycastHit2D raycastHit2D;
		return Helper.IsRayHittingNoTriggers(origin, direction, length, layerMask, out raycastHit2D);
	}

	// Token: 0x06001BC3 RID: 7107 RVA: 0x000844D8 File Offset: 0x000826D8
	public static string CombinePaths(string path1, params string[] paths)
	{
		if (path1 == null)
		{
			throw new ArgumentNullException("path1");
		}
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		return paths.Aggregate(path1, (string acc, string p) => Path.Combine(acc, p));
	}

	// Token: 0x06001BC4 RID: 7108 RVA: 0x00084527 File Offset: 0x00082727
	public static bool FileOrFolderExists(string path)
	{
		return File.Exists(path) || Directory.Exists(path);
	}

	// Token: 0x06001BC5 RID: 7109 RVA: 0x00084539 File Offset: 0x00082739
	public static void DeleteFileOrFolder(string path)
	{
		if ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory)
		{
			Directory.Delete(path, true);
			return;
		}
		File.Delete(path);
	}

	// Token: 0x06001BC6 RID: 7110 RVA: 0x00084558 File Offset: 0x00082758
	public static void CopyFileOrFolder(string src, string dest)
	{
		if ((File.GetAttributes(src) & FileAttributes.Directory) == FileAttributes.Directory)
		{
			DirectoryInfo source = new DirectoryInfo(src);
			DirectoryInfo target = Directory.Exists(dest) ? new DirectoryInfo(dest) : Directory.CreateDirectory(dest);
			Helper.DeepCopy(source, target);
			return;
		}
		File.Copy(src, dest);
	}

	// Token: 0x06001BC7 RID: 7111 RVA: 0x000845A0 File Offset: 0x000827A0
	public static void DeepCopy(DirectoryInfo source, DirectoryInfo target)
	{
		foreach (DirectoryInfo directoryInfo in source.GetDirectories())
		{
			Helper.DeepCopy(directoryInfo, target.CreateSubdirectory(directoryInfo.Name));
		}
		foreach (FileInfo fileInfo in source.GetFiles())
		{
			fileInfo.CopyTo(Path.Combine(target.FullName, fileInfo.Name));
		}
	}

	// Token: 0x06001BC8 RID: 7112 RVA: 0x0008460C File Offset: 0x0008280C
	public static void MoveFileOrFolder(string src, string dest)
	{
		if ((File.GetAttributes(src) & FileAttributes.Directory) == FileAttributes.Directory)
		{
			Directory.Move(src, dest);
			return;
		}
		File.Copy(src, dest);
	}

	// Token: 0x06001BC9 RID: 7113 RVA: 0x0008462C File Offset: 0x0008282C
	public static bool CheckMatchingSearchFilter(string text, string filter)
	{
		text = text.ToLower();
		filter = filter.ToLower().Replace('_', ' ');
		return filter.Split(new char[]
		{
			' '
		}).All((string f) => text.Contains(f));
	}

	// Token: 0x06001BCA RID: 7114 RVA: 0x0008468C File Offset: 0x0008288C
	public static string ParseSearchString(string original)
	{
		if (string.IsNullOrEmpty(original))
		{
			return null;
		}
		return original.Trim().ToLower().Replace(" ", "");
	}

	// Token: 0x040021B8 RID: 8632
	private static RaycastHit2D[] rayHitStore;
}
