# Evolution Note - 2026-05-16 09:25:43

- Question: 场景内 GameObject 列表 / 位置 / collider 大小如何静态查询？
- Target: `rules/INDEX.md`
- Risk: `low`
- Status: `applied to target rule`
- Marker: `<!-- evolution:e490a98c975e -->`

## Learned Facts

- Hollow Knight 关卡序列化在 hollow_knight_Data/levelN，N 与 globalgamemanagers.BuildSettings 索引一致 (501 scenes)。
- 用 UnityPy 读 levelN 可枚举所有 GameObject + Transform/Collider2D/Renderer 字段，但 MonoBehaviour 的 m_Script 类名解析需要跨文件 env，否则失败。
- 新增 scene-index/scene-objects.tsv 静态索引：scene/go_path/pathid/world_pos/collider/renderer/fsm_count，~MB 体量，覆盖所有场景静态 GO。
- fsm_count 通过解析 fsm-export/.../*.md 的 GameObject PathId 与 GO 精确 join，不能用名字 join（短名如 White_Flash 会过度匹配）。
- scripts/dump_gameobject.py 按 (scene, pathid) 在查询时生成单 GO 完整组件 markdown，写入 scene-cache/，避免全量预 dump。
- 运行时 Instantiate 出来的 GO（投射物、spawn 出来的敌人、DontDestroyOnLoad 上下文）静态拿不到，需 UnityExplorer mod。

## Sources

- `scripts/rebuild_scene_index.py:1`
- `scripts/dump_gameobject.py:1`
- `scene-index/README.md:1`
