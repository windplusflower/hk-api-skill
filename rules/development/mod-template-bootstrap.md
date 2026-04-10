# Hollow Knight Mod Template Bootstrap

用于指导 AI 在**空目录**中创建一个可编译、可安装的 Hollow Knight Mod 模板。

## 适用场景

- 用户说“从零创建 HK Mod 模板”
- 目录为空，只有需求说明
- 需要快速得到可运行的最小项目

## 最小目录结构

```text
MyMod/
├── MyMod.csproj
├── MyMod.cs
├── README.md
└── assets/               # 可选，嵌入资源
```

## 必需步骤（按顺序）

1. 创建 `net472` SDK 风格项目（`MyMod.csproj`）
2. 添加 HK/Unity/Modding 必需引用（Assembly-CSharp、UnityEngine.*、PlayMaker、MMHOOK_*）
3. 创建 `Mod` 主类并实现：
   - `GetVersion()`
   - `Initialize(...)`
   - `IGlobalSettings<T>`
   - `IMenuMod`（至少一个开关）
4. 配置构建后安装：复制构建产物到 `Managed/Mods/<ModName>`，并自动生成可分发的 `<ModName>.zip`
5. 在 README 写明：重命名项、`GameDir` 配置、构建命令、安装路径

## 构建产物打包策略（推荐默认启用）

对于 HK Mod 模板，推荐在 `.csproj` 的构建后目标里同时完成三件事：

1. 将 `.dll/.pdb` 与资源文件复制到 `Managed/Mods/<ModName>`
2. 在临时 `Archive/` 目录中整理要发布的文件
3. 自动生成 `<ModName>.zip`，并输出 `SHA256.txt`

这样做的好处：

1. 本地调试安装与发布包生成共用同一套构建流程
2. 每次构建后立即得到可直接分发的 zip 包
3. 校验文件哈希更方便做版本发布与更新校验

### 推荐的 `.csproj` 目标示例

```xml
<Target Name="InstallMod" AfterTargets="Build">
  <MakeDir Directories="$(InstallDir)" />
  <MakeDir Directories="$(InstallDir)\assets" />
  <Copy SourceFiles="$(TargetPath)" DestinationFolder="$(InstallDir)" />
  <Copy SourceFiles="$(TargetDir)$(AssemblyName).pdb" DestinationFolder="$(InstallDir)" Condition="Exists('$(TargetDir)$(AssemblyName).pdb')" />

  <RemoveDir Condition="Exists('$(InstallDir)\Archive')" Directories="$(InstallDir)\Archive" />
  <MakeDir Directories="$(InstallDir)\Archive" />

  <ItemGroup>
    <PackageFiles Include="$(TargetPath)" />
    <PackageFiles Include="$(TargetDir)$(AssemblyName).pdb" Condition="Exists('$(TargetDir)$(AssemblyName).pdb')" />
    <PackageFiles Include="assets\**\*" />
  </ItemGroup>

  <Copy
    SourceFiles="@(PackageFiles)"
    DestinationFiles="@(PackageFiles->'$(InstallDir)\Archive\%(RecursiveDir)%(Filename)%(Extension)')"
  />

  <ZipDirectory
    SourceDirectory="$(InstallDir)\Archive"
    DestinationFile="$(InstallDir)\$(AssemblyName).zip"
    Overwrite="true"
  />

  <GetFileHash Files="$(InstallDir)\$(AssemblyName).zip" Algorithm="SHA256">
    <Output TaskParameter="Items" ItemName="PackageHash" />
  </GetFileHash>

  <WriteLinesToFile
    File="$(InstallDir)\SHA256.txt"
    Lines="@(PackageHash->'%(FileHash)')"
    Overwrite="true"
    Encoding="UTF-8"
  />

  <RemoveDir Directories="$(InstallDir)\Archive" />
</Target>
```

### 模板生成时的默认要求

- 若模板包含 `assets/`，应将资源一并复制进安装目录与 zip 包
- zip 包内容应以 mod 根目录内容为准，不要把整个 `bin/Debug` 打进去
- 建议构建完成后固定输出：`<ModName>.dll`、可选 `.pdb`、`<ModName>.zip`、`SHA256.txt`
- 若用户明确只要本地调试模板，可保留 zip 目标为可选；否则默认启用

## GameDir 路径策略（默认写入 csproj）

当已经能确定用户机器上的正确 `Managed` 目录时，**优先把该绝对路径直接写入 `.csproj` 的 `GameDir`**，而不是要求用户每次 `dotnet build -p:GameDir=...`。

理由：

1. 大部分用户路径模式一致（Steam 默认安装路径）
2. 模板项目通常由单个开发者维护，固定路径成本更低
3. 降低命令行参数出错概率，首次构建体验更稳定

推荐流程：

1. 先探测常见路径（如 `D:\SteamLibrary\...`、`C:\Program Files (x86)\Steam\...`）
2. 找到有效路径后，写入 `<GameDir>...</GameDir>`
3. 仅在路径不确定时，才保留 `HK_GAME_DIR` 或 `-p:GameDir=...` 作为备用

### 示例（推荐）

```xml
<PropertyGroup>
  <GameDir>D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\Managed</GameDir>
</PropertyGroup>
```

### 备用模式（路径未知时）

```xml
<PropertyGroup>
  <GameDir Condition="'$(GameDir)' == ''">$(HK_GAME_DIR)</GameDir>
  <GameDir Condition="'$(GameDir)' == ''">C:\Program Files (x86)\Steam\steamapps\common\Hollow Knight\hollow_knight_Data\Managed</GameDir>
</PropertyGroup>
```

## 推荐的模板主类骨架

```csharp
using Modding;
using UnityEngine;

namespace MyMod;

[Serializable]
public class ModSettings
{
    public bool Enabled = true;
}

public class MyMod : Mod, IGlobalSettings<ModSettings>, IMenuMod
{
    private ModSettings settings = new();

    public MyMod() : base("MyMod") { }
    public override string GetVersion() => "1.0.0";

    public override void Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)
    {
        // register hooks
    }

    public void OnLoadGlobal(ModSettings s) => settings = s ?? new ModSettings();
    public ModSettings OnSaveGlobal() => settings;
    public bool ToggleButtonInsideMenu => true;
    public List<IMenuMod.MenuEntry> GetMenuData(IMenuMod.MenuEntry? menu) => new();
}
```

## 常见特化项（需要 AI 主动提醒）

1. **项目命名残留**：类名、命名空间、构造函数中的 mod 名称未同步
2. **硬编码路径**：仅当路径已验证且项目由单人维护时推荐；多人协作项目应提供备用策略
3. **演示逻辑污染模板**：具体 Boss/FSM 场景判断应改为通用占位注释
4. **可选库耦合**：如 RingLib/Satchel，应标注为可选依赖而非强制

## 对现有模板仓库的应用建议

当工作区已是模板仓库（例如 `HKModTemplate`）时：

1. 优先保留“可运行最小骨架”
2. 将特化示例改成注释化占位逻辑
3. 在 README 单独列出“从空目录起步”的步骤
4. 保留高级库目录（如 RingLib）但明确其为可选
