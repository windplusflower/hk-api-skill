# HK API Skill 索引结构检查报告

**检查日期**: 2026-03-08  
**检查人**: Subagent  
**检查范围**: `/home/windflower/.openclaw/workspace/HollowKnight/hk-api-skill/rules/`

---

## 一、索引结构评估

### 1.1 整体结构

索引采用四层分类结构：
- **Core**（核心参考）- 基础 API 和数据结构
- **Systems**（游戏系统）- 特定游戏系统的修改方法
- **Development**（开发指南）- 开发工具和最佳实践
- **Libraries**（第三方库）- 常用第三方库使用指南

### 1.2 分类清晰度评估

| 分类 | 清晰度 | 评估说明 |
|------|--------|----------|
| Core | ⭐⭐⭐⭐⭐ | 明确：核心类、FSM、物品ID、预加载名 |
| Systems | ⭐⭐⭐⭐ | 较清晰，但 `game-modification-patterns.md` 内容过于庞大 |
| Development | ⭐⭐⭐⭐⭐ | 明确：Hooks、代码模式、资源、最佳实践 |
| Libraries | ⭐⭐⭐⭐⭐ | 明确：Satchel 库相关文档 |

### 1.3 快速导航评估

**优点**:
- 提供了"新手入门"阅读路径
- "按任务查找"表格非常实用
- 文档层级图清晰展示文件结构

**问题**:
- "按任务查找"只覆盖了 12 个场景，不够全面
- 缺少反向索引（从文档找相关任务）

---

## 二、发现的问题列表

### 2.1 分类重叠/模糊问题

#### 问题 1: `code-patterns.md` 与 `game-modification-patterns.md` 边界模糊

**描述**:
- `code-patterns.md` 包含 FSM 相关模式（FSM Injection、FSM State Copying 等）
- `game-modification-patterns.md` 也包含大量 FSM 操作（商店 FSM 修改、Boss FSM 修改等）

**影响**: 用户不确定应该在哪个文档查找 FSM 相关内容

**建议**:
- `code-patterns.md` 应聚焦于**纯代码模式**（不涉及具体游戏系统）
- `game-modification-patterns.md` 聚焦于**游戏系统特定的修改模式**
- 在 `code-patterns.md` 中添加注释说明："具体 FSM 修改场景请参见 game-modification-patterns.md"

#### 问题 2: `common-hooks.md` 与 `code-patterns.md` 有重叠

**描述**:
- `common-hooks.md` 包含 Hook 类型和常用 Hook 列表
- `code-patterns.md` 也包含 Hook Injection Pattern、Hook Interception Pattern

**影响**: Hook 相关内容分散在两个文档

**建议**:
- `common-hooks.md` 作为**参考手册**（列举所有可用 Hooks）
- `code-patterns.md` 作为**模式指南**（如何使用 Hooks 的代码示例）
- 在 `code-patterns.md` 的 Hook 模式部分添加链接："可用 Hooks 列表参见 common-hooks.md"

### 2.2 内容重复问题

#### 问题 3: 护符检测代码重复

**重复内容**: 护符检测和伤害计算代码

**出现位置**:
1. `core/core-classes.md` - PlayerData 部分
2. `code-patterns.md` - 伤害计算模式
3. `core/item-ids.md` - 伤害倍数计算示例

**重复程度**: 高度重复，代码几乎相同

**建议**:
- 保留 `core/item-ids.md` 作为主要参考（因为这是"物品ID"文档）
- `core-classes.md` 中简化为引用："护符检测示例参见 item-ids.md"
- `code-patterns.md` 中简化为引用："伤害计算模式参见 item-ids.md"

#### 问题 4: FSM 操作代码重复

**重复内容**: FSM 注入、状态复制、过渡修改

**出现位置**:
1. `code-patterns.md` - FSM 相关模式
2. `game-modification-patterns.md` - 商店/Boss 修改示例
3. `core/fsm-reference.md` - 代码示例部分

**重复程度**: 中等重复，示例代码相似

**建议**:
- `core/fsm-reference.md` 作为**快速参考**，保留简洁示例
- `code-patterns.md` 作为**通用模式**，保留完整模式说明
- `game-modification-patterns.md` 作为**场景应用**，引用前两者

#### 问题 5: Satchel 内容重复

**重复内容**: Satchel 的 FUtils 使用方法

**出现位置**:
1. `libraries/satchel.md` - FUtils 部分
2. `game-modification-patterns.md` - 商店修改示例中使用了 Satchel 方法

**评估**: 这不是真正的重复，`game-modification-patterns.md` 使用的是标准 FSM 方法（非 Satchel 特有）

**状态**: ✅ 无问题

### 2.3 导航完整性问题

#### 问题 6: 文档未被索引

**检查方法**: 对比 `INDEX.md` 中的文档层级图与实际文件

**结果**:
- `libraries/satchel-src-index.md` 在索引中列出 ✅
- `EVOLUTION.md` 和 `EVOLUTION_LOG.md` 未被索引 ⚠️

**建议**:
- `EVOLUTION.md` 和 `EVOLUTION_LOG.md` 是元文档，不需要在规则索引中列出
- 但应在 SKILL.md 中提及（如果尚未提及）

#### 问题 7: 缺少文档间交叉引用

**描述**: 相关文档之间缺少链接

**具体缺失**:
- `core/core-classes.md` 中的 HealthManager 应该链接到 `game-modification-patterns.md` 的 Boss 修改模式
- `systems/spell-system.md` 应该链接到 `code-patterns.md` 的 FSM 注入模式
- `systems/nail-arts.md` 应该链接到 `code-patterns.md` 的 FSM 注入模式

---

## 三、通用范式合规性检查

### 3.1 检查原则

**应该包含**:
- ✅ 类别 1: 如何使用和修改游戏内已有的组件（HeroController、HealthManager、FSM 等）
- ✅ 类别 2: 如何创建和引入全新的自定义组件（自定义 MonoBehaviour、新 FSM 等）

**不应该包含**:
- ❌ 如何使用特定 Mod 内别人自定义的组件（无法复用）
- ❌ 特定 Mod 的业务逻辑（与具体 Mod 强耦合）

### 3.2 各文档合规性评估

| 文档 | 类别 | 合规性 | 说明 |
|------|------|--------|------|
| `core/core-classes.md` | 类别 1 | ✅ 合规 | 只包含游戏原生类 |
| `core/fsm-reference.md` | 类别 1 | ✅ 合规 | 只包含游戏原生 FSM |
| `core/item-ids.md` | 类别 1 | ✅ 合规 | 只包含游戏原生 ID |
| `core/preload-names.md` | 类别 1 | ✅ 合规 | 只包含游戏原生对象 |
| `systems/combat-system.md` | 类别 1 | ✅ 合规 | 只包含游戏战斗系统 |
| `systems/spell-system.md` | 类别 1 | ✅ 合规 | 只包含游戏法术系统 |
| `systems/nail-arts.md` | 类别 1 | ✅ 合规 | 只包含游戏骨钉技系统 |
| `systems/audio-system.md` | 类别 1+2 | ✅ 合规 | 通用音频管理 |
| `systems/game-modification-patterns.md` | 类别 1 | ✅ 合规 | 修改游戏自带系统 |
| `development/common-hooks.md` | 类别 1 | ✅ 合规 | 游戏 Hook 点 |
| `development/code-patterns.md` | 类别 1+2 | ✅ 合规 | 通用代码模式 |
| `development/resources.md` | 类别 2 | ✅ 合规 | 资源管理通用模式 |
| `development/best-practices.md` | 类别 1+2 | ✅ 合规 | 通用最佳实践 |
| `libraries/satchel.md` | 第三方库 | ✅ 合规 | 第三方库使用指南 |
| `libraries/satchel-src-index.md` | 第三方库 | ✅ 合规 | 源码索引 |

### 3.3 合规性结论

**✅ 所有文档均符合通用范式原则**

未发现包含特定 Mod 自定义组件或业务逻辑的内容。

---

## 四、改进建议汇总

### 4.1 高优先级

1. **解决内容重复问题**
   - 统一护符检测代码到 `item-ids.md`
   - 在重复位置添加交叉引用而非复制代码

2. **明确文档边界**
   - 在 `code-patterns.md` 和 `game-modification-patterns.md` 之间建立清晰的边界
   - 添加注释说明每个文档的适用范围

### 4.2 中优先级

3. **增强交叉引用**
   - 在相关文档之间添加链接
   - 特别是 FSM 相关文档之间

4. **扩展"按任务查找"**
   - 增加更多常见任务场景
   - 考虑添加搜索关键词索引

### 4.3 低优先级

5. **优化 `game-modification-patterns.md` 结构**
   - 当前 8 个模式都在一个文档中，篇幅较长
   - 可考虑按系统拆分（Boss/商店/敌人/场景）

---

## 五、内容重复情况总结

| 重复内容 | 涉及文档 | 严重程度 | 建议处理 |
|----------|----------|----------|----------|
| 护符检测代码 | core-classes, code-patterns, item-ids | 高 | 统一到 item-ids.md |
| FSM 操作示例 | fsm-reference, code-patterns, game-modification-patterns | 中 | 建立层次关系 |
| 伤害计算模式 | code-patterns, item-ids | 中 | 统一到 item-ids.md |
| HealthManager 使用 | core-classes, game-modification-patterns | 低 | 保留各自上下文 |

---

## 六、需要改进的问题清单

### 立即处理（本周）
- [ ] 统一护符检测代码到 `item-ids.md`
- [ ] 在 `code-patterns.md` 和 `game-modification-patterns.md` 中添加边界说明

### 短期处理（本月）
- [ ] 在 FSM 相关文档之间添加交叉引用
- [ ] 扩展"按任务查找"覆盖更多场景
- [ ] 在重复代码位置添加引用注释

### 长期考虑（按需）
- [ ] 评估是否拆分 `game-modification-patterns.md`
- [ ] 添加搜索关键词索引
- [ ] 考虑添加文档版本历史

---

## 七、检查规则保存位置

检查规则已保存至:
```
/home/windflower/.openclaw/workspace/HollowKnight/hk-api-skill/rules/CHECKLIST.md
```

---

## 附录：文档清单

**已审查文档**（15个）:
1. `rules/INDEX.md`
2. `rules/core/core-classes.md`
3. `rules/core/fsm-reference.md`
4. `rules/core/item-ids.md`
5. `rules/core/preload-names.md`
6. `rules/systems/combat-system.md`
7. `rules/systems/spell-system.md`
8. `rules/systems/nail-arts.md`
9. `rules/systems/audio-system.md`
10. `rules/systems/game-modification-patterns.md`
11. `rules/development/common-hooks.md`
12. `rules/development/code-patterns.md`
13. `rules/development/resources.md`
14. `rules/development/best-practices.md`
15. `rules/libraries/satchel.md`
16. `rules/libraries/satchel-src-index.md`

**未审查文档**（元文档）:
- `SKILL.md` - Skill 定义主入口
- `EVOLUTION.md` - 演进规划
- `EVOLUTION_LOG.md` - 演进日志
