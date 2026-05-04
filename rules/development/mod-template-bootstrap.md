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
2. 建立跨机器可移植的本地配置层：仓库内保留模板配置，机器相关路径放到未跟踪文件
3. 添加 HK/Unity/Modding 必需引用（Assembly-CSharp、UnityEngine.*、PlayMaker、MMHOOK_*），优先引用用户机器上已存在的真实 DLL
4. 创建 `Mod` 主类并实现：
   - `GetVersion()`
   - `Initialize(...)`
   - `IGlobalSettings<T>`
   - `IMenuMod`（至少一个开关）
5. 配置构建后安装：复制构建产物到 `Managed/Mods/<ModName>`，并自动生成可分发的 `<ModName>.zip`
6. 确保构建流程在新机器上只需补本地配置即可运行，不依赖硬编码环境路径
7. 在 README 写明：本地配置文件、构建命令、安装路径、找不到 DLL 时需要补哪些路径

## 核心原则

### 1. 依赖 DLL 必须优先使用机器上已存在的真实文件

- `Assembly-CSharp.dll`、`UnityEngine*.dll`、`PlayMaker.dll`、`MMHOOK_*.dll` 等引用，优先解析到用户电脑上已经存在的真实 DLL。
- 对于已安装 HK Modding API 的游戏环境，要先假定 `Managed/Assembly-CSharp.dll` 已被 Modding API 以覆盖安装方式替换；此时它既是游戏主程序集，也是 Modding API 所在程序集，不应再默认额外寻找单独的 `Modding.dll`。
- 不要默认把这些 DLL 复制进仓库，也不要伪造占位 DLL。
- 如果自动探测不到某个必需 DLL，必须询问用户路径，并把这个缺口记录到 skill 的本地机器配置说明里。

### 2. 机器相关配置必须和仓库代码分离

- 构建系统必须满足跨平台、跨机器拉取后仍可编译。
- 仓库提交的文件只能包含可移植模板、相对路径、环境变量回退、以及导入本地配置文件的逻辑。
- 机器相关的绝对路径应放在未跟踪文件中，例如 `LocalBuildProperties.props`、`.env.local`、`.local/` 或类似本地配置层。
- 这类本地配置文件应加入 `.gitignore`，并同时提供可提交的示例文件，例如 `LocalBuildProperties.props.example`。

### 3. 构建完成后自动安装，不要求用户手动复制

- 默认构建完成后必须自动把 mod 产物安装到 `Managed/Mods/<ModName>`。
- 同一轮构建还应自动生成可分发的 zip 包，并一并复制到安装目录，避免用户手动整理发布包。
- 用户执行一次正常构建后，应同时得到：可直接运行的已安装 mod、可直接分发的 zip、以及可选的调试符号文件。

### 4. RingLib 不是模板默认依赖

- RingLib 属于协程状态机类库，不应在初始化仓库或生成最小模板时默认加入。
- 只有当 mod 确实需要基于协程的自定义状态机、复杂阶段流转、或希望用 RingLib 管理行为状态时，才应把它加入项目。
- 普通 Hook、FSM 修改、简单菜单、基础数据保存、基础预加载等模板场景，不需要为了“以后可能会用”而预先接入 RingLib。
- 如果用户只是说“先建一个新 mod 项目”，默认不要创建 RingLib 依赖、引用、示例代码或目录。

## 本地配置层设计

推荐在项目根目录采用两层配置：

```text
MyMod/
├── MyMod.csproj
├── LocalBuildProperties.props.example
├── .gitignore
└── LocalBuildProperties.props      # 本机创建，gitignore
```

### 推荐的 `.gitignore`

```gitignore
LocalBuildProperties.props
.local/
```

### 推荐的 `LocalBuildProperties.props.example`

```xml
<Project>
  <PropertyGroup>
    <HKManagedDir>C:\Path\To\Hollow Knight\hollow_knight_Data\Managed</HKManagedDir>
    <HKModsDir>C:\Path\To\Hollow Knight\hollow_knight_Data\Managed\Mods</HKModsDir>
    <HKModdingApiDir>C:\Path\To\HKModdingAPI</HKModdingApiDir>
  </PropertyGroup>
</Project>
```

### 推荐的 `Directory.Build.props` / `.csproj` 导入模式

```xml
<Import Project="LocalBuildProperties.props"
        Condition="Exists('LocalBuildProperties.props')" />
```

要求：

- 仓库内必须有示例文件，但不要提交真实机器路径。
- 如果本地配置缺失，构建报错信息要明确指出缺的是哪个目录或 DLL。
- AI 在新项目里发现缺少本地配置时，应先创建 example 文件和 `.gitignore`，再提示用户补真实路径。

## DLL 解析策略

优先顺序：

1. `LocalBuildProperties.props` 中用户显式提供的目录
2. 机器上已知的游戏安装目录、已安装 Mods 目录
3. 环境变量回退
4. 询问用户

规则：

- 找到真实 DLL 后，引用应指向该 DLL 的实际存在路径。
- 如果用户说明其游戏已经装好 HK Modding API，应优先把 `$(HKManagedDir)\Assembly-CSharp.dll` 视为 `Assembly-CSharp` 和 `Modding` 共同的来源程序集。
- 找不到时不要瞎猜最终 `HintPath`，必须停下来问用户。
- 问到用户提供路径后，应把这类“本机依赖位置”沉淀到本地配置模板说明，而不是写死到项目主 `.csproj`。
- 如果依赖来自其他 mod，例如 `Satchel.dll`，优先从已安装的 `Managed/Mods/<Dependency>/` 查找。

### 推荐的引用方式

```xml
<ItemGroup>
  <Reference Include="Assembly-CSharp">
    <HintPath>$(HKManagedDir)\Assembly-CSharp.dll</HintPath>
    <Private>false</Private>
  </Reference>
  <Reference Include="Modding">
    <HintPath>$(HKManagedDir)\Assembly-CSharp.dll</HintPath>
    <Private>false</Private>
  </Reference>
  <Reference Include="Satchel" Condition="Exists('$(HKModsDir)\Satchel\Satchel.dll')">
    <HintPath>$(HKModsDir)\Satchel\Satchel.dll</HintPath>
    <Private>false</Private>
  </Reference>
</ItemGroup>
```

注意：上面只是模式示例。实际项目中应先确认当前机器是否已经装好 HK Modding API；如果已安装，通常 `Assembly-CSharp.dll` 就已经是带 Modding API 的版本。其他可选依赖如 `MMHOOK_*`、`Satchel.dll` 再按真实位置补充。

## 构建产物打包策略（推荐默认启用）

对于 HK Mod 模板，推荐在 `.csproj` 的构建后目标里同时完成三件事：

1. 将 `.dll/.pdb` 与资源文件复制到 `Managed/Mods/<ModName>`
2. 在临时 `Archive/` 目录中整理要发布的文件
3. 自动生成 `<ModName>.zip`，并输出 `SHA256.txt`
4. 把生成的 zip 一并放进 `Managed/Mods/<ModName>`，使本地安装目录同时具备运行产物和分发包

这样做的好处：

1. 本地调试安装与发布包生成共用同一套构建流程
2. 每次构建后立即得到可直接分发的 zip 包
3. 校验文件哈希更方便做版本发布与更新校验

### 推荐的 `.csproj` 目标示例

```xml
<PropertyGroup>
  <InstallDir>$(HKModsDir)\$(AssemblyName)</InstallDir>
  <PackageDir>$(OutputPath)package\</PackageDir>
</PropertyGroup>

<Target Name="ValidateLocalBuildConfig" BeforeTargets="Build">
  <Error Condition="'$(HKManagedDir)' == ''"
         Text="HKManagedDir is not set. Create LocalBuildProperties.props from the example file and point it to your Hollow Knight Managed directory." />
  <Error Condition="'$(HKModsDir)' == ''"
         Text="HKModsDir is not set. Create LocalBuildProperties.props from the example file and point it to your Hollow Knight Mods directory." />
  <Error Condition="!Exists('$(HKManagedDir)\Assembly-CSharp.dll')"
         Text="Assembly-CSharp.dll was not found under HKManagedDir. Verify your local Hollow Knight installation path." />
</Target>

<Target Name="InstallMod" AfterTargets="Build">
  <MakeDir Directories="$(InstallDir)" />
  <MakeDir Directories="$(InstallDir)\assets" />
  <Copy SourceFiles="$(TargetPath)" DestinationFolder="$(InstallDir)" />
  <Copy SourceFiles="$(TargetDir)$(AssemblyName).pdb" DestinationFolder="$(InstallDir)" Condition="Exists('$(TargetDir)$(AssemblyName).pdb')" />

  <RemoveDir Condition="Exists('$(PackageDir)')" Directories="$(PackageDir)" />
  <MakeDir Directories="$(PackageDir)" />

  <ItemGroup>
    <PackageFiles Include="$(TargetPath)" />
    <PackageFiles Include="$(TargetDir)$(AssemblyName).pdb" Condition="Exists('$(TargetDir)$(AssemblyName).pdb')" />
    <PackageFiles Include="assets\**\*" />
  </ItemGroup>

  <Copy
    SourceFiles="@(PackageFiles)"
    DestinationFiles="@(PackageFiles->'$(PackageDir)%(RecursiveDir)%(Filename)%(Extension)')"
  />

  <ZipDirectory
    SourceDirectory="$(PackageDir)"
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

  <RemoveDir Directories="$(PackageDir)" />
</Target>
```

### 模板生成时的默认要求

- 若模板包含 `assets/`，应将资源一并复制进安装目录与 zip 包
- zip 包内容应以 mod 根目录内容为准，不要把整个 `bin/Debug` 打进去
- 建议构建完成后固定输出：`<ModName>.dll`、可选 `.pdb`、`<ModName>.zip`、`SHA256.txt`
- zip 包应和运行产物一起放进 `Managed/Mods/<ModName>`，保证“构建即安装”
- 若用户明确只要本地调试模板，可保留 zip 目标为可选；否则默认启用

## 路径策略（不要把真实机器路径提交进仓库）

当已经能确定用户机器上的正确目录时，也**不要把该绝对路径直接提交进主 `.csproj`**。应把它写入本机 `LocalBuildProperties.props`，并让项目通过条件导入来读取。

理由：

1. 不同电脑、不同系统、不同磁盘布局的安装路径不一致
2. 机器相关配置进入仓库后会破坏跨机器构建
3. 本地 props 方案既保留自动构建体验，也不污染仓库

推荐流程：

1. 先探测常见路径（如 Steam 默认路径、用户已安装的 Mods 目录、Modding API 目录）
2. 找到有效路径后，写入本机 `LocalBuildProperties.props`
3. 提交 `LocalBuildProperties.props.example` 和 `.gitignore`
4. 仅在路径不确定时，才退回到环境变量或向用户询问

### 不推荐的做法

```xml
<PropertyGroup>
  <HKManagedDir>D:\SteamLibrary\steamapps\common\Hollow Knight\hollow_knight_Data\Managed</HKManagedDir>
</PropertyGroup>
```

上面这种真实路径不应直接提交进仓库，只能存在于本机未跟踪文件。

### 推荐的仓库内写法

```xml
<PropertyGroup>
  <HKManagedDir Condition="'$(HKManagedDir)' == ''">$(HK_MANAGED_DIR)</HKManagedDir>
  <HKModsDir Condition="'$(HKModsDir)' == ''">$(HK_MODS_DIR)</HKModsDir>
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
2. **硬编码路径**：不要把真实机器路径提交进仓库；应改用本地 props + example 文件
3. **演示逻辑污染模板**：具体 Boss/FSM 场景判断应改为通用占位注释
4. **可选库耦合**：如 RingLib/Satchel，应标注为可选依赖而非强制；其中 RingLib 默认不要随模板初始化加入
5. **手动安装依赖**：不要让用户在构建后再手动复制 DLL/zip；默认应构建即安装

## 对现有模板仓库的应用建议

当工作区已是模板仓库（例如 `HKModTemplate`）时：

1. 优先保留“可运行最小骨架”
2. 将特化示例改成注释化占位逻辑
3. 在 README 单独列出“从空目录起步”的步骤
4. 若仓库中已有高级库目录（如 RingLib），应明确其为可选，不要让初始化模板默认耦合它
