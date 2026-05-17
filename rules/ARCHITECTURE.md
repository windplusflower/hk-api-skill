# HK API Skill Architecture

## 目标

`hk-api` 采用两层结构，目的是把“默认必须遵守的规范”与“只在需要时才检索的知识”分开，避免主 skill 在每次触发时注入过多上下文。

## 两层模型

### 1. Modding Spec

位置：`rules/modding-spec.md`

作用：

- 这是触发 `hk-api` 时默认全量加载的唯一规则文档。
- 只放跨任务、稳定、默认应遵守的规范。
- 如果某条内容更像“工作约束”而不是“领域知识”，优先考虑放在这里。

适合放入的内容：

- 日志规范
- 内嵌资源规范
- 预加载与资源来源规范
- 构建与依赖规范
- 输入读取规范
- FSM 查询规范
- FSM 与自定义状态机选型规范
- 知识回填规范

### 2. Modding Knowledge

位置：`rules/**`、`fsm-index/**`、`fsm-export/**`、`scene-index/**`、`hkapi/**`、`scripts/**`

作用：

- 只在问题需要时渐进查阅。
- 默认不应整批预读。
- 应按任务类型精准打开最少必要文档。

适合放入的内容：

- 类、方法、字段、调用链细节
- Boss / 场景 / GameObject / FSM 具体结构
- 场景物体的位置 / collider / hierarchy（走 `scene-index/scene-objects.tsv`，需要细节时用 `scripts/dump_gameobject.py` 生成 `scene-cache/`）
- preload 名、item id、对象链路
- 战斗、法术、音频、商店等系统知识
- `RingLib`、`Satchel` 等库的细节用法

### Lazy-dump 子模式

`scene-index/` 与 `scripts/dump_gameobject.py` 配对体现了「轻索引 + 按需 dump」的子架构：

- 静态索引（committed）只覆盖能廉价拿到的字段（位置 / 类型 / 数量）
- 完整组件细节按 `(scene, pathid)` 在查询时生成，写入 `scene-cache/`（regenerable，不入库）

任何未来「全量预 dump 体积过大但单点查询频率低」的数据都可以参照这个模式接入。

## 默认工作流

1. 触发 `hk-api`
2. 先应用 `rules/modding-spec.md`
3. 判断问题属于哪一类：API、FSM、系统机制、资源/构建、自定义状态机
4. 只打开与当前问题直接相关的知识文档
5. 如果规则层和知识层都不足，再读 `hkapi/**` 或 `fsm-export/**`
6. 若形成稳定新知识，按知识回填规范沉淀回 skill

## 维护原则

1. 不要把大量具体知识重新堆回 `SKILL.md`。
2. `SKILL.md` 应保持为调度入口，而不是百科正文。
3. 新增内容时，先判断它属于“Spec”还是“Knowledge”。
4. 相同内容尽量保存在单一知识源，通过链接引用，不要复制粘贴。
5. 如果某条知识被反复跨任务使用，并且更像通用约束，可以考虑提升进 `modding-spec.md`。
