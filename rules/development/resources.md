---
title: Resource Management
impact: MEDIUM
impactDescription: Proper asset loading is essential for mod resources
tags: hk-api, resources, embedded, assets, texture
---

## Resource Management

### Embedded Resources Setup

**In .csproj**:
```xml
<ItemGroup>
  <EmbeddedResource Include="assets\*.png" />
  <EmbeddedResource Include="assets\*.wav" />
</ItemGroup>
```

---

### Loading Textures

```csharp
protected Texture2D LoadTex(string fileName)
{
    Assembly asm = Assembly.GetExecutingAssembly();
    string path = $"YourModName.assets.{fileName}";
    using (Stream s = asm.GetManifestResourceStream(path))
    {
        if (s == null) return null;
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
        if (s == null) return null;
        byte[] buffer = new byte[s.Length];
        s.Read(buffer, 0, buffer.Length);
        return WavUtility.ToAudioClip(buffer, fileName);
    }
}
```

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
