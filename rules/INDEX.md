# HK API Rules Index

## 快速导航

按使用场景分类的规则文档索引。

---

## 🔰 新手入门

**刚开始做 Mod？** 按以下顺序阅读：

1. [核心类参考](core/core-classes.md) - 了解 HeroController, PlayerData 等基础类
2. [FSM 参考](core/fsm-reference.md) - 理解状态机系统
3. [常用 Hook](development/common-hooks.md) - 学习如何拦截游戏逻辑
4. [代码模式](development/code-patterns.md) - 掌握常见代码模式

---

## 📚 分类索引

### Core（核心参考）

基础 API 和数据结构。

| 文档 | 用途 |
|------|------|
| [Core Classes](core/core-classes.md) | HeroController, PlayerData, HealthManager 等核心类 |
| [FSM Reference](core/fsm-reference.md) | PlayMaker FSM 列表、状态、事件 |
| [Item IDs](core/item-ids.md) | 护符 ID、PlayerData 字段 |
| [Preload Names](core/preload-names.md) | 预加载物品和场景对象 |

### Systems（游戏系统）

特定游戏系统的修改方法。

| 文档 | 用途 |
|------|------|
| [Combat System](systems/combat-system.md) | 伤害计算、攻击检测 |
| [Spell System](systems/spell-system.md) | 法术拦截和修改 |
| [Nail Arts](systems/nail-arts.md) | 骨钉技拦截 |
| [Audio System](systems/audio-system.md) | 音效和音频管理 |
| [Game Modification Patterns](systems/game-modification-patterns.md) | **游戏自带系统修改模式**（商店/Boss/敌人/场景等 8 个模式）<br>⚠️ 本文档较长，建议按需阅读或使用快速导航 |

### Development（开发指南）

开发工具和最佳实践。

| 文档 | 用途 |
|------|------|
| [Common Hooks](development/common-hooks.md) | 常用 Hook 模式 |
| [Code Patterns](development/code-patterns.md) | 常见代码模式 |
| [Resource Management](development/resources.md) | 资源加载和管理 |
| [Best Practices](development/best-practices.md) | 最佳实践和技巧 |

### Libraries（第三方库）

常用第三方库使用指南和源码索引。

| 文档 | 用途 |
|------|------|
| [Satchel](libraries/satchel.md) | **Satchel 工具库**（BetterMenus/FUtils/自定义 UI） |
| [Satchel Source Index](libraries/satchel-src-index.md) | **Satchel 源代码索引**（快速定位源码位置） |

---

## 🔍 按任务查找

### 我想...

**修改 Boss 行为**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - Boss 组件附加模式 → [FSM Reference](core/fsm-reference.md) → [Common Hooks](development/common-hooks.md)

**修改 Boss 名称**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - Boss 名称修改模式

**修改商店**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 商店 FSM 修改模式

**生成自定义敌人**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 敌人预加载模式

**监听敌人死亡**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 死亡事件订阅模式

**修改场景流程**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 场景状态管理模式

**添加多语言支持**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 文本本地化模式

**添加新护符效果**
→ [Item IDs](core/item-ids.md) → [Code Patterns](development/code-patterns.md)

**修改法术效果**
→ [Spell System](systems/spell-system.md) → [FSM Reference](core/fsm-reference.md)

**修改骨钉技**
→ [Nail Arts](systems/nail-arts.md) → [FSM Reference](core/fsm-reference.md)

**修改伤害计算**
→ [Combat System](systems/combat-system.md) → [Item IDs](core/item-ids.md)

**添加游戏内设置菜单**
→ [Code Patterns](development/code-patterns.md) - 搜索 "Menu"

**优化资源加载**
→ [Resource Management](development/resources.md) → [Preload Names](core/preload-names.md)

**添加新物品**
→ [Item IDs](core/item-ids.md) → [Game Modification Patterns](systems/game-modification-patterns.md) - 商店 FSM 修改模式 → [Code Patterns](development/code-patterns.md)

**修改地图**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 场景状态管理模式 → [Preload Names](core/preload-names.md)

**添加新 NPC**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 文本本地化模式 → [FSM Reference](core/fsm-reference.md) → [Code Patterns](development/code-patterns.md)

**修改存档系统**
→ [Core Classes](core/core-classes.md) - PlayerData → [Code Patterns](development/code-patterns.md) - IGlobalSettings

**添加新成就**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 场景状态管理模式 → [Core Classes](core/core-classes.md) - PlayerData

**修改菜单 UI**
→ [Game Modification Patterns](systems/game-modification-patterns.md) - 商店 FSM 修改模式（参考 UI 修改方法）→ [Code Patterns](development/code-patterns.md) - IMenuMod

**添加新粒子效果**
→ [Code Patterns](development/code-patterns.md) - 动画与特效 → [Resource Management](development/resources.md)

**修改音频/音效**
→ [Audio System](systems/audio-system.md) → [Code Patterns](development/code-patterns.md)

**拦截玩家输入**
→ [Common Hooks](development/common-hooks.md) → [Code Patterns](development/code-patterns.md) - Input Axis Reading

---

## 📖 文档层级

```
hk-api-skill/
├── SKILL.md              # 主入口（Skill 定义）
├── rules/
│   ├── INDEX.md          # 本文档（分类索引）
│   ├── core/             # 核心参考
│   │   ├── core-classes.md
│   │   ├── fsm-reference.md
│   │   ├── item-ids.md
│   │   └── preload-names.md
│   ├── systems/          # 游戏系统
│   │   ├── combat-system.md
│   │   ├── spell-system.md
│   │   ├── nail-arts.md
│   │   ├── audio-system.md
│   │   └── game-modification-patterns.md   # 游戏自带系统修改模式
│   ├── development/      # 开发指南
│   │   ├── common-hooks.md
│   │   ├── code-patterns.md
│   │   ├── resources.md
│   │   └── best-practices.md
│   └── libraries/        # 第三方库
│       └── satchel.md    # Satchel 工具库
└── analysis/             # 分析报告（参考用）
```

---

## 💡 使用提示

1. **从 INDEX.md 开始** - 找到你需要的文档类别
2. **查看代码示例** - 每个文档都有可复制的代码片段
3. **参考 Best Practices** - 避免常见错误
4. **遇到问题？** - 查看 [Common Hooks](development/common-hooks.md) 和 [Code Patterns](development/code-patterns.md)
