# Satchel Source Code Index

## 概述

本文档是 Satchel 源代码的索引，帮助快速定位所需功能的源码位置。

**源代码位置**: `satchel-src/`

**GitHub**: https://github.com/PrashantMohta/Satchel

---

## 目录结构

```
satchel-src/
├── Core.cs                    # 核心功能入口
├── Mod.cs                     # Mod 入口
├── Satchel.csproj             # 项目文件
├── Animation/                 # 动画相关
├── Assets/                    # 资源文件
├── BetterMenus/               # 菜单系统（重点）
├── BetterPreloads/            # 预加载系统
├── Custom/                    # 自定义功能
├── Deprecated/                # 已弃用功能
├── Futils/                    # FSM 工具（重点）
├── JsonConverters/            # JSON 转换器
├── Monobehaviour/             # MonoBehaviour 组件
└── Utils/                     # 工具类
```

---

## 核心功能源码位置

### 1. BetterMenus（菜单系统）

**目录**: `BetterMenus/`

| 文件 | 路径 | 用途 |
|------|------|------|
| **Menu.cs** | `BetterMenus/Menu.cs` | 菜单屏幕定义（14KB） |
| **MenuOptionBuilder.cs** | `BetterMenus/MenuOptionBuilder.cs` | 菜单选项构建器（15KB） |
| **Utils.cs** | `BetterMenus/Utils.cs` | 工具方法 |
| **Attributes/** | `BetterMenus/Attributes/` | 特性定义 |
| **Base/** | `BetterMenus/Base/` | 基类定义 |
| **Blueprints/** | `BetterMenus/Blueprints/` | 菜单蓝图 |
| **Elements/** | `BetterMenus/Elements/` | UI 元素 |
| **Example/** | `BetterMenus/Example/` | 使用示例 |

#### 关键类

| 类名 | 文件 | 说明 |
|------|------|------|
| `MenuScreen` | Menu.cs | 菜单屏幕类 |
| `MenuOption` | MenuOptionBuilder.cs | 菜单选项类 |
| `SatchelHelper` | Utils.cs | 工具类（BuildModMenu） |

#### 使用示例位置

```bash
# 查看完整示例
cat BetterMenus/Example/
```

---

### 2. Futils（FSM 工具）

**目录**: `Futils/`

| 文件 | 路径 | 用途 |
|------|------|------|
| **FsmUtils.cs** | `Futils/FsmUtils.cs` | FSM 工具核心（23KB） |
| **FsmVariables.cs** | `Futils/FsmVariables.cs` | FSM 变量工具（5KB） |
| **CustomAction.cs** | `Futils/CustomAction.cs` | 自定义动作 |
| **Extractors/** | `Futils/Extractors/` | 数据提取器 |
| **Interceptors/** | `Futils/Interceptors/` | 拦截器 |
| **Serialiser/** | `Futils/Serialiser/` | 序列化器 |

#### 关键方法（FsmUtils.cs）

| 方法 | 行号 | 说明 |
|------|------|------|
| `LocateMyFSM` | ~50 | 查找 FSM 扩展方法 |
| `InsertMethod` | ~100 | 插入自定义方法 |
| `ChangeTransition` | ~150 | 修改 FSM 过渡 |
| `GetAction<T>` | ~200 | 获取 FSM 动作 |
| `InsertCustomAction` | ~250 | 插入自定义动作 |

#### 关键类（FsmVariables.cs）

| 类名 | 说明 |
|------|------|
| `FsmVariables` | FSM 变量操作类 |
| `GetFsmFloat` | 获取浮点变量 |
| `GetFsmInt` | 获取整数变量 |
| `GetFsmString` | 获取字符串变量 |

---

### 3. Core（核心功能）

**文件**: `Core.cs`（7KB）

| 功能 | 行号 | 说明 |
|------|------|------|
| `Satchel` 类 | ~1 | 主类定义 |
| `Log` 方法 | ~50 | 日志输出 |
| `GetModVersion` | ~80 | 获取 Mod 版本 |

---

### 4. BetterPreloads（预加载系统）

**目录**: `BetterPreloads/`

| 文件 | 路径 | 用途 |
|------|------|------|
| **PreloadManager.cs** | `BetterPreloads/PreloadManager.cs` | 预加载管理器 |
| **PreloadObject.cs** | `BetterPreloads/PreloadObject.cs` | 预加载对象 |

---

### 5. Custom（自定义功能）

**目录**: `Custom/`

| 文件 | 用途 |
|------|------|
| **CustomUI.cs** | 自定义 UI |
| **InteractiveCard.cs** | 互动卡片 |

---

### 6. Utils（工具类）

**目录**: `Utils/`

| 文件 | 用途 |
|------|------|
| **Extensions.cs** | 扩展方法 |
| **ReflectionHelper.cs** | 反射工具 |
| **SpriteHelper.cs** | 精灵工具 |

---

## 快速查找指南

### 我想...

**查看菜单系统源码**
→ `BetterMenus/Menu.cs`（菜单定义）
→ `BetterMenus/MenuOptionBuilder.cs`（选项构建）

**查看 FSM 工具源码**
→ `Futils/FsmUtils.cs`（核心工具）
→ `Futils/FsmVariables.cs`（变量操作）

**查看示例代码**
→ `BetterMenus/Example/`

**查看自定义 UI**
→ `Custom/InteractiveCard.cs`

**查看预加载系统**
→ `BetterPreloads/PreloadManager.cs`

**查看工具方法**
→ `Utils/Extensions.cs`

---

## 代码规模统计

| 目录 | 文件数 | 总大小 |
|------|--------|--------|
| BetterMenus/ | 20+ | ~50KB |
| Futils/ | 15+ | ~40KB |
| BetterPreloads/ | 5+ | ~10KB |
| Custom/ | 5+ | ~10KB |
| Utils/ | 10+ | ~15KB |
| Animation/ | 5+ | ~5KB |
| Assets/ | - | ~100KB |
| **总计** | **60+** | **~230KB** |

---

## 与文档对应关系

| 文档章节 | 对应源码 |
|----------|----------|
| BetterMenus 基本用法 | `BetterMenus/Menu.cs` + `BetterMenus/MenuOptionBuilder.cs` |
| BetterMenus 完整示例 | `BetterMenus/Example/` |
| FUtils 基本用法 | `Futils/FsmUtils.cs` |
| FUtils 常用方法 | `Futils/FsmUtils.cs` (LocateMyFSM, InsertMethod 等) |
| 自定义 UI | `Custom/InteractiveCard.cs` |
| 安装方法 | `Satchel.csproj` + `LocalBuildProperties.props` |

---

## 注意事项

1. **不要修改源码** - 这是第三方库源码，仅供查阅
2. **查看示例** - `BetterMenus/Example/` 包含完整使用示例
3. **参考文档** - 配合 `rules/libraries/satchel.md` 文档使用
4. **版本信息** - 查看 `Mod.cs` 了解当前版本

---

## 相关资源

- **使用文档**: `rules/libraries/satchel.md`
- **GitHub**: https://github.com/PrashantMohta/Satchel
- **官方文档**: https://prashantmohta.github.io/ModdingDocs/Satchel/Satchel.html
