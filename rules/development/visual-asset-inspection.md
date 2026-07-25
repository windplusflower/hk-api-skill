---
title: Visual Asset Inspection
impact: MEDIUM
impactDescription: Use this when you need Hollow Knight's real in-game textures, atlases, or animation source frames rather than FSM-only logic data
tags: hk-api, texture, atlas, sprite, tk2d, UnityPy, AssetRipper
---

## Visual Asset Inspection

规范层入口：先遵守 [Modding Spec](../modding-spec.md) 里的“预加载与资源来源规范”。

本文件回答的是“游戏里原本那张图到底是什么”。如果问题只是“什么时候播这个动作”“这个 Boss 开局先跳还是先劈”，先去查 `fsm-export/`；如果问题是“原贴图长什么样”“这个 clip 对应哪几帧”“我改图前要先看到原 atlas”，按本流程走。

## 什么时候用

- 用户明确要看游戏原本贴图、atlas、动画帧
- 需要确认自己画的替换资源是否贴近原版
- 需要把某个 FSM / 动作名对应到真实画面素材
- 需要从 vanilla 资源里抠出某个敌人、武器、斩击特效

## 工具分工

- `fsm-export/`: 只回答逻辑、状态、变量、事件、动作名；不回答贴图画面本身
- `scene-index/scene-objects.tsv`: 先锁定 scene、GO 路径、`pathid`、renderer 类型
- `scripts/dump_gameobject.py`: 快速看单个 GO 的静态组件信息，尤其是 collider / renderer / `SpriteRenderer.m_Sprite`
- `UnityExplorer`: 运行时看当前 clip、当前对象、运行时 spawn 出来的物体
- `UnityPy` / `AssetRipper`: 离线追材质、sprite、atlas、Texture2D 并导出真实图片

## 推荐流程

### 1. 先锁定 scene 和目标 GO

不要一上来就按敌人名猜贴图文件名。

推荐顺序：

1. 用 `fsm-export/` 确认 scene、FSM、动作名
2. 回到 `scene-index/scene-objects.tsv` 找该 scene 里的主体 GO、子物体和武器/特效物体
3. 需要组件细节时，再用 `scripts/dump_gameobject.py --scene X --pathid N`

如果对象是运行时 `Instantiate` 出来的，静态索引通常不够，要改用 `UnityExplorer` 看 live 对象。

### 2. 先判断它走哪条渲染链

不要默认所有对象都是 `SpriteRenderer`。

- **普通 SpriteRenderer 链**：直接从 `m_Sprite` 往下追
- **tk2d / MeshRenderer 链**：很多 HK 角色主体走的是 `MeshRenderer` + `tk2d`，不会直接给你一个可用的 `SpriteRenderer`

这是个关键分叉。像主角、Boss、本体角色经常属于第二类。

### 3. 如果是 SpriteRenderer，沿 sprite 直接找纹理

常见链路：

`SpriteRenderer.m_Sprite -> Sprite.m_RD.texture -> Texture2D`

这条线最直接，适合武器、单独挂件、部分静态装饰。

### 4. 如果是 tk2d / MeshRenderer，沿 collection / material 找 atlas

常见链路有两种：

1. **按动画帧追**
   - `tk2dSpriteAnimationFrame` 里有 `spriteCollection` 和 `spriteId`
   - 再去对应 collection 的 `spriteDefinitions[spriteId]`
   - 从 definition 的材质 / 纹理反查 atlas

2. **按当前渲染材质追**
   - 当前 `Renderer.material`
   - 对应 `materialInst`
   - 材质的 `_MainTex`
   - 再导出该 `Texture2D`

对于 HK 的 tk2d 角色，第二条经常比“按名字搜 sprite”更稳。

## 实操判断准则

### 不要只信资源名

Hollow Knight 里非常常见这种名字：

- `atlas0`
- `atlas0 material`
- 没有敌人名的通用材质名

所以不要靠“搜到一个像是 God Tamer 的文件名”就当答案。优先信：

- 当前 GO 的 live renderer / material 关联
- 当前 sprite / frame 的 PPtr 关联
- 当前 scene 内已经锁定的 GO 链路

### `path_id` 不能跨文件单独用

`path_id` 只在单个 assets file 里唯一。跨文件会重复。

离线探资源时，至少用下面这个键：

`(assets_file.name, path_id)`

否则很容易把别的文件里的同号对象误认成目标对象。

### 窄环境里跨文件 PPtr 可能会断

如果只加载一个很窄的 `levelN` 环境，`MonoScript`、材质、sprite、甚至某些 `MonoBehaviour` 可能解析不全。

遇到这种情况：

- 先尝试加载更宽的 UnityPy 环境
- 或者直接改用 `AssetRipper`

不要把“解析不到”误判成“资源不存在”。

## 一个稳妥的最小流程

1. 用 `fsm-export/` 锁动作名和 scene
2. 用 `scene-index/scene-objects.tsv` 找主体 GO 和武器/特效子物体
3. 用 `dump_gameobject.py` 先判断是 `SpriteRenderer` 还是 `MeshRenderer`
4. `SpriteRenderer` 就追 `m_Sprite`
5. `tk2d / MeshRenderer` 就追当前材质或 `spriteCollection + spriteId`
6. 导出整张 atlas，再按需要裁帧
7. 需要确认“当前播到哪帧”时，用 `UnityExplorer` 对照 live 对象

## 常见误区

- 还没看到原 atlas，就先按印象重画
- 把 `fsm-export/` 当成贴图数据源
- 把只有渲染碎片的子物体当成本体
- 看到 `SpriteRenderer` 子物体就以为主体也走 SpriteRenderer
- 用全局唯一方式保存 `path_id`
- 只搜名字，不顺着 live renderer / material / PPtr 去追

## 对现有脚本的预期

当前 `scripts/dump_gameobject.py` 很适合做第一层静态确认，但它现成暴露得最直接的是 `SpriteRenderer.m_Sprite`。如果目标对象主体是 tk2d / MeshRenderer，本脚本给你的更多是“确认渲染链类型”，而不是一步到位导出 atlas。

这时就该切到 `UnityPy` 或 `AssetRipper`，而不是继续死磕 `dump_gameobject.py` 的输出。

### Fallback Learning (2026-05-31)
<!-- evolution:7c8076726fa2 -->
- Question: 如何获取 Hollow Knight 游戏实际贴图而不是凭名字猜图？
- Facts:
  - 先用 scene-index 或 FSM 数据锁定 scene、GameObject 路径和 pathid，再顺着该对象当前的渲染链找真实贴图；不要只按动画名或敌人名猜资源名。
  - dump_gameobject.py 现成能读出 SpriteRenderer.m_Sprite，但很多 Hollow Knight 角色主体是 MeshRenderer + tk2d 链路，不会直接暴露成 SpriteRenderer。
  - tk2dSpriteAnimationFrame 持有 spriteCollection 与 spriteId，tk2dBaseSprite.SetSprite() 会切换 collection/id，tk2dSprite.UpdateMaterial() 再把当前 spriteDefinition 的 materialInst 设给 Renderer；因此实际 atlas 往往应从当前 material/texture 反查。
  - 用 UnityPy 探资源时，path_id 只在单个 assets file 内唯一，跨文件会重复；做对象映射时要至少用 (assets_file.name, path_id) 作为键。
  - 跨文件 PPtr 在窄环境里可能解析失败；需要更宽的 UnityPy env 或直接用 AssetRipper 做离线资源检查。
- Sources:
  - `rules/INDEX.md:47-56`
  - `scripts/dump_gameobject.py:150-161`
  - `scripts/rebuild_scene_index.py:155-164`
  - `hkapi/tk2dBaseSprite.cs:205-223`
  - `hkapi/tk2dSprite.cs:192-198`
  - `hkapi/tk2dSpriteAnimationFrame.cs:50-53`
