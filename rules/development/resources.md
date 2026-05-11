---
title: Resource Management
impact: MEDIUM
impactDescription: Proper asset loading is essential for mod resources
tags: hk-api, resources, embedded, assets, texture
---

## Resource Management

规范层入口：先遵守 [Modding Spec](../modding-spec.md) 里的“内嵌资源规范”和“预加载与资源来源规范”。

本文件只保留资源实现示例和补充技巧，不再重复规范层的通用约束。

### Embedded Resources Setup

**In .csproj**:
```xml
<ItemGroup>
  <EmbeddedResource Include="assets\*.png" />
  <EmbeddedResource Include="assets\*.wav" />
</ItemGroup>
```

推荐把资源放在稳定目录下并统一命名，方便直接映射到程序集资源名。

---

### Loading Textures

```csharp
protected Texture2D LoadTex(string fileName)
{
    Assembly asm = Assembly.GetExecutingAssembly();
    string path = $"YourModName.assets.{fileName}";
    using (Stream s = asm.GetManifestResourceStream(path))
    {
        if (s == null)
        {
            Modding.Logger.LogError($"Missing embedded texture: {path}");
            return null;
        }

        byte[] buffer = new byte[s.Length];
        s.Read(buffer, 0, buffer.Length);
        Texture2D tex = new Texture2D(2, 2);
        tex.LoadImage(buffer);
        tex.filterMode = FilterMode.Point;  // Pixel art style
        return tex;
    }
}
```

---

### Loading Audio

```csharp
protected AudioClip LoadAudio(string fileName)
{
    Assembly asm = Assembly.GetExecutingAssembly();
    string path = $"YourModName.assets.{fileName}";
    using (Stream s = asm.GetManifestResourceStream(path))
    {
        if (s == null)
        {
            Modding.Logger.LogError($"Missing embedded audio: {path}");
            return null;
        }

        byte[] buffer = new byte[s.Length];
        s.Read(buffer, 0, buffer.Length);
        return WavUtility.ToAudioClip(buffer, fileName);
    }
}
```

### What To Avoid

不要写下面这类运行时查找逻辑：

```csharp
string path = Path.Combine(modDir, "assets", fileName);
if (File.Exists(path))
{
    return LoadFromDisk(path);
}

foreach (string candidate in candidatePaths)
{
    if (File.Exists(candidate))
    {
        return LoadFromDisk(candidate);
    }
}
```

上面的模式会导致：

- 开发机和用户机行为不一致
- 打包后资源路径容易失效
- 资源缺失时诊断点分散
- 后续维护时不断增加路径回退分支

正确做法的规范依据见 [Modding Spec](../modding-spec.md)。这里保留这段反例，主要是为了帮助识别代码异味。

---

### Preloading Game Objects

```csharp
public class MyMod : Mod
{
    public override List<(string, string)> GetPreloadNames()
    {
        return new List<(string, string)>
        {
            ("Tutorial_01", "_Enemies/Buzzer"),
            ("RestingGrounds_08", "Ghost revek"),
        };
    }
    
    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        var buzzer = preloadedObjects["Tutorial_01"]["_Enemies/Buzzer"];
        // Use preloaded objects
    }
}
```

---

### Advanced Preloading: Nested Objects

**Get GameObject from nested FSM**:
```csharp
public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
{
    var radiance = preloadedObjects["GG_Radiance"]["Boss Control/Absolute Radiance"];
    var radianceFSM = radiance.LocateMyFSM("Attack Commands");
    
    // Get gameObject from a SpawnObjectFromGlobalPool action
    var nailComb = radianceFSM.GetAction<SpawnObjectFromGlobalPool>("Comb Top", 0).gameObject.Value;
    
    // Then get FSM from that object
    var nailCombFSM = nailComb.LocateMyFSM("Control");
    var nailPrefab = nailCombFSM.GetAction<SpawnObjectFromGlobalPool>("RG1", 1).gameObject.Value;
}
```

**Remove components to make prefab reusable**:
```csharp
GameObject.Destroy(nailPrefab.GetComponent<PersistentBoolItem>());
GameObject.Destroy(nailPrefab.GetComponent<ConstrainPosition>());
```
