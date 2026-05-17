---
title: HK Modding Spec
impact: HIGH
impactDescription: Always-loaded conventions for Hollow Knight mod work
tags: hk-api, spec, logging, embedded-resource, preload, build
---

# Modding Spec

这个文档是 `hk-api` skill 里应全量加载的 Modding 规范层。

目标不是覆盖所有 Hollow Knight modding 知识，而是定义在大多数实现任务中都应默认遵守的稳定约束。具体 API、FSM、系统行为、Boss 机制等知识，仍应通过 `rules/**`、`fsm-index/**`、`fsm-export/**` 和 `hkapi/**` 按需渐进查阅。

## 1. 日志规范

把日志当作 HK mod 的一等调试接口，而不是可有可无的附属品。

1. 开发中必须添加足够详细的调试日志，至少覆盖初始化、Hook 注册与命中、FSM 或状态切换、关键分支、对象生成/销毁、失败路径和提前返回路径。
2. 代码日志默认优先使用 Modding API 日志接口，例如 `Log(...)`、`LogDebug(...)`、`LogWarn(...)`、`LogError(...)` 或 `Modding.Logger.*`。
3. 不要把 `UnityEngine.Debug.Log*` 作为 mod 业务日志的主通道，除非问题本身就是 Unity 引擎层诊断。
4. 日常排障优先使用 `Debug` 构建并保留详细 `LogDebug(...)`；`Release` 构建不应持续输出常规调试噪音。
5. 排查“功能没生效”时，优先看 `ModLog.txt`，`Player.log` 只作为补充。
6. Windows 上常见 `ModLog.txt` 路径是 `C:\Users\33361\AppData\LocalLow\Team Cherry\Hollow Knight\ModLog.txt`。

## 2. 内嵌资源规范

mod 自带图片、音频和类似静态资源，默认使用程序集内嵌资源 `EmbeddedResource`。

1. 不要依赖运行时从磁盘查找资源文件。
2. 不要写 `File.Exists(...)`、遍历目录、按开发环境/发布环境切换路径之类的回退逻辑。
3. 资源名应在代码中稳定映射到程序集资源名；加载失败时记录清晰日志，并按需失败，不再继续尝试文件系统回退。
4. 资源目录和命名规则应尽量固定，避免后续引入路径探测和多分支兼容逻辑。

## 3. 预加载与资源来源规范

当需要游戏内现成对象、Prefab 或 FSM 挂载对象时，默认优先走预加载和已知对象来源，而不是运行时盲搜。

1. 需要复用游戏对象时，优先通过 `GetPreloadNames()` 和 `Initialize(Dictionary<string, Dictionary<string, GameObject>> preloadedObjects)` 获取。
2. 需要定位预加载对象名时，优先查 `rules/core/preload-names.md` 或从已知 FSM/对象链路推导。
3. 需要从预加载对象进一步拿嵌套对象、FSM 动作里的 `gameObject` 引用时，可以沿已知 FSM 动作链提取，但要保留清晰日志。
4. 不要默认写运行时全场景扫描或模糊名称猜测来替代稳定的 preload 来源。
5. 检索“游戏内一个物品 / 可见对象”时，不要先验假设它等于一个完整、集中的单一 `GameObject`。HK 里一个视觉上固定的物品，常常是多个零散对象叠加出来的结果，例如独立碰撞箱、本体子物体装饰、父物体上的部分装饰，甚至场景里额外摆放的装饰物。
6. 因此，查物品相关对象时要把“视觉呈现”和“逻辑 / 碰撞 / 装饰归属”拆开验证：优先分别确认交互碰撞箱、主显示对象、父子层级装饰、关联 FSM，以及附近是否有独立场景装饰，不要因为名字相近或视觉上挨在一起就认定它们属于同一个 GO 树。
7. 除非用户明确表达“找贴图”“找纯装饰”“只看显示层”之类意图，否则默认寻找的目标 `GameObject` 至少应具备可用碰撞体积，或能明确挂靠到承担碰撞/交互职责的对象；不要把只有渲染、没有 collider 的纯视觉碎片直接当成用户要找的物品本体。

## 4. 构建与依赖规范

新建或维护 HK mod 项目时，构建系统默认遵守以下约束。

1. 优先引用用户机器上已经存在的真实 DLL。
2. 如果 HK Modding API 已安装到游戏目录，默认把 `Managed/Assembly-CSharp.dll` 视为已包含 Modding API surface 的目标程序集。
3. 不要先验假设一定存在独立 `Modding.dll`，除非仓库或用户明确证明。
4. 机器相关路径应放入本地未跟踪配置，例如 `LocalBuildProperties.props`。
5. 正常构建应自动把 mod 输出和生成 zip 安装到 `Managed/Mods/<ModName>`。

## 5. 输入读取规范

涉及实时玩家输入的逻辑，默认遵守 HK 原生输入链路。

1. 优先使用 `InputHandler.Instance?.inputActions` 或 `HeroActions`。
2. 不要默认使用 `UnityEngine.Input.GetAxisRaw()` 处理法术、攻击、骨钉技等 gameplay 输入判断。
3. 如果注入的 FSM action 早于 `ListenForUp`、`ListenForDown` 等监听动作，不要信任 FSM 布尔量如 `Pressed Up`，而应直接读取当前 `inputActions`。

## 6. FSM 与自定义状态机选型规范

不要默认把所有行为问题都塞进一个工具里；先判断是小修补，还是完整接管。

1. 如果目标行为本来就在游戏 FSM 里，且只需要小范围修改，优先保留并修改原 `PlayMakerFSM`。
2. 如果任务是状态编辑、转移改写、插入 action、变量微调，优先用 FSM patch。
3. 如果任务变成“自己管理一个复杂行为系统”，应优先评估 `RingLib` 这类自定义 C# 状态机方案，而不是继续堆叠 `Update()`、`switch`、大量零散协程。
4. 新 Boss、新敌人、新 projectile 控制器、多阶段战斗流、复杂打断逻辑，默认都应先评估 `RingLib`。
5. 对 Boss 或敌人主行为接管，默认优先 `EntityStateMachine`，并把宿主抓取、旧 FSM 禁用、接管准备等初始化放在 `EntityStateMachineStart()` 一侧完成。

## 7. FSM 查询规范

查询 PlayMaker FSM 时，优先查本地导出数据，不要先凭经验猜 C# 代码位置。

1. 先查 `fsm-index/fsm-manifest.tsv`。
2. 如果已知 Boss 或战斗场景，再看 `fsm-index/boss-shortcuts.md`。
3. 如果已知 scene，再看 `fsm-index/scene-summary.md`。
4. 命中后再打开 `fsm-export/<group>/<scene>/<file>.md` 看完整状态、动作、变量、事件与转移。
5. 同名 FSM 很常见，必须联合 `scene + gameobject_segment + fsm_id` 判断。

## 8. 知识回填规范

当现有规则层回答不了问题，而必须回退到 `hkapi/**` 源码查证时，应把新知识沉淀回 skill。

1. 先确认是规则缺口，而不是自己没查到。
2. 读源码并回答用户问题。
3. 抽取 3 到 8 条带精确来源的事实。
4. 使用 `scripts/evolution_record.py` 记录。
5. 低风险知识可以直接追加到目标规则文档；高风险知识只写 pending，等待确认。

## 适合放入 Modding Spec 的内容范围

除了日志规范和内嵌资源规范，以下内容也适合放入 Modding Spec，因为它们属于跨任务、稳定、应默认遵守的工作约束：

- 预加载与资源来源规范
- 构建与依赖规范
- 输入读取规范
- FSM 与自定义状态机选型规范
- FSM 查询规范
- 知识回填规范

不适合放入 Modding Spec 的内容通常是“具体知识层”而非“规范层”，例如：

- 某个 Boss 的具体 FSM 结构
- 某个类的成员细节与调用链
- 某个系统的机制实现细节
- 某个库的详细 API 用法

这些内容应继续保留在按需查阅的 Modding Knowledge 层。
