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
| [Rogue Systems](systems/rogue-systems.md) | **Roguelike 系统合集**（商店/Boss/波次/物品等 8 个系统） |

### Development（开发指南）

开发工具和最佳实践。

| 文档 | 用途 |
|------|------|
| [Common Hooks](development/common-hooks.md) | 常用 Hook 模式 |
| [Code Patterns](development/code-patterns.md) | 常见代码模式 |
| [Resource Management](development/resources.md) | 资源加载和管理 |
| [Best Practices](development/best-practices.md) | 最佳实践和技巧 |

---

## 🔍 按任务查找

### 我想...

**修改 Boss 行为**
→ [FSM Reference](core/fsm-reference.md) → [Common Hooks](development/common-hooks.md)

**添加新护符效果**
→ [Item IDs](core/item-ids.md) → [Code Patterns](development/code-patterns.md)

**修改法术效果**
→ [Spell System](systems/spell-system.md) → [FSM Reference](core/fsm-reference.md)

**修改骨钉技**
→ [Nail Arts](systems/nail-arts.md) → [FSM Reference](core/fsm-reference.md)

**添加自定义敌人**
→ [Preload Names](core/preload-names.md) → [Code Patterns](development/code-patterns.md)

**修改伤害计算**
→ [Combat System](systems/combat-system.md) → [Item IDs](core/item-ids.md)

**添加游戏内设置菜单**
→ [Code Patterns](development/code-patterns.md) - 搜索 "Menu"

**优化资源加载**
→ [Resource Management](development/resources.md) → [Preload Names](core/preload-names.md)

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
│   │   └── rogue-systems.md   # Roguelike 系统合集
│   └── development/      # 开发指南
│       ├── common-hooks.md
│       ├── code-patterns.md
│       ├── resources.md
│       └── best-practices.md
└── analysis/             # 分析报告（参考用）
```

---

## 💡 使用提示

1. **从 INDEX.md 开始** - 找到你需要的文档类别
2. **查看代码示例** - 每个文档都有可复制的代码片段
3. **参考 Best Practices** - 避免常见错误
4. **遇到问题？** - 查看 [Common Hooks](development/common-hooks.md) 和 [Code Patterns](development/code-patterns.md)
