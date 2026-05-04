# FSM Index

这一目录是 `fsm-export/` 的导航层，方便在不全量翻目录的情况下定位 Hollow Knight 的 PlayMaker FSM 导出文件。

## Contents

- [`fsm-manifest.tsv`](./fsm-manifest.tsv): 24701 条 FSM 索引，字段为 `group, scene, gameobject_segment, fsm_name, fsm_id, relative_path, source_asset, content_hash`。
- [`scene-summary.md`](./scene-summary.md): 当前导出的按区域和场景汇总入口。
- [`boss-shortcuts.md`](./boss-shortcuts.md): 当前导出的 Boss / 战斗场景快捷入口。

## Dataset

- Source root: [`../fsm-export/`](../fsm-export/)
- Total FSM files: 24701
- Total groups: 23
- Total scenes: scene 目录现按当前导出使用的 Unity scene 文件名组织，例如 `Abyss_01.unity`、`GG_Vengefly.unity`

## Manifest Columns

| Column | Meaning |
| --- | --- |
| `group` | 大区域分组，例如 `Greenpath`、`Dreams`、`Godhome`。 |
| `scene` | 场景名，通常对应 Unity scene / assets 导出目录。 |
| `gameobject_segment` | 文件名前半段，对应导出时的 GameObject 路径片段。 |
| `fsm_name` | FSM 名。查 `LocateMyFSM(...)` 时通常先看这一列。 |
| `fsm_id` | PlayMaker FSM PathId，用于唯一定位同名实例。 |
| `relative_path` | 相对 `fsm-export/` 根目录的 Markdown 路径。 |
| `source_asset` | 原始资源文件路径。 |
| `content_hash` | 导出内容哈希，用于比较内容是否变化。 |

## Query Workflow

1. 已知 Boss / 战斗场景：优先查 [`fsm-manifest.tsv`](./fsm-manifest.tsv)，再用 [`boss-shortcuts.md`](./boss-shortcuts.md) 快速浏览候选。
2. 已知场景但不知道文件名：优先直接搜索 [`fsm-manifest.tsv`](./fsm-manifest.tsv) 里的 `scene` 列。当前 scene 多为 Unity scene 文件名。
3. 已知 GameObject 或 FSM 名：直接在 [`fsm-manifest.tsv`](./fsm-manifest.tsv) 上做文本搜索。
4. 需要动作、变量、状态细节：打开 `../fsm-export/<group>/<scene>/<file>.md`。

## Example Searches

```bash
rg -n $'\tControl\t' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
rg -n 'Hornet|Grimm|Radiance' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
rg -n 'GG_Vengefly|GG_Hornet_1|Dream_Final_Boss' /home/windflower/.codex/skills/hk-api/fsm-index/fsm-manifest.tsv
```
