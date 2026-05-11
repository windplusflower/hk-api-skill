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

**添加新护符效果**
→ [Item IDs](core/item-ids.md) → [Code Patterns](development/code-patterns.md)

**修改音频 / 音效**
→ [Audio System](systems/audio-system.md) → [Code Patterns](development/code-patterns.md)

## 文档层级

```text
hk-api-skill/
├── SKILL.md
├── fsm-export/           # 24701 个 FSM Markdown 文件
├── fsm-index/
│   ├── README.md
│   ├── fsm-manifest.tsv
│   ├── scene-summary.md
│   └── boss-shortcuts.md
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
