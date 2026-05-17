# HK API Rules Index

## Rule Priority & Conflict Resolution

When rules conflict, follow this priority:
1. `SKILL.md` explicit statements
2. `modding-spec.md`
3. `core/`
4. `systems/`
5. `development/`
6. `libraries/`

If still ambiguous, prefer the more specific rule.

## 快速导航

按使用场景分类的规则文档索引。

## 先读规范层

`hk-api` 已重构为两层：

1. **Modding Spec**：全量加载的工作规范
2. **Modding Knowledge**：按需渐进查阅的知识文档

开始处理 HK modding 任务时，先读：

- [Modding Spec](modding-spec.md)

再根据问题类型按需打开下面的知识文档。

默认不应整批预读 `core/`、`systems/`、`development/`、`libraries/`、`fsm-index/` 或 `hkapi/`；只有当前问题需要时才打开最少必要内容。

## FSM 数据入口

如果任务涉及 PlayMaker FSM，先看这些文件，而不是直接猜名字：

- [FSM Index README](../fsm-index/README.md) - FSM 数据集总入口
- [Scene Summary](../fsm-index/scene-summary.md) - 当前导出的按区域 / scene 汇总
- [Boss Shortcuts](../fsm-index/boss-shortcuts.md) - 当前导出的 Boss / 战斗场景快速入口
- [FSM Query Guide](core/fsm-query-guide.md) - 具体检索流程和查询范式

## 场景物体 / 几何信息入口

需要回答「场景里有哪些 GameObject」「某个 GO 的位置 / collider 大小」这类问题时：

- [Scene Index README](../scene-index/README.md) - 场景物体索引（lazy-dump 架构）总览
- `scene-index/scene-objects.tsv` - 静态行级索引：scene / go_path / pathid / world position / collider / renderer / fsm_count
- `scripts/dump_gameobject.py` - 按需生成单个 GO 的完整组件 markdown（写入 `scene-cache/`）
- `scripts/rebuild_scene_index.py` - 重建索引（依赖本地 HK 安装 + `pip install UnityPy`）

索引只覆盖 level 文件里静态保存的 GameObject。运行时 `Instantiate` 出来的对象（投射物 / 生成的敌人 / 跨场景 DontDestroyOnLoad）需要 in-game 的 UnityExplorer mod。

## 新手入门

**刚开始做 Mod？** 按以下顺序阅读：

1. [核心类参考](core/core-classes.md) - 了解 `HeroController`、`PlayerData` 等基础类
2. [FSM Reference](core/fsm-reference.md) - 了解 FSM 数据集和运行时操作
3. [FSM Query Guide](core/fsm-query-guide.md) - 学会按 Boss / scene / 名称找具体 FSM
4. [常用 Hook](development/common-hooks.md) - 学习如何拦截游戏逻辑
5. [代码模式](development/code-patterns.md) - 掌握常见代码模式

## 分类索引

### Core（核心参考）

| 文档 | 用途 |
|------|------|
| [Core Classes](core/core-classes.md) | `HeroController`, `PlayerData`, `HealthManager` 等核心类 |
| [FSM Reference](core/fsm-reference.md) | FSM 数据集概况、常见命名、事件、运行时修改 |
| [FSM Query Guide](core/fsm-query-guide.md) | 从 Boss / scene / GameObject / FSM 名定位具体导出文件 |
| [Item IDs](core/item-ids.md) | 护符 ID、`PlayerData` 字段 |
| [Preload Names](core/preload-names.md) | 预加载物品和场景对象 |

### Systems（游戏系统）

| 文档 | 用途 |
|------|------|
| [Combat System](systems/combat-system.md) | 伤害计算、攻击检测 |
| [Spell System](systems/spell-system.md) | 法术拦截和修改 |
| [Nail Arts](systems/nail-arts.md) | 骨钉技拦截 |
| [Audio System](systems/audio-system.md) | 音效和音频管理 |
| [Game Modification Patterns](systems/game-modification-patterns.md) | 商店 / Boss / 敌人 / 场景等系统修改模式 |

### Development（开发指南）

| 文档 | 用途 |
|------|------|
| [Common Hooks](development/common-hooks.md) | 常用 Hook 模式 |
| [Code Patterns](development/code-patterns.md) | 常见代码模式 |
| [Resource Management](development/resources.md) | 资源加载和管理 |
| [Best Practices](development/best-practices.md) | 最佳实践和技巧 |
| [Template Bootstrap](development/mod-template-bootstrap.md) | 从空目录创建 HK Mod 模板 |

### Libraries（第三方库）

| 文档 | 用途 |
|------|------|
| [Satchel](libraries/satchel.md) | `Satchel` 工具库（BetterMenus / FUtils / 自定义 UI） |
| [Satchel Source Index](libraries/satchel-src-index.md) | `Satchel` 源代码索引 |
| [RingLib](libraries/ringlib.md) | 协程状态机源码库的定位、接入方式与 HK mod 用法 |
| [RingLib Source Index](libraries/ringlib-src-index.md) | `RingLib` 内置源码索引 |

## 按任务查找

### 我想...

**定位某个 Boss 的 FSM**
→ [FSM Query Guide](core/fsm-query-guide.md) → [Boss Shortcuts](../fsm-index/boss-shortcuts.md) → [FSM Reference](core/fsm-reference.md)

**按 scene 找 FSM**
→ [FSM Query Guide](core/fsm-query-guide.md) → [Scene Summary](../fsm-index/scene-summary.md)

**按 GameObject / FSM 名找具体文件**
→ [FSM Query Guide](core/fsm-query-guide.md) → [FSM Index README](../fsm-index/README.md)

**修改 Boss 行为**
→ [Game Modification Patterns](systems/game-modification-patterns.md) → [FSM Reference](core/fsm-reference.md) → [Common Hooks](development/common-hooks.md)

**修改商店**
→ [Game Modification Patterns](systems/game-modification-patterns.md) → [FSM Reference](core/fsm-reference.md)

**修改法术效果**
→ [Spell System](systems/spell-system.md) → [FSM Reference](core/fsm-reference.md)

**修改骨钉技**
→ [Nail Arts](systems/nail-arts.md) → [FSM Reference](core/fsm-reference.md)

**修改伤害计算**
→ [Combat System](systems/combat-system.md) → [Item IDs](core/item-ids.md)

**添加游戏内设置菜单**
→ [Code Patterns](development/code-patterns.md) - 搜索 `Menu`

**从空目录创建 Mod 模板 / 构建系统**
→ [Template Bootstrap](development/mod-template-bootstrap.md) → [Best Practices](development/best-practices.md)

**用 C# 协程状态机组织 Boss / 敌人逻辑**
→ [RingLib](libraries/ringlib.md) → [RingLib Source Index](libraries/ringlib-src-index.md)

**优化资源加载**
→ [Resource Management](development/resources.md) → [Preload Names](core/preload-names.md)

**添加新 NPC**
→ [FSM Query Guide](core/fsm-query-guide.md) → [Game Modification Patterns](systems/game-modification-patterns.md) → [Code Patterns](development/code-patterns.md)

**修改场景流程**
→ [FSM Query Guide](core/fsm-query-guide.md) → [Scene Summary](../fsm-index/scene-summary.md) → [Game Modification Patterns](systems/game-modification-patterns.md)

**列出场景里所有物体 / 查 GO 坐标 / collider 大小**
→ [Scene Index README](../scene-index/README.md) → 直接 grep `scene-index/scene-objects.tsv` → 需要细节时用 `scripts/dump_gameobject.py --scene X --pathid N`

**添加新护符效果**
→ [Item IDs](core/item-ids.md) → [Code Patterns](development/code-patterns.md)

**修改音频 / 音效**
→ [Audio System](systems/audio-system.md) → [Code Patterns](development/code-patterns.md)

## 文档层级

```text
hk-api/
├── SKILL.md
├── fsm-export/           # 24701 个 FSM Markdown 文件
├── fsm-index/
│   ├── README.md
│   ├── fsm-manifest.tsv
│   ├── scene-summary.md
│   └── boss-shortcuts.md
├── scene-index/          # 静态场景物体索引（lazy-dump 架构）
│   ├── README.md
│   ├── scene-objects.tsv  # 587944 行
│   └── scene-map.tsv      # scene → levelN 映射
├── scene-cache/          # dump_gameobject.py 按需写入的单 GO markdown（gitignored）
│   └── README.md
├── scripts/
│   ├── README.md
│   ├── evolution_record.py
│   ├── rebuild_scene_index.py
│   └── dump_gameobject.py
├── data/                 # 辅助数据
│   └── gameDic.json      # 游戏内文本字典（中文本地化 key → 文本）
├── satchel-src/          # Satchel 库源码镜像（rules/libraries/satchel-src-index.md 索引）
├── rules/
│   ├── INDEX.md
│   ├── core/
│   │   ├── core-classes.md
│   │   ├── fsm-reference.md
│   │   ├── fsm-query-guide.md
│   │   ├── item-ids.md
│   │   └── preload-names.md
│   ├── systems/
│   │   ├── combat-system.md
│   │   ├── spell-system.md
│   │   ├── nail-arts.md
│   │   ├── audio-system.md
│   │   └── game-modification-patterns.md
│   ├── development/
│   │   ├── common-hooks.md
│   │   ├── code-patterns.md
│   │   ├── resources.md
│   │   ├── best-practices.md
│   │   └── mod-template-bootstrap.md
│   ├── libraries/
│   │   ├── satchel.md
│   │   ├── satchel-src-index.md
│   │   ├── ringlib.md
│   │   └── ringlib-src-index.md
│   ├── evolution-notes/
│   │   └── README.md
│   └── _pending/
│       └── README.md
├── EVOLUTION.md
├── EVOLUTION_LOG.md
├── hkapi/
└── third_party/
    └── RingLib/
```

## 使用提示

1. 先判断问题属于 `源码 API` 还是 `FSM 图`。
2. 查 FSM 时优先走 `fsm-manifest.tsv -> boss-shortcuts/scene-summary -> fsm-export`。
3. 回答具体 FSM 问题时，尽量给出 `scene`、`gameobject_segment`、`fsm_name`、`fsm_id`、`relative_path`。
4. 运行时改写、Hook 点和代码注入问题，再回到 `rules/development/` 和 `rules/systems/`。

### Fallback Learning (2026-05-16)
<!-- evolution:e490a98c975e -->
- Question: 场景内 GameObject 列表 / 位置 / collider 大小如何静态查询？
- Facts:
  - Hollow Knight 关卡序列化在 hollow_knight_Data/levelN，N 与 globalgamemanagers.BuildSettings 索引一致 (501 scenes)。
  - 用 UnityPy 读 levelN 可枚举所有 GameObject + Transform/Collider2D/Renderer 字段，但 MonoBehaviour 的 m_Script 类名解析需要跨文件 env，否则失败。
  - 新增 scene-index/scene-objects.tsv 静态索引：scene/go_path/pathid/world_pos/collider/renderer/fsm_count，~MB 体量，覆盖所有场景静态 GO。
  - fsm_count 通过解析 fsm-export/.../*.md 的 GameObject PathId 与 GO 精确 join，不能用名字 join（短名如 White_Flash 会过度匹配）。
  - scripts/dump_gameobject.py 按 (scene, pathid) 在查询时生成单 GO 完整组件 markdown，写入 scene-cache/，避免全量预 dump。
  - 运行时 Instantiate 出来的 GO（投射物、spawn 出来的敌人、DontDestroyOnLoad 上下文）静态拿不到，需 UnityExplorer mod。
- Sources:
  - `scripts/rebuild_scene_index.py:1`
  - `scripts/dump_gameobject.py:1`
  - `scene-index/README.md:1`
