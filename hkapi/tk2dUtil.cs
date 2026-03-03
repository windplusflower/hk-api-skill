using System;
using UnityEngine;

// Token: 0x02000594 RID: 1428
public static class tk2dUtil
{
	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x000A0384 File Offset: 0x0009E584
	// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x000A038B File Offset: 0x0009E58B
	public static bool UndoEnabled
	{
		get
		{
			return tk2dUtil.undoEnabled;
		}
		set
		{
			tk2dUtil.undoEnabled = value;
		}
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000A0393 File Offset: 0x0009E593
	public static void BeginGroup(string name)
	{
		tk2dUtil.undoEnabled = true;
		tk2dUtil.label = name;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000A03A1 File Offset: 0x0009E5A1
	public static void EndGroup()
	{
		tk2dUtil.label = "";
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x000A03AD File Offset: 0x0009E5AD
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
		if (obj == null)
		{
			return;
		}
		UnityEngine.Object.DestroyImmediate(obj);
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x000A03BF File Offset: 0x0009E5BF
	public static GameObject CreateGameObject(string name)
	{
		return new GameObject(name);
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000A03C7 File Offset: 0x0009E5C7
	public static Mesh CreateMesh()
	{
		Mesh mesh = new Mesh();
		mesh.MarkDynamic();
		return mesh;
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000A03D4 File Offset: 0x0009E5D4
	public static T AddComponent<T>(GameObject go) where T : Component
	{
		return go.AddComponent<T>();
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000A03DC File Offset: 0x0009E5DC
	public static void SetActive(GameObject go, bool active)
	{
		if (active == go.activeSelf)
		{
			return;
		}
		go.SetActive(active);
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000A03EF File Offset: 0x0009E5EF
	public static void SetTransformParent(Transform t, Transform parent)
	{
		t.parent = parent;
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x00003603 File Offset: 0x00001803
	public static void SetDirty(UnityEngine.Object @object)
	{
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000A03F8 File Offset: 0x0009E5F8
	// Note: this type is marked as 'beforefieldinit'.
	static tk2dUtil()
	{
		tk2dUtil.label = "";
		tk2dUtil.undoEnabled = false;
	}

	// Token: 0x0400259F RID: 9631
	private static string label;

	// Token: 0x040025A0 RID: 9632
	private static bool undoEnabled;
}
